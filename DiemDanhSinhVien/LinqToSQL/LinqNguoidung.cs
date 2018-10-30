using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinqNguoidung
    {
        qlDiemdanhsvDataContext qldd = new qlDiemdanhsvDataContext();
        public QL_NguoiDung getNguoiDung(string TenDangNhap)
        {
            return qldd.QL_NguoiDungs.Where(t=>t.TenDangNhap==TenDangNhap).FirstOrDefault();
        }
        public int updateNguoidung(QL_NguoiDung nguoidung)
        {
            QL_NguoiDung ng = qldd.QL_NguoiDungs.Where(t => t.TenDangNhap == nguoidung.TenDangNhap).FirstOrDefault();
            if (ng != null)
            {
                ng.TenDangNhap = nguoidung.TenDangNhap;
                ng.MatKhau = nguoidung.MatKhau;
                ng.HoatDong = ng.HoatDong;
                qldd.SubmitChanges();
                return 1;
            }
            else
                return 0;
        }
        public int ktNguoidung(QL_NguoiDung nguoidung)
        {
            var ng = qldd.QL_NguoiDungs.Where(t => t.TenDangNhap == nguoidung.TenDangNhap && t.MatKhau == nguoidung.MatKhau).FirstOrDefault();
            if (ng != null)
            {
                return 1;
            }
            return 0;
        }
    }
}
