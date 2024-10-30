using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanSach
{
    public partial class frmChinh : Form
    {
        private string maNV;
        public frmChinh(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
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
            OpenChildForm(new frmQuanLyNhanVien());
        }

        private void panelNhapSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapSach(this.maNV));
        }

        private void panelQlSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSach());
        }

        private void panelKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhachHang());
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            label1.Text = maNV.ToString();
        }

        private void panelBanSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanSach("NV001"));
        }

        private void panelThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }
    }
}
