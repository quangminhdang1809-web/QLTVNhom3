using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO; 
using System.Collections.Generic;

namespace QLTVNhom3.DAL
{
    public class PhieuTraDAL
    {
        private DBHelper db = new DBHelper();
        private const int MA_LOI_QUA_HAN_CO_DINH = 10; // Giả định Mã lỗi Quá hạn

        public bool LuuDanhSachPhieuTra(List<PhieuTraDTO> danhSachPhieuTra)
        {
            // BẮT BUỘC: Gói tất cả vào Transaction
            // GIẢ ĐỊNH: DBHelper hỗ trợ BeginTransaction/Commit/Rollback
            // Nếu DBHelper của bạn không có, dòng này sẽ gây lỗi.
            // db.BeginTransaction(); 

            int count = 0;

            try
            {
                // BẮT ĐẦU TRANSACTION (Nếu DBHelper hỗ trợ)
                // Dùng phương thức đã sửa của bạn nếu có: db.BeginTransaction();

                foreach (var phieuTra in danhSachPhieuTra)
                {
                    count++;
                    Console.WriteLine($"=== ĐANG XỬ LÝ SÁCH {count}/{danhSachPhieuTra.Count} (MS:{phieuTra.MaPhieuMS}, S:{phieuTra.MaSach}) ===");

                    // 0. LOGIC ÁNH XẠ DỮ LIỆU VÀ TÍNH TOÁN LỖI
                    int maTinhTrangMoi = GetMaTinhTrang(phieuTra.TinhTrangSach);
                    List<int> dsMaLoi = GetDanhSachMaLoiTuPhieuTra(phieuTra);

                    // 1. INSERT PHIEUTRASACH và lấy MaPhieuTra (Dùng OUTPUT)
                    string insertPhieuTra = @"
                        INSERT INTO PHIEUTRASACH (MaPhieuMS, MaSach, NgayTra, SoNgayTraTre, 
                                                  TienPhatQuaHan, TienPhatLoiSach, TongTienPhat, GhiChu, MaThuThu)
                        OUTPUT INSERTED.MaPhieuTra
                        VALUES (@MaPhieuMS, @MaSach, @NgayTra, @SoNgayTraTre, 
                                @TienPhatQuaHan, @TienPhatLoiSach, @TongTienPhat, @GhiChu, @MaThuThu)";

                    var phieuTraParams = new SqlParameter[]
                    {
                        new SqlParameter("@MaPhieuMS", phieuTra.MaPhieuMS),
                        new SqlParameter("@MaSach", phieuTra.MaSach),
                        new SqlParameter("@NgayTra", phieuTra.NgayTra),
                        new SqlParameter("@SoNgayTraTre", phieuTra.SoNgayTraTre),
                        new SqlParameter("@TienPhatQuaHan", phieuTra.TienPhatQuaHan),
                        new SqlParameter("@TienPhatLoiSach", phieuTra.TienPhatLoiSach),
                        new SqlParameter("@TongTienPhat", phieuTra.TongTienPhat),
                        new SqlParameter("@GhiChu", phieuTra.GhiChu ?? (object)DBNull.Value),
                        new SqlParameter("@MaThuThu", phieuTra.MaThuThu)
                    };

                    object result = db.ExecuteScalar(insertPhieuTra, phieuTraParams);
                    if (result == null || !int.TryParse(result.ToString(), out int maPhieuTraMoi))
                    {
                        throw new Exception("Lỗi: Không lấy được MaPhieuTra mới.");
                    }
                    Console.WriteLine($"→ INSERT PHIEUTRASACH thành công. MaPhieuTra = {maPhieuTraMoi}");

                    // 2. INSERT CTVIPHAM (Sử dụng MaPhieuTraMoi và dsMaLoi)
                    if (dsMaLoi.Any())
                    {
                        foreach (int maLoi in dsMaLoi)
                        {
                            string insertCTViPham = @"
                                INSERT INTO CTVIPHAM (MaPhieuTra, MaLoi, MoTa)
                                VALUES (@MaPhieuTra, @MaLoi, @MoTa)";

                            var ctViPhamParams = new SqlParameter[]
                            {
                                new SqlParameter("@MaPhieuTra", maPhieuTraMoi),
                                new SqlParameter("@MaLoi", maLoi),
                                new SqlParameter("@MoTa", phieuTra.GhiChu ?? (object)DBNull.Value)
                            };
                            db.ExecuteNonQuery(insertCTViPham, ctViPhamParams);
                        }
                        Console.WriteLine($"→ INSERT CTVIPHAM: {dsMaLoi.Count} lỗi đã được lưu.");
                    }

                    // 3. UPDATE CTPHIEUMUON (Đánh dấu trạng thái trả)
                    string updateCTPhieuMuon = @"
                        UPDATE CTPHIEUMUON SET MaTinhTrang = @MaTinhTrang 
                        WHERE MaPhieuMS = @MaPhieuMS AND MaSach = @MaSach";

                    db.ExecuteNonQuery(updateCTPhieuMuon, new SqlParameter[] {
                        new SqlParameter("@MaTinhTrang", maTinhTrangMoi),
                        new SqlParameter("@MaPhieuMS", phieuTra.MaPhieuMS),
                        new SqlParameter("@MaSach", phieuTra.MaSach)
                    });
                    Console.WriteLine($"→ UPDATE CTPHIEUMUON: Đã cập nhật trạng thái trả.");

                    // 4. UPDATE SACH (Cập nhật trạng thái vật lý)
                    string updateSach = @"
                        UPDATE SACH SET MaTinhTrang = @MaTinhTrangMoi 
                        WHERE MaSach = @MaSach";

                    db.ExecuteNonQuery(updateSach, new SqlParameter[] {
                        new SqlParameter("@MaTinhTrangMoi", maTinhTrangMoi),
                        new SqlParameter("@MaSach", phieuTra.MaSach)
                    });
                    Console.WriteLine($"→ UPDATE SACH: Đã cập nhật trạng thái vật lý.");

                    Console.WriteLine($"✓ THÀNH CÔNG: Đã xử lý sách {phieuTra.MaSach}");
                } // END foreach

                // COMMIT TRANSACTION
                // Dùng phương thức đã sửa của bạn nếu có: db.CommitTransaction();

                Console.WriteLine($"=== HOÀN TẤT: Đã xử lý {count} sách ===");
                return true;
            }
            catch (Exception ex)
            {
                // ROLLBACK TRANSACTION
                // Dùng phương thức đã sửa của bạn nếu có: db.RollbackTransaction();

                Console.WriteLine($"=== LỖI CHI TIẾT ===");
                throw;
                // Log lỗi
                return false;
            }
        }

