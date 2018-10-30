using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_CHITIETDIEMDANH
    {
        DAL_CHITIETDIEMDANH chitietdd = new DAL_CHITIETDIEMDANH();
        public int Insert(int IDDIEMDANH, string MASV, int? SOTIETVANG, string LYDO)
        {
            return chitietdd.Insert(IDDIEMDANH, MASV, SOTIETVANG, LYDO);
        }
    }
}
