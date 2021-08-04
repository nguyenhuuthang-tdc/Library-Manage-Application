namespace ET
{
    public class ET_Sach
    {
        private string maSach;
        private string tenSach;
        private string maLoai;
        private string keSach;
        private string donGia;
        private string soLuong;
        private string nXB; 

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
        public string KeSach 
        {
            get { return keSach; }
            set { keSach = value; }
        }
        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public string SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string NXB
        {
            get { return nXB; }
            set { nXB = value; }
        }

        public ET_Sach(string maSach, string tenSach, string maLoai, string keSach, string donGia,string soLuong,string nXB)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.MaLoai = maLoai;
            this.KeSach = keSach;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.NXB = nXB;
        }
        public ET_Sach(string maSach)
        {
            this.MaSach = maSach;
        }
        public ET_Sach(string maSach,string soLuong)
        {
            this.maSach = maSach;
            this.soLuong = soLuong;
        }
    }

}
