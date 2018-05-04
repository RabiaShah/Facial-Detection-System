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
    }
}
