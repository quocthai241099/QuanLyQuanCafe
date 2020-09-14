using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafeApp.Models;

namespace QuanLyQuanCafeApp
{
    public partial class frm_Account : Form
    {
        AppRepository app = new AppRepository();
        private TaiKhoan loginAccount;

        public frm_Account(TaiKhoan acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            hienThiThongTinAccount(loginAccount);
        }

        void hienThiThongTinAccount(TaiKhoan acc)
        {
            txt_UserName.Text = acc.UserName;
            txt_HoTen.Text = acc.FullName;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhatTT_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string fullname = txt_HoTen.Text;
            string password = txt_MatKhau.Text;
            string newpass = txt_MatKhauMoi.Text;
            string reenterpass = Txt_Nhaplai.Text;

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!!");
            }
            else
            {
                if (app.TaiKhoan.UpdateThongTinCaNhan(username, fullname, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if(updateAccount != null)
                    {
                        updateAccount(this,new AccountEvent(app.TaiKhoan.GetAccountByUserName(username)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!!!");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private TaiKhoan acc;

            public TaiKhoan Acc { get { return acc; } set {  acc = value; } }
            public AccountEvent(TaiKhoan acc)
            {
                this.acc = acc;
            }
        }

        private void frm_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

    }
}
