using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
   public class ET_MuonSach
    {
        private string maMuon;
        private string maBD;        
        private string ngayMuon;
        private string ngayTra;
        private string trangThai;
        public string MaMuon
        {
            get
            {
                return maMuon;
            }

            set
            {
                maMuon = value;
            }
        }
        public string MaBD
        {
            get
            {
                return maBD;
            }

            set
            {
                maBD = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public string NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public ET_MuonSach(string maMuon, string maBD, string ngayMuon,string ngayTra, string trangThai)
        {
            this.MaMuon = maMuon;
            this.MaBD = maBD;
            this.NgayMuon = ngayMuon;
            this.NgayTra = ngayTra;
            this.TrangThai = trangThai;

        }
        public ET_MuonSach(string maMuon)
        {
           this.MaMuon = maMuon;
           
        }

    }
}
