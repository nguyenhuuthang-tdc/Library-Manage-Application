using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using ET;
namespace BUS
{
   public class BUS_ChiTietMuon
    {
        DAL_ChiTietMuon ctmuon = new DAL_ChiTietMuon();
        public bool busThemCTMuon(ET_ChiTietMuon eT)
        {
            return ctmuon.ThemChiTietMuon(eT);
        }
        //hien thi 
        public DataTable busHienThiChiTietMuon()
        {
            DataTable dt = new DataTable();
            dt = ctmuon.HienThiChiTietMuon();
            return dt;
        }
        //xoa loai sach
        public bool busXoaCTMuon(ET_ChiTietMuon eT)
        {
            return ctmuon.XoaChiTietMuon(eT);
        }

        //Sua loai sach
        public bool busSuaChiTietMuon(ET_ChiTietMuon eT)
        {
            return ctmuon.SuaChiTietMuon(eT);
        }
        //in phieu muon ca nhan theo ma 
        public DataTable busInPhieuMuonCaNhan(ET_ChiTietMuon eT)
        {
            DataTable dt = new DataTable();
            dt = ctmuon.InPhieuMuonCaNhan(eT);
            return dt;
        }
    }
}
