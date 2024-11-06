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
    public partial class FrmSach : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;
        int tonsua = 0;
        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            napTenNXB();
            napTenTheLoai();
            napTenTacGia();
            dataSach.DataSource = layDanhSachSach();
        }

        private void btnQLTheLoai_Click(object sender, EventArgs e)
        {
            frmQuanLyTheLoai qlTheLoai = new frmQuanLyTheLoai();
            qlTheLoai.Show();
        }

        private void btnQLNXB_Click(object sender, EventArgs e)
        {
            frmQuanLyNXB qlNXB = new frmQuanLyNXB();
            qlNXB.Show();
        }

        private void btnQLTacGia_Click(object sender, EventArgs e)
        {
            frmQuanLyTacGia quanLyTacGia = new frmQuanLyTacGia();
            quanLyTacGia.Show();
        }

        public DataTable layDanhSachNXB()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachNhaXuatBan", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        public DataTable layDanhSachSach()
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachSach", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        public DataTable layDanhSachTheLoai() 
        {
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_LayDanhSachTheLoai", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
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

        public void napTenNXB()
        {
            DataTable dt = new DataTable();
            dt = layDanhSachNXB();
            comboBoxNXB.DataSource = dt;
            comboBoxNXB.DisplayMember = "tenNXB";
            comboBoxNXB.ValueMember = "maNXB";
        }

        public void napTenTheLoai()
        {
            DataTable dt = new DataTable();
            dt = layDanhSachTheLoai();
            comboBoxTheLoai.DataSource = dt;
            comboBoxTheLoai.DisplayMember = "tenTL";
            comboBoxTheLoai.ValueMember = "maTL";
        }

        public void napTenTacGia()
        {
            DataTable dt = new DataTable();
            dt = layDanhSachTacGia();
            comboBoxTacGia.DataSource = dt;
            comboBoxTacGia.DisplayMember = "tenTG";
            comboBoxTacGia.ValueMember = "maTG";
        }

        private void dataSach_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtboxMaSach.Text = dataSach.CurrentRow.Cells[0].Value.ToString();
                txtboxTenSach.Text = dataSach.CurrentRow.Cells[1].Value.ToString();
                comboBoxTheLoai.Text = dataSach.CurrentRow.Cells[4].Value.ToString() ;
                txtboxMoTa.Text = dataSach.CurrentRow.Cells[5].Value.ToString();
                comboBoxNXB.Text = dataSach.CurrentRow.Cells[6].Value.ToString();
                chiTietSangTacSach();

                tonsua = Convert.ToInt32(dataSach.CurrentRow.Cells[2].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable layDanhSachChiTietSangTacSach()
        {
            string masach = txtboxMaSach.Text;
            DataTable dt = new DataTable();
            mydb.openConection();
            sqlCommand = new SqlCommand("proc_ChiTietSangTacSach", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@maSach", masach);

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dt);
            }
            mydb.closeConection();
            return dt;
        }

        public void chiTietSangTacSach()
        {
            DataTable dt = new DataTable();
            dt = layDanhSachChiTietSangTacSach();
            listBoxTacGia.DataSource = dt;
            listBoxTacGia.DisplayMember = "tenTG";
            listBoxTacGia.ValueMember = "maTG";
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txtboxMaSach.Text;
                string matg = comboBoxTacGia.SelectedValue.ToString();

                sqlCommand = new SqlCommand("proc_ThemTacGiaChoSach", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("MaSach", masach);
                sqlCommand.Parameters.AddWithValue("MaTG", matg);

                mydb.openConection();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Thêm tác giả vào sách thành công", "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) 
            {
                MessageBox.Show("Lỗi khi thêm tác giả, vui lòng thêm thông tin sách trước khi bổ sung tác giả, mã lỗi: " +  ex.Message, "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            chiTietSangTacSach();

        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txtboxMaSach.Text;
                string matg = comboBoxTacGia.SelectedValue.ToString();

                sqlCommand = new SqlCommand("proc_XoaTacGiaKhoiSach", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("MaSach", masach);
                sqlCommand.Parameters.AddWithValue("MaTG", matg);

                mydb.openConection();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Xoá tác giả khỏi sách thành công", "Xoá tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá tác giả, mã lỗi: " + ex.Message, "Xoá tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            chiTietSangTacSach();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                string tensach = txtboxTenSach.Text;
                string mota = txtboxMoTa.Text;
                string theloai = comboBoxTheLoai.SelectedValue.ToString();
                int dotuoi = Convert.ToInt32(numericUpDownTuoi.Value);
                string nxb = comboBoxNXB.SelectedValue.ToString() ;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_themSach", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tenSach", tensach);
                sqlCommand.Parameters.AddWithValue("@slTon", 0);
                sqlCommand.Parameters.AddWithValue("@doTuoi", dotuoi);
                sqlCommand.Parameters.AddWithValue("@maTL", theloai);
                sqlCommand.Parameters.AddWithValue("@moTa", mota);
                sqlCommand.Parameters.AddWithValue("@maNXB", nxb);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mydb.closeConection();
            FrmSach_Load(sender, e);
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txtboxMaSach.Text;
                string tensach = txtboxTenSach.Text;
                string mota = txtboxMoTa.Text;
                string theloai = comboBoxTheLoai.SelectedValue.ToString();
                int dotuoi = Convert.ToInt32(numericUpDownTuoi.Value);
                string nxb = comboBoxNXB.SelectedValue.ToString();

                mydb.openConection();

                sqlCommand = new SqlCommand("pro_suaSach", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maSach", masach);
                sqlCommand.Parameters.AddWithValue("@tenSach", tensach);
                sqlCommand.Parameters.AddWithValue("@slTon", tonsua);
                sqlCommand.Parameters.AddWithValue("@doTuoi", dotuoi);
                sqlCommand.Parameters.AddWithValue("@maTL", theloai);
                sqlCommand.Parameters.AddWithValue("@moTa", mota);
                sqlCommand.Parameters.AddWithValue("@maNXB", nxb);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mydb.closeConection();
            FrmSach_Load(sender, e);
        }

        private DataTable timKiemSach(string text)
        {
            mydb.openConection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("proc_timKiemSachTheoTen", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenSach", text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            mydb.closeConection();
            return dt;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenSach = txtBoxTimKiem.Text;
            dataSach.DataSource = timKiemSach(tenSach);
        }
    }
}
