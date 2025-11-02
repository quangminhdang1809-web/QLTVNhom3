using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.BLL
{
    public class PhieuTraBLL
    {
        private PhieuTraDAL phieuTraDAL = new PhieuTraDAL();
        public DataTable LaySachDangMuonTheoDocGia(string maDocGia)
        {
            if (string.IsNullOrEmpty(maDocGia))
            {
                Console.WriteLine("Mã độc giả trống!");
                return new DataTable();
            }

            Console.WriteLine($"BLL: Đang tìm sách mượn của độc giả {maDocGia}");

            DataTable result = phieuTraDAL.LaySachDangMuonTheoDocGia(maDocGia);

            Console.WriteLine($"BLL: Tìm thấy {result.Rows.Count} sách cho độc giả {maDocGia}");

            // DEBUG: Kiểm tra schema
            if (result.Columns.Count > 0)
            {
                Console.WriteLine("Schema của kết quả:");
                foreach (DataColumn col in result.Columns)
                {
                    Console.WriteLine($" - {col.ColumnName} ({col.DataType})");
                }
            }

            return result;
        }

        public DataTable LayThongTinDocGia(string maDocGia)
        {
            if (string.IsNullOrEmpty(maDocGia))
                return new DataTable();

            return phieuTraDAL.LayThongTinDocGia(maDocGia);
        }
        public decimal TinhTienPhat(int soNgayTraTre, string maSach)
        {
            return phieuTraDAL.TinhTienPhat(soNgayTraTre, maSach);
        }
    public bool LuuDanhSachPhieuTra(List<PhieuTraDTO> danhSachPhieuTra)
        {
            try
            {
                Console.WriteLine("=== BLL: BẮT ĐẦU LƯU PHIẾU TRẢ ===");
                Console.WriteLine($"Số sách cần lưu: {danhSachPhieuTra?.Count}");

                bool result = phieuTraDAL.LuuDanhSachPhieuTra(danhSachPhieuTra);

                Console.WriteLine($"=== BLL: KẾT THÚC - Kết quả: {result} ===");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"=== LỖI BLL ===");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                MessageBox.Show($"Lỗi BLL: {ex.Message}", "Lỗi");
                return false;
            }
        }
    }
}
