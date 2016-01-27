using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Configuration;

namespace SMS
{
    public partial class LogInPage : UserControl
    {
        SqlConnection conn;
        public LogInPage()
        {
            InitializeComponent();         
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = DBconnection.GetConnection();
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT ISNULL(username, '') AS stUsername, ISNULL(password,'') AS stPassword, ISNULL(Role,'') AS stRole FROM [sms].[dbo].[user] WHERE username=@username and password=@password", conn);
                cmd.Parameters.AddWithValue("@username", userNameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                string userNameText = userNameBox.Text;
                string userPassText = passwordBox.Text;
                string PersonRole1 = "Admin";
                string PersonRole2 = "User";

                while (dr.Read())
                {
                    if (this.CompareStrings(dr["stUsername"].ToString(), userNameText) &&
                        this.CompareStrings(dr["stPassword"].ToString(), userPassText) &&
                        this.CompareStrings(dr["stRole"].ToString(), PersonRole1))
                    {
                        MessageBox.Show("Welcome admin!");
                        Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
                    }
                    else if (this.CompareStrings(dr["stUsername"].ToString(), userNameText) &&
                       this.CompareStrings(dr["stPassword"].ToString(), userPassText) &&
                       this.CompareStrings(dr["stRole"].ToString(), PersonRole2))
                    {
                        MessageBox.Show("Welcome user!");
                        DateTime dt = DateTime.Now;
                        DateTime ut = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
                        var log_in_time = ut + " " + ut.Kind;

                        SqlCommand TimeCmd = new SqlCommand("UPDATE [sms].[dbo].[user] set last_log_in = @dateTime WHERE username= @username and password=@password", conn);
                        TimeCmd.Parameters.AddWithValue("@dateTime", log_in_time);
                        TimeCmd.Parameters.AddWithValue("@username", userNameBox.Text.Trim());
                        TimeCmd.Parameters.AddWithValue("@password", passwordBox.Text);
                        TimeCmd.ExecuteNonQuery();
                        Program.MainWindow.ShowControl(SequenceEnum.HomeWindow_Control);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password!!");
                    }
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CompareStrings(string firstString, string secondString)
        {
            return String.Compare(firstString, secondString, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void btnLogPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void btnLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void btnLogPageExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
                Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutUs abtUs = new AboutUs();
            abtUs.Show();
        }
    }
}
