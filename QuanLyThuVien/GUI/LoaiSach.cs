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
    public partial class frmLoaiSach : Form
    {
        public frmLoaiSach()
        {
            InitializeComponent();
        }
        //toàn cục
        BUS_LoaiSach busLoai = new BUS_LoaiSach();
        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            dgvLoaiSach.DataSource = busLoai.busHienThiLoaiSach();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_LoaiSach etLoai = new ET_LoaiSach(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (busLoai.busThemLoai(etLoai) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvLoaiSach.DataSource = busLoai.busHienThiLoaiSach();
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
            ET_LoaiSach etLoai = new ET_LoaiSach(txtMaLoai.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (busLoai.busXoaLoai(etLoai) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvLoaiSach.DataSource = busLoai.busHienThiLoaiSach();
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
            ET_LoaiSach etLoai = new ET_LoaiSach(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (busLoai.busSuaLoai(etLoai) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvLoaiSach.DataSource = busLoai.busHienThiLoaiSach();
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
        private void dgvLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLoaiSach.SelectedRows)
            {
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
