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
    public partial class ChiTietMuon : Form
    {
        public ChiTietMuon()
        {
            InitializeComponent();
        }
        // toan cuc
        BUS_ChiTietMuon bus_ChiTietMuon = new BUS_ChiTietMuon();
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_MuonSach bus_MuonSach = new BUS_MuonSach();
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_ChiTietMuon etCTMuon = new ET_ChiTietMuon(cbMaMuon.SelectedValue.ToString(), cbMaSach.SelectedValue.ToString(), txtSoLuong.Text);
            try
            {
                if (bus_ChiTietMuon.busThemCTMuon(etCTMuon) == true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgvChiTietMuon.DataSource = bus_ChiTietMuon.busHienThiChiTietMuon();
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

        private void ChiTietMuon_Load(object sender, EventArgs e)
        {
            dgvChiTietMuon.DataSource = bus_ChiTietMuon.busHienThiChiTietMuon();
            cbMaMuon.DataSource = bus_MuonSach.busHienThiMuonSach();
            cbMaMuon.DisplayMember = "MaMuon";
            cbMaMuon.ValueMember = "MaMuon";
            cbMaSach.DataSource = bus_Sach.busHienThiSach();
            cbMaSach.DisplayMember = "TenSach";
            cbMaSach.ValueMember = "MaSach";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_ChiTietMuon etSach = new ET_ChiTietMuon(cbMaMuon.SelectedValue.ToString());
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_ChiTietMuon.busXoaCTMuon(etSach) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgvChiTietMuon.DataSource = bus_ChiTietMuon.busHienThiChiTietMuon();
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
            ET_ChiTietMuon etSach = new ET_ChiTietMuon(cbMaMuon.SelectedValue.ToString(), cbMaSach.SelectedValue.ToString(), txtSoLuong.Text);
            try
            {
                if (bus_ChiTietMuon.busSuaChiTietMuon(etSach) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvChiTietMuon.DataSource = bus_ChiTietMuon.busHienThiChiTietMuon();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChiTietMuon.Rows.Count; i++)
            {
                ET_Sach etupdate = new ET_Sach(dgvChiTietMuon.Rows[i].Cells[1].Value.ToString(), dgvChiTietMuon.Rows[i].Cells[2].Value.ToString());
                try
                {
                    if(bus_Sach.busCapNhatSoLuong(etupdate) == false)
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
            ET_ChiTietMuon eTInPhieu = new ET_ChiTietMuon(cbMaMuon.SelectedValue.ToString());
            rptPhieuMuonCaNhan pMCN = new rptPhieuMuonCaNhan();
            pMCN.SetDataSource(bus_ChiTietMuon.busInPhieuMuonCaNhan(eTInPhieu));
            FormInPhieuMuonTheoMa f = new FormInPhieuMuonTheoMa();
            f.crystalReportViewer1.ReportSource = pMCN;
            f.ShowDialog();
        }

        private void dgvChiTietMuon_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvChiTietMuon.SelectedRows)
            {
                cbMaMuon.SelectedValue = row.Cells[0].Value.ToString();
                cbMaSach.SelectedValue = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
