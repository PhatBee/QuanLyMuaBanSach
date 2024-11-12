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
            this.maNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblThongTinNXB.Location = new System.Drawing.Point(8, 32);
            this.lblThongTinNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinNXB.Name = "lblThongTinNXB";
            this.lblThongTinNXB.Size = new System.Drawing.Size(159, 26);
            this.lblThongTinNXB.TabIndex = 0;
            this.lblThongTinNXB.Text = "Thông Tin NXB";
            // 
            // dataNXB
            // 
            this.dataNXB.AllowUserToAddRows = false;
            this.dataNXB.AllowUserToDeleteRows = false;
            this.dataNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNXB,
            this.tenNXB,
            this.diaChiNXB});
            this.dataNXB.Location = new System.Drawing.Point(8, 60);
            this.dataNXB.Margin = new System.Windows.Forms.Padding(2);
            this.dataNXB.Name = "dataNXB";
            this.dataNXB.ReadOnly = true;
            this.dataNXB.RowHeadersWidth = 62;
            this.dataNXB.RowTemplate.Height = 28;
            this.dataNXB.Size = new System.Drawing.Size(631, 229);
            this.dataNXB.TabIndex = 1;
            this.dataNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNXB_CellClick);
            // 
            // maNXB
            // 
            this.maNXB.DataPropertyName = "maNXB";
            this.maNXB.HeaderText = "Mã NXB";
            this.maNXB.Name = "maNXB";
            this.maNXB.ReadOnly = true;
            // 
            // tenNXB
            // 
            this.tenNXB.DataPropertyName = "tenNXB";
            this.tenNXB.HeaderText = "Tên NXB";
            this.tenNXB.Name = "tenNXB";
            this.tenNXB.ReadOnly = true;
            // 
            // diaChiNXB
            // 
            this.diaChiNXB.DataPropertyName = "diaChiNXB";
            this.diaChiNXB.HeaderText = "Địa Chỉ NXB";
            this.diaChiNXB.Name = "diaChiNXB";
            this.diaChiNXB.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(4, 109);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 28);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(109, 109);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(223, 109);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtBoxTenNXB
            // 
            this.txtBoxTenNXB.Location = new System.Drawing.Point(88, 33);
            this.txtBoxTenNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTenNXB.Name = "txtBoxTenNXB";
            this.txtBoxTenNXB.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTenNXB.TabIndex = 3;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNXB.Location = new System.Drawing.Point(1, 32);
            this.lblTenNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(72, 18);
            this.lblTenNXB.TabIndex = 4;
            this.lblTenNXB.Text = "Tên NXB ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(319, 27);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(88, 18);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ NXB";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(-3, 61);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(77, 18);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SDT NXB ";
            // 
            // txtBoxNXB
            // 
            this.txtBoxNXB.Location = new System.Drawing.Point(423, 27);
            this.txtBoxNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNXB.Multiline = true;
            this.txtBoxNXB.Name = "txtBoxNXB";
            this.txtBoxNXB.Size = new System.Drawing.Size(200, 111);
            this.txtBoxNXB.TabIndex = 3;
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(88, 61);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(200, 20);
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
            this.panel1.Location = new System.Drawing.Point(8, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 150);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NXB";
            // 
            // txtBoxMaNXB
            // 
            this.txtBoxMaNXB.Enabled = false;
            this.txtBoxMaNXB.Location = new System.Drawing.Point(88, 6);
            this.txtBoxMaNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMaNXB.Name = "txtBoxMaNXB";
            this.txtBoxMaNXB.Size = new System.Drawing.Size(200, 20);
            this.txtBoxMaNXB.TabIndex = 5;
            // 
            // frmQuanLyNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataNXB);
            this.Controls.Add(this.lblThongTinNXB);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn maNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNXB;
    }
}