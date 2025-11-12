using Microsoft.Data.SqlClient;
using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Cần cho GetMaDauSachMoi
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class DauSachDAL
    {
        private DBHelper db = new DBHelper();

        // ----------------- CÁC HÀM TIỆN ÍCH (HELPER) -----------------

        // Query cơ sở (KHÔNG chứa WHERE)
        private string GetBaseQuery()
        {
            return @"
                SELECT 
                    ds.MaDauSach, ds.TenDauSach, ds.MaTheLoai, ds.NamXuatBan,
                    ds.NhaXuatBan, ds.SoLuongTong, ds.MaViTri,
                    tl.TenTheLoai, vt.TenViTri, ds.AnhBia 
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
            ";
        }

        // Điều kiện lọc Xóa Mềm (Soft Delete)
        private string GetSoftDeleteCondition()
        {
            // Lấy từ cột TrangThai của DAUSACH (đã có trong CSDL của bạn)
            return " ds.TrangThai = 1 ";
        }

        // ----------------- CÁC HÀM CHÍNH (GỌI TỪ BLL) -----------------

        // 1. Lấy danh sách đầu sách (Cho lưới chính)
        public DataTable LayDanhSachDauSach()
        {
            string query = @"
                SELECT 
                    ds.MaDauSach, ds.TenDauSach, tl.TenTheLoai, ds.SoLuongTong, ds.AnhBia
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                WHERE " + GetSoftDeleteCondition() + @"
                ORDER BY ds.MaDauSach";
            return db.ExecuteQuery(query);
        }

        // 2. Lấy chi tiết 1 đầu sách (Khi click vào lưới)
        public DauSachDTO LayChiTietSach(string maDauSach)
        {
            var sach = new DauSachDTO();
            // SỬA LỖI: Thêm điều kiện TrangThai
            string query = GetBaseQuery()
                         + " WHERE ds.MaDauSach = @MaDauSach AND " + GetSoftDeleteCondition();

            SqlParameter[] parameters = { new SqlParameter("@MaDauSach", maDauSach) };
            var dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                sach.MaDauSach = row["MaDauSach"].ToString();
                sach.TenDauSach = row["TenDauSach"].ToString();
                sach.MaTheLoai = Convert.ToInt32(row["MaTheLoai"]);
                sach.NamXuatBan = Convert.ToInt16(row["NamXuatBan"]);
                sach.NhaXuatBan = row["NhaXuatBan"].ToString();
                sach.SoLuongTong = Convert.ToInt32(row["SoLuongTong"]);
                sach.MaViTri = row["MaViTri"].ToString();
                sach.TenTheLoai = row["TenTheLoai"].ToString();
                sach.TenViTri = row["TenViTri"].ToString();
                sach.AnhBia = row["AnhBia"].ToString(); // Đọc AnhBia kiểu string

                sach.DanhSachTacGia = LayTacGiaTheoSach(maDauSach);
            }
            return sach;
        }

        // 3. Lấy danh sách tác giả của sách (Cho panel chi tiết)
        public List<TacGiaDTO> LayTacGiaTheoSach(string maDauSach)
        {
            var danhSach = new List<TacGiaDTO>();
            string query = @"
                SELECT tg.MaTacGia, tg.TenTacGia, tg.NamSinh, tg.QuocTich
                FROM TACGIA tg
                INNER JOIN DAUSACH_TACGIA dtg ON tg.MaTacGia = dtg.MaTacGia
                WHERE dtg.MaDauSach = @MaDauSach";
            SqlParameter[] parameters = { new SqlParameter("@MaDauSach", maDauSach) };
            var dt = db.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new TacGiaDTO
                {
                    MaTacGia = Convert.ToInt32(row["MaTacGia"]),
                    TenTacGia = row["TenTacGia"]?.ToString(),
                    NamSinh = row["NamSinh"] != DBNull.Value ? Convert.ToInt32(row["NamSinh"]) : (int?)null,
                    QuocTich = row["QuocTich"]?.ToString()
                });
            }
            return danhSach;
        }

        // 4. Tìm kiếm sách
        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = @"
                SELECT ds.MaDauSach, ds.TenDauSach, tl.TenTheLoai, ds.SoLuongTong
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                WHERE " + GetSoftDeleteCondition() + @" 
                AND (ds.TenDauSach LIKE @TuKhoa OR ds.MaDauSach LIKE @TuKhoa OR tl.TenTheLoai LIKE @TuKhoa)
                ORDER BY ds.MaDauSach";

            SqlParameter[] parameters = { new SqlParameter("@TuKhoa", $"%{tuKhoa}%") };
            return db.ExecuteQuery(query, parameters);
        }

        // 5. Cập nhật sách (Transaction)
        // SỬA LỖI: Thêm List<TacGiaDTO> tacGiasMoi
        public bool CapNhatSachTransaction(DauSachDTO sach, List<TacGiaDTO> tacGiasMoi, int soLuongCu)
        {
 
            try
            {
                // 1. Cập nhật DAUSACH
                string queryUpdateDS = @"
                    UPDATE DAUSACH 
                    SET TenDauSach = @TenDauSach, MaTheLoai = @MaTheLoai, 
                        NamXuatBan = @NamXuatBan, NhaXuatBan = @NhaXuatBan, 
                        SoLuongTong = @SoLuongTong, MaViTri = @MaViTri,
                        AnhBia = @AnhBia
                    WHERE MaDauSach = @MaDauSach";

                SqlParameter[] paramDS = {
                    new SqlParameter("@TenDauSach", sach.TenDauSach),
                    new SqlParameter("@MaTheLoai", sach.MaTheLoai),
                    new SqlParameter("@NamXuatBan", sach.NamXuatBan),
                    new SqlParameter("@NhaXuatBan", (object)sach.NhaXuatBan ?? DBNull.Value),
                    new SqlParameter("@SoLuongTong", sach.SoLuongTong),
                    new SqlParameter("@MaViTri", sach.MaViTri),
                    new SqlParameter("@AnhBia", (object)sach.AnhBia ?? DBNull.Value),
                    new SqlParameter("@MaDauSach", sach.MaDauSach)
                };
                db.ExecuteNonQuery(queryUpdateDS, paramDS);

                // 2. Cập nhật Tác giả (Xóa cũ, Thêm mới)
                string queryXoaTG = "DELETE FROM DAUSACH_TACGIA WHERE MaDauSach = @MaDauSach";
                db.ExecuteNonQuery(queryXoaTG, new[] { new SqlParameter("@MaDauSach", sach.MaDauSach) });

                string queryThemTG = "INSERT INTO DAUSACH_TACGIA (MaDauSach, MaTacGia) VALUES (@MaDauSach, @MaTacGia)";
                foreach (var tg in tacGiasMoi)
                {
                    db.ExecuteNonQuery(queryThemTG, new[] {
                        new SqlParameter("@MaDauSach", sach.MaDauSach),
                        new SqlParameter("@MaTacGia", tg.MaTacGia)
                    });
                }

                // 3. Xử lý TĂNG Số lượng
                if (sach.SoLuongTong > soLuongCu)
                {
                    int soLuongThem = sach.SoLuongTong - soLuongCu;

                    string queryMax = @"
                        SELECT TOP 1 MaSach FROM SACH 
                        WHERE MaDauSach = @MaDauSach 
                        ORDER BY CAST(SUBSTRING(MaSach, CHARINDEX('-', MaSach) + 1, 10) AS INT) DESC";

                    object result = db.ExecuteScalar(queryMax, new[] { new SqlParameter("@MaDauSach", sach.MaDauSach) });

                    int maxIndex = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        string lastMaSach = result.ToString();
                        maxIndex = int.Parse(lastMaSach.Split('-').Last());
                    }

                    string queryInsertSach = "INSERT INTO SACH (MaSach, MaDauSach, MaTinhTrang) VALUES (@MaSach, @MaDauSach, 1)";
                    for (int i = 0; i < soLuongThem; i++)
                    {
                        maxIndex++;
                        string maSachMoi = $"{sach.MaDauSach}-{maxIndex:D3}";

                        db.ExecuteNonQuery(queryInsertSach, new[] {
                            new SqlParameter("@MaSach", maSachMoi),
                            new SqlParameter("@MaDauSach", sach.MaDauSach)
                        });
                    }
                }

     
                return true;
            }
            catch (Exception ex)
            {
     
                throw new Exception("Lỗi Transaction khi cập nhật sách: " + ex.Message, ex);
            }
        }

        // 6. Xóa sách (Xóa Mềm)
        public bool XoaSach(string maDauSach)
        {
            try
            {
                string sqlCapNhatTrangThai = @"
                    UPDATE DAUSACH 
                    SET TrangThai = 0 
                    WHERE MaDauSach = @MaDauSach";
                SqlParameter[] param = { new SqlParameter("@MaDauSach", maDauSach) };
                int result = db.ExecuteNonQuery(sqlCapNhatTrangThai, param);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái sách: " + ex.Message, ex);
            }
        }

        // 7. Lấy danh sách thể loại
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            var list = new List<TheLoaiDTO>();
            string sql = "SELECT MaTheLoai, TenTheLoai FROM THELOAI ORDER BY TenTheLoai";
            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TheLoaiDTO
                {
                    MaTheLoai = Convert.ToInt32(row["MaTheLoai"]),
                    TenTheLoai = row["TenTheLoai"]?.ToString()
                });
            }
            return list;
        }

        // 8. Lấy danh sách vị trí
        public List<ViTriDTO> LayDanhSachViTri()
        {
            var list = new List<ViTriDTO>();
            string sql = "SELECT MaViTri, TenViTri FROM VITRI ORDER BY TenViTri";
            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ViTriDTO
                {
                    MaViTri = row["MaViTri"].ToString(),
                    TenViTri = row["TenViTri"].ToString()
                });
            }
            return list;
        }

        // 9. Lấy mã đầu sách mới
        public string GetMaDauSachMoi()
        {
            string query = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC";
            object result = db.ExecuteScalar(query);

            if (result == null || string.IsNullOrEmpty(result.ToString()))
            {
                return "DS001";
            }
            try
            {
                string lastMa = result.ToString();
                string numberPart = Regex.Match(lastMa, @"\d+").Value;
                int newNumber = int.Parse(numberPart) + 1;
                return "DS" + newNumber.ToString("D3");
            }
            catch
            {
                return "DS001";
            }
        }

        // 10. Thêm sách mới (Transaction)
        public bool ThemSachMoi(DauSachDTO dauSach, List<TacGiaDTO> tacGias, List<BanSachDTO> banSach)
        {
     
            try
            {
                string queryDauSach = @"
                    INSERT INTO DAUSACH (MaDauSach, TenDauSach, MaTheLoai, NamXuatBan, 
                                         NhaXuatBan, SoLuongTong, MaViTri, AnhBia, TrangThai)
                    VALUES (@MaDauSach, @TenDauSach, @MaTheLoai, @NamXuatBan, 
                            @NhaXuatBan, @SoLuongTong, @MaViTri, @AnhBia, 1)"; // Thêm TrangThai = 1

                SqlParameter[] paramDauSach = {
                    new SqlParameter("@MaDauSach", dauSach.MaDauSach),
                    new SqlParameter("@TenDauSach", dauSach.TenDauSach),
                    new SqlParameter("@MaTheLoai", dauSach.MaTheLoai),
                    new SqlParameter("@NamXuatBan", dauSach.NamXuatBan),
                    new SqlParameter("@NhaXuatBan", (object)dauSach.NhaXuatBan ?? DBNull.Value),
                    new SqlParameter("@SoLuongTong", dauSach.SoLuongTong),
                    new SqlParameter("@MaViTri", dauSach.MaViTri),
                    new SqlParameter("@AnhBia", (object)dauSach.AnhBia ?? DBNull.Value) // Kiểu string
                };
                db.ExecuteNonQuery(queryDauSach, paramDauSach);

                string queryTacGia = @"
                    INSERT INTO DAUSACH_TACGIA (MaDauSach, MaTacGia)
                    VALUES (@MaDauSach, @MaTacGia)";
                foreach (var tg in tacGias)
                {
                    SqlParameter[] paramTacGia = {
                        new SqlParameter("@MaDauSach", dauSach.MaDauSach),
                        new SqlParameter("@MaTacGia", tg.MaTacGia)
                    };
                    db.ExecuteNonQuery(queryTacGia, paramTacGia);
                }

                string querySach = @"
                    INSERT INTO SACH (MaSach, MaDauSach, MaTinhTrang)
                    VALUES (@MaSach, @MaDauSach, @MaTinhTrang)";
                foreach (var sach in banSach)
                {
                    SqlParameter[] paramSach = {
                        new SqlParameter("@MaSach", sach.MaSach),
                        new SqlParameter("@MaDauSach", sach.MaDauSach),
                        new SqlParameter("@MaTinhTrang", sach.MaTinhTrang)
                    };
                    db.ExecuteNonQuery(querySach, paramSach);
                }

       
                return true;
            }
            catch (Exception ex)
            {
   
                throw new Exception("Lỗi khi lưu Transaction. Dữ liệu đã được rollback.", ex);
            }
        }

        // 11. Lấy danh sách bản sách (Cho popup frmMaCaBiet)
        // SỬA LỖI: Thêm JOIN để lấy TenDauSach
        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            var danhSach = new List<BanSachDTO>();
            string query = @"
                SELECT 
                    s.MaSach, s.MaDauSach, ds.TenDauSach, 
                    s.MaTinhTrang, t.TenTinhTrang
                FROM SACH s
                JOIN TINHTRANG t ON s.MaTinhTrang = t.MaTinhTrang
                JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                WHERE s.MaDauSach = @MaDauSach
                ORDER BY s.MaSach";

            SqlParameter[] parameters = { new SqlParameter("@MaDauSach", maDauSach) };
            DataTable dt = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new BanSachDTO
                {
                    MaSach = row["MaSach"].ToString(),
                    MaDauSach = row["MaDauSach"].ToString(),
                    TenDauSach = row["TenDauSach"].ToString(), // Lấy tên
                    MaTinhTrang = Convert.ToInt32(row["MaTinhTrang"]),
                    TenTinhTrang = row["TenTinhTrang"].ToString()
                });
            }
            return danhSach;
        }
    }
}