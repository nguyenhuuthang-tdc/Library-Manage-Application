using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    public class ET_DangNhap
    {
        private string tenTK;
        private string matKhau;
        private string tenThuThu;

        public ET_DangNhap(string tenTK, string matKhau)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
        }

        public ET_DangNhap(string tenTK)
        {
            this.tenTK = tenTK;
        }
       
        public string TenTK
        {
            get
            {
                return tenTK;
            }

            set
            {
                tenTK = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string TenThuThu
        {
            get
            {
                return tenThuThu;
            }
        }
    }
}
