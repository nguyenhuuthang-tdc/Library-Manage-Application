using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DAL;

namespace BUS
{
    public class BUS_TimKiem
    {
        //tao DAL Tim Kiem
        DAL_TimKiem timKiem = new DAL_TimKiem();
        //tim kiem ban doc
        public DataTable busHienThiKetQuaBanDoc(string key)
        {
            return timKiem.KetQuaBanDoc(key);
        }
        //tim kiem loai sach
        public DataTable busHienThiKetQuaLoaiSach(string key)
        {
            return timKiem.KetQuaLoaiSach(key);
        }
        //tim kiem sach
        public DataTable busHienThiKetQuaSach(string key)
        {
            return timKiem.KetQuaSach(key);
        }
        //tim kiem phieu muon
        public DataTable busHienThiKetQuaPhieMuon(string MABD,string MASACH)
        {
            return timKiem.KetQuaPhieMuon(MABD,MASACH);
        }
    }
}
