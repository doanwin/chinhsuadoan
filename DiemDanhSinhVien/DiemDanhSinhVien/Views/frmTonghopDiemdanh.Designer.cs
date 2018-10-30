namespace DiemDanhSinhVien.Views
{
    partial class frmTonghopDiemdanh
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
            this.cbo_chonlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dulieudiemdanh = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOPNIENCHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGSOTIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dulieudiemdanh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_chonlop
            // 
            this.cbo_chonlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_chonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_chonlop.FormattingEnabled = true;
            this.cbo_chonlop.Location = new System.Drawing.Point(204, 16);
            this.cbo_chonlop.Name = "cbo_chonlop";
            this.cbo_chonlop.Size = new System.Drawing.Size(620, 28);
            this.cbo_chonlop.TabIndex = 0;
            this.cbo_chonlop.SelectedIndexChanged += new System.EventHandler(this.cbo_chonlop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp";
            // 
            // dgv_dulieudiemdanh
            // 
            this.dgv_dulieudiemdanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dulieudiemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dulieudiemdanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.TENSV,
            this.NGAYSINH,
            this.GIOITINH,
            this.LOPNIENCHE,
            this.TONGSOTIET});
            this.dgv_dulieudiemdanh.Location = new System.Drawing.Point(25, 50);
            this.dgv_dulieudiemdanh.Name = "dgv_dulieudiemdanh";
            this.dgv_dulieudiemdanh.Size = new System.Drawing.Size(799, 371);
            this.dgv_dulieudiemdanh.TabIndex = 2;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "MÃ SINH VIÊN";
            this.MASV.Name = "MASV";
            this.MASV.Width = 150;
            // 
            // TENSV
            // 
            this.TENSV.DataPropertyName = "TENSV";
            this.TENSV.HeaderText = "TÊN SINH VIÊN";
            this.TENSV.Name = "TENSV";
            this.TENSV.Width = 250;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGÀY SINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 150;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "GIỚI TÍNH";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // LOPNIENCHE
            // 
            this.LOPNIENCHE.DataPropertyName = "LOPNIENCHE";
            this.LOPNIENCHE.HeaderText = "LỚP NIÊN CHẾ";
            this.LOPNIENCHE.Name = "LOPNIENCHE";
            // 
            // TONGSOTIET
            // 
            this.TONGSOTIET.DataPropertyName = "TONGSOTIET";
            this.TONGSOTIET.HeaderText = "TỔNG SỐ TIẾT VẮNG";
            this.TONGSOTIET.Name = "TONGSOTIET";
            // 
            // frmTonghopDiemdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 517);
            this.Controls.Add(this.dgv_dulieudiemdanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_chonlop);
            this.Name = "frmTonghopDiemdanh";
            this.Text = "Dữ Liệu Điểm Danh";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dulieudiemdanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_chonlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dulieudiemdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOPNIENCHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGSOTIET;
    }
}