namespace QuanLyMuaBanSach
{
    partial class frmDuDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgDuDoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDoanTheoXuHuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDoanTheoMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuDoanChoThangSau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDuDoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDuDoan
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDuDoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgDuDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDuDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.DuDoanTheoXuHuong,
            this.DuDoanTheoMua,
            this.DuDoanChoThangSau});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDuDoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgDuDoan.Location = new System.Drawing.Point(31, 101);
            this.dvgDuDoan.Name = "dvgDuDoan";
            this.dvgDuDoan.RowHeadersWidth = 51;
            this.dvgDuDoan.RowTemplate.Height = 24;
            this.dvgDuDoan.Size = new System.Drawing.Size(1334, 384);
            this.dvgDuDoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(416, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dự Đoán Tháng Tiếp Theo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 76);
            this.panel1.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1290, 491);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // maSach
            // 
            this.maSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            // 
            // tenSach
            // 
            this.tenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 114;
            // 
            // DuDoanTheoXuHuong
            // 
            this.DuDoanTheoXuHuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DuDoanTheoXuHuong.DataPropertyName = "DuDoanTheoXuHuong";
            this.DuDoanTheoXuHuong.HeaderText = "Dự đoán theo xu hướng";
            this.DuDoanTheoXuHuong.MinimumWidth = 6;
            this.DuDoanTheoXuHuong.Name = "DuDoanTheoXuHuong";
            // 
            // DuDoanTheoMua
            // 
            this.DuDoanTheoMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DuDoanTheoMua.DataPropertyName = "DuDoanTheoMua";
            this.DuDoanTheoMua.HeaderText = "Dự đoán theo mùa";
            this.DuDoanTheoMua.MinimumWidth = 6;
            this.DuDoanTheoMua.Name = "DuDoanTheoMua";
            // 
            // DuDoanChoThangSau
            // 
            this.DuDoanChoThangSau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DuDoanChoThangSau.DataPropertyName = "DuDoanChoThangSau";
            this.DuDoanChoThangSau.HeaderText = "Dự đoán cho tháng sau ";
            this.DuDoanChoThangSau.MinimumWidth = 6;
            this.DuDoanChoThangSau.Name = "DuDoanChoThangSau";
            // 
            // frmDuDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 614);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvgDuDoan);
            this.Name = "frmDuDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dự Đoán Tháng Tiếp Theo";
            this.Load += new System.EventHandler(this.frmDuDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDuDoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDuDoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDoanTheoXuHuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDoanTheoMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuDoanChoThangSau;
    }
}