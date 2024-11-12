using System;

namespace QuanLyMuaBanSach
{
    partial class frmBanSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSach,
            this.colSoLuong,
            this.GiaNhap,
            this.colThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "tenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "soLuongBan";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "giaBan";
            this.GiaNhap.HeaderText = "Giá bán";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "thanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "tenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "soLuongBan";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "giaBan";
            this.GiaNhap.HeaderText = "Giá bán";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "thanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bán sách";
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(371, 6);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(331, 25);
            this.cboKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng:";
            // 
            // numSoLuongNhap
            // 
            this.numSoLuongNhap.Location = new System.Drawing.Point(738, 435);
            this.numSoLuongNhap.Name = "numSoLuongNhap";
            this.numSoLuongNhap.Size = new System.Drawing.Size(83, 24);
            this.numSoLuongNhap.TabIndex = 7;
            this.numSoLuongNhap.ValueChanged += new System.EventHandler(this.numSoLuongNhap_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(16, 489);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(148, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(772, 494);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(12, 18);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = ".";
            // 
            // btnThemHD
            // 
            this.btnThemHD.AutoSize = true;
            this.btnThemHD.Location = new System.Drawing.Point(756, 2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(162, 36);
            this.btnThemHD.TabIndex = 14;
            this.btnThemHD.Text = "Thêm Hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cboSach
            // 
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(180, 437);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(231, 25);
            this.cboSach.TabIndex = 15;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Location = new System.Drawing.Point(16, 561);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(127, 46);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "Thanh toán ";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cboSach);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSoLuongNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanSach";
            this.Text = "frmNhapSach";
            this.Load += new System.EventHandler(this.frmBanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numSoLuongNhap_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoLuongNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
    }
}