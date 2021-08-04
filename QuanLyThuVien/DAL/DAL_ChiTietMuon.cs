using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
   public class DAL_ChiTietMuon : DAL_Connect
    {
        public DataTable HienThiChiTietMuon()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThiChiTietMuon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
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
        public bool ThemChiTietMuon(ET_ChiTietMuon eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemCTMuon", _con);
                cmd.CommandText = "sp_ThemCTMuon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
               
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

        //xoa
        public bool XoaChiTietMuon(ET_ChiTietMuon eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaChiTietMuon", _con);
                cmd.CommandText = "sp_XoaChiTietMuon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
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
        public bool SuaChiTietMuon(ET_ChiTietMuon eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaCTMuon", _con);
                cmd.CommandText = "sp_SuaCTMuon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
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
        //in phieu muon
        public DataTable InPhieuMuonCaNhan(ET_ChiTietMuon eT)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_InPhieuMuonTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
    }
}
