using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;

namespace DAL
{
    public class DAL_DiemDanh
    {
        DIEMDANHTableAdapter atp_diemdanh = new DIEMDANHTableAdapter();
        public int InsertDiemDanh(string MAGV,DateTime? NGAYDIEMDANH,int LANDIEMDANH)
        {
            return atp_diemdanh.InsertDiemDanh(MAGV, NGAYDIEMDANH, LANDIEMDANH);
        }
        public int soLanDiemdanhcuaGV(string magv)
        {
            return (int)atp_diemdanh.getSoLanDiemDanhByGV(magv);
        }
        public int layIDDiemDanhCuaGV(string magv)
        {
            object o = atp_diemdanh.LayIDDiemDanhCuaGV(magv);
            if (o == null)
                return 0;
            else 
                return (int)o;
        }
    }
}
