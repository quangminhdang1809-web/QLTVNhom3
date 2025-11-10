using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class PhieuMuonDAL
    {
        private DBHelper db = new DBHelper(); // Dùng lại class DBHelper của bạn

        // 🔹 Lấy thông tin chi tiết của 1 quyển sách để mượn
        // 🔹 Lấy thông tin chi tiết của 1 quyển sách để mượn
        public DataTable GetSachChiTiet(string maSach)
        {
            // 💡 ĐÃ SỬA LẠI ĐỂ DÙNG 'TenTacGia' VÀ 'STRING_AGG'
            string query = @"
        SELECT 
            s.MaSach, 
            ds.TenDauSach,
            ds.AnhBia,
            
            -- Ghép tên tác giả và đặt bí danh là 'TacGia'
            STRING_AGG(tg.TenTacGia, N', ') AS TacGia, 
            
            ds.NamXuatBan, 
            s.MaTinhTrang 
        FROM SACH s
        JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
        LEFT JOIN DAUSACH_TACGIA dtg ON ds.MaDauSach = dtg.MaDauSach
        LEFT JOIN TACGIA tg ON dtg.MaTacGia = tg.MaTacGia
        WHERE s.MaSach = @MaSach
        GROUP BY 
            s.MaSach, 
            ds.TenDauSach, 
            ds.NamXuatBan, 
            s.MaTinhTrang";

            SqlParameter[] parameters = { new SqlParameter("@MaSach", maSach) };
            return db.ExecuteQuery(query, parameters); // db là DBHelper của bạn
        }
        // Trong file DAL của bạn (ví dụ PhieuMuonDAL.cs hoặc SachDAL.cs)

        // 🔹 Tìm kiếm sách (theo Tên hoặc Mã) để cho mượn
        // 🔹 Tìm kiếm sách (theo Tên hoặc Mã) để cho mượn
        // [THAY THẾ HÀM NÀY TRONG PhieuMuonDAL.cs]

        public DataTable TimKiemSach(string keyword)
        {
            string query = @"
        SELECT 
            s.MaSach, 
            ds.TenDauSach,
            ds.AnhBia,
            
            -- Ghép tên các tác giả thành 1 chuỗi
            STRING_AGG(tg.TenTacGia, N', ') AS TacGia, 
            
            ds.NamXuatBan,
            s.MaTinhTrang
        FROM SACH s
        JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
        LEFT JOIN DAUSACH_TACGIA dtg ON ds.MaDauSach = dtg.MaDauSach
        LEFT JOIN TACGIA tg ON dtg.MaTacGia = tg.MaTacGia
        
        WHERE 
            (s.MaSach LIKE @Keyword OR ds.TenDauSach LIKE @Keyword)
            AND s.MaTinhTrang = 1 -- Chỉ tìm sách 'Có sẵn'
        
        -- Phải GROUP BY vì chúng ta đã dùng hàm STRING_AGG
        GROUP BY 
            s.MaSach, 
            ds.TenDauSach, 
            ds.NamXuatBan, 
            s.MaTinhTrang,
            ds.AnhBia"; 

            SqlParameter[] parameters = {
        new SqlParameter("@Keyword", "%" + keyword + "%")
    };
            return db.ExecuteQuery(query, parameters);
        }
        // 🔹 Thêm phiếu mượn

        public int InsertPhieuMuon(int maDG, int maThuThu, DateTime ngayMuon, string hinhThuc)
        {
            try
            {
                string query = @"
                    INSERT INTO PHIEUMUON (MaDocGia, MaThuThu, NgayMuon, HinhThucMuon) 
                    OUTPUT INSERTED.MaPhieuMS 
                    VALUES (@MaDG, @MaThuThu, @NgayMuon, @HinhThuc)";

                SqlParameter[] parameters = {
                    new SqlParameter("@MaDG", maDG),
                    new SqlParameter("@MaThuThu", maThuThu), // Cột NOT NULL đã thiếu
                    new SqlParameter("@NgayMuon", ngayMuon),
                    new SqlParameter("@HinhThuc", hinhThuc)
                };

                // Dùng ExecuteScalar để lấy ID mới trả về từ OUTPUT
                object result = db.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                // Hiển thị lỗi SQL chi tiết
                MessageBox.Show(string.Join("\n", ex.Errors.Cast<SqlError>().Select(er => er.Message)), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác khi thêm phiếu mượn: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }





        // 🔹 Thêm chi tiết phiếu mượn
        public int InsertChiTietPhieuMuon(int maPM, string maSach, DateTime hanTra, int maTinhTrang)
        {
            string query = @"
                INSERT INTO CTPHIEUMUON (MaPhieuMS, MaSach, HanTra, MaTinhTrang)
                VALUES (@MaPM, @MaSach, @HanTra, @MaTinhTrang)";

            SqlParameter[] parameters = {
                new SqlParameter("@MaPM", maPM),
                new SqlParameter("@MaSach", maSach),
                new SqlParameter("@HanTra", hanTra),
                new SqlParameter("@MaTinhTrang", maTinhTrang) // Cột NOT NULL đã thiếu
            };
            return db.ExecuteNonQuery(query, parameters);
        }


        // 🔹 Cập nhật tình trạng sách
        public int CapNhatTinhTrangSach(string maSach, int tinhTrang)
        {
            string query = "UPDATE SACH SET MaTinhTrang = @TinhTrang WHERE MaSach = @MaSach";
            SqlParameter[] parameters = {
        new SqlParameter("@TinhTrang", tinhTrang),
        new SqlParameter("@MaSach", maSach)
    };
            return db.ExecuteNonQuery(query, parameters);
        }
        // 🔹 Lấy sách đã mượn của độc giả
        // 🔹 Lấy sách đã mượn của độc giả - ĐÚNG VỚI DATABASE
        public DataTable GetSachDaMuonCuaDocGia(int maDocGia)
        {
            string query = @"
        SELECT 
            pm.MaPhieuMS AS 'Phiếu mượn',
            pm.NgayMuon AS 'Ngày mượn',
            cpm.HanTra AS 'Hạn trả',
            pts.NgayTra AS 'Ngày trả',
            ds.TenDauSach AS 'Tên sách',
            ISNULL(pts.TongTienPhat, 0) AS 'Tiền phạt',
            CASE 
                WHEN pts.NgayTra IS NOT NULL THEN N'Đã trả'
                WHEN GETDATE() > cpm.HanTra THEN N'Quá hạn' 
                ELSE N'Đang mượn'
            END AS 'Trạng thái'
        FROM PHIEUMUON pm
        JOIN CTPHIEUMUON cpm ON pm.MaPhieuMS = cpm.MaPhieuMS
        JOIN SACH s ON cpm.MaSach = s.MaSach
        JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
        LEFT JOIN PHIEUTRASACH pts ON pm.MaPhieuMS = pts.MaPhieuMS AND cpm.MaSach = pts.MaSach
        WHERE pm.MaDocGia = @MaDocGia
        ORDER BY pm.NgayMuon DESC";

            SqlParameter[] parameters = {
        new SqlParameter("@MaDocGia", maDocGia)
    };

            return db.ExecuteQuery(query, parameters);
        }

    }
}
