using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLTVNhom3.BLL
{
    public class BanSachBLL
    {
        // Giả sử DAL của bạn tên là BanSachDAL
        private BanSachDAL banSachDAL = new BanSachDAL();

        public List<BanSachDTO> LayTatCaSach()
        {
            return banSachDAL.LayTatCaSach();
        }

        public BanSachDTO LayChiTietSach(string maSach)
        {
            return banSachDAL.LayChiTietSach(maSach);
        }

        public DataTable LayDanhSachTinhTrang()
        {
            return banSachDAL.LayDanhSachTinhTrang();
        }

        public bool CapNhatSach(BanSachDTO sach)
        {
            if (sach.MaTinhTrang <= 0)
                throw new Exception("Trạng thái không hợp lệ.");
            return banSachDAL.CapNhatSach(sach);
        }

        public bool XoaSach(string maSach)
        {
            return banSachDAL.XoaSach(maSach);
        }

        // HÀM MỚI (Sửa lỗi CS1061 và lỗi "trống trơn")
        public List<BanSachDTO> LaySachTheoDauSach(string maDauSach)
        {
            return banSachDAL.LaySachTheoDauSach(maDauSach);
        }

        // HÀM MỚI (Cho tìm kiếm)
        public List<BanSachDTO> TimKiemSach(string tuKhoa)
        {
            return banSachDAL.TimKiemSach(tuKhoa, null);
        }
    }
}