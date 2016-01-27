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
    public partial class lblStatus : UserControl
    {
        SqlConnection conn;
        public lblStatus()
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

            SelectShiftCombo.DisplayMember = "Value";
            SelectShiftCombo.ValueMember = "Key";
            SelectShiftCombo.DataSource = new BindingSource(ShiftDictionary, null);
        }

        private void SelectShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = SelectShiftCombo.SelectedValue.ToString();
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
            SelectClassCombo.DisplayMember = "Value";
            SelectClassCombo.ValueMember = "Key";
            SelectClassCombo.DataSource = new BindingSource(classListDictionary, null);
        }

        private void SelectClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = SelectClassCombo.SelectedValue.ToString();
                FillStudentList(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillStudentList(string value)
        {
            try
            {
            SqlCommand stdListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE class_id='" + value + "'  ORDER BY roll", conn);
            SqlDataReader dr = stdListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                var studentListDictionary = new Dictionary<int, string>();
                while (dr.Read())
                {
                    int indexPersonID = dr.GetOrdinal("id");
                    int indexStudentID = dr.GetOrdinal("student_id");

                    int PersonID = dr.GetInt32(indexPersonID);
                    string StudentID = dr.GetString(indexStudentID);

                    SqlCommand IdentifyStudentCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id='" + PersonID + "'", conn);
                    SqlDataReader Sdr = IdentifyStudentCmd.ExecuteReader();
            
                    while (Sdr.Read())
                    {
                        int IndexFname = Sdr.GetOrdinal("fname");
                        int IndexLname = Sdr.GetOrdinal("lname");

                        string Fname = Sdr.GetString(IndexFname);
                        string Lname = Sdr.GetString(IndexLname);
                        studentListDictionary = studentListDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        studentListDictionary.Add(PersonID, Fname + " " + Lname);
                    }                   
                }
                stdList.DisplayMember = "Value";
                stdList.ValueMember = "Key";
                stdList.DataSource = new BindingSource(studentListDictionary, null);
            }
            else
            {
                stdList.DataSource = null;
            }
            }
            catch (NullReferenceException)
            { }            
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

        private void btnStdCreate_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.CreateStudent_Control);
        }

        private void stdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student]", conn);
                    SqlDataReader sqlDr = Cmd.ExecuteReader();
                    if (sqlDr.HasRows)
                    {
                        int val = (int)stdList.SelectedValue;

                        SqlCommand IdentifyStudentCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id='" + val + "'", conn);
                        SqlDataReader Sdr = IdentifyStudentCmd.ExecuteReader();
                        while (Sdr.Read())
                        {
                            int IndexFname = Sdr.GetOrdinal("fname");
                            int IndexLname = Sdr.GetOrdinal("lname");
                            int IndexFather = Sdr.GetOrdinal("father_name");
                            int IndexMother = Sdr.GetOrdinal("mother_name");
                            int IndexEmail = Sdr.GetOrdinal("email");
                            int IndexStreet = Sdr.GetOrdinal("street");
                            int IndexCity = Sdr.GetOrdinal("city");
                            int IndexDistrict = Sdr.GetOrdinal("district");
                            int IndexZip = Sdr.GetOrdinal("zip");
                            int IndexBloodGrp = Sdr.GetOrdinal("blood_group");

                            string Fname = Sdr.GetString(IndexFname);
                            string Lname = Sdr.GetString(IndexLname);
                            string Father = Sdr.GetString(IndexFather);
                            string Mother = Sdr.GetString(IndexMother);
                            string Email = Sdr.GetString(IndexEmail);
                            int Street = Sdr.GetInt32(IndexStreet);
                            string City = Sdr.GetString(IndexCity);
                            string District = Sdr.GetString(IndexDistrict);
                            int Zip = Sdr.GetInt32(IndexZip);
                            string BloodGrp = Sdr.GetString(IndexBloodGrp);

                            lblNameTxt.Text = Fname + " " + Lname;
                            lblFatherTxt.Text = Father;
                            lblMotherTxt.Text = Mother;
                            lblBloodTxt.Text = BloodGrp;
                            lblEmailTxt.Text = Email;
                            lblStreetTxt.Text = Street.ToString();
                            lblCityTxt.Text = City;
                            lblDistrictTxt.Text = District;
                            lblZipTxt.Text = Zip.ToString();

                            SqlCommand GetStudentInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE id='" + val + "'", conn);
                            SqlDataReader GSIcmd = GetStudentInfoCmd.ExecuteReader();
                            if (GSIcmd.HasRows)
                            {
                                while (GSIcmd.Read())
                                {
                                    int IndexClassID = GSIcmd.GetOrdinal("class_id");
                                    int IndexRoll = GSIcmd.GetOrdinal("roll");
                                    int IndexGcontact = GSIcmd.GetOrdinal("guardian_contact");
                                    int IndexStatus = GSIcmd.GetOrdinal("status");

                                    string ClassID = GSIcmd.GetString(IndexClassID);
                                    int Roll = GSIcmd.GetInt32(IndexRoll);
                                    int GContact = GSIcmd.GetInt32(IndexGcontact);
                                    int Status = GSIcmd.GetInt32(IndexStatus);

                                    lblRollTxt.Text = Roll.ToString();
                                    lblGuardianTxt.Text = GContact.ToString();
                                    if (Status == 1)
                                    {
                                        lblStatusTxt.Text = "Current Student";
                                    }
                                    else if (Status == 0)
                                    {
                                        lblStatusTxt.Text = "Ex Student";
                                    }

                                    SqlCommand GetClassInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE class_id='" + ClassID + "'", conn);
                                    SqlDataReader GCIcmd = GetClassInfoCmd.ExecuteReader();
                                    if (GCIcmd.HasRows)
                                    {
                                        while (GCIcmd.Read())
                                        {
                                            int IndexShift = GCIcmd.GetOrdinal("shift");
                                            int IndexSection = GCIcmd.GetOrdinal("section");

                                            string Shift = GCIcmd.GetString(IndexShift);
                                            string Section = GCIcmd.GetString(IndexSection);

                                            lblShiftTxt.Text = Shift;
                                            lblSectionTxt.Text = Section;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else { }
                }
                catch (InvalidCastException)
                {
                }
            }
            catch (NullReferenceException) { }
        }

        private void btnStdEdit_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.EditStudent_Control);
        }

        private void btnStdDelete_Click(object sender, EventArgs e)
        {
            int val = (int)stdList.SelectedValue;
            string message = "Do you want to delete this entry?";
            string caption = "Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand StudentDeleteCmd = new SqlCommand("DELETE FROM [sms].[dbo].[student] WHERE id=" + val, conn);
                StudentDeleteCmd.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully!");
            } 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            stdList.DataSource = null;
            SelectClassCombo.DataSource = null;
            SelectShiftCombo.DataSource = null;
            FillShiftList();
        }
    }
}
