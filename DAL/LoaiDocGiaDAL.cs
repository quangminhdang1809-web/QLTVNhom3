using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class LoaiDocGiaDAL
    {
        private DBHelper db = new DBHelper();

        // Lấy toàn bộ danh sách loại độc giả
        public DataTable GetLoaiDocGia()
        {
            string query = "SELECT * FROM LoaiDocGia";
            return db.ExecuteQuery(query);
        }

        // Lấy chi tiết 1 loại độc giả theo mã
        public LoaiDocGiaDTO GetLoaiDocGiaByMa(string maLoaiDG)
        {
            string query = "SELECT * FROM LoaiDocGia WHERE MaLoaiDG = @MaLoaiDG";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLoaiDG", maLoaiDG)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LoaiDocGiaDTO(
                    Convert.ToInt32(row["MaLoaiDG"]),
                    row["TenLoaiDG"].ToString(),
                    Convert.ToInt32(row["ThoiHanThe"]),
                    Convert.ToInt32(row["SoSachToiDa"]),
                    Convert.ToInt32(row["SoNgayMuonToiDa"])
                );
            }
            return null;
        }

    }
}
