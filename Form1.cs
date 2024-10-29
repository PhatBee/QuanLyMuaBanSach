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
    public partial class Form1 : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sql = new SqlCommand();
        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = tbxUser.Text;
            string password = tbxPass.Text;

            mydb.openConection();

            sql = new SqlCommand("proc_KiemTraDangNhap", mydb.getConnection);
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.AddWithValue("@username", user);
            sql.Parameters.AddWithValue("@password", password);

            bool result = (bool)sql.ExecuteScalar();


            if (result != true)
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmChinh mainForm = new frmChinh(); // Form chính sau khi đăng nhập
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }

            //frmChinh frmChinh = new frmChinh();
            //frmChinh.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
