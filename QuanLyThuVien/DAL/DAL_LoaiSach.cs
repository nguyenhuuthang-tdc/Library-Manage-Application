using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DAL_LoaiSach : DAL_Connect
    {
        //hien thi
        public DataTable HienThiLoaiSach()
        {
            DataTable dt = new DataTable();
            try
            {                
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThi";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }catch(Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }

        //them
        public bool ThemLoaiSach(ET_LoaiSach eT)
        {            
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemLoaiSach", _con);
                cmd.CommandText = "sp_ThemLoaiSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaLoai", eT.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", eT.TenLoai);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    kQ = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return kQ;
        }

        //xoa
        public bool XoaLoaiSach(ET_LoaiSach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaLoaiSach", _con);
                cmd.CommandText = "sp_XoaLoaiSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaLoai", eT.MaLoai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kQ = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return kQ;
        }

        //Sua
        public bool SuaLoaiSach(ET_LoaiSach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaLoaiSach", _con);
                cmd.CommandText = "sp_SuaLoaiSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaLoai", eT.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", eT.TenLoai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kQ = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return kQ;
        }
    }
}