using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Project
{
    public partial class PictureComparison : Form
    {
        public Bitmap takenImage;
        public Image<Gray,byte> img;
        public Image<Gray, byte> img1;
        public DataTable dt;
        int index;

        public PictureComparison()
        {
            InitializeComponent();
        }

        public PictureComparison(Bitmap bmp)
        {
            InitializeComponent();
            takenImage = bmp;
        }

        public void SetIndex(int id)
        {
            index = id;
        }


        private void PictureComparison_Load(object sender, EventArgs e)
        {
            try
            {
                pbCapturedImg.Image = img;
                pbDBImg.Image = img1;
                if (img1 != null)
                {
                    lblFound.Text = "Match Found";
                    timerForColor.Start();
                    timerForColor.Enabled = true;
                }
                else
                    lblFound.Text = "No Record Found";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PersonDetails obj = new PersonDetails();
            obj.SetIndex(index);
            obj.Show();
            this.Hide();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //the image matched from the database (if any)..
        }

        private void pbCpaturedImg_Click(object sender, EventArgs e)
        {
            //the image captured from the webcam in LiveVideo
            //or the image loaded/browsed from the computer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ImageStatistics obj = new ImageStatistics();
            //obj.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int alpha = rand.Next(0, 255);
            int one = rand.Next(0,255);
            int two = rand.Next(0,255);
            lblFound.ForeColor = Color.FromArgb(alpha, two, one, two);

        }
        
    }
}
