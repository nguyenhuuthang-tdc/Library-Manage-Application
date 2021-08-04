using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    public class ET_NhaXuatBan
    {
        private string maNXB;
        private string tenNXB;
        private string diaChi;
        private string sDT;
        //propaties
        public string MaNXB
        {
            get
            {
                return maNXB;
            }

            set
            {
                maNXB = value;
            }
        }

        public string TenNXB
        {
            get
            {
                return tenNXB;
            }

            set
            {
                tenNXB = value;
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
        public string SDT
        {
            get
            {
                return sDT;
            }

            set
            {
                sDT = value;
            }
        }
        //constructor
        public ET_NhaXuatBan(string maNXB, string tenNXB, string diaChi,string sDT)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;
            this.sDT = sDT;
        }
        public ET_NhaXuatBan(string maNXB)
        {
            this.maNXB = maNXB;            
        }
    }
}
