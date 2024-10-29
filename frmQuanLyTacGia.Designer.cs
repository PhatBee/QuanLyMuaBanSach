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
            this.dataGridViewTG = new System.Windows.Forms.DataGridView();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtBoxTenTG = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinTG
            // 
            this.lblThongTinTG.AutoSize = true;
            this.lblThongTinTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTG.Location = new System.Drawing.Point(345, 16);
            this.lblThongTinTG.Name = "lblThongTinTG";
            this.lblThongTinTG.Size = new System.Drawing.Size(285, 37);
            this.lblThongTinTG.TabIndex = 0;
            this.lblThongTinTG.Text = "Thông Tin Tác Giả";
            // 
            // dataGridViewTG
            // 
            this.dataGridViewTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTG.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewTG.Name = "dataGridViewTG";
            this.dataGridViewTG.RowHeadersWidth = 62;
            this.dataGridViewTG.RowTemplate.Height = 28;
            this.dataGridViewTG.Size = new System.Drawing.Size(994, 425);
            this.dataGridViewTG.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(270, 110);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(139, 26);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenTG
            // 
            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTG.Location = new System.Drawing.Point(280, 55);
            this.lblTenTG.Name = "lblTenTG";
            this.lblTenTG.Size = new System.Drawing.Size(129, 26);
            this.lblTenTG.TabIndex = 13;
            this.lblTenTG.Text = "Tên Tác Giả";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(427, 110);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(298, 26);
            this.txtBoxSDT.TabIndex = 8;
            // 
            // txtBoxTenTG
            // 
            this.txtBoxTenTG.Location = new System.Drawing.Point(427, 57);
            this.txtBoxTenTG.Name = "txtBoxTenTG";
            this.txtBoxTenTG.Size = new System.Drawing.Size(298, 26);
            this.txtBoxTenTG.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(628, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(457, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(301, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.lblTenTG);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtBoxSDT);
            this.panel1.Controls.Add(this.txtBoxTenTG);
            this.panel1.Location = new System.Drawing.Point(13, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 233);
            this.panel1.TabIndex = 14;
            // 
            // frmQuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTG);
            this.Controls.Add(this.lblThongTinTG);
            this.Name = "frmQuanLyTacGia";
            this.Text = "frmQuanLyTacGia";
            this.Load += new System.EventHandler(this.frmQuanLyTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinTG;
        private System.Windows.Forms.DataGridView dataGridViewTG;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenTG;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.TextBox txtBoxTenTG;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
    }
}