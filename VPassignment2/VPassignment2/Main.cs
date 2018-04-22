using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPassignment2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createProfile cp = new createProfile();
            cp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            dl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Student sc = new Search_Student();
            sc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top3 top3 = new Top3();
            top3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mark_Attendance mark = new Mark_Attendance();
            mark.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View_Attendance view = new View_Attendance();
            view.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
