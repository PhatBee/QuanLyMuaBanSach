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

namespace QuanLyMuaBanSach
{
    public partial class frmBanSach : Form
    {
       
        private string maNV;
        private string maKH;
        private string maHD;
        private bool cosan;
        private string sqlcon;
        MyDB myDB;
        public frmBanSach(string maNV, string sqlcon)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.sqlcon = sqlcon;
            myDB = new MyDB(sqlcon);
        }
       

        private void frmBanSach_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadSach();

        }
        private void LoadKhachHang()
        {
            string sql = "Select * from list_KhachHang";
            try
            {
                myDB.openConection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, myDB.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cboKH.DataSource = dataTable;
                cboKH.DisplayMember = "tenKH";
                cboKH.ValueMember = "maKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { myDB.closeConection(); }
        }

        private void LoadSach()
        {
            string sql = "Select * from list_Sach";
            try
            {
                myDB.openConection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, myDB.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cboSach.DataSource = dataTable;
                cboSach.DisplayMember = "tenSach";
                cboSach.ValueMember = "maSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { myDB.closeConection(); }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            maKH = cboKH.SelectedValue.ToString();
            
            try
            {
                if (cosan == false)
                {
                    myDB.openConection();
                    SqlCommand cmd = new SqlCommand("proc_themHoaDonVoiMaKH", myDB.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date) { Value = DateTime.Now });
                    cmd.Parameters.Add(new SqlParameter("@maKH", SqlDbType.NVarChar, 10) { Value = maKH });
                    cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10) { Value = maNV });

                    SqlParameter soHDParam = new SqlParameter("@soHD", SqlDbType.NVarChar, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(soHDParam);


                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm Hóa đơn thành công");
                    maHD = soHDParam.Value.ToString();
                }
                else
                {
                    string tenKH = txtTenKH.Text;
                    string SDT = txtSDT.Text;
                    myDB.openConection();
                    SqlCommand cmd = new SqlCommand("proc_themHoaDonVoiTenKH", myDB.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tenKH", SqlDbType.NVarChar, 250) { Value = tenKH });
                    cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.NVarChar, 250) { Value = SDT });
                    cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10) { Value = maNV });
                    cmd.Parameters.Add(new SqlParameter("@ngayLap", SqlDbType.Date) { Value = DateTime.Now });
                    

                    SqlParameter soHDParam = new SqlParameter("@soHD", SqlDbType.NVarChar, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(soHDParam);


                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm Hóa đơn thành công");
                    maHD = soHDParam.Value.ToString();
                }
                
                label1.Text = "Hóa đơn" + maHD;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { myDB.closeConection(); }
        }

        private void LoadChiTiet()
        {
            try
            {
                if(myDB.getConnection.State == ConnectionState.Closed)
                    myDB.openConection();

                SqlCommand cmd = new SqlCommand("proc_getChiTietHoaDon", myDB.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@soHD", maHD);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lblTongTien.Text = dataTable.Rows[0]["tongThanhTien"].ToString();
                dataTable.Columns.Remove("tongThanhTien");
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { myDB.closeConection(); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSach = cboSach.SelectedValue.ToString();
            int soLuong = Convert.ToInt32(numSoLuongNhap.Value);
            try
            {
                myDB.openConection();
                SqlCommand cmd = new SqlCommand("proc_themChiTietHoaDon", myDB.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maSach", maSach);
                cmd.Parameters.AddWithValue("@soHD", maHD);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm Thành công");

                LoadChiTiet();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { myDB.closeConection(); }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int parsedInt = int.Parse(lblTongTien.Text.Split('.')[0]);

            Form thanhtoan = new frmThanhToan(parsedInt, maHD,sqlcon);
            thanhtoan.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cosan = checkBox1.Checked;
            if (cosan == true)
            {
                panelKH.Visible = true;
                btnGoiY.Visible = false;
            }
            else if(cosan == false)
            {
                panelKH.Visible = false;
                btnGoiY.Visible = true;
            }
        }

        private void btnGoiY_Click(object sender, EventArgs e)
        {
            maKH = cboKH.SelectedValue.ToString();
            Form frmGoiY = new frmGoiY(sqlcon, maKH);
            frmGoiY.ShowDialog();
        }
    }
}
