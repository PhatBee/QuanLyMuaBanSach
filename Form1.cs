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
        private string maNV;
        MyDB mydb = new MyDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = tbxUser.Text.ToString();
            string password = tbxPass.Text.ToString();

            mydb.openConection();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("proc_login", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            mydb.closeConection();

            if(dt.Rows.Count > 0)
            {
                maNV = dt.Rows[0][0].ToString();
                frmChinh frmChinh = new frmChinh(this.maNV);
                frmChinh.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản chưa có trên hệ thống", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            
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
