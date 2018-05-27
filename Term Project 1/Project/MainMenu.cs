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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiveVideo obj = new LiveVideo();
            obj.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            LoadImg obj = new LoadImg();
            obj.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
