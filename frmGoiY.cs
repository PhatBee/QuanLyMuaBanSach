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
    public partial class frmGoiY : Form
    {
        private string sqlcon;
        private string maKH;
        MyDB myDB;
        public frmGoiY(string sqlcon, string maKH)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            this.maKH = maKH;
            myDB = new MyDB(sqlcon);
        }
        private void frmGoiY_Load(object sender, EventArgs e)
        {
            myDB.openConection();
            SqlCommand cmd = new SqlCommand("select * from dbo.GetBookSuggestionsForCustomer(@maKH)", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@maKH", maKH);
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
