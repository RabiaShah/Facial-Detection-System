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
        Bitmap takenImage;
        public DataTable dt;
        Image<Gray, byte> capturedImg;
        Image<Gray, byte> DBImg;


        public PictureComparison()
        {
            InitializeComponent();
            DBConnector db = new DBConnector();
            dt = db.GetData();
        }
        public PictureComparison(Bitmap bmp)
        {
            InitializeComponent();
            takenImage = bmp;
        }

        private void PictureComparison_Load(object sender, EventArgs e)
        {
            pbCpaturedImg.Image = takenImage;
            //pbDBImage.Image = Image.FromFile((dt.Rows[0].ItemArray[0]).ToString()); 
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
        public void Detection()
        {
            capturedImg = new Image<Gray, byte>(takenImage);
            DBImg = new Image<Gray, byte>((dt.Rows[0].ItemArray[0]).ToString());

            DenseHistogram hist1 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            DenseHistogram hist2 = new DenseHistogram(256, new RangeF(0.0f, 255.0f));

            hist1.Calculate(new Image<Gray, byte>[] { capturedImg }, false, null);
            hist1.Calculate(new Image<Gray, byte>[] { DBImg }, false, null);

            Mat mat1 = new Mat();
            hist1.CopyTo(mat1);
            Mat mat2 = new Mat();
            hist2.CopyTo(mat2);

            double comp1 = CvInvoke.CompareHist(mat1, mat2, Emgu.CV.CvEnum.HistogramCompMethod.Bhattacharyya);

            float[] hist1Float = new float[256];
            hist1.CopyTo(hist1Float);

            float[] hist2Float = new float[256];
            hist2.CopyTo(hist2Float);

            double count1 = 0, count2 = 0;
            for (int i = 0; i < 256; i++)
            {
                count1 += hist1Float[i];
                count2 += hist2Float[i];
            }


        }
    }
}
