using System;
using System.Data; 
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    internal class DBHelper
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLThuVien;Integrated Security=True; TrustServerCertificate=True";
        public SqlConnection Getconnection() => new SqlConnection(connectionString);
        private SqlCommand CreateCommand(string query, SqlConnection sqlCon, SqlParameter[] para = null, bool isStoredProc = false)
        {
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            if (isStoredProc)
                cmd.CommandType = CommandType.StoredProcedure;
            if (para != null && para.Length > 0)
            {
                cmd.Parameters.AddRange(para);
            }
            return cmd;
        }
        public DataTable ExecuteQuery(string query, SqlParameter[] para = null, bool isStoredProc = false)
        {
            using (var con = Getconnection())
            using (var cmd = CreateCommand(query, con, para, isStoredProc))
            using (var adt = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }
        //Những câu lệnh không phải truy vấn select (
        public int ExecuteNonQuery(string query, SqlParameter[] para = null, bool isStoredProc = false)
        {
            try
            {
                using (var con = Getconnection())
                using (var cmd = CreateCommand(query, con, para, isStoredProc))
                {
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message); 
                return -1; // Hoặc xử lý lỗi theo cách khác
            }
        }
        //Trả về 1 giá trị đơn 
        public object ExecuteScalar(string query, SqlParameter[] para = null, bool isStoredProc = false)
        {
            using (var con = Getconnection())
            using (var cmd = CreateCommand(query, con, para, isStoredProc))
            {
                con.Open(); return cmd.ExecuteScalar();
            }
        }

    }
}
