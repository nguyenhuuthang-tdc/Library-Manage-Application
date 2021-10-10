namespace GUI
{
    partial class QuanLyThuVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLBanDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLoaiSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLMuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNhaXuatBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLChiTietMuonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLChiTietTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraSachTreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lbNameAdmin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.thongTinToolStripMenuItem,
            this.heThongToolStripMenuItem,
            this.timKiemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLBanDocToolStripMenuItem,
            this.qLLoaiSachToolStripMenuItem,
            this.qLMuonSachToolStripMenuItem,
            this.qLNhaXuatBanToolStripMenuItem,
            this.qLSachToolStripMenuItem,
            this.qLChiTietMuonToolStripMenuItem,
            this.qLChiTietTraToolStripMenuItem});
            this.quanLyToolStripMenuItem.Enabled = false;
            this.quanLyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyToolStripMenuItem.Image = global::GUI.Properties.Resources.Archive_manage_icon;
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // qLBanDocToolStripMenuItem
            // 
            this.qLBanDocToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.qLBanDocToolStripMenuItem.Image = global::GUI.Properties.Resources.Book_icon__1_;
            this.qLBanDocToolStripMenuItem.Name = "qLBanDocToolStripMenuItem";
            this.qLBanDocToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLBanDocToolStripMenuItem.Text = "QL Bạn Đọc";
            this.qLBanDocToolStripMenuItem.Click += new System.EventHandler(this.qLBanDocToolStripMenuItem_Click);
            // 
            // qLLoaiSachToolStripMenuItem
            // 
            this.qLLoaiSachToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.qLLoaiSachToolStripMenuItem.Image = global::GUI.Properties.Resources.book_red_icon__1_;
            this.qLLoaiSachToolStripMenuItem.Name = "qLLoaiSachToolStripMenuItem";
            this.qLLoaiSachToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLLoaiSachToolStripMenuItem.Text = "QL Loại Sách";
            this.qLLoaiSachToolStripMenuItem.Click += new System.EventHandler(this.qLLoaiSachToolStripMenuItem_Click);
            // 
            // qLMuonSachToolStripMenuItem
            // 
            this.qLMuonSachToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.qLMuonSachToolStripMenuItem.Image = global::GUI.Properties.Resources.Dictionary_Mac_Book_icon;
            this.qLMuonSachToolStripMenuItem.Name = "qLMuonSachToolStripMenuItem";
            this.qLMuonSachToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLMuonSachToolStripMenuItem.Text = "QL Mượn Sách";
            this.qLMuonSachToolStripMenuItem.Click += new System.EventHandler(this.qLMuonSachToolStripMenuItem_Click);
            // 
            // qLNhaXuatBanToolStripMenuItem
            // 
            this.qLNhaXuatBanToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.qLNhaXuatBanToolStripMenuItem.Image = global::GUI.Properties.Resources.Jules_Verne_Book_icon;
            this.qLNhaXuatBanToolStripMenuItem.Name = "qLNhaXuatBanToolStripMenuItem";
            this.qLNhaXuatBanToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLNhaXuatBanToolStripMenuItem.Text = "QL Nhà Xuất Bản";
            this.qLNhaXuatBanToolStripMenuItem.Click += new System.EventHandler(this.qLNhaXuatBanToolStripMenuItem_Click);
            // 
            // qLSachToolStripMenuItem
            // 
            this.qLSachToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.qLSachToolStripMenuItem.Image = global::GUI.Properties.Resources.books_icon;
            this.qLSachToolStripMenuItem.Name = "qLSachToolStripMenuItem";
            this.qLSachToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLSachToolStripMenuItem.Text = "QL Sách";
            this.qLSachToolStripMenuItem.Click += new System.EventHandler(this.qLSachToolStripMenuItem_Click);
            // 
            // qLChiTietMuonToolStripMenuItem
            // 
            this.qLChiTietMuonToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.qLChiTietMuonToolStripMenuItem.Image = global::GUI.Properties.Resources.Font_Book_icon__1_;
            this.qLChiTietMuonToolStripMenuItem.Name = "qLChiTietMuonToolStripMenuItem";
            this.qLChiTietMuonToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLChiTietMuonToolStripMenuItem.Text = "QL Chi Tiết Mượn";
            this.qLChiTietMuonToolStripMenuItem.Click += new System.EventHandler(this.qLChiTietMuonToolStripMenuItem_Click);
            // 
            // qLChiTietTraToolStripMenuItem
            // 
            this.qLChiTietTraToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.qLChiTietTraToolStripMenuItem.Image = global::GUI.Properties.Resources.Marvel_Book_icon;
            this.qLChiTietTraToolStripMenuItem.Name = "qLChiTietTraToolStripMenuItem";
            this.qLChiTietTraToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.qLChiTietTraToolStripMenuItem.Text = "QL Chi Tiết Trả";
            this.qLChiTietTraToolStripMenuItem.Click += new System.EventHandler(this.qLChiTietTraToolStripMenuItem_Click);
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.thongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SachToolStripMenuItem,
            this.TraSachTreToolStripMenuItem});
            this.thongTinToolStripMenuItem.Enabled = false;
            this.thongTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinToolStripMenuItem.Image = global::GUI.Properties.Resources.Help_Info_2_icon;
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.thongTinToolStripMenuItem.Text = "Thông Tin";
            // 
            // SachToolStripMenuItem
            // 
            this.SachToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.SachToolStripMenuItem.Image = global::GUI.Properties.Resources.G12_Book_4_icon;
            this.SachToolStripMenuItem.Name = "SachToolStripMenuItem";
            this.SachToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.SachToolStripMenuItem.Text = "Sách";
            this.SachToolStripMenuItem.Click += new System.EventHandler(this.phieuMuonToolStripMenuItem_Click);
            // 
            // TraSachTreToolStripMenuItem
            // 
            this.TraSachTreToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.TraSachTreToolStripMenuItem.Image = global::GUI.Properties.Resources.G12_Libraries_icon;
            this.TraSachTreToolStripMenuItem.Name = "TraSachTreToolStripMenuItem";
            this.TraSachTreToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.TraSachTreToolStripMenuItem.Text = "Trả Sách Trễ";
            this.TraSachTreToolStripMenuItem.Click += new System.EventHandler(this.TraSachTreToolStripMenuItem_Click);
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.ChangeSkin});
            this.heThongToolStripMenuItem.Enabled = false;
            this.heThongToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heThongToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heThongToolStripMenuItem.Image = global::GUI.Properties.Resources.settings_icon;
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.doiMatKhauToolStripMenuItem.Image = global::GUI.Properties.Resources.Misc_Settings_icon;
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi Mật Khẩu ";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dangXuatToolStripMenuItem.Image = global::GUI.Properties.Resources.settings_icon__1_;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // ChangeSkin
            // 
            this.ChangeSkin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeSkin.Image = global::GUI.Properties.Resources.thuan;
            this.ChangeSkin.Name = "ChangeSkin";
            this.ChangeSkin.Size = new System.Drawing.Size(173, 24);
            this.ChangeSkin.Text = "Đổi Giao Diện";
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.timKiemToolStripMenuItem.Enabled = false;
            this.timKiemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemToolStripMenuItem.Image = global::GUI.Properties.Resources.red_search_icon__1_;
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.timKiemToolStripMenuItem.Text = "Tìm Kiếm ";
            this.timKiemToolStripMenuItem.Click += new System.EventHandler(this.timKiemToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(259, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phần Mềm Quản Lý Thư Viện";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.thua;
            this.pictureBox3.Location = new System.Drawing.Point(720, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(650, 717);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.nghich;
            this.pictureBox2.Location = new System.Drawing.Point(0, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(722, 717);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.BackColor = System.Drawing.Color.Chocolate;
            this.lbTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTK.Location = new System.Drawing.Point(411, 392);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(107, 26);
            this.lbTK.TabIndex = 21;
            this.lbTK.Text = "Tài Khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(666, 519);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(108, 34);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPassWord.Location = new System.Drawing.Point(749, 392);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(147, 26);
            this.txtPassWord.TabIndex = 18;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTaiKhoan.Location = new System.Drawing.Point(545, 392);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(147, 26);
            this.txtTaiKhoan.TabIndex = 17;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.BackColor = System.Drawing.Color.Chocolate;
            this.lbMK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMK.Location = new System.Drawing.Point(924, 392);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(97, 26);
            this.lbMK.TabIndex = 19;
            this.lbMK.Text = "Mật khẩu";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.Location = new System.Drawing.Point(430, 5);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(0, 20);
            this.lbAdmin.TabIndex = 23;
            // 
            // txtAdmin
            // 
            this.txtAdmin.AcceptsReturn = true;
            this.txtAdmin.Enabled = false;
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.Location = new System.Drawing.Point(1093, 1);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(251, 26);
            this.txtAdmin.TabIndex = 24;
            // 
            // lbNameAdmin
            // 
            this.lbNameAdmin.AutoSize = true;
            this.lbNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAdmin.Location = new System.Drawing.Point(1021, 4);
            this.lbNameAdmin.Name = "lbNameAdmin";
            this.lbNameAdmin.Size = new System.Drawing.Size(66, 20);
            this.lbNameAdmin.TabIndex = 25;
            this.lbNameAdmin.Text = "Admin : ";
            // 
            // QuanLyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbNameAdmin);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyThuVien";
            this.Text = "QuanLyThuVien";
            this.Load += new System.EventHandler(this.QuanLyThuVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLBanDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLLoaiSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLMuonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLNhaXuatBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLChiTietMuonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLChiTietTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraSachTreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.ToolStripMenuItem ChangeSkin;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lbNameAdmin;
    }
}