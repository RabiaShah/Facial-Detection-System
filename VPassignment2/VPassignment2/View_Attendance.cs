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
    public partial class View_Attendance : Form
    {
        string sem;
        HelperClass obj = new HelperClass();
        public View_Attendance()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel2.AutoScroll = true;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
            sem = comboBoxSem.Text;
            label1.Text=obj.ViewAttendance(sem, "");
            button2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
