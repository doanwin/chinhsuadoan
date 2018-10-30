using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_Phanquyen
    {
        DAL_QL_PhanQuyen phanquyen = new DAL_QL_PhanQuyen();
        public DataTable selectPhanquyen(string manhom)
        {
            return phanquyen.selectPhanquyen(manhom);
        }
        public int insertPhanquyen(string MaNhomNguoiDung, string MaManhHinh)
        {
            return phanquyen.insertPhanquyen(MaNhomNguoiDung, MaManhHinh);
        }
        public int deletePhanquyen(string manhom, string mamanhinh)
        {
            return phanquyen.deletePhanquyen(manhom, mamanhinh);
        }
        public int updatePhanquyen(int coquyen, string mamanhinh, string manhom)
        {
            return phanquyen.updatePhanquyen(coquyen, mamanhinh, manhom);
        }
        public DataTable layDsManHinhCoQuyen(int? coquyen, string manhom)
        {
            return phanquyen.layDsManHinhCoQuyen(coquyen, manhom);
        }
    }
}
