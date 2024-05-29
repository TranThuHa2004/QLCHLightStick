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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkh= new DAL_KhachHang();
        public DataTable GetKhachHang()
        {
            return dalkh.GetKhachHang();
        }
        public DataTable LayMaKHTheoTen(string tenKH)
        {
            return dalkh.LayMaKHTheoTen(tenKH);// phương thức lấy ra mã khách hàng theo tên khách hàng, liên kết combobox bảng đơn hàng bán
        }
        public int KiemTraMaTrung(string ma)
        {
            return dalkh.kiemtramatrung(ma);
        }
        public bool ThemKH(KhachHang kh)
        {
            return dalkh.ThemKH(kh);
        }
        public bool SuaKH(KhachHang kh)
        {
            return dalkh.SuaKH(kh);
        }
        public bool XoaKH(string ma)
        {
            return dalkh.XoaKH(ma);
        }
    }
}

