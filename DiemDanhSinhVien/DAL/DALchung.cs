using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;
namespace DAL
{
    public class DALchung
    {
        DONVITableAdapter atp_dv = new DONVITableAdapter();
        public DataTable GetDataDonvi()
        {
            return atp_dv.GetData();
        }
    }
}
