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
    public partial class EditStudent : UserControl
    {
        SqlConnection conn;
        public EditStudent()
        {
            InitializeComponent();
            SelectLeaveYearCmbox.Enabled = false;
            FillSthiftList();
            FillStatusInfo();
        }

        private void FillSthiftList()
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

            selectShift.DisplayMember = "Value";
            selectShift.ValueMember = "Key";
            selectShift.DataSource = new BindingSource(ShiftDictionary, null);

            var DistrictDictionary = new Dictionary<string, string>();
            //B
            DistrictDictionary.Add("Bagerhat", "Bagerhat");
            DistrictDictionary.Add("Bandarban", "Bandarban");
            DistrictDictionary.Add("Barguna", "Barguna");
            DistrictDictionary.Add("Barisal", "Barisal");
            DistrictDictionary.Add("Bhola", "Bhola");
            DistrictDictionary.Add("Bogra", "Bogra");
            DistrictDictionary.Add("Brahmanbaria", "Brahmanbaria");
            //C
            DistrictDictionary.Add("Chandpur", "Chandpur");
            DistrictDictionary.Add("Chittagong", "Chittagong");
            DistrictDictionary.Add("Chuadanga", "Chuadanga");
            DistrictDictionary.Add("Comilla", "Comilla");
            DistrictDictionary.Add("Cox's Bazar", "Cox's Bazar");
            //D
            DistrictDictionary.Add("Dhaka", "Dhaka");
            DistrictDictionary.Add("Dinajpur", "Dinajpur");
            //F
            DistrictDictionary.Add("Faridpur", "Faridpur");
            DistrictDictionary.Add("Feni", "Feni");
            //G
            DistrictDictionary.Add("Gaibandha", "Gaibandha");
            DistrictDictionary.Add("Gazipur", "Gazipur");
            DistrictDictionary.Add("Gopalganj", "Gopalganj");
            //H
            DistrictDictionary.Add("Habiganj", "Habiganj");
            //J
            DistrictDictionary.Add("Jamalpur", "Jamalpur");
            DistrictDictionary.Add("Jaypurhat", "Jaypurhat");
            DistrictDictionary.Add("Jessore", "Jessore");
            DistrictDictionary.Add("Jhalokati", "Jhalokati");
            DistrictDictionary.Add("Jhenaidah", "Jhenaidah");
            //K
            DistrictDictionary.Add("Khagrachhari", "Khagrachhari");
            DistrictDictionary.Add("Khulna", "Khulna");
            DistrictDictionary.Add("Kishoreganj", "Kishoreganj");
            DistrictDictionary.Add("Kurigram", "Kurigram");
            DistrictDictionary.Add("Kushtia", "Kushtia");
            //L
            DistrictDictionary.Add("Lakshmipur", "Lakshmipur");
            DistrictDictionary.Add("Lalmonirhat", "Lalmonirhat");
            //M
            DistrictDictionary.Add("Madaripur", "Madaripur");
            DistrictDictionary.Add("Magura", "Magura");
            DistrictDictionary.Add("Manikganj", "Manikganj");
            DistrictDictionary.Add("Meherpur", "Meherpur");
            DistrictDictionary.Add("Moulvibazar", "Moulvibazar");
            DistrictDictionary.Add("Munshiganj", "Munshiganj");
            DistrictDictionary.Add("Mymensingh", "Mymensingh");
            //N
            DistrictDictionary.Add("Naogaon", "Naogaon");
            DistrictDictionary.Add("Narayanganj", "Narayanganj");
            DistrictDictionary.Add("Narail", "Narail");
            DistrictDictionary.Add("Narsingdi", "Narsingdi");
            DistrictDictionary.Add("Natore", "Natore");
            DistrictDictionary.Add("Nawabganj", "Nawabganj");
            DistrictDictionary.Add("Netrakona", "Netrakona");
            DistrictDictionary.Add("Nilphamari", "Nilphamari");
            DistrictDictionary.Add("Noakhali", "Noakhali");
            //P
            DistrictDictionary.Add("Pabna", "Pabna");
            DistrictDictionary.Add("Panchagarh", "Panchagarh");
            DistrictDictionary.Add("Patuakhali", "Patuakhali");
            DistrictDictionary.Add("Pirojpur", "Pirojpur");
            //R
            DistrictDictionary.Add("Rajbari", "Rajbari");
            DistrictDictionary.Add("Rajshahi", "Rajshahi");
            DistrictDictionary.Add("Rangamati", "Rangamati");
            DistrictDictionary.Add("Rangpur", "Rangpur");
            //S
            DistrictDictionary.Add("Satkhira", "Satkhira");
            DistrictDictionary.Add("Shariatpur", "Shariatpur");
            DistrictDictionary.Add("Sherpur", "Sherpur");
            DistrictDictionary.Add("Sirajganj", "Sirajganj");
            DistrictDictionary.Add("Sunamganj", "Sunamganj");
            DistrictDictionary.Add("Sylhet", "Sylhet");
            //T
            DistrictDictionary.Add("Tangail", "Tangail");
            DistrictDictionary.Add("Thakurgaon", "Thakurgaon");

            districtTxt.DisplayMember = "Value";
            districtTxt.ValueMember = "Key";
            districtTxt.DataSource = new BindingSource(DistrictDictionary, null);

            //Select the year
            var YearDictionary = new Dictionary<int, int>();
            DateTime dt = DateTime.Now;
            YearDictionary.Add(0, 0);
            for (int i = 1987; i <= dt.Year; i++)
            {
                YearDictionary.Add(i, i);
            }

            SelectLeaveYearCmbox.DisplayMember = "Value";
            SelectLeaveYearCmbox.ValueMember = "Key";
            SelectLeaveYearCmbox.DataSource = new BindingSource(YearDictionary, null);
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

        private void selectShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = selectShift.SelectedValue.ToString();
                FillClassBoxInfo(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillClassBoxInfo(string value)
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
            SelectClassCmbox.DisplayMember = "Value";
            SelectClassCmbox.ValueMember = "Key";
            SelectClassCmbox.DataSource = new BindingSource(classListDictionary, null);
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
                var studentListDictionary = new Dictionary<int, string>();
                SqlCommand stdListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE class_id='" + value + "'", conn);
                SqlDataReader dr = stdListCmd.ExecuteReader();
                if (dr.HasRows)
                {
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
            {}
        }

        private void FillStatusInfo()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            var ExOrCurrentDictionary = new Dictionary<int, string>();
            ExOrCurrentDictionary.Add(1, "Current");
            ExOrCurrentDictionary.Add(0, "Ex");

            lblStatusSelect.DisplayMember = "Value";
            lblStatusSelect.ValueMember = "Key";
            lblStatusSelect.DataSource = new BindingSource(ExOrCurrentDictionary, null);
        }

        private void lblStatusSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = (int)lblStatusSelect.SelectedValue;
                StatusLabel(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void StatusLabel(int value)
        {
            if (value == 0)
            {
                SelectLeaveYearCmbox.Enabled = true;
            }
            else { }
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
                            int IndexEmail = Sdr.GetOrdinal("email");
                            int IndexStreet = Sdr.GetOrdinal("street");
                            int IndexCity = Sdr.GetOrdinal("city");
                            int IndexDistrict = Sdr.GetOrdinal("district");
                            int IndexZip = Sdr.GetOrdinal("zip");

                            string Email = Sdr.GetString(IndexEmail);
                            int Street = Sdr.GetInt32(IndexStreet);
                            string City = Sdr.GetString(IndexCity);
                            string District = Sdr.GetString(IndexDistrict);
                            int Zip = Sdr.GetInt32(IndexZip);

                            EmailTxt.Text = Email;
                            streetTxt.Text = Street.ToString();
                            CityTxt.Text = City;
                            districtTxt.Text = District;
                            zipTxt.Text = Zip.ToString();

                            SqlCommand GetStudentInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[student] WHERE id='" + val + "'", conn);
                            SqlDataReader GSIcmd = GetStudentInfoCmd.ExecuteReader();
                            if (GSIcmd.HasRows)
                            {
                                while (GSIcmd.Read())
                                {
                                    int IndexClassID = GSIcmd.GetOrdinal("class_id");
                                    int IndexRoll = GSIcmd.GetOrdinal("roll");
                                    int IndexLeaveYr = GSIcmd.GetOrdinal("leaving_year");
                                    int IndexGcontact = GSIcmd.GetOrdinal("guardian_contact");
                                    int IndexStatus = GSIcmd.GetOrdinal("status");

                                    string ClassID = GSIcmd.GetString(IndexClassID);
                                    int Roll = GSIcmd.GetInt32(IndexRoll);
                                    int LeaveYr = GSIcmd.GetInt32(IndexLeaveYr);
                                    int GContact = GSIcmd.GetInt32(IndexGcontact);
                                    int Status = GSIcmd.GetInt32(IndexStatus);

                                    RollTxt.Text = Roll.ToString();
                                    SelectLeaveYearCmbox.Text = LeaveYr.ToString();
                                    GContactTxt.Text = GContact.ToString();
                                    if (Status == 1)
                                    {
                                        lblCurrent.Text = "Current Student";
                                    }
                                    else if (Status == 0)
                                    {
                                        lblCurrent.Text = "Ex Student";
                                    }

                                    SqlCommand GetClassInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE class_id='" + ClassID + "'", conn);
                                    SqlDataReader GCIcmd = GetClassInfoCmd.ExecuteReader();
                                    if (GCIcmd.HasRows)
                                    {
                                        while (GCIcmd.Read())
                                        {
                                            int IndexClass = GCIcmd.GetOrdinal("class");
                                            int IndexShift = GCIcmd.GetOrdinal("shift");
                                            int IndexSection = GCIcmd.GetOrdinal("section");

                                            string Class = GCIcmd.GetString(IndexClass);
                                            string Shift = GCIcmd.GetString(IndexShift);
                                            string Section = GCIcmd.GetString(IndexSection);
                                            SelectClassCmbox.Text = Class + " - (" + Section + ")";
                                            selectShift.Text = Shift;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Students_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStdEditSave_Click(object sender, EventArgs e)
        {
            int val = (int)stdList.SelectedValue;

            var Status = lblStatusSelect.SelectedValue;
            var Class = SelectClassCmbox.SelectedValue;
            var Roll = RollTxt.Text;
            var LeaveYr = SelectLeaveYearCmbox.SelectedValue;
            var Contact = GContactTxt.Text;
            var Email = EmailTxt.Text;
            var Street = int.Parse(streetTxt.Text);
            var Zip = int.Parse(zipTxt.Text);
            var City = CityTxt.Text;
            var District = districtTxt.SelectedValue;

            if (Roll != "" & Email != "" & City != "")
            {
                SqlCommand UpdateStudentCmd = new SqlCommand("UPDATE [sms].[dbo].[student]" +
                   "set class_id=@class, roll=@roll, leaving_year=@leaveYr, guardian_contact=@contact, status=@status WHERE id=" + val, conn);

                UpdateStudentCmd.Parameters.AddWithValue("@class", Class);
                UpdateStudentCmd.Parameters.AddWithValue("@roll", Roll);
                UpdateStudentCmd.Parameters.AddWithValue("@leaveYr", LeaveYr);
                UpdateStudentCmd.Parameters.AddWithValue("@contact", Contact);
                UpdateStudentCmd.Parameters.AddWithValue("@status", Status);

                SqlCommand UpdatePersonCmd = new SqlCommand("UPDATE [sms].[dbo].[person]" +
                       "set email=@email, street=@street, city=@city, district=@district, zip=@zip WHERE id=" + val, conn);

                UpdatePersonCmd.Parameters.AddWithValue("@email", Email);
                UpdatePersonCmd.Parameters.AddWithValue("@street", Street);
                UpdatePersonCmd.Parameters.AddWithValue("@city", City);
                UpdatePersonCmd.Parameters.AddWithValue("@district", District);
                UpdatePersonCmd.Parameters.AddWithValue("@zip", Zip);

                UpdateStudentCmd.ExecuteNonQuery();
                UpdatePersonCmd.ExecuteNonQuery();
                stdList.DataSource = null;
                SelectLeaveYearCmbox.Enabled = false;
                FillSthiftList();
                FillStatusInfo();
                MessageBox.Show("Student Information updated!!"); 
            }
            else
            {
                MessageBox.Show("You can't leave a required field blank!"); 
            }
        }

        private void btnStdEditCancel_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Students_Control);
        }

        
        
    }
}
