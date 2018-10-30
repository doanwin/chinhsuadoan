using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_NguoiDung
    {
        DAL_NguoiDung nguoidung = new DAL_NguoiDung();
        
        public DataTable loadNguoidung()
        {
            return nguoidung.loadNguoidung();
        }
        public int themNguoidung(string pTendangnhap, string pMatkhau)
        {
            return nguoidung.themNguoidung(pTendangnhap, pMatkhau);
        }
        public int updateNguoidung(string pMatkhau, int? HoatDong, string Tendangnhap)
        {
            return nguoidung.updateNguoidung(pMatkhau, HoatDong, Tendangnhap);
        }
        public int xoaNguoidung(string pTenDangNhap)
        {
            return nguoidung.xoaNguoidung(pTenDangNhap);
        }
        public DataTable getNguoiDungByTen(string TenDangNhap)
        {
            return nguoidung.getNguoiDungByTen(TenDangNhap);
        }
    }
}
