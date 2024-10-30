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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tungay
            // 
            this.tungay.Location = new System.Drawing.Point(107, 30);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(200, 22);
            this.tungay.TabIndex = 0;
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(411, 30);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(200, 22);
            this.den.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(96, 75);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
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
            this.TongDoanhThu});
            this.dataGridView1.Location = new System.Drawing.Point(79, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 294);
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
            this.TongSachBanRa.DataPropertyName = "TongSachBanRa";
            this.TongSachBanRa.HeaderText = "Tổng số Sách bán ra";
            this.TongSachBanRa.MinimumWidth = 6;
            this.TongSachBanRa.Name = "TongSachBanRa";
            // 
            // TongSachNhapVao
            // 
            this.TongSachNhapVao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSachNhapVao.DataPropertyName = "TongSachNhapVao";
            this.TongSachNhapVao.HeaderText = "Tổng số Sách nhập vào";
            this.TongSachNhapVao.MinimumWidth = 6;
            this.TongSachNhapVao.Name = "TongSachNhapVao";
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongDoanhThu.DataPropertyName = "DoanhThuSach";
            this.TongDoanhThu.HeaderText = "Doanh Thu";
            this.TongDoanhThu.MinimumWidth = 6;
            this.TongDoanhThu.Name = "TongDoanhThu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng doanh thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(666, 451);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(189, 22);
            this.txtDoanhThu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "VND";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSachBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSachNhapVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label4;
    }
}