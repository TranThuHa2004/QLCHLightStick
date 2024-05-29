using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO; 
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_DonHangBan
    {
        DAL_DonHangBan daldhb = new DAL_DonHangBan();
        DAL_ChitietDHB dalctb = new DAL_ChitietDHB();
        public DataTable GetDHB()
        {
            return daldhb.GetDHB();
        }
        public int KiemTraMaTrung(string ma)
        {
            return daldhb.kiemtramatrung(ma);
        }
        public bool ThemDHB(DonHangBan dhb)
        {   
            return daldhb.ThemDHB(dhb);
        }
        public bool SuaDHB(DonHangBan dhb)
        {
            return daldhb.SuaDHB(dhb);
        }
        public bool XoaDHB(string ma)
        {
            return daldhb.XoaDHB(ma);
        }
        public DataTable TimDHB(DateTime NgayBan)
        {
            return daldhb.TimDHB(NgayBan);
        }
        public float TongTien(string maHDB)
        {
            return dalctb.TongTien(maHDB);// tính tổng tiền ở bảng chi tiết bán và cập nhật lên tổng tiền ở bảng đơn hàng bán
        }
    }
}