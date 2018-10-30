using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_DULIEUDIEMDANH
    {
        DULIEUDIEMDANHTableAdapter atp_dulieu = new DULIEUDIEMDANHTableAdapter();
        public DataTable GetDataByMaLop(string malop)
        {
            return atp_dulieu.GetData(malop);
        }
    }
}
