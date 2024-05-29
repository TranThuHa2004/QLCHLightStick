using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con;
        public SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string chuoikn = @"Data Source=LAPTOP-CSRDQ59V;Initial Catalog=Do_an1;Integrated Security=True;Encrypt=False";
        public void Ketnoi()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void NgatKetNoi()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void Thucthi(string sql)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            NgatKetNoi();
        }
        public DataTable getData(string sql)
        {
            Ketnoi();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public int kiemtramatrung(string ma, string sql)
        {
            Ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            NgatKetNoi();
            return i;
        }
        public DataTable GetMaNCC()
        {
            string sql = "SELECT maNCC FROM NhaCungCap";
            return getData(sql);
        }
    }
}
