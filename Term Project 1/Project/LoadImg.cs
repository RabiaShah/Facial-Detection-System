using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCVWrapper;


namespace Project
{
    public partial class LoadImg : Form
    {
        
        public  Image<Bgr, byte> img;
        Bitmap ExtFace;
        Graphics painter;
        Bitmap[] ExtractedFaces;
        int faceNo;
        Image<Gray, byte> capturedImg;
        Image<Gray, byte> DBImg;
        int index = -1;
        double check = 0,comp1=0;
        DenseHistogram hist1, hist2;
        Mat mat1, mat2;
        DBConnector db;
        DataTable dt;

        public LoadImg()
        {
            
            InitializeComponent();
            db = new DBConnector();
            dt = new DataTable();
            img = null;
            faceNo = 0;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog obj = new OpenFileDialog();
            if(obj.ShowDialog()==DialogResult.OK)
            {
                img = new Image<Bgr, byte>(obj.FileName);
                pbBrowsedImage.Image = img;
                DetectFaces();
            }
        }

        private void DetectFaces()
        {
            try
            {                
                Image<Gray, byte> gray = img.Convert<Gray, byte>();
                pbBrowsedImage.Image = img;
                string path = "haarcascade_frontalface_default.xml";    //xml file for face detection
                CascadeClassifier cass = new CascadeClassifier(path);
                Rectangle[] faces = cass.DetectMultiScale(gray, 1.2, 4);
                faceNo = 0;
                ExtractedFaces = new Bitmap[faces.Length];
                foreach (var face in faces)
                {
                    img.Draw(face, new Bgr(0, 255, 0), 3);
                    ExtFace = new Bitmap(face.Width, face.Height);   //storing face which is in the rectangle of specified height and width
                    painter = Graphics.FromImage(ExtFace);
                    painter.DrawImage(gray.Bitmap, 0, 0, face, GraphicsUnit.Pixel);   //converting the bitmap image into pixel units from gray image to extracted face (ExtFace)
                    ExtractedFaces[faceNo] = ExtFace;
                    faceNo++;
                }
                MessageBox.Show("Face(s) detected: " + faces.Length,"Total captured faces",MessageBoxButtons.OK,MessageBoxIcon.Information);
                pbBrowsedImage.Image = img;
                pbDetectedFace.Image = new Image<Bgr, Byte>(ExtFace);
                //pbDetectedFace.Image = new Image<Bgr, Byte>(ExtractedFaces[0]);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt = db.GetData();
                Detection();
                PictureComparison obj = new PictureComparison();
                obj.img = new Image<Gray, byte>(pbDetectedFace.Image.Bitmap);

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
            }
            catch(IOException io)
            {
                MessageBox.Show(io.Message);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public void Detection()
        {
            try
            {
                check = comp1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    capturedImg = new Image<Gray, byte>(pbDetectedFace.Image.Bitmap);
                    DBImg = new Image<Gray, byte>((dt.Rows[i].ItemArray[0]).ToString());

                    hist1 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
                    hist2 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));

                    hist1.Calculate(new Image<Gray, byte>[] { capturedImg }, false, null);
                    hist2.Calculate(new Image<Gray, byte>[] { DBImg }, false, null);

                    mat1 = new Mat();
                    hist1.CopyTo(mat1);
                    mat2 = new Mat();
                    hist2.CopyTo(mat2);

                    //float[] histFloat = new float[256];
                    //hist1.CopyTo(histFloat);

                    //float[] hist2Float = new float[256];
                    //hist2.CopyTo(hist2Float);

                    //double count1 = 0, count2 = 0;
                    //for (int j = 0; j < 256; j++)
                    //{
                    //    count1 += histFloat[j];
                    //    count2 += hist2Float[j];
                    //}

                    //unsafe
                    //{
                    //    fixed (char* ch = (dt.Rows[i].ItemArray[0]).ToString().ToCharArray())
                    //    {
                    //        fixed (char* ch2 = (dt.Rows[i].ItemArray[0]).ToString().ToCharArray())
                    //        {
                    //            OpenCVWrapper.OpencvWrapperClass obj = new OpencvWrapperClass();
                    //            sbyte* pic1 = (sbyte*)ch2;
                    //            sbyte* pic2 = (sbyte*)ch;
                    //            comp1=obj.CompareHistogram(pic1, pic2);
                    //        }
                    //    }
                    //}

                    comp1 = CvInvoke.CompareHist(mat1, mat2, Emgu.CV.CvEnum.HistogramCompMethod.Correl);
                    if (comp1 > check && comp1 < 0.40 && comp1 > 0.221)
                    {
                        check = comp1;
                        index = i;

                    }

                }
                MessageBox.Show(check + " " + index.ToString());
            }
            catch(IndexOutOfRangeException index)
            {
                MessageBox.Show(index.Message);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LoadImg_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {

                if (faceNo > ExtractedFaces.Length - 1)
                    MessageBox.Show("No more Images!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    faceNo++;
                    pbDetectedFace.Image = new Image<Bgr, Byte>(ExtractedFaces[faceNo]);
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (faceNo < 1)
                    MessageBox.Show("No more Images!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    faceNo--;
                    pbDetectedFace.Image = new Image<Bgr, Byte>(ExtractedFaces[faceNo]);
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

    }
}
