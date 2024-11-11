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
    public partial class frmBanSach : Form
    {
        MyDB myDB = new MyDB();
        private string maNV;
        private string maHD;
        private bool cosan;
        public frmBanSach(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
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
            string maKH = cboKH.SelectedValue.ToString();
            try
            {
                if (!cosan)
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
                        MessageBox.Show("Thêm Phiếu nhập thành công");
                    maHD = soHDParam.Value.ToString();
                }
                else
                {
                    myDB.openConection();
                    SqlCommand cmd = new SqlCommand("proc_themHoaDon", myDB.getConnection);
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
                        MessageBox.Show("Thêm Phiếu nhập thành công");
                    maHD = soHDParam.Value.ToString();
                }
                
                label1.Text = "Nhập sách: " + maHD;

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

            Form thanhtoan = new frmThanhToan(parsedInt, maHD);
            thanhtoan.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panelKH.Visible = true;
            cosan = checkBox1.Checked;
        }
    }
}
