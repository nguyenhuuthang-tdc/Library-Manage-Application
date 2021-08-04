using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DAL_BanDoc : DAL_Connect
    {
        public DataTable HienThiBanDoc()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_HienThiBanDoc";
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
        public bool ThemBanDoc(ET_BanDoc eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemBanDoc", _con);
                cmd.CommandText = "sp_ThemBanDoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaBD", eT.MaBanDoc);
                cmd.Parameters.AddWithValue("@TenBD", eT.TenBanDoc);
                cmd.Parameters.AddWithValue("@NgaySinh", eT.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", eT.GioiTinh);
                cmd.Parameters.AddWithValue("@DoiTuong", eT.DoiTuong);
                cmd.Parameters.AddWithValue("@DiaChi", eT.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", eT.SoDienThoai);
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
        public bool XoaBanDoc(ET_BanDoc eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaBanDoc", _con);
                cmd.CommandText = "sp_XoaBanDoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaBD", eT.MaBanDoc);
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
        public bool SuaBanDoc(ET_BanDoc eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaBanDoc", _con);
                cmd.CommandText = "sp_SuaBanDoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaBD", eT.MaBanDoc);
                cmd.Parameters.AddWithValue("@TenBD", eT.TenBanDoc);
                cmd.Parameters.AddWithValue("@NgaySinh", eT.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", eT.GioiTinh);
                cmd.Parameters.AddWithValue("@DoiTuong", eT.DoiTuong);
                cmd.Parameters.AddWithValue("@DiaChi", eT.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", eT.SoDienThoai);
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
