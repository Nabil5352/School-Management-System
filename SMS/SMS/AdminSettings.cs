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
    public partial class AdminSettings : UserControl
    {
        SqlConnection conn;
        public AdminSettings()
        {
            InitializeComponent();
            UserArrow.Hide();
            userPanel.Hide();
            FillUserList();
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

        private bool CompareStrings(string firstString, string secondString)
        {
            return String.Compare(firstString, secondString, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AdminArrow.Show();
            personalPanel.Visible = true;
            UserArrow.Hide();
            userPanel.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminArrow.Hide();
            personalPanel.Visible = false;
            UserArrow.Show();
            userPanel.Show();
        }

        private void FillUserList()
        {
            try
            {
                conn = DBconnection.GetConnection();
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                //Create User
                var dictionary = new Dictionary<string, string>();
                SqlCommand usrList = new SqlCommand("SELECT * FROM [sms].[dbo].[person] as pr INNER JOIN [sms].[dbo].[teacher] as teach ON pr.id = teach.id WHERE teach_id not in (SELECT x_id FROM [sms].[dbo].[user]) ORDER BY pr.id", conn);
                SqlDataReader uldr = usrList.ExecuteReader();
                if (uldr.HasRows)
                {
                    while (uldr.Read())
                    {
                        int indexFname = uldr.GetOrdinal("fname");
                        int indexLname = uldr.GetOrdinal("lname");
                        int indexteachId = uldr.GetOrdinal("teach_id");

                        string firstname = uldr.GetString(indexFname);
                        string lastname = uldr.GetString(indexLname);
                        string teachID = uldr.GetString(indexteachId);
                        dictionary.Add(teachID, firstname + " " + lastname);
                    }
                }
                selectUserCombo.DisplayMember = "Value";
                selectUserCombo.ValueMember = "Key";
                selectUserCombo.DataSource = new BindingSource(dictionary, null);

                //Edit User
                var usrDictionary = new Dictionary<string, string>();
                SqlCommand CurrUsrList = new SqlCommand("SELECT username,password,fname,lname,teach_id FROM [sms].[dbo].[user] as ur INNER JOIN [sms].[dbo].[teacher] as teach ON ur.x_id = teach.teach_id INNER JOIN [sms].[dbo].[person] as pr ON pr.id = teach.id WHERE Role='User'", conn);
                SqlDataReader culdr = CurrUsrList.ExecuteReader();
                if (culdr.HasRows)
                {
                    while (culdr.Read())
                    {
                        int indexFname = culdr.GetOrdinal("fname");
                        int indexLname = culdr.GetOrdinal("lname");
                        int indexteachId = culdr.GetOrdinal("teach_id");

                        string firstname = culdr.GetString(indexFname);
                        string lastname = culdr.GetString(indexLname);
                        string teachID = culdr.GetString(indexteachId);
                        usrDictionary.Add(teachID, firstname + " " + lastname);
                    }
                }
                selectUser.DisplayMember = "Value";
                selectUser.ValueMember = "Key";
                selectUser.DataSource = new BindingSource(usrDictionary, null);
            }
            catch (NullReferenceException)
            {}
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                string value = selectUserCombo.SelectedValue.ToString();

                var username = userUsername.Text;
                var pass = userPass.Text;
                var log_in_time = "";

                if (username != "" & pass != "")
                {
                    SqlCommand InsertUserCmd = new SqlCommand("INSERT INTO [sms].[dbo].[user] (x_id, username, password, Role, last_log_in) VALUES (@x_id, @usrname, @pass, 'User', @log_time)", conn);
                    InsertUserCmd.Parameters.AddWithValue("@x_id", value);
                    InsertUserCmd.Parameters.AddWithValue("@usrname", username);
                    InsertUserCmd.Parameters.AddWithValue("@pass", pass);
                    InsertUserCmd.Parameters.AddWithValue("@log_time", log_in_time);

                    InsertUserCmd.ExecuteNonQuery();
                    selectUserCombo.DataSource = null;
                    FillUserList();
                    userUsername.Text = "";
                    userPass.Text = "";

                    MessageBox.Show("Successfull!! New user added!");
                }
                else
                {
                    MessageBox.Show("You can't keep any field blank!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            userUsername.Text = "";
            userPass.Text = "";
        }

        private void selectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = selectUser.SelectedValue.ToString();

                SqlCommand CurrUsrInfo = new SqlCommand("SELECT * FROM [sms].[dbo].[user] WHERE x_id='" + value + "' AND Role='User'", conn);
                SqlDataReader cuidr = CurrUsrInfo.ExecuteReader();
                if (cuidr.HasRows)
                {
                    while (cuidr.Read())
                    {
                        int indexUsername = cuidr.GetOrdinal("username");
                        int indexPassword = cuidr.GetOrdinal("password");

                        string username = cuidr.GetString(indexUsername);
                        string pass = cuidr.GetString(indexPassword);

                        EditUserTxt.Text = username;
                        EditPassword.Text = pass;
                    }
                }
            }
            catch (NullReferenceException)
            {}
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                string value = selectUser.SelectedValue.ToString();

                var NewUsername = EditUserTxt.Text;
                var NewPass = EditPassword.Text;

                if (NewUsername != "" & NewPass != "")
                {
                    SqlCommand UpdateUserCmd = new SqlCommand("UPDATE [sms].[dbo].[user] SET username=@username, password=@password WHERE x_id='" + value + "' AND Role='User'", conn);
                    UpdateUserCmd.Parameters.AddWithValue("@username", NewUsername);
                    UpdateUserCmd.Parameters.AddWithValue("@password", NewPass);

                    UpdateUserCmd.ExecuteNonQuery();
                    EditUserTxt.Text = "";
                    EditPassword.Text = "";
                    selectUser.DataSource = null;
                    FillUserList();

                    MessageBox.Show("User Information Updated Successfully!! ");
                }
                else
                {
                    MessageBox.Show("You can't keep any field blank!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            EditUserTxt.Text = "";
            EditPassword.Text = "";
        }

        private void btnUsrDelete_Click(object sender, EventArgs e)
        {
            string value = selectUser.SelectedValue.ToString();

            string message = "Do you want to delete this user?";
            string caption = "Caution!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand UserDeleteCmd = new SqlCommand("DELETE FROM [sms].[dbo].[user] WHERE x_id='"+value+"' AND Role='User'", conn);
                UserDeleteCmd.ExecuteNonQuery();

                MessageBox.Show("User Deleted successfully!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBconnection.GetConnection();
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                var username = newUsernameTxt.Text.Trim();
                var newPass = NewPassTxt.Text;
                string oldPass = OldPassTxt.Text;

                SqlCommand cmd = new SqlCommand("SELECT * FROM [sms].[dbo].[user] WHERE Role='Admin'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int adminPass = dr.GetOrdinal("password");
                    string OldadminPass = dr.GetString(adminPass);

                    if (username != "" & newPass != "" & oldPass != "")
                    {
                        if (this.CompareStrings(OldadminPass.ToString(), oldPass))
                        {
                            SqlCommand UpdateAdmincmd = new SqlCommand("UPDATE [sms].[dbo].[user] SET username=@username, password=@password WHERE Role='Admin'", conn);

                            UpdateAdmincmd.Parameters.AddWithValue("@username", username);
                            UpdateAdmincmd.Parameters.AddWithValue("@password", newPass);

                            UpdateAdmincmd.ExecuteNonQuery();
                            MessageBox.Show("Admin Information updated!!");
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can't keep any field blank!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newUsernameTxt.Text = "";
            NewPassTxt.Text = "";
            OldPassTxt.Text = "";
        }
        
    }
}
