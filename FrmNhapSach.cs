using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyMuaBanSach
{
    public partial class frmNhapSach : Form
    {

        private string maNV;
        private string maNXB;
        MyDB mydb;
        private string sqlcon;
        private string maPN;
        private bool coSan;
        public frmNhapSach(string maNV,string sqlcon)
        {
            InitializeComponent();
            this.sqlcon = sqlcon;
            this.maNV = maNV;
            mydb = new MyDB(sqlcon);
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            int soLuong = Convert.ToInt32(numSoLuongNhap.Value);
            int gia = Convert.ToInt32(txtGiaNhap.Text);
            try
            {
                if (!coSan)
                {
                    string maSach = cboTenSach.SelectedValue.ToString();
                    mydb.openConection();
                    SqlCommand cmd = new SqlCommand("proc_themChiTietPhieuNhapVoiMaSach", mydb.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@soPN", maPN);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@donGia", gia);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm Thành công");
                }
                else
                {
                    string tenSach = txtTenSach.Text;
                    mydb.openConection();
                    SqlCommand cmd = new SqlCommand("proc_themChiTietPhieuNhapVoiTenSach", mydb.getConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNXB", maNXB);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);
                    cmd.Parameters.AddWithValue("@soPN", maPN);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@donGia", gia);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm Thành công");
                }
                
                
                LoadChiTiet();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }finally { mydb.closeConection(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            LoadNXB();
        }

        private void LoadSach(string maNXB) 
        {
            try
            {
                mydb.openConection();
                SqlCommand cmd = new SqlCommand("proc_laySachTheoNXB", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNXB", maNXB);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cboTenSach.DataSource = dataTable;
                cboTenSach.DisplayMember = "tenSach";
                cboTenSach.ValueMember = "maSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {mydb.closeConection(); }
        }
        private void LoadNXB() 
        {
            string sql = "Select * from v_LayDanhSachNhaXuatBan";
            try
            {
                mydb.openConection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, mydb.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cboNXB.DataSource = dataTable;
                cboNXB.DisplayMember = "tenNXB";
                cboNXB.ValueMember = "maNXB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mydb.closeConection(); }
        }

        private void LoadChiTiet()
        {
            try
            {
                mydb.openConection();
                SqlCommand cmd = new SqlCommand("proc_getChiTietPhieuNhap", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@soPN", maPN);
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
            finally { mydb.closeConection(); }
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            maNXB = cboNXB.SelectedValue.ToString();
            try
            {
                mydb.openConection();
                SqlCommand cmd = new SqlCommand("proc_themPhieuNhap", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ngayNhap", SqlDbType.Date) { Value = DateTime.Now });
                cmd.Parameters.Add(new SqlParameter("@maNXB", SqlDbType.NVarChar, 10) { Value = maNXB });
                cmd.Parameters.Add(new SqlParameter("@maNV", SqlDbType.NVarChar, 10) { Value = maNV });

                SqlParameter soPNParam = new SqlParameter("@soPN", SqlDbType.NVarChar, 10)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(soPNParam);


                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm Phiếu nhập thành công");
                maPN = soPNParam.Value.ToString();
                label1.Text = "Nhập sách: " + maPN;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mydb.closeConection(); }
        }

        private void cboNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNXB = cboNXB.SelectedValue.ToString();
            LoadSach(maNXB);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            coSan = checkBox1.Checked;
            txtTenSach.Visible = true;
            //MessageBox.Show(coSan.ToString());
        }
    }
}
