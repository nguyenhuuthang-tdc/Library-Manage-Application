using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using ET;

namespace DAL
{
  public  class DAL_MuonSach : DAL_Connect
    {
        //hien thi
        public DataTable HienThiMuonSach()
        {
            DataTable dtMuonSach = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiMuonSach", _con);
                cmd.CommandText = "sp_HienThiMuonSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtMuonSach);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return dtMuonSach;
        }

        //them
        public bool ThemMuonSach(ET_MuonSach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemMuonSach", _con);
                cmd.CommandText = "sp_ThemMuonSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaBD", eT.MaBD);                
                cmd.Parameters.AddWithValue("@NgayMuon", eT.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", eT.NgayTra);
                cmd.Parameters.AddWithValue("@TrangThai", eT.TrangThai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    kQ = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ", ex);
            }
            finally
            {
                _con.Close();
            }
            return kQ;
        }

        //xoa
        public bool XoaMuonSach(ET_MuonSach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaMuonSach", _con);
                cmd.CommandText = "sp_XoaMuonSach";
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
        public bool SuaMuonSach(ET_MuonSach eT)
        {
            bool kQ = false;
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaMuonSach", _con);
                cmd.CommandText = "sp_SuaMuonSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                cmd.Parameters.AddWithValue("@MaBD", eT.MaBD);
                cmd.Parameters.AddWithValue("@NgayMuon", eT.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", eT.NgayTra);
                cmd.Parameters.AddWithValue("@TrangThai", eT.TrangThai);
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
        //tim thong tin sach bang ma 
        public DataTable InThongTinPhieuMuonTheoMa(ET_MuonSach eT)
        {
            DataTable dtMuonSach = new DataTable();
           
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiMuonSachBangMa", _con);
                cmd.CommandText = "sp_HienThiMuonSachBangMa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.Parameters.AddWithValue("@MaMuon", eT.MaMuon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtMuonSach);                
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi", ex);
            }
            finally
            {
                _con.Close();
            }
            return dtMuonSach;
        }
        //in danh sach tra tre
        public DataTable InDSTraTre()
        {
            DataTable dt = new DataTable();
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_TreHan";
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

    }
}
