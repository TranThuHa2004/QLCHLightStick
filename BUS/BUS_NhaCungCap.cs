using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
using BUS;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalncc = new DAL_NhaCungCap();
        public DataTable GetNhaCungCap()
        {
            return dalncc.GetNhaCungCap();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalncc.kiemtramatrung(ma);
        }
        public bool ThemNCC(NhaCungCap ncc)
        {
            return dalncc.ThemNCC(ncc);
        }
        public bool SuaNCC(NhaCungCap ncc)
        {
            return dalncc.SuaNCC(ncc);
        }
        public bool XoaNCC(string ma)
        {
            return dalncc.XoaNCC(ma);
        }
    }
}
