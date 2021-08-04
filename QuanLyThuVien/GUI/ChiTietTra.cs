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
    public partial class ChiTietTra : Form
    {
        public ChiTietTra()
        {
            InitializeComponent();
        }
        // toan cuc
        BUS_ChiTietTra bus_ChiTietTra = new BUS_ChiTietTra();
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_MuonSach bus_MuonSach = new BUS_MuonSach();
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_ChiTietTra etCTTra = new ET_ChiTietTra(cbMaMuon.SelectedValue.ToString(), cbMaSach.SelectedValue.ToString(), txtSoLuong.Text, dateTraThucTe.Text);
            try
            {
                if (bus_ChiTietTra.busThemCTTra(etCTTra) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvChiTietTra.DataSource = bus_ChiTietTra.busHienThiChiTietTra();
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

        private void ChiTietTra_Load(object sender, EventArgs e)
        {
            dgvChiTietTra.DataSource = bus_ChiTietTra.busHienThiChiTietTra();
            cbMaMuon.DataSource = bus_MuonSach.busHienThiMuonSach();
            cbMaMuon.DisplayMember = "MaMuon";
            cbMaMuon.ValueMember = "MaMuon";
            cbMaSach.DataSource = bus_Sach.busHienThiSach();
            cbMaSach.DisplayMember = "TenSach";
            cbMaSach.ValueMember = "MaSach";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_ChiTietTra etTra = new ET_ChiTietTra(cbMaMuon.SelectedValue.ToString());
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_ChiTietTra.busXoaCTTra(etTra) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvChiTietTra.DataSource = bus_ChiTietTra.busHienThiChiTietTra();
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
            ET_ChiTietTra etTra = new ET_ChiTietTra(cbMaMuon.SelectedValue.ToString(), cbMaSach.SelectedValue.ToString(), txtSoLuong.Text, dateTraThucTe.Text);
            try
            {
                if (bus_ChiTietTra.busSuaChiTietTra(etTra) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvChiTietTra.DataSource = bus_ChiTietTra.busHienThiChiTietTra();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChiTietTra.Rows.Count; i++)
            {
                ET_Sach etupdate = new ET_Sach(dgvChiTietTra.Rows[i].Cells[1].Value.ToString(), dgvChiTietTra.Rows[i].Cells[2].Value.ToString());
                try
                {
                    if (bus_Sach.busCapNhatSoLuongTra(etupdate) == false)
                    {
                        MessageBox.Show("Không Sửa Được");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }
            }
            MessageBox.Show("đã cập nhật số lượng sách");
            ET_ChiTietTra eTInPhieu = new ET_ChiTietTra(cbMaMuon.SelectedValue.ToString());
            rptInPhieuTraTheoMa pTTM = new rptInPhieuTraTheoMa();
            pTTM.SetDataSource(bus_ChiTietTra.busInPhieuTraCaNhan(eTInPhieu));
            frmInPhieuTraTheoMa f = new frmInPhieuTraTheoMa();
            f.crystalReportViewer1.ReportSource = pTTM;
            f.ShowDialog();
        }

        private void dgvChiTietTra_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvChiTietTra.SelectedRows)
            {
                cbMaMuon.SelectedValue = row.Cells[0].Value.ToString();
                cbMaSach.SelectedValue = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                dateTraThucTe.Text = row.Cells[3].Value.ToString();
            }
        }
    }

}

