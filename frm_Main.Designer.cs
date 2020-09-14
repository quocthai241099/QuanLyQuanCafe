namespace QuanLyQuanCafeApp
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lsvThucdon = new System.Windows.Forms.ListView();
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grKhachhang = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numGiamgia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grKhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.97795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.02205F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.29021F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.70978F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 603);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lsvThucdon, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.45536F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.54464F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 448);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lsvThucdon
            // 
            this.lsvThucdon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenMon,
            this.colGia,
            this.colSoluong,
            this.colThanhtien});
            this.lsvThucdon.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvThucdon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvThucdon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThucdon.HideSelection = false;
            this.lsvThucdon.Location = new System.Drawing.Point(3, 125);
            this.lsvThucdon.Name = "lsvThucdon";
            this.lsvThucdon.Size = new System.Drawing.Size(669, 320);
            this.lsvThucdon.TabIndex = 2;
            this.lsvThucdon.UseCompatibleStateImageBehavior = false;
            this.lsvThucdon.View = System.Windows.Forms.View.Details;
            this.lsvThucdon.SelectedIndexChanged += new System.EventHandler(this.lsvThucdon_SelectedIndexChanged);
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món";
            this.colTenMon.Width = 160;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.Width = 114;
            // 
            // colSoluong
            // 
            this.colSoluong.Text = "Số lượng";
            this.colSoluong.Width = 105;
            // 
            // colThanhtien
            // 
            this.colThanhtien.Text = "Thành tiền";
            this.colThanhtien.Width = 184;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 24);
            this.toolStripMenuItem1.Text = "Xóa";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.12389F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.87611F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel6.Controls.Add(this.lbLoai, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbMon, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cboLoai, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cboMon, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnThem, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtGiaban, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.numSoluong, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.31461F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.68539F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(669, 116);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLoai.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoai.Location = new System.Drawing.Point(3, 0);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(98, 42);
            this.lbLoai.TabIndex = 0;
            this.lbLoai.Text = "Loại";
            // 
            // lbMon
            // 
            this.lbMon.AutoSize = true;
            this.lbMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMon.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMon.Location = new System.Drawing.Point(3, 42);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(98, 44);
            this.lbMon.TabIndex = 1;
            this.lbMon.Text = "Món";
            // 
            // cboLoai
            // 
            this.cboLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(107, 3);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(363, 24);
            this.cboLoai.TabIndex = 2;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // cboMon
            // 
            this.cboMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(107, 45);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(363, 24);
            this.cboMon.TabIndex = 3;
            this.cboMon.SelectedIndexChanged += new System.EventHandler(this.cboMon_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.ImageIndex = 7;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(476, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 36);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm món";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "luu.png");
            this.imageList1.Images.SetKeyName(1, "print.jpg");
            this.imageList1.Images.SetKeyName(2, "sua.jpg");
            this.imageList1.Images.SetKeyName(3, "them.jpg");
            this.imageList1.Images.SetKeyName(4, "thoat.jpg");
            this.imageList1.Images.SetKeyName(5, "xoa.png");
            this.imageList1.Images.SetKeyName(6, "thanhtoan.png");
            this.imageList1.Images.SetKeyName(7, "add.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaban.Enabled = false;
            this.txtGiaban.Location = new System.Drawing.Point(107, 89);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(363, 22);
            this.txtGiaban.TabIndex = 7;
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(476, 45);
            this.numSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(112, 22);
            this.numSoluong.TabIndex = 5;
            this.numSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69364F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.30636F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 457);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(675, 143);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.33334F));
            this.tableLayoutPanel5.Controls.Add(this.lbTongtien, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtTongtien, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnThanhtoan, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(243, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(429, 139);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(3, 0);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(74, 17);
            this.lbTongtien.TabIndex = 0;
            this.lbTongtien.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(125, 2);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(301, 22);
            this.txtTongtien.TabIndex = 1;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhtoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.ImageIndex = 6;
            this.btnThanhtoan.ImageList = this.imageList1;
            this.btnThanhtoan.Location = new System.Drawing.Point(125, 71);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(301, 66);
            this.btnThanhtoan.TabIndex = 2;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.grKhachhang, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(234, 137);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // grKhachhang
            // 
            this.grKhachhang.BackColor = System.Drawing.SystemColors.Control;
            this.grKhachhang.Controls.Add(this.label3);
            this.grKhachhang.Controls.Add(this.numGiamgia);
            this.grKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grKhachhang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKhachhang.Location = new System.Drawing.Point(3, 2);
            this.grKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grKhachhang.Name = "grKhachhang";
            this.grKhachhang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grKhachhang.Size = new System.Drawing.Size(228, 133);
            this.grKhachhang.TabIndex = 2;
            this.grKhachhang.TabStop = false;
            this.grKhachhang.Text = "Giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "%";
            // 
            // numGiamgia
            // 
            this.numGiamgia.Location = new System.Drawing.Point(37, 46);
            this.numGiamgia.Name = "numGiamgia";
            this.numGiamgia.Size = new System.Drawing.Size(53, 22);
            this.numGiamgia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Image = global::QuanLyQuanCafeApp.Properties.Resources.logo;
            this.label2.Location = new System.Drawing.Point(684, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 149);
            this.label2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(684, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 448);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1117, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý quán Cafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grKhachhang.ResumeLayout(false);
            this.grKhachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView lsvThucdon;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colSoluong;
        private System.Windows.Forms.ColumnHeader colThanhtien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox grKhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numGiamgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
    }
}