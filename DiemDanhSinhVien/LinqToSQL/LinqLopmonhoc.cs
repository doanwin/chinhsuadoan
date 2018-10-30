using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinqLopmonhoc
    {
        qlDiemdanhsvDataContext qldd = new qlDiemdanhsvDataContext();
        public List<LOPMONHOC> GetDataLopByMaGV(string pMAGv)
        {
            return qldd.LOPMONHOCs.Where(t => t.MAGV == pMAGv).ToList<LOPMONHOC>();
        }
        public List<LOPMONHOC> loadLop()
        {
            return qldd.LOPMONHOCs.Select(t=>t).ToList<LOPMONHOC>();
        }
        public LOPMONHOC layLopHoc(string maLop)
        {
            return qldd.LOPMONHOCs.Where(t => t.MALOPMONHOC == maLop).FirstOrDefault();
        }
        bool ktKhoaChinh(string pMaLop)
        {
            var lop = qldd.LOPMONHOCs.Where(t => t.MALOPMONHOC == pMaLop).FirstOrDefault();
            if (lop != null)
            {
                return true;
            }
            return false;
        }
        public int themLop(LOPMONHOC lop)
        {
            if (ktKhoaChinh(lop.MALOPMONHOC))
            {
                return 2;
            }
            try
            {
                qldd.LOPMONHOCs.InsertOnSubmit(lop);
                qldd.SubmitChanges();
                return 1;
            }
            catch 
            {
                return 0;
            }
        }
        public int xoaLop(string  malop)
        {
            List<LOPMONHOC> listlop = loadLop();
            foreach (LOPMONHOC item in listlop)
            {
                if (item.MALOPMONHOC == malop)
                {
                    qldd.LOPMONHOCs.DeleteOnSubmit(item);
                    qldd.SubmitChanges();
                    return 1;
                }
            }
            return 0;
        }
    }
}
