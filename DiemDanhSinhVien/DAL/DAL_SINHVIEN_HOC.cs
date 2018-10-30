using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_SINHVIEN_HOC
    {
        SINHVIEN_HOCTableAdapter atp_sv_hoc = new SINHVIEN_HOCTableAdapter();
        public DataTable GetDataByMaLop(string malop)
        {
            return atp_sv_hoc.GetData(malop);
        }
    }
}
