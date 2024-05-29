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
    public class BUS_ChitietDHN
    {
        DAL_ChitietDHN dalctdhn = new DAL_ChitietDHN();

        public DataTable GetCTDHN()
        {
            return dalctdhn.GetCTDHN();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalctdhn.kiemtramatrung(ma);
        }
        public bool ThemCTDHN(ChitietDHN ctdhn)
        {
            return dalctdhn.ThemCTDHN(ctdhn);
        }
        public bool SuaCTDHN(ChitietDHN ctdhn)
        {
            return dalctdhn.SuaCTDHN(ctdhn);
        }
        public bool XoaCTDHN(string ma)
        {
            return dalctdhn.XoaCTDHN(ma);
        }

    }
}
