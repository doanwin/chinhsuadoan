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
using DiemDanhSinhVien.ClassXuLy;

namespace DiemDanhSinhVien.Views
{
    public partial class frmPhanquyennguoidung : Form
    {
        BLL_Nhomnguoidung nhomnguoidungbll = new BLL_Nhomnguoidung();
        BLL_NguoidungNhomnguoidung NDNNDbll = new BLL_NguoidungNhomnguoidung();
        BLL_NguoiDung nguoidungBll = new BLL_NguoiDung();
        BLL_themnguoidungvaonhom themBLL = new BLL_themnguoidungvaonhom();
        BLL_QuyenChucNang quyenchucnangBll = new BLL_QuyenChucNang();
        BLL_Phanquyen phanquyen = new BLL_Phanquyen();
        private int hoatdong = 0;

        private string tentaikhoan="";

        private string maNhom;

        public string MaNhom
        {
            get { return maNhom; }
            set { maNhom = value; }
        }

        public frmPhanquyennguoidung()
        {
            InitializeComponent();
            loadCbo_Nhomnguoidung();
            loadNguoidung();
            loadNhomNguoidung();
        }
        #region hàm load
        void loadNhomNguoidung()
        {
            dgv_1.DataSource = nhomnguoidungbll.loadNhomnguoidung();
            dgv_nhomnguoidung.DataSource = nhomnguoidungbll.loadNhomnguoidung();
        }
        void loadCbo_Nhomnguoidung()
        {
            cbo_nhomnguoidung.DataSource = nhomnguoidungbll.loadNhomnguoidung();
            cbo_nhomnguoidung.DisplayMember = "TenNhom";
            cbo_nhomnguoidung.ValueMember = "MaNhom";
        }
        void loadDsNguoidungNhomnguoidungByMaNhom(string pMaNhom)
        {
            dgv_nguoidungnhomnguoidung.DataSource = themBLL.load(pMaNhom);
        }
        List<DTO_NguoiDung> listNguoidung()
        {
            List<DTO_NguoiDung> listNguoidung = new List<DTO_NguoiDung>();
            DataTable table = nguoidungBll.loadNguoidung();
            foreach (DataRow item in table.Rows)
            {
                DTO_NguoiDung nguoidung= new DTO_NguoiDung();
                if (item.ItemArray[2].ToString() == "0")
                {
                    nguoidung.TenDangNhap = item.ItemArray[0].ToString();
                    nguoidung.MatKhau = item.ItemArray[1].ToString();
                    nguoidung.HoatDong = 0;
                }
                else
                {
                    nguoidung.TenDangNhap = item.ItemArray[0].ToString();
                    nguoidung.MatKhau = item.ItemArray[1].ToString();
                    nguoidung.HoatDong = 1;
                }
                listNguoidung.Add(nguoidung); 
            }
            return listNguoidung;
        }
        void loadNguoidung()
        {
            qL_NguoiDungDataGridView.DataSource = listNguoidung();
            dgvNguoidungphanquyen.DataSource = listNguoidung();
        }
        void loadPhanquyen(string manhom)
        {
            dgv_chucnangquyen.DataSource = quyenchucnangBll.GetDataQuyenChucNang(manhom);
        }
        #endregion


