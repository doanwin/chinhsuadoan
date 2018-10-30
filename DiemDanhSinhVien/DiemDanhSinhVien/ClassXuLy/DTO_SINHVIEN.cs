using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanhSinhVien.ClassXuLy
{
    public class DTO_SINHVIEN
    {
        string mASV, tENSV, lOPNIENCHE;

        public string LOPNIENCHE
        {
            get { return lOPNIENCHE; }
            set { lOPNIENCHE = value; }
        }

        public string TENSV
        {
            get { return tENSV; }
            set { tENSV = value; }
        }

        public string MASV
        {
            get { return mASV; }
            set { mASV = value; }
        }
        bool gIOITINH;

        public bool GIOITINH
        {
            get { return gIOITINH; }
            set { gIOITINH = value; }
        }


        DateTime? nGAYSINH;

        public DateTime? NGAYSINH
        {
            get { return nGAYSINH; }
            set { nGAYSINH = value; }
        }
        public DTO_SINHVIEN(DataRow row)
        {
            this.MASV = row["MASV"].ToString();
            this.TENSV = row["TENSV"].ToString();
            var ngaysinhtemp = row["NGAYSINH"];
            if (ngaysinhtemp.ToString() != "")
                this.NGAYSINH = (DateTime?)ngaysinhtemp;
            this.GIOITINH=Convert.ToBoolean( row["GIOITINH"]);
            this.LOPNIENCHE = row["LOPNIENCHE"].ToString();
                
        }
        public DTO_SINHVIEN(string masv, string tensv, DateTime? ngaysinh, bool gioitinh, string lopnienche)
        {
            this.MASV = masv;
            this.TENSV = tensv;
            this.NGAYSINH = ngaysinh;
            this.GIOITINH = gioitinh;
            this.LOPNIENCHE = lopnienche;
        }
        public DTO_SINHVIEN() { }
    }
}
