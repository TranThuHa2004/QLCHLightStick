using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class ChitietDHN
    {
        public string ctDHN { get; set; }
        public string maDHN { get; set; }
        public string maLT { get; set; }
        public float giaTien { get; set; }
        public int soLuong { get; set; }
        public float TongTien { get; set; }
        public ChitietDHN(string ctDHN,string maDHN, string maLT, float giaTien, int soLuong, float TongTien)
        {
            this.ctDHN = ctDHN;
            this.maDHN = maDHN;
            this.maLT = maLT;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
            this.TongTien = TongTien;
        }
    }
}
