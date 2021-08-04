using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DAL_Sach : DAL_Connect
    {
        //hien thi
        public DataTable HienThiSach()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThiSach";
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
        public bool ThemSach(ET_Sach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemSach", _con);
                cmd.CommandText = "sp_ThemSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                SqlParameter paraMaSach = new SqlParameter("@MaSach", eT.MaSach);
                SqlParameter paraTenSach = new SqlParameter("@TenSach", eT.TenSach);
                SqlParameter paraMaLoai = new SqlParameter("@MaLoai", eT.MaLoai);
                SqlParameter paraKeSach = new SqlParameter("@KeSach", eT.KeSach);
                SqlParameter paraDonGia = new SqlParameter("@DonGia", eT.DonGia);
                SqlParameter paraSoLuong = new SqlParameter("@SoLuong", eT.SoLuong);
                SqlParameter paraNXB = new SqlParameter("@MaNXB", eT.NXB);
                cmd.Parameters.Add(paraMaSach);
                cmd.Parameters.Add(paraTenSach);
                cmd.Parameters.Add(paraMaLoai);
                cmd.Parameters.Add(paraKeSach);
                cmd.Parameters.Add(paraDonGia);
                cmd.Parameters.Add(paraSoLuong);
                cmd.Parameters.Add(paraNXB);

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
        public bool XoaSach(ET_Sach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSach", _con);
                cmd.CommandText = "sp_XoaSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
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
        public bool SuaSach(ET_Sach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaSach", _con);
                cmd.CommandText = "sp_SuaSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", eT.TenSach);
                cmd.Parameters.AddWithValue("@MaLoai", eT.MaLoai);
                cmd.Parameters.AddWithValue("@KeSach", eT.KeSach);
                cmd.Parameters.AddWithValue("@DonGia", eT.DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
                cmd.Parameters.AddWithValue("@MaNXB", eT.NXB);
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
        //Cap Nhat So Luong
        public bool CapNhatSoLuong(ET_Sach eT)
        {
             bool kq = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateTotalOfBook", _con);
                cmd.CommandText = "sp_UpdateTotalOfBook";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kq = true;
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
            return kq;
        }
        //Cap Nhat So Luong Tra
        public bool CapNhatSoLuongTra(ET_Sach eT)
        {
            bool kq = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateTotalOfBookTra", _con);
                cmd.CommandText = "sp_UpdateTotalOfBookTra";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaSach", eT.MaSach);
                cmd.Parameters.AddWithValue("@SoLuong", eT.SoLuong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kq = true;
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
            return kq;
        }
    }
}
