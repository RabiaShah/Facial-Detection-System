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


        public LoadImg()
        {
            InitializeComponent();
            img = null;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog obj = new OpenFileDialog();
            if(obj.ShowDialog()==DialogResult.OK)
            {
                img = new Image<Bgr, byte>(obj.FileName);
                imageBox1.Image = img;
                DetectFaces();
            }
        }

        private void DetectFaces()
        {
            try
            {                
                Image<Gray, byte> gray = img.Convert<Gray, byte>();
                
                imageBox1.Image = img;
                string path = "haarcascade_frontalface_default.xml";
                CascadeClassifier cass = new CascadeClassifier(path);
                Rectangle[] faces = cass.DetectMultiScale(gray, 1.2, 4);
                foreach (var face in faces)
                {
                    img.Draw(face, new Bgr(0, 255, 0), 3);
                    ExtFace = new Bitmap(face.Width, face.Height);
                    painter = Graphics.FromImage(ExtFace);
                    painter.DrawImage(gray.Bitmap, 0, 0, face, GraphicsUnit.Pixel);
                }
                MessageBox.Show("Faces detected: " + faces.Length);
                imageBox1.Image = img;
                imageBox2.Image = new Image<Bgr,Byte>(ExtFace);
                //pictureBox1.Image = ExtFace;
             
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
    }
}
