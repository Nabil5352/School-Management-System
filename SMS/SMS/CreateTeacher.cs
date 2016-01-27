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
    public partial class CreateTeacher : UserControl
    {
        SqlConnection conn;
        public CreateTeacher()
        {
            InitializeComponent();
            FillTeacherSelectFromPersonCombox();
        }

        private void FillTeacherSelectFromPersonCombox()
        {
            try
            {
                var dictionary = new Dictionary<int, string>();
                conn = DBconnection.GetConnection();
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
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
                        dictionary.Add(personID, firstname+ " " +lastname); 
                    }
                }
                TeachSelectCmbox.DisplayMember = "Value";
                TeachSelectCmbox.ValueMember = "Key";
                TeachSelectCmbox.DataSource = new BindingSource(dictionary, null);

                //Measure teacher ID
                SqlCommand noOfTeach = new SqlCommand("SELECT COUNT(*) FROM [sms].[dbo].[teacher]", conn);
                noOfTeach.CommandType = CommandType.Text;
                var Count = (Int32)noOfTeach.ExecuteScalar();
                var teachID = "teach" + (Count + 1);
                TeachlblID.Text = teachID;
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
            Program.MainWindow.ShowControl(SequenceEnum.Teachers_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTeach_Click(object sender, EventArgs e)
        {
            try
            {
            var personID = TeachSelectCmbox.SelectedValue;
            var teachID = TeachlblID.Text;
            var designation = teachDesignationTxt.Text;
            var eduQuality = teachEduQualityTxt.Text;
            var contact = teachContactTxt.Text;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            if (designation != "" & eduQuality != "")
            {
                SqlCommand insertValueCmd = new SqlCommand("INSERT INTO [sms].[dbo].[teacher](id, teach_id, designation, educational_qualification, contact) " +
                "VALUES (@ID, @teachID, @designation, @eduQuality, @contact)", conn);
                insertValueCmd.Parameters.AddWithValue("@ID", personID);
                insertValueCmd.Parameters.AddWithValue("@teachID", teachID);
                insertValueCmd.Parameters.AddWithValue("@designation", designation);
                insertValueCmd.Parameters.AddWithValue("@eduQuality", eduQuality);
                insertValueCmd.Parameters.AddWithValue("@contact", contact);

                insertValueCmd.ExecuteNonQuery();
                MessageBox.Show("Successfull!! Person added as Teacher!");
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

        private void btnCancelUsr_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Teachers_Control);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TeachSelectCmbox.DataSource = null;
            teachDesignationTxt.Text = "";
            teachEduQualityTxt.Text = "";
            teachContactTxt.Text = "";
            FillTeacherSelectFromPersonCombox();
        }
    }
}
