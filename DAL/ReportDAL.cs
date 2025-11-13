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
                    pt.TongTienPhat
                FROM PHIEUTRASACH pt
                INNER JOIN CTPHIEUMUON ct ON pt.MaPhieuMS = ct.MaPhieuMS AND pt.MaSach = ct.MaSach
                INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
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
                    TongTienPhat = tongTienPhat,
                });
            }

            return fines;
        }

        public ReportDTO.FineReportSummaryDTO GetFineReportSummary(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    COUNT(*) as TongSoPhieuPhat,
                    SUM(pt.TongTienPhat) as TongTienPhat
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

                return new ReportDTO.FineReportSummaryDTO
                {
                    TongSoPhieuPhat = tongSoPhieu,
                    TongTienPhat = Convert.ToDecimal(row["TongTienPhat"]),
                    StartDate = startDate,
                    EndDate = endDate
                };
            }

            return new ReportDTO.FineReportSummaryDTO();
        }
        public List<ReportDTO.BookInventoryDTO> GetBookInventoryStatus()
        {
            var books = new List<ReportDTO.BookInventoryDTO>();

            string query = @"
        SELECT 
            ROW_NUMBER() OVER (ORDER BY ds.TenDauSach) as STT,
            ds.MaDauSach,
            ds.TenDauSach as TenSach,
            COUNT(s.MaSach) as TongSoLuong,
            COUNT(CASE WHEN s.MaTinhTrang = 1 THEN 1 END) as CoSan,
            COUNT(CASE WHEN s.MaTinhTrang = 2 THEN 1 END) as DangMuon
        FROM 
            DAUSACH ds
        LEFT JOIN 
            SACH s ON ds.MaDauSach = s.MaDauSach
        GROUP BY 
            ds.MaDauSach, ds.TenDauSach
        ORDER BY 
            ds.TenDauSach";

            DataTable dt = dbHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                int tongSoLuong = Convert.ToInt32(row["TongSoLuong"]);
                int coSan = Convert.ToInt32(row["CoSan"]);
                int dangMuon = Convert.ToInt32(row["DangMuon"]);
                int conLai = coSan;

                books.Add(new ReportDTO.BookInventoryDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    MaDauSach = row["MaDauSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    TongSoLuong = tongSoLuong,
                    DangMuon = dangMuon,
                    ConLai = conLai
                });
            }
            return books;
        }
        public List<ReportDTO.SimpleFineReportDTO> GetSimpleFineReports(DateTime startDate, DateTime endDate)
        {
            var fines = new List<ReportDTO.SimpleFineReportDTO>();

            string query = @"
        SELECT 
            ROW_NUMBER() OVER (ORDER BY CONVERT(date, pt.NgayTra) DESC) as STT,
            CONVERT(date, pt.NgayTra) as NgayPhat,
            COUNT(pt.MaPhieuTra) as SoLuongPhieu,
            SUM(pt.TongTienPhat) as TongTienPhat
        FROM PHIEUTRASACH pt
        WHERE pt.NgayTra BETWEEN @StartDate AND @EndDate
        GROUP BY CONVERT(date, pt.NgayTra)
        ORDER BY CONVERT(date, pt.NgayTra) DESC";

            SqlParameter[] parameters = {
        new SqlParameter("@StartDate", startDate.Date),
        new SqlParameter("@EndDate", endDate.Date)
    };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                fines.Add(new ReportDTO.SimpleFineReportDTO
                {
                    STT = Convert.ToInt32(row["STT"]),
                    NgayPhat = Convert.ToDateTime(row["NgayPhat"]),
                    SoLuongPhieu = Convert.ToInt32(row["SoLuongPhieu"]),
                    TongTienPhat = Convert.ToDecimal(row["TongTienPhat"])
                });
            }

            return fines;
        }
    }
}

