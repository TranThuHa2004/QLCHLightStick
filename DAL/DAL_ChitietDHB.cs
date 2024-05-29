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
    public class DAL_ChitietDHB : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetCTDHB()
        {
            string strGetCTDHB = "select * from ChiTietDonHangBan";
            return getData(strGetCTDHB);
        }
        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from ChiTietDonHangBan where ctDHB = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemCTDHB(ChitietDHB ctdhb)
        {
            string sql = "Insert into ChiTietDonHangBan values('" + ctdhb.ctDHB + "','" + ctdhb.maDHB + "', N'" + ctdhb.maLT + "', N'" + ctdhb.giaTien + "',  '" + ctdhb.soLuong + "','" + ctdhb.TongTien + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaCTDHB(ChitietDHB ctdhb)
        {
            string sql = "Update ChiTietDonHangBan set maDHB='" + ctdhb.maDHB + "', maLT = N'" + ctdhb.maLT + "',giaTien = N'" + ctdhb.giaTien + "', soLuong = N'" + ctdhb.soLuong + "' ,  TongTien = '" + ctdhb.TongTien + "' where ctDHB = '" + ctdhb.ctDHB + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaCTDHB(string ma)
        {
            string sql = "Delete from ChiTietDonHangBan where maDHB = '" + ma + "'";
            Thucthi(sql);
            return true;
        }
        // Tính tổng tiền ở bảng chi tiết bán cho cột tổng tiền trong bảng đơn hàng bán qua mã đơn hàng bán
        public float TongTien(string MaHDB)
        {
            float tongTien = 0;
            try
            {
                Ketnoi(); // Kiểm tra và mở kết nối nếu cần
                using (SqlCommand cmd = new SqlCommand("dbo.TongThanhToanDHB", con)) //using kết nối SQL 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDHB", MaHDB);//thêm tham số vào sqlcommand

                    var result = cmd.ExecuteScalar();// thực thi truy vấn sql và trả về kết quả là tổng tiền
                    if (result != null)
                    {
                        tongTien = Convert.ToSingle(result);// chuyển đổi kiểu dữ liệu thành float 
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine(ex.Message);
            }
            finally
            {
                NgatKetNoi(); // Đảm bảo ngắt kết nối sau khi sử dụng
            }
            return tongTien;
        }
    }
}
