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
    public partial class frmKPINhanVien : Form
    {
        MyDB mydb = new MyDB();
        public frmKPINhanVien()
        {
            InitializeComponent();
        }

        private void frmKPINhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int thang = Convert.ToInt32(cbxThang.Text);
            int nam = Convert.ToInt32(numNam.Text);
            thongKeDoanhThuTheoThang(thang, nam);
            txtDoanhThu.Text = tongDoanhThuTheoThang(thang, nam).ToString();
            txtbxKPI.Text = KPIThang(thang, nam).ToString();
            thongKeDoanhThuNhanVien(thang, nam);

        }

        private void thongKeDoanhThuNhanVien(int thang, int nam)
        {
            try
            {

                mydb.openConection();
                SqlCommand cmd = new SqlCommand("sp_DoanhThuTheoNhanVienTheoThang", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@month", thang);
                cmd.Parameters.AddWithValue("@year", nam);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal KPIThang(int thang, int nam)
        {
            decimal KPI = 0;
            try
            {
                mydb.openConection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_KPI_TheoThang(@month, @year)", mydb.getConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@month", thang);
                cmd.Parameters.AddWithValue("@year", nam);

                KPI = Convert.ToDecimal(cmd.ExecuteScalar());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return KPI;
        }

        private decimal tongDoanhThuTheoThang(int thang, int nam)
        {
            decimal tongDoanhThu = 0;
            try
            {
                mydb.openConection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_tongDoanhThuTheoThang(@month, @year)", mydb.getConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@month", thang);
                cmd.Parameters.AddWithValue("@year", nam);

                tongDoanhThu = Convert.ToDecimal(cmd.ExecuteScalar());


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tongDoanhThu;

        }
        private void thongKeDoanhThuTheoThang(int thang, int nam)
        {
            try
            {

                mydb.openConection();
                SqlCommand cmd = new SqlCommand("proc_DoanhThuTheoThang", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@month", thang);
                cmd.Parameters.AddWithValue("@year", nam);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
