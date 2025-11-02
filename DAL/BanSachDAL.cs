using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class BanSachDAL
    {
        private DBHelper db = new DBHelper();
        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            List<BanSachDTO> danhSach = new List<BanSachDTO>();
            string query = @"
            SELECT 
                s.MaSach,
                s.MaDauSach,
                s.MaTinhTrang,
                tt.TenTinhTrang
            FROM SACH s
            INNER JOIN TINHTRANG tt ON s.MaTinhTrang = tt.MaTinhTrang
            WHERE s.MaDauSach = @MaDauSach
            ORDER BY s.MaSach";
            using (SqlConnection conn = db.Getconnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    danhSach.Add(new BanSachDTO
                    {
                        MaSach = reader["MaSach"].ToString(),
                        MaDauSach = reader["MaDauSach"].ToString(),
                        MaTinhTrang = Convert.ToInt32(reader["MaTinhTrang"]),
                        TenTinhTrang = reader["TenTinhTrang"].ToString()
                    });
                }
            }
            return danhSach;
        }
        public int DemSoSachSanCo(string maDauSach)
        {
            string query = @"
            SELECT COUNT(*)
            FROM SACH s
            INNER JOIN TINHTRANG tt ON s.MaTinhTrang = tt.MaTinhTrang
            WHERE s.MaDauSach = @MaDauSach 
            AND tt.TenTinhTrang = N'Có sẵn'";

            using (SqlConnection conn = db.Getconnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
