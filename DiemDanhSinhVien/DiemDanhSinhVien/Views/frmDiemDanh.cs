using DiemDanhSinhVien.ClassXuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToSQL;
using BLL;
using System.Collections;

namespace DiemDanhSinhVien.Views
{
    public partial class frmDiemdanh : Form
    {
        BLL_SINHVIEN_HOC sv_hoc = new BLL_SINHVIEN_HOC();
        LinqLopmonhoc linqLop = new LinqLopmonhoc();
        LinqGiaovien linqGv = new LinqGiaovien();
        BLL_DiemDanh diemdanhbll = new BLL_DiemDanh();
        BLL_CHITIETDIEMDANH chitietBLL = new BLL_CHITIETDIEMDANH();
        private DTO_NguoiDung nguoiDung;
        private GIANGVIEN giangVien;
        private List<DTO_SINHVIEN> listSV = new List<DTO_SINHVIEN>();
        private int i;
        private DTO_SINHVIEN sinhvien = new DTO_SINHVIEN();
        private string MaLop = "";

        public GIANGVIEN GiangVien
        {
            get { return giangVien; }
            set { giangVien = value; }
        }

        public DTO_NguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; }
        }
        public frmDiemdanh()
        {
            InitializeComponent();
        }
        public frmDiemdanh(DTO_NguoiDung nguoidung)
        {
            InitializeComponent();
            this.NguoiDung = nguoidung;
            layGiangVienByTenDangNhap();
            loadDsLopByMaGV(GiangVien.MAGV);
        }
        public void layGiangVienByTenDangNhap()
        {
            GIANGVIEN gv=linqGv.getGiangVienByTenDangNhap(NguoiDung.TenDangNhap);
            if (gv != null)
            {
                GiangVien = linqGv.getGiangVienByTenDangNhap(NguoiDung.TenDangNhap);
                lblGiangvien.Text = GiangVien.HOTEN;
            }
            else
                return;
        }
        void loadDsLopByMaGV(string pMAGv)
        {
            dgv_dslop.DataSource = linqLop.GetDataLopByMaGV(pMAGv);
        }
        void loadDsSvThuocLop(string MaLop)
        {
            dgv_dshocsinh.DataSource = sv_hoc.GetDataByMaLop(MaLop);
            
        }
        void add(string MaLop)
        {
            DataTable table = sv_hoc.GetDataByMaLop(MaLop);
            foreach (DataRow item in table.Rows)
            {
                DTO_SINHVIEN sv = new DTO_SINHVIEN(item);
                listSV.Add(sv);
            }
        }

        private void dgv_dslop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    MaLop = dgv_dslop.Rows[e.RowIndex].Cells[0].Value.ToString();
                    loadDsSvThuocLop(MaLop);
                    btnDiemDanh.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("lớp chưa được phân công");
                }
            }
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            if (dgv_dshocsinh.Visible == true)
                dgv_dshocsinh.Visible = false;
            else
                dgv_dshocsinh.Visible = true;
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            btnDiemDanh.Enabled = false;
            int LANDIEMDANH=diemdanhbll.soLanDiemdanhcuaGV(GiangVien.MAGV)+1;
            int them=diemdanhbll.InsertDiemDanh(GiangVien.MAGV,DateTime.Now,LANDIEMDANH);
            if (them != 0)
            {
                pnl_chitietdiemdanh.Enabled = true;
                lblTenSV.Visible = true;
                add(MaLop);
                i = 0;
                sinhvien = listSV[i];
                lblTenSV.Text = listSV[i].TENSV;
            }
            else
                MessageBox.Show("Lỗi. Không điểm danh được");
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = 0;
                return;            }
            sinhvien = listSV[i];
            lblTenSV.Text = listSV[i].TENSV;
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= listSV.Count)
            {
                i = listSV.Count - 1;
                return;
            }
            sinhvien = listSV[i];
            lblTenSV.Text = listSV[i].TENSV;
        }

        private void dgv_dshocsinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_dshocsinh.CurrentCell.RowIndex;
                lblTenSV.Text = dgv_dshocsinh.Rows[r].Cells[1].Value.ToString();
            }
            catch 
            {
                
            }
            
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int id=diemdanhbll.layIDDiemDanhCuaGV(GiangVien.MAGV);
            if(id==0)
                return;
            int IDDIEMDANH =id ;
            string MASV = sinhvien.MASV;
            int SOTIETVANG = 0;
            try
            {
                SOTIETVANG = int.Parse(txtSotietvang.Text);
            }
            catch 
            {
                SOTIETVANG = 0;
            }
            
            string LYDO = txtLydo.Text;
            int insert = chitietBLL.Insert(IDDIEMDANH, MASV, SOTIETVANG, LYDO);
            if (insert != 0)
            {
                MessageBox.Show("Điểm danh thành công");
                sinhvien = listSV[i + 1];
                lblTenSV.Text = sinhvien.TENSV;
                txtSotietvang.Text = "";
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
