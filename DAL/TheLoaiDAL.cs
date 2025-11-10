using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLTVNhom3.DAL
{
    public class TheLoaiDAL
    {
        private DBHelper db = new DBHelper();
        private const string SELECT_QUERY = @"SELECT MaTheLoai, TenTheLoai FROM THELOAI";

        public List<TheLoaiDTO> GetDanhSachTheLoai()
        {
            string query = SELECT_QUERY;
            DataTable dt = db.ExecuteQuery(SELECT_QUERY);
            return ConvertToDTOList(dt);
        }
        public List<TheLoaiDTO> TimKiemTheLoai(string keyword)
        {
            string query = SELECT_QUERY + @" 
                WHERE MaTheLoai LIKE N'%' + @keyword + N'%' 
                   OR TenTheLoai LIKE N'%' + @keyword + N'%'
                ORDER BY MaTheLoai DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);
            return ConvertToDTOList(dt);
        }
        public int ThemTheLoai(string tenTheLoai)
        {
            string query = @"INSERT INTO THELOAI (TenTheLoai) VALUES (@TenTheLoai);
                             SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters = {
                new SqlParameter("@TenTheLoai", tenTheLoai)
            };
            // Nếu DBHelper.ExecuteScalar trả về object, bạn có thể ép kiểu
            object result = db.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int CapNhatTheLoai(TheLoaiDTO theLoai)
        {
            string query = @"UPDATE THELOAI
                             SET TenTheLoai = @TenTheLoai
                             WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters = {
                new SqlParameter("@TenTheLoai", theLoai.TenTheLoai),
                new SqlParameter("@MaTheLoai", theLoai.MaTheLoai)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public int XoaTheLoai(int maTheLoai)
        {
            string query = @"DELETE FROM THELOAI WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters = {
                new SqlParameter("@MaTheLoai", maTheLoai)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public TheLoaiDTO GetTheLoaiByMa(int maTheLoai)
        {
            string query = SELECT_QUERY + " WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters = {
                new SqlParameter("@MaTheLoai", maTheLoai)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? ConvertToDTO(dt.Rows[0]) : null;
        }
        private List<TheLoaiDTO> ConvertToDTOList(DataTable dt)
        {
            List<TheLoaiDTO> theLoailist = new List<TheLoaiDTO>();
            foreach (DataRow row in dt.Rows)
            {
                theLoailist.Add(ConvertToDTO(row));
            }
            return theLoailist;
        }
        private TheLoaiDTO ConvertToDTO(DataRow row)
        {
            return new TheLoaiDTO
            {
                MaTheLoai = Convert.ToInt32(row["MaTheLoai"]),
                TenTheLoai = row["TenTheLoai"].ToString()
            };
        }
    }
}
