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
    public class BUS_BanDoc
    {
        //tao them ban doc
        DAL_BanDoc banDoc = new DAL_BanDoc();
        public bool busThemBanDoc(ET_BanDoc eT)
        {
            return banDoc.ThemBanDoc(eT);
        }
        //hien thi 
        public DataTable busHienThiBanDoc()
        {
            DataTable dt = new DataTable();
            dt = banDoc.HienThiBanDoc();
            return dt;
        }
        //xoa
        public bool busXoaBanDoc(ET_BanDoc eT)
        {
            return banDoc.XoaBanDoc(eT);
        }

        //Sua
        public bool busSuaBanDoc(ET_BanDoc eT)
        {
            return banDoc.SuaBanDoc(eT);
        }
    }
}
