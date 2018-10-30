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

namespace DiemDanhSinhVien.Views
{
    public partial class frmPhanquyen : Form
    {
        BLL_DM_ManHinh manhinhBLL = new BLL_DM_ManHinh();
        BLL_Phanquyen phanquyenBLL = new BLL_Phanquyen();
        BLL_QuyenChucNang quyenchucnangBLL = new BLL_QuyenChucNang();
        private string maNhom, maManHinh;
        private string maManHinhChon;

        public string MaManHinhChon
        {
            get { return maManHinhChon; }
            set { maManHinhChon = value; }
        }

        public string MaManHinh
        {
            get { return maManHinh; }
            set { maManHinh = value; }
        }

        public string MaNhom
        {
            get { return maNhom; }
            set { maNhom = value; }
        }

        public frmPhanquyen()
        {
            InitializeComponent();
            
        }
        public frmPhanquyen(string manhom)
        {
            InitializeComponent();
            loadDSManhinh();
            this.MaNhom = manhom;
            lblTenNhom.Text = MaNhom;
        }
        void loadDSManhinh()
        {
            dgv_dsmanhinh.DataSource = manhinhBLL.loadDsManHinh();
        }
        void loadDSManhinhDuocChon(string manhom)
        {
            dgv_dsduocchon.DataSource = quyenchucnangBLL.GetDataQuyenChucNang(manhom);
        }
        private void frmPhanquyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.DM_ManHinh' table. You can move, or remove it, as needed.
            this.dM_ManHinhTableAdapter.Fill(this.qldiemdanhsvDataSet.DM_ManHinh);
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.qldiemdanhsvDataSet.QL_NhomNguoiDung);
            
        }

        private void dgv_dsmanhinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_dsmanhinh.CurrentCell.RowIndex;
                MaManHinh = dgv_dsmanhinh.Rows[r].Cells[0].Value.ToString();
                loadDSManhinhDuocChon(MaNhom);
            }
            catch
            {
                
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int them = phanquyenBLL.insertPhanquyen(MaNhom, MaManHinh);
                loadDSManhinhDuocChon(MaNhom);
            }
            catch 
            {
                MessageBox.Show("Quyền đã được chọn. Vui lòng kiểm tra lại");
            }

        }

        private void btnPushall_Click(object sender, EventArgs e)
        {

        }
        
        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                int xoa = phanquyenBLL.deletePhanquyen(MaNhom, MaManHinhChon);
                loadDSManhinhDuocChon(MaNhom);
            }
            catch 
            {
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (updateBangphanquyen != null)
            {
                updateBangphanquyen(this, e);
            }
        }


        #region Tạo Event
        private event EventHandler updateBangphanquyen;
        public event EventHandler UpdateBangphanquyen
        {
            add { updateBangphanquyen+=value;}
            remove { updateBangphanquyen += value; }
        }

        #endregion

        private void dgv_dsduocchon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dsduocchon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_dsduocchon.CurrentCell.RowIndex;
                MaManHinhChon = dgv_dsduocchon.Rows[r].Cells[0].Value.ToString();
            }
            catch 
            {
                
            }
            

        }





    }
}
