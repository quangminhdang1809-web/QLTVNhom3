using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class PhieuTraDTO
    {
        public int MaPhieuMS { get; set; }
        public string MaSach { get; set; }
        public string TenDauSach { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNgayTraTre { get; set; }
        public string TinhTrangSach { get; set; }
        public int? MaLoiQuaHan { get; set; }
        public int MaLoiSach { get; set; }
        public decimal TienPhatQuaHan { get; set; }
        public decimal TienPhatLoiSach { get; set; }
        public decimal TongTienPhat { get; set; }
        public string GhiChu { get; set; }
        public int MaThuThu { get; set; }
        // Thêm các thuộc tính để hiển thị thông tin
        public string TenLoiQuaHan { get; set; }
        public string TenLoiSach { get; set; }
        public decimal MucPhatQuaHan { get; set; }
        public decimal MucPhatLoiSach { get; set; }

        // Thuộc tính tính toán
        public bool DaQuaHan => SoNgayTraTre > 0;
        public string TrangThai => DaQuaHan ? "Trả trễ" : "Trả đúng hạn";
    }
}
