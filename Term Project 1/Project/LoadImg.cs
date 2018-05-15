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


namespace Project
{
    public partial class LoadImg : Form
    {
        public  Image<Bgr, byte> img;
        Bitmap ExtFace;
        Graphics painter;
        Bitmap[] ExtractedFaces;
        int faceNo;

        public LoadImg()
        {
            InitializeComponent();
            img = null;
            faceNo = 0;
            //btnNext.Visible = false;
            //btnPrev.Visible = false;
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
            PictureComparison obj = new PictureComparison();
            obj.Show();
            this.Hide();
        }

        private void LoadImg_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (faceNo > ExtractedFaces.Length-1)
                MessageBox.Show("No more Images!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                faceNo++;
                pbDetectedFace.Image = new Image<Bgr, Byte>(ExtractedFaces[faceNo]);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo < 1)
                MessageBox.Show("No more Images!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                faceNo--;
                pbDetectedFace.Image = new Image<Bgr, Byte>(ExtractedFaces[faceNo]);
            }
        }
    }
}
