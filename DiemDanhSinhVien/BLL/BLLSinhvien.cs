using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLSinhvien
    {
        DAL_DULIEUDIEMDANH dulieu = new DAL_DULIEUDIEMDANH();
        
        public DataTable GetDataByMaLop(string malop)
        {
            return dulieu.GetDataByMaLop(malop);
        }
    }
}
