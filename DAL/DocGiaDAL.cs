using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVNhom3.DTO;
using System.Linq.Expressions;

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
            List<DocGiaDTO> danhSach = new List<DocGiaDTO>();

            try
            {
                string query = SELECT_QUERY;
                DataTable dt = db.ExecuteQuery(query);

                // DEBUG: In ra số lượng record
                Console.WriteLine($"DAL: Đã lấy {dt.Rows.Count} độc giả từ database");

                // DEBUG: In ra các MaDocGia
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine("Các MaDocGia trong database:");
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"- {row["MaDocGia"]}: {row["HoTen"]}");
                    }
                }

                return ConvertToDTOList(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách độc giả: " + ex.Message);
                return new List<DocGiaDTO>();
            }
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
        public int ThemDocGia(string hoTen, DateTime ngaySinh, string diaChi, string email, string SoDienThoai, string idAccount, int maLoaiDG, DateTime ngayLapThe, DateTime ngayHetHan)
        {
            try
            {
                // LUÔN TẠO IDAccount TỰ ĐỘNG THEO PATTERN docgia5,6,7...
                string finalIdAccount = TaoTaiKhoanTuDong();
                if (finalIdAccount == null)
                {
                    MessageBox.Show("Không thể tạo tài khoản tự động!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                string query = @"insert into DOCGIA (HoTen, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan,IDAccount, SoDienThoai, MaLoaiDG)
                             values (@HoTen, @NgaySinh,@DiaChi,@Email, @NgayLapThe, @NgayHetHan, @IDAccount, @SoDienThoai,@MaLoaiDG)";
                SqlParameter[] parameters = {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@Email", email),
                new SqlParameter("@SoDienThoai", SoDienThoai),
                new SqlParameter("@IDAccount", finalIdAccount),
                new SqlParameter("@MaLoaiDG", maLoaiDG),
                new SqlParameter("@NgayLapThe", ngayLapThe),
                new SqlParameter("@NgayHetHan", ngayHetHan)
            };
                int result = db.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show($"Thêm độc giả thành công!\nTài khoản: {finalIdAccount}\nMật khẩu: 123456",
                          "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DEBUG
                    Console.WriteLine($"Đã thêm độc giả thành công:{hoTen}, ID: {finalIdAccount}");
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return result;
            }
            catch (SqlException sqlEx)
            {
                // XỬ LÝ LỖI SQL CỤ THỂ
                string errorMessage = $"Lỗi SQL khi thêm độc giả:\n";

                if (sqlEx.Number == 547) // Foreign key violation
                {
                    errorMessage += "Lỗi khóa ngoại:\n";
                    if (sqlEx.Message.Contains("IDAccount"))
                        errorMessage += "- IDAccount không tồn tại trong bảng ACCOUNT\n";
                    if (sqlEx.Message.Contains("MaLoaiDG"))
                        errorMessage += "- MaLoaiDG không tồn tại trong bảng LOAIDOCGIA\n";
                }
                else if (sqlEx.Number == 2627 || sqlEx.Number == 2601) // Unique constraint violation
                {
                    errorMessage += "Dữ liệu bị trùng:\n";
                    if (sqlEx.Message.Contains("Email"))
                        errorMessage += "- Email đã tồn tại\n";
                    if (sqlEx.Message.Contains("IDAccount"))
                        errorMessage += "- IDAccount đã được sử dụng\n";
                }
                else
                {
                    errorMessage += sqlEx.Message;
                }

                MessageBox.Show(errorMessage, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm độc giả: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                      "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public bool KiemTraTonTaiIDAccount(string idAccount)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM ACCOUNT WHERE IDAccount = @IDAccount";
                SqlParameter[] parameters = { new SqlParameter("@IDAccount", idAccount) };
                int count = Convert.ToInt32(db.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch
            {
                return false;
            }
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
                MaLoaiDG = Convert.ToInt32(row["MaLoaiDG"]),
                SoDienThoai = row["SoDienThoai"].ToString()
            };
        }
        public string TaoTaiKhoanTuDong()
        {
            try
            {
                // Lấy số lớn nhất hiện có - SỬA QUERY ĐỂ CHẮC CHẮN
                string query = @"SELECT ISNULL(MAX(CAST(SUBSTRING(IDAccount, 7, LEN(IDAccount)) AS INT)), 0) 
                        FROM ACCOUNT 
                        WHERE IDAccount LIKE 'docgia[0-9]%'";
                object result = db.ExecuteScalar(query);

                int nextNumber = 1;
                if (result != null && result != DBNull.Value)
                {
                    nextNumber = Convert.ToInt32(result) + 1;
                }

                string idAccount = $"docgia{nextNumber}";
                string password = "123456";

                // Thêm vào bảng ACCOUNT
                string insertQuery = @"INSERT INTO ACCOUNT (IDAccount, PasswordAccount, TypeOfAccount) 
                          VALUES (@IDAccount, @Password, 'DOCGIA')";

                SqlParameter[] parameters = {
            new SqlParameter("@IDAccount", idAccount),
            new SqlParameter("@Password", password)
        };

                int insertResult = db.ExecuteNonQuery(insertQuery, parameters);

                if (insertResult > 0)
                {
                    Console.WriteLine($"Đã tạo tài khoản: {idAccount}");
                    return idAccount;
                }
                else
                {
                    MessageBox.Show("Không thể tạo tài khoản trong ACCOUNT!", "Lỗi");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo tài khoản tự động: {ex.Message}", "Lỗi");
                return null;
            }
        }
        public DocGiaDTO GetDocGiaMoiNhat()
        {
            try
            {
                string query = @"SELECT TOP 1 dg.MaDocGia, dg.HoTen, ld.TenLoaiDG, dg.NgaySinh, dg.SoDienThoai, 
                        dg.NgayLapThe, dg.NgayHetHan, dg.Email, dg.DiaChi, a.IDAccount, dg.MaLoaiDG
                        FROM DOCGIA dg 
                        JOIN LOAIDOCGIA ld ON dg.MaLoaiDG = ld.MaLoaiDG
                        JOIN ACCOUNT a ON dg.IDAccount = a.IDAccount
                        ORDER BY dg.MaDocGia DESC";

                DataTable dt = db.ExecuteQuery(query);
                return dt.Rows.Count > 0 ? ConvertToDTO(dt.Rows[0]) : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy độc giả mới nhất: " + ex.Message);
                return null;
            }
        }
        public DataTable LayLichSuMuonTra(int maDocGia)
        {
            string query = @"
                SELECT Distinct
                    pm.MaPhieuMS,
                    ct.MaSach,
                    ds.TenDauSach,
                    pm.NgayMuon,
                    pt.NgayTra
                FROM PHIEUMUON pm
                JOIN CTPHIEUMUON ct ON pm.MaPhieuMS = ct.MaPhieuMS
                JOIN SACH s ON ct.MaSach = s.MaSach
                JOIN DAUSACH ds ON s.MaDauSach = ds.MaDauSach
                JOIN PHIEUTRASACH pt on pm.MaPhieuMS = pt.MaPhieuMS
                WHERE pm.MaDocGia = @MaDocGia
                ORDER BY pm.NgayMuon DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@MaDocGia", maDocGia)
            };

            return db.ExecuteQuery(query, parameters);
        }
        public bool KiemTraPhieuMuonTonTai(int maDocGia)
        {
            string query = "SELECT COUNT(*) FROM PHIEUMUON WHERE MaDocGia = @MaDocGia";

            SqlParameter[] parameters = {
        new SqlParameter("@MaDocGia", maDocGia)
    };

            // Thực thi và lấy kết quả
            object result = db.ExecuteScalar(query, parameters);

            // Chuyển kết quả sang số nguyên
            int count = Convert.ToInt32(result);

            // Nếu count > 0, nghĩa là đã có phiếu mượn
            return (count > 0);
        }
        public DocGiaDTO GetThongTinDocGia(string idAccount)
        {
            try
            {
                string query = @"SELECT a.IDAccount, a.PasswordAccount,a.TypeOfAccount,dg.MaDocGia,dg.HoTen,dg.SoDienThoai,dg.Email,dg.DiaChi,dg.NgayLapThe,dg.NgayHetHan,ld.TenLoaiDG from ACCOUNT a
        join DOCGIA dg ON a.IDAccount = dg.IDAccount 
        join LOAIDOCGIA ld ON dg.MaLoaiDG = ld.MaLoaiDG 
        where a.IDAccount = @IDAccount";

                SqlParameter[] parameters = {
            new SqlParameter("@IDAccount", idAccount)
        };
                DataTable dt = db.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DocGiaDTO()
                    {
                        IDAccount = row["IDAccount"].ToString(),
                        PasswordAccount = row["PasswordAccount"].ToString(),
                        TypeOfAccount = row["TypeOfAccount"].ToString(),
                        MaDocGia = Convert.ToInt32(row["MaDocGia"]),
                        HoTen = row["HoTen"].ToString(),
                        SoDienThoai = row["SoDienThoai"].ToString(),
                        Email = row["Email"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        NgayLapThe = Convert.ToDateTime(row["NgayLapThe"]),
                        NgayHetHan = Convert.ToDateTime(row["NgayHetHan"]),
                        TenLoaiDG = row["TenLoaiDG"].ToString()
                    };
                }
                return null;
            }

            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin độc giả: {ex.Message}");
            }
        }
    }
}