        // ******************************************************
        //             LOGIC PHỤ (Thay thế BLL)
        // ******************************************************

        private int GetMaTinhTrang(string tinhTrangSach)
        {
            // Logic ánh xạ string -> int
            if (string.IsNullOrEmpty(tinhTrangSach)) return 1;

            switch (tinhTrangSach.Trim().ToLower())
            {
                case "bình thường":
                case "tốt":
                    return 1; // Sẵn sàng mượn
                case "hư hỏng":
                case "rách":
                    return 3; // Cần sửa chữa
                case "mất":
                    return 4; // Bị mất
                default:
                    return 1;
            }
        }

        private List<int> GetDanhSachMaLoiTuPhieuTra(PhieuTraDTO phieuTra)
        {
            // Logic tính toán lỗi (Giả định DTO có DsMaLoiViPham)
            // Nếu bạn có DTO cũ, bạn cần thay thế bằng logic ánh xạ từ MaLoiSach (int)
            List<int> dsLoi = phieuTra.DsMaLoiViPham ?? new List<int>();

            // Nếu trả trễ, thêm mã lỗi quá hạn
            if (phieuTra.SoNgayTraTre > 0 && !dsLoi.Contains(MA_LOI_QUA_HAN_CO_DINH))
            {
                dsLoi.Add(MA_LOI_QUA_HAN_CO_DINH);
            }

            return dsLoi;
        }

