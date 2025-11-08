using Microsoft.Data.SqlClient;
using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class DauSachDAL
    {
        private DBHelper db = new DBHelper();
        //Lấy danh sách đầu sách để hiển thị
        // [TRONG FILE DauSachDAL.cs]
        // SỬA HÀM NÀY (thêm 1 dòng WHERE):
        public DataTable LayDanhSachDauSach()
        {
            string query = @"
        SELECT 
            ds.MaDauSach,
            ds.TenDauSach,
            tl.TenTheLoai, 
            ds.SoLuongTong
        FROM DAUSACH ds
        LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
        LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
        WHERE ds.TrangThai = 1  -- THÊM DÒNG NÀY
        ORDER BY ds.MaDauSach";
            return db.ExecuteQuery(query);
        }
        // 2. Lấy chi tiết 1 đầu sách khi bấm vào
        public DauSachDTO LayChiTietSach(string maDauSach)
        {
            var sach = new DauSachDTO();

            string query = @"
                SELECT 
                    ds.MaDauSach,
                    ds.TenDauSach,
                    ds.MaTheLoai,
                    ds.NamXuatBan,
                    ds.NhaXuatBan,
                    ds.SoLuongTong,
                    ds.MaViTri,
                    tl.TenTheLoai,
                    vt.TenViTri
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
                WHERE ds.MaDauSach = @MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDauSach", maDauSach)
            };

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

                // Lấy danh sách tác giả
                sach.DanhSachTacGia = LayTacGiaTheoSach(maDauSach);
            }

            return sach;
        }
        // 3. Lấy danh sách tác giả của sách
        public List<TacGiaDTO> LayTacGiaTheoSach(string maDauSach)
        {
            var danhSach = new List<TacGiaDTO>();

            string query = @"
                SELECT 
                    tg.MaTacGia,
                    tg.TenTacGia,
                    tg.NamSinh,
                    tg.QuocTich
                FROM TACGIA tg
                INNER JOIN DAUSACH_TACGIA dtg ON tg.MaTacGia = dtg.MaTacGia
                WHERE dtg.MaDauSach = @MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDauSach", maDauSach)
            };

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
        // [TRONG FILE DauSachDAL.cs]
        // SỬA HÀM NÀY (thêm 1 dòng AND):
        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = @"
        SELECT 
            ds.MaDauSach,
            ds.TenDauSach,
            ds.NamXuatBan,
            ds.NhaXuatBan,
            ds.SoLuongTong,
            ds.MaViTri,
            tl.TenTheLoai,
            vt.TenViTri
        FROM DAUSACH ds
        LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
        LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
        WHERE 
            (ds.TenDauSach LIKE @TuKhoa 
            OR ds.MaDauSach LIKE @TuKhoa
            OR tl.TenTheLoai LIKE @TuKhoa)
        AND ds.TrangThai = 1  -- THÊM DÒNG NÀY
        ORDER BY ds.MaDauSach";

            SqlParameter[] parameters = {
        new SqlParameter("@TuKhoa", $"%{tuKhoa}%")
    };
            return db.ExecuteQuery(query, parameters);
        }
        // 5. Cập nhật sách
        // [TRONG FILE DauSachDAL.cs]
        // THAY THẾ BẤT KỲ HÀM CapNhatSach NÀO BẰNG HÀM NÀY

        public bool CapNhatSachTransaction(DauSachDTO sach, int soLuongCu)
        {
           
            try
            {
                // 1. Cập nhật thông tin Bảng DAUSACH (Tên, NXB, Số lượng TỔNG, Vị trí...)
                string queryUpdateDS = @"
            UPDATE DAUSACH 
            SET TenDauSach = @TenDauSach,
                MaTheLoai = @MaTheLoai,
                NamXuatBan = @NamXuatBan,
                NhaXuatBan = @NhaXuatBan,
                SoLuongTong = @SoLuongTong,
                MaViTri = @MaViTri
            WHERE MaDauSach = @MaDauSach";

                SqlParameter[] paramDS = {
            new SqlParameter("@TenDauSach", sach.TenDauSach),
            new SqlParameter("@MaTheLoai", sach.MaTheLoai),
            new SqlParameter("@NamXuatBan", sach.NamXuatBan),
            new SqlParameter("@NhaXuatBan", sach.NhaXuatBan ?? (object)DBNull.Value),
            new SqlParameter("@SoLuongTong", sach.SoLuongTong), // Số lượng MỚI (ví dụ: 8)
            new SqlParameter("@MaViTri", sach.MaViTri),
            new SqlParameter("@MaDauSach", sach.MaDauSach)
        };
                db.ExecuteNonQuery(queryUpdateDS, paramDS);

                

                // 3. XỬ LÝ TẠO BẢN SÁCH MỚI (NẾU SỐ LƯỢNG TĂNG)
                if (sach.SoLuongTong > soLuongCu)
                {
                    int soLuongThem = sach.SoLuongTong - soLuongCu; // (8 - 5 = 3 cuốn mới)

                    // Tìm số thứ tự lớn nhất hiện tại (ví dụ: DS001-005 -> 5)
                    string queryMax = @"
                SELECT TOP 1 MaSach FROM SACH 
                WHERE MaDauSach = @MaDauSach 
                ORDER BY CAST(SUBSTRING(MaSach, CHARINDEX('-', MaSach) + 1, 10) AS INT) DESC";

                    object result = db.ExecuteScalar(queryMax, new[] { new SqlParameter("@MaDauSach", sach.MaDauSach) });

                    int maxIndex = 0;
                    if (result != null)
                    {
                        string lastMaSach = result.ToString(); // "DS001-005"
                        maxIndex = int.Parse(lastMaSach.Split('-').Last()); // 5
                    }

                    // Thêm các bản sách mới
                    string queryInsertSach = "INSERT INTO SACH (MaSach, MaDauSach, MaTinhTrang) VALUES (@MaSach, @MaDauSach, 1)"; // Mã 1 = Sẵn sàng
                    for (int i = 0; i < soLuongThem; i++)
                    {
                        maxIndex++; // Tăng index (6, 7, 8)
                        string maSachMoi = $"{sach.MaDauSach}-{maxIndex:D3}"; // DS001-006

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

        // 6. Xóa sách
        public bool XoaSach(string maDauSach)
        {
            try
            {
                // Không xóa, chỉ cập nhật trạng thái
                string sqlCapNhatTrangThai = @"
            UPDATE DAUSACH 
            SET TrangThai = 0 
            WHERE MaDauSach = @MaDauSach";

                SqlParameter[] param = {
            new SqlParameter("@MaDauSach", maDauSach)
        };

                int result = db.ExecuteNonQuery(sqlCapNhatTrangThai, param);
                return result > 0;
            }
            catch (Exception ex)
            {
                // Ném lỗi nếu có sự cố
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
        // [DÁN 2 HÀM NÀY VÀO CUỐI FILE DauSachDAL.cs]

        // 9. Lấy mã đầu sách mới (cho BLL)
        public string GetMaDauSachMoi()
        {
            string query = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC";
            object result = db.ExecuteScalar(query);

            if (result == null || string.IsNullOrEmpty(result.ToString()))
            {
                return "DS001"; // Sách đầu tiên
            }

            try
            {
                // Dùng Regex để tìm số (an toàn hơn Substring)
                string lastMa = result.ToString(); // Ví dụ: "DS010"
                string numberPart = System.Text.RegularExpressions.Regex.Match(lastMa, @"\d+").Value;
                int newNumber = int.Parse(numberPart) + 1; // 11
                return "DS" + newNumber.ToString("D3"); // "DS011"
            }
            catch
            {
                return "DS001"; // Nếu có lỗi parsing
            }
        }

        // 10. Thêm sách mới (Transaction) (cho BLL)
        public bool ThemSachMoi(DauSachDTO dauSach, List<TacGiaDTO> tacGias, List<BanSachDTO> banSach)
        {
            try
            {
                // 1. INSERT VÀO DAUSACH
                string queryDauSach = @"
            INSERT INTO DAUSACH (MaDauSach, TenDauSach, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuongTong, MaViTri)
            VALUES (@MaDauSach, @TenDauSach, @MaTheLoai, @NamXuatBan, @NhaXuatBan, @SoLuongTong, @MaViTri)";

                SqlParameter[] paramDauSach = {
            new SqlParameter("@MaDauSach", dauSach.MaDauSach),
            new SqlParameter("@TenDauSach", dauSach.TenDauSach),
            new SqlParameter("@MaTheLoai", dauSach.MaTheLoai),
            new SqlParameter("@NamXuatBan", dauSach.NamXuatBan),
            new SqlParameter("@NhaXuatBan", dauSach.NhaXuatBan ?? (object)DBNull.Value),
            new SqlParameter("@SoLuongTong", dauSach.SoLuongTong),
            new SqlParameter("@MaViTri", dauSach.MaViTri)
        };
                db.ExecuteNonQuery(queryDauSach, paramDauSach);

                // 2. INSERT VÀO DAUSACH_TACGIA (Nhiều-Nhiều)
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

                // 3. INSERT VÀO SACH (Các bản sách cụ thể)
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
                Console.WriteLine("LỖI TRANSACTION: " + ex.Message);
                // Ném lỗi ra ngoài để BLL và UI bắt
                throw new Exception("Lỗi khi lưu Transaction. Dữ liệu đã được rollback.", ex);
            }
        }
        // [THÊM HÀM NÀY VÀO DAUSACHDAL.CS]

        // 11. Lấy danh sách các bản sách cụ thể của một đầu sách
        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            var danhSach = new List<BanSachDTO>();

            // Query này JOIN với bảng TINHTRANG để lấy Tên Trạng Thái
            string query = @"
        SELECT 
            s.MaSach, 
            s.MaDauSach, 
            s.MaTinhTrang, 
            t.TenTinhTrang
        FROM SACH s
        JOIN TINHTRANG t ON s.MaTinhTrang = t.MaTinhTrang
        WHERE s.MaDauSach = @MaDauSach
        ORDER BY s.MaSach";

            SqlParameter[] parameters = {
        new SqlParameter("@MaDauSach", maDauSach)
    };

            DataTable dt = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new BanSachDTO
                {
                    MaSach = row["MaSach"].ToString(),
                    MaDauSach = row["MaDauSach"].ToString(),
                    MaTinhTrang = (int)row["MaTinhTrang"],
                    TenTinhTrang = row["TenTinhTrang"].ToString()
                });
            }

            return danhSach;
        }
    }
}
