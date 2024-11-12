namespace QuanLyMuaBanSach
{
    partial class frmKPINhanVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxKPI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "VND";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(749, 542);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(212, 26);
            this.txtDoanhThu.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng doanh thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.ngayLap,
            this.DoanhThu});
            this.dataGridView1.Location = new System.Drawing.Point(91, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 368);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(91, 88);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 29);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tháng";
            // 
            // cbxThang
            // 
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(91, 34);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 28);
            this.cbxThang.TabIndex = 22;
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(299, 35);
            this.numNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(120, 26);
            this.numNam.TabIndex = 23;
            this.numNam.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV2,
            this.tenNV2,
            this.tongDoanhThu,
            this.danhGia});
            this.dataGridView2.Location = new System.Drawing.Point(91, 628);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(921, 282);
            this.dataGridView2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "KPI";
            // 
            // txtbxKPI
            // 
            this.txtbxKPI.Location = new System.Drawing.Point(148, 591);
            this.txtbxKPI.Name = "txtbxKPI";
            this.txtbxKPI.ReadOnly = true;
            this.txtbxKPI.Size = new System.Drawing.Size(233, 26);
            this.txtbxKPI.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "VNĐ";
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã Nhân Viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 125;
            // 
            // ngayLap
            // 
            this.ngayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày bán";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            // 
            // DoanhThu
            // 
            this.DoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            // 
            // maNV2
            // 
            this.maNV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV2.DataPropertyName = "maNV";
            this.maNV2.HeaderText = "Mã nhân viên";
            this.maNV2.MinimumWidth = 8;
            this.maNV2.Name = "maNV2";
            // 
            // tenNV2
            // 
            this.tenNV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNV2.DataPropertyName = "tenNV";
            this.tenNV2.HeaderText = "Tên nhân viên";
            this.tenNV2.MinimumWidth = 8;
            this.tenNV2.Name = "tenNV2";
            // 
            // tongDoanhThu
            // 
            this.tongDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongDoanhThu.DataPropertyName = "tongDoanhThu";
            this.tongDoanhThu.HeaderText = "Tổng doanh thu";
            this.tongDoanhThu.MinimumWidth = 8;
            this.tongDoanhThu.Name = "tongDoanhThu";
            // 
            // danhGia
            // 
            this.danhGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.danhGia.DataPropertyName = "danhGia";
            this.danhGia.HeaderText = "Đánh giá";
            this.danhGia.MinimumWidth = 8;
            this.danhGia.Name = "danhGia";
            // 
            // frmKPINhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 954);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxKPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.numNam);
            this.Controls.Add(this.cbxThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKPINhanVien";
            this.Text = "frmKPINhanVien";
            this.Load += new System.EventHandler(this.frmKPINhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxKPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhGia;
    }
}