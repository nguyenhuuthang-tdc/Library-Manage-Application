
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
  public  class ET_ChiTietTra
    {
        private string maMuon;
        private string maSach;
        private string soLuong;
        private string ngayTraThucTe;

        public ET_ChiTietTra(string maMuon, string maSach, string soLuong, string ngayTraThucTe)
        {
            this.maMuon = maMuon;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.ngayTraThucTe = ngayTraThucTe;
        }
        public ET_ChiTietTra(string maMuon)
        {
            this.maMuon = maMuon;
           
        }
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

        public string NgayTraThucTe
        {
            get
            {
                return ngayTraThucTe;
            }

            set
            {
                ngayTraThucTe = value;
            }
        }
    }
}
