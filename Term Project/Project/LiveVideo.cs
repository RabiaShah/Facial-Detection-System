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
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Cvb;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class LiveVideo : Form
    {
        
        private FilterInfoCollection webcam;
        private VideoCaptureDevice videoSource;
        
        
        public LiveVideo()
        {
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
            videoSource = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(webcam[cmbVideoDevices.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            PictureComparison obj = new PictureComparison();
            obj.Show();
            this.Hide();
        }
    }
}
