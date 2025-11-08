using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
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
        // [TRONG FILE DauSachBLL.cs]
        // THAY THẾ HÀM CapNhatSach

        public bool CapNhatSach(DauSachDTO sachDaSua, int soLuongCu)
        {
            // 1. Validate dữ liệu
            if (string.IsNullOrEmpty(sachDaSua.TenDauSach))
                throw new ArgumentException("Tên đầu sách không được để trống");

            // 2. KIỂM TRA QUAN TRỌNG
            if (sachDaSua.SoLuongTong < soLuongCu)
                throw new ArgumentException("Không thể giảm số lượng. Vui lòng sử dụng chức năng 'Thanh lý' ở form Mã Cá Biệt.");

            if (sachDaSua.NamXuatBan < 1000 || sachDaSua.NamXuatBan > DateTime.Now.Year)
                throw new ArgumentException("Năm xuất bản không hợp lệ");


            // 3. Gọi DAL Transaction (hàm này sẽ xử lý việc tạo bản sách mới)
            return dauSachDAL.CapNhatSachTransaction(sachDaSua, soLuongCu);
        }

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
        public string GetMaDauSachMoi()
        {
            return dauSachDAL.GetMaDauSachMoi();
        }

        public bool ThemSachMoi(DauSachDTO dauSach, List<TacGiaDTO> tacGias, List<BanSachDTO> banSach)
        {
            // Kiểm tra logic nghiệp vụ (BLL)
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

            // Gọi DAL để thực thi
            return dauSachDAL.ThemSachMoi(dauSach, tacGias, banSach);
        }
        // [THÊM HÀM NÀY VÀO DAUSACHBLL.CS]

        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
            {
                return new List<BanSachDTO>(); // Trả về danh sách rỗng nếu không có mã
            }
            return dauSachDAL.LayDanhSachBanSach(maDauSach);
        }
    }
}
