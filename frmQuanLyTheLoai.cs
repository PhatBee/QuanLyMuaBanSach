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
    public partial class frmQuanLyTheLoai : Form
    {
        MyDB mydb = new MyDB();
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlcon = null;
        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }
        private void frmQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            dataTheLoai.AutoGenerateColumns = true;
            dataTheLoai.DataSource = layDanhSachTheLoai();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTL = txtBoxTenTheLoai.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("proc_themTheLoai", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tenTL", tenTL);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã thêm thể loại mới thành công!", "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thể loại thất bại. Mã lỗi: " + ex.Message, "Thêm thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTheLoai_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maTL = txtBoxMaTheLoai.Text;
                string tenTL = txtBoxTenTheLoai.Text;


                mydb.openConection();

                sqlCommand = new SqlCommand("pro_suaTheLoai", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maTL", maTL);
                sqlCommand.Parameters.AddWithValue("@tenTL", tenTL);


                sqlCommand.ExecuteNonQuery();

                mydb.closeConection();

                MessageBox.Show("Đã sửa thông tin thể loại thành công!", "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thể loại thất bại. Mã lỗi: " + ex.Message, "Sửa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTheLoai_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxMaTheLoai.Text = dataTheLoai.CurrentRow.Cells[0].Value.ToString();
                string maTL = txtBoxMaTheLoai.Text;

                mydb.openConection();

                sqlCommand = new SqlCommand("proc_xoaTheLoai", mydb.getConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@maTL", maTL);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thể loại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thể loại cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mydb.closeConection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá thể loại thất bại, do thể loại đang được dùng trên hệ thống. Mã lỗi: " + ex.Message, "Xoá thể loại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmQuanLyTheLoai_Load(sender, e);
        }

        private void dataTheLoai_DoubleClick(object sender, EventArgs e)
        {
            // MaTL, tenTL
            try
            {
                txtBoxMaTheLoai.Text = dataTheLoai.CurrentRow.Cells[0].Value.ToString();
                txtBoxTenTheLoai.Text = dataTheLoai.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
