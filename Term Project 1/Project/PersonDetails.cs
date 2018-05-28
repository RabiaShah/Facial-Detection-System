using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class PersonDetails : Form
    {
        DBConnector db;
        LoadImg obj;
        DataTable dt;
        int index = 0;
        Image<Bgr, byte> img;

        public PersonDetails()
        {
            InitializeComponent();
            img = null;
        }

        public void SetIndex(int id)
        {
            index = id;
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
            try
            {
                db = new DBConnector();
                obj = new LoadImg();
                dt = new DataTable();


                if (index > 0)
                {
                    dt = db.GetPersonDetails(index);
                    lblName1.Text = dt.Rows[0].ItemArray[1].ToString();
                    lblGender1.Text = dt.Rows[0].ItemArray[4].ToString();
                    lblAge1.Text = dt.Rows[0].ItemArray[2].ToString();
                    lblNationality1.Text = dt.Rows[0].ItemArray[3].ToString();
                    lblCrime1.Text = dt.Rows[0].ItemArray[5].ToString();
                    pbFace.Image = new Image<Bgr, byte>(dt.Rows[0].ItemArray[6].ToString());
                }
            }catch(IndexOutOfRangeException indexer)
            {
                MessageBox.Show(indexer.Message);
            }
            catch(NullReferenceException nullreference)
            {
                MessageBox.Show(nullreference.Message);
            }
            
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