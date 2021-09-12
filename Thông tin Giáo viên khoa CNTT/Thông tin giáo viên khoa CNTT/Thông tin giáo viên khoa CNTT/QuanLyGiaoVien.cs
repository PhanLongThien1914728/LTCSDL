﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thông_tin_giáo_viên_khoa_CNTT
{
     public class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }

        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }

        public bool Them(GiaoVien giaoVien)
        {
            var already = dsGiaoVien.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if (already) return false;

            dsGiaoVien.Add(giaoVien);

            return true;
        }

        public GiaoVien Tim(string value, KieuTim kieuTim)
        {
            GiaoVien giaoVien = null;

            switch (kieuTim)
            {
                case KieuTim.TheoMa:
                    giaoVien = dsGiaoVien.Find(gv => gv.MaSo == value);
                    break;
                case KieuTim.TheoHoTen:
                    giaoVien = dsGiaoVien.Find(gv => gv.HoTen == value);
                    break;
                case KieuTim.TheoSDT:
                    giaoVien = dsGiaoVien.Find(gv => gv.SoDT == value);
                    break;
            }
            return giaoVien;
        }

    }
}

