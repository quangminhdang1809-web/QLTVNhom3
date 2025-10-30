using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class DauSachDTO
    {
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public byte[] AnhBia { get; set; }
        public int MaTheLoai { get; set; }
        public short NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoLuongTong { get; set; }
        public string MaViTri { get; set; }
        public string TenTheLoai { get; set; }
        public string TenViTri { get; set; }
        public List<TacGiaDTO> DanhSachTacGia { get; set; }
    }
    public class TacGiaDTO
    {
        public int MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public int? NamSinh { get; set; }
        public string QuocTich { get; set; }
    }
    public class TheLoaiDTO
    {
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
    }
    public class ViTriDTO
    {
        public string MaViTri { get; set; }
        public string TenViTri { get; set; }
    }
}
