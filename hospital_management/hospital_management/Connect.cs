using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hospital_management
{
    internal class Connect
    {
        public SqlConnection link()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-KVV9CU5\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
