using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach
{
    internal class MyDB
    {
        public string sqlcon;
        SqlConnection conn;

        public MyDB(string sqlcon)
        { 
            this.sqlcon = sqlcon;
            conn = new SqlConnection(sqlcon);
        }

        //private static string sqlcon = "Data Source=TAMA\\TAMA;Initial Catalog=QLNhaSach;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
         
        // private static string sqlcon = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234;Encrypt=False";
        //private static string sqlcon = "Data Source=LAPTOP-1BLCIFVL\\PHATBEE;Initial Catalog=QLNhaSach;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        

        public SqlConnection getConnection
        {

            get { return conn; }
        }

        // Mở kết nối
        public void openConection()
        {
            if ((conn.State == System.Data.ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        // Đóng kết nối
        public void closeConection()
        {
            if ((conn.State == System.Data.ConnectionState.Open))
            {
                conn.Close();
            }
        }
    }
}
