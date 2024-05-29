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
    public class DAL_Lightstick : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetLT()
        {
            string strGetLT = "select * from Lightstick";
            return getData(strGetLT);
        }
        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from Lightstick where maLT = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemLT(Lightstick lt)
        {
            string sql = "Insert into Lightstick values('" + lt.maLT + "', N'" + lt.tenLT + "', N'" + lt.maNN + "', '" + lt.soLuong + "', '" + lt.giaTien + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaLT(Lightstick lt)
        {
            string sql = "Update Lightstick set tenLT = N'" + lt.tenLT + "', maNN = N'" + lt.maNN + "', soLuong = N'" + lt.soLuong + "', giaTien = N'" + lt.giaTien + "' where maLT = '" + lt.maLT + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaLT(string ma)
        {
            string sql = "Delete from Lightstick where maLT = '" + ma + "'";
            Thucthi(sql);
            return true;
        }
        // phương thức tăng số lượng mặt hàng bằng truy vấn đề thủ tục tăng số lượng ở SQL
        public bool TangSoLuong(string ma, int soLuong)
        {
            try
            {
                con.Open();
                string strTang = "EXEC SoLuongTang @maLT  = " + ma + ", @soLuong = " + soLuong + "";// câu lệnh thực thi thủ tục tăng
                SqlCommand cmd = new SqlCommand(strTang, con);
                if (cmd.ExecuteNonQuery() > 0)// nếu có dữ liệu thì là > 0
                {
                    return true;// trả về true và đến finally đóng SQL
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        // phương thức giảm số lượng mặt hàng bằng truy vấn đề thủ tục giảm số lượng ở SQL
        public bool GiamSoLuong(string ma, int soLuong)
        {
            try
            {
                con.Open();
                string strTang = "EXEC SoLuongGiam @maLT  = " + ma + ", @soLuong = " + soLuong + "";// câu lệnh thực thi thủ tục giảm
                if (cmd.ExecuteNonQuery() > 0)// nếu có dữ liệu thì là > 0
                {
                    return true;// trả về true và đến finally đóng SQL
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        //tìm kiếm
    }
}
