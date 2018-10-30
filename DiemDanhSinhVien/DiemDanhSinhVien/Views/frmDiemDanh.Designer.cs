namespace DiemDanhSinhVien.Views
{
    partial class frmDiemdanh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGiangvien = new System.Windows.Forms.Label();
            this.dgv_dslop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl_chitietdiemdanh = new System.Windows.Forms.Panel();
            this.txtSotietvang = new NumericTextbox.NumericTextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.txtLydo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_dshocsinh = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnl_chitietdiemdanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGiangvien);
            this.groupBox1.Controls.Add(this.dgv_dslop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 548);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỚP GIẢNG DẬY";
            // 
            // lblGiangvien
            // 
            this.lblGiangvien.AutoSize = true;
            this.lblGiangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiangvien.ForeColor = System.Drawing.Color.Red;
            this.lblGiangvien.Location = new System.Drawing.Point(242, 18);
            this.lblGiangvien.Name = "lblGiangvien";
            this.lblGiangvien.Size = new System.Drawing.Size(60, 24);
            this.lblGiangvien.TabIndex = 20;
            this.lblGiangvien.Text = "label8";
            // 
            // dgv_dslop
            // 
            this.dgv_dslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dslop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_dslop.Location = new System.Drawing.Point(16, 70);
            this.dgv_dslop.Name = "dgv_dslop";
            this.dgv_dslop.Size = new System.Drawing.Size(334, 463);
            this.dgv_dslop.TabIndex = 19;
            this.dgv_dslop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dslop_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOPMONHOC";
            this.Column1.HeaderText = "Mã lớp giảng dậy";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOP";
            this.Column2.HeaderText = "Tên lớp giảng dậy";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MAGV";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MAMON";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "giangvien";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "monhoc";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "DANH SÁCH LỚP HỌC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "CHÀO GIẢNG VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl_chitietdiemdanh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDSSV);
            this.groupBox2.Controls.Add(this.btnDiemDanh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(313, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 267);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐIỂM DANH";
            // 
            // pnl_chitietdiemdanh
            // 
            this.pnl_chitietdiemdanh.Controls.Add(this.txtSotietvang);
            this.pnl_chitietdiemdanh.Controls.Add(this.btnNhap);
            this.pnl_chitietdiemdanh.Controls.Add(this.btnTieptuc);
            this.pnl_chitietdiemdanh.Controls.Add(this.btnQuaylai);
            this.pnl_chitietdiemdanh.Controls.Add(this.txtLydo);
            this.pnl_chitietdiemdanh.Controls.Add(this.label5);
            this.pnl_chitietdiemdanh.Controls.Add(this.label4);
            this.pnl_chitietdiemdanh.Controls.Add(this.lblTenSV);
            this.pnl_chitietdiemdanh.Enabled = false;
            this.pnl_chitietdiemdanh.Location = new System.Drawing.Point(48, 95);
            this.pnl_chitietdiemdanh.Name = "pnl_chitietdiemdanh";
            this.pnl_chitietdiemdanh.Size = new System.Drawing.Size(587, 93);
            this.pnl_chitietdiemdanh.TabIndex = 19;
            // 
            // txtSotietvang
            // 
            this.txtSotietvang.Location = new System.Drawing.Point(194, 25);
            this.txtSotietvang.Name = "txtSotietvang";
            this.txtSotietvang.Size = new System.Drawing.Size(100, 22);
            this.txtSotietvang.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(479, 9);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(74, 47);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.Location = new System.Drawing.Point(305, 53);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(108, 33);
            this.btnTieptuc.TabIndex = 2;
            this.btnTieptuc.Text = "Tiếp theo>>";
            this.btnTieptuc.UseVisualStyleBackColor = true;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(194, 53);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(105, 33);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "<<Quay lại ";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // txtLydo
            // 
            this.txtLydo.Location = new System.Drawing.Point(352, 25);
            this.txtLydo.Name = "txtLydo";
            this.txtLydo.Size = new System.Drawing.Size(100, 22);
            this.txtLydo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lý do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiết nghỉ";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.Red;
            this.lblTenSV.Location = new System.Drawing.Point(3, 4);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(51, 20);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "label3";
            this.lblTenSV.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btnDSSV
            // 
            this.btnDSSV.Location = new System.Drawing.Point(230, 217);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Size = new System.Drawing.Size(231, 42);
            this.btnDSSV.TabIndex = 18;
            this.btnDSSV.Text = "Hiển thị/Ẩn danh sách sinh viên";
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Enabled = false;
            this.btnDiemDanh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDiemDanh.Image = global::DiemDanhSinhVien.Properties.Resources.Open_folder_accept_icon;
            this.btnDiemDanh.Location = new System.Drawing.Point(259, 21);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(169, 49);
            this.btnDiemDanh.TabIndex = 17;
            this.btnDiemDanh.Text = "Bắt đầu điểm danh";
            this.btnDiemDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chi tiết điểm danh";
            // 
            // dgv_dshocsinh
            // 
            this.dgv_dshocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dshocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgv_dshocsinh.Location = new System.Drawing.Point(325, 297);
            this.dgv_dshocsinh.Name = "dgv_dshocsinh";
            this.dgv_dshocsinh.Size = new System.Drawing.Size(683, 275);
            this.dgv_dshocsinh.TabIndex = 18;
            this.dgv_dshocsinh.Visible = false;
            this.dgv_dshocsinh.SelectionChanged += new System.EventHandler(this.dgv_dshocsinh_SelectionChanged);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MASV";
            this.Column7.HeaderText = "MÃ SINH VIÊN";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TENSV";
            this.Column8.HeaderText = "TÊN SINH VIÊN";
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NGAYSINH";
            this.Column9.HeaderText = "NGÀY SINH";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GIOITINH";
            this.Column10.HeaderText = "GIỚI TINH";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "LOPNIENCHE";
            this.Column11.HeaderText = "LỚP NIÊN CHẾ";
            this.Column11.Name = "Column11";
            this.Column11.Width = 130;
            // 
            // frmDiemdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 609);
            this.Controls.Add(this.dgv_dshocsinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiemdanh";
            this.Text = "frmDiemdanh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnl_chitietdiemdanh.ResumeLayout(false);
            this.pnl_chitietdiemdanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dshocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGiangvien;
        private System.Windows.Forms.DataGridView dgv_dslop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnl_chitietdiemdanh;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTieptuc;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.TextBox txtLydo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDSSV;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_dshocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private NumericTextbox.NumericTextBox txtSotietvang;

    }
}