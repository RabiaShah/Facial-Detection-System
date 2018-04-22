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
    public partial class Mark_Attendance : Form
    {
        string sem;
        HelperClass obj = HelperClass.Help;
        public Mark_Attendance()
        {
            InitializeComponent();
            //panel2.AutoScroll = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sem = comboBoxSem.Text;
            //lbl6.Text = "Semester " + sem;
            Mark_Attendance1 mark = new Mark_Attendance1(sem);
            mark.Show();
            this.Hide();
            HelperClass.Help.MarkAttendance(sem);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
