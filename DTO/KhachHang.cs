using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdtKH { get; set; }
        public string maDHB { get; set; }

        public KhachHang(string maKH, string tenKH, string gioiTinh, string diaChi, string sdtKH, string maDHB)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdtKH = sdtKH;
            this.maDHB = maDHB;
        }
    }
}
