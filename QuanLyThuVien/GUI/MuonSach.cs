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
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }
        // toan cuc
        BUS_BanDoc bus_BanDoc = new BUS_BanDoc();
        BUS_MuonSach bus_MuonSach = new BUS_MuonSach();
        private void MuonSach_Load(object sender, EventArgs e)
        {
            dgvMuonSach.DataSource = bus_MuonSach.busHienThiMuonSach();
            cbMaBD.DataSource = bus_BanDoc.busHienThiBanDoc();
            cbMaBD.DisplayMember = "TenBD";
            cbMaBD.ValueMember = "MaBD";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {              
                ET_MuonSach etmuon = new ET_MuonSach(txtMaMuon.Text,cbMaBD.SelectedValue.ToString(), dateMuon.Text, dateTra.Text, txtTrangThai.Text);
                try
                {
                    if (bus_MuonSach.busThemMuonSach(etmuon) == true)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        dgvMuonSach.DataSource = bus_MuonSach.busHienThiMuonSach();
                    }
                    else
                    {
                        MessageBox.Show("Không Thêm Được","Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_MuonSach etMuonSach = new ET_MuonSach(txtMaMuon.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_MuonSach.busXoaMuonSach(etMuonSach) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvMuonSach.DataSource = bus_MuonSach.busHienThiMuonSach();
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
            ET_MuonSach etmuon = new ET_MuonSach(txtMaMuon.Text, cbMaBD.SelectedValue.ToString(), dateMuon.Text, dateTra.Text, txtTrangThai.Text);
            try
            {
                if (bus_MuonSach.busSuaMuonSach(etmuon) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvMuonSach.DataSource = bus_MuonSach.busHienThiMuonSach();
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
        private void dgvMuonSach_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMuonSach.SelectedRows)
            {
                txtMaMuon.Text = row.Cells[0].Value.ToString();
                cbMaBD.SelectedValue = row.Cells[1].Value.ToString();                
                dateMuon.Text = row.Cells[2].Value.ToString();
                dateTra.Text = row.Cells[3].Value.ToString();
                txtTrangThai.Text = row.Cells[4].Value.ToString();
            }
        }        
    }
}
