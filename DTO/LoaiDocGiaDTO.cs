using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class LoaiDocGiaDTO
    {
        public int MaLoaiDG { get; set; }
        public string TenLoaiDG { get; set; }
        public int ThoiHanThe { get; set; } // tính bằng năm
        public int SoSachToiDa { get; set; }
        public int SoNgayMuonToiDa { get; set; }
        public LoaiDocGiaDTO() { }

        public LoaiDocGiaDTO(int maLoaiDG, string tenLoaiDG, int thoiHanThe, int soSachToiDa, int soNgayMuonToiDa)
        {
            MaLoaiDG = maLoaiDG;
            TenLoaiDG = tenLoaiDG;
            ThoiHanThe = thoiHanThe;
            SoSachToiDa = soSachToiDa;
            SoNgayMuonToiDa = soNgayMuonToiDa;
        }
    }
}
