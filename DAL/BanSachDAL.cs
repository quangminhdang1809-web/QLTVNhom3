using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLTVNhom3.DAL
{
    public class BanSachDAL
    {
        private DBHelper db = new DBHelper();

        // Hàm helper
        private BanSachDTO MapDataRowToBanSachDTO(DataRow row)
        {
            return new BanSachDTO
            {
                MaSach = row["MaSach"].ToString(),
                MaDauSach = row["MaDauSach"].ToString(),
                TenDauSach = row["TenDauSach"].ToString(),
                MaTinhTrang = (int)row["MaTinhTrang"],
                TenTinhTrang = row["TenTinhTrang"].ToString()
            };
        }

        // Query cơ sở (KHÔNG chứa WHERE)
        private string GetBaseQuery()
        {
            return @"
                SELECT 
                    s.MaSach, s.MaDauSach, ds.TenDauSach,
                    s.MaTinhTrang, t.TenTinhTrang
                FROM SACH s
                LEFT JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                LEFT JOIN TINHTRANG t ON s.MaTinhTrang = t.MaTinhTrang
            ";
        }

        // Điều kiện lọc Xóa Mềm (Soft Delete)
        private string GetSoftDeleteCondition()
        {
            // (Giả sử bạn đã thêm 'Đã thanh lý' vào bảng TINHTRANG)
            return " t.TenTinhTrang != N'Đã thanh lý' ";
        }

        public List<BanSachDTO> LayTatCaSach()
        {
            var list = new List<BanSachDTO>();
            string query = GetBaseQuery()
                         + " WHERE " + GetSoftDeleteCondition()
                         + " ORDER BY s.MaSach";

            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapDataRowToBanSachDTO(row));
            }
            return list;
        }

        // HÀM MỚI (Sửa lỗi CS1061 và lỗi "trống trơn")
        public List<BanSachDTO> LaySachTheoDauSach(string maDauSach)
        {
            var list = new List<BanSachDTO>();
            string query = GetBaseQuery()
                         + " WHERE s.MaDauSach = @MaDauSach"
                         + " AND " + GetSoftDeleteCondition()
                         + " ORDER BY s.MaSach";

            SqlParameter[] param = { new SqlParameter("@MaDauSach", maDauSach) };

            DataTable dt = db.ExecuteQuery(query, param);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapDataRowToBanSachDTO(row));
            }
            return list;
        }

        public BanSachDTO LayChiTietSach(string maSach)
        {
            string query = GetBaseQuery()
                         + " WHERE s.MaSach = @MaSach"
                         + " AND " + GetSoftDeleteCondition();

            SqlParameter[] param = { new SqlParameter("@MaSach", maSach) };
            DataTable dt = db.ExecuteQuery(query, param);
            if (dt.Rows.Count > 0)
            {
                return MapDataRowToBanSachDTO(dt.Rows[0]);
            }
            return null;
        }

        public DataTable LayDanhSachTinhTrang()
        {
            return db.ExecuteQuery("SELECT MaTinhTrang, TenTinhTrang FROM TINHTRANG");
        }

        public bool CapNhatSach(BanSachDTO sach)
        {
            string query = "UPDATE SACH SET MaTinhTrang = @MaTinhTrang WHERE MaSach = @MaSach";
            SqlParameter[] param = {
                new SqlParameter("@MaTinhTrang", sach.MaTinhTrang),
                new SqlParameter("@MaSach", sach.MaSach)
            };
            return db.ExecuteNonQuery(query, param) > 0;
        }

        // HÀM MỚI (Cho tìm kiếm)
        public List<BanSachDTO> TimKiemSach(string tuKhoa, string maDauSachFilter = null)
        {
            var list = new List<BanSachDTO>();
            string query = GetBaseQuery();
            var parameters = new List<SqlParameter>();

            query += " WHERE " + GetSoftDeleteCondition();

            query += @"
                AND (s.MaSach LIKE @TuKhoa 
                   OR s.MaDauSach LIKE @TuKhoa 
                   OR ds.TenDauSach LIKE @TuKhoa 
                   OR t.TenTinhTrang LIKE @TuKhoa)";
            parameters.Add(new SqlParameter("@TuKhoa", $"%{tuKhoa}%"));

            if (!string.IsNullOrEmpty(maDauSachFilter))
            {
                query += " AND s.MaDauSach = @MaDauSachFilter";
                parameters.Add(new SqlParameter("@MaDauSachFilter", maDauSachFilter));
            }

            query += " ORDER BY s.MaSach";

            DataTable dt = db.ExecuteQuery(query, parameters.ToArray());
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapDataRowToBanSachDTO(row));
            }
            return list;
        }

        // HÀM XÓA MỀM (Đã sửa)
        public bool XoaSach(string maSach)
        {
            object trangThaiIdObj = db.ExecuteScalar("SELECT MaTinhTrang FROM TINHTRANG WHERE TenTinhTrang = N'Đã thanh lý'");

            if (trangThaiIdObj == null)
            {
                throw new Exception("Lỗi CSDL: Không tìm thấy trạng thái 'Đã thanh lý'.");
            }
            int maTinhTrangDaThanhLy = (int)trangThaiIdObj;

            object maDauSachObj = db.ExecuteScalar("SELECT MaDauSach FROM SACH WHERE MaSach = @MaSach", new[] { new SqlParameter("@MaSach", maSach) });
            if (maDauSachObj == null)
            {
                throw new Exception("Không tìm thấy sách này.");
            }
            string maDauSach = maDauSachObj.ToString();

          
            try
            {
                string queryUpdateSach = @"
                    UPDATE SACH 
                    SET MaTinhTrang = @MaTinhTrangThanhLy 
                    WHERE MaSach = @MaSach";
                SqlParameter[] paramUpdate = {
                    new SqlParameter("@MaTinhTrangThanhLy", maTinhTrangDaThanhLy),
                    new SqlParameter("@MaSach", maSach)
                };
                int result = db.ExecuteNonQuery(queryUpdateSach, paramUpdate);

                if (result == 0) throw new Exception("Cập nhật trạng thái sách thất bại.");

                string queryUpdateDauSach = @"
                    UPDATE DAUSACH 
                    SET SoLuongTong = SoLuongTong - 1 
                    WHERE MaDauSach = @MaDauSach";
                SqlParameter[] paramUpdateDS = { new SqlParameter("@MaDauSach", maDauSach) };
                db.ExecuteNonQuery(queryUpdateDauSach, paramUpdateDS);

              
                return true;
            }
            catch (Exception ex)
            {
          
                throw new Exception("Lỗi khi xóa (đã rollback): " + ex.Message, ex);
            }
        }
    }
}