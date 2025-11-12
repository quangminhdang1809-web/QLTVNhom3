using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLTVNhom3.DAL
{
    public class DauSachDAL
    {
        private DBHelper db = new DBHelper();
        //Lấy danh sách đầu sách để hiển thị
        public DataTable LayDanhSachDauSach()
        {
            string query = @"
                SELECT 
                    ds.MaDauSach,
                    ds.TenDauSach,
                    tl.TenTheLoai, 
                    ds.SoLuongTong
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
                ORDER BY ds.MaDauSach";
            return db.ExecuteQuery(query); 
        }
        // 2. Lấy chi tiết 1 đầu sách khi bấm vào
        public DauSachDTO LayChiTietSach(string maDauSach)
        {
            var sach = new DauSachDTO();

            string query = @"
                SELECT 
                    ds.MaDauSach,
                    ds.TenDauSach,
                    ds.AnhBia,
                    ds.MaTheLoai,
                    ds.NamXuatBan,
                    ds.NhaXuatBan,
                    ds.SoLuongTong,
                    ds.MaViTri,
                    tl.TenTheLoai,
                    vt.TenViTri
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
                WHERE ds.MaDauSach = @MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDauSach", maDauSach)
            };

            var dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                sach.MaDauSach = row["MaDauSach"].ToString();
                sach.TenDauSach = row["TenDauSach"].ToString();
                sach.AnhBia = row["AnhBia"] as byte[];
                sach.MaTheLoai = Convert.ToInt32(row["MaTheLoai"]);
                sach.NamXuatBan = Convert.ToInt16(row["NamXuatBan"]);
                sach.NhaXuatBan = row["NhaXuatBan"].ToString();
                sach.SoLuongTong = Convert.ToInt32(row["SoLuongTong"]);
                sach.MaViTri = row["MaViTri"].ToString();
                sach.TenTheLoai = row["TenTheLoai"].ToString();
                sach.TenViTri = row["TenViTri"].ToString();

                // Lấy danh sách tác giả
                sach.DanhSachTacGia = LayTacGiaTheoSach(maDauSach);
            }

            return sach;
        }
        // 3. Lấy danh sách tác giả của sách
        public List<TacGiaDTO> LayTacGiaTheoSach(string maDauSach)
        {
            var danhSach = new List<TacGiaDTO>();

            string query = @"
                SELECT 
                    tg.MaTacGia,
                    tg.TenTacGia,
                    tg.NamSinh,
                    tg.QuocTich
                FROM TACGIA tg
                INNER JOIN DAUSACH_TACGIA dtg ON tg.MaTacGia = dtg.MaTacGia
                WHERE dtg.MaDauSach = @MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDauSach", maDauSach)
            };

            var dt = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new TacGiaDTO
                {
                    MaTacGia = Convert.ToInt32(row["MaTacGia"]),
                    TenTacGia = row["TenTacGia"]?.ToString(),
                    NamSinh = row["NamSinh"] != DBNull.Value ? Convert.ToInt32(row["NamSinh"]) : (int?)null,
                    QuocTich = row["QuocTich"]?.ToString()
                });
            }

            return danhSach;
        }
        // 4. Tìm kiếm sách
        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = @"
                SELECT 
                    ds.MaDauSach,
                    ds.TenDauSach,
                    ds.AnhBia,
                    ds.NamXuatBan,
                    ds.NhaXuatBan,
                    ds.SoLuongTong,
                    ds.MaViTri,
                    tl.TenTheLoai,
                    vt.TenViTri
                FROM DAUSACH ds
                LEFT JOIN THELOAI tl ON ds.MaTheLoai = tl.MaTheLoai
                LEFT JOIN VITRI vt ON ds.MaViTri = vt.MaViTri
                WHERE ds.TenDauSach LIKE @TuKhoa 
                   OR ds.MaDauSach LIKE @TuKhoa
                   OR tl.TenTheLoai LIKE @TuKhoa
                ORDER BY ds.MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TuKhoa", $"%{tuKhoa}%")
            };

            return db.ExecuteQuery(query, parameters);
        }
        // 5. Cập nhật sách
        public bool CapNhatSach(DauSachDTO sach)
        {
            string query = @"
                UPDATE DAUSACH 
                SET TenDauSach = @TenDauSach,
                    AnhBia = @AnhBia,
                    MaTheLoai = @MaTheLoai,
                    NamXuatBan = @NamXuatBan,
                    NhaXuatBan = @NhaXuatBan,
                    SoLuongTong = @SoLuongTong,
                    MaViTri = @MaViTri
                WHERE MaDauSach = @MaDauSach";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDauSach", sach.TenDauSach),
                new SqlParameter("@AnhBia", sach.AnhBia ?? (object)DBNull.Value),
                new SqlParameter("@MaTheLoai", sach.MaTheLoai),
                new SqlParameter("@NamXuatBan", sach.NamXuatBan),
                new SqlParameter("@NhaXuatBan", sach.NhaXuatBan ?? (object)DBNull.Value),
                new SqlParameter("@SoLuongTong", sach.SoLuongTong),
                new SqlParameter("@MaViTri", sach.MaViTri),
                new SqlParameter("@MaDauSach", sach.MaDauSach)
            };

            int result = db.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // 6. Xóa sách
        public bool XoaSach(string maDauSach)
        {
            try
            {
                // Xóa quan hệ tác giả - đầu sách
                string sqlXoaTacGia = "DELETE FROM DAUSACH_TACGIA WHERE MaDauSach = @MaDauSach";
                SqlParameter[] paramTacGia = new SqlParameter[]
                {
            new SqlParameter("@MaDauSach", maDauSach)
                };
                db.ExecuteNonQuery(sqlXoaTacGia, paramTacGia);

                // Xóa các bản sách cụ thể
                string sqlXoaSach = "DELETE FROM SACH WHERE MaDauSach = @MaDauSach";
                SqlParameter[] paramSach = new SqlParameter[]
                {
            new SqlParameter("@MaDauSach", maDauSach)
                };
                db.ExecuteNonQuery(sqlXoaSach, paramSach);

                // Xóa đầu sách
                string sqlXoaDauSach = "DELETE FROM DAUSACH WHERE MaDauSach = @MaDauSach";
                SqlParameter[] paramDauSach = new SqlParameter[]
                {
            new SqlParameter("@MaDauSach", maDauSach)
                };
                int result = db.ExecuteNonQuery(sqlXoaDauSach, paramDauSach);

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sách: " + ex.Message);
            }
        }

        // 7. Lấy danh sách thể loại
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            var list = new List<TheLoaiDTO>();
            string sql = "SELECT MaTheLoai, TenTheLoai FROM THELOAI ORDER BY TenTheLoai";

            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TheLoaiDTO
                {
                    MaTheLoai = Convert.ToInt32(row["MaTheLoai"]),
                    TenTheLoai = row["TenTheLoai"]?.ToString()
                });
            }
            return list;
        }

        // 8. Lấy danh sách vị trí
        public List<ViTriDTO> LayDanhSachViTri()
        {
            var list = new List<ViTriDTO>();
            string sql = "SELECT MaViTri, TenViTri FROM VITRI ORDER BY TenViTri";

            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ViTriDTO
                {
                    MaViTri = row["MaViTri"].ToString(),
                    TenViTri = row["TenViTri"].ToString()
                });
            }
            return list;
        }
    }
}
