using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLchung
    {
        DALchung dalchung = new DALchung();
        public DataTable GetDataDonvi()
        {
            return dalchung.GetDataDonvi();
        }
    }
}
