using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DiemDanh
    {
        DAL_DiemDanh diemdanh = new DAL_DiemDanh();
        public int InsertDiemDanh(string MAGV, DateTime? NGAYDIEMDANH, int LANDIEMDANH)
        {
            return diemdanh.InsertDiemDanh(MAGV, NGAYDIEMDANH, LANDIEMDANH);
        }
        public int soLanDiemdanhcuaGV(string magv)
        {
            return diemdanh.soLanDiemdanhcuaGV(magv);
        }
        public int layIDDiemDanhCuaGV(string magv)
        {
            object o = diemdanh.layIDDiemDanhCuaGV(magv);
            if (o == null)
                return 0;
            else
                return (int)o;
        }
    }
}
