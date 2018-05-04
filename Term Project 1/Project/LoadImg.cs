using Emgu.CV;
using Emgu.CV.UI;
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
        public  Image<Bgr, byte> imageFrame;
        private int WindowSize = 25;
        private double scaleIR = 1.1;
        private int min = 3;
        private HaarCascade haar;
        Bitmap[] ExtFaces;
        int faceNo = 0;

        public LoadImg()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog obj = new OpenFileDialog();
            if(obj.ShowDialog()==DialogResult.OK)
            {
                imageFrame = new Image<Bgr, byte>(obj.FileName);
                imageBox1.Image = imageFrame;
                DetectFaces();
            }
        }

        private void DetectFaces()
        {
            
            Image<Gray, byte> grayframe = imageFrame.Convert<Gray, byte>();
            var faces = haar.Detect(grayframe, scaleIR, min, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(WindowSize,WindowSize), new Size(WindowSize,WindowSize));
            Bitmap bmpInput = grayframe.ToBitmap();
            Bitmap ExtractedFaces;
            Graphics FaceCanvas;
            ExtFaces = new Bitmap[faces.Length];
            faceNo = 0;
            if(faces.Length>0)
            {
                foreach(var face in faces)
                {
                    imageFrame.Draw(face.rect, new Bgr(Color.Green), 3);
                    ExtractedFaces = new Bitmap(face.rect.Width, face.rect.Height);
                    FaceCanvas = Graphics.FromImage(ExtractedFaces);
                    FaceCanvas.DrawImage(bmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);
                    ExtFaces[faceNo] = ExtractedFaces;
                    faceNo++;
                }
                imageBox1.Image = imageFrame;
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
            //try
            //{
            //    haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
