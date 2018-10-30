using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_QL_PhanQuyen
    {
        QL_PhanQuyenTableAdapter atp_phanquyen = new QL_PhanQuyenTableAdapter();
        public DataTable selectPhanquyen(string manhom)
        {
            return atp_phanquyen.GetDataBy1(manhom);
        }
        public int insertPhanquyen(string MaNhomNguoiDung, string MaManhHinh)
        {
            return atp_phanquyen.insertPhanquyen(MaNhomNguoiDung,MaManhHinh);
        }
        public int deletePhanquyen(string manhom,string mamanhinh)
        {
            return atp_phanquyen.DeletePhanquyen(manhom, mamanhinh);
        }
        public int updatePhanquyen(int coquyen,string mamanhinh,string manhom)
        {
            return atp_phanquyen.updatePhanquyen(coquyen, mamanhinh, manhom);
        }
        public DataTable layDsManHinhCoQuyen(int? coquyen,string manhom)
        {
            return atp_phanquyen.layDsManHinhCoQuyen(coquyen, manhom);
        }
    }
}
