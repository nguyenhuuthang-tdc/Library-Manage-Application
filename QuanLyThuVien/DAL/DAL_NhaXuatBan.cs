using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;
namespace DAL
{
    public class DAL_NhaXuatBan: DAL_Connect
    {
        //hien thi nha xuat ban
        public DataTable HienThiNXB()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThiNXB";
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
        public bool ThemNXB(ET_NhaXuatBan eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNXB", _con);
                cmd.CommandText = "sp_ThemNXB";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaNXB", eT.MaNXB);
                cmd.Parameters.AddWithValue("@TenNXB", eT.TenNXB);
                cmd.Parameters.AddWithValue("@DiaChi", eT.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", eT.SDT);
                
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
        public bool XoaNXB(ET_NhaXuatBan eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaNXB", _con);
                cmd.CommandText = "sp_XoaNXB";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaNXB", eT.MaNXB);
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
        //sua
        public bool SuaNXB(ET_NhaXuatBan eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaNXB", _con);
                cmd.CommandText = "sp_SuaNXB";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaNXB", eT.MaNXB);
                cmd.Parameters.AddWithValue("@TenNXB", eT.TenNXB);
                cmd.Parameters.AddWithValue("@DiaChi", eT.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", eT.SDT);
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
