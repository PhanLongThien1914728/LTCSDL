using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thông_tin_giáo_viên_khoa_CNTT
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }

        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoTen, DateTime ngaySinh, DanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.dsMonHoc = ds;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ Tên:" + HoTen + "\n"
                + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                + "Giới tính:" + GioiTinh + "\n"
                + "Số ĐT:" + SoDT + "\n"
                + "Mail:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = "Danh sách môn dạy:";
            foreach (MonHoc mh in dsMonHoc.ds)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}
