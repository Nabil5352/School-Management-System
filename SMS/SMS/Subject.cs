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
    public partial class Subject : UserControl
    {
        SqlConnection conn;
        public Subject()
        {
            InitializeComponent();
            createNewPanel.Hide();
            btnSubjectMain.Hide();
            EditPanel.Hide();
            btnEdit2Main.Hide();
            FillClassList();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            classListCombo.DataSource = null;
            classList.DataSource = null;
            FillClassList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillClassList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            Dictionary<int, string> list = new Dictionary<int, string>();

            list.Add(1 ,"Class One");
            list.Add(2, "Class Two");
            list.Add(3, "Class Three");
            list.Add(4, "Class Four");
            list.Add(5, "Class Five");
            list.Add(6, "Class Six");
            list.Add(7, "Class Seven");
            list.Add(8, "Class Eight");
            list.Add(9, "Class Nine");
            list.Add(10, "Class Ten");

            classListCombo.DisplayMember = "Value";
            classListCombo.ValueMember = "Key";
            classListCombo.DataSource = new BindingSource(list, null);
        }

        private void classListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = (int)classListCombo.SelectedValue;
                FillSubjectData(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillSubjectData(int value)
        {
            try
            {
                SqlCommand SubjectCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[subject]", conn);
                SqlDataReader subjctdr = SubjectCmd.ExecuteReader();
                if (subjctdr.HasRows)
                {
                    int val = (int)classListCombo.SelectedValue;
                    var SubjectDictionary = new Dictionary<string, string>();
                    SqlCommand findsubjectCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[subject] WHERE class_id=" + val, conn);
                    SqlDataReader fsdr = findsubjectCmd.ExecuteReader();

                      while (fsdr.Read())
                      {
                         int indexSName = fsdr.GetOrdinal("subject_name");
                         int indexSid = fsdr.GetOrdinal("subject_id");

                         string SName = fsdr.GetString(indexSName);
                         string Sid = fsdr.GetString(indexSid);
                         SubjectDictionary = SubjectDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                         SubjectDictionary.Add(Sid, SName);
                      }                      
                    classList.DisplayMember = "Value";
                    classList.ValueMember = "Key";
                    classList.DataSource = new BindingSource(SubjectDictionary, null);
                }
                else
                { }
            }
            catch (NullReferenceException)
            { }
        }  

        private void classList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand SubjectCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[subject]", conn);
                SqlDataReader subjctdr = SubjectCmd.ExecuteReader();

                //Measure subject ID
                int classValue = (int)classListCombo.SelectedValue;
                SqlCommand MeasureSubjectIDtd = new SqlCommand("SELECT count(*) FROM [sms].[dbo].[subject] WHERE class_id =" + classValue, conn);
                MeasureSubjectIDtd.CommandType = CommandType.Text;
                var Count = (Int32)MeasureSubjectIDtd.ExecuteScalar();
                var sID = Count + 1;
                subjectIDtxt.Text = "c" + classValue + "s" + sID;

                if (subjctdr.HasRows)
                {
                    string val = classList.SelectedValue.ToString();

                    SqlCommand CountSubjectCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[subject] WHERE subject_id='"+val+"'", conn);
                    SqlDataReader dr = CountSubjectCmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            int indexSubjectID = dr.GetOrdinal("subject_id");
                            int indexSubjectName = dr.GetOrdinal("subject_name");
                            int indexTeacher = dr.GetOrdinal("teach_id");
                            int indexCT = dr.GetOrdinal("ct");
                            int indexPresence = dr.GetOrdinal("percentage");
                            int indexTotal = dr.GetOrdinal("total_marks");

                            string SID = dr.GetString(indexSubjectID);
                            string SName = dr.GetString(indexSubjectName);
                            string Teacher = dr.GetString(indexTeacher);
                            int CT = dr.GetInt32(indexCT);
                            int Presence = dr.GetInt32(indexPresence);
                            int Total = dr.GetInt32(indexTotal);
                            int Written = Total - (CT + Presence);

                            SqlCommand SeekTeacherNameCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher] tr, [sms].[dbo].[person] pr WHERE tr.id = pr.id AND teach_id='" + Teacher + "'", conn);
                            SqlDataReader stNdr = SeekTeacherNameCmd.ExecuteReader();
                            if (stNdr.HasRows)
                            {
                                while (stNdr.Read())
                                {
                                    int indexFname = stNdr.GetOrdinal("fname");
                                    int indexLname = stNdr.GetOrdinal("lname");

                                    string firstname = stNdr.GetString(indexFname);
                                    string lastname = stNdr.GetString(indexLname);

                                    lblTeacherNameTxt.Text = firstname + " " + lastname;
                                    teachNameTxt.Text = firstname + " " + lastname;
                                }
                            }
                            else
                            {
                                lblTeacherNameTxt.Text = Teacher;
                                teachNameTxt.Text = Teacher;
                            }

                            //Main view
                            lblSubjectTxt.Text = SName;                           
                            lblWrittenTxt.Text = Written.ToString();
                            lblCTtxt.Text = CT.ToString();
                            lblPresenceTxt.Text = Presence.ToString();
                            lblTotalMarksTxt.Text = Total.ToString();

                            //Create view
                            var dictionary = new Dictionary<string, string>();
                            SqlCommand SeekTeacherListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher] tr, [sms].[dbo].[person] pr WHERE tr.id = pr.id", conn);
                            SqlDataReader stldr = SeekTeacherListCmd.ExecuteReader();
                            if (stldr.HasRows)
                            {
                                while (stldr.Read())
                                {
                                    int indexFname = stldr.GetOrdinal("fname");
                                    int indexLname = stldr.GetOrdinal("lname");
                                    int indexteachId = stldr.GetOrdinal("teach_id");

                                    string firstname = stldr.GetString(indexFname);
                                    string lastname = stldr.GetString(indexLname);
                                    string teachID = stldr.GetString(indexteachId);
                                    dictionary.Add(teachID, firstname + " " + lastname);
                                }
                            }
                            teacherTxt.DisplayMember = "Value";
                            teacherTxt.ValueMember = "Key";
                            teacherTxt.DataSource = new BindingSource(dictionary, null);

                            //Edit view
                            snameTxt.Text = SName;                           
                            selectTeacherTxt.DisplayMember = "Value";
                            selectTeacherTxt.ValueMember = "Key";
                            selectTeacherTxt.DataSource = new BindingSource(dictionary, null);
                            changeCTtxt.Text = CT.ToString();
                            changePresenceTxt.Text = Presence.ToString();
                            changeTmarksTxt.Text = Total.ToString();
                        }
                    }
                    else
                    {
                        lblSubjectTxt.Text = "-";
                        lblTeacherNameTxt.Text = "-";
                        lblWrittenTxt.Text = "-";
                        lblCTtxt.Text = "-";
                        lblPresenceTxt.Text = "-";
                        lblTotalMarksTxt.Text = "-";
                        snameTxt.Text = "-";
                        teachNameTxt.Text = "-";
                        changeCTtxt.Text = "-";
                        changePresenceTxt.Text = "-";
                        changeTmarksTxt.Text = "-";
                    }
                }
                else
                {}
            }
            catch (NullReferenceException)
            {}
        }

        private void btnSubjectCreate_Click(object sender, EventArgs e)
        {
            subjectDetails.Hide();
            createNewPanel.Visible = true;
            EditPanel.Visible = false;
            btnEdit2Main.Hide();
            btnSubjectEdit.Show();
            btnSubjectMain.Show();
        }

        private void btnSubjectMain_Click(object sender, EventArgs e)
        {
            subjectDetails.Show();
            createNewPanel.Hide();
            btnSubjectMain.Hide();
        }

        private void btnSubjectEdit_Click(object sender, EventArgs e)
        {
            subjectDetails.Hide();
            createNewPanel.Visible = false;
            btnSubjectMain.Hide();
            btnSubjectEdit.Hide();
            EditPanel.Visible = true;
            btnEdit2Main.Show();
            //Program.MainWindow.ShowControl(SequenceEnum.EditSubject_Control);
        }

        private void btnEdit2Main_Click(object sender, EventArgs e)
        {
            subjectDetails.Show();
            btnSubjectEdit.Show();
            EditPanel.Hide();
            btnEdit2Main.Hide();
        }

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            string val = classList.SelectedValue.ToString();

            string message = "Do you want to delete this subject?";
            string caption = "Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand SubjectDeleteCmd = new SqlCommand("DELETE FROM [sms].[dbo].[subject] WHERE subject_id='" + val + "'", conn);
                SubjectDeleteCmd.ExecuteNonQuery();
                classListCombo.DataSource = null;
                classList.DataSource = null;
                FillClassList();
                MessageBox.Show("Deleted successfully!");
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var classID = classListCombo.SelectedValue;
                var subjectID = subjectIDtxt.Text;
                var subjectName = subjectNameTxt.Text;
                var teacherID = teacherTxt.SelectedValue;
                var ct = ctTxt.Text;
                var presence = presenceTxt.Text;
                var total = totalMarksTxt.Text;

                if (classID != "" & subjectID != "" & subjectName != "" & ct != "" & presence != "" & total != "")
                {
                    SqlCommand insertValueCmd = new SqlCommand("INSERT INTO [sms].[dbo].[subject](subject_id, subject_name, class_id, teach_id, ct, percentage, total_marks) " +
                    "VALUES (@SubjectID, @SubjectName, @class_id, @teach_id, @ct, @percentage, @total_marks)", conn);
                    insertValueCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    insertValueCmd.Parameters.AddWithValue("@SubjectName", subjectName);
                    insertValueCmd.Parameters.AddWithValue("@class_id", classID);
                    insertValueCmd.Parameters.AddWithValue("@teach_id", teacherID);
                    insertValueCmd.Parameters.AddWithValue("@ct", ct);
                    insertValueCmd.Parameters.AddWithValue("@percentage", presence);
                    insertValueCmd.Parameters.AddWithValue("@total_marks", total);

                    insertValueCmd.ExecuteNonQuery();
                    classListCombo.DataSource = null;
                    classList.DataSource = null;
                    subjectIDtxt.Text = "";
                    subjectNameTxt.Text = "";
                    ctTxt.Text = "";
                    presenceTxt.Text = "";
                    totalMarksTxt.Text = "";
                    FillClassList();

                    MessageBox.Show("New subject added successfully!");
                }
                else
                {
                    MessageBox.Show("You can't leave a required field blank!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            subjectDetails.Show();
            createNewPanel.Hide();
            btnSubjectMain.Hide();
        }

        private void btnSubjectEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                int value = (int)classListCombo.SelectedValue;
                string val = classList.SelectedValue.ToString();

                var subjectName = snameTxt.Text;
                var teacherID = selectTeacherTxt.SelectedValue;
                var ct = changeCTtxt.Text;
                var presence = changePresenceTxt.Text;
                var total = changeTmarksTxt.Text;

                if (subjectName != "" & ct != "" & presence != "" & total != "")
                {
                    SqlCommand UpdateValueCmd = new SqlCommand("UPDATE [sms].[dbo].[subject]" +
                    "SET subject_name=@SubjectName, teach_id=@teach_id, ct=@ct, percentage=@percentage, total_marks=@total_marks WHERE subject_id='" + val + "' and class_id=" + value, conn);
                    UpdateValueCmd.Parameters.AddWithValue("@SubjectName", subjectName);
                    UpdateValueCmd.Parameters.AddWithValue("@teach_id", teacherID);
                    UpdateValueCmd.Parameters.AddWithValue("@ct", ct);
                    UpdateValueCmd.Parameters.AddWithValue("@percentage", presence);
                    UpdateValueCmd.Parameters.AddWithValue("@total_marks", total);

                    UpdateValueCmd.ExecuteNonQuery();
                    classListCombo.DataSource = null;
                    classList.DataSource = null;
                    FillClassList();

                    MessageBox.Show("You can't leave a required field blank!");
                }
                else
                {
                    MessageBox.Show("Information updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubjectEditCancel_Click(object sender, EventArgs e)
        {
            subjectDetails.Show();
            btnSubjectEdit.Show();
            EditPanel.Hide();
            btnEdit2Main.Hide();
        }
    }
}