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
    public partial class EditTeacher : UserControl
    {
        SqlConnection conn;
        public EditTeacher()
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

                    SqlCommand FindTeachCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[person] WHERE id=" + PersonID, conn);
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
            TeachList.DisplayMember = "Value";
            TeachList.ValueMember = "Key";
            TeachList.DataSource = new BindingSource(teacherListDictionary, null);

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

            DistrictTxt.DisplayMember = "Value";
            DistrictTxt.ValueMember = "Key";
            DistrictTxt.DataSource = new BindingSource(DistrictDictionary, null);
        }

        private void TeachList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int val = (int)TeachList.SelectedValue;

                SqlCommand TeacherInfoCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[teacher] AS t INNER JOIN [sms].[dbo].person AS p ON t.id = p.id WHERE t.id=" + val, conn);
                SqlDataReader Tdr = TeacherInfoCmd.ExecuteReader();
                while (Tdr.Read())
                {
                    int IndexDesignation = Tdr.GetOrdinal("designation");
                    int IndexEducation = Tdr.GetOrdinal("educational_qualification");
                    int IndexContact = Tdr.GetOrdinal("contact");
                    int IndexFname = Tdr.GetOrdinal("fname");
                    int IndexLname = Tdr.GetOrdinal("lname");
                    int IndexEmail = Tdr.GetOrdinal("email");
                    int IndexStreet = Tdr.GetOrdinal("street");
                    int IndexCity = Tdr.GetOrdinal("city");
                    int IndexDistrict = Tdr.GetOrdinal("district");
                    int IndexZip = Tdr.GetOrdinal("zip");

                    string Designation = Tdr.GetString(IndexDesignation);
                    string Education = Tdr.GetString(IndexEducation);
                    decimal Contact = Tdr.GetDecimal(IndexContact);
                    string FName = Tdr.GetString(IndexFname);
                    string LName = Tdr.GetString(IndexLname); ;
                    string Email = Tdr.GetString(IndexEmail);
                    int Street = Tdr.GetInt32(IndexStreet);
                    string City = Tdr.GetString(IndexCity);
                    int Zip = Tdr.GetInt32(IndexZip);
                    string District = Tdr.GetString(IndexDistrict);

                    DesignationTxt.Text = Designation;
                    EducationTxt.Text = Education;
                    ContactTxt.Text = Contact.ToString();
                    FnameTxt.Text = FName;
                    LnameTxt.Text = LName;
                    EmailTxt.Text = Email;
                    StreetTxt.Text = Street.ToString();
                    CityTxt.Text = City;
                    ZipTxt.Text = Zip.ToString();
                    DistrictTxt.Text = District;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Teachers_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            int val = (int)TeachList.SelectedValue;

            var Fname = FnameTxt.Text;
            var Lname = LnameTxt.Text;
            var Email = EmailTxt.Text;
            var Designation = DesignationTxt.Text;
            var Contact = decimal.Parse(ContactTxt.Text);
            var Education = EducationTxt.Text;
            var Street = int.Parse(StreetTxt.Text);
            var Zip = int.Parse(ZipTxt.Text);
            var City = CityTxt.Text;
            var District = DistrictTxt.SelectedValue;

            if (Fname != "" & Lname != "" & Email != "" & Designation != "" & Education != "" & City != "")
            {
                SqlCommand UpdatePersonCmd = new SqlCommand("UPDATE [sms].[dbo].[person]" +
                   "set fname=@fname, lname=@lname, email=@email, street=@street, city=@city, district=@district, zip=@zip WHERE id=" + val, conn);

                SqlCommand UpdateTeacherCmd = new SqlCommand("UPDATE [sms].[dbo].[teacher]" +
                       "set designation=@designation, educational_qualification=@education, contact=@contact WHERE id=" + val, conn);

                UpdatePersonCmd.Parameters.AddWithValue("@fname", Fname);
                UpdatePersonCmd.Parameters.AddWithValue("@lname", Lname);
                UpdatePersonCmd.Parameters.AddWithValue("@email", Email);
                UpdatePersonCmd.Parameters.AddWithValue("@street", Street);
                UpdatePersonCmd.Parameters.AddWithValue("@city", City);
                UpdatePersonCmd.Parameters.AddWithValue("@district", District);
                UpdatePersonCmd.Parameters.AddWithValue("@zip", Zip);

                UpdateTeacherCmd.Parameters.AddWithValue("@designation", Designation);
                UpdateTeacherCmd.Parameters.AddWithValue("@education", Education);
                UpdateTeacherCmd.Parameters.AddWithValue("@contact", Contact);

                UpdatePersonCmd.ExecuteNonQuery();
                UpdateTeacherCmd.ExecuteNonQuery();
                TeachList.DataSource = null;
                FillTeacherList();
                MessageBox.Show("Teacher Information updated!!");
            }
            else
            {
                MessageBox.Show("You can't leave a required field blank!");
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Teachers_Control);
        }
    }
}
