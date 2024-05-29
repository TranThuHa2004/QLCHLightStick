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
    public class DAL_NhomNhac : DBConnect
    {
        DBConnect connect = new DBConnect();

        public DataTable GetNhomNhac()
        {
            string strGetNN = "select * from NhomNhac";
            return getData(strGetNN);
        }

        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from NhomNhac where maNN = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm 
        public bool ThemNN(NhomNhac nn)
        {
            string sql = "Insert into NhomNhac values('" + nn.maNN + "', N'" + nn.tenNN + "', N'" + nn.maNCC + "')";
            Thucthi(sql);
            return true;
        }

        // sửa 
        public bool SuaNN(NhomNhac nn)
        {
            string sql = "Update NhomNhac set tenNN = N'" + nn.tenNN + "', maNCC = N'" + nn.maNCC + "' where maNN = '" + nn.maNN + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaNN(string ma)
        {
            string sql = "Delete from NhomNhac where maNN = '" + ma + "'";
            Thucthi(sql);
            return true;
        }
    }
}
