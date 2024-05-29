using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class NhomNhac
    {
        public string maNN { get; set; }
        public string tenNN { get; set; }
        public string maNCC { get; set; }

        public NhomNhac(string maNN,string tenNN,string maNCC) 
        {
            this.maNN = maNN;
            this.tenNN = tenNN;
            this.maNCC = maNCC;
        }
    }
}
