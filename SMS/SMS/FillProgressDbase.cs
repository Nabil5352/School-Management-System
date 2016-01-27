using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public class FillProgressDbase
    {
        SqlConnection conn;
        public void FillChartList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand classListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class]", conn);
                SqlDataReader cldr = classListCmd.ExecuteReader();
                {
                    if (cldr.HasRows)
                    {
                        while (cldr.Read())
                        {
                            for (int term = 1; term <= 3; term++)
                            {
                                int IndexClassID = cldr.GetOrdinal("class_id");
                                string classID = cldr.GetString(IndexClassID);

                                SqlCommand ResultCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[result] as re INNER JOIN [sms].[dbo].[class] as cls ON re.class_id = cls.class_id WHERE re.class_id='" + classID + "' AND re.exam_id=" + term, conn);
                                SqlDataReader rdr = ResultCmd.ExecuteReader();
                                if (rdr.HasRows)
                                {
                                    int TotalPercentage = 0;
                                    while (rdr.Read())
                                    {
                                        CalculateProgress cp = new CalculateProgress();

                                        var digit = findDigit(classID);

                                        string v = digit.ToString();
                                        string c = "Nothing";
                                        if (v == "01" || v == "02" || v == "03" || v == "04" || v == "05" || v == "06" || v == "07" || v == "08" || v == "09")
                                        {
                                            c = v.Replace("0", " ");
                                        }
                                        else if (v == "10")
                                        {
                                            c = v;
                                        }

                                        int intDigit = Convert.ToInt32(c);

                                        SqlCommand noOfSubject = new SqlCommand("SELECT count(subject_id) FROM [sms].[dbo].[subject] WHERE class_id=" + digit, conn);
                                        noOfSubject.CommandType = CommandType.Text;
                                        int countSubject = (Int32)noOfSubject.ExecuteScalar();
                                        int[] receiveProgressValue = new int[countSubject];

                                        int IndexTotalStudent = rdr.GetOrdinal("total_student");
                                        int totalStd = rdr.GetInt32(IndexTotalStudent);

                                        for (int i = 1, j = 0; i <= countSubject; i++, j++)
                                        {
                                            SqlCommand noOfFirstStd = new SqlCommand("SELECT count(*) FROM [sms].[dbo].[result] WHERE class_id='" + classID + "' AND subject_id='c" + intDigit + "s" + i + "' AND exam_id=" + term + " AND gpa = 5", conn);
                                            noOfFirstStd.CommandType = CommandType.Text;
                                            int firstStd = (Int32)noOfFirstStd.ExecuteScalar();

                                            SqlCommand noOfSecondStd = new SqlCommand("SELECT count(*) FROM [sms].[dbo].[result] WHERE class_id='" + classID + "' AND subject_id='c" + intDigit + "s" + i + "' AND exam_id=" + term + " AND gpa = 4", conn);
                                            noOfSecondStd.CommandType = CommandType.Text;
                                            int secondStd = (Int32)noOfSecondStd.ExecuteScalar();

                                            SqlCommand noThirdStd = new SqlCommand("SELECT count(*) FROM [sms].[dbo].[result] WHERE class_id='" + classID + "' AND subject_id='c" + intDigit + "s" + i + "' AND exam_id=" + term + " AND gpa < 4 AND gpa >= 3", conn);
                                            noThirdStd.CommandType = CommandType.Text;
                                            int thirdStd = (Int32)noThirdStd.ExecuteScalar();

                                            SqlCommand noOtherStd = new SqlCommand("SELECT count(*) FROM [sms].[dbo].[result] WHERE class_id='" + classID + "' AND subject_id='c" + intDigit + "s" + i + "' AND exam_id=" + term + " AND gpa <= 2", conn);
                                            noOtherStd.CommandType = CommandType.Text;
                                            int otherStd = (Int32)noOtherStd.ExecuteScalar();

                                            var subjectValue = cp.SingleSubjectCalculation(totalStd, firstStd, secondStd, thirdStd, otherStd);
                                            receiveProgressValue[j] = subjectValue;
                                        }

                                        int Tvalue = 0;
                                        for (int k = 0; k < receiveProgressValue.Length; k++)
                                        {
                                            Tvalue = Tvalue + receiveProgressValue[k];
                                        }
                                        Array.Clear(receiveProgressValue, 0, receiveProgressValue.Length);

                                        TotalPercentage = cp.AllSubjectCalculation(countSubject, Tvalue);

                                        //var Class = TeachSelectCmbox.SelectedValue;
                                        //var Term = term;
                                        //var Progress = TotalPercentage;

                                        //SqlCommand insertValueCmd = new SqlCommand("INSERT INTO [sms].[dbo].[progress](class, term, progress) " +
                                        //    "VALUES (@class, @term, @progress)", conn);
                                        //insertValueCmd.Parameters.AddWithValue("@class", Class);
                                        //insertValueCmd.Parameters.AddWithValue("@term", Term);
                                        //insertValueCmd.Parameters.AddWithValue("@progress", Progress);

                                        //insertValueCmd.ExecuteNonQuery();
                                    }                                   
                                }
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException)
            { }
        }

        private object findDigit(string value)
        {
            var val = Regex.Match(value, @"\d+");
            return val;
        }
    }
}
