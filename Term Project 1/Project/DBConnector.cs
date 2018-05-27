using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project
{
    public class DBConnector
    {
        private MySqlConnection con;
 
        public DBConnector()
        {
            con = new MySqlConnection("server=localhost;user id=root;database=facesdb;password=rabia123");
            con.Open();
        }
        public  DataTable GetData()
        {

            MySqlCommand cmd = new MySqlCommand("Select Image from facesdb.facedetectiondb", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //int i = dt.Rows.Count;
            string str = dt.Rows[1].ItemArray[0].ToString();
            con.Close();
            return dt;
        }
        public DataTable GetPersonDetails(int id)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from facesdb.facedetectiondb where EntryNo='" + id + "'", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        
    }
}
