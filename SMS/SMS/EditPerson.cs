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
    public partial class EditPerson : UserControl
    {
        SqlConnection conn;
        public EditPerson()
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

            cmbSelectDistrict.DisplayMember = "Value";
            cmbSelectDistrict.ValueMember = "Key";
            cmbSelectDistrict.DataSource = new BindingSource(DistrictDictionary, null);

            var bloodGrp = new Dictionary<string, string>();
            bloodGrp.Add("A+", "A+");
            bloodGrp.Add("A-", "A-");
            bloodGrp.Add("B+", "B+");
            bloodGrp.Add("B-", "B-");
            bloodGrp.Add("AB+", "AB+");
            bloodGrp.Add("AB-", "AB-");
            bloodGrp.Add("O+", "O+");
            bloodGrp.Add("O-", "O-");

            cmbSelectBlood.DisplayMember = "Value";
            cmbSelectBlood.ValueMember = "Key";
            cmbSelectBlood.DataSource = new BindingSource(bloodGrp, null);
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
            Program.MainWindow.ShowControl(SequenceEnum.AllPerson_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    string Email = Pdr.GetString(IndexEmail);
                    int Street = Pdr.GetInt32(IndexStreet);
                    string City = Pdr.GetString(IndexCity);
                    string District = Pdr.GetString(IndexDistrict);
                    int Zip = Pdr.GetInt32(IndexZip);
                    string BloodGrp = Pdr.GetString(IndexBloodGrp);

                    TxtFName.Text = Fname;
                    TxtLName.Text = Lname;
                    TxtFather.Text = Father;
                    TxtMother.Text = Mother;
                    cmbSelectBlood.Text = BloodGrp;
                    TxtEmail.Text = Email;
                    TxtStreet.Text = Street.ToString();
                    TxtCity.Text = City;
                    cmbSelectDistrict.Text = District;
                    TxtZip.Text = Zip.ToString();
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PersonList.DataSource = null;
            FillPersonList();
        }

        private void btnPersonEditSave_Click(object sender, EventArgs e)
        {
            int val = (int)PersonList.SelectedValue;

            var Fname = TxtFName.Text;
            var Lname = TxtLName.Text;
            var Father = TxtFather.Text;
            var Mother = TxtMother.Text;
            var Blood = cmbSelectBlood.SelectedValue;
            var Email = TxtEmail.Text;
            var Street = int.Parse(TxtStreet.Text);
            var Zip = int.Parse(TxtZip.Text);
            var City = TxtCity.Text;
            var District = cmbSelectDistrict.SelectedValue;

            if (Fname != "" & Lname != "" & Father != "" & Mother != "" & Email != "" & City != "")
            {
                SqlCommand UpdatePersonCmd = new SqlCommand("UPDATE [sms].[dbo].[person]" +
                   "set fname=@fname, lname=@lname, father_name=@father, mother_name=@mother, email=@email, street=@street, city=@city, district=@district, zip=@zip, blood_group=@bloodgrp WHERE id=" + val, conn);

                UpdatePersonCmd.Parameters.AddWithValue("@fname", Fname);
                UpdatePersonCmd.Parameters.AddWithValue("@lname", Lname);
                UpdatePersonCmd.Parameters.AddWithValue("@father", Father);
                UpdatePersonCmd.Parameters.AddWithValue("@mother", Mother);
                UpdatePersonCmd.Parameters.AddWithValue("@email", Email);
                UpdatePersonCmd.Parameters.AddWithValue("@street", Street);
                UpdatePersonCmd.Parameters.AddWithValue("@city", City);
                UpdatePersonCmd.Parameters.AddWithValue("@district", District);
                UpdatePersonCmd.Parameters.AddWithValue("@zip", Zip);
                UpdatePersonCmd.Parameters.AddWithValue("@bloodgrp", Blood);

                UpdatePersonCmd.ExecuteNonQuery();
                PersonList.DataSource = null;
                FillPersonList();
                MessageBox.Show("Person Information updated!!"); 
            }
            else
            {
                MessageBox.Show("You can't keep required field blank!"); 
            }
        }

        private void btnPersonEditCancel_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.AllPerson_Control);
        }   
    }
}
