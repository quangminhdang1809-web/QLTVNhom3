using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic; // <-- Cần thêm thư viện này
using System.Data;

namespace QLTVNhom3.BLL
{
    public class DauSachBLL
    {
        private DauSachDAL dauSachDAL = new DauSachDAL();

        // 1. Lấy danh sách đầu sách
        public DataTable LayDanhSachDauSach()
        {
            return dauSachDAL.LayDanhSachDauSach();
        }

        // 2. Lấy chi tiết sách
        public DauSachDTO LayChiTietSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
                throw new ArgumentException("Mã đầu sách không được để trống");

            return dauSachDAL.LayChiTietSach(maDauSach);
        }

        // 3. Tìm kiếm sách
        public DataTable TimKiemSach(string tuKhoa)
        {
            return dauSachDAL.TimKiemSach(tuKhoa);
        }

        // 4. Cập nhật sách
        // ▼▼▼ SỬA HÀM NÀY (thêm List<TacGiaDTO> tacGiasMoi) ▼▼▼
        public bool CapNhatSach(DauSachDTO sachDaSua, List<TacGiaDTO> tacGiasMoi, int soLuongCu)
        {
            // 1. Validate dữ liệu
            if (string.IsNullOrEmpty(sachDaSua.TenDauSach))
                throw new ArgumentException("Tên đầu sách không được để trống");

            if (sachDaSua.SoLuongTong < soLuongCu)
                throw new ArgumentException("Không thể giảm số lượng. Vui lòng sử dụng chức năng 'Thanh lý' ở form Mã Cá Biệt.");

            if (sachDaSua.NamXuatBan < 1000 || sachDaSua.NamXuatBan > DateTime.Now.Year)
                throw new ArgumentException("Năm xuất bản không hợp lệ");

            // Thêm kiểm tra tác giả
            if (tacGiasMoi.Count == 0)
                throw new ArgumentException("Sách phải có ít nhất 1 tác giả");


            // 2. Gọi DAL Transaction với 3 tham số
            return dauSachDAL.CapNhatSachTransaction(sachDaSua, tacGiasMoi, soLuongCu);
        }
        // ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

        // 5. Xóa sách
        public bool XoaSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
                throw new ArgumentException("Mã đầu sách không được để trống");

            return dauSachDAL.XoaSach(maDauSach);
        }

        // 6. Lấy danh sách thể loại
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            return dauSachDAL.LayDanhSachTheLoai();
        }

        // 7. Lấy danh sách vị trí
        public List<ViTriDTO> LayDanhSachViTri()
        {
            return dauSachDAL.LayDanhSachViTri();
        }

        // 8. Lấy mã đầu sách mới
        public string GetMaDauSachMoi()
        {
            return dauSachDAL.GetMaDauSachMoi();
        }

        // 9. Thêm sách mới
        public bool ThemSachMoi(DauSachDTO dauSach, List<TacGiaDTO> tacGias, List<BanSachDTO> banSach)
        {
            // (Code validate của bạn ở đây)
            if (string.IsNullOrEmpty(dauSach.TenDauSach))
                throw new Exception("Tên sách không được rỗng");
            if (dauSach.MaTheLoai <= 0)
                throw new Exception("Vui lòng chọn thể loại");
            if (string.IsNullOrEmpty(dauSach.MaViTri))
                throw new Exception("Vui lòng chọn vị trí");
            if (tacGias.Count == 0)
                throw new Exception("Sách phải có ít nhất 1 tác giả");
            if (banSach.Count == 0 || dauSach.SoLuongTong <= 0)
                throw new Exception("Phải thêm ít nhất 1 bản sách (nhập số lượng và nhấn +)");

            return dauSachDAL.ThemSachMoi(dauSach, tacGias, banSach);
        }

        // 10. Lấy danh sách bản sách (cho popup)
        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
            {
                return new List<BanSachDTO>();
            }
            return dauSachDAL.LayDanhSachBanSach(maDauSach);

        }
    }
}