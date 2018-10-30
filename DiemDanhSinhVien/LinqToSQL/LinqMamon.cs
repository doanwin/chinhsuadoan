using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToSQL;

namespace LinqToSQL
{
    public class LinqMamon
    {
        qlDiemdanhsvDataContext qldd = new qlDiemdanhsvDataContext();
        public List<MONHOC> loadMonHoc()
        {
            return qldd.MONHOCs.Select(t=>t).ToList<MONHOC>();
        }
        
    }
}
