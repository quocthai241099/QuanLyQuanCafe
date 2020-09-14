namespace QuanLyQuanCafeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login.jpg");
            this.imageList1.Images.SetKeyName(1, "exit.jpg");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_TenDN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(174, 50);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(222, 22);
            this.txt_TenDN.TabIndex = 1;
            this.txt_TenDN.Text = "admin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_MK);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 77);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(173, 29);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(222, 22);
            this.txt_MK.TabIndex = 1;
            this.txt_MK.Text = "123456";
            this.txt_MK.UseSystemPasswordChar = true;
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.ImageIndex = 0;
            this.btn_DN.ImageList = this.imageList1;
            this.btn_DN.Location = new System.Drawing.Point(49, 215);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(150, 75);
            this.btn_DN.TabIndex = 3;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ImageIndex = 1;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(276, 215);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 75);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_DN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 308);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_DN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(458, 320);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel1;
    }
}

