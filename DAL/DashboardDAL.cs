using DevExpress.XtraSpreadsheet.DocumentFormats.Xlsb;
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
    public class DashboardDAL
    {
        private DBHelper db = new DBHelper();
        public DashboardDTO GetThongKeDashboard()
        {
            DashboardDTO thongKe = new DashboardDTO();

            try
            {
                // Tổng đầu sách
                string queryTongDauSach = "SELECT COUNT(DISTINCT MaDauSach) FROM DAUSACH WHERE TrangThai = 1";
                thongKe.TongDauSach = Convert.ToInt32(db.ExecuteScalar(queryTongDauSach));

                // Sách đang mượn
                string querySachMuon = "SELECT COUNT(*) FROM SACH WHERE MaTinhTrang = 2";
                thongKe.SoSachMuon = Convert.ToInt32(db.ExecuteScalar(querySachMuon));

                // Sách quá hạn
                string querySachQuaHan = @"
                    SELECT COUNT(*) 
                    FROM CTPHIEUMUON ctp 
                    INNER JOIN PHIEUMUON pm ON ctp.MaPhieuMS = pm.MaPhieuMS
                    WHERE ctp.HanTra < GETDATE() AND ctp.MaTinhTrang = 2";
                thongKe.SoSachQuaHan = Convert.ToInt32(db.ExecuteScalar(querySachQuaHan));

                // Tổng độc giả
                string queryTongDocGia = "SELECT COUNT(*) FROM DOCGIA WHERE NgayHetHan >= GETDATE()";
                thongKe.TongDocGia = Convert.ToInt32(db.ExecuteScalar(queryTongDocGia));
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê dashboard: " + ex.Message);
            }

            return thongKe;
        }
        public DataTable GetLuotMuonTheoNgayTrongThang()
        {
            string query = @"
        -- Tạo danh sách tất cả các ngày trong tháng
        WITH AllDays AS (
            SELECT 1 as Ngay
            UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5
            UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9
            UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12 UNION ALL SELECT 13
            UNION ALL SELECT 14 UNION ALL SELECT 15 UNION ALL SELECT 16 UNION ALL SELECT 17
            UNION ALL SELECT 18 UNION ALL SELECT 19 UNION ALL SELECT 20 UNION ALL SELECT 21
            UNION ALL SELECT 22 UNION ALL SELECT 23 UNION ALL SELECT 24 UNION ALL SELECT 25
            UNION ALL SELECT 26 UNION ALL SELECT 27 UNION ALL SELECT 28 UNION ALL SELECT 29
            UNION ALL SELECT 30 UNION ALL SELECT 31
        )
        SELECT 
            ad.Ngay,
            ISNULL(COUNT(ctp.MaSach), 0) as LuotMuon
        FROM AllDays ad
        LEFT JOIN PHIEUMUON pm ON DAY(pm.NgayMuon) = ad.Ngay 
            AND MONTH(pm.NgayMuon) = MONTH(GETDATE()) 
            AND YEAR(pm.NgayMuon) = YEAR(GETDATE())
        LEFT JOIN CTPHIEUMUON ctp ON pm.MaPhieuMS = ctp.MaPhieuMS
        WHERE ad.Ngay <= DAY(EOMONTH(GETDATE()))  -- Chỉ lấy đến ngày cuối tháng
        GROUP BY ad.Ngay
        ORDER BY ad.Ngay";

            return db.ExecuteQuery(query);
        }
        public DataTable GetSachMuonNhieuNhat()
        {
            string query = @"
                SELECT TOP 5 
                    ds.MaDauSach,
                    ds.TenDauSach,
                    tl.TenTheLoai,
                    COUNT(ctp.MaSach) as SoLanMuon
                FROM DAUSACH ds
                INNER JOIN SACH s ON ds.MaDauSach = s.MaDauSach
                INNER JOIN CTPHIEUMUON ctp ON s.MaSach = ctp.MaSach
                INNER JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                WHERE ds.TrangThai = 1
                GROUP BY ds.MaDauSach, ds.TenDauSach, tl.TenTheLoai
                ORDER BY SoLanMuon DESC";

            return db.ExecuteQuery(query);
        }
        public DataTable GetSachQuaHanChiTiet()
        {
            string query = @"
        SELECT 
            s.MaSach,
            ds.TenDauSach,
            dg.HoTen as TenDocGia,
            dg.SoDienThoai,
            DATEDIFF(DAY, ctp.HanTra, GETDATE()) as SoNgayQuaHan
        FROM CTPHIEUMUON ctp
        INNER JOIN PHIEUMUON pm ON ctp.MaPhieuMS = pm.MaPhieuMS
        INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
        INNER JOIN SACH s ON ctp.MaSach = s.MaSach
        INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
        WHERE ctp.HanTra < GETDATE() AND ctp.MaTinhTrang = 2
        ORDER BY SoNgayQuaHan DESC";

            return db.ExecuteQuery(query);
        }
    }
}
