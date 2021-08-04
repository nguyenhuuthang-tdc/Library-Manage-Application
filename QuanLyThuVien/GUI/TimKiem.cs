using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class Tim_Kiếm : Form
    {
        public Tim_Kiếm()
        {
            InitializeComponent();
        }
        BUS_TimKiem busTimKiem = new BUS_TimKiem();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdBanDoc.Checked == false && rdLoaiSach.Checked == false && rdSach.Checked == false)
            {
                MessageBox.Show("Hãy Chọn Loại Dữ Liệu Muốn Tìm");
            }
            if (rdBanDoc.Checked == true)
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Từ Khóa");
                }
                else
                {
                    dgvTimKiem.DataSource = busTimKiem.busHienThiKetQuaBanDoc(txtTimKiem.Text);
                }
            }
            if (rdLoaiSach.Checked == true)
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Từ Khóa");
                }
                else
                {
                    dgvTimKiem.DataSource = busTimKiem.busHienThiKetQuaLoaiSach(txtTimKiem.Text);
                }
            }
            if (rdSach.Checked == true)
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Từ Khóa");
                }
                else
                {
                    dgvTimKiem.DataSource = busTimKiem.busHienThiKetQuaSach(txtTimKiem.Text);
                }
            }
        }
    }
}
