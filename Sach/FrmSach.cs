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
    public partial class FrmSach : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;
        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            napTenNXB();
        }

        private void btnQLTheLoai_Click(object sender, EventArgs e)
        {
            frmQuanLyTheLoai qlTheLoai = new frmQuanLyTheLoai();
            qlTheLoai.Show();
        }

        private void btnQLNXB_Click(object sender, EventArgs e)
        {
            frmQuanLyNXB qlNXB = new frmQuanLyNXB();
            qlNXB.Show();
        }

        private void btnQLTacGia_Click(object sender, EventArgs e)
        {
            frmQuanLyTacGia quanLyTacGia = new frmQuanLyTacGia();
            quanLyTacGia.Show();
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

        public void napTenNXB()
        {
            DataTable dt = new DataTable();
            dt = layDanhSachNXB();
            comboBoxNXB.DataSource = dt;
            comboBoxNXB.DisplayMember = "tenNXB";
            comboBoxNXB.ValueMember = "maNXB";
        }
    }
}
