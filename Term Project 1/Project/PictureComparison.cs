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
    public partial class PictureComparison : Form
    {
        public PictureComparison()
        {
            InitializeComponent();
        }

        private void PictureComparison_Load(object sender, EventArgs e)
        {
            
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
    }
}
