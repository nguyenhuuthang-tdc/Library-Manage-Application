using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
     public class ET_ChiTietMuon
    {
        private string maMuon;
        private string maSach;
        private string soLuong;

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

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public ET_ChiTietMuon(string maMuon, string maSach, string soLuong)
        {
            this.MaMuon = maMuon;
            this.MaSach = maSach;
            this.SoLuong = soLuong;
        }
        public ET_ChiTietMuon(string maMuon)
        {
            this.MaMuon = maMuon;
        }

    }
}
