using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    internal class PhieuMuonDTO
    {
        public int MaPhieuMS { get; set; }
        public int MaDocGia { get; set; }
        public string HoTenDocGia { get; set; }
        public string MaSach { get; set; }
        public string TenDauSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TenTinhTrang { get; set; }
        public string HinhThucMuon { get; set; }
    }
}
