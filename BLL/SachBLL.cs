using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.BLL
{
    public class SachBLL
    {
        private SachDAL sachDAL;

        public SachBLL()
        {
            sachDAL = new SachDAL();
        }

        public bool ThemDauSachMoi(SachDTO dauSach)
        {
            // Validate dữ liệu
            if (string.IsNullOrEmpty(dauSach.TenDauSach))
                throw new Exception("Tên đầu sách không được để trống");

            if (dauSach.SoLuongTong <= 0)
                throw new Exception("Số lượng phải lớn hơn 0");

            if (dauSach.DanhSachTacGia.Count == 0)
                throw new Exception("Phải có ít nhất một tác giả");

            // Tự động sinh mã đầu sách nếu chưa có
            if (string.IsNullOrEmpty(dauSach.MaDauSach))
                dauSach.MaDauSach = sachDAL.SinhMaDauSach();

            // Tạo các bản sách vật lý
            TaoDanhSachBanSach(dauSach);

            // Gọi DAL để lưu vào database
            return sachDAL.ThemDauSach(dauSach);
        }

        private void TaoDanhSachBanSach(SachDTO dauSach)
        {
            dauSach.DanhSachBanSach.Clear();

            for (int i = 1; i <= dauSach.SoLuongTong; i++)
            {
                var banSach = new BanSachDTO
                {
                    MaSach = sachDAL.SinhMaSach(dauSach.MaDauSach, i),
                    MaDauSach = dauSach.MaDauSach,
                    MaTinhTrang = 1 // Mặc định: Có sẵn
                };
                dauSach.DanhSachBanSach.Add(banSach);
            }
        }

        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            return sachDAL.LayDanhSachTheLoai();
        }

        public List<ViTriDTO> LayDanhSachViTri()
        {
            return sachDAL.LayDanhSachViTri();
        }

        public List<TinhTrangDTO> LayDanhSachTinhTrang()
        {
            return sachDAL.LayDanhSachTinhTrang();
        }

        public string SinhMaDauSach()
        {
            return sachDAL.SinhMaDauSach();
        }
    }
}