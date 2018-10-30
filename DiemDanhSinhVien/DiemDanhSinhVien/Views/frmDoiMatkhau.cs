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
    public partial class frmDoiMatkhau : Form
    {
        
        private QL_NguoiDung nguoiDung;

        public QL_NguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; loadAccountProfide(NguoiDung); }
        }
        LinqNguoidung lqNguoidung = new LinqNguoidung();
        public frmDoiMatkhau(QL_NguoiDung nguoidung)
        {
            InitializeComponent();
            this.NguoiDung = nguoidung;
        }
        void loadAccountProfide(QL_NguoiDung acc)
        {
            txtUserName.Text = acc.TenDangNhap;
            
        }
        void UpdateAccCountProfile()
        {
            
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            string newpass = txtNewPass.Text;
            string passAgain = txtPasswordAgain.Text;
            if (!newpass.Equals(passAgain))
            {
                MessageBox.Show("Mật khẩu không giống nhau.Vui lòng nhập lại! ");
            }
            else
            {
                
                QL_NguoiDung nguoidung=new QL_NguoiDung();
                nguoidung.TenDangNhap=username;
                nguoidung.MatKhau=pass;
                nguoidung.HoatDong=0;
                int kt=lqNguoidung.ktNguoidung(nguoidung);
                if (kt==1)
                {
                    nguoidung.MatKhau = newpass;
                    lqNguoidung.updateNguoidung(nguoidung);
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    onUpdate();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác!");
                    txtPassword.Clear();
                    txtNewPass.Clear();
                    txtPasswordAgain.Clear();
                    txtPassword.Focus();
                }
            }
        }
        public void onUpdate()
        {
            if (updateAcc != null)
            {
                updateAcc(this, new AccountEvent(NguoiDung));
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccCountProfile();
        }
        private EventHandler<AccountEvent> updateAcc;
        public event EventHandler<AccountEvent> UpdateAcc
        {
            add { updateAcc += value; }
            remove { updateAcc -= value; }
        }
    }
    public class AccountEvent : EventArgs
    {
        private QL_NguoiDung acc;

        public QL_NguoiDung Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(QL_NguoiDung acc)
        {
            this.Acc = acc;
        }
    }
}
