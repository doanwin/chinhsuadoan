namespace DiemDanhSinhVien.Views
{
    partial class frmPhanquyen
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
            this.qldiemdanhsvDataSet = new DiemDanhSinhVien.qldiemdanhsvDataSet();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager();
            this.dM_ManHinhTableAdapter = new DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.DM_ManHinhTableAdapter();
            this.dM_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsmanhinh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPushall = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPopAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dsduocchon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTenNhom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmanhinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsduocchon)).BeginInit();
            this.SuspendLayout();
            // 
            // qldiemdanhsvDataSet
            // 
            this.qldiemdanhsvDataSet.DataSetName = "qldiemdanhsvDataSet";
            this.qldiemdanhsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOTRILOPTableAdapter = null;
            this.tableAdapterManager.CAHOCTableAdapter = null;
            this.tableAdapterManager.CHITIETDIEMDANHTableAdapter = null;
            this.tableAdapterManager.DIEMDANHTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = this.dM_ManHinhTableAdapter;
            this.tableAdapterManager.DONVITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCTableAdapter = null;
            this.tableAdapterManager.LAPTableAdapter = null;
            this.tableAdapterManager.LOPMONHOCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiemDanhSinhVien.qldiemdanhsvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_ManHinhTableAdapter
            // 
            this.dM_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // dM_ManHinhBindingSource
            // 
            this.dM_ManHinhBindingSource.DataMember = "DM_ManHinh";
            this.dM_ManHinhBindingSource.DataSource = this.qldiemdanhsvDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsmanhinh);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách màn hình hiện có";
            // 
            // dgv_dsmanhinh
            // 
            this.dgv_dsmanhinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsmanhinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_dsmanhinh.Location = new System.Drawing.Point(18, 17);
            this.dgv_dsmanhinh.Name = "dgv_dsmanhinh";
            this.dgv_dsmanhinh.Size = new System.Drawing.Size(347, 337);
            this.dgv_dsmanhinh.TabIndex = 1;
            this.dgv_dsmanhinh.SelectionChanged += new System.EventHandler(this.dgv_dsmanhinh_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManhHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên màn hình";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(400, 93);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(32, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = ">";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPushall
            // 
            this.btnPushall.Location = new System.Drawing.Point(400, 122);
            this.btnPushall.Name = "btnPushall";
            this.btnPushall.Size = new System.Drawing.Size(32, 23);
            this.btnPushall.TabIndex = 2;
            this.btnPushall.Text = ">>";
            this.btnPushall.UseVisualStyleBackColor = true;
            this.btnPushall.Click += new System.EventHandler(this.btnPushall_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(400, 198);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(32, 23);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "<";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPopAll
            // 
            this.btnPopAll.Location = new System.Drawing.Point(400, 227);
            this.btnPopAll.Name = "btnPopAll";
            this.btnPopAll.Size = new System.Drawing.Size(32, 23);
            this.btnPopAll.TabIndex = 4;
            this.btnPopAll.Text = ">>";
            this.btnPopAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dsduocchon);
            this.groupBox2.Location = new System.Drawing.Point(436, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 327);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách màn hình được chọn";
            // 
            // dgv_dsduocchon
            // 
            this.dgv_dsduocchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsduocchon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_dsduocchon.Location = new System.Drawing.Point(19, 19);
            this.dgv_dsduocchon.Name = "dgv_dsduocchon";
            this.dgv_dsduocchon.Size = new System.Drawing.Size(342, 335);
            this.dgv_dsduocchon.TabIndex = 0;
            this.dgv_dsduocchon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsduocchon_CellContentClick);
            this.dgv_dsduocchon.SelectionChanged += new System.EventHandler(this.dgv_dsduocchon_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaManhHinh";
            this.Column1.HeaderText = "Mã màn hình";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenManHinh";
            this.Column2.HeaderText = "Tên màn hình";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhom.Location = new System.Drawing.Point(13, 13);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(45, 16);
            this.lblTenNhom.TabIndex = 6;
            this.lblTenNhom.Text = "label1";
            // 
            // frmPhanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 384);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPopAll);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPushall);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanquyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frmPhanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qldiemdanhsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmanhinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsduocchon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qldiemdanhsvDataSet qldiemdanhsvDataSet;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private qldiemdanhsvDataSetTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private qldiemdanhsvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private qldiemdanhsvDataSetTableAdapters.DM_ManHinhTableAdapter dM_ManHinhTableAdapter;
        private System.Windows.Forms.BindingSource dM_ManHinhBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPushall;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPopAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dsduocchon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgv_dsmanhinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTenNhom;
    }
}