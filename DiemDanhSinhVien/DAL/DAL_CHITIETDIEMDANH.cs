using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;

namespace DAL
{
    public class DAL_CHITIETDIEMDANH
    {
        CHITIETDIEMDANHTableAdapter atp_ctdd = new CHITIETDIEMDANHTableAdapter();
        public int Insert(int IDDIEMDANH,string MASV,int? SOTIETVANG,string LYDO)
        {
            return atp_ctdd.Insert(IDDIEMDANH, MASV, SOTIETVANG, LYDO);
        }
    }

}
