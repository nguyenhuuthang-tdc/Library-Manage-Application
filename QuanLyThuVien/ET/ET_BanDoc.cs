using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    public class ET_BanDoc
    {
        private string maBanDoc;
        private string tenBanDoc;
        private string ngaySinh;
        private string gioiTinh;
        private string doiTuong;
        private string diaChi;
        private string soDienThoai;

        public ET_BanDoc(string maBanDoc, string tenBanDoc, string ngaySinh, string gioiTinh, string doiTuong, string diaChi, string soDienThoai)
        {
            this.MaBanDoc = maBanDoc;
            this.TenBanDoc = tenBanDoc;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DoiTuong = doiTuong;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }
        public ET_BanDoc(string maBanDoc)
        {
            this.maBanDoc = maBanDoc;
        }

        public string MaBanDoc
        {
            get
            {
                return maBanDoc;
            }

            set
            {
                maBanDoc = value;
            }
        }

        public string TenBanDoc
        {
            get
            {
                return tenBanDoc;
            }

            set
            {
                tenBanDoc = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DoiTuong
        {
            get
            {
                return doiTuong;
            }

            set
            {
                doiTuong = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }
    }
}
