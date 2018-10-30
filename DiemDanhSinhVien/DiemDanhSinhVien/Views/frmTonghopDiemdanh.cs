using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DiemDanhSinhVien.ClassXuLy;
using LinqToSQL;

namespace DiemDanhSinhVien.Views
{
    public partial class frmTonghopDiemdanh : Form
    {
        BLLSinhvien sinhvienBLL = new BLLSinhvien();
        LinqLopmonhoc loplq = new LinqLopmonhoc();
        LinqGiaovien linqGv = new LinqGiaovien();
        private GIANGVIEN giangVien;

        public GIANGVIEN GiangVien
        {
            get { return giangVien; }
            set { giangVien = value; }
        }
        private DTO_NguoiDung nguoiDung;

        public DTO_NguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; }
        }
        BLLLopmonhoc lopBLL = new BLLLopmonhoc();
        public frmTonghopDiemdanh(DTO_NguoiDung nguoidung)
        {
            InitializeComponent();
            this.NguoiDung = nguoidung;
            layGiangVienByTenDangNhap();
            loadCboLopByMagv(GiangVien.MAGV);
        }
        public void layGiangVienByTenDangNhap()
        {
            GIANGVIEN gv = linqGv.getGiangVienByTenDangNhap(NguoiDung.TenDangNhap);
            if (gv != null)
            {
                GiangVien = linqGv.getGiangVienByTenDangNhap(NguoiDung.TenDangNhap);
            }
            else
                return;
        }
        void loadCboLopByMagv(string magv)
        {
            cbo_chonlop.DataSource = loplq.GetDataLopByMaGV(magv);
            cbo_chonlop.DisplayMember = "TenLop";
            cbo_chonlop.ValueMember = "MaLopMonHoc";
        }
        void loadSinhVienTuDieuLieuDiemDanhByMaLop(string malop)
        {
            dgv_dulieudiemdanh.DataSource = sinhvienBLL.GetDataByMaLop(malop);
        }

        private void cbo_chonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string malop = cbo_chonlop.SelectedValue.ToString();
                loadSinhVienTuDieuLieuDiemDanhByMaLop(malop);
            }
            catch
            {

            }
        }
    }
}
