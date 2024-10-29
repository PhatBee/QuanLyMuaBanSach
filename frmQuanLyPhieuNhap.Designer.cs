namespace QuanLyMuaBanSach
{
    partial class frmQuanLyPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhieuNhapSet = new QuanLyMuaBanSach.QLPhieuNhapSet();
            this.label1 = new System.Windows.Forms.Label();
            this.list_PhieuNhapTableAdapter = new QuanLyMuaBanSach.QLPhieuNhapSetTableAdapters.list_PhieuNhapTableAdapter();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.txtBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhieuNhapSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 331);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPNDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.tenNXBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listPhieuNhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 280);
            this.dataGridView1.TabIndex = 1;
            // 
            // soPNDataGridViewTextBoxColumn
            // 
            this.soPNDataGridViewTextBoxColumn.DataPropertyName = "soPN";
            this.soPNDataGridViewTextBoxColumn.HeaderText = "Số phiếu nhập";
            this.soPNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soPNDataGridViewTextBoxColumn.Name = "soPNDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "ngayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "tenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // tenNXBDataGridViewTextBoxColumn
            // 
            this.tenNXBDataGridViewTextBoxColumn.DataPropertyName = "tenNXB";
            this.tenNXBDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.tenNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNXBDataGridViewTextBoxColumn.Name = "tenNXBDataGridViewTextBoxColumn";
            // 
            // listPhieuNhapBindingSource
            // 
            this.listPhieuNhapBindingSource.DataMember = "list_PhieuNhap";
            this.listPhieuNhapBindingSource.DataSource = this.qLPhieuNhapSet;
            // 
            // qLPhieuNhapSet
            // 
            this.qLPhieuNhapSet.DataSetName = "QLPhieuNhapSet";
            this.qLPhieuNhapSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // list_PhieuNhapTableAdapter
            // 
            this.list_PhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemPN
            // 
            this.btnThemPN.AutoSize = true;
            this.btnThemPN.Location = new System.Drawing.Point(4, 423);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(77, 36);
            this.btnThemPN.TabIndex = 1;
            this.btnThemPN.Text = "Thêm";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // txtBoxTimKiem
            // 
            this.txtBoxTimKiem.Location = new System.Drawing.Point(454, 48);
            this.txtBoxTimKiem.Name = "txtBoxTimKiem";
            this.txtBoxTimKiem.Size = new System.Drawing.Size(540, 32);
            this.txtBoxTimKiem.TabIndex = 9;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(347, 51);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(101, 26);
            this.lblTimKiem.TabIndex = 8;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // frmQuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.txtBoxTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnThemPN);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyPhieuNhap";
            this.Text = "frmNhapSach";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhieuNhapSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private QLPhieuNhapSet qLPhieuNhapSet;
        private System.Windows.Forms.BindingSource listPhieuNhapBindingSource;
        private QLPhieuNhapSetTableAdapters.list_PhieuNhapTableAdapter list_PhieuNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.TextBox txtBoxTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}