namespace QuanLyMuaBanSach
{
    partial class frmThongKe
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
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSachBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSachNhapVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKPINhanVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tungay
            // 
            this.tungay.Location = new System.Drawing.Point(120, 38);
            this.tungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(224, 26);
            this.tungay.TabIndex = 0;
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(462, 38);
            this.den.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(224, 26);
            this.den.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(108, 94);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(84, 29);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.TongSachBanRa,
            this.TongSachNhapVao,
            this.TongDoanhThu,
            this.LoiNhuan});
            this.dataGridView1.Location = new System.Drawing.Point(89, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 368);
            this.dataGridView1.TabIndex = 5;
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 125;
            // 
            // TongSachBanRa
            // 
            this.TongSachBanRa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSachBanRa.DataPropertyName = "tongSoLuongBan";
            this.TongSachBanRa.HeaderText = "Tổng số sách bán ra";
            this.TongSachBanRa.MinimumWidth = 6;
            this.TongSachBanRa.Name = "TongSachBanRa";
            // 
            // TongSachNhapVao
            // 
            this.TongSachNhapVao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSachNhapVao.DataPropertyName = "tongSoLuongNhap";
            this.TongSachNhapVao.HeaderText = "Tổng số sách nhập vào";
            this.TongSachNhapVao.MinimumWidth = 6;
            this.TongSachNhapVao.Name = "TongSachNhapVao";
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongDoanhThu.DataPropertyName = "DoanhThu";
            this.TongDoanhThu.HeaderText = "Doanh Thu";
            this.TongDoanhThu.MinimumWidth = 6;
            this.TongDoanhThu.Name = "TongDoanhThu";
            // 
            // LoiNhuan
            // 
            this.LoiNhuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoiNhuan.DataPropertyName = "LoiNhuan";
            this.LoiNhuan.HeaderText = "Lợi nhuận";
            this.LoiNhuan.MinimumWidth = 6;
            this.LoiNhuan.Name = "LoiNhuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng doanh thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(749, 564);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(212, 26);
            this.txtDoanhThu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(969, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "VND";
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Location = new System.Drawing.Point(749, 615);
            this.txtLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.ReadOnly = true;
            this.txtLoiNhuan.Size = new System.Drawing.Size(212, 26);
            this.txtLoiNhuan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng lợi nhuận";
            // 
            // btnKPINhanVien
            // 
            this.btnKPINhanVien.Location = new System.Drawing.Point(805, 35);
            this.btnKPINhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKPINhanVien.Name = "btnKPINhanVien";
            this.btnKPINhanVien.Size = new System.Drawing.Size(205, 29);
            this.btnKPINhanVien.TabIndex = 12;
            this.btnKPINhanVien.Text = "Đánh giá KPI Nhân Viên";
            this.btnKPINhanVien.UseVisualStyleBackColor = true;
            this.btnKPINhanVien.Click += new System.EventHandler(this.btnKPINhanVien_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 774);
            this.Controls.Add(this.btnKPINhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tungay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tungay;
        private System.Windows.Forms.DateTimePicker den;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSachBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSachNhapVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoiNhuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKPINhanVien;
    }
}