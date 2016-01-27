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
    public partial class Users : UserControl
    {
        SqlConnection conn;
        public Users()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            Dictionary<string, string> UserListDictionary = new Dictionary<string, string>();
            SqlCommand usrListCmd = new SqlCommand("SELECT x_id,fname,lname FROM [sms].[dbo].[user] as us INNER JOIN [sms].[dbo].[teacher] as teach ON us.x_id = teach.teach_id INNER JOIN [sms].[dbo].[person] as pr ON pr.id = teach.id WHERE Role='User'", conn);
            SqlDataReader dr = usrListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int IndexXID = dr.GetOrdinal("x_id");
                    int IndexFname = dr.GetOrdinal("fname");
                    int IndexLname = dr.GetOrdinal("lname");

                    string UserXID = dr.GetString(IndexXID);
                    string Fname = dr.GetString(IndexFname);
                    string Lname = dr.GetString(IndexLname);
                    UserListDictionary = UserListDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    UserListDictionary.Add(UserXID, Fname + " " + Lname);
                }
            }

            usrList.DisplayMember = "Value";
            usrList.ValueMember = "Key";
            usrList.DataSource = new BindingSource(UserListDictionary, null);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnUsrCreate_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Admin_Settings);
        }

        private void btnUsrEdit_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Admin_Settings);
        }

        private void btnUsrDelete_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Admin_Settings);
        }

        private void usrList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string val = usrList.SelectedValue.ToString();

                SqlCommand IdentifyUserCmd = new SqlCommand("SELECT fname,lname,designation,contact,email,subject_name FROM [sms].[dbo].[user] as us INNER JOIN [sms].[dbo].[teacher] as teach ON us.x_id = teach.teach_id INNER JOIN [sms].[dbo].[person] as pr ON pr.id = teach.id INNER JOIN [sms].[dbo].[subject] as sb ON sb.teach_id = teach.teach_id WHERE x_id='"+val+"' AND Role='User'", conn);
                SqlDataReader Iudr = IdentifyUserCmd.ExecuteReader();
                while (Iudr.Read())
                {
                    int IndexFname = Iudr.GetOrdinal("fname");
                    int IndexLname = Iudr.GetOrdinal("lname");
                    int IndexDesignation = Iudr.GetOrdinal("designation");
                    int IndexContact = Iudr.GetOrdinal("contact");
                    int IndexEmail = Iudr.GetOrdinal("email");
                    int IndexSubject = Iudr.GetOrdinal("subject_name");

                    string Fname = Iudr.GetString(IndexFname);
                    string Lname = Iudr.GetString(IndexLname);
                    string Designation = Iudr.GetString(IndexDesignation);
                    decimal Contact = Iudr.GetDecimal(IndexContact);
                    string Email = Iudr.GetString(IndexEmail);
                    string Subject = Iudr.GetString(IndexSubject);

                    usrNameTxt.Text = Fname+" "+Lname;
                    usrDesignationTxt.Text = Designation;
                    usrContactTxt.Text = "+880-"+Contact.ToString();
                    usrEmailTxt.Text = Email;
                    usrSubjectTxt.Text = Subject;
                }
            }
            catch (NullReferenceException)
            { }
        }

        
    }
}
