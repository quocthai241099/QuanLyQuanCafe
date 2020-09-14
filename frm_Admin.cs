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
    public partial class frm_Admin : Form
    {
        AppRepository app = new AppRepository();
        BindingSource listMon = new BindingSource();
        BindingSource listThucDon = new BindingSource();
        BindingSource listBan = new BindingSource();
        BindingSource listTaiKhoan = new BindingSource();
        public frm_Admin()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dateTimePicker_FromDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_FromDate.CustomFormat = "'Ngày:' dd/ MM/ yyyy";
            dateTimePicker_ToDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_ToDate.CustomFormat = "'Ngày:' dd/ MM/ yyyy";
            setDateTimePicker();load_Thongkedoanhthu();
            LoadMon(); MonBinding();
            LoadThucDon(); ThucDonBinding();
            LoadBan(); BanBinding();
            LoadTaiKhoan(); TaiKhoanBinding();
            loadPhanQuyenCombobox(cbb_PhanQuyenTaiKhoan); loadHoatDongCombobox(cbb_HoatDongTK);
        }

        void LoadMon()
        {
            listMon.DataSource = app.Mon.GetMons();
            dGV_Mon.DataSource = listMon;
            dGV_Mon.ReadOnly = true;
            dGV_Mon.AllowUserToAddRows = false;
            LoadThucDonCombobox(cbb_ThucDon_Mon);
            cbb_ThucDon_Mon.Enabled = txt_TenMon.Enabled = num_updown_GiaBan.Enabled
                = btn_SuaMon.Enabled = btn_XoaMon.Enabled = btn_LuuMon.Enabled = false;
        }
        void LoadThucDon()
        {
            listThucDon.DataSource = app.ThucDon.GetThucDons();
            dGV_ThucDon.DataSource = listThucDon;
            dGV_ThucDon.ReadOnly = true;
            dGV_ThucDon.AllowUserToAddRows = false;
            txt_NameThucDon.Enabled = btnLuuThucDon.Enabled = btn_XoaThucDon.Enabled = btn_SuaThucDon.Enabled = false;
        }
        void LoadBan()
        {
            listBan.DataSource = app.Ban.GetBans();
            dGV_Ban.DataSource = listBan;
            dGV_Ban.ReadOnly = true;
            dGV_Ban.AllowUserToAddRows = false;
            txt_TenBan.Enabled = btnLuuBan.Enabled = btn_XoaBan.Enabled = btn_SuaBan.Enabled = false;
        }
        void LoadTaiKhoan()
        {
            listTaiKhoan.DataSource = app.TaiKhoan.GetTaiKhoans();
            dGV_TaiKhoan.DataSource = listTaiKhoan;
            dGV_TaiKhoan.Columns["MatKhau"].Visible = false;
            dGV_TaiKhoan.Columns["PhanQuyen"].Visible = false;
            dGV_TaiKhoan.Columns["HoatDong"].Visible = false;
            dGV_TaiKhoan.ReadOnly = true;
            dGV_TaiKhoan.AllowUserToAddRows = false;

            string user = dGV_TaiKhoan.Rows[0].Cells["Username"].Value.ToString();
            TaiKhoan obj = app.TaiKhoan.GetAccountByUserName(user);
            cbb_PhanQuyenTaiKhoan.SelectedItem = obj._PhanQuyen;
            cbb_HoatDongTK.SelectedItem = obj._HoatDong;
            //
            cbb_PhanQuyenTaiKhoan.Enabled = cbb_HoatDongTK.Enabled = txt_UserName_TK.Enabled = txt_HoTen_TK.Enabled
                = btn_SuaTK.Enabled = btnLuuTK.Enabled = false;
        }

        private void btn_XemMon_Click(object sender, EventArgs e)
        {
            LoadMon();
        }

        private void btn_XemThucDon_Click(object sender, EventArgs e)
        {
            LoadThucDon();
        }

        private void btn_XemBan_Click(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btn_XemTK_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        void MonBinding()
        {
            txt_TenMon.DataBindings.Add(new Binding("Text", dGV_Mon.DataSource, "TenMon", true, DataSourceUpdateMode.Never));
            txt_ID_Mon.DataBindings.Add(new Binding("Text", dGV_Mon.DataSource, "Id", true, DataSourceUpdateMode.Never));
            num_updown_GiaBan.DataBindings.Add(new Binding("Value", dGV_Mon.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
        }
        void LoadThucDonCombobox(ComboBox cb)
        {
            cb.DataSource = app.ThucDon.GetThucDons();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
        }
        void loadPhanQuyenCombobox(ComboBox cb)
        {
            cb.Items.Add("Admin");
            cb.Items.Add("Staff");
        }
        void loadHoatDongCombobox(ComboBox cb)
        {
            cb.Items.Add("Active");
            cb.Items.Add("Block");
        }

        void ThucDonBinding()
        {
            txt_IdThucDon.DataBindings.Add(new Binding("Text", dGV_ThucDon.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txt_NameThucDon.DataBindings.Add(new Binding("Text", dGV_ThucDon.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void BanBinding()
        {
            txt_IDBAn.DataBindings.Add(new Binding("Text", dGV_Ban.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txt_TenBan.DataBindings.Add(new Binding("Text", dGV_Ban.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txt_TrangThai_Ban.DataBindings.Add(new Binding("Text", dGV_Ban.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        }
        void TaiKhoanBinding()
        {
            txt_UserName_TK.DataBindings.Add(new Binding("Text", dGV_TaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txt_HoTen_TK.DataBindings.Add(new Binding("Text", dGV_TaiKhoan.DataSource, "FullName", true, DataSourceUpdateMode.Never));
        }

        //-------------------------------------------Them/Xoa/Sua MÓN-----------------------------------------------------
        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            btn_SuaMon.Enabled = btn_XoaMon.Enabled = false;
            //
            cbb_ThucDon_Mon.Enabled = txt_TenMon.Enabled = num_updown_GiaBan.Enabled = btn_LuuMon.Enabled = true;
            cbb_ThucDon_Mon.SelectedIndex = 0;
            txt_TenMon.Text = txt_ID_Mon.Text = "";
            num_updown_GiaBan.Value = 0;
            txt_TenMon.Focus();
            //

        }

        private void dGV_Mon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Mon.SelectedCells.Count > 0)
            {
                int id = (int)dGV_Mon.SelectedCells[0].OwningRow.Cells["IdThucDon"].Value;
                ThucDon obj = app.ThucDon.GetThucDonById(id);
                cbb_ThucDon_Mon.SelectedValue = obj.Id;
            }
            btn_SuaMon.Enabled = btn_XoaMon.Enabled = true;
            btn_LuuMon.Enabled = false;
        }

        private void btn_SuaMon_Click(object sender, EventArgs e)
        {
            cbb_ThucDon_Mon.Enabled = txt_TenMon.Enabled = num_updown_GiaBan.Enabled = btn_LuuMon.Enabled = true;
            btn_SuaMon.Enabled = false;
            txt_TenMon.Focus();
        }

        private void btn_LuuMon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TenMon.Text.Trim()))
            {
                Mon obj = new Mon
                {
                    TenMon = txt_TenMon.Text.Trim(),
                    GiaBan = (double)num_updown_GiaBan.Value,
                    IdThucDon = (int)cbb_ThucDon_Mon.SelectedValue
                };
                if (!string.IsNullOrEmpty(txt_ID_Mon.Text))
                {
                    //MessageBox.Show("Ok Sua");
                    obj.Id = int.Parse(txt_ID_Mon.Text.Trim());
                    int kq = app.Mon.UpdateMon(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Sửa món thành công");
                        LoadMon();
                        //if (updateMon != null)
                        //{
                        //    updateMon(this, new EventArgs());
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Sửa món thất bại");
                    }
                }
                else
                {
                    //MessageBox.Show("Themmoi");
                    int kq = app.Mon.AddMon(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Thêm món thành công");
                        LoadMon();
                        //if (addMon != null)
                        //{
                        //    addMon(this, new EventArgs());
                        //}
                    }
                    else
                        MessageBox.Show("Thêm món thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập tên món!");
            }
        }

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID_Mon.Text.Trim()))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                {
                    int id = int.Parse(txt_ID_Mon.Text);
                    if (!app.ChiTietHoaDon.isTonTaiMonTrongCTHD(id))
                    {
                        int kq = app.Mon.DeleteMon(id);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Xóa món thành công");
                            LoadMon();
                            //if(deleteMon != null)
                            //{
                            //    deleteMon(this,new EventArgs());
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Xóa món thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đang được sử dụng, không thể Xóa!!!");
                    }
                }
            }
        }
        //private event EventHandler addMon;
        //public event EventHandler AddMon
        //{
        //    add { addMon += value; }
        //    remove { addMon -= value; }
        //}

        //private event EventHandler deleteMon;
        //public event EventHandler DeleteMon
        //{
        //    add { deleteMon += value; }
        //    remove { deleteMon -= value; }
        //}

        //private event EventHandler updateMon;
        //public event EventHandler UpdateMon
        //{
        //    add { updateMon += value; }
        //    remove { updateMon -= value; }
        //}
        //-------------------------------------------Them/Xoa/Sua Thực Đơn-----------------------------------------------------
        private void btn_ThemThucDon_Click(object sender, EventArgs e)
        {
            btn_SuaThucDon.Enabled = btn_XoaThucDon.Enabled = false;
            btnLuuThucDon.Enabled = true;
            txt_NameThucDon.Enabled = true;
            txt_NameThucDon.Text = txt_IdThucDon.Text = "";
            txt_NameThucDon.Focus();
        }

        private void dGV_ThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_SuaThucDon.Enabled = btn_XoaThucDon.Enabled = true;
            btnLuuThucDon.Enabled = false;
        }

        private void btn_SuaThucDon_Click(object sender, EventArgs e)
        {
            txt_NameThucDon.Enabled = btnLuuThucDon.Enabled = true;
            btn_SuaMon.Enabled = false;
            txt_NameThucDon.Focus();
        }

        private void btnLuuThucDon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_NameThucDon.Text.Trim()))
            {
                ThucDon obj = new ThucDon
                {
                    Name = txt_NameThucDon.Text.Trim()
                };
                if (!string.IsNullOrEmpty(txt_IdThucDon.Text))
                {
                    //MessageBox.Show("Ok Sua");
                    obj.Id = int.Parse(txt_IdThucDon.Text.Trim());
                    int kq = app.ThucDon.UpdateThucDon(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Sửa Thực đơn thành công");
                        LoadThucDon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thực đơn thất bại");
                    }
                }
                else
                {
                    //MessageBox.Show("Themmoi");
                    int kq = app.ThucDon.AddThucDon(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Thêm Thực đơn thành công");
                        LoadThucDon();
                    }
                    else
                        MessageBox.Show("Thêm Thực đơn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập tên thực đơn!");
            }
        }

        private void btn_XoaThucDon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_IdThucDon.Text.Trim()))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = int.Parse(txt_IdThucDon.Text);
                    if (!app.ThucDon.isTonTaiThucDonTrong_Mon(id))
                    {
                        int kq = app.ThucDon.DeleteThucDon(id);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Xóa Thực đơn thành công");
                            LoadThucDon();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Thực đơn thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đang được sử dụng, không thể Xóa!!!");
                    }
                }
            }
        }
        //-------------------------------------------Them/Xoa/Sua Bàn-----------------------------------------------------
        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            btn_SuaBan.Enabled = btn_XoaBan.Enabled = false;
            btnLuuBan.Enabled = true;
            txt_TenBan.Enabled = true;
            txt_TenBan.Text = txt_IDBAn.Text = "";
            txt_TrangThai_Ban.Text = "Trống";
            txt_TenBan.Focus();
        }

        private void dGV_Ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_SuaBan.Enabled = btn_XoaBan.Enabled = true;
            btnLuuBan.Enabled = false;
        }

        private void btn_SuaBan_Click(object sender, EventArgs e)
        {
            txt_TenBan.Enabled = btnLuuBan.Enabled = true;
            txt_TenBan.Focus();
            btn_SuaBan.Enabled = false;
        }

        private void btnLuuBan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TenBan.Text.Trim()))
            {
                Ban obj = new Ban
                {
                    Name = txt_TenBan.Text.Trim()
                };
                if (!string.IsNullOrEmpty(txt_IDBAn.Text))
                {
                    //MessageBox.Show("Ok Sua");
                    obj.Id = int.Parse(txt_IDBAn.Text.Trim());
                    int kq = app.Ban.UpdateBan(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Sửa Bàn thành công");
                        LoadBan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Bàn thất bại");
                    }
                }
                else
                {
                    //MessageBox.Show("Themmoi");
                    int kq = app.Ban.AddBan(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        LoadBan();
                    }
                    else
                        MessageBox.Show("Thêm bàn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập tên bàn");
            }
        }

        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_IDBAn.Text.Trim()))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = int.Parse(txt_IDBAn.Text);
                    if (!app.Ban.isTonTaiBanTrong_HoaDon(id))
                    {
                        int kq = app.Ban.DeleteBan(id);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Xóa bàn thành công");
                            LoadBan();
                        }
                        else
                        {
                            MessageBox.Show("Xóa bàn thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đang được sử dụng, không thể Xóa!!!");
                    }
                }
            }
        }
        //-------------------------------------------------------Thống kê doanh thu------------------------------------------------
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            load_Thongkedoanhthu();
        }
        void load_Thongkedoanhthu()
        {
            DateTime fromdate = dateTimePicker_FromDate.Value;
            DateTime todate = dateTimePicker_ToDate.Value;
            dGV_DoanhThu.DataSource = app.HoaDon.ThongKeDoanhThu(fromdate, todate);
            dGV_DoanhThu.ReadOnly = true;
            dGV_DoanhThu.AllowUserToAddRows = false;
        }
        void setDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dateTimePicker_FromDate.Value = new DateTime(today.Year,today.Month,1);
            dateTimePicker_ToDate.Value = dateTimePicker_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        //---------------------------------------------------CRUD Tai khoan---------------------------------------------------------
        private void dGV_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId >= 0 && rowId < dGV_TaiKhoan.Rows.Count)
            {
                string user = dGV_TaiKhoan.Rows[rowId].Cells["Username"].Value.ToString();
                TaiKhoan obj = app.TaiKhoan.GetAccountByUserName(user);
                cbb_PhanQuyenTaiKhoan.SelectedItem = obj._PhanQuyen;
                cbb_HoatDongTK.SelectedItem = obj._HoatDong;
            }
            btn_SuaTK.Enabled = true;
            btnLuuTK.Enabled = false;
        }

        private void btn_Them_TK_Click(object sender, EventArgs e)
        {
            btn_SuaTK.Enabled = false;
            btnLuuTK.Enabled = true;
            txt_UserName_TK.Enabled = txt_HoTen_TK.Enabled = cbb_PhanQuyenTaiKhoan.Enabled = cbb_HoatDongTK.Enabled= true;

            cbb_HoatDongTK.SelectedIndex = 0;
            cbb_PhanQuyenTaiKhoan.SelectedItem = "Staff";
            txt_UserName_TK.Text = txt_HoTen_TK.Text = "";
            txt_UserName_TK.Focus();
        }
        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            btnLuuTK.Enabled = txt_HoTen_TK.Enabled = cbb_HoatDongTK.Enabled = cbb_PhanQuyenTaiKhoan.Enabled = true;
            txt_HoTen_TK.Focus();
            btn_SuaTK.Enabled = false;
        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_UserName_TK.Text.Trim()) && !string.IsNullOrEmpty(txt_HoTen_TK.Text.Trim()))
            {
                TaiKhoan obj = new TaiKhoan
                {
                    UserName = txt_UserName_TK.Text.Trim(),
                    FullName = txt_HoTen_TK.Text.Trim(),
                    Phanquyen = cbb_PhanQuyenTaiKhoan.SelectedItem.ToString().Equals("Admin") ? 1 : 0,
                    Hoatdong = cbb_HoatDongTK.SelectedItem.ToString().Equals("Active") ? 1 : 0
                };
                if (app.TaiKhoan.isTrungUserName(obj.UserName))
                {
                    if (MessageBox.Show("Tài khoản này đã tồn tại, Bạn có muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        int kq = app.TaiKhoan.UpdateTaiKhoan(obj);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Cập nhật Tài khoản thành công");
                            LoadTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Tài khoản thất bại");
                        }
                    }
                }
                else
                {
                    int kq = app.TaiKhoan.AddTaiKhoan(obj);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Thêm Tài khoản thành công");
                        LoadTaiKhoan();
                    }
                    else
                        MessageBox.Show("Thêm Tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin!!");
            }
        }

        private void btn_DatLaiMK_Click(object sender, EventArgs e)
        {
            string username = txt_UserName_TK.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                if (MessageBox.Show("Đặt lại mật khẩu cho Tài khoản: " +username+ " ứng với Password: " + username, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (app.TaiKhoan.isTrungUserName(username))
                    {
                        int kq = app.TaiKhoan.ResetPassWord(username);
                        if (kq >= 1)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu thất bại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserName không tồn tại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có tài khoản nào được chọn!!!");
            }
        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        
    }
}

