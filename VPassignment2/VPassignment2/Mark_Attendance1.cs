using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPassignment2
{
    
    public partial class Mark_Attendance1 : Form
    {
        string semester;
        string s_record;
        
        string ID, Name, Student_Info;
        char status = 'P';
        int ID_Index, ID_Index_end, Name_Index, ending_index, std_count = 0, labelPosition = 29;
        public Mark_Attendance1(string sem)
        {
            semester = sem;
            InitializeComponent();
            panel2.AutoScroll=true;
            lbl6.Text = "Semester " + sem;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void Mark_Attendance1_Load(object sender, EventArgs e)
        {
            
            StreamReader reader = new StreamReader(HelperClass.Help.Path1);
            s_record = reader.ReadToEnd();
            reader.Close();
            string[] Student_Array = s_record.Split('x').ToArray();
            Label[] label=new Label[Student_Array.Length];
            RadioButton[] radioPresent = new RadioButton[Student_Array.Length];
            RadioButton[] radioAbsent = new RadioButton[Student_Array.Length];
            for (int i = 0; i < Student_Array.Length; i++)
            {
                if (Student_Array[i].Contains("Semester: " + semester))
                {
                    ID_Index = Student_Array[i].IndexOf(" 01");
                    ID_Index_end = Student_Array[i].IndexOf('S', ID_Index);
                    ID = Student_Array[i].Substring(ID_Index + 1, 13);
                    //Name_Index = Student_Array[i].IndexOf("e: ");
                    //ending_index = Student_Array[i].IndexOf('\n', Name_Index);
                    //Name = Student_Array[i].Substring(Name_Index+3, ending_index-1);
                    std_count++;
                    Student_Info = (i+1)+".  "+ID;
                    label1.Text = Student_Info;
                    //label[i] = new Label();
                    //label[i].Location = new Point(3, 80 + labelPosition);
                    //label[i].Text = std_count + ".  " + Student_Info;
                    //label[i].Font = new Font("Calibry", 12);
                    //label[i].Parent = panel2;
                    //label[i].Visible = true;
                    //label[i].Show();

                    //radioPresent[i] = new RadioButton();
                    //radioPresent[i].Text = "Present";
                    //radioPresent[i].Location = new Point(305, 82 + labelPosition);
                    //radioPresent[i].Parent = panel2;
                    //radioPresent[i].Visible = true;
                    //radioPresent[i].Show();

                    //radioAbsent[i] = new RadioButton();
                    //radioAbsent[i].Text = "Absent";
                    //radioAbsent[i].Location = new Point(372, 82 + labelPosition);
                    //radioAbsent[i].Parent = panel2;
                    //radioAbsent[i].Visible = true;
                    //radioAbsent[i].Show();
                    //labelPosition += 29;

                    
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter writer = File.AppendText(@"C:\Users\rabia\Desktop\Attendance.txt");
            writer.AutoFlush = true;
            if (radioButton1.Checked)
                status = 'P';
            Console.WriteLine();
            writer.WriteLine("Semester: " + semester);
            writer.WriteLine(Student_Info);
            writer.WriteLine("Attendance: " + status);
            writer.WriteLine("Date: " + DateTime.Now);
            writer.WriteLine("x");
            writer.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter writer = File.AppendText(HelperClass.Help.Path2);
            writer.AutoFlush = true;
            if (radioButton2.Checked)
                status = 'A';
            Console.WriteLine();
            writer.WriteLine("Semester: " + semester);
            writer.WriteLine(Student_Info);
            writer.WriteLine("Attendance: " + status);
            writer.WriteLine("Date: " + DateTime.Now);
            writer.WriteLine("x");
            writer.Close();
        }
    }
}
