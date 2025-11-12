using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class ReportDTO
    {
        // 1. DTO cho báo cáo sách đang mượn hiện tại
        public class CurrentBorrowedBookDTO
        {
            public int STT { get; set; }
            public int MaPhieuMS { get; set; }
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TenDocGia { get; set; }
            public DateTime NgayMuon { get; set; }
            public DateTime HanTra { get; set; }
            public int SoNgayConLai { get; set; }
            public string TrangThai { get; set; }
        }

        public class CurrentBorrowedSummaryDTO
        {
            public int TongSoSachDangMuon { get; set; }
            public int SoSachSapHetHan { get; set; }
            public int SoSachQuaHan { get; set; }
            public DateTime ReportDate { get; set; }
        }

        // 2. DTO cho báo cáo sách quá hạn hiện tại
        public class OverdueBookDTO
        {
            public int STT { get; set; }
            public int MaPhieuMS { get; set; }
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TenDocGia { get; set; }
            public DateTime NgayMuon { get; set; }
            public DateTime HanTra { get; set; }
            public int SoNgayQuaHan { get; set; }
            public decimal TienPhatDuKien { get; set; }
        }

        public class OverdueSummaryDTO
        {
            public int TongSoSachQuaHan { get; set; }
            public int SoDocGiaViPham { get; set; }
            public decimal TongTienPhatDuKien { get; set; }
            public DateTime ReportDate { get; set; }
        }

        // 3. DTO cho báo cáo tiền phạt và số lượng phiếu phạt
        public class FineReportDTO
        {
            public int STT { get; set; }
            public int MaPhieuTra { get; set; }
            public DateTime NgayTra { get; set; }
            public string TenDocGia { get; set; }
            public string LyDoPhat { get; set; }
            public int SoNgayQuaHan { get; set; }
            public decimal TienPhatQuaHan { get; set; }
            public decimal TienPhatLoiSach { get; set; }
            public decimal TongTienPhat { get; set; }
            public string TrangThaiThu { get; set; }
        }

        public class FineReportSummaryDTO
        {
            public int TongSoPhieuPhat { get; set; }
            public decimal TongTienPhat { get; set; }
            public int SoPhieuDaThu { get; set; }
            public int SoPhieuChuaThu { get; set; }
            public decimal TyLeThuPhat { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }

        // 4. DTO cho báo cáo sách được yêu thích nhất
        public class FavoriteBookDTO
        {
            public int STT { get; set; }
            public string MaDauSach { get; set; }
            public string TenSach { get; set; }
            public int SoLuotMuon { get; set; }
        }

        public class FavoriteBookSummaryDTO
        {
            public int TongLuotMuon { get; set; }
            public int TongDauSach { get; set; }
            public string SachMuonNhieuNhat { get; set; }
            public int SoLuotCaoNhat { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }
    }
}
