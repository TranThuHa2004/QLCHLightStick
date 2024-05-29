using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.Remoting.Messaging;
using DAL;


namespace DAL
{
    public class DAL_DonHangBan : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetDHB()
        {
            string strGetDHB = "select * from DonHangBan";
            return getData(strGetDHB);
        }

        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from DonHangBan where maDHB = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemDHB(DonHangBan dhb)
        {
            string sql = "Insert into DonHangBan values('" + dhb.maDHB + "', N'" + dhb.maNV + "',N'" + dhb.tenKH + "', '" + dhb.ngayBan.ToString("yyyy-MM-dd") + "', '" + dhb.TongThanhToan + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaDHB(DonHangBan dhb)
        {
            string sql = "Update DonHangBan set maNV = '" + dhb.maNV + "', maKH = '" + dhb.tenKH + "', ngayBan = '" + dhb.ngayBan.ToString("yyyy-MM-dd") + "', TongThanhToan = '" + dhb.TongThanhToan + "' where maDHB = '" + dhb.maDHB + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaDHB(string ma)
        {
            string sql = "Delete from DonHangBan where maDHB = '" + ma + "'";
            Thucthi(sql);
            return true;
        }

        public DataTable TimDHB(DateTime ngayBan)
        {
            string strGetDHB = "select * from DonHangBan where ngayBan = '" + ngayBan.ToString("yyyy-MM-dd") + "'";
            return getData(strGetDHB);
        }
    }
}
