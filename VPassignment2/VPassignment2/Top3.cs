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
    public partial class Top3 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        //HelperClass obj;
        string[] top3Std;
        string semester,final;
        int index=0;
        public Top3()
        {
            InitializeComponent();
            //obj = new HelperClass();
            top3Std = new string[3];
            panel2.Visible = false;
            panel2.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSem.Equals(""))
                MessageBox.Show("Please Enter Semester");
            else
            {
                semester = comboBoxSem.Text;
                top3Std = HelperClass.Help.Top3Students(semester);
                for (int i = 0; i < 3;i++ )
                {
                    final += top3Std[i];
                }
                if (index < listpanel.Count - 1)
                    listpanel[++index].BringToFront();
                label3.Text = final;
            }
        }

        private void Top3_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel[index].BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxSem.Equals(""))
                MessageBox.Show("Please Enter Semester");
            else
            {
                semester = comboBoxSem.Text;
                top3Std = HelperClass.Help.Top3Students(semester);
                for (int i = 0; i < 3; i++)
                {
                    final += top3Std[i];
                }
                //if (index < listpanel.Count - 1)
                //    listpanel[index++].BringToFront();
                //panel1.Visible = false;
                panel2.Visible = true;
                label3.Text = final;
                panel2.Visible = true;
            }
        }
    }
}
