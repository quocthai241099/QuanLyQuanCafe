namespace QuanLyQuanCafeApp
{
    partial class frm_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Account));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_CapNhatTT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nhaplai = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.ImageIndex = 1;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(283, 397);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(136, 65);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "update.jpg");
            this.imageList1.Images.SetKeyName(1, "thoat.jpg");
            // 
            // btn_CapNhatTT
            // 
            this.btn_CapNhatTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatTT.ImageIndex = 0;
            this.btn_CapNhatTT.ImageList = this.imageList1;
            this.btn_CapNhatTT.Location = new System.Drawing.Point(36, 397);
            this.btn_CapNhatTT.Name = "btn_CapNhatTT";
            this.btn_CapNhatTT.Size = new System.Drawing.Size(146, 65);
            this.btn_CapNhatTT.TabIndex = 22;
            this.btn_CapNhatTT.Text = "Cập nhật";
            this.btn_CapNhatTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhatTT.UseVisualStyleBackColor = true;
            this.btn_CapNhatTT.Click += new System.EventHandler(this.btn_CapNhatTT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại:";
            // 
            // Txt_Nhaplai
            // 
            this.Txt_Nhaplai.Location = new System.Drawing.Point(143, 21);
            this.Txt_Nhaplai.Name = "Txt_Nhaplai";
            this.Txt_Nhaplai.Size = new System.Drawing.Size(256, 22);
            this.Txt_Nhaplai.TabIndex = 1;
            this.Txt_Nhaplai.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Txt_Nhaplai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 65);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(143, 21);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(256, 22);
            this.txt_MatKhauMoi.TabIndex = 1;
            this.txt_MatKhauMoi.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_MatKhauMoi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 65);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(143, 21);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(256, 22);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 65);
            this.panel1.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Họ Tên:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(143, 21);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(256, 22);
            this.txt_HoTen.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txt_HoTen);
            this.panel21.Controls.Add(this.label13);
            this.panel21.Location = new System.Drawing.Point(12, 96);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(407, 65);
            this.panel21.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "UserName:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(144, 34);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(256, 22);
            this.txt_UserName.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txt_UserName);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Location = new System.Drawing.Point(12, 12);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(407, 78);
            this.panel15.TabIndex = 20;
            // 
            // frm_Account
            // 
            this.AcceptButton = this.btn_CapNhatTT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(472, 488);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CapNhatTT);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel21);
            this.MaximizeBox = false;
            this.Name = "frm_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Account_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_CapNhatTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nhaplai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ImageList imageList1;

    }
}