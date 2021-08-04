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
    public class BUS_DangNhap
    {
        DAL_DangNhap new_login = new DAL_DangNhap();
        public int Login(ET_DangNhap eT)
        {
            return new_login.Login(eT);
        }
        public int SuaMatKhau(ET_DangNhap eT)
        {
            return new_login.SuaMatKhau(eT);
        }
        public void DangXuat()
        {
             new_login.DangXuat();
        }
        public DataSet busHienThiAdmin(ET_DangNhap eT)
        {
            DataSet ds = new DataSet();
            ds = new_login.LayThongTinAdmin(eT);
            return ds;
        }
        //String lenh = "SELECT * From DangNhap WHERE TenTK ='" + taiKhoan + "' AND MatKhau = '" + matKhau + "'";
        //SqlDataAdapter da = new SqlDataAdapter(lenh, _con);
        //da.Fill(dtDangNhap);
    }
}
