namespace QuanLyMuaBanSach
{
    partial class frmQuanLyNXB
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
            this.lblThongTinNXB = new System.Windows.Forms.Label();
            this.dataNXB = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtBoxTenNXB = new System.Windows.Forms.TextBox();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtBoxNXB = new System.Windows.Forms.TextBox();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMaNXB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataNXB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinNXB
            // 
            this.lblThongTinNXB.AutoSize = true;
            this.lblThongTinNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNXB.Location = new System.Drawing.Point(301, 6);
            this.lblThongTinNXB.Name = "lblThongTinNXB";
            this.lblThongTinNXB.Size = new System.Drawing.Size(199, 31);
            this.lblThongTinNXB.TabIndex = 0;
            this.lblThongTinNXB.Text = "Thông Tin NXB";
            // 
            // dataNXB
            // 
            this.dataNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNXB.Location = new System.Drawing.Point(11, 38);
            this.dataNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataNXB.Name = "dataNXB";
            this.dataNXB.RowHeadersWidth = 62;
            this.dataNXB.RowTemplate.Height = 28;
            this.dataNXB.Size = new System.Drawing.Size(841, 282);
            this.dataNXB.TabIndex = 1;
            this.dataNXB.DoubleClick += new System.EventHandler(this.dataNXB_DoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 134);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(145, 134);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(297, 134);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtBoxTenNXB
            // 
            this.txtBoxTenNXB.Location = new System.Drawing.Point(118, 41);
            this.txtBoxTenNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTenNXB.Name = "txtBoxTenNXB";
            this.txtBoxTenNXB.Size = new System.Drawing.Size(265, 22);
            this.txtBoxTenNXB.TabIndex = 3;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNXB.Location = new System.Drawing.Point(1, 40);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(94, 24);
            this.lblTenNXB.TabIndex = 4;
            this.lblTenNXB.Text = "Tên NXB ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(425, 33);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(112, 24);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ NXB";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(-4, 75);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(97, 24);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SDT NXB ";
            // 
            // txtBoxNXB
            // 
            this.txtBoxNXB.Location = new System.Drawing.Point(564, 33);
            this.txtBoxNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNXB.Multiline = true;
            this.txtBoxNXB.Name = "txtBoxNXB";
            this.txtBoxNXB.Size = new System.Drawing.Size(265, 136);
            this.txtBoxNXB.TabIndex = 3;
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(118, 75);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(265, 22);
            this.txtBoxSDT.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxMaNXB);
            this.panel1.Controls.Add(this.txtBoxNXB);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.lblTenNXB);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtBoxSDT);
            this.panel1.Controls.Add(this.txtBoxTenNXB);
            this.panel1.Location = new System.Drawing.Point(11, 326);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 184);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NXB";
            // 
            // txtBoxMaNXB
            // 
            this.txtBoxMaNXB.Location = new System.Drawing.Point(118, 8);
            this.txtBoxMaNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMaNXB.Name = "txtBoxMaNXB";
            this.txtBoxMaNXB.Size = new System.Drawing.Size(265, 22);
            this.txtBoxMaNXB.TabIndex = 5;
            // 
            // frmQuanLyNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataNXB);
            this.Controls.Add(this.lblThongTinNXB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyNXB";
            this.Text = "frmQuanLyNXB";
            this.Load += new System.EventHandler(this.frmQuanLyNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinNXB;
        private System.Windows.Forms.DataGridView dataNXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtBoxTenNXB;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtBoxNXB;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMaNXB;
    }
}