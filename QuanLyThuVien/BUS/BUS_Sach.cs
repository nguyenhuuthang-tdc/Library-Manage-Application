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
    public class BUS_Sach
    {
        //tao them sach
        DAL_Sach sach = new DAL_Sach();
        public bool busThemSach(ET_Sach eT)
        {
            return sach.ThemSach(eT);
        }
        //hien thi 
        public DataTable busHienThiSach()
        {
            DataTable dt = new DataTable();
            dt = sach.HienThiSach();
            return dt;
        }
        //xoa loai sach
        public bool busXoaSach(ET_Sach eT)
        {
            return sach.XoaSach(eT);
        }

        //Sua loai sach
        public bool busSuaLoai(ET_Sach eT)
        {
            return sach.SuaSach(eT);
        }
        //cap nhat so luong
        public bool busCapNhatSoLuong(ET_Sach eT)
        {
           return sach.CapNhatSoLuong(eT);
        }
        //cap nhat so luong tra
        public bool busCapNhatSoLuongTra(ET_Sach eT)
        {
            return sach.CapNhatSoLuongTra(eT);
        }
    }
}
