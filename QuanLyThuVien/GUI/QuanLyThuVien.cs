using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using ET;
using System.IO;
using System.Diagnostics;
using Sunisoft.IrisSkin;


namespace GUI
{
    public partial class QuanLyThuVien : Form
    {
        BUS_DangNhap login = new BUS_DangNhap();
        BUS_TimKiem busTimKiem = new BUS_TimKiem();
        BUS_MuonSach ms = new BUS_MuonSach();
        public QuanLyThuVien()
        {
            InitializeComponent();
            se = new SkinEngine();
            se.SerialNumber = "n7cKULtvGKV9Xvrwywp6jEjZtTJqexLVUVJm+5BfuNMgk1tYsIPRmw==";
            se.BuiltIn = true;
            se.SkinFile = "skins\\Vista.ssk";
            se.SkinAllForm = true;
            se.Active = false;
            loadSkinsMenu();
        }
         private SkinEngine se;
        //Hàm đổi giao diện khi click
        private void skinmenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem skinmenu = (ToolStripMenuItem)sender;
            //Giao diện mặc định
            foreach (ToolStripMenuItem ts in ChangeSkin.DropDownItems)
            {
                ts.Checked = false;
            }
            if (skinmenu == ChangeSkin.DropDownItems[0])
            {
                se.SkinAllForm = false;
                se.Active = false;
                skinmenu.Checked = true;
                return;
            }
            string skinlocation = "skins\\" + skinmenu.Text + ".ssk";
            loadSkin(skinlocation);            
            skinmenu.Checked = true;
        }
        //Hàm load skin menu
        private void loadSkinsMenu()
        {
            try
            {
                string[] files = Directory.GetFiles("skins", "*.ssk", SearchOption.TopDirectoryOnly);
                ToolStripMenuItem[] skinmenu = new ToolStripMenuItem[files.Length];                
                ToolStripMenuItem defaultSkin = new ToolStripMenuItem();
                defaultSkin.Text = "Mặc định";
                defaultSkin.Checked = true;
                defaultSkin.Click += new EventHandler(skinmenu_Click);
                ChangeSkin.DropDownItems.Add(defaultSkin);                
                for (int i = 0; i < files.Length; i++)
                {
                    string[] temp = files[i].Split('\\');                    
                    temp = temp[temp.Length - 1].Split('.');
                    skinmenu[i] = new ToolStripMenuItem();
                    skinmenu[i].Text = temp[0];
                    skinmenu[i].Click += new EventHandler(skinmenu_Click);
                    ChangeSkin.DropDownItems.Add(skinmenu[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Load skin với path truyền vào
        private void loadSkin(string skinFile)
        {
            try
            {
                se.SkinFile = skinFile;
                se.SkinAllForm = true;                
                se.Active = true;                
            }
            catch 
            {
                MessageBox.Show("Thay đổi giao diện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void qLBanDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanDoc bd = new frmBanDoc();
            bd.Show();
        }

        private void qLLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSach ls = new frmLoaiSach();
            ls.Show();
        }

        private void qLMuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonSach ms = new frmMuonSach();
            ms.Show();
        }

        private void qLNhaXuatBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.Show();
        }

        private void qLSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach s = new frmSach();
            s.Show();
        }

        private void qLChiTietMuonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietMuon ctm = new ChiTietMuon();
            ctm.Show();
        }

        private void qLChiTietTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietTra ctt = new ChiTietTra();
            ctt.Show();
        }

        private void phieuMuonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptSach sach = new rptSach();
            FormInSach frmSach = new FormInSach();
            frmSach.rpt4.ReportSource = sach;
            frmSach.Show();           
        }

        

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.DangXuat();
            MessageBox.Show("Đăng xuất thành công", "Thông báo");
            txtAdmin.Clear();   
            quanLyToolStripMenuItem.Enabled = false;
            thongTinToolStripMenuItem.Enabled = false;
            heThongToolStripMenuItem.Enabled = false;
            timKiemToolStripMenuItem.Enabled = false;
            lbTK.Show();
            lbMK.Show();
            txtTaiKhoan.ResetText();
            txtPassWord.ResetText();
            txtTaiKhoan.Show();
            txtPassWord.Show();
            btnDangNhap.Show();
          
        }
        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tim_Kiếm tk = new Tim_Kiếm();
            tk.Show();
        }

        private void QuanLyThuVien_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ET_DangNhap eT = new ET_DangNhap(txtTaiKhoan.Text, txtPassWord.Text);
            if (txtTaiKhoan.Text == "" && txtPassWord.Text == "")
            {
                DialogResult r = MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lưu ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    txtTaiKhoan.Focus();
                }
                else
                {
                    this.Refresh();
                }
            }
            else
            {
                if (txtTaiKhoan.Text == "")
                {
                    DialogResult r = MessageBox.Show("Vui lòng nhập tên người dùng!", "Lưu ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (r == DialogResult.OK)
                    {
                        txtTaiKhoan.Focus();
                    }
                    else
                    {
                        this.Refresh();
                    }
                }
                else
                {
                    if (txtPassWord.Text == "")
                    {
                        DialogResult r = MessageBox.Show("Vui lòng nhập mật khẩu!", "Lưu ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (r == DialogResult.OK)
                        {
                            txtPassWord.Focus();
                        }
                        else
                        {
                            this.Refresh();
                        }
                    }
                    else
                    {
                        try
                        {
                            if (login.Login(eT) == 1)
                            {
                                MessageBox.Show("Đăng nhập thành công", "Thông báo");                              
                                quanLyToolStripMenuItem.Enabled = true;
                                thongTinToolStripMenuItem.Enabled = true;
                                heThongToolStripMenuItem.Enabled = true;
                                timKiemToolStripMenuItem.Enabled = true;                                
                                lbTK.Hide();
                                lbMK.Hide();                                
                                txtTaiKhoan.Hide();
                                txtPassWord.Hide();
                                btnDangNhap.Hide();
                                txtAdmin.DataBindings.Clear();
                                txtAdmin.DataBindings.Add("text", login.busHienThiAdmin(eT), "DangNhap.TenThuThu");
                            }
                            else
                            {
                                MessageBox.Show("Sai thông tin", "Thông báo");
                                txtAdmin.Text = "";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi!", "Thông báo");
                        }                        
                    }
                }
            }
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dMK = new frmDoiMatKhau();
            dMK.Show();
        }

        private void TraSachTreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptTreHan treHan = new rptTreHan();
            treHan.SetDataSource(ms.busTreHan());
            FrmTreHancs f = new FrmTreHancs();
            f.crystalReportViewer1.ReportSource = treHan;
            f.ShowDialog();
        }
    }
}
