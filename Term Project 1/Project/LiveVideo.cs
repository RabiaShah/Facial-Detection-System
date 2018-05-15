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
        
        
        public LiveVideo()
        {
            
            classifier = new CascadeClassifier("haarcascade_frontalface_default.xml");    //the xml file for face detection, added along with opencv and wrapper class EmguCV
            videoSource = new VideoCaptureDevice();
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
            PictureComparison obj = new PictureComparison();
            obj.Show();
            this.Hide();
            if(videoSource.IsRunning || capture!=null)
            {
                videoSource.Stop();
                //capture.Dispose();
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //method for detecting face from the frame and putting a rectangle around the face
        private void ProcessImage(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imageFrame = new Image<Bgr,byte>(capture.QueryFrame().Bitmap);
            if (imageFrame != null)
            {
                Image<Gray, byte> grayFrame = imageFrame.Convert<Gray, byte>();
                Rectangle[] faces = classifier.DetectMultiScale(grayFrame, 1.2, 4);
                foreach (var face in faces)
                {
                    imageFrame.Draw(face, new Bgr(Color.Green), 3);
                    faceDetected = new Bitmap(face.Width, face.Height);    //storing face which is in the rectangle of specified height and width
                    painter = Graphics.FromImage(faceDetected);
                    painter.DrawImage(grayFrame.Bitmap, 0, 0, face,GraphicsUnit.Pixel);
                }
            }

            pbVideo.Image = imageFrame.Bitmap;    
        }
    }
}