        private void frmPhanquyennguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qldiemdanhsvDataSet.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.qldiemdanhsvDataSet.QL_NguoiDung);

        }

        private void dgv_1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_1.CurrentCell.RowIndex;
                MaNhom = dgv_1.Rows[r].Cells[0].Value.ToString();
                loadPhanquyen(MaNhom);
                dgv_chucnangquyen.Visible = true;
            }
            catch
            {

            }
        }

        private void btnLayra_Click(object sender, EventArgs e)
        {
            if (tentaikhoan == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn xóa khỏi nhóm");
                return;
            }
            string manhom = cbo_nhomnguoidung.SelectedValue.ToString();
            int xoa = NDNNDbll.xoaNguoidungTrongNhom(tentaikhoan, manhom);
            if (xoa == 0)
            {
                MessageBox.Show("That bại");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
                loadDsNguoidungNhomnguoidungByMaNhom(manhom);
            }
        }

        private void btnThemvao_Click(object sender, EventArgs e)
        {
            if (tentaikhoan == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng");
            }

            string pMaNhom = cbo_nhomnguoidung.SelectedValue.ToString();
            string ghichu = "";
            int them = NDNNDbll.themNguoidungVao(tentaikhoan, pMaNhom, ghichu);
            if (them == 1)
            {
                MessageBox.Show("Thêm thành công");
                tentaikhoan = "";
                loadDsNguoidungNhomnguoidungByMaNhom(pMaNhom);
            }
            else
            {
                MessageBox.Show("Lỗi. Tên đăng nhập đã tồn tại trong nhóm. Vui lòng kiểm tra lại");
            }
        }

        private void cbo_nhomnguoidung_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string manhom = cbo_nhomnguoidung.SelectedValue.ToString();
                loadDsNguoidungNhomnguoidungByMaNhom(manhom);
            }
            catch
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmPhanquyen frphanquyen = new frmPhanquyen(MaNhom);
            frphanquyen.UpdateBangphanquyen += frphanquyen_UpdateBangphanquyen;
            frphanquyen.ShowDialog();
        }

        private void frphanquyen_UpdateBangphanquyen(object sender, EventArgs e)
        {
            loadPhanquyen(MaNhom);
        }

        private void qL_NguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = qL_NguoiDungDataGridView.CurrentCell.RowIndex;
                txtTendangnhap.Text = qL_NguoiDungDataGridView.Rows[r].Cells[0].Value.ToString();
                txtMatkhau.Text = qL_NguoiDungDataGridView.Rows[r].Cells[1].Value.ToString();
                hoatdong = int.Parse(qL_NguoiDungDataGridView.Rows[r].Cells[2].Value.ToString());
            }
            catch
            {

            }
        }

        private void qL_NguoiDungDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(qL_NguoiDungDataGridView.Rows[e.RowIndex].Cells[2].EditedFormattedValue) == true)
                {
                    try
                    {
                        nguoidungBll.updateNguoidung(txtMatkhau.Text.Trim(), 1, txtTendangnhap.Text.Trim());
                        loadNguoidung();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                    }

                }
                else
                {
                    try
                    {
                        nguoidungBll.updateNguoidung(txtMatkhau.Text.Trim(), 0, txtTendangnhap.Text.Trim());
                        loadNguoidung();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
        }

        private void dgv_nhomnguoidung_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_nhomnguoidung.CurrentCell.RowIndex;
                txtManhom.Text = dgv_nhomnguoidung.Rows[r].Cells[0].Value.ToString();
                txtTennhom.Text = dgv_nhomnguoidung.Rows[r].Cells[1].Value.ToString();
                txtGhichu.Text = dgv_nhomnguoidung.Rows[r].Cells[2].Value.ToString();
            }
            catch 
            {
                
            }
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {
            string MaNhom = txtManhom.Text.Trim();
            string TenNhom = txtTennhom.Text.Trim();
            string GhiChu = txtGhichu.Text.Trim();
            int them = nhomnguoidungbll.insertThemNhom(MaNhom, TenNhom, GhiChu);
            if (them != 0)
            {
                MessageBox.Show("Thêm nhóm người thành công");
                loadNhomNguoidung();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //loadDsNguoidungNhomnguoidungByMaNhom();
        }

        private void dgvNguoidungphanquyen_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoaNguoidung_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa " + txtTendangnhap.Text + " ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    int xoa = nguoidungBll.xoaNguoidung(txtTendangnhap.Text.Trim());
                    if (xoa > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        
                        loadNguoidung();
                    }
                    else if (xoa == 0)
                        MessageBox.Show("Thất bại");
                    else
                        MessageBox.Show("Không được xóa");
                }
            }
        }

        private void btnthemnguoidung_Click(object sender, EventArgs e)
        {
            string TenDangnhap = txtTendangnhap.Text;
            string matkhau = txtMatkhau.Text;
            try
            {
                int them = nguoidungBll.themNguoidung(TenDangnhap, matkhau);
                if (them != 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loadNguoidung();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng kiểm tra lại");
                txtTendangnhap.Text = "";
                txtMatkhau.Text = "";
                txtTendangnhap.Focus();
                return;
            }
        }

        private void dgv_chucnangquyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mamanhinh = dgv_chucnangquyen.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (Convert.ToBoolean(dgv_chucnangquyen.Rows[e.RowIndex].Cells[2].EditedFormattedValue) == true)
            {
                try
                {
                    phanquyen.updatePhanquyen(1, mamanhinh, MaNhom);
                    loadPhanquyen(MaNhom);
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }

            }
            else
            {
                try
                {
                    phanquyen.updatePhanquyen(0, mamanhinh, MaNhom);
                    loadPhanquyen(MaNhom);
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvNguoidungphanquyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    tentaikhoan = qL_NguoiDungDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch
                {

                }
            }
            else
                return;
        }

        private void dgv_nguoidungnhomnguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    tentaikhoan = dgv_nguoidungnhomnguoidung.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch
                {

                }
            }
            else
                tentaikhoan = "";
        }

    }
}
