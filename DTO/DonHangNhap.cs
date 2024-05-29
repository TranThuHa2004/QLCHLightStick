using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class DonHangNhap
    {
        public string maDHN { get; set; }
        public string maNCC { get; set; }
        public string maNV { get; set; }
        public DateTime ngayNhap { get; set; }
        public float TongThanhToan {  get; set; }

        public DonHangNhap(string maDHN,string maNCC,string maNV,DateTime ngayNhap, float TongThanhToan) 

        {
            this.maDHN = maDHN;
            this.maNCC = maNCC;
            this.maNV = maNV;
            this.ngayNhap = ngayNhap;
            this.TongThanhToan = TongThanhToan;
        }
    }
}
