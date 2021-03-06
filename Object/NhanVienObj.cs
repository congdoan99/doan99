﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau;
        DateTime namsinh;

        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, DateTime namsinh, string diachi, string sdt, string matkhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.matkhau = matkhau;

        }
    }
}
