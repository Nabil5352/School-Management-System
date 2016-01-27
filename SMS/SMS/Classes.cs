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
    public partial class Classes : UserControl
    {
        SqlConnection conn;
        public Classes()
        {
            InitializeComponent();
            FillShiftInfo();
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

            var classDictionary = new Dictionary<string, string>();
            SqlCommand classListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='"+val+"' ORDER BY class_id", conn);
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

                    classDictionary.Add(classID, "Class - "+className+" ("+classSection+")");
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
                        int indexclass = dr.GetOrdinal("class");
                        int indextotalstudent = dr.GetOrdinal("total_student");
                        int indexCoordinator = dr.GetOrdinal("coordinator");
                        int indexCR = dr.GetOrdinal("class_captain");
                        int indexSpecial = dr.GetOrdinal("special_care");

                        string Class = dr.GetString(indexclass);
                        int TotalStudent = dr.GetInt32(indextotalstudent);
                        string Coordinator = dr.GetString(indexCoordinator);
                        string CR = dr.GetString(indexCR);
                        string Special_care = dr.GetString(indexSpecial);

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

                                        lblClsInfoCTeacherTxt.Text = Fname + " " + Lname;
                                    }
                                }
                            }
                        }
                        else 
                        {
                            lblClsInfoCTeacherTxt.Text = "-";
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

                                        lblClsInfoCCaptainTxt.Text = CRFname + " " + CRLname;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lblClsInfoCCaptainTxt.Text = "-";
                        }

                        lblClsInfoClassTxt.Text = Class;
                        lblClsInfoStdNoTxt.Text = TotalStudent.ToString();
                        lblClsInfoSpecialTxt.Text = Special_care;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btnClsEdit_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.EditClass_Control);
        }

        private void btnClsProgress_Click(object sender, EventArgs e)
        {

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
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
