using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_QuanLyThongTin
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Diachi { get; set; }
        public string Lop { get; set; }
        public string SĐT { get; set; }
        public string Email { get; set; }
        public string Hinh { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string ms, string ht, bool gt, DateTime ngay, string dc, string lop, string sđt, string email, string hinh)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.GioiTinh = gt;
            this.NgaySinh = ngay;
            this.Diachi = dc;
            this.Lop = lop;
            this.SĐT = sđt;
            this.Email = email;
            this.Hinh = hinh;
        }
    }
}
