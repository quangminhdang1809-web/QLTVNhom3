using System;

namespace QLTVNhom3.DTO
{
    public class ThuThuDTO
    {
        public int MaThuThu { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string IDAccount { get; set; }
        public string SoDienThoai { get; set; }

        // Dùng cho việc Thêm mới
        public string Password { get; set; }
    }
}