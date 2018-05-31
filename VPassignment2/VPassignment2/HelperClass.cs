using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace VPassignment2
{
    class HelperClass
    {


        string path1 = @"happy.txt", path2 = @"C:\Users\rabia\Desktop\Attendance.txt";
        public string Path1
        {
            get
            {
                return path1;
            }
        }
        public string Path2
        {
            get
            {
                return path2;
            }
        }

        private static HelperClass obj;
        public static HelperClass Help
        {
            get
            {
                if (obj == null)
                    obj = new HelperClass();
                return obj;
            }
        }

        public void CreateProfile(string StudentId, string Name, string Dept, string Uni, int Sem, float cgpa)
        {
            using (StreamWriter obj = File.AppendText(Path1)) 
            {
                //obj.AutoFlush = true;
                obj.WriteLine("Student ID: " + StudentId);
                obj.WriteLine("Student Name: " + Name);
                obj.WriteLine("Department: " + Dept);
                obj.WriteLine("University: " + Uni);
                obj.WriteLine("CGPA: " + cgpa.ToString());
                obj.WriteLine("Semester: " + Sem);
                obj.WriteLine("x");
                obj.Close();
            }
            MessageBox.Show("Student Profile has been successfully created!");
        }
        public bool CheckUniqueID(string StudentId,out bool correct)
        {
            StreamReader reader = new StreamReader(path1);
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
            StreamReader reader = new StreamReader(path1);
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
        public string SearchStudent(int choice, string Input)
        {
            StreamReader reader = new StreamReader(path1);
            string s_record = reader.ReadToEnd(), Student_info = "", search_str = "";
            reader.Close();
            string[] Student_Array = s_record.Split('x').ToArray();
            if (choice == 1)
                search_str = "Student ID: ";
            else if (choice == 2)
                search_str = "Student Name: ";
            else if (choice == 3)
                search_str = "Semester: ";
            if (s_record.Contains(search_str + Input))
            {
                for (int i = 0; i < Student_Array.Length; i++)
                {
                    if (Student_Array[i].Contains(Input))
                    {
                        Student_info += Student_Array[i];
                    }
                }

                return Student_info;
            }

            return "No Record Found!";
        }
        public string[] Top3Students(string Semester)
        {
            StreamReader reader = new StreamReader(path1);
            string substr_cgpa = "", temp_str, s_record = reader.ReadToEnd();
            string[] record = s_record.Split('x').ToArray();
            string[] final_record = new string[record.Length];
            float[] CGPAs = new float[record.Length];
            int index = 0, index2 = 0, sem_counter = 0;
            float temp = 0;


            for (int i = 0; i < record.Length; i++)
            {
                if (record[i].Contains("Semester: " + Semester))
                {
                    index = record[i].IndexOf("CGPA: ");
                    index2 = record[i].IndexOf('\n', index + 1);
                    substr_cgpa = record[i].Substring(index + 6, 3);
                    CGPAs[sem_counter] = float.Parse(substr_cgpa);
                    final_record[sem_counter] = record[i];
                    sem_counter++;
                }
            }

            for (int i = 0; i < CGPAs.Length; i++)
            {
                for (int j = 0; j < CGPAs.Length - i - 1; j++)
                {
                    if (CGPAs[j] < CGPAs[j + 1])
                    {
                        temp = CGPAs[j];
                        CGPAs[j] = CGPAs[j + 1];
                        CGPAs[j + 1] = temp;
                        temp_str = final_record[j];
                        final_record[j] = final_record[j + 1];
                        final_record[j + 1] = temp_str;
                    }
                }
            }
            reader.Close();
            return final_record;
        }
        public void MarkAttendance(string semester)
        {
            StreamWriter writer = File.AppendText(path2);
            writer.AutoFlush = true;
            StreamReader reader = new StreamReader(path1);
            string s_record = reader.ReadToEnd();
            reader.Close();
            Mark_Attendance mark = new Mark_Attendance();
            string[] Student_Array = s_record.Split('x').ToArray();
            string ID,Name, Student_Info;
            //char status;
            int ID_Index, Name_Index, ending_index, std_count = 0;// labelPosition = 29;
            Label[] label=new Label[Student_Array.Length];
            RadioButton[] radioPresent = new RadioButton[Student_Array.Length];
            RadioButton[] radioAbsent = new RadioButton[Student_Array.Length];
            for (int i = 0; i < Student_Array.Length; i++)
            {
                if (Student_Array[i].Contains("Semester: " + semester))
                {
                    ID_Index = Student_Array[i].IndexOf("01");
                    Name_Index = Student_Array[i].IndexOf("Student Name: ");
                    ID = Student_Array[i].Substring(ID_Index+1, Name_Index-1);
                    ending_index = Student_Array[i].IndexOf('\n', Name_Index);
                    Name = Student_Array[i].Substring(Name_Index, ending_index);
                    Student_Info = ID+Name;
                    std_count++;

                    //label[i]=new Label();
                    //label[i].Location = new Point(3, 80+labelPosition);
                    //label[i].Text =std_count + ".  " + Student_Info;
                    //label[i].Font = new Font("Calibry", 12);
                    //label[i].Parent = mark.panel2;
                    //label[i].Visible = true;
                    //label[i].Show();

                    //radioPresent[i] = new RadioButton();
                    //radioPresent[i].Text = "Present";
                    //radioPresent[i].Location = new Point(305, 82+labelPosition);
                    //radioPresent[i].Parent = mark.panel2;
                    //radioPresent[i].Visible = true;
                    //radioPresent[i].Show();

                    //radioAbsent[i] = new RadioButton();
                    //radioAbsent[i].Text = "Absent";
                    //radioAbsent[i].Location = new Point(372, 82 + labelPosition);
                    //radioAbsent[i].Parent = mark.panel2;
                    //radioAbsent[i].Visible = true;
                    //radioAbsent[i].Show();
                    //labelPosition += 29;

                    //status = Convert.ToChar(Console.ReadLine());
                    //Console.WriteLine();
                    //writer.WriteLine("Semester: " + semester);
                    //writer.Write(Student_Info);
                    //writer.WriteLine("Attendance: " + status);
                    //writer.WriteLine("Date: " + DateTime.Now);
                    //writer.WriteLine("x");

                }
            }
            writer.Close();
        }
        public string ViewAttendance(string sem, string date)
        {
            StreamReader reader = new StreamReader(path2);
            string s_record = reader.ReadToEnd(), showAttendance = "";
            reader.Close();
            string[] attendace = s_record.Split('x').ToArray();
            for (int j = 0; j < attendace.Length - 1; j++)
            {
                if (sem != "" && date != "")
                {
                    if (attendace[j].Contains("Semester: " + sem) && attendace.Contains("Date: " + date))
                    {
                        showAttendance += attendace[j];
                    }

                }
                else if (sem == "" && date != null)
                {
                    if (attendace[j].Contains("Date: " + date))
                    {
                        showAttendance += attendace[j];
                    }

                }
                else if (date == "" && sem != null)
                {
                    if (attendace[j].Contains("Semester: " + sem))
                    {
                        showAttendance += attendace[j];
                    }

                }
                else
                    showAttendance += attendace[j];
            }
            return showAttendance;
        }
    }
}
