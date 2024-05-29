using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class NhanVien
    {
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdtNV { get; set; }
        public int Luong { get; set; }

        public NhanVien(string maNV, string tenNV, string gioiTinh, string diaChi, string sdtNV, int Luong)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdtNV= sdtNV;
            this.Luong = Luong;
            
        }
    }
}
