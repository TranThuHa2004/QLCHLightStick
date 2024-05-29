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
    public class BUS_DonHangNhap
    {
        DAL_DonHangNhap daldhn = new DAL_DonHangNhap();
        DAL_ChitietDHN dalctn = new DAL_ChitietDHN();
        public DataTable GetDHN()
        {
            return daldhn.GetDHN();
        }
        public int KiemTraMaTrung(string ma)
        {
            return daldhn.kiemtramatrung(ma);
        }
        public bool ThemDHN(DonHangNhap dhn)
        {
            return daldhn.ThemDHN(dhn);
        }
        public bool SuaDHN(DonHangNhap dhn)
        {
            return daldhn.SuaDHN(dhn);
        }
        public bool XoaDHN(string ma)
        {
            return daldhn.XoaDHN(ma);
        }
        public DataTable TimDHN(DateTime NgayNhap)
        {
            return daldhn.TimDHN(NgayNhap);
        }
        public float TongTien(string maDHN)
        {
            return dalctn.TongTien(maDHN);// tính tổng tiền ở bảng chi tiết nhập và cập nhật lên tổng tiền ở bảng đơn hàng nhập
        }

    }
}
