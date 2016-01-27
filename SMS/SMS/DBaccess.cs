using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SMS
{
    public class DBaccess
    {
        SqlConnection conn;
        public DBaccess()
        {
            conn = DBconnection.GetConnection();
        }
    }
}
