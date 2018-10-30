using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DiemDanhSinhVien.ClassXuLy;
using DiemDanhSinhVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using LinqToSQL;

namespace DiemDanhSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLL_NguoidungNhomnguoidung nguoidungnhom = new BLL_NguoidungNhomnguoidung();
        BLL_Nhomnguoidung nhomnguoidung = new BLL_Nhomnguoidung();
        BLL_QuyenChucNang quyen = new BLL_QuyenChucNang();
        BLL_DM_ManHinh manhinh = new BLL_DM_ManHinh();
        LinqGiaovien linqGv = new LinqGiaovien();
        LinqNguoidung linqnguoiDung = new LinqNguoidung();
        private QL_NguoiDung lqnguoiDung;

        public QL_NguoiDung LqnguoiDung
        {
            get { return lqnguoiDung; }
            set { lqnguoiDung = value; }
        }
        private DTO_NguoiDung nguoiDung;

        public DTO_NguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; }
        }
        public frmMain(DTO_NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.NguoiDung = nguoiDung;
            LqnguoiDung = linqnguoiDung.getNguoiDung(NguoiDung.TenDangNhap);
        }


        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var from = new frmPhanquyennguoidung();
            if (ExistForm(from))
                return;
            from.MdiParent = this;
            from.Show();
        }
        private void btnDSCahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmCaHoc();

            if (ExistForm(form))
                return;

            form.MdiParent = this;
            form.Show();
        }
        public bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if(child.Name==form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnTheodoidiemdanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmDiemdanh(NguoiDung);
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnChitietgiangvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmGiaoVien();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnChitietSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmSinhVien();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnBaocaotinhtrang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmBaoCaoTinhTrang();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            stt_ngaygio.Caption = DateTime.Now.ToString();
            stt_user.Caption = "Xin chào, " + NguoiDung.TenDangNhap;
            GIANGVIEN gv = linqGv.getGiangVienByTenDangNhap(NguoiDung.TenDangNhap);
            if (gv != null)
            {
                return;
            }
            else
            {
                btnTheodoidiemdanh.Enabled = false;
            }
            PhanQuyen();
        }
        private void btnDanhsachlophoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form1 = new frmLopMonHoc();
            if (ExistForm(form1))
                return;
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatkhau doimatkhau = new frmDoiMatkhau(LqnguoiDung);
            doimatkhau.ShowDialog();
            
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fmDuLieudiemdanh = new frmTonghopDiemdanh(NguoiDung);
            if (ExistForm(fmDuLieudiemdanh))
                return;
            fmDuLieudiemdanh.MdiParent = this;
            fmDuLieudiemdanh.Show();
        }

        private void btnDSLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmLopMonHoc();
            if (ExistForm(form))
                return;
            form.MdiParent = this;
            form.Show();
        }
        //Phân quyền 
        void test()
        {
            DataTable tableQuyen = quyen.layManHinhCoQuyen("admin");
            foreach (DataRow rowquyen in tableQuyen.Rows)
            {
                DTO_ChucNangQuyen quyenchucnang = new DTO_ChucNangQuyen(rowquyen);
                foreach (BarButtonItem button in ribbonControl1.Items)
                {
                    if (button.GetType() == typeof(BarButtonItem))
                    {
                        if (quyenchucnang.TenManHinh == button.Caption)
                        {
                            button.Enabled = false;
                            break;
                        }
                    }
                }
            }
        }
        private void PhanQuyen()
        {
            List<DTO_NhomNguoiDung> listNhom = new List<DTO_NhomNguoiDung>();
            DataTable tableNhom = nguoidungnhom.laynhom(NguoiDung.TenDangNhap);
            foreach (DataRow item in tableNhom.Rows)
            {
                DTO_NhomNguoiDung nhom = new DTO_NhomNguoiDung(item);
                listNhom.Add(nhom);
            }
            foreach (DTO_NhomNguoiDung item in listNhom)
            {
                DataTable tableQuyen = quyen.layManHinhCoQuyen(item.MaNhom);
                foreach (DataRow rowquyen in tableQuyen.Rows)
                {
                    DTO_ChucNangQuyen quyenchucnang = new DTO_ChucNangQuyen(rowquyen);
                    foreach (BarButtonItem button in ribbonControl1.Items)
                    {
                        if (button.GetType() == typeof(BarButtonItem))
                        {
                            if (quyenchucnang.TenManHinh == button.Caption)
                            {
                                button.Enabled = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

    }
}
