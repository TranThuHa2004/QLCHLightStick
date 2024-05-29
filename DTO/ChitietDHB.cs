using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DTO
{
    public class ChitietDHB
    {
        public string ctDHB { get; set; }
        public string maDHB { get; set; }
        public string maLT { get; set; }
        public float giaTien { get; set; }
        public int soLuong { get; set; }
        public float TongTien { get; set; }

        public ChitietDHB(string ctHDB,string maDHB, string maLT,float giaTien, int soLuong,  float TongTien )
        {
            this.ctDHB = ctHDB;
            this.maDHB = maDHB;
            this.maLT = maLT;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
            this.TongTien = TongTien;
        }
    }
}
