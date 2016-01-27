using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SMS
{
    public partial class AddResult : UserControl
    {
        SqlConnection conn;
        public AddResult()
        {
            InitializeComponent();
            FillShiftList();
            string subject_id = SubjectSelectCombo.SelectedValue.ToString();
            FillResultEntry(subject_id);
        }

        private void FillShiftList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            var ShiftDictionary = new Dictionary<string, string>();
            ShiftDictionary.Add("Morning", "Morning");
            ShiftDictionary.Add("Day", "Day");

            ShiftSelectCombo.DisplayMember = "Value";
            ShiftSelectCombo.ValueMember = "Key";
            ShiftSelectCombo.DataSource = new BindingSource(ShiftDictionary, null);

            //Fill year list
            var YearDictionary = new Dictionary<int, int>();
            DateTime dt = DateTime.Now;
            YearDictionary.Add(0, 0);
            for (int i = 1987; i <= dt.Year; i++)
            {
                YearDictionary.Add(i, i);
            }
            StdSelectYearCombox.DisplayMember = "Value";
            StdSelectYearCombox.ValueMember = "Key";
            StdSelectYearCombox.DataSource = new BindingSource(YearDictionary, null);
        }

        private void ShiftSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = ShiftSelectCombo.SelectedValue.ToString();
                FillClassInfo(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillClassInfo(string value)
        {           
            SqlCommand classListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='" + value + "'", conn);
            SqlDataReader dr = classListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                var classListDictionary = new Dictionary<string, string>();
                while (dr.Read())
                {
                    int indexclassName = dr.GetOrdinal("class");
                    int indexsection = dr.GetOrdinal("section");
                    int indexclass_id = dr.GetOrdinal("class_id");

                    string className = dr.GetString(indexclassName);
                    string classSection = dr.GetString(indexsection);
                    string classID = dr.GetString(indexclass_id);

                    classListDictionary.Add(classID, "Class - " + className + " (" + classSection + ")");
                }
                ClassSelectCombo.DisplayMember = "Value";
                ClassSelectCombo.ValueMember = "Key";
                ClassSelectCombo.DataSource = new BindingSource(classListDictionary, null);
            }
            else
            {
                ClassSelectCombo.DataSource = null;
            }
        }

        private void ClassSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillSubjectList();
                FillTermList();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillTermList()
        {
            var TermDictionary = new Dictionary<int, string>();
            TermDictionary.Add(1, "1st Term");
            TermDictionary.Add(2, "2nd Term");
            TermDictionary.Add(3, "3rd Term");

            termSelectCombo.DisplayMember = "Value";
            termSelectCombo.ValueMember = "Key";
            termSelectCombo.DataSource = new BindingSource(TermDictionary, null);
        }

        private void termSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillStudentList();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillStudentList()
        {
            string class_id = ClassSelectCombo.SelectedValue.ToString();
            
            SqlCommand studentListCmd = new SqlCommand("SELECT student_id,fname,lname FROM [sms].[dbo].[student] AS st INNER JOIN [sms].[dbo].[person] AS pe ON st.id = pe.id WHERE st.class_id='"+class_id+"' ORDER BY roll", conn);
            SqlDataReader sdr = studentListCmd.ExecuteReader();
            if (sdr.HasRows)
            {
                var studnetListDictionary = new Dictionary<string, string>();
                while (sdr.Read())
                {
                    int indexStudentID = sdr.GetOrdinal("student_id");
                    int indexFname = sdr.GetOrdinal("fname");
                    int indexLname = sdr.GetOrdinal("lname");

                    string Student_id = sdr.GetString(indexStudentID);
                    string Fname = sdr.GetString(indexFname);
                    string Lname = sdr.GetString(indexLname);

                    studnetListDictionary.Add(Student_id, Fname + " " + Lname);
                }
                StudentSelectCombo.DisplayMember = "Value";
                StudentSelectCombo.ValueMember = "Key";
                StudentSelectCombo.DataSource = new BindingSource(studnetListDictionary, null);
            }
            else
            {
                StudentSelectCombo.DataSource = null;
            }
            
        }

        private void FillSubjectList()
        {
            string class_id = ClassSelectCombo.SelectedValue.ToString();
            var value = int.Parse(Regex.Match(class_id, @"\d+").Value);
            SqlCommand subjectListCmd = new SqlCommand("SELECT subject_id,subject_name,fname,lname FROM [sms].[dbo].[subject] AS sb INNER JOIN [sms].[dbo].[teacher] AS te ON sb.teach_id = te.teach_id INNER JOIN [sms].[dbo].[person] AS pe ON te.id = pe.id WHERE sb.class_id="+value+" ORDER BY subject_id", conn);
            SqlDataReader sbjctdr = subjectListCmd.ExecuteReader();
            if (sbjctdr.HasRows)
            {
                var subjectListDictionary = new Dictionary<string, string>();
                while (sbjctdr.Read())
                {
                    int indexSubjectID = sbjctdr.GetOrdinal("subject_id");
                    int indexSubjectName = sbjctdr.GetOrdinal("subject_name");
                    int indexFname = sbjctdr.GetOrdinal("fname");
                    int indexLname = sbjctdr.GetOrdinal("lname");

                    string Subject_ID = sbjctdr.GetString(indexSubjectID);
                    string Subject_name = sbjctdr.GetString(indexSubjectName);
                    string Fname = sbjctdr.GetString(indexFname);
                    string Lname = sbjctdr.GetString(indexLname);

                    subjectListDictionary.Add(Subject_ID, Subject_name);
                }
                SubjectSelectCombo.DisplayMember = "Value";
                SubjectSelectCombo.ValueMember = "Key";
                SubjectSelectCombo.DataSource = new BindingSource(subjectListDictionary, null);
            }
            else
            {
                SubjectSelectCombo.DataSource = null;
            }
        }

        private void SubjectSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string subject_id = SubjectSelectCombo.SelectedValue.ToString();
                FillResultEntry(subject_id);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void StudentSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string subject_id = SubjectSelectCombo.SelectedValue.ToString();
                FillResultEntry(subject_id);
            }
            catch (NullReferenceException)
            {
            }
        }  

        private void FillResultEntry(string subject_id)
        {
            try
            {
                int term = (int)termSelectCombo.SelectedValue;
                string studentID = StudentSelectCombo.SelectedValue.ToString();

                SqlCommand FindResultExistCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[result] WHERE exam_id=" + term + " AND subject_id='" + subject_id + "' AND student_id='" + studentID + "'", conn);
                SqlDataReader FREdr = FindResultExistCmd.ExecuteReader();
                if (FREdr.HasRows)
                {
                    ResultInputEntry.Visible = false;
                    WarningPanel.Visible = true;
                }
                else
                {
                    ResultInputEntry.Visible = true;
                    WarningPanel.Visible = false;
                }
            }
            catch (NullReferenceException)
            {}
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Result_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                var classID = ClassSelectCombo.SelectedValue;
                var year = StdSelectYearCombox.SelectedValue;
                var examID = termSelectCombo.SelectedValue;
                var subjectID = SubjectSelectCombo.SelectedValue;
                var examiner = "";
                SqlCommand FindExaminerCmd = new SqlCommand("SELECT teach_id FROM [sms].[dbo].[subject] WHERE subject_id='"+subjectID.ToString()+"'", conn);
                SqlDataReader FEdr = FindExaminerCmd.ExecuteReader();
                if (FEdr.Read())
                {
                    int indexExaminerID = FEdr.GetOrdinal("teach_id");

                    examiner = FEdr.GetString(indexExaminerID);
                }
                var studentID = StudentSelectCombo.SelectedValue;
                var written = writtenTxt.Text;
                var ct = CTtxt.Text;
                var presence = presenceTxt.Text;
                var total = totalTxt.Text;
                var gpa = 0.0;
                int totalMark = Convert.ToInt32(total);
                if (totalMark >= 80 && totalMark <= 100)
                {
                    gpa = 5.0;
                }
                else if (totalMark >= 70 && totalMark <= 79)
                {
                    gpa = 4.0;
                }
                else if (totalMark >= 60 && totalMark <= 69)
                {
                    gpa = 3.5;
                }
                else if (totalMark >= 50 && totalMark <= 59)
                {
                    gpa = 3.0;
                }
                else if (totalMark >= 40 && totalMark <= 49)
                {
                    gpa = 2.0;
                }
                else if (totalMark >= 33 && totalMark <= 39)
                {
                    gpa = 1.0;
                }
                else if (totalMark >= 0 && totalMark <= 32)
                {
                    gpa = 0.0;
                }
                else if (totalMark < 0 || totalMark > 100)
                {
                    MessageBox.Show("Check your given numbers... It is not correct!!");
                }
                
                if (totalMark >= 45 && totalMark <= 50 && subjectID.ToString() == "c1s5")
                {
                    gpa = 5.0;
                }
                else if (totalMark >= 40 && totalMark <= 44 && subjectID.ToString() == "c1s5")
                {
                    gpa = 4.0;
                }
                else if (totalMark >= 35 && totalMark <= 39 && subjectID.ToString() == "c1s5")
                {
                    gpa = 3.5;
                }
                else if (totalMark >= 30 && totalMark <= 34 && subjectID.ToString() == "c1s5")
                {
                    gpa = 3.5;
                }
                else if (totalMark >= 25 && totalMark <= 29 && subjectID.ToString() == "c1s5")
                {
                    gpa = 3.0;
                }
                else if (totalMark >= 20 && totalMark <= 24 && subjectID.ToString() == "c1s5")
                {
                    gpa = 2.0;
                }
                else if (totalMark >= 15 && totalMark <= 19 && subjectID.ToString() == "c1s5")
                {
                    gpa = 1.0;
                }
                else if (totalMark >= 0 && totalMark <= 14 && subjectID.ToString() == "c1s5")
                {
                    gpa = 0.0;
                }
                else if (totalMark < 0 || totalMark > 50 && subjectID.ToString() == "c1s5")
                {
                    MessageBox.Show("Check your given numbers... It is not correct!!");
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [sms].[dbo].[result](class_id, year, exam_id, subject_id, examiner, student_id, m_written, m_ct, m_presence, m_total, gpa)" +
                    " VALUES (@classID, @year, @examID, @subjectID, @examiner, @studentID, @written, @ct, @presence, @total, @gpa)", conn);
                cmd.Parameters.AddWithValue("@classID", classID);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@examID", examID);
                cmd.Parameters.AddWithValue("@subjectID", subjectID);
                cmd.Parameters.AddWithValue("@examiner", examiner);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@written", written);
                cmd.Parameters.AddWithValue("@ct", ct);
                cmd.Parameters.AddWithValue("@presence", presence);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@gpa", gpa);

                cmd.ExecuteNonQuery();
                writtenTxt.Text = "";
                CTtxt.Text = "";
                presenceTxt.Text = "";
                totalTxt.Text = "";
                FillShiftList();
                string subject_id = SubjectSelectCombo.SelectedValue.ToString();
                FillResultEntry(subject_id);
                MessageBox.Show("Result entry successfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelResult_Click(object sender, EventArgs e)
        {
            writtenTxt.Text = "";
            CTtxt.Text = "";
            presenceTxt.Text = "";
            totalTxt.Text = "";
            FillShiftList();
            string subject_id = SubjectSelectCombo.SelectedValue.ToString();
            FillResultEntry(subject_id);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            writtenTxt.Text = "";
            CTtxt.Text = "";
            presenceTxt.Text = "";
            totalTxt.Text = "";
            FillShiftList();
            string subject_id = SubjectSelectCombo.SelectedValue.ToString();
            FillResultEntry(subject_id);
        }           
    }
}
