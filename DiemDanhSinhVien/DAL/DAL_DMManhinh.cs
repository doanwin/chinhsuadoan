using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_DMManhinh
    {
        DM_ManHinhTableAdapter atp_manhinh = new DM_ManHinhTableAdapter();
        public DataTable loadDsManhinh()
        {
            return atp_manhinh.GetData();
        }
        public void InsertQuery(string TenManHinh)
        {
            atp_manhinh.InsertQuery(TenManHinh);
        }
    }
}
