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
    public class DAL_ChitietDHN : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable GetCTDHN()
        {
            string strGetCTDHN = "select * from ChiTietDonHangNhap";
            return getData(strGetCTDHN);
        }
        //ktra mã trùng
        public int kiemtramatrung(string ma)
        {
            Ketnoi();
            int i;
            string sql = "Select count(*) from ChiTietDonHangNhap where maDHN = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm nhân viên
        public bool ThemCTDHN(ChitietDHN ctdhn)
        {
            string sql = "Insert into ChiTietDonHangNhap values('" + ctdhn.ctDHN + "','" + ctdhn.maDHN + "', N'" + ctdhn.maLT + "', N'" + ctdhn.giaTien + "', '" + ctdhn.soLuong + "', '" + ctdhn.TongTien + "')";
            Thucthi(sql);
            return true;
        }

        // sửa nhân viên
        public bool SuaCTDHN(ChitietDHN ctdhn)
        {
            string sql = "Update ChiTietDonHangNhap set maDHN = '" + ctdhn.maDHN + "', maLT = '" + ctdhn.maLT + "', giaTien = '" + ctdhn.giaTien + "', soLuong = '" + ctdhn.soLuong + "', TongTien = '" + ctdhn.TongTien + "' where ctDHN = '" + ctdhn.ctDHN + "'";
            Thucthi(sql);
            return true;
        }

        // xóa 
        public bool XoaCTDHN(string ma)
        {
            string sql = "Delete from ChiTietDonHangNhap where maDHN = '" + ma + "'";
            Thucthi(sql);
            return true;
        }
        // Tính tổng tiền ở bảng chi tiết nhập cho cột tổng tiền trong bảng đơn hàng nhập qua mã đơn hàng nhập
        public float TongTien(string maDHN)
        {
            float tongTien = 0;
            try
            {
                Ketnoi(); // Kiểm tra và mở kết nối nếu cần
                using (SqlCommand cmd = new SqlCommand("dbo.TongThanhToanDHN", con)) //using kết nối đến SQL
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDHN", maDHN);

                    var result = cmd.ExecuteScalar();// thực thi truy vấn sql và trả về kết quả là tổng tiền
                    if (result != null)
                    {
                        tongTien = Convert.ToSingle(result);// chuyển đổi kiểu dữ liệu thành float 
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ghi log hoặc hiển thị thông báo lỗi)
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
