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

    public partial class CreatePerson : UserControl
    {
        SqlConnection conn;
        public CreatePerson()
        {
            InitializeComponent();
            FillPersonComboBox();
        }
        

        private void FillPersonComboBox()
        {
            var SexDictionary = new Dictionary<string, string>();
            SexDictionary.Add("Male", "Male");
            SexDictionary.Add("Female", "Female");

            PersonSexCmbox.DisplayMember = "Value";
            PersonSexCmbox.ValueMember = "Key";
            PersonSexCmbox.DataSource = new BindingSource(SexDictionary, null);

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

            PersonDistrictCmbox.DisplayMember = "Value";
            PersonDistrictCmbox.ValueMember = "Key";
            PersonDistrictCmbox.DataSource = new BindingSource(DistrictDictionary, null);

            var bloodGrp = new Dictionary<string, string>();
            bloodGrp.Add("A+", "A+");
            bloodGrp.Add("A-", "A-");
            bloodGrp.Add("B+", "B+");
            bloodGrp.Add("B-", "B-");
            bloodGrp.Add("AB+", "AB+");
            bloodGrp.Add("AB-", "AB-");
            bloodGrp.Add("O+", "O+");
            bloodGrp.Add("O-", "O-");

            PersonBloodGrpCmbox.DisplayMember = "Value";
            PersonBloodGrpCmbox.ValueMember = "Key";
            PersonBloodGrpCmbox.DataSource = new BindingSource(bloodGrp, null);
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

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBconnection.GetConnection();
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                var fname = PersonFnameTxt.Text;
                var lname = PersonLnameTxt.Text;
                var fathername = PersonFatherTxt.Text;
                var mothername = PersonMotherTxt.Text;
                var email = PersonEmailTxt.Text;
                var street = PersonStreetTxt.Text;
                var city = PersonCityTxt.Text;
                var zip = PersonZipTxt.Text;

                var sex = PersonSexCmbox.SelectedValue;
                var district = PersonDistrictCmbox.SelectedValue;
                var bloodgrp = PersonBloodGrpCmbox.SelectedValue;

                if (fname != "" & lname != "" & fathername != "" & mothername != "" & email != "" & city != "")
                {
                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [sms].[dbo].[person](fname, lname, father_name, mother_name, sex, email, street, city, district, zip, blood_group)"+
                    " VALUES (@fname, @lname, @fathername, @mothername, @sex, @email, @street, @city, @district, @zip, @blood)", conn);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@fathername", fathername);
                    cmd.Parameters.AddWithValue("@mothername", mothername);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@district", district);
                    cmd.Parameters.AddWithValue("@zip", zip);
                    cmd.Parameters.AddWithValue("@blood", bloodgrp);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Person information added successfully!");
                }
                else
                {
                    MessageBox.Show("You can't keep any field blank!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelPerson_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.AllPerson_Control);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PersonFnameTxt.Text = "";
            PersonLnameTxt.Text = "";
            PersonFatherTxt.Text = "";
            PersonMotherTxt.Text = "";
            PersonSexCmbox.SelectedValue = "Male";
            PersonEmailTxt.Text = "";
            PersonStreetTxt.Text = "";
            PersonCityTxt.Text = "";
            PersonDistrictCmbox.SelectedValue = "Bagerhat";
            PersonZipTxt.Text = "";
            PersonBloodGrpCmbox.SelectedValue = "A+";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PersonFnameTxt.Text = "";
            PersonLnameTxt.Text = "";
            PersonFatherTxt.Text = "";
            PersonMotherTxt.Text = "";
            PersonSexCmbox.SelectedValue = "Male";
            PersonEmailTxt.Text = "";
            PersonStreetTxt.Text = "";
            PersonCityTxt.Text = "";
            PersonDistrictCmbox.SelectedValue = "Bagerhat";
            PersonZipTxt.Text = "";
            PersonBloodGrpCmbox.SelectedValue = "A+";
        }

        
    }
}
