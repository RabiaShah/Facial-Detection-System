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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
            textID.Visible = false;
            textName.Visible = false;
            comboBoxSem.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textID.Visible = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textName.Visible = false;
                comboBoxSem.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textName.Visible = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                textID.Visible = false;
                comboBoxSem.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBoxSem.Visible = true;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                textID.Visible = false;
                textName.Visible = false;
            }
        }
    }
}
