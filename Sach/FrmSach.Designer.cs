namespace QuanLyMuaBanSach
{
    partial class FrmSach
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
            this.dataSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSachDataSet = new QuanLyMuaBanSach.QLSachDataSet();
            this.list_SachTableAdapter = new QuanLyMuaBanSach.QLSachDataSetTableAdapters.list_SachTableAdapter();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtboxTenSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownTuoi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.txtboxMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.listBoxTacGia = new System.Windows.Forms.ListBox();
            this.txtboxMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnQLNXB = new System.Windows.Forms.Button();
            this.btnQLTacGia = new System.Windows.Forms.Button();
            this.btnQLTheLoai = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.lbl_ThongTinSach = new System.Windows.Forms.Label();
            this.lbl_timKiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSach
            // 
            this.dataSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.soLuongTon,
            this.doTuoi,
            this.tenTL,
            this.moTa,
            this.tenNXB});
            this.dataSach.Location = new System.Drawing.Point(11, 54);
            this.dataSach.Name = "dataSach";
            this.dataSach.RowHeadersWidth = 51;
            this.dataSach.RowTemplate.Height = 24;
            this.dataSach.Size = new System.Drawing.Size(1061, 273);
            this.dataSach.TabIndex = 0;
            this.dataSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellClick);
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.Name = "maSach";
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.Name = "tenSach";
            // 
            // soLuongTon
            // 
            this.soLuongTon.DataPropertyName = "soLuongTon";
            this.soLuongTon.HeaderText = "Số Lượng Tồn";
            this.soLuongTon.Name = "soLuongTon";
            // 
            // doTuoi
            // 
            this.doTuoi.DataPropertyName = "doTuoi";
            this.doTuoi.HeaderText = "Độ Tuổi";
            this.doTuoi.Name = "doTuoi";
            // 
            // tenTL
            // 
            this.tenTL.DataPropertyName = "tenTL";
            this.tenTL.HeaderText = "Tên Thể Loại";
            this.tenTL.Name = "tenTL";
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô Tả";
            this.moTa.Name = "moTa";
            // 
            // tenNXB
            // 
            this.tenNXB.DataPropertyName = "tenNXB";
            this.tenNXB.HeaderText = "Tên NXB";
            this.tenNXB.Name = "tenNXB";
            // 
            // listSachBindingSource
            // 
            this.listSachBindingSource.DataMember = "list_Sach";
            this.listSachBindingSource.DataSource = this.qLSachDataSet;
            // 
            // qLSachDataSet
            // 
            this.qLSachDataSet.DataSetName = "QLSachDataSet";
            this.qLSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_SachTableAdapter
            // 
            this.list_SachTableAdapter.ClearBeforeFill = true;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(590, 31);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(64, 20);
            this.lblTacGia.TabIndex = 5;
            this.lblTacGia.Text = "Tác Giả";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(3, 46);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(77, 20);
            this.lblTenSach.TabIndex = 7;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // txtboxTenSach
            // 
            this.txtboxTenSach.Location = new System.Drawing.Point(141, 46);
            this.txtboxTenSach.Name = "txtboxTenSach";
            this.txtboxTenSach.Size = new System.Drawing.Size(369, 24);
            this.txtboxTenSach.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownTuoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXoaTacGia);
            this.panel1.Controls.Add(this.btnThemTacGia);
            this.panel1.Controls.Add(this.txtboxMaSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxTacGia);
            this.panel1.Controls.Add(this.listBoxTacGia);
            this.panel1.Controls.Add(this.txtboxMoTa);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.comboBoxNXB);
            this.panel1.Controls.Add(this.comboBoxTheLoai);
            this.panel1.Controls.Add(this.lblNXB);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.btnSuaSach);
            this.panel1.Controls.Add(this.btnQLNXB);
            this.panel1.Controls.Add(this.btnQLTacGia);
            this.panel1.Controls.Add(this.btnQLTheLoai);
            this.panel1.Controls.Add(this.btnThemSach);
            this.panel1.Controls.Add(this.lblTacGia);
            this.panel1.Controls.Add(this.txtboxTenSach);
            this.panel1.Controls.Add(this.lblTenSach);
            this.panel1.Location = new System.Drawing.Point(11, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 459);
            this.panel1.TabIndex = 10;
            // 
            // numericUpDownTuoi
            // 
            this.numericUpDownTuoi.Location = new System.Drawing.Point(141, 296);
            this.numericUpDownTuoi.Name = "numericUpDownTuoi";
            this.numericUpDownTuoi.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownTuoi.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Độ tuổi";
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.AutoSize = true;
            this.btnXoaTacGia.Location = new System.Drawing.Point(986, 46);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(75, 32);
            this.btnXoaTacGia.TabIndex = 24;
            this.btnXoaTacGia.Text = "Xoá";
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.AutoSize = true;
            this.btnThemTacGia.Location = new System.Drawing.Point(906, 46);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(75, 32);
            this.btnThemTacGia.TabIndex = 23;
            this.btnThemTacGia.Text = "Thêm";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // txtboxMaSach
            // 
            this.txtboxMaSach.Enabled = false;
            this.txtboxMaSach.Location = new System.Drawing.Point(141, 5);
            this.txtboxMaSach.Name = "txtboxMaSach";
            this.txtboxMaSach.Size = new System.Drawing.Size(369, 24);
            this.txtboxMaSach.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Sách";
            // 
            // comboBoxTacGia
            // 
            this.comboBoxTacGia.FormattingEnabled = true;
            this.comboBoxTacGia.Location = new System.Drawing.Point(906, 8);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(155, 25);
            this.comboBoxTacGia.TabIndex = 20;
            // 
            // listBoxTacGia
            // 
            this.listBoxTacGia.FormattingEnabled = true;
            this.listBoxTacGia.ItemHeight = 17;
            this.listBoxTacGia.Location = new System.Drawing.Point(692, 8);
            this.listBoxTacGia.Name = "listBoxTacGia";
            this.listBoxTacGia.Size = new System.Drawing.Size(208, 123);
            this.listBoxTacGia.TabIndex = 19;
            // 
            // txtboxMoTa
            // 
            this.txtboxMoTa.Location = new System.Drawing.Point(141, 89);
            this.txtboxMoTa.Multiline = true;
            this.txtboxMoTa.Name = "txtboxMoTa";
            this.txtboxMoTa.Size = new System.Drawing.Size(369, 98);
            this.txtboxMoTa.TabIndex = 17;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(3, 116);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(53, 20);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(141, 251);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(378, 25);
            this.comboBoxNXB.TabIndex = 16;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(141, 207);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(378, 25);
            this.comboBoxTheLoai.TabIndex = 15;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.Location = new System.Drawing.Point(3, 251);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(42, 20);
            this.lblNXB.TabIndex = 13;
            this.lblNXB.Text = "NXB";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(3, 207);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(70, 20);
            this.lblTheLoai.TabIndex = 14;
            this.lblTheLoai.Text = "Thể Loại";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(1228, 269);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(138, 41);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSach.Location = new System.Drawing.Point(314, 330);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(109, 41);
            this.btnSuaSach.TabIndex = 11;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnQLNXB
            // 
            this.btnQLNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNXB.Location = new System.Drawing.Point(553, 247);
            this.btnQLNXB.Name = "btnQLNXB";
            this.btnQLNXB.Size = new System.Drawing.Size(192, 41);
            this.btnQLNXB.TabIndex = 10;
            this.btnQLNXB.Text = "Quản lý NXB";
            this.btnQLNXB.UseVisualStyleBackColor = true;
            this.btnQLNXB.Click += new System.EventHandler(this.btnQLNXB_Click);
            // 
            // btnQLTacGia
            // 
            this.btnQLTacGia.AccessibleDescription = "";
            this.btnQLTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTacGia.Location = new System.Drawing.Point(692, 146);
            this.btnQLTacGia.Name = "btnQLTacGia";
            this.btnQLTacGia.Size = new System.Drawing.Size(208, 41);
            this.btnQLTacGia.TabIndex = 10;
            this.btnQLTacGia.Text = "Quản lý tác giả";
            this.btnQLTacGia.UseVisualStyleBackColor = true;
            this.btnQLTacGia.Click += new System.EventHandler(this.btnQLTacGia_Click);
            // 
            // btnQLTheLoai
            // 
            this.btnQLTheLoai.AccessibleDescription = "";
            this.btnQLTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTheLoai.Location = new System.Drawing.Point(553, 193);
            this.btnQLTheLoai.Name = "btnQLTheLoai";
            this.btnQLTheLoai.Size = new System.Drawing.Size(192, 41);
            this.btnQLTheLoai.TabIndex = 10;
            this.btnQLTheLoai.Text = "Quản lý thể loại";
            this.btnQLTheLoai.UseVisualStyleBackColor = true;
            this.btnQLTheLoai.Click += new System.EventHandler(this.btnQLTheLoai_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Location = new System.Drawing.Point(152, 330);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(109, 41);
            this.btnThemSach.TabIndex = 10;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // lbl_ThongTinSach
            // 
            this.lbl_ThongTinSach.AutoSize = true;
            this.lbl_ThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinSach.Location = new System.Drawing.Point(12, 26);
            this.lbl_ThongTinSach.Name = "lbl_ThongTinSach";
            this.lbl_ThongTinSach.Size = new System.Drawing.Size(164, 25);
            this.lbl_ThongTinSach.TabIndex = 11;
            this.lbl_ThongTinSach.Text = "Thông Tin Sách";
            // 
            // lbl_timKiem
            // 
            this.lbl_timKiem.AutoSize = true;
            this.lbl_timKiem.Location = new System.Drawing.Point(487, 27);
            this.lbl_timKiem.Name = "lbl_timKiem";
            this.lbl_timKiem.Size = new System.Drawing.Size(71, 18);
            this.lbl_timKiem.TabIndex = 12;
            this.lbl_timKiem.Text = "Tìm Kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(997, 22);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 26);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(564, 24);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(428, 24);
            this.txtBoxTimKiem.TabIndex = 14;
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 823);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.lbl_timKiem);
            this.Controls.Add(this.lbl_ThongTinSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSach";
            this.Text = "FrmSach";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSach;
        private QLSachDataSet qLSachDataSet;
        private System.Windows.Forms.BindingSource listSachBindingSource;
        private QLSachDataSetTableAdapters.list_SachTableAdapter list_SachTableAdapter;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtboxTenSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnQLNXB;
        private System.Windows.Forms.Button btnQLTheLoai;
        private System.Windows.Forms.TextBox txtboxMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnQLTacGia;
        private System.Windows.Forms.ComboBox comboBoxTacGia;
        private System.Windows.Forms.ListBox listBoxTacGia;
        private System.Windows.Forms.TextBox txtboxMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.NumericUpDown numericUpDownTuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ThongTinSach;
        private System.Windows.Forms.Label lbl_timKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn doTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXB;
    }
}