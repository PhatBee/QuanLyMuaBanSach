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
    }
}
