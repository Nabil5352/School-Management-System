using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SMS
{
    public partial class Progress : UserControl
    {
        SqlConnection conn;
        public Progress()
        {
            InitializeComponent();
            //FillProgressDbase fpdb = new FillProgressDbase();
            //fpdb.FillChartList();
            FillShiftList();
        }

        private void FillShiftList()
        {
            conn = DBconnection.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            var ShiftDictionary = new Dictionary<string, string>();
            ShiftDictionary.Add("Morning", "Morning");
            ShiftDictionary.Add("Day", "Day");

            SelectShiftCombo.DisplayMember = "Value";
            SelectShiftCombo.ValueMember = "Key";
            SelectShiftCombo.DataSource = new BindingSource(ShiftDictionary, null);
        }

        private void SelectShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string value = SelectShiftCombo.SelectedValue.ToString();
                FillChartList(value);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void FillChartList(string value)
        {
            SqlCommand ClassListCmd = new SqlCommand("SELECT * FROM [sms].[dbo].[class] WHERE shift='" + value + "'", conn);
            SqlDataReader cldr = ClassListCmd.ExecuteReader();
            if (cldr.HasRows)
            {
                while (cldr.Read())
                {
                    int IndexClassID = cldr.GetOrdinal("class_id");
                    int IndexClass = cldr.GetOrdinal("class");

                    string ClassID = cldr.GetString(IndexClassID);
                    string Class = cldr.GetString(IndexClass);

                    for (int i = 1; i <= 3; i++)
                    {
                        SqlCommand GetResultCmd = new SqlCommand("SELECT progress FROM [sms].[dbo].[progress] as pr INNER JOIN [sms].[dbo].[class] as cl ON pr.class = cl.class_id WHERE pr.class='"+ClassID+"' AND term="+i, conn);
                        SqlDataReader grdr = GetResultCmd.ExecuteReader();
                        if (grdr.HasRows)
                        {
                            while (grdr.Read())
                            {
                                int IndexProgress = grdr.GetOrdinal("progress");
                                int Progress = grdr.GetInt32(IndexProgress);
                                switch (i)
                                {
                                    case 1:
                                        this.TermChart.Series["1st Term"].Points.AddXY(Class, Progress);                                        
                                        break;
                                    case 2:
                                        this.TermChart.Series["2nd Term"].Points.AddXY(Class, Progress);                                       
                                        break;
                                    case 3:
                                        this.TermChart.Series["Final Term"].Points.AddXY(Class, Progress);
                                        break;
                                }
                            }
                        }
                    }
                }
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
    }
}
