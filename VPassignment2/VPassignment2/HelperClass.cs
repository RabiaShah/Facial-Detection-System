using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VPassignment2
{
    class HelperClass
    {
        public void CreateProfile(string StudentId, string Name, string Dept, string Uni, int Sem, float cgpa)
        {
            StreamWriter obj = File.AppendText(@"C:\Users\rabia\Desktop\happy.txt");
            obj.AutoFlush = true;
            obj.WriteLine("Student ID: " + StudentId);
            obj.WriteLine("Student Name: " + Name);
            obj.WriteLine("Department: " + Dept);
            obj.WriteLine("University: " + Uni);
            obj.WriteLine("CGPA: " + cgpa.ToString());
            obj.WriteLine("Semester: " + Sem);
            obj.WriteLine("x");
            obj.Close();
            MessageBox.Show("Student Profile has been successfully created!");
        }
        public bool CheckUniqueID(string StudentId,out bool correct)
        {
            StreamReader reader = new StreamReader(@"C:\Users\rabia\Desktop\happy.txt");
            string s_record = reader.ReadToEnd();
            reader.Close();
            correct = false;
            createProfile obj = new createProfile();

                if (StudentId[2] == '-' && StudentId[9] == '-' && StudentId.Length.Equals(13))
                {
                    correct = true;
                }
                else
                {
                    correct = false;
                    MessageBox.Show("Invalid ID, try again: ");
                    obj.textID.Text = "";
                }


                if (s_record.Contains(StudentId))
                {
                        MessageBox.Show("This Student ID has already been saved, try again: ");
                        obj.textID.Text = "";
                }
           
                return correct;
        }
        public string DeleteRecord(string StudentID)
        {
            StreamReader reader = new StreamReader(@"C:\Users\rabia\Desktop\happy.txt");
            string s_record = reader.ReadToEnd(), first_str = "", second_str = "", final_file = "";
            reader.Close();
            if (s_record.Contains(StudentID))
            {
                int first = s_record.IndexOf("Student ID: " + StudentID);
                int last = s_record.IndexOf("Student ID: ", first + 1);
                if (last <= 0)                //if the record being searched is at the last, then the next Student ID value would be -1
                    first_str = s_record.Substring(0, first);
                else if (first == 0)         //if the string being searched is at the start
                    second_str = s_record.Substring(last);
                else                         //if record being searched is in the middle somewhere
                {
                    first_str = s_record.Substring(0, first);
                    second_str = s_record.Substring(last);
                }
            }
            else
            {
                return "No Record Found!";
            }

            final_file = string.Concat(first_str, second_str);
            reader.Close();
            return final_file;
        }
    }
}
