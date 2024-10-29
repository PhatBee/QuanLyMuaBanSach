using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace QuanLyMuaBanSach
{
    public partial class frmQuanLyNhanVien : Form
    {

        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtbxMaNV.Text;
                string tenNV = txtbxTenNV.Text;
                string gioiTinh = "";
                if (rdobtnNam.Checked)
                {
                    gioiTinh = "male";
                }
                else if (rdobtnNu.Checked)
                {
                    gioiTinh = "female";
                }
                else
                {
                    gioiTinh = "other";
                }

                DateTime ngaySinh = datipikrNgaySinh.Value;

                string sdt = txtbxSDT.Text;
                string diaChi = txtbxDiaChi.Text;
                string unameMoi = txtbxUsernameMoi.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_ThemNhanVien", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@username", unameMoi);
                sqlCommand.Parameters.AddWithValue("@tenNV", tenNV);
                sqlCommand.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                sqlCommand.Parameters.AddWithValue("@SDT", sdt);
                sqlCommand.Parameters.AddWithValue("@diaChi", diaChi);

                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã thêm nhân viên mới thành công!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex){
                MessageBox.Show("Thêm nhên viên thất bại. Mã lỗi: " + ex.Message, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtbxMaNV.Text;
                string tenNV = txtbxTenNV.Text;
                string gioiTinh = "";
                if (rdobtnNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (rdobtnNu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                else
                {
                    gioiTinh = "Khác";
                }

                DateTime ngaySinh = datipikrNgaySinh.Value;

                string sdt = txtbxSDT.Text;
                string diaChi = txtbxDiaChi.Text;
                string unameMoi = txtbxUsernameMoi.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_SuaThongTinNhanVien", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maNV", maNV);
                sqlCommand.Parameters.AddWithValue("@tenNV", tenNV);
                sqlCommand.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                sqlCommand.Parameters.AddWithValue("@SDT", sdt);
                sqlCommand.Parameters.AddWithValue("@diaChi", diaChi);

                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại. Mã lỗi: " + ex.Message, "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            frmQuanLyNhanVien_Load(sender, e);
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataNV.AutoGenerateColumns = true;
            dataNV.DataSource = LayDanhSachNhanVien();

            

        }

        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachNhanVien", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        private void dataNV_DoubleClick(object sender, EventArgs e)
        { // MaNV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi
            try
            {
                txtbxMaNV.Text = dataNV.CurrentRow.Cells[0].Value.ToString();
                txtbxTenNV.Text = dataNV.CurrentRow.Cells[1].Value.ToString();
                if ((dataNV.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam"))
                {
                    rdobtnNam.Checked = true;
                }
                if ((dataNV.CurrentRow.Cells[2].Value.ToString().Trim() == "Nữ"))
                {
                    rdobtnNu.Checked = true;
                }
                if ((dataNV.CurrentRow.Cells[2].Value.ToString().Trim() == "Khác"))
                {
                    rdobtnKhac.Checked = true;
                }

                datipikrNgaySinh.Value = (DateTime)dataNV.CurrentRow.Cells[3].Value;
                txtbxSDT.Text = dataNV.CurrentRow.Cells[4].Value.ToString();
                txtbxDiaChi.Text = dataNV.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
