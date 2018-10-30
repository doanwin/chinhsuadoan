using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_NguoiDung
    {
        QL_NguoiDungTableAdapter atp_Nguoidung = new QL_NguoiDungTableAdapter();
        
        public DataTable loadNguoidung()
        {
             return atp_Nguoidung.GetData();

        }
        public int themNguoidung(string pTendangnhap,string pMatkhau)
        {
            return atp_Nguoidung.InsertQuery(pTendangnhap, pMatkhau);
        }
        public int updateNguoidung(string pMatkhau, int? HoatDong, string Tendangnhap)
        {
            return atp_Nguoidung.UpdateQuery(pMatkhau, HoatDong, Tendangnhap);
        }
        public int xoaNguoidung(string pTenDangNhap)
        {
            return atp_Nguoidung.deleteNguoidung(pTenDangNhap);
        }
        public DataTable getNguoiDungByTen(string TenDangNhap)
        {
            return atp_Nguoidung.GetDataBy1(TenDangNhap);
        }
    }
}
