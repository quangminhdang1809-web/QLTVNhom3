using QLTVNhom3.DAL;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace QLTVNhom3.BLL
{
    public class AccountBLL
    {
        private AccountDAL accountDAL = new AccountDAL();

        public DataTable GetAccountListView()
        {
            return accountDAL.GetAccountListView();
        }

        public string ResetPassword(string idAccount)
        {
            string newPassword = "12345";
            string hashedPassword = HashPassword(newPassword);

            if (accountDAL.ResetPassword(idAccount, hashedPassword))
            {
                return newPassword;
            }
            else
            {
                throw new Exception("Reset mật khẩu thất bại.");
            }
        }

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
    }
}