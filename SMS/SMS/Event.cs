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
    public partial class Event : UserControl
    {
        SqlConnection conn;
        public Event()
        {
            InitializeComponent();
            FindToday();
            FillYearSummary();
        }

        private void FillYearSummary()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            try
            {
            SqlCommand eventListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[event]", conn);
            SqlDataReader dr = eventListCmd.ExecuteReader();
            if (dr.HasRows)
            {
                int x = 0;
                SqlCommand noOfEvnt = new SqlCommand("SELECT COUNT(*) FROM [sms].[dbo].[event]", conn);
                noOfEvnt.CommandType = CommandType.Text;
                var Count = (Int32)noOfEvnt.ExecuteScalar();
                while (dr.Read())
                {
                    int IndexDay = dr.GetOrdinal("day");
                    int IndexMonth = dr.GetOrdinal("month");
                    int IndexHoliday = dr.GetOrdinal("holiday");
                    int IndexAppoint = dr.GetOrdinal("appointment");
                    int IndexAppointTime = dr.GetOrdinal("appointment_time");

                    int Day = dr.GetInt32(IndexDay);
                    int Month = dr.GetInt32(IndexMonth);
                    string Holiday = dr.GetString(IndexHoliday);
                    string Appoint = dr.GetString(IndexAppoint);
                    string AppointTime = dr.GetString(IndexAppointTime);

                    string MonthName = "";
                    switch (Month)
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

                    Label U_lbl = new Label();
                    U_lbl.Location = new Point(15, 20 + (x * 60));
                    U_lbl.Name = "lbl_U" + x;
                    U_lbl.Text = "Date: " + MonthName +" " + Day;
                    U_lbl.AutoSize = true;
                    tabHolidays.Controls.Add(U_lbl);

                    Label L_lbl = new Label();
                    L_lbl.Location = new Point(15, 20 + (20 + x * 60));
                    L_lbl.Name = "lbl_L" + x;
                    L_lbl.Text = "Holiday: " + Holiday;
                    L_lbl.AutoSize = true;
                    tabHolidays.Controls.Add(L_lbl);
                    x = x + 1;
                }
            }
            }
            catch (NullReferenceException)
            {
            }
        }

        public object BanglaMonth { get; set; }
        public object ArabicMonth { get; set; }

        private void FindToday()
        {
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

            BanglaDate.Text = character.ToString() + " " + DateOutput + ", " + YearOutput;
            ArabicDate.Text = ArabicDigit.ToString() + " " + ArabicMonth.ToString() + ", " + ArabYr;

            //Fill this week section
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand ThisWeekCmd = new SqlCommand("SELECT Top 7 * FROM [sms].[dbo].[event] WHERE day>="+date+" and month>="+month, conn);
            SqlDataReader twdr = ThisWeekCmd.ExecuteReader();
            if (twdr.HasRows)
            {
                int z = 0;
                while (twdr.Read())
                {
                    int IndexDate = twdr.GetOrdinal("day");
                    int IndexMonth = twdr.GetOrdinal("month");
                    int IndexHoliday = twdr.GetOrdinal("holiday");

                    int TopDate = twdr.GetInt32(IndexDate);
                    int TopMonth = twdr.GetInt32(IndexMonth);
                    string TopHoliday = twdr.GetString(IndexHoliday);

                    string MonthName = "";
                    switch (TopMonth)
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

                    Label TweekU_lbl = new Label();
                    TweekU_lbl.Location = new Point(14, 12 + (z * 22));
                    TweekU_lbl.Name = "TweekU_lbl_" + z;
                    TweekU_lbl.Text = MonthName + " " + TopDate;
                    TweekU_lbl.AutoSize = true;
                    thisWeekPanel.Controls.Add(TweekU_lbl);

                    Label TweekL_lbl = new Label();
                    TweekL_lbl.Location = new Point(89, 12 + (z * 22));
                    TweekL_lbl.Name = "TweekL_lbl_" + z;
                    TweekL_lbl.Text = " :  " + TopHoliday;
                    TweekL_lbl.AutoSize = true;
                    thisWeekPanel.Controls.Add(TweekL_lbl);
                    z = z + 1;
                }
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
        
    }
}
