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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        
        BUS_Sach busSach = new BUS_Sach();
        BUS_LoaiSach busLoaiSach = new BUS_LoaiSach();
        BUS_NhaXuatBan busNXB = new BUS_NhaXuatBan();
        private void frmSach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = busSach.busHienThiSach();
            cbMaLoai.DataSource = busLoaiSach.busHienThiLoaiSach();
            cbMaLoai.DisplayMember = "TenLoai";
            cbMaLoai.ValueMember = "MaLoai";
            cbNXB.DataSource = busNXB.busHienThiNXB();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_Sach etSach = new ET_Sach(txtMaSach.Text, txtTenSach.Text, cbMaLoai.SelectedValue.ToString(), txtKeSach.Text, txtDonGia.Text,txtSoLuong.Text,cbNXB.SelectedValue.ToString());
            try
            {
                if (busSach.busThemSach(etSach) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvSach.DataSource = busSach.busHienThiSach();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_Sach etSach = new ET_Sach(txtMaSach.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (busSach.busXoaSach(etSach) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvSach.DataSource = busSach.busHienThiSach();
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
            ET_Sach etSach = new ET_Sach(txtMaSach.Text, txtTenSach.Text, cbMaLoai.SelectedValue.ToString(), txtKeSach.Text, txtDonGia.Text,txtSoLuong.Text,cbNXB.SelectedValue.ToString());
            try
            {
                if (busSach.busSuaLoai(etSach) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvSach.DataSource = busSach.busHienThiSach();
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

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSach.SelectedRows)
            {
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                cbMaLoai.SelectedValue = row.Cells[2].Value.ToString();
                txtKeSach.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                cbNXB.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
