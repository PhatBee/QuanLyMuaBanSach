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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSachDataSet = new QuanLyMuaBanSach.QLSachDataSet();
            this.list_SachTableAdapter = new QuanLyMuaBanSach.QLSachDataSetTableAdapters.list_SachTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnQLNXB = new System.Windows.Forms.Button();
            this.btnQLTacGia = new System.Windows.Forms.Button();
            this.btnQLTheLoai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 413);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 28);
            this.textBox1.TabIndex = 2;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(22, 96);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(81, 25);
            this.lblTacGia.TabIndex = 5;
            this.lblTacGia.Text = "Tác Giả";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(3, 35);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(98, 25);
            this.lblTenSach.TabIndex = 7;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 28);
            this.textBox2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.comboBoxNXB);
            this.panel1.Controls.Add(this.comboBoxTheLoai);
            this.panel1.Controls.Add(this.lblNXB);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnQLNXB);
            this.panel1.Controls.Add(this.btnQLTacGia);
            this.panel1.Controls.Add(this.btnQLTheLoai);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblTacGia);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblTenSach);
            this.panel1.Location = new System.Drawing.Point(11, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 508);
            this.panel1.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(920, 34);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(446, 187);
            this.textBox4.TabIndex = 17;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(816, 35);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(69, 25);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(141, 227);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(369, 30);
            this.comboBoxNXB.TabIndex = 16;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(141, 163);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(369, 30);
            this.comboBoxTheLoai.TabIndex = 15;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.Location = new System.Drawing.Point(50, 232);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(53, 25);
            this.lblNXB.TabIndex = 13;
            this.lblNXB.Text = "NXB";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(6, 168);
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
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1033, 269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 41);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnQLNXB
            // 
            this.btnQLNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNXB.Location = new System.Drawing.Point(532, 222);
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
            this.btnQLTacGia.Location = new System.Drawing.Point(532, 90);
            this.btnQLTacGia.Name = "btnQLTacGia";
            this.btnQLTacGia.Size = new System.Drawing.Size(192, 41);
            this.btnQLTacGia.TabIndex = 10;
            this.btnQLTacGia.Text = "Quản lý tác giả";
            this.btnQLTacGia.UseVisualStyleBackColor = true;
            this.btnQLTacGia.Click += new System.EventHandler(this.btnQLTacGia_Click);
            // 
            // btnQLTheLoai
            // 
            this.btnQLTheLoai.AccessibleDescription = "";
            this.btnQLTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTheLoai.Location = new System.Drawing.Point(532, 158);
            this.btnQLTheLoai.Name = "btnQLTheLoai";
            this.btnQLTheLoai.Size = new System.Drawing.Size(192, 41);
            this.btnQLTheLoai.TabIndex = 10;
            this.btnQLTheLoai.Text = "Quản lý thể loại";
            this.btnQLTheLoai.UseVisualStyleBackColor = true;
            this.btnQLTheLoai.Click += new System.EventHandler(this.btnQLTheLoai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(821, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 41);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSach";
            this.Text = "FrmSach";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLSachDataSet qLSachDataSet;
        private System.Windows.Forms.BindingSource listSachBindingSource;
        private QLSachDataSetTableAdapters.list_SachTableAdapter list_SachTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQLNXB;
        private System.Windows.Forms.Button btnQLTheLoai;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnQLTacGia;
    }
}