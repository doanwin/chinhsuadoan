using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToSQL;

namespace DiemDanhSinhVien.Views
{
    public partial class frmLopMonHoc : Form
    {
        LinqLopmonhoc lopLQ = new LinqLopmonhoc();
        LinqGiaovien gvLQ = new LinqGiaovien();
        public frmLopMonHoc()
        {
            InitializeComponent();
            loadDSLop();
            loadCboGv();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LOPMONHOC lop = new LOPMONHOC();
            lop.MALOPMONHOC = txtMalopmonhoc.Text;
            lop.TENLOP = txtTenlophoc.Text;
            lop.MAGV = cbmMagiangvien.SelectedValue.ToString();
            lop.MAMON = cbomamon.SelectedValue.ToString();
            int them = lopLQ.themLop(lop);
            if (them == 1)
            {
                MessageBox.Show("Thêm thành công");
                loadDSLop();
            }
            else if (them == 0)
            {
                MessageBox.Show("Thất bại");
            }
            else
                MessageBox.Show("Lớp đa tồn tạo. Vui lòng kiểm tra lại");
        }
        void loadDSLop()
        {
            dgvLopmonhoc.DataSource = lopLQ.loadLop();
        }
        void loadCboGv()
        {
            cbmMagiangvien.DataSource = gvLQ.GetData();
            cbmMagiangvien.DisplayMember = "TenGv";
            cbmMagiangvien.ValueMember = "MaGV";
        }
        string malop = "";
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             
        }

        private void dgvLopmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                malop = dgvLopmonhoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
