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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxTenKhachHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinKhachHang
            // 
            this.lblThongTinKhachHang.AutoSize = true;
            this.lblThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKhachHang.Location = new System.Drawing.Point(483, 35);
            this.lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            this.lblThongTinKhachHang.Size = new System.Drawing.Size(349, 37);
            this.lblThongTinKhachHang.TabIndex = 0;
            this.lblThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHang.Location = new System.Drawing.Point(11, 75);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.RowHeadersWidth = 62;
            this.dataKhachHang.RowTemplate.Height = 28;
            this.dataKhachHang.Size = new System.Drawing.Size(1291, 392);
            this.dataKhachHang.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lblTenKhachHang);
            this.panel1.Controls.Add(this.txtBoxSDT);
            this.panel1.Controls.Add(this.txtBoxTenKhachHang);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(12, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 232);
            this.panel1.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(425, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(581, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 42);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(752, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 42);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(410, 92);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(139, 26);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(383, 37);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(166, 26);
            this.lblTenKhachHang.TabIndex = 17;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(567, 92);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(298, 26);
            this.txtBoxSDT.TabIndex = 14;
            // 
            // txtBoxTenKhachHang
            // 
            this.txtBoxTenKhachHang.Location = new System.Drawing.Point(567, 39);
            this.txtBoxTenKhachHang.Name = "txtBoxTenKhachHang";
            this.txtBoxTenKhachHang.Size = new System.Drawing.Size(298, 26);
            this.txtBoxTenKhachHang.TabIndex = 15;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataKhachHang);
            this.Controls.Add(this.lblThongTinKhachHang);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
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
    }
}