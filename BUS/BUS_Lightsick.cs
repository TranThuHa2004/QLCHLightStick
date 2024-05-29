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
    public class BUS_Lightsick
    {
        DAL_Lightstick dallt = new DAL_Lightstick();
        public DataTable GetLT()
        {
            return dallt.GetLT();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dallt.kiemtramatrung(ma);
        }
        public bool ThemLT(Lightstick lt)
        {
            return dallt.ThemLT(lt);
        }
        public bool SuaLT(Lightstick lt)
        {
            return dallt.SuaLT(lt);
        }
        public bool XoaLT(string ma)
        {
            return dallt.XoaLT(ma);
        }
        public bool TangSoLuong(string ma, int soLuong)
        {
            return dallt.TangSoLuong(ma, soLuong);//phương thức Tăng số lượng khi nhập hàng hoặc khi huỷ đơn hàng bán
        }
        public bool GiamSoLuong(string ma, int soLuong)
        {
            return dallt.GiamSoLuong(ma, soLuong);//phương thức giảm số lượng khi huỷ nhập hàng hoặc khi thêm đơn hàng bán
        }
    }
}
