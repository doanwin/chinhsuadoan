using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_DM_ManHinh
    {
        DAL_DMManhinh manhinh = new DAL_DMManhinh();
        public DataTable loadDsManHinh()
        {
            return manhinh.loadDsManhinh();
        }
        public void InsertQuery(string TenManHinh)
        {
            manhinh.InsertQuery(TenManHinh);
        }
    } 
}
