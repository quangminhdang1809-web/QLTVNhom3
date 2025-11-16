using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVNhom3.DTO;

namespace QLTVNhom3.DAL
{
    public class AccountDAL
    {
        private DBHelper db = new DBHelper();

        public AccountDTO CheckLogin (string IDAccount, string PasswordAccount)
        {
            string query = "select * from ACCOUNT where IDAccount = @id and PasswordAccount = @pw";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", IDAccount),
                new SqlParameter("@pw", PasswordAccount)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return new AccountDTO
                {
                    IDAccount = dt.Rows[0]["IDAccount"].ToString(),
                    PasswordAccount = dt.Rows[0]["PasswordAccount"].ToString(),
                    TypeOfAccount = dt.Rows[0]["TypeOfAccount"].ToString()
                };
            }
            return null; 
        }

        public DataRow GetDocGiaInfo (string idAccount)
        {
            var dt = db.ExecuteQuery("sp_GetDocGiaByAccount", new SqlParameter[] 
                { 
                    new SqlParameter("@IDAccount", idAccount) 
                }, 
                isStoredProc: true);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataRow GetThuThuInfo (string idAccount)
        {
            var dt = db.ExecuteQuery("sp_GetThuThuByAccount", new SqlParameter[]
                {
                    new SqlParameter("@IDAccount", idAccount)
                },
                isStoredProc: true);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public string GetTenDocGia (string idAccount)
        {
            string query = "select HoTen from DOCGIA where IDAccount = @id";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@id", idAccount)
            };
            DataTable dt = db.ExecuteQuery(query, parameter);
            if ( dt.Rows.Count>0)
                return dt.Rows[0]["HoTen"].ToString();
            return null; 
        }
        public string GetTenThuThu (string idAccount)
        {
            string query = "select HoTen from THUTHU where IDAccount = @id";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@id", idAccount)
            };
            DataTable dt = db.ExecuteQuery(query, parameter);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["HoTen"].ToString();
            return null;
        }
        // (Dán hàm mới này vào file AccountDAL.cs của bạn)

        // Dùng IDAccount (string) để lấy MaThuThu (int)
        public int LayMaThuThuTuAccount(string idAccount)
        {
            // 1. Câu query chỉ lấy MaThuThu
            string query = "select MaThuThu from THUTHU where IDAccount = @id";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@id", idAccount)
            };

            // 2. Dùng ExecuteScalar, cách này hiệu quả nhất để lấy 1 giá trị duy nhất
            object result = db.ExecuteScalar(query, parameter);

            // 3. Kiểm tra và trả về kết quả
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0; // Trả về 0 nếu không tìm thấy thủ thư
        }
        // [DÁN 2 HÀM NÀY VÀO CUỐI FILE AccountDAL.cs]

        // Hàm lấy danh sách tài khoản để hiển thị lên lưới
        public DataTable GetAccountListView()
        {
            // COALESCE dùng để lấy tên từ 2 bảng khác nhau
            // (Lấy HoTen của Độc giả, nếu không có thì lấy HoTen của Thủ thư)
            string query = @"
        SELECT
            a.IDAccount,
            a.TypeOfAccount,
            COALESCE(d.HoTen, t.HoTen, a.IDAccount) AS HoTen
        FROM ACCOUNT a
        LEFT JOIN DOCGIA d ON a.IDAccount = d.IDAccount
        LEFT JOIN THUTHU t ON a.IDAccount = t.IDAccount
        ORDER BY a.TypeOfAccount, HoTen";

            return db.ExecuteQuery(query);
        }

        // Hàm reset mật khẩu (lưu mật khẩu đã được HASH)
        public bool ResetPassword(string idAccount, string hashedPassword)
        {
            string query = "UPDATE ACCOUNT SET PasswordAccount = @Password WHERE IDAccount = @IDAccount";

            SqlParameter[] parameters = {
        new SqlParameter("@Password", hashedPassword),
        new SqlParameter("@IDAccount", idAccount)
    };

            return db.ExecuteNonQuery(query, parameters) > 0;
        }
        // Thêm các phương thức này vào class AccountDAL
        public bool CheckPassword(string accountId, string password)
        {
            string query = "SELECT COUNT(*) FROM ACCOUNT WHERE IDAccount = @id AND PasswordAccount = @pw";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@id", accountId),
        new SqlParameter("@pw", password)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        public bool ChangePassword(string accountId, string newPassword)
        {
            string query = "UPDATE ACCOUNT SET PasswordAccount = @newPassword WHERE IDAccount = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@newPassword", newPassword),
        new SqlParameter("@id", accountId)
            };

            return db.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
