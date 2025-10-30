using Microsoft.Data.SqlClient; 
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DAL
{
    public class SachDAL
    {
        private DBHelper db = new DBHelper();

        public bool ThemDauSach(SachDTO dauSach)
        {
            using (SqlConnection conn = db.Getconnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Thêm đầu sách
                    string sqlThemDauSach = @"INSERT INTO DAUSACH 
                                            (MaDauSach, TenDauSach, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuongTong, MaViTri) 
                                            VALUES (@MaDauSach, @TenDauSach, @MaTheLoai, @NamXuatBan, @NhaXuatBan, @SoLuongTong, @MaViTri)";

                    using (SqlCommand cmd = new SqlCommand(sqlThemDauSach, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaDauSach", dauSach.MaDauSach);
                        cmd.Parameters.AddWithValue("@TenDauSach", dauSach.TenDauSach);
                        cmd.Parameters.AddWithValue("@MaTheLoai", dauSach.MaTheLoai);
                        cmd.Parameters.AddWithValue("@NamXuatBan", dauSach.NamXuatBan);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", dauSach.NhaXuatBan ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoLuongTong", dauSach.SoLuongTong);
                        cmd.Parameters.AddWithValue("@MaViTri", dauSach.MaViTri);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Thêm tác giả và quan hệ
                    foreach (var tacGia in dauSach.DanhSachTacGia)
                    {
                        if (!KiemTraTacGiaTonTai(tacGia.MaTacGia, conn, transaction))
                        {
                            ThemTacGia(tacGia, conn, transaction);
                        }
                        ThemTacGiaDauSach(dauSach.MaDauSach, tacGia, conn, transaction);
                    }

                    // 3. Tạo các bản sách vật lý
                    foreach (var banSach in dauSach.DanhSachBanSach)
                    {
                        ThemBanSach(banSach, conn, transaction);
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Lỗi khi thêm đầu sách: " + ex.Message);
                }
            }
        }

        private bool KiemTraTacGiaTonTai(string maTacGia, SqlConnection conn, SqlTransaction transaction)
        {
            string sql = "SELECT COUNT(*) FROM TACGIA WHERE MaTacGia = @MaTacGia";
            using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@MaTacGia", maTacGia);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void ThemTacGia(TacGiaDTO tacGia, SqlConnection conn, SqlTransaction transaction)
        {
            string sql = "INSERT INTO TACGIA (MaTacGia, HoTen) VALUES (@MaTacGia, @HoTen)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@MaTacGia", tacGia.MaTacGia);
                cmd.Parameters.AddWithValue("@HoTen", tacGia.HoTen);
                cmd.ExecuteNonQuery();
            }
        }

        private void ThemTacGiaDauSach(string maDauSach, TacGiaDTO tacGia, SqlConnection conn, SqlTransaction transaction)
        {
            string sql = @"INSERT INTO TACGIA_DAUSACH (MaDauSach, MaTacGia, NamSinh) 
                          VALUES (@MaDauSach, @MaTacGia, @N)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);
                cmd.Parameters.AddWithValue("@MaTacGia", tacGia.MaTacGia);
                cmd.Parameters.AddWithValue("@NamSinh", tacGia.NamSinh);
                cmd.ExecuteNonQuery();
            }
        }

        private void ThemBanSach(BanSachDTO banSach, SqlConnection conn, SqlTransaction transaction)
        {
            string sql = @"INSERT INTO SACH (MaSach, MaDauSach, MaTinhTrang) 
                          VALUES (@MaSach, @MaDauSach, @MaTinhTrang)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@MaSach", banSach.MaSach);
                cmd.Parameters.AddWithValue("@MaDauSach", banSach.MaDauSach);
                cmd.Parameters.AddWithValue("@MaTinhTrang", banSach.MaTinhTrang);
                cmd.ExecuteNonQuery();
            }
        }

        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            var list = new List<TheLoaiDTO>();
            string sql = "SELECT MaTheLoai, TenTheLoai FROM THELOAI";

            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TheLoaiDTO
                {
                    MaTheLoai = Convert.ToInt32(row["MaTheLoai"]),
                    TenTheLoai = row["TenTheLoai"].ToString()
                });
            }
            return list;
        }

        public List<ViTriDTO> LayDanhSachViTri()
        {
            var list = new List<ViTriDTO>();
            string sql = "SELECT MaViTri, TenViTri FROM VITRI";

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

        public List<TinhTrangDTO> LayDanhSachTinhTrang()
        {
            var list = new List<TinhTrangDTO>();
            string sql = "SELECT MaTinhTrang, TenTinhTrang FROM TINHTRANG";

            DataTable dt = db.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TinhTrangDTO
                {
                    MaTinhTrang = Convert.ToInt32(row["MaTinhTrang"]),
                    TenTinhTrang = row["TenTinhTrang"].ToString()
                });
            }
            return list;
        }

        public string SinhMaDauSach()
        {
            string sql = "SELECT COUNT(*) FROM DAUSACH";
            object result = db.ExecuteScalar(sql);
            int count = Convert.ToInt32(result) + 1;
            return "DS" + count.ToString().PadLeft(4, '0');
        }

        public string SinhMaSach(string maDauSach, int stt)
        {
            return $"{maDauSach}_{stt.ToString().PadLeft(3, '0')}";
        }
    }
}
