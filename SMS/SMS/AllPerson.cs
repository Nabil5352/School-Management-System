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
using System.Collections;

namespace SMS
{
    public partial class AllPerson : UserControl
    {
       SqlConnection conn;
        public AllPerson()
        {
            InitializeComponent();
            PersonList.DataSource = null;
            FillPersonList();
        }

        Dictionary<int, string> personListDictionary = new Dictionary<int, string>();
        private void FillPersonList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand prsonListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person]", conn);
            SqlDataReader dr = prsonListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int IndexID = dr.GetOrdinal("id");
                    int IndexFname = dr.GetOrdinal("fname");
                    int IndexLname = dr.GetOrdinal("lname");

                    int PersonID = dr.GetInt32(IndexID);
                    string Fname = dr.GetString(IndexFname);
                    string Lname = dr.GetString(IndexLname);
                    personListDictionary = personListDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    personListDictionary.Add(PersonID, Fname + " " + Lname);                    
                }
            }

            PersonList.DisplayMember = "Value";
            PersonList.ValueMember = "Key";
            PersonList.DataSource = new BindingSource(personListDictionary, null);
        }

        private void sortListBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sortListBox.Text) || !string.IsNullOrEmpty(sortListBox.Text))
            {
                PersonList.DataSource = null;

                foreach (KeyValuePair<int, string> entry in personListDictionary)
                {
                    Dictionary<int, string> SortDictionary = new Dictionary<int, string>();
                    if (entry.Value.StartsWith(sortListBox.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        SortDictionary.Add(entry.Key, entry.Value);
                        PersonList.DisplayMember = "Value";
                        PersonList.ValueMember = "Key";
                        PersonList.DataSource = new BindingSource(SortDictionary, null);
                    }                    
                }
            }
            else
            {
                personListDictionary.Clear();
                PersonList.DataSource = null;
                FillPersonList();
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

        private void btnPersonCreate_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.CreatePerson_Control);
        }

        private void PersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int val = (int)PersonList.SelectedValue;

                SqlCommand IdentifyPersonCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id='" + val + "'", conn);
                SqlDataReader Pdr = IdentifyPersonCmd.ExecuteReader();
                while (Pdr.Read())
                {
                    int IndexFname = Pdr.GetOrdinal("fname");
                    int IndexLname = Pdr.GetOrdinal("lname");
                    int IndexFather = Pdr.GetOrdinal("father_name");
                    int IndexMother = Pdr.GetOrdinal("mother_name");
                    int IndexSex = Pdr.GetOrdinal("sex");
                    int IndexEmail = Pdr.GetOrdinal("email");
                    int IndexStreet = Pdr.GetOrdinal("street");
                    int IndexCity = Pdr.GetOrdinal("city");
                    int IndexDistrict = Pdr.GetOrdinal("district");
                    int IndexZip = Pdr.GetOrdinal("zip");
                    int IndexBloodGrp = Pdr.GetOrdinal("blood_group");

                    string Fname = Pdr.GetString(IndexFname);
                    string Lname = Pdr.GetString(IndexLname);
                    string Father = Pdr.GetString(IndexFather);
                    string Mother = Pdr.GetString(IndexMother);
                    string Sex = Pdr.GetString(IndexSex);
                    string Email = Pdr.GetString(IndexEmail);
                    int Street = Pdr.GetInt32(IndexStreet);
                    string City = Pdr.GetString(IndexCity);
                    string District = Pdr.GetString(IndexDistrict);
                    int Zip = Pdr.GetInt32(IndexZip);
                    string BloodGrp = Pdr.GetString(IndexBloodGrp);

                    lblNameTxt.Text = Fname + " " + Lname;
                    lblFatherTxt.Text = Father;
                    lblMotherTxt.Text = Mother;
                    lblSexTxt.Text = Sex;
                    lblBloodTxt.Text = BloodGrp;
                    lblEmailTxt.Text = Email;
                    lblStreetTxt.Text = Street.ToString();
                    lblCityTxt.Text = City;
                    lblDistrictTxt.Text = District;
                    lblZipTxt.Text = Zip.ToString();

                    SqlCommand stdRole = new SqlCommand("SELECT COUNT(*) FROM [sms].[dbo].[student] WHERE id=" + val, conn);
                    stdRole.CommandType = CommandType.Text;
                    var StdCount = (Int32)stdRole.ExecuteScalar();
                    SqlCommand teachRole = new SqlCommand("SELECT COUNT(*) FROM [sms].[dbo].[teacher] WHERE id=" + val, conn);
                    teachRole.CommandType = CommandType.Text;
                    var TeachCount = (Int32)teachRole.ExecuteScalar();
                    if (StdCount > 0)
                    {
                        lblRoleTxt.Text = "Student";
                    }
                    else if (TeachCount > 0)
                    {
                        lblRoleTxt.Text = "Teacher";
                    }
                    else
                    {
                        lblRoleTxt.Text = "-";
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btnPersonEdit_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.EditPerson_Control);
        }

        private void btnPersonDelete_Click(object sender, EventArgs e)
        {
            int val = (int)PersonList.SelectedValue;
            string message = "Do you want to delete this entry?";
            string caption = "Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand TeacherDeleteCmd = new SqlCommand("DELETE FROM [sms].[dbo].[person] WHERE id=" + val, conn);
                TeacherDeleteCmd.ExecuteNonQuery();
                PersonList.DataSource = null;
                FillPersonList();
                MessageBox.Show("Deleted successfully!");
            } 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            personListDictionary.Clear();
            PersonList.DataSource = null;
            FillPersonList();
        }
    }
}
