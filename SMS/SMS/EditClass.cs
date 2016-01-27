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
    public partial class EditClass : UserControl
    {
        SqlConnection conn;
        public EditClass()
        {
            InitializeComponent();
            FillShiftInfo();
            selectTeacherCombo.Hide();
            btnChangeTeachSave.Hide();
            selectCrCombo.Hide();
            btnChangeCRSave.Hide();
        }

        private void FillShiftInfo()
        {
            var ShiftDictionary = new Dictionary<string, string>();
            ShiftDictionary.Add("Morning", "Morning");
            ShiftDictionary.Add("Day", "Day");

            selectShiftCombo.DisplayMember = "Value";
            selectShiftCombo.ValueMember = "Key";
            selectShiftCombo.DataSource = new BindingSource(ShiftDictionary, null);
        }

        private void selectShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = selectShiftCombo.SelectedValue.ToString();
                FillClassData(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        public void FillClassData(string val)
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            //Fill Class data
            var classDictionary = new Dictionary<string, string>();
            SqlCommand classListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='" + val + "' ORDER BY class_id", conn);
            SqlDataReader dr = classListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int indexclassName = dr.GetOrdinal("class");
                    int indexsection = dr.GetOrdinal("section");
                    int indexshift = dr.GetOrdinal("shift");
                    int indexclass_id = dr.GetOrdinal("class_id");

                    string className = dr.GetString(indexclassName);
                    string classSection = dr.GetString(indexsection);
                    string classShift = dr.GetString(indexshift);
                    string classID = dr.GetString(indexclass_id);

                    classDictionary.Add(classID, "Class - " + className + " (" + classSection + ")");
                }
            }
            clsList.DisplayMember = "Value";
            clsList.ValueMember = "Key";
            clsList.DataSource = new BindingSource(classDictionary, null);
        }

        private void clsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string val = clsList.SelectedValue.ToString();

                SqlCommand selectedItemCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE class_id='" + val + "'", conn);
                SqlDataReader dr = selectedItemCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int indextotalstudent = dr.GetOrdinal("total_student");
                        int indexCoordinator = dr.GetOrdinal("coordinator");
                        int indexCR = dr.GetOrdinal("class_captain");
                        int indexSpecial = dr.GetOrdinal("special_care");

                        int TotalStudent = dr.GetInt32(indextotalstudent);
                        string Coordinator = dr.GetString(indexCoordinator);
                        string CR = dr.GetString(indexCR);
                        string Special_care = dr.GetString(indexSpecial);

                        //Total student
                        studentTxt.Text = TotalStudent.ToString();

                        //Check and find classteacher name
                        SqlCommand findTeacher = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher] WHERE teach_id='" + Coordinator + "'", conn);
                        SqlDataReader ftdr = findTeacher.ExecuteReader();
                        if (ftdr.HasRows)
                        {
                            while (ftdr.Read())
                            {
                                int IndexPersonID = ftdr.GetOrdinal("id");
                                int PersonID = ftdr.GetInt32(IndexPersonID);

                                SqlCommand findTeacherName = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id=" + PersonID, conn);
                                SqlDataReader ftndr = findTeacherName.ExecuteReader();
                                if (ftndr.HasRows)
                                {
                                    while (ftndr.Read())
                                    {
                                        int IndexPersonFname = ftndr.GetOrdinal("fname");
                                        int IndexPersonLname = ftndr.GetOrdinal("lname");

                                        string Fname = ftndr.GetString(IndexPersonFname);
                                        string Lname = ftndr.GetString(IndexPersonLname);

                                        lblCurrentTeachTxt.Text = Fname + " " + Lname;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lblCurrentTeachTxt.Text = "-";
                        }

                        //Check and find CR name
                        SqlCommand findCR = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE student_id='" + CR + "'", conn);
                        SqlDataReader fcrdr = findCR.ExecuteReader();
                        if (fcrdr.HasRows)
                        {
                            while (fcrdr.Read())
                            {
                                int IndexPersonID = fcrdr.GetOrdinal("id");
                                int PersonID = fcrdr.GetInt32(IndexPersonID);

                                SqlCommand findCRName = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id=" + PersonID, conn);
                                SqlDataReader fcrndr = findCRName.ExecuteReader();
                                if (fcrndr.HasRows)
                                {
                                    while (fcrndr.Read())
                                    {
                                        int IndexPersonFname = fcrndr.GetOrdinal("fname");
                                        int IndexPersonLname = fcrndr.GetOrdinal("lname");

                                        string CRFname = fcrndr.GetString(IndexPersonFname);
                                        string CRLname = fcrndr.GetString(IndexPersonLname);

                                        lblCRTxt.Text = CRFname + " " + CRLname;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lblCRTxt.Text = "-";
                        }
                        //Special care
                        careTxt.Text = Special_care;
                    }
                }

                //Fill classTeacher list
                var teacherListDictionary = new Dictionary<string, string>();
                SqlCommand teachListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher]", conn);
                SqlDataReader Tdr = teachListCmd.ExecuteReader();
                if (Tdr.HasRows)
                {
                    while (Tdr.Read())
                    {
                        int IndexID = Tdr.GetOrdinal("id");
                        int IndexTeachID = Tdr.GetOrdinal("teach_id");

                        int PersonID = Tdr.GetInt32(IndexID);
                        string TeachID = Tdr.GetString(IndexTeachID);

                        SqlCommand FindTeachCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id=" + PersonID, conn);
                        SqlDataReader TPdr = FindTeachCmd.ExecuteReader();

                        if (TPdr.HasRows)
                        {
                            if (TPdr.Read())
                            {
                                int IndexFname = TPdr.GetOrdinal("fname");
                                int IndexLname = TPdr.GetOrdinal("lname");

                                string Fname = TPdr.GetString(IndexFname);
                                string Lname = TPdr.GetString(IndexLname);

                                teacherListDictionary.Add(TeachID, Fname + " " + Lname);
                            }
                        }
                    }
                }
                selectTeacherCombo.DisplayMember = "Value";
                selectTeacherCombo.ValueMember = "Key";
                selectTeacherCombo.DataSource = new BindingSource(teacherListDictionary, null);

                //Fill studentList
                var studentListDictionary = new Dictionary<string, string>();
                SqlCommand stdListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE class_id='" + val + "'", conn);
                SqlDataReader Sdr = stdListCmd.ExecuteReader();
                if (Sdr.HasRows)
                {
                    while (Sdr.Read())
                    {
                        int indexPersonID = Sdr.GetOrdinal("id");
                        int indexStudentID = Sdr.GetOrdinal("student_id");

                        int PersonID = Sdr.GetInt32(indexPersonID);
                        string StudentID = Sdr.GetString(indexStudentID);

                        SqlCommand IdentifyStudentCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id='" + PersonID + "'", conn);
                        SqlDataReader SPdr = IdentifyStudentCmd.ExecuteReader();
                        while (SPdr.Read())
                        {
                            int IndexFname = SPdr.GetOrdinal("fname");
                            int IndexLname = SPdr.GetOrdinal("lname");

                            string Fname = SPdr.GetString(IndexFname);
                            string Lname = SPdr.GetString(IndexLname);
                            studentListDictionary.Add(StudentID, Fname + " " + Lname);
                        }

                        selectCrCombo.DisplayMember = "Value";
                        selectCrCombo.ValueMember = "Key";
                        selectCrCombo.DataSource = new BindingSource(studentListDictionary, null);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectShiftCombo.DataSource = null;
            clsList.DataSource = null;
            FillShiftInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Class_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClassEditSave_Click(object sender, EventArgs e)
        {
            string val = clsList.SelectedValue.ToString();

            var StudentNum = studentTxt.Text;
            var Special_care = careTxt.Text;

            if (StudentNum != "")
            {
                SqlCommand UpdatePersonCmd = new SqlCommand("UPDATE [sms].[dbo].[class]" +
                   "set total_student=@studentNum, special_care=@care WHERE class_id='" + val + "'", conn);

                UpdatePersonCmd.Parameters.AddWithValue("@studentNum", StudentNum);
                UpdatePersonCmd.Parameters.AddWithValue("@care", Special_care);

                UpdatePersonCmd.ExecuteNonQuery();
                selectShiftCombo.DataSource = null;
                clsList.DataSource = null;
                FillShiftInfo();
                MessageBox.Show("Class Information updated!!");
            }
            else
            {
                MessageBox.Show("You can't leave a required field blank!");
            }
        }

        private void btnClassEditCancel_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Class_Control);
        }

        private void lblChangeTeach_Click(object sender, EventArgs e)
        {
            selectTeacherCombo.Show();
            btnChangeTeachSave.Show();
            lblChangeTeach.Hide(); 
        }

        private void btnChangeTeachSave_Click(object sender, EventArgs e)
        {
            string val = clsList.SelectedValue.ToString();
            var teachID = selectTeacherCombo.SelectedValue;

            SqlCommand UpdateClassTeacherCmd = new SqlCommand("UPDATE [sms].[dbo].[class] set coordinator=@teach_id WHERE class_id='" + val + "'", conn);
            UpdateClassTeacherCmd.Parameters.AddWithValue("@teach_id", teachID);
            UpdateClassTeacherCmd.ExecuteNonQuery();
            MessageBox.Show("Classteacher added!");

            selectTeacherCombo.Hide();
            btnChangeTeachSave.Hide();
            lblChangeTeach.Show();
            selectShiftCombo.DataSource = null;
            clsList.DataSource = null;
            FillShiftInfo();
        }

        private void btnChangeCR_Click(object sender, EventArgs e)
        {
            selectCrCombo.Show();
            btnChangeCRSave.Show();
            btnChangeCR.Hide();
        }

        private void btnChangeCRSave_Click(object sender, EventArgs e)
        {
            string val = clsList.SelectedValue.ToString();
            var StudentID = selectCrCombo.SelectedValue;

            SqlCommand UpdateCRCmd = new SqlCommand("UPDATE [sms].[dbo].[class] set class_captain=@cr WHERE class_id='" + val + "'", conn);
            UpdateCRCmd.Parameters.AddWithValue("@cr", StudentID);
            UpdateCRCmd.ExecuteNonQuery();
            MessageBox.Show("Class CR added!");

            selectCrCombo.Hide();
            btnChangeCRSave.Hide();
            btnChangeCR.Show();
            selectShiftCombo.DataSource = null;
            clsList.DataSource = null;
            FillShiftInfo();
        }
    }
}
