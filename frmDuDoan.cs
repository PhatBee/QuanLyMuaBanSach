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
    public partial class frmDuDoan : Form
    {
        private string sqlcon;
        MyDB myDB;
        public frmDuDoan(string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            myDB = new MyDB(sqlcon);
        }
        private void frmDuDoan_Load(object sender, EventArgs e)
        {
            myDB.openConection();
            SqlCommand cmd = new SqlCommand("select * from dbo.func_DuDoanDoanhSoChoThangTiepTheo()", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dvgDuDoan.DataSource = dataTable;   

            myDB.closeConection();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
