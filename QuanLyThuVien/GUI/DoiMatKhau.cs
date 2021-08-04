using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        BUS_DangNhap login = new BUS_DangNhap();        
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            ET_DangNhap eT = new ET_DangNhap(txtTenTK.Text,txtMKCu.Text);
            if (login.Login(eT) != 1)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng !","Thông Báo");
            }
            else
            {
                if(txtMKMoi.Text.Length <= 0)
                {
                    MessageBox.Show("Hãy Nhập Mật Khẩu Mới !", "Thông Báo");
                }
                else
                {
                    if(txtXacNhanMK.Text != txtMKMoi.Text)
                    {
                        MessageBox.Show("Xác Nhận Mật Khẩu Thất Bại !", "Thông Báo");
                    }
                    else
                    {
                        ET_DangNhap eTupdate = new ET_DangNhap(txtTenTK.Text, txtMKMoi.Text);
                        if (login.SuaMatKhau(eTupdate) != 1)
                        {
                            MessageBox.Show("Đổi Không Thành Công !", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Đổi Mật Khẩu Thành Công !", "Thông Báo");
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
