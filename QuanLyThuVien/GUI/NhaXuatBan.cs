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
namespace GUI
{
    public partial class NhaXuatBan : Form
    {
        public NhaXuatBan()
        {
            InitializeComponent();
        }
        // toan cuc
        BUS_NhaXuatBan bus_NXB = new BUS_NhaXuatBan();        
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_NhaXuatBan eTNXB = new ET_NhaXuatBan(txtMaNXB.Text,txtTenNXB.Text,txtDiaChi.Text,txtSDT.Text);
            try
            {
                if (bus_NXB.busThemNXB(eTNXB) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvNXB.DataSource = bus_NXB.busHienThiNXB();
                }
                else
                {
                    MessageBox.Show("Không Thêm Được");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = bus_NXB.busHienThiNXB();         
        }
        //xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_NhaXuatBan eTNXB = new ET_NhaXuatBan(txtMaNXB.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_NXB.busXoaNXB(eTNXB) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvNXB.DataSource = bus_NXB.busHienThiNXB();
                    }
                    else
                    {
                        MessageBox.Show("Không Xóa Được");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_NhaXuatBan eTNXB = new ET_NhaXuatBan(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSDT.Text);
            try
            {
                if (bus_NXB.busSuaNXB(eTNXB) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvNXB.DataSource = bus_NXB.busSuaNXB(eTNXB);
                }
                else
                {
                    MessageBox.Show("Không Sửa Được");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
