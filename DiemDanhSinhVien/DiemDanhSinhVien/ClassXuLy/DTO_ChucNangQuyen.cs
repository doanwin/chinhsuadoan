using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DTO_ChucNangQuyen
    {
        private string maManHinh, tenManHinh;

        public string TenManHinh
        {
            get { return tenManHinh; }
            set { tenManHinh = value; }
        }

        public string MaManHinh
        {
            get { return maManHinh; }
            set { maManHinh = value; }
        }
        private int coQuyen;

        public int CoQuyen
        {
            get { return coQuyen; }
            set { coQuyen = value; }
        }
        public DTO_ChucNangQuyen(DataRow row)
        {
            this.MaManHinh = row["MaManhHinh"].ToString();
            this.TenManHinh = row["TenManHinh"].ToString();
            this.CoQuyen =(int)row["CoQuyen"];
                
        }
    }
}
