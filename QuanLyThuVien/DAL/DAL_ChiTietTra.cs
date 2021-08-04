using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using ET;
namespace DAL
{
   public class DAL_ChiTietTra:DAL_Connect
    {

        public DataTable HienThiChiTietTra()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThiChiTietTra";
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
        public bool ThemChiTietTra(ET_ChiTietTra eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemCTTra", _con);
                cmd.CommandText = "sp_ThemCTTra";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
                cmd.Parameters.AddWithValue("@NgayTraThucTe", eT.NgayTraThucTe);
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
        public bool XoaChiTietTra(ET_ChiTietTra eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaChiTietTra", _con);
                cmd.CommandText = "sp_XoaChiTietTra";
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
        public bool SuaChiTietTra(ET_ChiTietTra eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaCTTra", _con);
                cmd.CommandText = "sp_SuaCTTra";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
                cmd.Parameters.AddWithValue("@NgayTraThucTe", eT.NgayTraThucTe);

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
        //in phieu tra
        public DataTable InPhieuTraCaNhan(ET_ChiTietTra eT)
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_InPhieuTraTheoMa";
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
