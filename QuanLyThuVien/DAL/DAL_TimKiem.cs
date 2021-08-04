using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DAL_TimKiem : DAL_Connect
    {
        //tim kiem ban doc
        public DataTable KetQuaBanDoc(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_FindBanDoc",_con);
                cmd.CommandText = "sp_FindBanDoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter da = new SqlDataAdapter(cmd);                                 
                da.Fill(dt);                    
            }
            catch(Exception ex)
            {
                throw new Exception("Loi " + ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
        //tim kiem loai sach
        public DataTable KetQuaLoaiSach(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_FindLoaiSach", _con);
                cmd.CommandText = "sp_FindLoaiSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Loi " + ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
        //tim kiem sach
        public DataTable KetQuaSach(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_FindSach", _con);
                cmd.CommandText = "sp_FindSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@key", key);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Loi " + ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
        //tim kiem phieu muon
        public DataTable KetQuaPhieMuon(string maBD,string maSach)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_FindPhieuMuon", _con);
                cmd.CommandText = "sp_FindPhieuMuon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MABD", maBD);
                cmd.Parameters.AddWithValue("@MASACH", maSach);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Loi " + ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
    }
}
