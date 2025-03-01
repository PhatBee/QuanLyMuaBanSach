﻿using System;
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

        MyDB mydb;
        SqlCommand sqlCommand = new SqlCommand();
        string sqlcon;

        public frmQuanLyNhanVien(string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            mydb = new MyDB(sqlcon);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            enableTextBox();
            txtbxUsernameMoi.Enabled = true;
            btnXacNhan.Enabled = true;
            btnThemNV.Enabled = false;
            btnSuaNV.Enabled = true;

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            enableTextBox();
            txtbxUsernameMoi.Enabled = false;
            btnXacNhan.Enabled = true;
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = false;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataNV.AutoGenerateColumns = true;
            dataNV.DataSource = LayDanhSachNhanVien();
            refresh();
            disableTextBox();

        }

        public DataTable LayDanhSachNhanVien()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
                
            
        }

        private void btnXacNhanNV_Click(object sender, EventArgs e)
        {
            string tenNV = txtBoxTimKiem.Text;
            dataNV.DataSource = timKiemNhanVien(tenNV);
        }

        private DataTable timKiemNhanVien(string text)
        {
            mydb.openConection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("proc_TimKiemNhanVienTheoTen", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenNV", text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            mydb.closeConection();
            return dt;
        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnVoHieuNV_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = dataNV.CurrentRow.Cells[0].Value.ToString();
                mydb.openConection();
                sqlCommand = new SqlCommand("proc_NgungHoatDongNhanVien", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maNV", manv);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Ngừng hoạt động nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmQuanLyNhanVien_Load(sender, e);
        }

        private void refresh()
        {
            txtbxDiaChi.Text = "";
            txtbxMaNV.Text = "";
            txtbxSDT.Text = "";
            txtbxTenNV.Text = "";
            txtbxUsernameMoi.Text = "";
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnXacNhan.Enabled = false;
        }

        private void disableTextBox()
        {
            txtbxTenNV.Enabled = false;
            txtbxSDT.Enabled = false;
            txtbxDiaChi.Enabled = false;
            datipikrNgaySinh.Enabled = false;
            txtbxUsernameMoi.Enabled = false;
            
            
            }

        private void enableTextBox()
        {
            txtbxTenNV.Enabled = true;
            txtbxSDT.Enabled = true;
            txtbxDiaChi.Enabled= true;
            datipikrNgaySinh.Enabled = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        { // Sua
            if (!btnSuaNV.Enabled && btnThemNV.Enabled)
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
            else if(!btnThemNV.Enabled && btnSuaNV.Enabled)
            {// Them
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
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhên viên thất bại. Mã lỗi: " + ex.Message, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    frmQuanLyNhanVien_Load(sender, e);
            }
        }

        private void btnKichHoatNV_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = dataNV.CurrentRow.Cells[0].Value.ToString();
                mydb.openConection();
                sqlCommand = new SqlCommand("pro_KichHoatNhanVien", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maNV", manv);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Kích hoạt nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmQuanLyNhanVien_Load(sender, e);
        }
    }
}
