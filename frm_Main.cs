using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafeApp.Models;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafeApp.Models.DTO;

namespace QuanLyQuanCafeApp
{
    public partial class frm_Main : Form
    {
        AppRepository app = new AppRepository();
        private TaiKhoan loginAccount;
        SqlDataAdapter da_Ban;
        DataSet ds;


        public frm_Main(TaiKhoan acc)
        {
            this.loginAccount = acc;
            InitializeComponent(); ds = new DataSet();
            adminToolStripMenuItem.Enabled = acc.Phanquyen == 1;     //Phân quyền giữa Admin và Nhân viên
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + acc.FullName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Admin frm = new frm_Admin();
            //frm.AddMon += Frm_AddMon;
            //frm.DeleteMon += Frm_DeleteMon;
            //frm.UpdateMon += Frm_UpdateMon;

            frm.ShowDialog();
        }
        //--------------------------------------------------------------------------------------------------------------------------
        //private void Frm_UpdateMon(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void Frm_DeleteMon(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void Frm_AddMon(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Account frm = new frm_Account(loginAccount);
            frm.UpdateAccount += frm_UpdateAccount;
            frm.ShowDialog();
        }

        private void frm_UpdateAccount(object sender, frm_Account.AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ("+e.Acc.FullName+")";
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            loadCboLoai();
            cboLoai.SelectedIndex = 0;
            loadCboMon();
            LoadTable();
        }
        //-------------------------------------------Hao----------------------------------------
        private void LoadTable()
        {
            var Tables = app.Ban.GetBans();

            foreach (var item in Tables)
            {
                Button btn = new Button();
                btn.Width = 70;
                btn.Height = 70;
                btn.Text = item.Name.ToString() + Environment.NewLine + item.TrangThai.ToString();
                btn.Name = item.Id.ToString();

                btn.Click += btn_Click;

                switch (item.TrangThai.ToString())
                {
                    case "Trống":
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.DarkKhaki;
                        break;
                }

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void LayThongTinHoaDon(int maBan)
        {
            lsvThucdon.Items.Clear();
            List<HoaDonChiTiet> dsHDCT = app.Menu.LayMenuTuBan(maBan);

            foreach (HoaDonChiTiet hdct in dsHDCT)
            {
                ListViewItem lstvItem = new ListViewItem(hdct.TenMon.ToString());
                lstvItem.SubItems.Add(hdct.GiaBan.ToString());
                lstvItem.SubItems.Add(hdct.SoLuong.ToString());

                double thanhtien = int.Parse(hdct.GiaBan.ToString()) * int.Parse(hdct.SoLuong.ToString());
                lstvItem.SubItems.Add(thanhtien.ToString());
                lsvThucdon.Items.Add(lstvItem);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string[] nameAndStatus = btn.Text.Split('\n', '\r');
            int maBan = int.Parse((sender as Button).Name);
            lsvThucdon.Tag = ((Ban)new Ban(int.Parse(btn.Name), nameAndStatus[0], nameAndStatus[2]));
            LayThongTinHoaDon(maBan);
            hienTongTien();

        }
        private void loadCboLoai()
        {
            List<ThucDon> list = app.ThucDon.GetThucDons();
            list.Insert(0, new ThucDon {Id=0,Name="Tất cả" });
            cboLoai.DataSource = list;
            cboLoai.DisplayMember = "Name";
            cboLoai.ValueMember = "Id";
        }
        private void loadCboMon()
        {
            List<Mon> list = app.Mon.GetMons();
            cboMon.DataSource = list;
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "Id";
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex == 0)
            {
                loadCboMon();
            }
            else
            {
                int idThucDon = int.Parse(cboLoai.SelectedValue.ToString());
                List<Mon> list = app.Mon.getMonByIdThucDon(idThucDon);
                cboMon.DataSource = list;
                cboMon.DisplayMember = "TenMon";
                cboMon.ValueMember = "Id";
            }
        }

        private void ThemMon(Ban ban)
        {
            foreach (var item in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (item.Name == ban.Id.ToString())
                {
                    app.Ban.CapNhatTrangThaiBan(ban.Id, "Có người");
                    item.Text = ban.Name.ToString() + Environment.NewLine + "Có người";
                    item.BackColor = Color.DarkKhaki;
                }
            }
        }
        private void hienTongTien()
        {
            double tongtien = 0;
            for (int i = 0; i < lsvThucdon.Items.Count; i++)
            {
                tongtien = tongtien + double.Parse(lsvThucdon.Items[i].SubItems[3].Text.ToString());
            }
            txtTongtien.Text = tongtien.ToString() + " VNĐ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvThucdon.Tag as Ban;
                int maHoaDon = app.HoaDon.LayMaHoaDonTheoMaBan(ban.Id);
                int maMon = int.Parse(cboMon.SelectedValue.ToString());
                int soLuong = (int)numSoluong.Value;
                if (maHoaDon == -1)
                {
                    app.HoaDon.ThemHD(ban.Id);
                    app.ChiTietHoaDon.ThemChiTietHoaDon(app.HoaDon.LayMaHDLonNhat(),
                        maMon, soLuong);
                    ThemMon(ban);
                }
                else
                {
                    var check = app.ChiTietHoaDon.KiemTraMonAnTonTai(maHoaDon, maMon);
                    if (check)
                    {
                        app.ChiTietHoaDon.CapNhapSoLuong(maHoaDon, maMon, soLuong);
                        LayThongTinHoaDon(ban.Id);

                    }
                    else
                    {
                        app.ChiTietHoaDon.ThemChiTietHoaDon(maHoaDon, maMon, soLuong);
                    }
                }
                LayThongTinHoaDon(ban.Id);
                hienTongTien();
            }
            catch
            {
                MessageBox.Show("Chưa chọn bàn");
            }
        }

        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idmon;
            int.TryParse(cboMon.SelectedValue.ToString(),out idmon);
            Mon mon = app.Mon.GetMonById(idmon);
            if (mon != null)
                txtGiaban.Text = mon.GiaBan.ToString();
        }

