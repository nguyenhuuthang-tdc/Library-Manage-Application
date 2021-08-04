using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DAL_DangNhap : DAL_Connect
    {
        public int Login(ET_DangNhap eT)
        {
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", _con);
                cmd.CommandText = "sp_Login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.Add(new SqlParameter("@TenTk", eT.TenTK));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", eT.MatKhau));
           
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                   
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException se)
            {
                return -1;
                throw se;
            }
            finally
            {
                _con.Close();
            }
        }
        public int SuaMatKhau(ET_DangNhap eT)
        {
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaMatKhau", _con);
                cmd.CommandText = "sp_SuaMatKhau";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.Add(new SqlParameter("@TenTk", eT.TenTK));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", eT.MatKhau));
       
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
                else
                {
                    _con.Close();
                    return 0;
                }      
            }
            catch (SqlException se)
            {
                return -1;
                throw se;
            }            
        }
        //lay thong tin admin
        public DataSet LayThongTinAdmin(ET_DangNhap eT)
        {
            DataSet dsDangNhap = new DataSet();

            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_LayThongTinAdmin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.Add(new SqlParameter("@TenTk", eT.TenTK));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", eT.MatKhau));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsDangNhap,"DangNhap");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }      
            finally
            {
                _con.Close();
            }      
            return dsDangNhap;
        }
        public void DangXuat()
        {
            _con.Close();
        }

    }
}
