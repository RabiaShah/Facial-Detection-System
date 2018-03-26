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
    public partial class createProfile : Form
    {
        float cgpa = 0.0f;
        string ID = "", Name = "", Dept = "", Uni = "";
        int semester = 0; bool correct = false;
        HelperClass obj = new HelperClass();
        public createProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void createProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ID = textID.Text.ToString();
                Name = textName.Text.ToString();
                Uni = textUni.Text.ToString();
                Dept = textDept.Text;
                semester = Convert.ToInt32(comboBoxSem.Text);
                cgpa = float.Parse(textCGPA.Text);
                if (ID == "" || Name == "" || Dept == "" || Uni == "")
                {
                    MessageBox.Show("No field can be empty");
                }
                // else if (!obj.CheckUniqueID(ID, out correct))
                //{
                //    ID = textID.Text.ToString();
                //     while(!correct)
                //     {

                //     }
                //}
                else
                {
                    obj.CreateProfile(ID, Name, Dept, Uni, semester, cgpa);
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textName.Text = "";
            textUni.Text = "";
            textDept.Text = "";
            comboBoxSem.Text = "";
            textCGPA.Text = "";
        }
    }
}
