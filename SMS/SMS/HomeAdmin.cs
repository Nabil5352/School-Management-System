using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SMS
{
    public partial class HomeAdmin : UserControl
    {
        SqlConnection conn;
        public HomeAdmin()
        {
            InitializeComponent();
            btnBack.Enabled = false;
            FillEvent();
        }

        public object BanglaMonth { get; set; }
        public object ArabicMonth { get; set; }

        private void FillEvent()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            var Today = DateTime.Now.ToString("d-M-yyyy");

            string input = Today;
            string pattern = "-";

            string[] substrings = Regex.Split(input, pattern);

            var date = Convert.ToInt32(substrings[0]);
            var month = Convert.ToInt32(substrings[1]);
            var year = Convert.ToInt32(substrings[2]);

            calender findBday = new calender();
            var BanglaValue = findBday.BanglaDate(month, date);
            var ArabicValue = findBday.ArabicDate(month, date);

            //Arabic date, month, year calculation
            var ArabicMonth = findArabicMonth(ArabicValue);
            var ArabicDigit = findDate(ArabicValue);

            int ArabYr = 0;
            if (ArabicMonth.ToString() == "muh" || ArabicMonth.ToString() == "saf" && month >= 11 || ArabicMonth.ToString() == "raa" && month >= 12)
            {
                ArabYr = 1436;
            }
            else
            {
                ArabYr = 1435;
            }


            //Bangla date, month, year calculation
            var character = findMonth(BanglaValue);
            var digit = findDate(BanglaValue);
            var IntDigit = Convert.ToInt32(digit.ToString());

            int yr = 0;
            if (character.ToString() == "মাঘ" || character.ToString() == "ফাল্গুন" || character.ToString() == "চৈত্র" || character.ToString() == "পৌষ" && IntDigit >= 18)
            {
                yr = 1420;
            }
            else
            {
                yr = 1421;
            }

            //Convert date into bangla
            string numOfDate = digit.ToString();
            string[] x = new string[numOfDate.Length];
            string[] y = new string[numOfDate.Length];
            for (int i = 0; i < numOfDate.Length; i++)
            {
                x[i] = numOfDate.Substring(i, 1);
                switch (x[i])
                {
                    case "0":
                        y[i] = "০";
                        break;
                    case "1":
                        y[i] = "১";
                        break;
                    case "2":
                        y[i] = "২";
                        break;
                    case "3":
                        y[i] = "৩";
                        break;
                    case "4":
                        y[i] = "৪";
                        break;
                    case "5":
                        y[i] = "৫";
                        break;
                    case "6":
                        y[i] = "৬";
                        break;
                    case "7":
                        y[i] = "৭";
                        break;
                    case "8":
                        y[i] = "৮";
                        break;
                    case "9":
                        y[i] = "৯";
                        break;
                    default:
                        break;
                }
            }
            String DateOutput = String.Join("", y);

            //Convert year into bangla
            string numOfYear = yr.ToString();
            string[] m = new string[numOfYear.Length];
            string[] n = new string[numOfYear.Length];
            for (int i = 0; i < numOfYear.Length; i++)
            {
                m[i] = numOfYear.Substring(i, 1);
                switch (m[i])
                {
                    case "0":
                        n[i] = "০";
                        break;
                    case "1":
                        n[i] = "১";
                        break;
                    case "2":
                        n[i] = "২";
                        break;
                    case "3":
                        n[i] = "৩";
                        break;
                    case "4":
                        n[i] = "৪";
                        break;
                    case "5":
                        n[i] = "৫";
                        break;
                    case "6":
                        n[i] = "৬";
                        break;
                    case "7":
                        n[i] = "৭";
                        break;
                    case "8":
                        n[i] = "৮";
                        break;
                    case "9":
                        n[i] = "৯";
                        break;
                    default:
                        break;
                }
            }
            String YearOutput = String.Join("", n);

            string MonthName = "";
            switch (month)
            {
                case 1:
                    MonthName = "January";
                    break;
                case 2:
                    MonthName = "February";
                    break;
                case 3:
                    MonthName = "March";
                    break;
                case 4:
                    MonthName = "April";
                    break;
                case 5:
                    MonthName = "May";
                    break;
                case 6:
                    MonthName = "June";
                    break;
                case 7:
                    MonthName = "July";
                    break;
                case 8:
                    MonthName = "August";
                    break;
                case 9:
                    MonthName = "September";
                    break;
                case 10:
                    MonthName = "October";
                    break;
                case 11:
                    MonthName = "November";
                    break;
                case 12:
                    MonthName = "December";
                    break;
            }

            BanglaDate.Text = character.ToString() + " " + DateOutput + ", " + YearOutput;
            EnglishDate.Text = date + " " + MonthName + ", " + year;
            ArabicDate.Text = ArabicDigit.ToString() + " " + ArabicMonth.ToString() + ", " + ArabYr;

            //Fill event section
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand ThisWeekCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[event] WHERE day=" + date + " and month=" + month, conn);
            SqlDataReader twdr = ThisWeekCmd.ExecuteReader();
            if (twdr.HasRows)
            {
                while (twdr.Read())
                {
                    int IndexHoliday = twdr.GetOrdinal("holiday");
                    string EventHoliday = twdr.GetString(IndexHoliday);

                    HolidayLblTxt.Text = EventHoliday;
                    //AppointLblTxt.Text = ;
                }
            }
            else
            {
                HolidayLblTxt.Text = "No holiday today!";
                AppointLblTxt.Text = "No appointment today!";
            }
        }

        private object findArabicMonth(string value)
        {
            var val = Regex.Match(value, @"(?i)^[a-z]+");

            if (val.ToString() == "saf")
            {
                ArabicMonth = "Safar";
            }
            else if (val.ToString() == "raa")
            {
                ArabicMonth = "Rabi-al-Awwal";
            }
            else if (val.ToString() == "rus")
            {
                ArabicMonth = "Rabi-us-Sani";
            }
            else if (val.ToString() == "jua")
            {
                ArabicMonth = "Jumada-al-awwal";
            }
            else if (val.ToString() == "jus")
            {
                ArabicMonth = "Jamadi-us-Sani";
            }
            else if (val.ToString() == "raj")
            {
                ArabicMonth = "Rajab";
            }
            else if (val.ToString() == "sha")
            {
                ArabicMonth = "Sha'baan";
            }
            else if (val.ToString() == "rad")
            {
                ArabicMonth = "Ramadan";
            }
            else if (val.ToString() == "shw")
            {
                ArabicMonth = "Shawal";
            }
            else if (val.ToString() == "ziq")
            {
                ArabicMonth = "Zilqad";
            }
            else if (val.ToString() == "zih")
            {
                ArabicMonth = "Zilhajj";
            }
            else if (val.ToString() == "muh")
            {
                ArabicMonth = "Muharram";
            }

            return ArabicMonth;
        }

        private object findDate(string value)
        {
            var val = Regex.Match(value, @"\d+");
            return val;
        }

        private object findMonth(string value)
        {
            var val = Regex.Match(value, @"(?i)^[a-z]+");

            if (val.ToString() == "bai")
            {
                BanglaMonth = "বৈশাখ";
            }
            else if (val.ToString() == "jai")
            {
                BanglaMonth = "জ্যৈষ্ঠ";
            }
            else if (val.ToString() == "asr")
            {
                BanglaMonth = "আষাঢ়";
            }
            else if (val.ToString() == "sra")
            {
                BanglaMonth = "শ্রাবন";
            }
            else if (val.ToString() == "vad")
            {
                BanglaMonth = "ভাদ্র";
            }
            else if (val.ToString() == "ars")
            {
                BanglaMonth = "আশ্বিন";
            }
            else if (val.ToString() == "kar")
            {
                BanglaMonth = "কার্তিক";
            }
            else if (val.ToString() == "agr")
            {
                BanglaMonth = "অগ্রহায়ণ";
            }
            else if (val.ToString() == "pou")
            {
                BanglaMonth = "পৌষ";
            }
            else if (val.ToString() == "mag")
            {
                BanglaMonth = "মাঘ";
            }
            else if (val.ToString() == "fal")
            {
                BanglaMonth = "ফাল্গুন";
            }
            else if (val.ToString() == "cai")
            {
                BanglaMonth = "চৈত্র";
            }

            return BanglaMonth;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.HomeAdmin_Control);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.AllPerson_Control);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Users_Control);
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Teachers_Control);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Students_Control);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Class_Control);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Subject_Control);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Result_Control);
        }

        private void btnAdminSetting_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Admin_Settings);
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {

        }

        private void btnEventManagement_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Event_Control);
        }

        private void btnUserlogInfo_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.UserLog_Control);
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Program.MainWindow.ShowControl(SequenceEnum.Progress_Control);
        }  
    }
}
