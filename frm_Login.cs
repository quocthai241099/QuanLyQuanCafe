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
    public partial class Form1 : Form
    {
        AppRepository app = new AppRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_TenDN.Text) || string.IsNullOrEmpty(txt_MK.Text))
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin");
            }
            else
            {
                int ret;
                TaiKhoan obj = app.TaiKhoan.Login(txt_TenDN.Text, txt_MK.Text, out ret);
                if (obj == null)
                {
                    string[] error = { "UserName Không tồn tại", "Sai mật khẩu" };
                    MessageBox.Show(error[ret]);
                }
                else
                {
                    if(obj.Hoatdong == 0)
                    {
                        MessageBox.Show("Tài Khoản hiện tại đã bị khóa!!!");
                    }
                    else
                    {
                        this.Hide();
                        frm_Main frm = new frm_Main(obj);
                        frm.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
