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
    public partial class frmQuanLyPhieuNhap : Form
    {
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPhieuNhapSet.list_PhieuNhap' table. You can move, or remove it, as needed.
            this.list_PhieuNhapTableAdapter.Fill(this.qLPhieuNhapSet.list_PhieuNhap);

        }
    }
}
