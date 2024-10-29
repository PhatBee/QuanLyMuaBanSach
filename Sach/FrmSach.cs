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
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSachDataSet.list_Sach' table. You can move, or remove it, as needed.

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
    }
}
