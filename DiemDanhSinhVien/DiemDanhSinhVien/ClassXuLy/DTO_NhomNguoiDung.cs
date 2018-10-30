using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DTO_NhomNguoiDung
    {
        string maNhom, tenNhom, ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public string TenNhom
        {
            get { return tenNhom; }
            set { tenNhom = value; }
        }

        public string MaNhom
        {
            get { return maNhom; }
            set { maNhom = value; }
        }
        public DTO_NhomNguoiDung(DataRow row)
        {
            this.MaNhom=row[0].ToString();
            this.TenNhom = row[1].ToString();
            this.GhiChu = (row[2]).ToString() ;
        }
    }
}
