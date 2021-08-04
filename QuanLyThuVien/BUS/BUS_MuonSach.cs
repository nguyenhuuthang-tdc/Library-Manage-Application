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
   public class BUS_MuonSach
    {
            //tao them muon sach
            DAL_MuonSach muonsach = new DAL_MuonSach();

            public bool busThemMuonSach(ET_MuonSach eT)
            {
                return muonsach.ThemMuonSach(eT);
            }
            //hien thi 
            public DataTable busHienThiMuonSach()
            {
                DataTable dt = new DataTable();
                dt = muonsach.HienThiMuonSach();
                return dt;
            }
            //xoa loai sach
            public bool busXoaMuonSach(ET_MuonSach eT)
            {
                return muonsach.XoaMuonSach(eT);
            }
            //Sua loai sach
            public bool busSuaMuonSach(ET_MuonSach eT)
            {
                return muonsach.SuaMuonSach(eT);
            }
            //In Thong Tin PHieu Muon Theo Ma
             public DataTable busInPhieuMuonTheoMa(ET_MuonSach eT)
            {
                return muonsach.InThongTinPhieuMuonTheoMa(eT);
            }
            //tre han
            public DataTable busTreHan()
            {
                DataTable dt = new DataTable();
                dt = muonsach.InDSTraTre();
                return dt;
            }
    }
}
