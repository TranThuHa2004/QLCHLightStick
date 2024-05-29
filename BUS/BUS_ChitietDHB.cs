using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChitietDHB
    {
        DAL_ChitietDHB dalctdhb = new DAL_ChitietDHB();
        public DataTable GetCTDHB()
        {
            return dalctdhb.GetCTDHB();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalctdhb.kiemtramatrung(ma);
        }
        public bool ThemCTDHB(ChitietDHB ctdhb)
        {
            return dalctdhb.ThemCTDHB(ctdhb);
        }
        public bool SuaCTDHB(ChitietDHB ctdhb)
        {
            return dalctdhb.SuaCTDHB(ctdhb);
        }
        public bool XoaCTDHB(string ma)
        {
            return dalctdhb.XoaCTDHB(ma);
        }
    }
}
