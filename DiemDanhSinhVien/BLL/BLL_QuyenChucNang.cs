using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_QuyenChucNang
    {
        DAL_QuyenChucNang quyenchucnang = new DAL_QuyenChucNang();
        public DataTable GetDataQuyenChucNang(string manhom)
        {
            return quyenchucnang.GetDataQuyenChucNang(manhom);
        }
        public DataTable layManHinhCoQuyen(string manhom)
        {
            return quyenchucnang.layManHinhCoQuyen(manhom);
        }
    }
}
