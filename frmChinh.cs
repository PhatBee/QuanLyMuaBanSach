using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace QuanLyMuaBanSach
{
    public partial class frmChinh : Form
    {
        private string maNV;
        private string sqlcon;
        private MyDB myDB;
        public frmChinh(string maNV, string sqlcon)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.sqlcon = sqlcon;
            this.myDB = new MyDB(sqlcon);
            moChucNang();
            
        }

        private void moChucNang()
        {
            myDB.openConection();
            SqlCommand command = new SqlCommand("proc_layRoleIDvaTenNhanVien", myDB.getConnection);
            command.CommandType = CommandType.StoredProcedure;

            // Add the input parameter for maNV
            command.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10)).Value = maNV;

            // Add the output parameters for roleId and tenNV
            SqlParameter roleIdParam = new SqlParameter("@roleId", SqlDbType.Int);
            roleIdParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(roleIdParam);

            SqlParameter tenNVParam = new SqlParameter("@tenNV", SqlDbType.NVarChar, 250);
            tenNVParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(tenNVParam);

            // Execute the stored procedure
            command.ExecuteNonQuery();

            // Retrieve the output parameter values
            int roleId = (int)roleIdParam.Value;
            string tenNV = (string)tenNVParam.Value;
            if (roleId == 1)
            {
                panelNhanVien.Visible = false;
                panelKhachHang.Visible = false;
                panelQlSach.Visible = false;
                panelThongKe.Visible = false;
                panelHoaDon.Visible = false;
            }
            label1.Text = tenNV.ToString();


        }


        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            mainPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void panelNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyNhanVien(sqlcon));
        }

        private void panelNhapSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapSach(this.maNV,sqlcon));
        }

        private void panelQlSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSach(sqlcon));
        }

        private void panelKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhachHang(sqlcon));
        }

        private void panelBanSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanSach(maNV,sqlcon));
        }

        private void panelThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe(sqlcon));
        }

        private void panelHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(sqlcon));
        }
    }
}
