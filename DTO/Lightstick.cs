using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class Lightstick
    {
        public string maLT { get; set; }
        public string tenLT { get; set; }
        public string maNN { get; set; }
        public string soLuong { get; set; }
        public string giaTien { get; set; }

        public Lightstick( string maLT,string tenLT,string maNN,string soLuong,string giaTien) 
        {
            this.maLT = maLT;
            this.tenLT = tenLT;
            this.maNN = maNN;
            this.soLuong = soLuong;
            this.giaTien = giaTien;
        }
    }
}
