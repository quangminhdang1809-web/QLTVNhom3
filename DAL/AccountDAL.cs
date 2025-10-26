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
    }
}
