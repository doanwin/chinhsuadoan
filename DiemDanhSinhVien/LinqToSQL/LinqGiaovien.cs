using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinqGiaovien
    {
        qlDiemdanhsvDataContext qldd = new qlDiemdanhsvDataContext();
        public List<GIANGVIEN> GetData()
        {
            return qldd.GIANGVIENs.Select(t => t).ToList<GIANGVIEN>();
        }
        public GIANGVIEN getGiangVienByTenDangNhap(string TenDangNhap)
        {
            return qldd.GIANGVIENs.Where(t => t.TenDangNhap == TenDangNhap).FirstOrDefault();
        }

        public GIANGVIEN getGiangvien(string MaGv)
        {   
            return qldd.GIANGVIENs.Where(t => t.MAGV == MaGv).FirstOrDefault();

        }
        private bool ktraKhoachinh(string MaGv)
        {
            var kt=qldd.GIANGVIENs.Where(t=>t.MAGV ==MaGv).FirstOrDefault();
            if(kt!=null)
                return true;
            return false;
        }
        public int themGiangvien(GIANGVIEN gv)
        {
            try
            {
                if (ktraKhoachinh(gv.MAGV))
                    return 2;
                qldd.GIANGVIENs.InsertOnSubmit(gv);
                qldd.SubmitChanges();
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public int suaGiangvien(GIANGVIEN gv)
        {
            GIANGVIEN gvhientai = getGiangvien(gv.MAGV);
            if (gvhientai != null)
            {
                gvhientai.HOTEN = gv.HOTEN;
                gvhientai.MADONVI = gv.MADONVI;
                gv.TRINHDO = gv.TRINHDO;
                gv.CHUYENMON = gv.CHUYENMON;
                qldd.SubmitChanges();
                return 1;
            }
            return 0;
        }
        
    }
}
