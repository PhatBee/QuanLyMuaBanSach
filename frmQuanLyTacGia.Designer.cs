namespace QuanLyMuaBanSach
{
    partial class frmQuanLyTacGia
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
            this.lblThongTinTG = new System.Windows.Forms.Label();
            this.dataTacGia = new System.Windows.Forms.DataGridView();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxTenTG = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMaTG = new System.Windows.Forms.TextBox();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTacGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinTG
            // 
            this.lblThongTinTG.AutoSize = true;
            this.lblThongTinTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTG.Location = new System.Drawing.Point(8, 11);
            this.lblThongTinTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinTG.Name = "lblThongTinTG";
            this.lblThongTinTG.Size = new System.Drawing.Size(188, 26);
            this.lblThongTinTG.TabIndex = 0;
            this.lblThongTinTG.Text = "Thông Tin Tác Giả";
            // 
            // dataTacGia
            // 
            this.dataTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTacGia.Location = new System.Drawing.Point(9, 37);
            this.dataTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTacGia.Name = "dataTacGia";
            this.dataTacGia.RowHeadersWidth = 62;
            this.dataTacGia.RowTemplate.Height = 28;
            this.dataTacGia.Size = new System.Drawing.Size(663, 276);
            this.dataTacGia.TabIndex = 1;
            this.dataTacGia.DoubleClick += new System.EventHandler(this.dataTacGia_DoubleClick);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(180, 72);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(94, 18);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenTG
            // 
            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTG.Location = new System.Drawing.Point(182, 39);
            this.lblTenTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTG.Name = "lblTenTG";
            this.lblTenTG.Size = new System.Drawing.Size(89, 18);
            this.lblTenTG.TabIndex = 13;
            this.lblTenTG.Text = "Tên Tác Giả";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(285, 72);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(200, 20);
            this.txtBoxSDT.TabIndex = 8;
            // 
            // txtBoxTenTG
            // 
            this.txtBoxTenTG.Location = new System.Drawing.Point(292, 41);
            this.txtBoxTenTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTenTG.Name = "txtBoxTenTG";
            this.txtBoxTenTG.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTenTG.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(418, 109);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 28);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(304, 109);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 28);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(201, 109);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxMaTG);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.lblTenTG);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtBoxSDT);
            this.panel1.Controls.Add(this.txtBoxTenTG);
            this.panel1.Location = new System.Drawing.Point(9, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 151);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Tác Giả";
            // 
            // txtBoxMaTG
            // 
            this.txtBoxMaTG.Enabled = false;
            this.txtBoxMaTG.Location = new System.Drawing.Point(284, 9);
            this.txtBoxMaTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxMaTG.Name = "txtBoxMaTG";
            this.txtBoxMaTG.Size = new System.Drawing.Size(200, 20);
            this.txtBoxMaTG.TabIndex = 14;
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(320, 14);
            this.txtBoxTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(247, 20);
            this.txtBoxTimKiem.TabIndex = 16;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(232, 11);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 20);
            this.lblTimKiem.TabIndex = 15;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(571, 15);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(56, 19);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frmQuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 475);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataTacGia);
            this.Controls.Add(this.lblThongTinTG);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyTacGia";
            this.Text = "frmQuanLyTacGia";
            this.Load += new System.EventHandler(this.frmQuanLyTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTacGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinTG;
        private System.Windows.Forms.DataGridView dataTacGia;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenTG;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.TextBox txtBoxTenTG;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMaTG;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}