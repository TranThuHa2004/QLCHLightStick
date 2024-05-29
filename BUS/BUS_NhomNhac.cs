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
    public class BUS_NhomNhac
    {
       DAL_NhomNhac dalnn= new DAL_NhomNhac();
        public DataTable GetNhomNhac()
        {
            return dalnn.GetNhomNhac();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalnn.kiemtramatrung(ma);
        }
        public bool ThemNN(NhomNhac nn)
        {
            return dalnn.ThemNN(nn);
        }
        public bool SuaNN(NhomNhac nn)
        {
            return dalnn.SuaNN(nn);
        }
        public bool XoaNN(string ma)
        {
            return dalnn.XoaNN(ma);
        }
    }
}
