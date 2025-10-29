using Microsoft.Data.SqlClient;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QLTVNhom3.DAL
{
    public class TacGiaDAL
    {
        private DBHelper db = new DBHelper();
        private const string SELECT_QUERY = @"select MaTacGia,TenTacGia,NamSinh,QuocTich from TACGIA";
        public List<TacGiaDTO> GetDanhSachTacGia()
        {
            string query = SELECT_QUERY;
            DataTable dt = db.ExecuteQuery(query);
            return ConvertToDTOList(dt);
        }
        public List<TacGiaDTO> TimKiemTacGia(string keyword)
        {
            string query = SELECT_QUERY + @" where MaTacGia like N'%' + @keyword + N'%' or TenTacGia like N'%' + @keyword + N'%' order by MaTacGia DESC";
            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return ConvertToDTOList(dt);
        }
        public int ThemTacGia(string tenTacGia, int namSinh, string quocTich)
        {
            try
            {
                string query = @"INSERT INTO TACGIA(TenTacGia, NamSinh, QuocTich)
                         VALUES (@TenTacGia, @NamSinh, @QuocTich);
                         SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlParameter[] parameters = {
            new SqlParameter("@TenTacGia", tenTacGia),
            new SqlParameter("@NamSinh", namSinh),
            new SqlParameter("@QuocTich", quocTich)
        };

                object result = db.ExecuteScalar(query, parameters);
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm tác giả: " + ex.Message);
                return -1;
            }
        }


        public int CapNhatTacGia(TacGiaDTO tacGia)
        {
            string query = @"update TACGIA
                     set TenTacGia = @TenTacGia, NamSinh = @NamSinh, QuocTich = @QuocTich
                     where MaTacGia = @MaTacGia";
            SqlParameter[] parameters = {
        new SqlParameter("@TenTacGia", tacGia.TenTacGia),
        new SqlParameter("@NamSinh", tacGia.NamSinh),
        new SqlParameter("@QuocTich", tacGia.QuocTich),
        new SqlParameter("@MaTacGia", tacGia.MaTacGia)
    };
            return db.ExecuteNonQuery(query, parameters);
        }

        public int XoaTacGia(int maTacGia)
        {
            string query = @"delete from TACGIA where MaTacGia = @MaTacGia";
            SqlParameter[] parameters = {
                new SqlParameter("@MaTacGia", maTacGia)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public TacGiaDTO GetTacGiaByMa(int maTacGia)
        {
            string query = SELECT_QUERY + " where MaTacGia = @MaTacGia";
            SqlParameter[] parameters = {
                new SqlParameter("@MaTacGia", maTacGia)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? ConvertToDTO(dt.Rows[0]) : null;
        }
        private List<TacGiaDTO> ConvertToDTOList(DataTable dt)
        {
            List<TacGiaDTO> tacGiaList = new List<TacGiaDTO>();
            foreach (DataRow row in dt.Rows)
            {
                tacGiaList.Add(ConvertToDTO(row));
            }
            return tacGiaList;
        }
        private TacGiaDTO ConvertToDTO(DataRow row)
        {
            return new TacGiaDTO
            {
                MaTacGia = Convert.ToInt32(row["MaTacGia"]),
                TenTacGia = row["TenTacGia"].ToString(),
                NamSinh = Convert.ToInt32(row["NamSinh"]),
                QuocTich = row["QuocTich"].ToString()
            };
        }
    }
    }
