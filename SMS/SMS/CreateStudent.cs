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
    public partial class CreateStudent : UserControl
    {
        SqlConnection conn;
        public CreateStudent()
        {
            InitializeComponent();
            FillStatusInfo();

            selectShift.Enabled = false;
            StdSelectCmbox.Enabled = false;
            StdSelectClassCombox.Enabled = false;
            StdRollTxt.Enabled = false;
            StdSelectYearCombox.Enabled = false;
            StdSelectLeaveYearCombox.Enabled = false;
            StdGContactTxt.Enabled = false;
            StdMetaTxt.Enabled = false;
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

            StdSelectExOrCurrentCmbox.DisplayMember = "Value";
            StdSelectExOrCurrentCmbox.ValueMember = "Key";
            StdSelectExOrCurrentCmbox.DataSource = new BindingSource(ExOrCurrentDictionary, null);
        }

        private void StdSelectExOrCurrentCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = (int)StdSelectExOrCurrentCmbox.SelectedValue;
                selectShift.Enabled = true;
                FillShiftInfo(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillShiftInfo(int value)
        {
            if (value == 1)
            {
                StdSelectCmbox.Enabled = true;
                StdSelectClassCombox.Enabled = true;
                StdRollTxt.Enabled = true;
                StdSelectYearCombox.Enabled = true;
                StdSelectLeaveYearCombox.Enabled = false;
                StdGContactTxt.Enabled = true;
                StdMetaTxt.Enabled = true;
            }
            else if (value == 0)
            {
                StdSelectCmbox.Enabled = true;
                StdSelectClassCombox.Enabled = true;
                StdRollTxt.Enabled = true;
                StdSelectYearCombox.Enabled = true;
                StdSelectLeaveYearCombox.Enabled = true;
                StdGContactTxt.Enabled = true;
                StdMetaTxt.Enabled = true;
            }

            var ShiftDictionary = new Dictionary<string, string>();
            ShiftDictionary.Add("Morning", "Morning");
            ShiftDictionary.Add("Day", "Day");

            selectShift.DisplayMember = "Value";
            selectShift.ValueMember = "Key";
            selectShift.DataSource = new BindingSource(ShiftDictionary, null);
        }

        private void selectShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = selectShift.SelectedValue.ToString();
                FillStudentCombox(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillStudentCombox(string ShiftValue)
        {
            try
            {
                var PersonDictionary = new Dictionary<int, string>();

                //Select from Person List
                SqlCommand findPersonCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] pr WHERE pr.id not in (SELECT id FROM [sms].[dbo].[teacher]) AND pr.id not in (SELECT id FROM [sms].[dbo].[student])", conn);
                SqlDataReader dr = findPersonCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int indexFname = dr.GetOrdinal("fname");
                        int indexLname = dr.GetOrdinal("lname");
                        int indexId = dr.GetOrdinal("id");

                        string firstname = dr.GetString(indexFname);
                        string lastname = dr.GetString(indexLname);
                        int personID = dr.GetInt32(indexId);
                        PersonDictionary.Add(personID, firstname + " " + lastname);
                    }
                }
                StdSelectCmbox.DisplayMember = "Value";
                StdSelectCmbox.ValueMember = "Key";
                StdSelectCmbox.DataSource = new BindingSource(PersonDictionary, null);

                //Measure student ID
                SqlCommand noOfStd = new SqlCommand("SELECT COUNT(*) FROM [sms].[dbo].[student]", conn);
                noOfStd.CommandType = CommandType.Text;
                var Count = (Int32)noOfStd.ExecuteScalar();
                var stdID = "std" + (Count + 1);
                StdlblID.Text = stdID;

                //Select from Class List
                var classDictionary = new Dictionary<string, string>();
                SqlCommand classes = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='" + ShiftValue + "' ORDER BY class_id", conn);
                SqlDataReader Cdr = classes.ExecuteReader();
                if (Cdr.HasRows)
                {
                    while (Cdr.Read())
                    {
                        int indexClassID = Cdr.GetOrdinal("class_id");
                        int indexClass = Cdr.GetOrdinal("class");
                        int indexSection = Cdr.GetOrdinal("section");

                        string ClassID = Cdr.GetString(indexClassID);
                        string Class = Cdr.GetString(indexClass);
                        string Section = Cdr.GetString(indexSection);
                        classDictionary.Add(ClassID, "Class - " + Class + " (" + Section + ")");
                        StdSelectClassCombox.DisplayMember = "Value";
                        StdSelectClassCombox.ValueMember = "Key";
                        StdSelectClassCombox.DataSource = new BindingSource(classDictionary, null);
                    }
                }

                //Select the year
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

                StdSelectLeaveYearCombox.DisplayMember = "Value";
                StdSelectLeaveYearCombox.ValueMember = "Key";
                StdSelectLeaveYearCombox.DataSource = new BindingSource(YearDictionary, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            var personID = StdSelectCmbox.SelectedValue;
            var stdID = StdlblID.Text;
            var SelectClass = StdSelectClassCombox.SelectedValue;
            var ClassRoll = StdRollTxt.Text;
            var AdYear = StdSelectYearCombox.SelectedValue;
            var LeaveYear = StdSelectLeaveYearCombox.SelectedValue;
            var GContact = StdGContactTxt.Text;
            var status = StdSelectExOrCurrentCmbox.SelectedValue;
            var Meta = StdMetaTxt.Text;

            if (ClassRoll!= "")
            {
                SqlCommand InsertStdInfo = new SqlCommand("INSERT INTO [sms].[dbo].[student](id, student_id, class_id, roll, admission_year, leaving_year, guardian_contact, status, meta)" +
                    "VALUES (@id, @std_id, @class_id, @roll, @admission_yr, @leaving_yr, @guardians_contact, @status, @meta)", conn);

                InsertStdInfo.Parameters.AddWithValue("@id", personID);
                InsertStdInfo.Parameters.AddWithValue("@std_id", stdID);
                InsertStdInfo.Parameters.AddWithValue("@class_id", SelectClass);
                InsertStdInfo.Parameters.AddWithValue("@roll", ClassRoll);
                InsertStdInfo.Parameters.AddWithValue("@admission_yr", AdYear);
                InsertStdInfo.Parameters.AddWithValue("@leaving_yr", LeaveYear);
                InsertStdInfo.Parameters.AddWithValue("@guardians_contact", GContact);
                InsertStdInfo.Parameters.AddWithValue("@status", status);
                InsertStdInfo.Parameters.AddWithValue("@meta", Meta);

                InsertStdInfo.ExecuteNonQuery();
                StdSelectExOrCurrentCmbox.DataSource = null;
                selectShift.DataSource = null;
                StdSelectCmbox.DataSource = null;
                StdSelectClassCombox.DataSource = null;
                StdSelectLeaveYearCombox.DataSource = null;
                FillStatusInfo();
                MessageBox.Show("Student added successfully!");
            }
            else
            {
                MessageBox.Show("You can't leave a required field blank!");
            }
        }

        private void btnCancelTeach_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Students_Control);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StdSelectExOrCurrentCmbox.DataSource = null;
            selectShift.DataSource = null;
            StdSelectCmbox.DataSource = null;
            StdSelectClassCombox.DataSource = null;
            StdSelectLeaveYearCombox.DataSource = null;
            StdRollTxt.Text = "";
            StdGContactTxt.Text = "";
            StdMetaTxt.Text = "";
            FillStatusInfo();
        }
    }
}
