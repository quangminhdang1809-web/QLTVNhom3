using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Data;

namespace QLTVNhom3.BLL
{
    public class ViPhamBLL
    {
        private ViPhamDAL viPhamDAL = new ViPhamDAL();

        public DataTable GetDanhSachViPham()
        {
            return viPhamDAL.GetDanhSachViPham();
        }

        public DataTable TimKiemViPham(string tuKhoa)
        {
            return viPhamDAL.TimKiemViPham(tuKhoa);
        }

        public bool LuuViPham(ViPhamDTO dto)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(dto.TenLoi))
                throw new Exception("Tên lỗi không được để trống.");
            if (dto.MucPhat < 0)
                throw new Exception("Mức phạt không được là số âm.");
            if (string.IsNullOrEmpty(dto.LoaiViPham))
                throw new Exception("Vui lòng chọn loại vi phạm.");

            // Kiểm tra Thêm mới hay Cập nhật
            if (dto.MaLoi == 0)
            {
                return viPhamDAL.ThemViPham(dto);
            }
            else
            {
                return viPhamDAL.CapNhatViPham(dto);
            }
        }

        public bool XoaViPham(int maLoi)
        {
            return viPhamDAL.XoaViPham(maLoi);
        }
        public DataTable GetDistinctLoaiViPham()
        {
            return viPhamDAL.GetDistinctLoaiViPham();
        }
    }
}