        // ******************************************************
        //             CÁC HÀM TRUY VẤN PUBLIC
        // ******************************************************

        public DataTable LaySachDangMuonTheoDocGia(string maDocGia)
        {
            const int MA_TINH_TRANG_DANG_MUON = 2; // Đã xác nhận mã 2 là Đang Mượn

            // Bổ sung xử lý MaDocGia (int)
            int maDocGiaInt = 0;
            if (!int.TryParse(maDocGia, out maDocGiaInt))
            {
                // Trả về DataTable rỗng nếu Mã độc giả không hợp lệ
                return new DataTable();
            }

            string query = @"
        SELECT pm.MaPhieuMS, ct.MaSach, ds.TenDauSach, dg.HoTen as TenDocGia,
               pm.NgayMuon, ct.HanTra,
               CASE WHEN GETDATE() > ct.HanTra THEN DATEDIFF(day, ct.HanTra, GETDATE()) ELSE 0 END as SoNgayTraTre,
               CASE WHEN GETDATE() > ct.HanTra THEN N'Quá hạn' ELSE N'Đúng hạn' END as TrangThai
        FROM CTPHIEUMUON ct
        INNER JOIN PHIEUMUON pm ON ct.MaPhieuMS = pm.MaPhieuMS
        INNER JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
        INNER JOIN SACH s ON ct.MaSach = s.MaSach
        INNER JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
        WHERE pm.MaDocGia = @MaDocGia 
          AND ct.MaTinhTrang = @MaTinhTrangDangMuon "; // <--- Sử dụng tham số SQL

            // SỬA LỖI: Cung cấp giá trị cho @MaTinhTrangDangMuon và @MaDocGia
            return db.ExecuteQuery(query, new SqlParameter[] {
        // Tham số 1: Mã độc giả (dùng giá trị int đã chuyển đổi)
        new SqlParameter("@MaDocGia", maDocGiaInt), 
        // Tham số 2: Mã Tình trạng Đang Mượn (Giá trị bị thiếu gây lỗi)
        new SqlParameter("@MaTinhTrangDangMuon", MA_TINH_TRANG_DANG_MUON)
    });
        }

        public DataTable LayThongTinDocGia(string maDocGia)
        {
            string query = @"
                SELECT dg.MaDocGia, dg.HoTen, dg.NgayHetHan, ldg.SoSachToiDa, ldg.SoNgayMuonToiDa
                FROM DOCGIA dg
                INNER JOIN LOAIDOCGIA ldg ON dg.MaLoaiDG = ldg.MaLoaiDG
                WHERE dg.MaDocGia = @MaDocGia";

            return db.ExecuteQuery(query, new SqlParameter[] {
                new SqlParameter("@MaDocGia", maDocGia)
            });
        }

        public decimal TinhTienPhat(int soNgayTraTre, string maSach)
        {
            string query = @"
                SELECT ISNULL(SUM(lvp.MucPhat), 0)
                FROM LOAIVIPHAM lvp
                WHERE lvp.TenLoi LIKE N'%trả trễ%' AND @SoNgayTraTre >= 1";

            var result = db.ExecuteScalar(query, new SqlParameter[] {
                new SqlParameter("@SoNgayTraTre", soNgayTraTre),
                new SqlParameter("@MaSach", maSach)
            });

            return result != null ? Convert.ToDecimal(result) * soNgayTraTre : soNgayTraTre * 5000;
        }
        public DataTable LayDanhSachLoaiViPham()
        {
            string query = @"
        SELECT MaLoi, TenLoi, MucPhat 
        FROM LOAIVIPHAM 
        WHERE LoaiViPham = N'Lỗi sách' 
        ORDER BY MaLoi";
            // Chỉ lấy các lỗi liên quan đến sách (không bao gồm Quá hạn, vì Quá hạn tính tự động)

            return db.ExecuteQuery(query, null);
        }
    }
}