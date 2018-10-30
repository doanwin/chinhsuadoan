using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using LinqToSQL;

namespace DiemDanhSinhVien.Views
{
    public partial class frmGiaoVien : Form
    {
        BLLGiangvien gv = new BLLGiangvien();
        BLLchung chungbll = new BLLchung();
        LinqGiaovien lqGiaovien = new LinqGiaovien();

        public frmGiaoVien()
        {
            InitializeComponent();
            loadGiaoVien();
            loadCbo_Donvi();
        }

        void loadGiaoVien()
        {
            dgv_giaovien.DataSource = gv.GetData();
        }
        void loadCbo_Donvi()
        {
            cbo_madv.DataSource = chungbll.GetDataDonvi();
            cbo_madv.DisplayMember = "TENDONVI";
            cbo_madv.ValueMember = "MaDonVi";
        }


        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.DONVI' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
           // this.gIANGVIENTableAdapter.Fill(this.qldiemdanhsvDataSet.GIANGVIEN);

        }

        private void dgv_giaovien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_giaovien.CurrentCell.RowIndex;
                txtMaGv.Text = dgv_giaovien.Rows[r].Cells[0].Value.ToString();
                cbo_madv.Text = dgv_giaovien.Rows[r].Cells[1].Value.ToString();
                txtHoten.Text = dgv_giaovien.Rows[r].Cells[2].Value.ToString();
                txtTrinhdo.Text = dgv_giaovien.Rows[r].Cells[3].Value.ToString();
                txtchuyemon.Text = dgv_giaovien.Rows[r].Cells[4].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GIANGVIEN gv = new GIANGVIEN();
            gv.MAGV = txtMaGv.Text.Trim();
            gv.HOTEN = txtHoten.Text.Trim();
            gv.MADONVI = cbo_madv.SelectedValue.ToString();
            gv.TRINHDO = txtTrinhdo.Text.Trim();
            gv.CHUYENMON = txtchuyemon.Text.Trim();
            int them = lqGiaovien.themGiangvien(gv);
            if (them == 1)
            {
                MessageBox.Show("Thêm thành công");
                loadGiaoVien();
            }
            else if (them == 0)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            else
                MessageBox.Show("Giáo viên đã tồn tại.Vui lòng kt lại");
        }


       
    }
}
