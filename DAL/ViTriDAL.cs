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
    public class ViTriDAL
    {
        private DBHelper db = new DBHelper();
        private const string SELECT_QUERY = @"SELECT MaViTri, TenViTri, Tang, Ke, MoTa FROM VITRI";
        public List<ViTriDTO> GetDanhSachViTri()
        {
            string query = SELECT_QUERY;
            DataTable dt = db.ExecuteQuery(SELECT_QUERY);
            return ConvertToDTOList(dt);
        }
        public List<ViTriDTO> TimKiemViTri(string keyword)
        {
            string query = SELECT_QUERY + @" 
                WHERE MaViTri LIKE N'%' + @keyword + N'%' 
                   OR TenViTri LIKE N'%' + @keyword + N'%'
                ORDER BY MaViTri DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);
            return ConvertToDTOList(dt);
        }
        public int ThemViTri(ViTriDTO viTri)
        {
            string query = @"INSERT INTO VITRI (MaViTri, TenViTri, Tang, Ke, MoTa)
                             VALUES (@MaViTri, @TenViTri, @Tang, @Ke, @MoTa)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaViTri", viTri.MaViTri),
                new SqlParameter("@TenViTri", viTri.TenViTri),
                new SqlParameter("@Tang", viTri.Tang),
                new SqlParameter("@Ke", viTri.Ke),
                new SqlParameter("@MoTa", viTri.MoTa ?? (object)DBNull.Value)
            };

            try
            {
                return db.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm vị trí: " + ex.Message);
                return -1;
            }
        }
        public int CapNhatViTri(ViTriDTO viTri)
        {
            string query = @"UPDATE VITRI
                             SET TenViTri = @TenViTri,
                                 Tang = @Tang,
                                 Ke = @Ke,
                                 MoTa = @MoTa
                             WHERE MaViTri = @MaViTri";
            SqlParameter[] parameters = {
                new SqlParameter("@TenViTri", viTri.TenViTri),
                new SqlParameter("@Tang", viTri.Tang),
                new SqlParameter("@Ke", viTri.Ke),
                new SqlParameter("@MoTa", viTri.MoTa),
                new SqlParameter("@MaViTri", viTri.MaViTri)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public int XoaViTri(string maViTri)
        {
            string query = @"DELETE FROM VITRI WHERE MaViTri = @MaViTri";
            SqlParameter[] parameters = {
        new SqlParameter("@MaViTri", maViTri)
    };

            try
            {
                return db.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa vị trí: " + ex.Message);
                return -1;
            }
        }

        public ViTriDTO GetViTriByMa(int maViTri)
        {
            string query = SELECT_QUERY + " WHERE MaViTri = @MaViTri";
            SqlParameter[] parameters = {
                new SqlParameter("@MaViTri", maViTri)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? ConvertToDTO(dt.Rows[0]) : null;
        }
        private List<ViTriDTO> ConvertToDTOList(DataTable dt)
        {
            List<ViTriDTO> viTriList = new List<ViTriDTO>();
            foreach (DataRow row in dt.Rows)
            {
                viTriList.Add(ConvertToDTO(row));
            }
            return viTriList;
        }
        private ViTriDTO ConvertToDTO(DataRow row)
        {
            return new ViTriDTO
            {
                MaViTri = row["MaViTri"].ToString(),
                TenViTri = row["TenViTri"].ToString(),
                Tang = row["Tang"] != DBNull.Value ? Convert.ToInt32(row["Tang"]) : 0,
                Ke = row["Ke"] != DBNull.Value ? Convert.ToInt32(row["Ke"]) : 0,
                MoTa = row["MoTa"].ToString()
            };
        }
    }
}
