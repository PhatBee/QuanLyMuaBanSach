namespace QuanLyMuaBanSach
{
    partial class frmQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThongTinKhachHang = new System.Windows.Forms.Label();
            this.dataKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxMaKhanhHang = new System.Windows.Forms.TextBox();
            this.txtBoxTenKhachHang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinKhachHang
            // 
            this.lblThongTinKhachHang.AutoSize = true;
            this.lblThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKhachHang.Location = new System.Drawing.Point(12, 9);
            this.lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            this.lblThongTinKhachHang.Size = new System.Drawing.Size(292, 31);
            this.lblThongTinKhachHang.TabIndex = 0;
            this.lblThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHang.Location = new System.Drawing.Point(10, 60);
            this.dataKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.RowHeadersWidth = 62;
            this.dataKhachHang.RowTemplate.Height = 28;
            this.dataKhachHang.Size = new System.Drawing.Size(892, 314);
            this.dataKhachHang.TabIndex = 1;
            this.dataKhachHang.DoubleClick += new System.EventHandler(this.dataKhachHang_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lblMaKhachHang);
            this.panel1.Controls.Add(this.lblTenKhachHang);
            this.panel1.Controls.Add(this.txtBoxSDT);
            this.panel1.Controls.Add(this.txtBoxMaKhanhHang);
            this.panel1.Controls.Add(this.txtBoxTenKhachHang);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(11, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 186);
            this.panel1.TabIndex = 2;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(219, 93);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(121, 24);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(195, 18);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(140, 24);
            this.lblMaKhachHang.TabIndex = 17;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(195, 56);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(148, 24);
            this.lblTenKhachHang.TabIndex = 17;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(359, 93);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(265, 22);
            this.txtBoxSDT.TabIndex = 14;
            // 
            // txtBoxMaKhanhHang
            // 
            this.txtBoxMaKhanhHang.Enabled = false;
            this.txtBoxMaKhanhHang.Location = new System.Drawing.Point(359, 19);
            this.txtBoxMaKhanhHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMaKhanhHang.Name = "txtBoxMaKhanhHang";
            this.txtBoxMaKhanhHang.Size = new System.Drawing.Size(265, 22);
            this.txtBoxMaKhanhHang.TabIndex = 15;
            // 
            // txtBoxTenKhachHang
            // 
            this.txtBoxTenKhachHang.Location = new System.Drawing.Point(359, 58);
            this.txtBoxTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTenKhachHang.Name = "txtBoxTenKhachHang";
            this.txtBoxTenKhachHang.Size = new System.Drawing.Size(265, 22);
            this.txtBoxTenKhachHang.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(247, 134);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(385, 134);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 34);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(537, 134);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(466, 34);
            this.txtBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(436, 22);
            this.txtBoxTimKiem.TabIndex = 9;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(360, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lblTimKiem.TabIndex = 8;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 573);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataKhachHang);
            this.Controls.Add(this.lblThongTinKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinKhachHang;
        private System.Windows.Forms.DataGridView dataKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.TextBox txtBoxTenKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtBoxMaKhanhHang;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}