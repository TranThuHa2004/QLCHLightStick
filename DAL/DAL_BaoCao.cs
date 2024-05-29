using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_BaoCao
    {
        // Phương thức tạo đường dẫn kêt nối tới SQL
        private readonly string connectionString = @"Data Source=LAPTOP-CSRDQ59V;Initial Catalog=Do_an1;Integrated Security=True;Encrypt=False";

        public DataTable BaoCaoDoanhThu(DateTime fromDate, DateTime toDate)
        {
            // using chủ yếu được dùng để kết nối tới SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("BaoCaoDoanhThu", connection))
                {
                    // khai báo thủ tục và kết nối tới thủ tục qua SqlCommand
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Khoảng thời gian nhập từ bàn phím
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
