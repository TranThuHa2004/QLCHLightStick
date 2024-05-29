using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class DonHangBan
    {
        public string maDHB{ get; set; }
        public string maNV { get; set; }
        public string tenKH { get; set; }
        public DateTime ngayBan { get; set; }
        public float TongThanhToan { get; set; }

        public DonHangBan(string maDHB, string maNV, string tenKH, DateTime ngayBan, float tongThanhToan)
        {
            this.maDHB = maDHB;
            this.maNV = maNV;
            this.tenKH = tenKH;
            this.ngayBan = ngayBan;
            TongThanhToan = tongThanhToan;  
        }
    }
}
