namespace QuanLyMuaBanSach
{
    partial class frmQuanLyNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnVoHieuNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datipikrNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdobtnKhac = new System.Windows.Forms.RadioButton();
            this.rdobtnNu = new System.Windows.Forms.RadioButton();
            this.rdobtnNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxDiaChi = new System.Windows.Forms.TextBox();
            this.txtbxUsernameMoi = new System.Windows.Forms.TextBox();
            this.txtbxSDT = new System.Windows.Forms.TextBox();
            this.txtbxTenNV = new System.Windows.Forms.TextBox();
            this.txtbxMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhanNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLNhanVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanVienDataSet = new QuanLyMuaBanSach.QLNhanVienDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemNV);
            this.panel1.Controls.Add(this.btnSuaNV);
            this.panel1.Controls.Add(this.btnVoHieuNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.datipikrNgaySinh);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtbxDiaChi);
            this.panel1.Controls.Add(this.txtbxUsernameMoi);
            this.panel1.Controls.Add(this.txtbxSDT);
            this.panel1.Controls.Add(this.txtbxTenNV);
            this.panel1.Controls.Add(this.txtbxMaNV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 608);
            this.panel1.TabIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.AutoSize = true;
            this.btnThemNV.Location = new System.Drawing.Point(275, 556);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(80, 36);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.AutoSize = true;
            this.btnSuaNV.Location = new System.Drawing.Point(155, 556);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(80, 36);
            this.btnSuaNV.TabIndex = 5;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnVoHieuNV
            // 
            this.btnVoHieuNV.AutoSize = true;
            this.btnVoHieuNV.Location = new System.Drawing.Point(24, 556);
            this.btnVoHieuNV.Name = "btnVoHieuNV";
            this.btnVoHieuNV.Size = new System.Drawing.Size(81, 36);
            this.btnVoHieuNV.TabIndex = 5;
            this.btnVoHieuNV.Text = "Vô hiệu";
            this.btnVoHieuNV.UseVisualStyleBackColor = true;
            this.btnVoHieuNV.Click += new System.EventHandler(this.btnVoHieuNV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày sinh";
            // 
            // datipikrNgaySinh
            // 
            this.datipikrNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datipikrNgaySinh.Location = new System.Drawing.Point(155, 256);
            this.datipikrNgaySinh.Name = "datipikrNgaySinh";
            this.datipikrNgaySinh.Size = new System.Drawing.Size(200, 24);
            this.datipikrNgaySinh.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdobtnKhac);
            this.panel3.Controls.Add(this.rdobtnNu);
            this.panel3.Controls.Add(this.rdobtnNam);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(23, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 98);
            this.panel3.TabIndex = 2;
            // 
            // rdobtnKhac
            // 
            this.rdobtnKhac.AutoSize = true;
            this.rdobtnKhac.Location = new System.Drawing.Point(226, 49);
            this.rdobtnKhac.Name = "rdobtnKhac";
            this.rdobtnKhac.Size = new System.Drawing.Size(60, 22);
            this.rdobtnKhac.TabIndex = 2;
            this.rdobtnKhac.TabStop = true;
            this.rdobtnKhac.Text = "Khác";
            this.rdobtnKhac.UseVisualStyleBackColor = true;
            // 
            // rdobtnNu
            // 
            this.rdobtnNu.AutoSize = true;
            this.rdobtnNu.Location = new System.Drawing.Point(132, 49);
            this.rdobtnNu.Name = "rdobtnNu";
            this.rdobtnNu.Size = new System.Drawing.Size(45, 22);
            this.rdobtnNu.TabIndex = 2;
            this.rdobtnNu.TabStop = true;
            this.rdobtnNu.Text = "Nữ";
            this.rdobtnNu.UseVisualStyleBackColor = true;
            // 
            // rdobtnNam
            // 
            this.rdobtnNam.AutoSize = true;
            this.rdobtnNam.Location = new System.Drawing.Point(13, 49);
            this.rdobtnNam.Name = "rdobtnNam";
            this.rdobtnNam.Size = new System.Drawing.Size(58, 22);
            this.rdobtnNam.TabIndex = 2;
            this.rdobtnNam.TabStop = true;
            this.rdobtnNam.Text = "Nam";
            this.rdobtnNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính:";
            // 
            // txtbxDiaChi
            // 
            this.txtbxDiaChi.Location = new System.Drawing.Point(155, 378);
            this.txtbxDiaChi.Multiline = true;
            this.txtbxDiaChi.Name = "txtbxDiaChi";
            this.txtbxDiaChi.Size = new System.Drawing.Size(208, 88);
            this.txtbxDiaChi.TabIndex = 1;
            // 
            // txtbxUsernameMoi
            // 
            this.txtbxUsernameMoi.Location = new System.Drawing.Point(156, 493);
            this.txtbxUsernameMoi.Name = "txtbxUsernameMoi";
            this.txtbxUsernameMoi.Size = new System.Drawing.Size(208, 24);
            this.txtbxUsernameMoi.TabIndex = 1;
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Location = new System.Drawing.Point(155, 319);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.Size = new System.Drawing.Size(208, 24);
            this.txtbxSDT.TabIndex = 1;
            // 
            // txtbxTenNV
            // 
            this.txtbxTenNV.Location = new System.Drawing.Point(155, 60);
            this.txtbxTenNV.Name = "txtbxTenNV";
            this.txtbxTenNV.Size = new System.Drawing.Size(208, 24);
            this.txtbxTenNV.TabIndex = 1;
            // 
            // txtbxMaNV
            // 
            this.txtbxMaNV.Enabled = false;
            this.txtbxMaNV.Location = new System.Drawing.Point(155, 11);
            this.txtbxMaNV.Name = "txtbxMaNV";
            this.txtbxMaNV.Size = new System.Drawing.Size(208, 24);
            this.txtbxMaNV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên:";
            // 
            // btnXacNhanNV
            // 
            this.btnXacNhanNV.AutoSize = true;
            this.btnXacNhanNV.Location = new System.Drawing.Point(992, 49);
            this.btnXacNhanNV.Name = "btnXacNhanNV";
            this.btnXacNhanNV.Size = new System.Drawing.Size(106, 32);
            this.btnXacNhanNV.TabIndex = 5;
            this.btnXacNhanNV.Text = "Xác nhận";
            this.btnXacNhanNV.UseVisualStyleBackColor = true;
            this.btnXacNhanNV.Click += new System.EventHandler(this.btnXacNhanNV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataNV);
            this.panel2.Location = new System.Drawing.Point(420, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 539);
            this.panel2.TabIndex = 1;
            // 
            // dataNV
            // 
            this.dataNV.AllowUserToAddRows = false;
            this.dataNV.AllowUserToDeleteRows = false;
            this.dataNV.AutoGenerateColumns = false;
            this.dataNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.gioiTinh,
            this.ngaySinh,
            this.SDT,
            this.diaChi});
            this.dataNV.DataSource = this.qLNhanVienDataSetBindingSource;
            this.dataNV.Location = new System.Drawing.Point(3, 5);
            this.dataNV.Name = "dataNV";
            this.dataNV.ReadOnly = true;
            this.dataNV.RowHeadersWidth = 51;
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.Size = new System.Drawing.Size(675, 525);
            this.dataNV.TabIndex = 0;
            this.dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellClick);
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // tenNV
            // 
            this.tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên NV";
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // qLNhanVienDataSetBindingSource
            // 
            this.qLNhanVienDataSetBindingSource.DataSource = this.qLNhanVienDataSet;
            this.qLNhanVienDataSetBindingSource.Position = 0;
            // 
            // qLNhanVienDataSet
            // 
            this.qLNhanVienDataSet.DataSetName = "QLNhanVienDataSet";
            this.qLNhanVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách nhân viên";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(484, 55);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(69, 18);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(559, 52);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(427, 24);
            this.txtBoxTimKiem.TabIndex = 7;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 669);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnXacNhanNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "frmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datipikrNgaySinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdobtnKhac;
        private System.Windows.Forms.RadioButton rdobtnNu;
        private System.Windows.Forms.RadioButton rdobtnNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxSDT;
        private System.Windows.Forms.TextBox txtbxTenNV;
        private System.Windows.Forms.TextBox txtbxMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnVoHieuNV;
        private System.Windows.Forms.Button btnXacNhanNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtbxUsernameMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource qLNhanVienDataSetBindingSource;
        private QLNhanVienDataSet qLNhanVienDataSet;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
    }
}