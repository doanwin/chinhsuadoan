using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DALGiangvien
    {
        GIANGVIEN1TableAdapter atp_giangvien = new GIANGVIEN1TableAdapter();
        public DataTable GetData()
        {
            return atp_giangvien.GetData();
        }
    }
}
