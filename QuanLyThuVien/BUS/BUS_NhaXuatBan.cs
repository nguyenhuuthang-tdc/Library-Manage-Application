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
    public class BUS_NhaXuatBan
    {
        //tao them ban doc
        DAL_NhaXuatBan NXB = new DAL_NhaXuatBan();
        public bool busThemNXB(ET_NhaXuatBan eT)
        {
            return NXB.ThemNXB(eT);
        }
        //hien thi 
        public DataTable busHienThiNXB()
        {
            DataTable dt = new DataTable();
            dt = NXB.HienThiNXB();
            return dt;
        }
        //xoa
        public bool busXoaNXB(ET_NhaXuatBan eT)
        {
            return NXB.XoaNXB(eT);
        }

        //Sua
        public bool busSuaNXB(ET_NhaXuatBan eT)
        {
            return NXB.SuaNXB(eT);
        }
    }
}
