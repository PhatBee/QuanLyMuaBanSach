﻿namespace QuanLyMuaBanSach
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
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.lblThongTinTheLoai = new System.Windows.Forms.Label();
            this.txtBoxTheLoai = new System.Windows.Forms.TextBox();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(113, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 179);
            this.panel1.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(294, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(468, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblTenTheLoai
            // 
            this.lblTenTheLoai.AutoSize = true;
            this.lblTenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTheLoai.Location = new System.Drawing.Point(273, 69);
            this.lblTenTheLoai.Name = "lblTenTheLoai";
            this.lblTenTheLoai.Size = new System.Drawing.Size(124, 26);
            this.lblTenTheLoai.TabIndex = 13;
            this.lblTenTheLoai.Text = "Tên thể loại";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(621, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtBoxTenTheLoai
            // 
            this.txtBoxTenTheLoai.Location = new System.Drawing.Point(420, 71);
            this.txtBoxTenTheLoai.Name = "txtBoxTenTheLoai";
            this.txtBoxTenTheLoai.Size = new System.Drawing.Size(298, 26);
            this.txtBoxTenTheLoai.TabIndex = 10;
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(113, 67);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.RowHeadersWidth = 62;
            this.dataGridViewTheLoai.RowTemplate.Height = 28;
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(994, 425);
            this.dataGridViewTheLoai.TabIndex = 16;
            // 
            // lblThongTinTheLoai
            // 
            this.lblThongTinTheLoai.AutoSize = true;
            this.lblThongTinTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTheLoai.Location = new System.Drawing.Point(115, 27);
            this.lblThongTinTheLoai.Name = "lblThongTinTheLoai";
            this.lblThongTinTheLoai.Size = new System.Drawing.Size(297, 37);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 697);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTheLoai);
            this.Controls.Add(this.lblThongTinTheLoai);
            this.Name = "frmQuanLyTheLoai";
            this.Text = "frmQuanLyTheLoai";
            this.Load += new System.EventHandler(this.frmQuanLyTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.Label lblThongTinTheLoai;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.TextBox txtBoxTheLoai;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}