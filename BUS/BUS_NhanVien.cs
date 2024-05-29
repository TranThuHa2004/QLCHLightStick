using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable GetNhanVien()
        {
            return dalnv.GetNhanVien();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool ThemNV(NhanVien nv)
        {
            return dalnv.ThemNV(nv);
        }
        public bool SuaNV(NhanVien nv)
        {
            return dalnv.SuaNV(nv);
        }
        public bool XoaNV(string ma)
        {
            return dalnv.XoaNV(ma);
        }
    }
}
