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

        private void dataKhachHang_DoubleClick(object sender, EventArgs e)
        {
            //MaKH, tenKH, sdt
            try
            {
                txtBoxMaKhanhHang.Text = dataKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtBoxMaKhanhHang.Text = dataKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtBoxMaKhanhHang.Text = dataKhachHang.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
