using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DTO_NguoiDung
    {
        public DTO_NguoiDung(string tendangnhap, string matkhau, int hoatdong)
        {
            TenDangNhap = tendangnhap;
            MatKhau = matkhau;
            HoatDong = hoatdong;
        }
        public DTO_NguoiDung(DataRow row)
        {
            this.TenDangNhap=row[0].ToString();
            this.MatKhau = row[1].ToString();
            this.HoatDong =(int)( row[2]);
        }
        private string tenDangNhap, matKhau;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }


        private int hoatDong;

        public int HoatDong
        {
            get { return hoatDong; }
            set { hoatDong = value; }
        }

        
        public DTO_NguoiDung()
        { }
    }
}
