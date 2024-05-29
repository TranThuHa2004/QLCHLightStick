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
    public class DAL_KhachHang: DBConnect
    {
        DBConnect connect = new DBConnect();
        //hiển thị danh sách nhân viên
        public DataTable GetKhachHang()
        {
            string strGetKH = "select * from KhachHang";
            return getData(strGetKH);
        }

        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from KhachHang where MaKH = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemKH(KhachHang kh)
        {
            string sql = "Insert into KhachHang values('" + kh.maKH + "', N'" + kh.tenKH + "', N'" + kh.gioiTinh + "', '" + kh.diaChi + "', '" + kh.sdtKH + "','" + kh.maDHB + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaKH(KhachHang kh)
        {
            string sql = "Update KhachHang set tenKH = N'" + kh.tenKH + "', gioiTinh = N'" + kh.gioiTinh + "', diaChi = N'" + kh.diaChi + "', sdtKH = N'" + kh.sdtKH + "', maDHB = N'" + kh.maDHB + "' where maKH = '" + kh.maKH + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaKH(string ma)
        {
            string sql = "Delete from KhachHang where maKH = '" + ma + "'";
            Thucthi(sql);
            return true;
        }

        public DataTable LayMaKHTheoTen(string tenKH)
        { 
        
            string strGetKH = "select maKH from KhachHang  where tenKH = '" + tenKH +"'"; // tìm kiếm mã khách hàng theo tên khách => phục vụ combobox
            return getData(strGetKH);
        }
    }
}
