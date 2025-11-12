using System;

namespace QLTVNhom3.BLL // Hoặc namespace nào bạn muốn
{
    public static class UserSession
    {
        // Đây là biến static toàn cục để lưu mã thủ thư
        public static int MaThuThu { get; set; }
        public static string IDAccount { get; set; }
        public static string HoTen { get; set; }
    }
}