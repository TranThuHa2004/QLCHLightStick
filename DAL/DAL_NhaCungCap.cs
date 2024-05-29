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
    public class DAL_NhaCungCap : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetNhaCungCap()
        {
            string strGetNCC = "select * from NhaCungCap";
            return getData(strGetNCC);
        }
        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from NhaCungCap where maNCC = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }
        // Thêm nhân viên
        public bool ThemNCC(NhaCungCap ncc)
        {
            string sql = "Insert into NhaCungCap values('" + ncc.maNCC + "', N'" + ncc.tenNCC + "', '" + ncc.diaChi + "', N'" + ncc.sdtNCC + "')";
            Thucthi(sql);
            return true;
        }
        // sửa nhân viên
        public bool SuaNCC(NhaCungCap ncc)
        {
            string sql = "Update NhaCungCap set tenNCC = N'" + ncc.tenNCC + "', diachi = N'" + ncc.diaChi + "', sdtNCC = N'" + ncc.sdtNCC + "' where maNCC = '" + ncc.maNCC + "'";
            Thucthi(sql);
            return true;
        }
        // xóa 
        public bool XoaNCC(string ma)
        {
            string sql = "Delete from NhaCungCap where maNCC = '" + ma + "'";
            Thucthi(sql);
            return true;
        }


    }
}
