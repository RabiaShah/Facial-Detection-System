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
        string name, ID, Sem,result;
        public Search_Student()
        {
            InitializeComponent();
            textID.Visible = false;
            textName.Visible = false;
            comboBoxSem.Visible = false;
            button2.Visible = true;
            panel1.Visible = false;
            vScrollBar1.Hide();
            panel1.AutoScroll = true;
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
            if (checkBox3.Checked)
            {
                comboBoxSem.Visible = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                textID.Visible = false;
                textName.Visible = false;
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ID = textID.Text.ToString();
                result = HelperClass.Help.SearchStudent(1, ID);
                label7.Text= result;
                panel1.Visible = true;
                button1.Hide();
            }
            if (checkBox2.Checked)
            {
                name = textName.Text.ToString();
                result = HelperClass.Help.SearchStudent(2, name);
                label7.Text = result;
                panel1.Visible = true;
                button1.Hide();
            }
            if (checkBox3.Checked)
            {
                Sem = comboBoxSem.Text;
                result = HelperClass.Help.SearchStudent(3, Sem);
                label7.Text = result;
                panel1.Visible = true;
                button1.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            //Search_Student.Controls.Add(vScrollBar1);
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
