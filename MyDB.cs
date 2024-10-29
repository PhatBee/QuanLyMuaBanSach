using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach
{
    internal class MyDB
    {
         private static string sqlcon = "Data Source=TAMA\\TAMA;Initial Catalog=QLNhaSach;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //private static string sqlcon = "Data Source=LAPTOP-1BLCIFVL\\PHATBEE;Initial Catalog=QLNhaSach;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(sqlcon);
        public SqlConnection getConnection
        {
            get { return conn; }
        }

        // open the connection
        public void openConection()
        {
            if ((conn.State == System.Data.ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        // close the connection
        public void closeConection()
        {
            if ((conn.State == System.Data.ConnectionState.Open))
            {
                conn.Close();
            }
        }
    }
}
