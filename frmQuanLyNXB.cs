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
        MyDB mydb;
        SqlCommand sqlCommand = new SqlCommand();
        string sqlcon;
        public frmQuanLyNXB(string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            mydb = new MyDB(sqlcon);
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
            try
            {
                string tenNXB = txtBoxTenNXB.Text;
                string diaChiNXB = txtBoxNXB.Text;
                string sdtNXB = txtBoxSDT.Text;
                

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_ThemNXB", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tenNXB", tenNXB);
                sqlCommand.Parameters.AddWithValue("@SDT", sdtNXB);
                sqlCommand.Parameters.AddWithValue("@diaChiNXB", diaChiNXB);
           

                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã thêm nhà xuất bản mới thành công!", "Thêm nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhà xuất bản thất bại. Mã lỗi: " + ex.Message, "Thêm nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyNXB_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNXB = txtBoxTenNXB.Text;
                string diaChiNXB = txtBoxNXB.Text;
                string sdtNXB = txtBoxSDT.Text;
                string maNXB = txtBoxMaNXB.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_SuaNXB", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maNXB", maNXB);
                sqlCommand.Parameters.AddWithValue("@tenNXB", tenNXB);
                sqlCommand.Parameters.AddWithValue("@SDT", sdtNXB);
                sqlCommand.Parameters.AddWithValue("@diaChiNXB", diaChiNXB);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã sửa thông tin nhà xuất bản thành công!", "Sửa thông tin nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thông tin nhà xuất bản thất bại. Mã lỗi: " + ex.Message, "Sửa thông tin nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyNXB_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxMaNXB.Text = dataNXB.CurrentRow.Cells[0].Value.ToString();
                string maNXB = txtBoxMaNXB.Text;

                mydb.openConection();


                sqlCommand = new SqlCommand("proc_XoaNXB", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maNXB", maNXB);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa nhà xuất bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà xuất bản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mydb.closeConection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá nhà xuất bản thất bại, do nhà xuất bản đang được dùng trên hệ thống. Mã lỗi: " + ex.Message, "Xoá nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyNXB_Load(sender, e);
        }

        private void dataNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            // MaNXB, TenNXB, DiaChi, SDT
            try
            {
                txtBoxMaNXB.Text = dataNXB.CurrentRow.Cells[0].Value.ToString();
                txtBoxTenNXB.Text = dataNXB.CurrentRow.Cells[1].Value.ToString();
                txtBoxSDT.Text = dataNXB.CurrentRow.Cells[3].Value.ToString();
                txtBoxNXB.Text = dataNXB.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
