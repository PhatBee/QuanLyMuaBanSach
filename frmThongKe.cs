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
    public partial class frmThongKe : Form
    {
        private string sqlcon;
        MyDB myDB;
        public frmThongKe(string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            myDB = new MyDB(sqlcon);
        }
        

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime dateA = tungay.Value;
            DateTime dateB = den.Value;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_ThongKeSachVaDoanhThuTong(@dateA, @dateB)", myDB.getConnection);
                cmd.Parameters.AddWithValue("@dateA", dateA);
                cmd.Parameters.AddWithValue("@dateB", dateB);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                txtDoanhThu.Text = dataTable.Rows[0]["TongDoanhThu"].ToString();
                txtLoiNhuan.Text = dataTable.Rows[0]["TongLoiNhuan"].ToString();
                dataTable.Columns.Remove("TongDoanhThu");
                dataTable.Columns.Remove("TongLoiNhuan");

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myDB.closeConection();
            }
        }

        private void btnKPINhanVien_Click(object sender, EventArgs e)
        {
            //frmkpinhanvien frm = new frmkpinhanvien(sqlcon);
            //frm.showdialog();
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            Form frmDuDoan = new frmDuDoan(sqlcon);
            frmDuDoan.ShowDialog();
        }
    }
}
