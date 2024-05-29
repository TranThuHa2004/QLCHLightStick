using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting.Messaging;
using DAL;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        DBConnect connect = new DBConnect();
        //hiển thị danh sách nhân viên
        public DataTable GetNhanVien()
        {
            string strGetNV = "select * from NhanVien";
            return getData(strGetNV);
        }

        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from NhanVien where MaNV = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemNV(NhanVien nv)
        {

            string sql = "Insert into NhanVien values('" + nv.maNV + "', N'" + nv.tenNV + "', N'" + nv.gioiTinh + "',N'" + nv.diaChi + "', N'" + nv.sdtNV + "', '" + nv.Luong + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaNV(NhanVien nv)
        {
            string sql = "Update NhanVien set tenNV = N'" + nv.tenNV + "', gioiTinh = N'" + nv.gioiTinh + "', diaChi = N'" + nv.diaChi + "', sdtNV = N'" + nv.sdtNV + "', Luong = '" + nv.Luong + "' where maNV = '" + nv.maNV + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaNV(string ma)
        {
            string sql = "Delete from NhanVien where maNV = '" + ma + "'";
            Thucthi(sql);
            return true;
        }
    }
}
