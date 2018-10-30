using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_SINHVIEN_HOC
    {
        DAL_SINHVIEN_HOC sv_hoc = new DAL_SINHVIEN_HOC();
        public DataTable GetDataByMaLop(string malop)
        {
            return sv_hoc.GetDataByMaLop(malop);
        }
    }
}
