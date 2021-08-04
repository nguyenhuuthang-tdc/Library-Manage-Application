using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    public class ET_LoaiSach
    {
        private string maLoai;
        private string tenLoai;
        private string tenThuThu;
        public string MaLoai
        {
            get { return maLoai; } 
            set { maLoai = value; }
        }
        
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        public string TenThuThu
        {
            get
            {
                return tenThuThu;
            }

            set
            {
                tenThuThu = value;
            }
        }

        public ET_LoaiSach(string ma,string ten)
        {
            this.MaLoai = ma;
            this.TenLoai = ten;
        }
        public ET_LoaiSach(string ma)
        {
            this.MaLoai = ma;
        }

        public ET_LoaiSach(string maLoai, string tenLoai, string tenThuThu)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.tenThuThu = tenThuThu;
        }
    }
}
