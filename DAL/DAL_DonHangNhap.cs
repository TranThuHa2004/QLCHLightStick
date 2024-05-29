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
    public class DAL_DonHangNhap : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetDHN()
        {
            string strGetDHN = "select * from DonHangNhap";
            return getData(strGetDHN);
        }
        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from DonHangNhap where maDHN = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemDHN(DonHangNhap dhn) 
        {
            string sql = "Insert into DonHangNhap values('" + dhn.maDHN + "', '" + dhn.maNCC + "', '" + dhn.maNV + "', '" + dhn.ngayNhap.ToString("yyyy-MM-dd") + "', '" + dhn.TongThanhToan + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaDHN(DonHangNhap dhn)
        {
            string sql = "Update DonHangNhap set maNCC = '" + dhn.maNCC + "', maNV = '" + dhn.maNV + "', ngayNhap = '" + dhn.ngayNhap.ToString("yyyy-MM-dd") + "', TongThanhToan = '" + dhn.TongThanhToan + "' where maDHN = '" + dhn.maDHN + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaDHN(string ma)
        {
            string sql = "Delete from DonHangNhap where maDHN = '" + ma + "'";
            Thucthi(sql);
            return true;
        }

        public DataTable TimDHN(DateTime ngayNhap)
        {
            string strGetDHN = "select * from DonHangNhap where ngayNhap = '" + ngayNhap.ToString("yyyy-MM-dd") + "'";
            return getData(strGetDHN);
        }

        //tìm kiếm

    }
}
