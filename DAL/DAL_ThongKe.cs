using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThongKe
    {
        // phương thức kết nối đến SQL
        private readonly string connectionString = @"Data Source=LAPTOP-CSRDQ59V;Initial Catalog=Do_an1;Integrated Security=True;Encrypt=False";

        public DataTable HangBanChay(DateTime fromDate, DateTime toDate)// dữ liệu đầu vào là khoảng thời gian nhập từ bàn phím
        {
            using (SqlConnection connection = new SqlConnection(connectionString))// using được sử dụng để quản lý kết nối đến cơ sở dữ liệu
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("HangBanChay", connection))
                {
                    // kết nối tới thủ tục
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
        public DataTable HangTonKho(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("HangTonKho", connection))
                {
                    // kết nối tới thủ tục
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
