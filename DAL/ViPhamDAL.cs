using QLTVNhom3.DTO;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLTVNhom3.DAL
{
    public class ViPhamDAL
    {
        private DBHelper db = new DBHelper();

        public DataTable GetDanhSachViPham()
        {
            string query = "SELECT * FROM LOAIVIPHAM";
            return db.ExecuteQuery(query);
        }

        public DataTable TimKiemViPham(string tuKhoa)
        {
            string query = "SELECT * FROM LOAIVIPHAM WHERE TenLoi LIKE @TuKhoa";
            SqlParameter[] param = {
                new SqlParameter("@TuKhoa", $"%{tuKhoa}%")
            };
            return db.ExecuteQuery(query, param);
        }

        public bool ThemViPham(ViPhamDTO dto)
        {
            string query = @"
                INSERT INTO LOAIVIPHAM (TenLoi, MucPhat, LoaiViPham, MoTa)
                VALUES (@TenLoi, @MucPhat, @LoaiViPham, @MoTa)";

            SqlParameter[] param = {
                new SqlParameter("@TenLoi", dto.TenLoi),
                new SqlParameter("@MucPhat", dto.MucPhat),
                new SqlParameter("@LoaiViPham", dto.LoaiViPham),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value)
            };
            return db.ExecuteNonQuery(query, param) > 0;
        }

        public bool CapNhatViPham(ViPhamDTO dto)
        {
            string query = @"
                UPDATE LOAIVIPHAM
                SET TenLoi = @TenLoi,
                    MucPhat = @MucPhat,
                    LoaiViPham = @LoaiViPham,
                    MoTa = @MoTa
                WHERE MaLoi = @MaLoi";

            SqlParameter[] param = {
                new SqlParameter("@TenLoi", dto.TenLoi),
                new SqlParameter("@MucPhat", dto.MucPhat),
                new SqlParameter("@LoaiViPham", dto.LoaiViPham),
                new SqlParameter("@MoTa", (object)dto.MoTa ?? DBNull.Value),
                new SqlParameter("@MaLoi", dto.MaLoi)
            };
            return db.ExecuteNonQuery(query, param) > 0;
        }

        public bool XoaViPham(int maLoi)
        {
            string query = "DELETE FROM LOAIVIPHAM WHERE MaLoi = @MaLoi";
            SqlParameter[] parameters = {
                new SqlParameter("@MaLoi", maLoi)
            };
            // SỬA LỖI CS0029
            return db.ExecuteNonQuery(query, parameters) > 0;
        }
        public DataTable GetDistinctLoaiViPham()
        {
            string query = "SELECT DISTINCT LoaiViPham FROM LOAIVIPHAM WHERE LoaiViPham IS NOT NULL";
            return db.ExecuteQuery(query);
        }
    }
}