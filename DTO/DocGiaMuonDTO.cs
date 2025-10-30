using System;

namespace QLTVNhom3.DTO
{
    public class DocGiaMuonDTO
    {
        public int MaDocGia { get; set; }          // Mã độc giả
        public string HoTen { get; set; }          // Họ tên độc giả
        public DateTime NgayHetHan { get; set; }   // Ngày hết hạn thẻ
        public int SoSachToiDa { get; set; }       // Số sách tối đa được mượn

        public int MaSach { get; set; }            // Mã sách đang mượn
        public string TenSach { get; set; }        // Tên sách
        public int NamXuatBan { get; set; }        // Năm xuất bản

        public DateTime NgayMuon { get; set; }     // Ngày mượn
        public DateTime HanTra { get; set; }       // Hạn trả
        public bool QuaHan { get; set; }           // Đánh dấu sách có bị quá hạn hay không

        // --- Tùy chọn: bạn có thể thêm các thuộc tính bổ sung ---
        public string MaPhieuMS { get; set; }      // Mã phiếu mượn sách (nếu cần)
        public string TinhTrang { get; set; }      // Tình trạng sách (nếu muốn hiển thị)
    }
}
