using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class NhaCungCap
    {
        public string maNCC { get; set; }
        public string tenNCC { get; set; }

        public string diaChi { get; set; }
        public string sdtNCC { get; set; }

        public NhaCungCap(string maNCC,string tenNCC,string diaChi, string sdtNCC) 
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sdtNCC = sdtNCC;
        }
    }
}
