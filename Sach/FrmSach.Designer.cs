namespace QuanLyMuaBanSach
{
    partial class FrmSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doTuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSachDataSet = new QuanLyMuaBanSach.QLSachDataSet();
            this.list_SachTableAdapter = new QuanLyMuaBanSach.QLSachDataSetTableAdapters.list_SachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.doTuoiDataGridViewTextBoxColumn,
            this.tenTLDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.tenNXBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listSachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "maSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "tenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "soLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.soLuongTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.Width = 125;
            // 
            // doTuoiDataGridViewTextBoxColumn
            // 
            this.doTuoiDataGridViewTextBoxColumn.DataPropertyName = "doTuoi";
            this.doTuoiDataGridViewTextBoxColumn.HeaderText = "Độ tuổi";
            this.doTuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doTuoiDataGridViewTextBoxColumn.Name = "doTuoiDataGridViewTextBoxColumn";
            this.doTuoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenTLDataGridViewTextBoxColumn
            // 
            this.tenTLDataGridViewTextBoxColumn.DataPropertyName = "tenTL";
            this.tenTLDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.tenTLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTLDataGridViewTextBoxColumn.Name = "tenTLDataGridViewTextBoxColumn";
            this.tenTLDataGridViewTextBoxColumn.Width = 125;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "moTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNXBDataGridViewTextBoxColumn
            // 
            this.tenNXBDataGridViewTextBoxColumn.DataPropertyName = "tenNXB";
            this.tenNXBDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.tenNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNXBDataGridViewTextBoxColumn.Name = "tenNXBDataGridViewTextBoxColumn";
            this.tenNXBDataGridViewTextBoxColumn.Width = 125;
            // 
            // listSachBindingSource
            // 
            this.listSachBindingSource.DataMember = "list_Sach";
            this.listSachBindingSource.DataSource = this.qLSachDataSet;
            // 
            // qLSachDataSet
            // 
            this.qLSachDataSet.DataSetName = "QLSachDataSet";
            this.qLSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_SachTableAdapter
            // 
            this.list_SachTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSach";
            this.Text = "FrmSach";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSachDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLSachDataSet qLSachDataSet;
        private System.Windows.Forms.BindingSource listSachBindingSource;
        private QLSachDataSetTableAdapters.list_SachTableAdapter list_SachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doTuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXBDataGridViewTextBoxColumn;
    }
}