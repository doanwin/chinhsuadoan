using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLLLopmonhoc
    {
        DALLopmonhoc lop = new DALLopmonhoc();

        public DataTable load()
        {
            return lop.load();
        }
        public DataTable GetDataByMaGV(string magv)
        {
            return lop.GetDataByMaGV(magv);
        }
    }
}
