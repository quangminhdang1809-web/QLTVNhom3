using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using QLTVNhom3.DTO;

namespace QLTVNhom3.DAL
{
    public class DocGiaDAL
    {
        private DBHelper db = new DBHelper();
        private const string SELECT_QUERY = @"select dg.MaDocGia, dg.HoTen, ld.TenLoaiDG, dg.NgaySinh,dg.SoDienThoai, dg.NgayLapThe, dg.NgayHetHan, dg.Email,dg.DiaChi, a.IDAccount, dg.MaLoaiDG
                        from DOCGIA dg join LOAIDOCGIA ld on dg.MaLoaiDG = ld.MaLoaiDG
                         join ACCOUNT a on dg.IDAccount = a.IDAccount";
        public List<DocGiaDTO> GetDanhSachDocGia()
        {
            string query = SELECT_QUERY;
            DataTable dt = db.ExecuteQuery(query);
            return ConvertToDTOList(dt);
        }
        public List<DocGiaDTO> TimKiemDocGia(string keyword)
        {
            string query = SELECT_QUERY + @" where dg.MaDocGia like N'%' + @keyword + N'%' or dg.HoTen like N'%' + @keyword + N'%' order by dg.MaDocGia DESC";
            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return ConvertToDTOList(dt);
        }
        public DataTable GetLoaiDocGia()
        {
            string query = @"select MaLoaiDG, TenLoaiDG, ThoiHanThe from LOAIDOCGIA";
            return db.ExecuteQuery(query);
        }
        public DataTable GetAllAccounts()
        {
             string query = @"select IDAccount from ACCOUNT";
            return db.ExecuteQuery(query);
        }
        public int ThemDocGia(string hoTen, DateTime ngaySinh, string diaChi, string email, string SoDienThoai, string idAccount, string maLoaiDG, DateTime ngayLapThe, DateTime ngayHetHan)
        {
            string query = @"insert into DOCGIA (HoTen, NgaySinh, DiaChi, Email,SoDienThoai, NgayLapThe, NgayHetHan,IDAccount, MaLoaiDG)
                             values (@HoTen, @NgaySinh,@DiaChi,@Email, @SoDienThoai,@NgayLapThe, @NgayHetHan, @IDAccount, @MaLoaiDG)";
            SqlParameter[] parameters = {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@Email", email),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SoDienThoai", SoDienThoai),
                new SqlParameter("@NgayLapThe", ngayLapThe),
                new SqlParameter("@NgayHetHan", ngayHetHan),
                new SqlParameter("@IDAccount", idAccount),
                new SqlParameter("@MaLoaiDG", maLoaiDG)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public int CapNhatDocGia(DocGiaDTO docGia)
        {
            string query = @"update DOCGIA 
                             set HoTen = @HoTen, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Email = @Email, SoDienThoai = @SoDienThoai, MaLoaiDG = @MaLoaiDG, IDAccount = @IDAccount
                             where MaDocGia = @MaDocGia";
            SqlParameter[] parameters = {
                new SqlParameter("@MaDocGia", docGia.MaDocGia),
                new SqlParameter("@HoTen", docGia.HoTen),
                new SqlParameter("@NgaySinh", docGia.NgaySinh),
                new SqlParameter("@DiaChi", docGia.DiaChi),
                new SqlParameter("@Email", docGia.Email),
                new SqlParameter("@IDAccount", docGia.IDAccount),
                new SqlParameter("@SoDienThoai", docGia.SoDienThoai),
                new SqlParameter("@MaLoaiDG", docGia.MaLoaiDG)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public int XoaDocGia(int maDocGia)
        {
            string query = @"delete from DOCGIA where MaDocGia = @MaDocGia";
            SqlParameter[] parameters = {
                new SqlParameter("@MaDocGia", maDocGia)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public DocGiaDTO GetDocGiaByMa(int maDocGia)
        {
            string query = SELECT_QUERY + " where dg.MaDocGia = @MaDocGia";
            SqlParameter[] parameters = {
                new SqlParameter("@MaDocGia", maDocGia)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? ConvertToDTO(dt.Rows[0]) : null;
        }
        private List<DocGiaDTO> ConvertToDTOList(DataTable dt)
        {
            List<DocGiaDTO> docGiaList = new List<DocGiaDTO>();
            foreach (DataRow row in dt.Rows)
            {
                docGiaList.Add(ConvertToDTO(row));
            }
            return docGiaList;
        }
        private DocGiaDTO ConvertToDTO(DataRow row)
        {
            return new DocGiaDTO
            {
                MaDocGia = Convert.ToInt32(row["MaDocGia"]),
                HoTen = row["HoTen"].ToString(),
                TenLoaiDG = row["TenLoaiDG"].ToString(),
                NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                NgayLapThe = Convert.ToDateTime(row["NgayLapThe"]),
                NgayHetHan = Convert.ToDateTime(row["NgayHetHan"]),
                Email = row["Email"].ToString(),
                DiaChi = row["DiaChi"].ToString(),
                IDAccount = row["IDAccount"].ToString(),
                MaLoaiDG = row["MaLoaiDG"].ToString(),
                SoDienThoai = row["SoDienThoai"].ToString()
            };
        }
    }
}
