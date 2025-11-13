using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class DocGiaDTO
    {
        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string IDAccount { get; set; }
        public string SoDienThoai { get; set; }
        public int MaLoaiDG { get; set; }
        public string TenLoaiDG { get; set; }
        public string PasswordAccount { get; set; }
        public string TypeOfAccount { get; set; }
    }
}


