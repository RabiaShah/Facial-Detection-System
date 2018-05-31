using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VPassignment2
{
    public partial class Delete : Form
    {
        string ID = "", result;
        
       
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ID = textID.Text.ToString();
            result = HelperClass.Help.DeleteRecord(ID);
            if (result.Equals("No Record Found!"))
                MessageBox.Show("No Record Found!");
            else
            {
                StreamWriter writer = new StreamWriter(HelperClass.Help.Path1);
                writer.AutoFlush = true;
                writer.WriteLine(result);
                MessageBox.Show("The Record Has Been Successfully Deleted!");
                writer.Close();
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
