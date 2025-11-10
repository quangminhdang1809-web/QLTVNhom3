using Microsoft.Data.SqlClient;
using System;
using System.Data;
using QLTVNhom3.DTO;

namespace QLTVNhom3.DAL
{
    public class DocGiaMuonDAL
    {
        private DBHelper db = new DBHelper();

        private const string BASE_QUERY = @"
            SELECT 
                dg.MaDocGia, dg.HoTen, dg.NgayHetHan, ldg.SoSachToiDa,
                s.MaSach, ds.TenDauSach AS TenSach, ds.NamXuatBan,
                pm.NgayMuon, ctp.HanTra,
                CASE WHEN ctp.HanTra < GETDATE() THEN 1 ELSE 0 END AS QuaHan
            FROM DOCGIA dg
            JOIN LOAIDOCGIA ldg ON dg.MaLoaiDG = ldg.MaLoaiDG
            LEFT JOIN PHIEUMUON pm ON dg.MaDocGia = pm.MaDocGia
            LEFT JOIN CTPHIEUMUON ctp ON pm.MaPhieuMS = ctp.MaPhieuMS
            LEFT JOIN SACH s ON ctp.MaSach = s.MaSach
            LEFT JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
            WHERE (s.MaTinhTrang = 2 OR s.MaTinhTrang IS NULL)";

        // 🔹 Lấy toàn bộ danh sách độc giả mượn (hoặc có thẻ)
        public DataTable GetDanhSachDocGiaMuon()
        {
            return db.ExecuteQuery(BASE_QUERY);
        }

        // 🔹 Tìm kiếm độc giả theo tên hoặc mã
        public DataTable TimKiemDocGiaMuon(string keyword)
        {
            string query = BASE_QUERY + @" AND (dg.MaDocGia LIKE N'%' + @keyword + N'%' 
                                                OR dg.HoTen LIKE N'%' + @keyword + N'%')";
            SqlParameter[] parameters =
            {
                new SqlParameter("@keyword", keyword)
            };
            return db.ExecuteQuery(query, parameters);
        }

        // 🔹 Lấy sách đang mượn của một độc giả
        public DataTable GetSachDangMuonTheoDocGia(string maDocGia)
        {
            string query = @"
                SELECT 
                    ds.TenDauSach AS TenSach,
                    s.MaSach,
                    pm.NgayMuon,
                    ctp.HanTra,
                    -- Cột này BẮT BUỘC phải có vì code ở ucMuonsachthuthu.cs có dùng
                    CASE WHEN ctp.HanTra < GETDATE() THEN 1 ELSE 0 END AS QuaHan
                FROM PHIEUMUON pm
                JOIN CTPHIEUMUON ctp ON pm.MaPhieuMS = ctp.MaPhieuMS
                JOIN SACH s ON ctp.MaSach = s.MaSach
                JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                WHERE pm.MaDocGia = @MaDocGia AND ctp.MaTinhTrang = 2";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDocGia", maDocGia)
            };
            return db.ExecuteQuery(query, parameters);
        }

        // 🔹 Lấy thông tin độc giả (dù chưa mượn sách)
        // Trong file: DocGiaMuonDAL.cs
        public DataTable LayThongTinDocGia(string maDocGia)
        {
            string query = @"
        SELECT 
            dg.MaDocGia, dg.HoTen, dg.NgayHetHan, ldg.SoSachToiDa,
            ldg.SoNgayMuonToiDa  -- ⬅️ THÊM CỘT NÀY VÀO
        FROM DOCGIA dg
        JOIN LOAIDOCGIA ldg ON dg.MaLoaiDG = ldg.MaLoaiDG
        WHERE dg.MaDocGia = @MaDocGia";

            SqlParameter[] parameters =
            {
        new SqlParameter("@MaDocGia", maDocGia)
    };
            return db.ExecuteQuery(query, parameters);
        }
    }
}
