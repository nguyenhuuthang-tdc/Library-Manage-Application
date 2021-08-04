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
    public class BUS_ChiTietTra
    {
        DAL_ChiTietTra ctTra = new DAL_ChiTietTra();
        public bool busThemCTTra(ET_ChiTietTra eT)
        {
            return ctTra.ThemChiTietTra(eT);
        }
        //hien thi 
        public DataTable busHienThiChiTietTra()
        {
            DataTable dt = new DataTable();
            dt = ctTra.HienThiChiTietTra();
            return dt;
        }
        //xoa loai sach
        public bool busXoaCTTra(ET_ChiTietTra eT)
        {
            return ctTra.XoaChiTietTra(eT);
        }

        //Sua loai sach
        public bool busSuaChiTietTra(ET_ChiTietTra eT)
        {
            return ctTra.SuaChiTietTra(eT);
        }
        //in phieu tra ca nhan theo ma 
        public DataTable busInPhieuTraCaNhan(ET_ChiTietTra eT)
        {
            DataTable dt = new DataTable();
            dt = ctTra.InPhieuTraCaNhan(eT);
            return dt;
        }
    }
}

