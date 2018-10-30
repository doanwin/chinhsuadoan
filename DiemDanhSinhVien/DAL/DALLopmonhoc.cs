using DAL.qldiemdanhsvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLopmonhoc
    {
        LOPMONHOCTableAdapter lop = new LOPMONHOCTableAdapter();

        public DataTable load()
        {
            return lop.GetData();
        }
        public DataTable GetDataByMaGV(string magv)
        {
            return lop.GetDataBy(magv);
        }
    }
}
