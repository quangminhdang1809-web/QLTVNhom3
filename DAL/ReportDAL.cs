using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO;

namespace QLTVNhom3.DAL
{
    public class ReportDAL
    {
        private DBHelper dbHelper = new DBHelper();

        // 1. BÁO CÁO SÁCH ĐANG MƯỢN (CHỈ SÁCH TRONG HẠN)
        public List<ReportDTO.CurrentBorrowedBookDTO> GetCurrentBorrowedBooks()
        {
            var books = new List<ReportDTO.CurrentBorrowedBookDTO>();

            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY ct.HanTra ASC) as STT,
                    pm.MaPhieuMS,
                    s.MaSach,
                    ds.TenDauSach as TenSach,
                    dg.HoTen as TenDocGia,
                    pm.NgayMuon,
                    ct.HanTra,
                    DATEDIFF(DAY, GETDATE(), ct.HanTra) as SoNgayConLai
                FROM CTPHIEUMUON ct
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                INNER JOIN SACH s ON ct.MaSach = s.MaSach
                INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
                WHERE ct.MaTinhTrang = 2 
                AND ct.HanTra >= GETDATE() -- CHỈ LẤY SÁCH TRONG HẠN
                ORDER BY ct.HanTra ASC";

            DataTable dt = dbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int soNgayConLai = Convert.ToInt32(row["SoNgayConLai"]);
                string trangThai = soNgayConLai <= 2 ? "Sắp hết hạn" : "Đang mượn";

                books.Add(new ReportDTO.CurrentBorrowedBookDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaPhieuMS = Convert.ToInt32(row["MaPhieuMS"]),
                    MaSach = row["MaSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    TenDocGia = row["TenDocGia"].ToString(),
                    NgayMuon = Convert.ToDateTime(row["NgayMuon"]),
                    HanTra = Convert.ToDateTime(row["HanTra"]),
                    SoNgayConLai = soNgayConLai,
                    TrangThai = trangThai
                });
            }

