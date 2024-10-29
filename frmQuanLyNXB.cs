using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanSach
{
    public partial class frmQuanLyNXB : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;

        public frmQuanLyNXB()
        {
            InitializeComponent();
        }

        private void frmQuanLyNXB_Load(object sender, EventArgs e)
        {
            dataNXB.AutoGenerateColumns = true;
            dataNXB.DataSource = layDanhSachNXB();
        }

        public DataTable layDanhSachNXB()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachNhaXuatBan", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
