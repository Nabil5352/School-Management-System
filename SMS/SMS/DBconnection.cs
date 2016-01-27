using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SMS
{
    class DBconnection
    {
        public static SqlConnection NewCon;
        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            NewCon = new SqlConnection(ConStr);
            NewCon.Open();
            return NewCon;
        }

        public static string UserLogInName { get; set; }
    }
}
