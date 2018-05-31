using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
//using Emgu.CV.CvEnum;



namespace Project
{
    public partial class LiveVideo : Form
    {
        
        private FilterInfoCollection webcam;
        private VideoCaptureDevice videoSource;
        private Capture capture;
        private CascadeClassifier classifier;
        private Bitmap faceDetected;
        private Graphics painter;
        Image<Gray, byte> capturedImg;
        Image<Gray, byte> DBImg;
        int index = -1;
        double check = 0, comp1 = 0;
        DenseHistogram hist1, hist2;
        Mat mat1, mat2;
        DBConnector db;
        DataTable dt;
        
        
        public LiveVideo()
        {
            try
            {

                db = new DBConnector();
                dt = new DataTable();

                classifier = new CascadeClassifier("haarcascade_frontalface_default.xml");    //the xm file for face detection, added along with opencv and wrapper class EmguCV

                videoSource = new VideoCaptureDevice();
            }
            catch(FieldAccessException file)
            {
                MessageBox.Show(file.Message);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo videoDevice in webcam)
            {
                cmbVideoDevices.Items.Add(videoDevice.Name);
            }
            if (cmbVideoDevices.Items.Count > 0)
            {
                cmbVideoDevices.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No video sources found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //videoSource = new VideoCaptureDevice(webcam[cmbVideoDevices.SelectedIndex].MonikerString);
            //videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            //videoSource.Start();
            capture = new Capture();
            if (capture != null)
                    Application.Idle += ProcessImage;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbVideo.Image = bitmap;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pbCapturedImg.Image = faceDetected;
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                dt = db.GetData();
                if (videoSource.IsRunning || capture != null)
                {
                    videoSource.Stop();
                    //capture.Dispose();
                }
                Detection();
                //transferring the image into the next form i-e Picture Comparison
                PictureComparison obj = new PictureComparison();
                obj.img = new Image<Gray, byte>(faceDetected);

                obj.histogramBox1.ClearHistogram();
                obj.histogramBox1.AddHistogram("Picture histogram", Color.Blue, mat1, 256, new float[] { 0.0f, 255.0f });
                obj.histogramBox1.Refresh();
                obj.SetIndex(index + 1);

                if (index > -1)
                {

                    obj.histogramBox2.ClearHistogram();
                    obj.histogramBox2.AddHistogram("Picture histogram", Color.Blue, mat2, 256, new float[] { 0.0f, 255.0f });
                    obj.histogramBox2.Refresh();

                    obj.img1 = new Image<Gray, byte>(dt.Rows[index].ItemArray[0].ToString());
                }
                obj.Show();
                this.Hide();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //method for detecting face from the frame and putting a rectangle around the face
        private void ProcessImage(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, Byte> imageFrame = new Image<Bgr, byte>(capture.QueryFrame().Bitmap);
                if (imageFrame != null)
                {
                    Image<Gray, byte> grayFrame = imageFrame.Convert<Gray, byte>();
                    Rectangle[] faces = classifier.DetectMultiScale(grayFrame, 1.2, 4);
                    foreach (var face in faces)
                    {
                        imageFrame.Draw(face, new Bgr(Color.Green), 3);
                        faceDetected = new Bitmap(face.Width, face.Height);    //storing face which is in the rectangle of specified height and width
                        painter = Graphics.FromImage(faceDetected);
                        painter.DrawImage(grayFrame.Bitmap, 0, 0, face, GraphicsUnit.Pixel);
                    }
                }

                pbVideo.Image = imageFrame.Bitmap;
            }catch(Exception ee)
            { MessageBox.Show(ee.Message); }
        }
        public void Detection()
        {
            try
            {
                check = comp1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    capturedImg = new Image<Gray, byte>(faceDetected);
                    DBImg = new Image<Gray, byte>((dt.Rows[i].ItemArray[0]).ToString());

                    hist1 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
                    hist2 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));

                    hist1.Calculate(new Image<Gray, byte>[] { capturedImg }, false, null);
                    hist2.Calculate(new Image<Gray, byte>[] { DBImg }, false, null);

                    mat1 = new Mat();
                    hist1.CopyTo(mat1);
                    mat2 = new Mat();
                    hist2.CopyTo(mat2);


                    comp1 = CvInvoke.CompareHist(mat1, mat2, Emgu.CV.CvEnum.HistogramCompMethod.Bhattacharyya);
                    if (comp1 > check)
                    {
                        check = comp1;
                        index = i;

                    }

                }
                MessageBox.Show(check + " " + index.ToString());
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
