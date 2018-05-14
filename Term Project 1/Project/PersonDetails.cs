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
    public partial class PersonDetails : Form
    {
        public PersonDetails()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void pbFace_Click(object sender, EventArgs e)
        {
            //picture of the person from the databse
        }

        private void grpBoxDetails_Enter(object sender, EventArgs e)
        {
            //the details of the person from the database
        }
    }
}