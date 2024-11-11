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
    public partial class frmQuanLyKhachHang : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dataKhachHang.AutoGenerateColumns = true;
            dataKhachHang.DataSource = layDanhSachKhachHang();
        }

        public DataTable layDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_layDanhSachKhachHang", mydb.getConnection);
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
                string tenKH = txtBoxTenKhachHang.Text;
                string sdt = txtBoxSDT.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("proc_ThemKhachHang", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tenKH", tenKH);
                sqlCommand.Parameters.AddWithValue("@SDT", sdt);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã thêm khách hàng mới thành công!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khách hàng thất bại. Mã lỗi: " + ex.Message, "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtBoxMaKhanhHang.Text;
                string tenKH = txtBoxTenKhachHang.Text;
                string sdt = txtBoxSDT.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("proc_SuaThongTinKhachHang", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@MaKH", maKH);
                sqlCommand.Parameters.AddWithValue("@TenKH", tenKH);
                sqlCommand.Parameters.AddWithValue("@SDT", sdt);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã sửa thông tin khách hàng mới thành công!", "Sửa thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại. Mã lỗi: " + ex.Message, "Sửa thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxMaKhanhHang.Text = dataKhachHang.CurrentRow.Cells[0].Value.ToString();
                string maKH = txtBoxMaKhanhHang.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_xoaKhachHang", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maKH", maKH);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mydb.closeConection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá khách hàng thất bại, do khách hàng đang được dùng trên hệ thống. Mã lỗi: " + ex.Message, "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyKhachHang_Load(sender, e);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenKH = txtBoxTimKiem.Text;
            dataKhachHang.DataSource = timKiemKH(tenKH);
        }

        private DataTable timKiemKH(string text)
        {
            mydb.openConection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("proc_TimKiemKhachHangTheoTen", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenKH", text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            mydb.closeConection();
            return dt;
        }

        private void dataKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MaKH, tenKH, sdt
            try
            {
                txtBoxMaKhanhHang.Text = dataKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtBoxTenKhachHang.Text = dataKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtBoxSDT.Text = dataKhachHang.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
