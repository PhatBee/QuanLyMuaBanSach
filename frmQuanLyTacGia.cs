﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyMuaBanSach
{
    public partial class frmQuanLyTacGia : Form
    {
        MyDB mydb;
        SqlCommand sqlCommand = new SqlCommand();
        string sqlcon;
        public frmQuanLyTacGia(string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            mydb = new MyDB(sqlcon);
        }

        private void frmQuanLyTacGia_Load(object sender, EventArgs e)
        {
            dataTacGia.AutoGenerateColumns = true;
            dataTacGia.DataSource = layDanhSachTacGia();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTG = txtBoxTenTG.Text;
                string sdtTG = txtBoxSDT.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("proc_ThemTacGia", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tenTG", tenTG);
                sqlCommand.Parameters.AddWithValue("@SDT", sdtTG);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã thêm tác giả mới thành công!", "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tác giả thất bại. Mã lỗi: " + ex.Message, "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTacGia_Load(sender, e);
        }

        public DataTable layDanhSachTacGia()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachTacGia", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        private void dataTacGia_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maTG = txtBoxMaTG.Text;
                string tenTG = txtBoxTenTG.Text;
                string sdtTG = txtBoxSDT.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("proc_SuaThongTinTacGia", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@MaTG", maTG);
                sqlCommand.Parameters.AddWithValue("@TenTG", tenTG);
                sqlCommand.Parameters.AddWithValue("@SDT", sdtTG);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã sửa thông tin tác giả thành công!", "Sửa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa tác giả thất bại. Mã lỗi: " + ex.Message, "Sửa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTacGia_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxMaTG.Text = dataTacGia.CurrentRow.Cells[0].Value.ToString();
                string maTG = txtBoxMaTG.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_xoaTacGia", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maTG", maTG);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tác giả cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mydb.closeConection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá tác giả thất bại, do tác giả đang được dùng trên hệ thống. Mã lỗi: " + ex.Message, "Xoá tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTacGia_Load(sender, e);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenTG = txtBoxMaTG.Text;
            dataTacGia.DataSource = timKiemTacGia(tenTG);
        }

        public DataTable timKiemTacGia(string text)
        {
            mydb.openConection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("proc_TimKiemTacGiaTheoTen", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenTG", text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            mydb.closeConection();
            return dt;
        }

        private void dataTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MaTG, TenTG, SDT
            try
            {
                txtBoxMaTG.Text = dataTacGia.CurrentRow.Cells[0].Value.ToString();
                txtBoxTenTG.Text = dataTacGia.CurrentRow.Cells[1].Value.ToString();
                txtBoxSDT.Text = dataTacGia.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
