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
    public partial class Teachers : UserControl
    {
        SqlConnection conn;
        public Teachers()
        {
            InitializeComponent();
            FillTeacherList();
        }

        private void FillTeacherList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            var teacherListDictionary = new Dictionary<int, string>();
            SqlCommand teachListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher]", conn);
            SqlDataReader dr = teachListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int IndexID = dr.GetOrdinal("id");

                    int PersonID = dr.GetInt32(IndexID);

                    SqlCommand FindTeachCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id="+PersonID, conn);
                    SqlDataReader Tdr = FindTeachCmd.ExecuteReader();

                    if (Tdr.HasRows)
                    {
                        if (Tdr.Read())
                        {
                            int IndexFname = Tdr.GetOrdinal("fname");
                            int IndexLname = Tdr.GetOrdinal("lname");

                            string Fname = Tdr.GetString(IndexFname);
                            string Lname = Tdr.GetString(IndexLname);
                            teacherListDictionary = teacherListDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                            teacherListDictionary.Add(PersonID, Fname + " " + Lname);
                        }
                    }
                }
            }
            teachList.DisplayMember = "Value";
            teachList.ValueMember = "Key";
            teachList.DataSource = new BindingSource(teacherListDictionary, null);
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

        private void btnTeachCreate_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.CreateTeacher_Control);
        }

        private void btnTeachEdit_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.EditTeacher_Control);
        }

        private void teachList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher]", conn);
                SqlDataReader sqlDr = Cmd.ExecuteReader();
                int val = (int)teachList.SelectedValue;
                if (sqlDr.HasRows)
                {
                    SqlCommand TeacherInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher] AS t INNER JOIN [sms].[dbo].person AS p ON t.id = p.id WHERE t.id=" + val, conn);
                    SqlDataReader Tdr = TeacherInfoCmd.ExecuteReader();
                    while (Tdr.Read())
                    {
                        int IndexDesignation = Tdr.GetOrdinal("designation");
                        int IndexEducation = Tdr.GetOrdinal("educational_qualification");
                        int IndexContact = Tdr.GetOrdinal("contact");
                        int IndexFname = Tdr.GetOrdinal("fname");
                        int IndexLname = Tdr.GetOrdinal("lname");
                        int IndexFather = Tdr.GetOrdinal("father_name");
                        int IndexMother = Tdr.GetOrdinal("mother_name");
                        int IndexEmail = Tdr.GetOrdinal("email");
                        int IndexStreet = Tdr.GetOrdinal("street");
                        int IndexCity = Tdr.GetOrdinal("city");
                        int IndexDistrict = Tdr.GetOrdinal("district");
                        int IndexZip = Tdr.GetOrdinal("zip");
                        int IndexBlood = Tdr.GetOrdinal("blood_group");                       

                        string Designation = Tdr.GetString(IndexDesignation);
                        string Education = Tdr.GetString(IndexEducation);
                        decimal Contact = Tdr.GetDecimal(IndexContact);
                        string FName = Tdr.GetString(IndexFname);
                        string LName = Tdr.GetString(IndexLname);
                        string Father = Tdr.GetString(IndexFather);
                        string Mother = Tdr.GetString(IndexMother);
                        string Email = Tdr.GetString(IndexEmail);
                        int Street = Tdr.GetInt32(IndexStreet);
                        string City = Tdr.GetString(IndexCity);
                        int Zip = Tdr.GetInt32(IndexZip);
                        string District = Tdr.GetString(IndexDistrict);
                        string Blood = Tdr.GetString(IndexBlood);

                        lblDesignationTxt.Text = Designation;
                        lblEducationTxt.Text = Education;
                        lblContactTxt.Text = Contact.ToString();
                        lblNameTxt.Text = FName + " " + LName;
                        lblFatherTxt.Text = Father;
                        lblMotherTxt.Text = Mother;
                        lblEmailTxt.Text = Email;
                        lblStreetTxt.Text = Street.ToString();
                        lblCityTxt.Text = City;
                        lblZipTxt.Text = Zip.ToString();
                        lblDistrictTxt.Text = District;
                        lblBloodTxt.Text = Blood;
                    }


                    //Find CoOrdinator
                    SqlCommand ClassCmd = new SqlCommand("SELECT class FROM [sms].[dbo].[teacher] as te INNER JOIN [sms].[dbo].[person] as pr ON pr.id=te.id INNER JOIN [sms].[dbo].[class] as cl ON te.teach_id=cl.coordinator WHERE te.id=" + val, conn);
                    SqlDataReader Ccmd = ClassCmd.ExecuteReader();
                    if (Ccmd.HasRows)
                    {
                        while (Ccmd.Read())
                        {
                            int IndexClass = Ccmd.GetOrdinal("class");
                            string Class = Ccmd.GetString(IndexClass);

                            lblCoordianteTxt.Text = Class;
                        }
                    }
                    else
                    {
                        lblCoordianteTxt.Text = "None";
                    }

                    //Find Subject
                    SqlCommand SubjectCmd = new SqlCommand("SELECT subject_name FROM [sms].[dbo].[teacher] as te INNER JOIN [sms].[dbo].[person] as pr ON pr.id=te.id INNER JOIN [sms].[dbo].[subject] as sb ON te.teach_id=sb.teach_id WHERE te.id=" + val, conn);
                    SqlDataReader Scmd = SubjectCmd.ExecuteReader();
                    if (Scmd.HasRows)
                    {
                        while (Scmd.Read())
                        {
                            int IndexSubject = Scmd.GetOrdinal("subject_name");
                            string Subject_name = Scmd.GetString(IndexSubject);

                            lblSubjectTxt.Text = Subject_name;
                        }
                    }
                    else
                    {
                        lblSubjectTxt.Text = "None";
                    }
                }
                else { }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btnTeachDelete_Click(object sender, EventArgs e)
        {
            int val = (int)teachList.SelectedValue;
            string message = "Do you want to delete this entry?";
            string caption = "Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand TeacherDeleteCmd = new SqlCommand("DELETE FROM [sms].[dbo].[teacher] WHERE id=" + val, conn);
                TeacherDeleteCmd.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully!");
            }   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            teachList.DataSource = null;
            FillTeacherList();
        }
    }
}