            return books;
        }

        public ReportDTO.CurrentBorrowedSummaryDTO GetCurrentBorrowedSummary()
        {
            string query = @"
                SELECT 
                    COUNT(*) as TongSoSachDangMuon,
                    SUM(CASE WHEN DATEDIFF(DAY, GETDATE(), ct.HanTra) <= 2 THEN 1 ELSE 0 END) as SoSachSapHetHan
                FROM CTPHIEUMUON ct
                WHERE ct.MaTinhTrang = 2 
                AND ct.HanTra >= GETDATE()";

            DataTable dt = dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new ReportDTO.CurrentBorrowedSummaryDTO
                {
                    TongSoSachDangMuon = Convert.ToInt32(row["TongSoSachDangMuon"]),
                    SoSachSapHetHan = Convert.ToInt32(row["SoSachSapHetHan"]),
                    SoSachQuaHan = 0, // KHÔNG CÓ SÁCH QUÁ HẠN TRONG BÁO CÁO NÀY
                    ReportDate = DateTime.Now
                };
            }

            return new ReportDTO.CurrentBorrowedSummaryDTO();
        }

        // 2. BÁO CÁO SÁCH QUÁ HẠN (RIÊNG BIỆT)
        public List<ReportDTO.OverdueBookDTO> GetOverdueBooks()
        {
            var books = new List<ReportDTO.OverdueBookDTO>();

            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY DATEDIFF(DAY, ct.HanTra, GETDATE()) DESC) as STT,
                    pm.MaPhieuMS,
                    s.MaSach,
                    ds.TenDauSach as TenSach,
                    dg.HoTen as TenDocGia,
                    pm.NgayMuon,
                    ct.HanTra,
                    DATEDIFF(DAY, ct.HanTra, GETDATE()) as SoNgayQuaHan
                FROM CTPHIEUMUON ct
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                INNER JOIN SACH s ON ct.MaSach = s.MaSach
                INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
                WHERE ct.MaTinhTrang = 2 
                AND ct.HanTra < GETDATE() -- CHỈ LẤY SÁCH QUÁ HẠN
                ORDER BY SoNgayQuaHan DESC";

            DataTable dt = dbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int soNgayQuaHan = Convert.ToInt32(row["SoNgayQuaHan"]);
                decimal tienPhatDuKien = soNgayQuaHan * 2000;

                books.Add(new ReportDTO.OverdueBookDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaPhieuMS = Convert.ToInt32(row["MaPhieuMS"]),
                    MaSach = row["MaSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    TenDocGia = row["TenDocGia"].ToString(),
                    NgayMuon = Convert.ToDateTime(row["NgayMuon"]),
                    HanTra = Convert.ToDateTime(row["HanTra"]),
                    SoNgayQuaHan = soNgayQuaHan,
                    TienPhatDuKien = tienPhatDuKien
                });
            }

            return books;
        }

        public ReportDTO.OverdueSummaryDTO GetOverdueSummary()
        {
            string query = @"
                SELECT 
                    COUNT(*) as TongSoSachQuaHan,
                    COUNT(DISTINCT pm.MaDocGia) as SoDocGiaViPham,
                    SUM(DATEDIFF(DAY, ct.HanTra, GETDATE()) * 2000) as TongTienPhatDuKien
                FROM CTPHIEUMUON ct
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                WHERE ct.MaTinhTrang = 2 
                AND ct.HanTra < GETDATE()";

            DataTable dt = dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new ReportDTO.OverdueSummaryDTO
                {
                    TongSoSachQuaHan = Convert.ToInt32(row["TongSoSachQuaHan"]),
                    SoDocGiaViPham = Convert.ToInt32(row["SoDocGiaViPham"]),
                    TongTienPhatDuKien = Convert.ToDecimal(row["TongTienPhatDuKien"]),
                    ReportDate = DateTime.Now
                };
            }

            return new ReportDTO.OverdueSummaryDTO();
        }

        // 3. BÁO CÁO TIỀN PHẠT VÀ SỐ LƯỢNG PHIẾU PHẠT
        public List<ReportDTO.FineReportDTO> GetFineReports(DateTime startDate, DateTime endDate)
        {
            var fines = new List<ReportDTO.FineReportDTO>();

            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY pt.NgayTra DESC) as STT,
                    pt.MaPhieuTra,
                    pt.NgayTra,
                    dg.HoTen as TenDocGia,
                    pt.SoNgayTraTre,
                    pt.TongTienPhat
                FROM PHIEUTRASACH pt
                INNER JOIN CTPHIEUMUON ct ON pt.MaPhieuMS = ct.MaPhieuMS AND pt.MaSach = ct.MaSach
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
                WHERE pt.NgayTra BETWEEN @StartDate AND @EndDate
                ORDER BY pt.NgayTra DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                decimal tongTienPhat = Convert.ToDecimal(row["TongTienPhat"]);

                fines.Add(new ReportDTO.FineReportDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaPhieuTra = Convert.ToInt32(row["MaPhieuTra"]),
                    NgayTra = Convert.ToDateTime(row["NgayTra"]),
                    TenDocGia = row["TenDocGia"].ToString(),
                    LyDoPhat = "Phạt trả trễ", // ĐƠN GIẢN HÓA
                    SoNgayQuaHan = Convert.ToInt32(row["SoNgayTraTre"]),
                    TienPhatQuaHan = tongTienPhat, // GỘP CHUNG
                    TienPhatLoiSach = 0, // KHÔNG TÍNH RIÊNG
                    TongTienPhat = tongTienPhat,
                    TrangThaiThu = tongTienPhat > 0 ? "Đã thu" : "Chưa thu"
                });
            }

            return fines;
        }

        public ReportDTO.FineReportSummaryDTO GetFineReportSummary(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    COUNT(*) as TongSoPhieuPhat,
                    SUM(pt.TongTienPhat) as TongTienPhat,
                    SUM(CASE WHEN pt.TongTienPhat > 0 THEN 1 ELSE 0 END) as SoPhieuDaThu,
                    SUM(CASE WHEN pt.TongTienPhat = 0 THEN 1 ELSE 0 END) as SoPhieuChuaThu
                FROM PHIEUTRASACH pt
                WHERE pt.NgayTra BETWEEN @StartDate AND @EndDate";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int tongSoPhieu = Convert.ToInt32(row["TongSoPhieuPhat"]);
                int soPhieuDaThu = Convert.ToInt32(row["SoPhieuDaThu"]);
                decimal tyLeThuPhat = tongSoPhieu > 0 ? (soPhieuDaThu * 100.0m / tongSoPhieu) : 0;

                return new ReportDTO.FineReportSummaryDTO
                {
                    TongSoPhieuPhat = tongSoPhieu,
                    TongTienPhat = Convert.ToDecimal(row["TongTienPhat"]),
                    SoPhieuDaThu = soPhieuDaThu,
                    SoPhieuChuaThu = Convert.ToInt32(row["SoPhieuChuaThu"]),
                    TyLeThuPhat = Math.Round(tyLeThuPhat, 2),
                    StartDate = startDate,
                    EndDate = endDate
                };
            }

            return new ReportDTO.FineReportSummaryDTO();
        }

        // 4. BÁO CÁO SÁCH ĐƯỢC YÊU THÍCH NHẤT - ĐƠN GIẢN
        public List<ReportDTO.FavoriteBookDTO> GetFavoriteBooks(DateTime startDate, DateTime endDate)
        {
            var books = new List<ReportDTO.FavoriteBookDTO>();

            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY COUNT(ct.MaSach) DESC) as STT,
                    ds.MaDauSach,
                    ds.TenDauSach as TenSach,
                    COUNT(ct.MaSach) as SoLuotMuon
                FROM DAUSACH ds
                INNER JOIN SACH s ON ds.MaDauSach = s.MaDauSach
                INNER JOIN CTPHIEUMUON ct ON s.MaSach = ct.MaSach
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                WHERE pm.NgayMuon BETWEEN @StartDate AND @EndDate
                GROUP BY ds.MaDauSach, ds.TenDauSach
                ORDER BY SoLuotMuon DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                books.Add(new ReportDTO.FavoriteBookDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaDauSach = row["MaDauSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    SoLuotMuon = Convert.ToInt32(row["SoLuotMuon"])
                });
            }

            return books;
        }

        public ReportDTO.FavoriteBookSummaryDTO GetFavoriteBookSummary(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    COUNT(ct.MaSach) as TongLuotMuon,
                    COUNT(DISTINCT ds.MaDauSach) as TongDauSach
                FROM CTPHIEUMUON ct
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
                INNER JOIN SACH s ON ct.MaSach = s.MaSach
                INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                WHERE pm.NgayMuon BETWEEN @StartDate AND @EndDate";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var favoriteBooks = GetFavoriteBooks(startDate, endDate);
                string sachNhieuNhat = favoriteBooks.Count > 0 ? favoriteBooks[0].TenSach : "Không có dữ liệu";
                int soLuotCaoNhat = favoriteBooks.Count > 0 ? favoriteBooks[0].SoLuotMuon : 0;

                return new ReportDTO.FavoriteBookSummaryDTO
                {
                    TongLuotMuon = Convert.ToInt32(row["TongLuotMuon"]),
                    TongDauSach = Convert.ToInt32(row["TongDauSach"]),
                    SachMuonNhieuNhat = sachNhieuNhat,
                    SoLuotCaoNhat = soLuotCaoNhat,
                    StartDate = startDate,
                    EndDate = endDate
                };
            }

            return new ReportDTO.FavoriteBookSummaryDTO();
        }
        public List<ReportDTO.BookInventoryDTO> GetBookInventoryStatus()
        {
            var books = new List<ReportDTO.BookInventoryDTO>();

            // Câu query SQL mới để thống kê
            string query = @"
        SELECT 
            ROW_NUMBER() OVER (ORDER BY ds.TenDauSach) as STT,
            ds.MaDauSach,
            ds.TenDauSach as TenSach,
            COUNT(s.MaSach) as TongSoLuong,
            (COUNT(s.MaSach) - COUNT(ct.MaSach)) as CoSan,
            COUNT(ct.MaSach) as DangMuon,
           
        FROM 
            DAUSACH ds
        LEFT JOIN 
            SACH s ON ds.MaDauSach = s.MaDauSach
        LEFT JOIN 
            CTPHIEUMUON ct ON s.MaSach = ct.MaSach AND ct.MaTinhTrang = 2 -- Chỉ join với sách ĐANG MƯỢN
        GROUP BY 
            ds.MaDauSach, ds.TenDauSach
        ORDER BY 
            ds.TenDauSach;";

            DataTable dt = dbHelper.ExecuteQuery(query); // dbHelper của bạn

            foreach (DataRow row in dt.Rows)
            {
                books.Add(new ReportDTO.BookInventoryDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaDauSach = row["MaDauSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    TongSoLuong = Convert.ToInt32(row["TongSoLuong"]),
                    DangMuon = Convert.ToInt32(row["DangMuon"]),
                    ConLai = Convert.ToInt32(row["ConLai"])
                });
            }
            return books;
        }
    }
}