        private void ThanhToan(Ban ban)
        {
            foreach (var item in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (item.Name == ban.Id.ToString())
                {
                    app.Ban.CapNhatTrangThaiBan(ban.Id, "Trống");
                    item.Text = ban.Name.ToString() + Environment.NewLine + "Trống";
                    item.BackColor = Color.LightSkyBlue;
                }
            }
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvThucdon.Tag as Ban;
                if (ban.TrangThai != "Trống")
                {
                    int id = app.HoaDon.LayMaHoaDonTheoMaBan(ban.Id);
                    DateTime time = DateTime.Now;
                    int trangthai = 1;
                    string nguoilap = loginAccount.UserName;
                    double giamgia = double.Parse(numGiamgia.Value.ToString());
                    double tongtien = 0;
                    for (int i = 0; i < lsvThucdon.Items.Count; i++)
                    {
                        tongtien = tongtien + double.Parse(lsvThucdon.Items[i].SubItems[3].Text.ToString());
                    }
                    tongtien = tongtien - (tongtien * giamgia / 100.0);
                    app.HoaDon.CapNhatHoaDon(id, time, trangthai, nguoilap, tongtien, giamgia);
                    ThanhToan(ban);
                    txtTongtien.Text = tongtien.ToString() + " VNĐ";
                    lsvThucdon.Items.Clear();

                    //
                    InHoaDon inhd = new InHoaDon(id);
                    inhd.Show();
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn bàn");
            }
        }
        
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lsvThucdon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvThucdon.Tag as Ban;
                int idhoadon = app.HoaDon.LayMaHoaDonTheoMaBan(ban.Id);

                string tenmon = lsvThucdon.SelectedItems[0].Text.ToString();
                Mon mon = app.Mon.GetMonTheoTen(tenmon);
                app.Mon.XoaMonKhiOrder(idhoadon, mon.Id);
                LayThongTinHoaDon(ban.Id);
                if (lsvThucdon.Items.Count < 1)
                {
                    ThanhToan(ban);
                    app.HoaDon.XoaHoaDonKhiXoaAllMon(idhoadon);
                }
                
            }
            catch
            {
                MessageBox.Show("Chưa chọn món");
            }
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

       
    }
}
