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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblTenTheLoai = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtBoxTenTheLoai = new System.Windows.Forms.TextBox();
            this.dataTheLoai = new System.Windows.Forms.DataGridView();
            this.lblThongTinTheLoai = new System.Windows.Forms.Label();
            this.txtBoxTheLoai = new System.Windows.Forms.TextBox();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.lblMaTheLoai);
            this.panel1.Controls.Add(this.lblTenTheLoai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtBoxTheLoai);
            this.panel1.Controls.Add(this.txtBoxTenTheLoai);
            this.panel1.Location = new System.Drawing.Point(100, 398);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 143);
            this.panel1.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(261, 78);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            
            // 
            // lblTenTheLoai
            // 
            this.lblTenTheLoai.AutoSize = true;
            this.lblTenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTheLoai.Location = new System.Drawing.Point(243, 33);
            this.lblTenTheLoai.Name = "lblTenTheLoai";
            this.lblTenTheLoai.Size = new System.Drawing.Size(109, 24);
            this.lblTenTheLoai.TabIndex = 13;
            this.lblTenTheLoai.Text = "Tên thể loại";
            // 
            
            // 
            // txtBoxTenTheLoai
            // 
            this.txtBoxTenTheLoai.Location = new System.Drawing.Point(373, 34);
            this.txtBoxTenTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTenTheLoai.Name = "txtBoxTenTheLoai";
            this.txtBoxTenTheLoai.Size = new System.Drawing.Size(265, 22);
            this.txtBoxTenTheLoai.TabIndex = 10;
            // 
            // dataTheLoai
            // 
            this.dataTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTheLoai.Location = new System.Drawing.Point(100, 54);
            this.dataTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTheLoai.Name = "dataTheLoai";
            this.dataTheLoai.RowHeadersWidth = 62;
            this.dataTheLoai.RowTemplate.Height = 28;
            this.dataTheLoai.Size = new System.Drawing.Size(884, 340);
            this.dataTheLoai.TabIndex = 16;
            // 
            // lblThongTinTheLoai
            // 
            this.lblThongTinTheLoai.AutoSize = true;
            this.lblThongTinTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTheLoai.Location = new System.Drawing.Point(396, 22);
            this.lblThongTinTheLoai.Name = "lblThongTinTheLoai";
            this.lblThongTinTheLoai.Size = new System.Drawing.Size(248, 31);
            this.lblThongTinTheLoai.TabIndex = 15;
            this.lblThongTinTheLoai.Text = "Thông Tin Thể Loại";
            // 
            // txtBoxTheLoai
            // 
            this.txtBoxTheLoai.Location = new System.Drawing.Point(420, 29);
            this.txtBoxTheLoai.Name = "txtBoxTheLoai";
            this.txtBoxTheLoai.Size = new System.Drawing.Size(298, 26);
            this.txtBoxTheLoai.TabIndex = 10;
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTheLoai.Location = new System.Drawing.Point(273, 27);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(118, 26);
            this.lblMaTheLoai.TabIndex = 13;
            this.lblMaTheLoai.Text = "Mã thể loại";
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(796, 34);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(311, 26);
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
            // frmQuanLyTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataTheLoai);
            this.Controls.Add(this.lblThongTinTheLoai);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblTenTheLoai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtBoxTenTheLoai;
        private System.Windows.Forms.DataGridView dataTheLoai;
        private System.Windows.Forms.Label lblThongTinTheLoai;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.TextBox txtBoxTheLoai;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}