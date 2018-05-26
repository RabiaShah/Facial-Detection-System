using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PictureComparison : Form
    {
        Bitmap takenImage;

        public PictureComparison()
        {
            InitializeComponent();
        }
        public PictureComparison(Bitmap bmp)
        {
            InitializeComponent();
            takenImage = bmp;
        }

        private void PictureComparison_Load(object sender, EventArgs e)
        {
            pbCpaturedImg.Image = takenImage;
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PersonDetails obj = new PersonDetails();
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
    }
}
