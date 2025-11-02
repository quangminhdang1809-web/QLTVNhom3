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
    public class PhieuTraDAL
    {
        private DBHelper db = new DBHelper();
        public bool LuuDanhSachPhieuTra(List<PhieuTraDTO> danhSachPhieuTra)
        {
            try
            {
                int count = 0;
                foreach (var phieuTra in danhSachPhieuTra)
                {
                    count++;

                    // DEBUG
                    Console.WriteLine($"=== ĐANG LƯU SÁCH {count}/{danhSachPhieuTra.Count} ===");
                    Console.WriteLine($"Mã phiếu MS: {phieuTra.MaPhieuMS}");
                    Console.WriteLine($"Mã sách: {phieuTra.MaSach}");
                    Console.WriteLine($"Mã thủ thư: {phieuTra.MaThuThu}");
                    // 1. Lưu phiếu trả sách
                    string insertPhieuTra = @"
                    INSERT INTO PHIEUTRASACH (MaPhieuMS, MaSach, NgayTra, SoNgayTraTre, 
                                             MaLoiQuaHan, MaLoiSach, TienPhatQuaHan, 
                                             TienPhatLoiSach, TongTienPhat, GhiChu, MaThuThu)
                    VALUES (@MaPhieuMS, @MaSach, @NgayTra, @SoNgayTraTre, 
                            @MaLoiQuaHan, @MaLoiSach, @TienPhatQuaHan,
                            @TienPhatLoiSach, @TongTienPhat, @GhiChu, @MaThuThu)";

                    var parameters = new SqlParameter[]
                    {
                    new SqlParameter("@MaPhieuMS", phieuTra.MaPhieuMS),
                    new SqlParameter("@MaSach", phieuTra.MaSach),
                    new SqlParameter("@NgayTra", phieuTra.NgayTra),
                    new SqlParameter("@SoNgayTraTre", phieuTra.SoNgayTraTre),
                    new SqlParameter("@MaLoiQuaHan", phieuTra.MaLoiQuaHan ?? (object)DBNull.Value),
                    new SqlParameter("@MaLoiSach", phieuTra.MaLoiSach),
                    new SqlParameter("@TienPhatQuaHan", phieuTra.TienPhatQuaHan),
                    new SqlParameter("@TienPhatLoiSach", phieuTra.TienPhatLoiSach),
                    new SqlParameter("@TongTienPhat", phieuTra.TongTienPhat),
                    new SqlParameter("@GhiChu", phieuTra.GhiChu ?? (object)DBNull.Value),
                    new SqlParameter("@MaThuThu", phieuTra.MaThuThu) // Tạm thời dùng mã thủ thư mặc định
                    };
                    Console.WriteLine("→ Đang thực hiện INSERT...");
                    int rowsInserted = db.ExecuteNonQuery(insertPhieuTra, parameters);
                    Console.WriteLine($"→ INSERT PHIEUTRASACH: {rowsInserted} dòng");
                    if (rowsInserted == 0)
                    {
                        Console.WriteLine("✗ LỖI: INSERT không thành công");
                        return false;
                    }
                    // 2. Cập nhật tình trạng sách trong CTPHIEUMUON
                    string updateCTPhieuMuon = @"
                    UPDATE CTPHIEUMUON 
                    SET MaTinhTrang = @MaTinhTrang 
                    WHERE MaPhieuMS = @MaPhieuMS AND MaSach = @MaSach";

                    var updateParams = new SqlParameter[]
                    {
                    new SqlParameter("@MaTinhTrang", GetMaTinhTrang(phieuTra.TinhTrangSach)),
                    new SqlParameter("@MaPhieuMS", phieuTra.MaPhieuMS),
                    new SqlParameter("@MaSach", phieuTra.MaSach)
                    };
                    Console.WriteLine("→ Đang thực hiện UPDATE...");
                    int rowsUpdated = db.ExecuteNonQuery(updateCTPhieuMuon, updateParams);
                    Console.WriteLine($"→ UPDATE CTPHIEUMUON: {rowsUpdated} dòng");
                    // Kiểm tra kết quả
                    if (rowsInserted > 0 && rowsUpdated > 0)
                    {
                        Console.WriteLine($"✓ THÀNH CÔNG: Đã lưu sách {phieuTra.MaSach}");
                    }
                    else
                    {
                        Console.WriteLine($"✗ THẤT BẠI: Không thể lưu sách {phieuTra.MaSach}");
                        return false;
                    }
                }
                Console.WriteLine($"=== HOÀN TẤT: Đã xử lý {count} sách ===");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"=== LỖI CHI TIẾT ===");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                Console.WriteLine($"StackTrace: {ex.StackTrace}");

                // Hiển thị lỗi cho người dùng
                MessageBox.Show($"Lỗi khi lưu phiếu trả:\n{ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi Database");
                return false;
            }
        }
        private int GetMaTinhTrang(string tinhTrangSach)
        {
            return 2; 
        }
        public DataTable LaySachDangMuonTheoDocGia(string maDocGia)
        {
            string query = @"
    SELECT 
        pm.MaPhieuMS,
        ct.MaSach,
        ds.TenDauSach,
        dg.HoTen as TenDocGia,
        pm.NgayMuon,
        ct.HanTra,
        CASE 
            WHEN GETDATE() > ct.HanTra THEN DATEDIFF(day, ct.HanTra, GETDATE())
            ELSE 0
        END as SoNgayTraTre,
        CASE 
            WHEN GETDATE() > ct.HanTra THEN N'Quá hạn'
            ELSE N'Đúng hạn'
        END as TrangThai
    FROM CTPHIEUMUON ct
    INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
    INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
    INNER JOIN SACH s ON ct.MaSach = s.MaSach
    INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
    WHERE pm.MaDocGia = @MaDocGia"; 

    return db.ExecuteQuery(query, new SqlParameter[] {
        new SqlParameter("@MaDocGia", maDocGia)
    });
        }
        public DataTable LayThongTinDocGia(string maDocGia)
        {
            string query = @"
            SELECT 
                dg.MaDocGia,
                dg.HoTen,
                dg.NgayHetHan,
                ldg.SoSachToiDa,
                ldg.SoNgayMuonToiDa
            FROM DOCGIA dg
            INNER JOIN LOAIDOCGIA ldg ON dg.MaLoaiDG = ldg.MaLoaiDG
            WHERE dg.MaDocGia = @MaDocGia";

            return db.ExecuteQuery(query, new SqlParameter[] {
            new SqlParameter("@MaDocGia", maDocGia)
        });
        }
        public decimal TinhTienPhat(int soNgayTraTre, string maSach)
        {
            // Tính tiền phạt dựa trên loại vi phạm trong bảng LOAIVIPHAM
            string query = @"
            SELECT ISNULL(SUM(lvp.MucPhat), 0)
            FROM LOAIVIPHAM lvp
            WHERE lvp.TenLoi LIKE N'%trả trễ%' 
            AND @SoNgayTraTre >= 1"; // Giả sử có loại vi phạm "trả trễ"

            var result = db.ExecuteScalar(query, new SqlParameter[] {
            new SqlParameter("@SoNgayTraTre", soNgayTraTre),
            new SqlParameter("@MaSach", maSach)
        });

            return result != null ? Convert.ToDecimal(result) * soNgayTraTre : soNgayTraTre * 5000; // Mặc định 5000đ/ngày
        }
    }
}
