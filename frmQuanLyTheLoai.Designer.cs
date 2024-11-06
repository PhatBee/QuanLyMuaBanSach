namespace QuanLyMuaBanSach
{
    partial class frmQuanLyTheLoai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.lblTenTheLoai = new System.Windows.Forms.Label();
            this.txtBoxMaTheLoai = new System.Windows.Forms.TextBox();
            this.txtBoxTenTheLoai = new System.Windows.Forms.TextBox();
            this.dataTheLoai = new System.Windows.Forms.DataGridView();
            this.maTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinTheLoai = new System.Windows.Forms.Label();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblMaTheLoai);
            this.panel1.Controls.Add(this.lblTenTheLoai);
            this.panel1.Controls.Add(this.txtBoxMaTheLoai);
            this.panel1.Controls.Add(this.txtBoxTenTheLoai);
            this.panel1.Location = new System.Drawing.Point(75, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 116);
            this.panel1.TabIndex = 17;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(300, 88);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 28);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(414, 88);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 28);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(194, 88);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTheLoai.Location = new System.Drawing.Point(176, 23);
            this.lblMaTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(80, 18);
            this.lblMaTheLoai.TabIndex = 13;
            this.lblMaTheLoai.Text = "Mã thể loại";
            // 
            // lblTenTheLoai
            // 
            this.lblTenTheLoai.AutoSize = true;
            this.lblTenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTheLoai.Location = new System.Drawing.Point(176, 54);
            this.lblTenTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTheLoai.Name = "lblTenTheLoai";
            this.lblTenTheLoai.Size = new System.Drawing.Size(84, 18);
            this.lblTenTheLoai.TabIndex = 13;
            this.lblTenTheLoai.Text = "Tên thể loại";
            // 
            // txtBoxMaTheLoai
            // 
            this.txtBoxMaTheLoai.Enabled = false;
            this.txtBoxMaTheLoai.Location = new System.Drawing.Point(280, 23);
            this.txtBoxMaTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMaTheLoai.Name = "txtBoxMaTheLoai";
            this.txtBoxMaTheLoai.Size = new System.Drawing.Size(200, 20);
            this.txtBoxMaTheLoai.TabIndex = 10;
            // 
            // txtBoxTenTheLoai
            // 
            this.txtBoxTenTheLoai.Location = new System.Drawing.Point(280, 54);
            this.txtBoxTenTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTenTheLoai.Name = "txtBoxTenTheLoai";
            this.txtBoxTenTheLoai.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTenTheLoai.TabIndex = 10;
            // 
            // dataTheLoai
            // 
            this.dataTheLoai.AllowUserToAddRows = false;
            this.dataTheLoai.AllowUserToDeleteRows = false;
            this.dataTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTL,
            this.tenTL});
            this.dataTheLoai.Location = new System.Drawing.Point(75, 44);
            this.dataTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.dataTheLoai.Name = "dataTheLoai";
            this.dataTheLoai.ReadOnly = true;
            this.dataTheLoai.RowHeadersWidth = 62;
            this.dataTheLoai.RowTemplate.Height = 28;
            this.dataTheLoai.Size = new System.Drawing.Size(663, 276);
            this.dataTheLoai.TabIndex = 16;
            this.dataTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTheLoai_CellClick);
            // 
            // maTL
            // 
            this.maTL.DataPropertyName = "maTL";
            this.maTL.HeaderText = "Mã Thể Loại";
            this.maTL.Name = "maTL";
            this.maTL.ReadOnly = true;
            // 
            // tenTL
            // 
            this.tenTL.DataPropertyName = "tenTL";
            this.tenTL.HeaderText = "Tên Thể Loại";
            this.tenTL.Name = "tenTL";
            this.tenTL.ReadOnly = true;
            // 
            // lblThongTinTheLoai
            // 
            this.lblThongTinTheLoai.AutoSize = true;
            this.lblThongTinTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTheLoai.Location = new System.Drawing.Point(76, 19);
            this.lblThongTinTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinTheLoai.Name = "lblThongTinTheLoai";
            this.lblThongTinTheLoai.Size = new System.Drawing.Size(196, 26);
            this.lblThongTinTheLoai.TabIndex = 15;
            this.lblThongTinTheLoai.Text = "Thông Tin Thể Loại";
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(796, 34);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(311, 20);
            this.txtBoxTimKiem.TabIndex = 19;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(677, 35);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(113, 29);
            this.lblTimKiem.TabIndex = 18;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm kiếm";
            // 
            // frmQuanLyTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataTheLoai);
            this.Controls.Add(this.lblThongTinTheLoai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyTheLoai";
            this.Text = "frmQuanLyTheLoai";
            this.Load += new System.EventHandler(this.frmQuanLyTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTenTheLoai;
        private System.Windows.Forms.TextBox txtBoxTenTheLoai;
        private System.Windows.Forms.DataGridView dataTheLoai;
        private System.Windows.Forms.Label lblThongTinTheLoai;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.TextBox txtBoxMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
    }
}