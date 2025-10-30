using QLTVNhom3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class SachDTO
    {
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public short NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoLuongTong { get; set; }
        public string MaViTri { get; set; }
        public string TenViTri { get; set; }
        public byte[] AnhBia { get; set; }
        public List<TacGiaDTO> DanhSachTacGia { get; set; }
        public List<BanSachDTO> DanhSachBanSach { get; set; }

        // SỬA: Constructor cho SachDTO
        public SachDTO()
        {
            DanhSachTacGia = new List<TacGiaDTO>();
            DanhSachBanSach = new List<BanSachDTO>();
        }
    }
    public class TacGiaDTO
    {
        public string MaTacGia { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
    }

    public class BanSachDTO
    {
        public string MaSach { get; set; }
        public string MaDauSach { get; set; }
        public int MaTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
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

    public class TinhTrangDTO
    {
        public int MaTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
    }
}
