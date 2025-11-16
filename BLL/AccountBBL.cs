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
            string newPassword = "123456";

            if (accountDAL.ResetPassword(idAccount, newPassword))
            {
                return newPassword;
            }
            else
            {
                throw new Exception("Reset mật khẩu thất bại.");
            }
        }
    }
}