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
    public class DocGiaDAL
    {
        private DBHelper db = new DBHelper();
        public DataTable GetDanhSachDocGia()
        {
            string query = @"SELECT dg.MaDocGia, dg.HoTen, dg.NgaySinh,dg.DiaChi, dg.Email,dg.NgayLapThe,dg.NgayHetHan,dg.SoDienThoai, a.IDAccount, ldg.TenLoaiDG" +
                "from DOCGIA dg " +
                "join ACCOUNT a on a.IDAccount = dg.IDAccount" +
                "join LOAIDOCGIA ldg on dg.MaLoaiDG = ldg.MaLoaiDG" +
                "order by dg.MaDocGia DESC";
            return db.ExecuteQuery(query);
        }
        public DataTable TimKiemDocGia(string keyword)
        {
            string query = @"SELECT dg.MaDocGia, dg.HoTen, dg.NgaySinh,dg.DiaChi, dg.Email,dg.NgayLapThe,dg.NgayHetHan,dg.SoDienThoai, a.IDAccount, ldg.TenLoaiDG" +
                "from DOCGIA dg " +
                "join ACCOUNT a on a.IDAccount = dg.IDAccount" +
                "join LOAIDOCGIA ldg on dg.MaLoaiDG = ldg.MaLoaiDG" +
                "where dg.HoTen LIKE @keyword OR dg.MaDocGia LIKE @keyword" +
                "order by dg.MaDocGia DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@keyword", "%" + keyword + "%")
            };
            return db.ExecuteQuery(query, parameters);
        }
        public DataTable GetLoaiDocGia()
        {
            string query = "SELECT MaLoaiDG, TenLoaiDG FROM LOAIDOCGIA";
            return db.ExecuteQuery(query);
        }
        public bool Insert(DocGiaDTO dg)
        {
            string query = @"INSERT INTO DOCGIA (HoTen, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, SoDienThoai, IDAccount, MaLoaiDG)
                             VALUES (@HoTen, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan, @SoDienThoai, @IDAccount, @MaLoaiDG)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HoTen", dg.HoTen),
                new SqlParameter("@NgaySinh", dg.NgaySinh),
                new SqlParameter("@DiaChi", dg.DiaChi),
                new SqlParameter("@Email", dg.Email),
                new SqlParameter("@NgayLapThe", dg.NgayLapThe),
                new SqlParameter("@NgayHetHan", dg.NgayHetHan),
                new SqlParameter("@SoDienThoai", dg.SoDienThoai),
                new SqlParameter("@IDAccount", dg.IDAccount),
                new SqlParameter("@MaLoaiDG", dg.MaLoaiDG)
            };
            int result = db.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
