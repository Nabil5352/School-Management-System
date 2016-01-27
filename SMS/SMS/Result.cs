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

namespace SMS
{
    public partial class Result : UserControl
    {
        SqlConnection conn;
        public Result()
        {
            InitializeComponent();
            FillShiftList();
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
            var classListDictionary = new Dictionary<string, string>();
            SqlCommand classListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='" + value + "'", conn);
            SqlDataReader dr = classListCmd.ExecuteReader();
            if (dr.HasRows)
            {
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
            }
            ClassSelectCombo.DisplayMember = "Value";
            ClassSelectCombo.ValueMember = "Key";
            ClassSelectCombo.DataSource = new BindingSource(classListDictionary, null);
        }

        private void ClassSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = ClassSelectCombo.SelectedValue.ToString();
                FillTermList(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillTermList(string value)
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
                int value = (int)termSelectCombo.SelectedValue;
                FillResultSection(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillResultSection(int value)
        {
            try
            {
                SqlCommand eventListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[result]", conn);
                SqlDataReader dr = eventListCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int FindTermForResult = (int)termSelectCombo.SelectedValue;
                    string FindClassForResult = ClassSelectCombo.SelectedValue.ToString();
                    int x = 0;
                    int y = 0;
                    SqlCommand FindStudentName = new SqlCommand("SELECT DISTINCT re.student_id ,fname, lname,st.roll FROM [sms].[dbo].[result] AS re INNER JOIN [sms].[dbo].[student] AS st ON re.student_id = st.student_id INNER JOIN [sms].[dbo].[person] AS pe ON st.id = pe.id WHERE re.class_id='" + FindClassForResult + "' AND re.exam_id=" + FindTermForResult + " ORDER BY st.roll", conn);
                    SqlDataReader Fdr = FindStudentName.ExecuteReader();
                    if (Fdr.HasRows)
                    {
                        Label P1_lbl = new Label();
                        P1_lbl.Location = new Point(26, 7);
                        P1_lbl.Name = "P1_lbl_1";
                        P1_lbl.Text = "Student - Name (Roll)";
                        P1_lbl.AutoSize = true;
                        P1_lbl.ForeColor = Color.DarkGreen;
                        P1_lbl.Font = new Font("Constantia", 10f, FontStyle.Bold | FontStyle.Underline);
                        resultContainer.Panel1.Controls.Add(P1_lbl);

                        Label P2_lbl = new Label();
                        P2_lbl.Location = new Point(182, 7);
                        P2_lbl.Name = "P2_lbl_2";
                        P2_lbl.Text = "Subjects - GPA (Number)";
                        P2_lbl.AutoSize = true;
                        P2_lbl.ForeColor = Color.DarkGreen;
                        P2_lbl.Font = new Font("Constantia", 10f, FontStyle.Bold | FontStyle.Underline);
                        resultContainer.Panel2.Controls.Add(P2_lbl);
                        while (Fdr.Read())
                        {
                            int IndexFname = Fdr.GetOrdinal("fname");
                            int IndexLname = Fdr.GetOrdinal("lname");
                            int IndexStudentID = Fdr.GetOrdinal("student_id");
                            int IndexRoll = Fdr.GetOrdinal("roll");

                            string Fname = Fdr.GetString(IndexFname);
                            string Lname = Fdr.GetString(IndexLname);
                            string StudentID = Fdr.GetString(IndexStudentID);
                            int Roll = Fdr.GetInt32(IndexRoll);

                            SqlCommand FindStudentResult = new SqlCommand("SELECT m_total,gpa,subject_name FROM [sms].[dbo].[result] AS re INNER JOIN [sms].[dbo].[student] AS st ON re.student_id = st.student_id INNER JOIN [sms].[dbo].[subject] AS sb ON re.subject_id = sb.subject_id WHERE re.student_id='" + StudentID + "' ORDER BY sb.subject_id", conn);
                            SqlDataReader FSRdr = FindStudentResult.ExecuteReader();
                            while (FSRdr.Read())
                            {
                                int IndexSubjectName = FSRdr.GetOrdinal("subject_name");
                                int IndexTotal = FSRdr.GetOrdinal("m_total");
                                int IndexGPA = FSRdr.GetOrdinal("gpa");

                                string SubjectName = FSRdr.GetString(IndexSubjectName);
                                int Total = FSRdr.GetInt32(IndexTotal);
                                double GPA = FSRdr.GetDouble(IndexGPA);

                                Label S_lbl = new Label();
                                S_lbl.Location = new Point(16 + (y * 107), 36);
                                S_lbl.Name = "S_lbl_" + y;
                                S_lbl.Text = SubjectName;
                                S_lbl.Font = new Font(S_lbl.Font.FontFamily, S_lbl.Font.Size , FontStyle.Underline);
                                S_lbl.AutoSize = true;
                                resultContainer.Panel2.Controls.Add(S_lbl);

                                Label V_lbl = new Label();
                                V_lbl.Location = new Point(16 + (y * 108), 65 + (x * 40));
                                V_lbl.Name = "V_lbl_" + y;
                                V_lbl.Text = GPA + " (" + Total + ")";
                                V_lbl.AutoSize = true;
                                resultContainer.Panel2.Controls.Add(V_lbl);
                                y = y + 1;
                            }

                            Label N_lbl = new Label();
                            N_lbl.Location = new Point(43, 65 + (x * 40));
                            N_lbl.Name = "N_lbl_" + x;
                            N_lbl.Text = Fname + " " + Lname + " (" + Roll + ")";
                            N_lbl.AutoSize = true;
                            resultContainer.Panel1.Controls.Add(N_lbl);
                            x = x + 1;
                            y = 0;
                        }
                    }
                    else
                    {
                        resultContainer.Panel1.Controls.Clear();
                        resultContainer.Panel2.Controls.Clear();

                        Label P1_lbl = new Label();
                        P1_lbl.Location = new Point(26, 7);
                        P1_lbl.Name = "P1_lbl_1";
                        P1_lbl.Text = "Student - Name (Roll)";
                        P1_lbl.AutoSize = true;
                        P1_lbl.ForeColor = Color.DarkGreen;
                        P1_lbl.Font = new Font("Constantia", 10f, FontStyle.Bold | FontStyle.Underline);
                        resultContainer.Panel1.Controls.Add(P1_lbl);

                        Label P2_lbl = new Label();
                        P2_lbl.Location = new Point(182, 7);
                        P2_lbl.Name = "P2_lbl_2";
                        P2_lbl.Text = "Subjects - GPA (Number)";
                        P2_lbl.AutoSize = true;
                        P2_lbl.ForeColor = Color.DarkGreen;
                        P2_lbl.Font = new Font("Constantia", 10f, FontStyle.Bold | FontStyle.Underline);
                        resultContainer.Panel2.Controls.Add(P2_lbl);
                    }
                }
                
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShiftSelectCombo.DataSource = null;
            FillShiftList();
        }

        private void btnAddNewResult_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.AddResult_Control);
        }      
    }
}
