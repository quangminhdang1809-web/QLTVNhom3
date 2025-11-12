using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace QLTVNhom3.BLL
{
    public class ThuThuBLL
    {
        private ThuThuDAL thuThuDAL = new ThuThuDAL();

        // Lấy hàm Hashing (bạn có thể copy từ AccountBLL)
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public DataTable GetDanhSachThuThu()
        {
            return thuThuDAL.GetDanhSachThuThu();
        }

        public DataTable TimKiemThuThu(string tuKhoa)
        {
            return thuThuDAL.TimKiemThuThu(tuKhoa);
        }

        public bool ThemThuThu(ThuThuDTO tt)
        {
            if (string.IsNullOrWhiteSpace(tt.IDAccount))
                throw new Exception("IDAccount không được trống.");
            if (string.IsNullOrWhiteSpace(tt.Password))
                throw new Exception("Mật khẩu không được trống.");
            if (string.IsNullOrWhiteSpace(tt.HoTen))
                throw new Exception("Họ tên không được trống.");

            string hashedPassword = HashPassword(tt.Password);

            return thuThuDAL.ThemThuThu(tt, hashedPassword);
        }

        public bool CapNhatThuThu(ThuThuDTO tt)
        {
            if (string.IsNullOrWhiteSpace(tt.HoTen))
                throw new Exception("Họ tên không được trống.");

            return thuThuDAL.CapNhatThuThu(tt);
        }

        public bool XoaThuThu(string idAccount)
        {
            return thuThuDAL.XoaThuThu(idAccount);
        }
    }
}