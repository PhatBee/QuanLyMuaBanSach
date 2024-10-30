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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        MyDB myDB = new MyDB();

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime dateA = tungay.Value;
            DateTime dateB = den.Value;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_ThongKeSachVaDoanhThuTong(@dateA, @dateB)", myDB.getConnection);
                cmd.Parameters.AddWithValue("@dateA", dateA);
                cmd.Parameters.AddWithValue("@dateB", dateB);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                txtDoanhThu.Text = dataTable.Rows[0]["DoanhThuTong"].ToString();
                dataTable.Columns.Remove("DoanhThuTong");

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myDB.closeConection();
            }
        }

    }
}
