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
        public bool CapNhatSach(DauSachDTO sach)
        {
            // Validate dữ liệu
            if (string.IsNullOrEmpty(sach.TenDauSach))
                throw new ArgumentException("Tên đầu sách không được để trống");

            if (sach.SoLuongTong < 0)
                throw new ArgumentException("Số lượng không được âm");

            if (sach.NamXuatBan < 1000 || sach.NamXuatBan > DateTime.Now.Year)
                throw new ArgumentException("Năm xuất bản không hợp lệ");

            return dauSachDAL.CapNhatSach(sach);
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
    }
}
