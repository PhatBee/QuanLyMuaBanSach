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
            this.listSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSachDataSet = new QuanLyMuaBanSach.QLSachDataSet();
            this.list_SachTableAdapter = new QuanLyMuaBanSach.QLSachDataSetTableAdapters.list_SachTableAdapter();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtboxTenSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTuoi = new System.Windows.Forms.NumericUpDown();
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
            this.dataSach.Location = new System.Drawing.Point(11, 5);
            this.dataSach.Name = "dataSach";
            this.dataSach.RowHeadersWidth = 51;
            this.dataSach.RowTemplate.Height = 24;
            this.dataSach.Size = new System.Drawing.Size(1061, 273);
            this.dataSach.TabIndex = 0;
            this.dataSach.DoubleClick += new System.EventHandler(this.dataSach_DoubleClick);
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
            this.lblTacGia.Size = new System.Drawing.Size(81, 25);
            this.lblTacGia.TabIndex = 5;
            this.lblTacGia.Text = "Tác Giả";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(3, 46);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(98, 25);
            this.lblTenSach.TabIndex = 7;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // txtboxTenSach
            // 
            this.txtboxTenSach.Location = new System.Drawing.Point(141, 46);
            this.txtboxTenSach.Name = "txtboxTenSach";
            this.txtboxTenSach.Size = new System.Drawing.Size(369, 28);
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
            this.panel1.Location = new System.Drawing.Point(12, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 508);
            this.panel1.TabIndex = 10;
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
            this.txtboxMaSach.Size = new System.Drawing.Size(369, 28);
            this.txtboxMaSach.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Sách";
            // 
            // comboBoxTacGia
            // 
            this.comboBoxTacGia.FormattingEnabled = true;
            this.comboBoxTacGia.Location = new System.Drawing.Point(906, 8);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(155, 30);
            this.comboBoxTacGia.TabIndex = 20;
            // 
            // listBoxTacGia
            // 
            this.listBoxTacGia.FormattingEnabled = true;
            this.listBoxTacGia.ItemHeight = 22;
            this.listBoxTacGia.Location = new System.Drawing.Point(692, 8);
            this.listBoxTacGia.Name = "listBoxTacGia";
            this.listBoxTacGia.Size = new System.Drawing.Size(208, 136);
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
            this.lblMoTa.Size = new System.Drawing.Size(69, 25);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(141, 251);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(378, 30);
            this.comboBoxNXB.TabIndex = 16;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(141, 207);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(378, 30);
            this.comboBoxTheLoai.TabIndex = 15;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.Location = new System.Drawing.Point(3, 251);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(53, 25);
            this.lblNXB.TabIndex = 13;
            this.lblNXB.Text = "NXB";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(3, 207);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(89, 25);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Độ tuổi";
            // 
            // numericUpDownTuoi
            // 
            this.numericUpDownTuoi.Location = new System.Drawing.Point(141, 296);
            this.numericUpDownTuoi.Name = "numericUpDownTuoi";
            this.numericUpDownTuoi.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownTuoi.TabIndex = 26;
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 823);
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
    }
}