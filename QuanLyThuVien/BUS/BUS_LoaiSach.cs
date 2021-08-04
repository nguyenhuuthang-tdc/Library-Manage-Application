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
    public class BUS_LoaiSach
    {
        //tao them loai sach
        DAL_LoaiSach loaiSach = new DAL_LoaiSach();
        public bool busThemLoai(ET_LoaiSach eT)
        {
            return loaiSach.ThemLoaiSach(eT);
        }
        //hien thi 
        public DataTable busHienThiLoaiSach()
        {
            DataTable dt = new DataTable();
            dt = loaiSach.HienThiLoaiSach();
            return dt;
        }
        //xoa loai sach
        public bool busXoaLoai(ET_LoaiSach eT)
        {
            return loaiSach.XoaLoaiSach(eT);
        }

        //Sua loai sach
        public bool busSuaLoai(ET_LoaiSach eT)
        {
            return loaiSach.SuaLoaiSach(eT);
        }
    }
}
