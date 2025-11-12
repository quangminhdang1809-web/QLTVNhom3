using QLTVNhom3.DTO;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLTVNhom3.DAL
{
    public class ThuThuDAL
    {
        private DBHelper db = new DBHelper();

        // Lấy danh sách Thủ thư (đã Xóa Mềm tài khoản)
        public DataTable GetDanhSachThuThu()
        {
            string query = @"
                SELECT t.MaThuThu, t.HoTen, t.NgaySinh, t.Email, t.IDAccount, t.SoDienThoai
                FROM THUTHU t
                LEFT JOIN ACCOUNT a ON t.IDAccount = a.IDAccount
                WHERE a.TrangThai = 1 AND a.TypeOfAccount = 'THUTHU'
                ORDER BY t.MaThuThu";
            return db.ExecuteQuery(query);
        }

        // Tìm kiếm Thủ thư
        public DataTable TimKiemThuThu(string tuKhoa)
        {
            string query = @"
                SELECT t.MaThuThu, t.HoTen, t.NgaySinh, t.Email, t.IDAccount, t.SoDienThoai
                FROM THUTHU t
                LEFT JOIN ACCOUNT a ON t.IDAccount = a.IDAccount
                WHERE a.TrangThai = 1 AND a.TypeOfAccount = 'THUTHU'
                AND (t.HoTen LIKE @TuKhoa OR t.Email LIKE @TuKhoa OR t.SoDienThoai LIKE @TuKhoa)
                ORDER BY t.MaThuThu";

            SqlParameter[] param = { new SqlParameter("@TuKhoa", $"%{tuKhoa}%") };
            return db.ExecuteQuery(query, param);
        }

        // Thêm Thủ thư (Transaction)
        public bool ThemThuThu(ThuThuDTO tt, string hashedPassword)
        {
       
            try
            {
                // 1. Thêm vào ACCOUNT
                string queryAcc = @"
                    INSERT INTO ACCOUNT (IDAccount, PasswordAccount, TypeOfAccount, TrangThai)
                    VALUES (@IDAccount, @Password, 'THUTHU', 1)";
                SqlParameter[] paramAcc = {
                    new SqlParameter("@IDAccount", tt.IDAccount),
                    new SqlParameter("@Password", hashedPassword)
                };
                db.ExecuteNonQuery(queryAcc, paramAcc);

                // 2. Thêm vào THUTHU
                string queryTT = @"
                    INSERT INTO THUTHU (HoTen, NgaySinh, Email, IDAccount, SoDienThoai)
                    VALUES (@HoTen, @NgaySinh, @Email, @IDAccount, @SoDienThoai)";
                SqlParameter[] paramTT = {
                    new SqlParameter("@HoTen", tt.HoTen),
                    new SqlParameter("@NgaySinh", tt.NgaySinh),
                    new SqlParameter("@Email", tt.Email),
                    new SqlParameter("@IDAccount", tt.IDAccount),
                    new SqlParameter("@SoDienThoai", tt.SoDienThoai)
                };
                db.ExecuteNonQuery(queryTT, paramTT);

             
                return true;
            }
            catch (Exception ex)
            {
             
                throw ex; // Ném lỗi ra BLL
            }
        }

        // Cập nhật Thủ thư
        public bool CapNhatThuThu(ThuThuDTO tt)
        {
            string query = @"
                UPDATE THUTHU
                SET HoTen = @HoTen,
                    NgaySinh = @NgaySinh,
                    Email = @Email,
                    SoDienThoai = @SoDienThoai
                WHERE MaThuThu = @MaThuThu";

            SqlParameter[] param = {
                new SqlParameter("@HoTen", tt.HoTen),
                new SqlParameter("@NgaySinh", tt.NgaySinh),
                new SqlParameter("@Email", tt.Email),
                new SqlParameter("@SoDienThoai", tt.SoDienThoai),
                new SqlParameter("@MaThuThu", tt.MaThuThu)
            };
            return db.ExecuteNonQuery(query, param) > 0;
        }

        // Xóa Mềm (Vô hiệu hóa tài khoản)
        public bool XoaThuThu(string idAccount)
        {
            string query = "UPDATE ACCOUNT SET TrangThai = 0 WHERE IDAccount = @IDAccount";
            SqlParameter[] param = {
                new SqlParameter("@IDAccount", idAccount)
            };
            return db.ExecuteNonQuery(query, param) > 0;
        }
    }
}