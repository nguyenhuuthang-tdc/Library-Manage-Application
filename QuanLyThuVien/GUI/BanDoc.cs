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
    public partial class frmBanDoc : Form
    {
        public frmBanDoc()
        {
            InitializeComponent();
        }

        BUS_BanDoc busBanDoc = new BUS_BanDoc();
        private void frmBanDoc_Load(object sender, EventArgs e)
        {
            dgvBanDoc.DataSource = busBanDoc.busHienThiBanDoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            ET_BanDoc etBanDoc = new ET_BanDoc(txtMaBD.Text, txtTenBD.Text, dtpNgaySinh.Text, gioiTinh , txtDoiTuong.Text, txtDiaChi.Text, txtSDT.Text);
            try
            {
                if (busBanDoc.busThemBanDoc(etBanDoc) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvBanDoc.DataSource = busBanDoc.busHienThiBanDoc();
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
            ET_BanDoc etBanDoc = new ET_BanDoc(txtMaBD.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (busBanDoc.busXoaBanDoc(etBanDoc) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvBanDoc.DataSource = busBanDoc.busHienThiBanDoc();
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
            string gioiTinh = "";
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            ET_BanDoc etBanDoc = new ET_BanDoc(txtMaBD.Text, txtTenBD.Text, dtpNgaySinh.Text, gioiTinh, txtDoiTuong.Text, txtDiaChi.Text, txtSDT.Text);
            try
            {
                if (busBanDoc.busSuaBanDoc(etBanDoc) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvBanDoc.DataSource = busBanDoc.busHienThiBanDoc();
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
        private void dgvBanDoc_SelectionChanged(object sender, EventArgs e)
        {
            string gioiTinh = "";
            foreach (DataGridViewRow row in dgvBanDoc.SelectedRows)
            {
                txtMaBD.Text = row.Cells[0].Value.ToString();
                txtTenBD.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                gioiTinh = row.Cells[3].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {

                    radNu.Checked = true;
                }
                txtDoiTuong.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
