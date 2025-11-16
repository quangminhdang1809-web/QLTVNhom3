using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class Thongtincanhan : UserControl
    {
        private DocGiaDAL docGiaDAL;
        private string currentAccountId;
        private DocGiaDTO thongTinDocGia;
        private PhieuMuonDAL phieuMuonDAL;

        public Thongtincanhan(string idAccount)
        {
            InitializeComponent();
            docGiaDAL = new DocGiaDAL();
            phieuMuonDAL = new PhieuMuonDAL();
            currentAccountId = idAccount;
            this.btnChangePassword.Resize += BtnChangePassword_Resize;
            this.btnChangePassword.MouseEnter += BtnChangePassword_MouseEnter;
            this.btnChangePassword.MouseLeave += BtnChangePassword_MouseLeave;
            ConfigureDataGridView();
            LoadThongTinDocGia();
        }
        private void LoadSachDaMuon()
        {
            try
            {
                if (thongTinDocGia != null)
                {
                    DataTable dt = phieuMuonDAL.GetSachDaMuonCuaDocGia(thongTinDocGia.MaDocGia);

                    if (dgvLichsumuon != null)
                    {
                        dgvLichsumuon.DataSource = dt;

                        // Định dạng cột ngày tháng
                        if (dt.Columns.Contains("Ngày mượn"))
                            dgvLichsumuon.Columns["Ngày mượn"].DefaultCellStyle.Format = "dd/MM/yyyy";

                        if (dt.Columns.Contains("Hạn trả"))
                            dgvLichsumuon.Columns["Hạn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";

                        if (dt.Columns.Contains("Ngày trả"))
                            dgvLichsumuon.Columns["Ngày trả"].DefaultCellStyle.Format = "dd/MM/yyyy";

                        // Định dạng cột tiền phạt
                        if (dt.Columns.Contains("Tiền phạt"))
                        {
                            dgvLichsumuon.Columns["Tiền phạt"].DefaultCellStyle.Format = "N0";
                            dgvLichsumuon.Columns["Tiền phạt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                        int tongSoDong = dt.Rows.Count;

                        // Hiển thị tổng số dòng
                        if (txtSosachmuon != null) // Thay 'txtTongSoDong' bằng tên textbox thực tế của bạn
                        {
                            txtSosachmuon.Text = tongSoDong.ToString();
                        }
                        dgvLichsumuon.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sách đã mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BoTronButton(Button btn, int radius)
        {
            if (btn.Width <= 0 || btn.Height <= 0) return; // tránh lỗi khi control chưa vẽ

            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void BtnChangePassword_Resize(object sender, EventArgs e)
        {
            BoTronButton((Button)sender, 15);
        }

        private void BtnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.FromArgb(0, 102, 204); // đậm hơn khi hover
        }

        private void BtnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.DodgerBlue; // trở lại màu gốc
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frmDoiMatKhau = new frmDoiMatKhau(currentAccountId))
                {
                    if (frmDoiMatKhau.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy thông tin từ form
                        string oldPassword = frmDoiMatKhau.OldPassword;
                        string newPassword = frmDoiMatKhau.NewPassword;
                        string confirmPassword = frmDoiMatKhau.ConfirmPassword;

                        // Kiểm tra dữ liệu
                        if (string.IsNullOrWhiteSpace(oldPassword) ||
                            string.IsNullOrWhiteSpace(newPassword) ||
                            string.IsNullOrWhiteSpace(confirmPassword))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (newPassword != confirmPassword)
                        {
                            MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (newPassword.Length < 6)
                        {
                            MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Cảnh báo",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (newPassword == oldPassword)
                        {
                            MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Cảnh báo",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Thực hiện đổi mật khẩu
                        AccountDAL accountDAL = new AccountDAL();

                        // 1. Kiểm tra mật khẩu cũ
                        bool isOldPasswordCorrect = accountDAL.CheckPassword(currentAccountId, oldPassword);

                        if (!isOldPasswordCorrect)
                        {
                            MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // 2. Thực hiện đổi mật khẩu
                        bool changeResult = accountDAL.ChangePassword(currentAccountId, newPassword);

                        if (changeResult)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật hiển thị mật khẩu (vẫn hiển thị dấu *)
                            txtMatkhau.Text = "••••••••";
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng thử lại.", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đổi mật khẩu: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadThongTinDocGia()
        {
            try
            {
                thongTinDocGia = docGiaDAL.GetThongTinDocGia(currentAccountId);

                if (thongTinDocGia != null)
                {
                    // Thông tin tài khoản
                    txtTenTK.Text = thongTinDocGia.IDAccount;
                    txtMatkhau.Text = "••••••••"; // Hiển thị dấu * thay vì mật khẩu thật

                    // Thông tin độc giả
                    txtMaDocGia.Text = thongTinDocGia.MaDocGia.ToString();
                    txtHoTen.Text = thongTinDocGia.HoTen;
                    txtSDT.Text = thongTinDocGia.SoDienThoai;
                    txtEmail.Text = thongTinDocGia.Email;
                    txtNgayMoThe.Text = thongTinDocGia.NgayLapThe.ToString("dd/MM/yyyy");
                    txtNgayHetHan.Text = thongTinDocGia.NgayHetHan.ToString("dd/MM/yyyy");
                    txtLoaiDocGia.Text = thongTinDocGia.TenLoaiDG;

                    // Kiểm tra trạng thái thẻ
                    KiemTraTrangThaiThe();
                    LoadSachDaMuon();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KiemTraTrangThaiThe()
        {
            if (thongTinDocGia == null) return;

            // Đảm bảo control được hiển thị
            txtTrangThaiThe.Visible = true;

            // Đặt font và style trước
            txtTrangThaiThe.Font = new Font(lblTrangThaiThe.Font.FontFamily, lblTrangThaiThe.Font.Size, FontStyle.Bold);

            if (thongTinDocGia.NgayHetHan < DateTime.Now)
            {
                txtTrangThaiThe.Text = "THẺ ĐÃ HẾT HẠN";
                txtTrangThaiThe.ForeColor = Color.Red;
                txtTrangThaiThe.BackColor = Color.LightPink; // Thêm màu nền để dễ nhận biết
            }
            else if (thongTinDocGia.NgayHetHan.AddDays(-7) <= DateTime.Now)
            {
                txtTrangThaiThe.Text = "THẺ SẮP HẾT HẠN";
                txtTrangThaiThe.ForeColor = Color.Orange;
                txtTrangThaiThe.BackColor = Color.LightYellow;
            }
            else
            {
                txtTrangThaiThe.Text = "THẺ CÒN HẠN";
                txtTrangThaiThe.ForeColor = Color.Green;
                txtTrangThaiThe.BackColor = Color.LightGreen;
            }

            // Force refresh control
            txtTrangThaiThe.Refresh();
        }

        private void Thongtincanhan_Load(object sender, EventArgs e)
        {
            LoadThongTinDocGia();
        }

        private void Thongtincanhan_Load_1(object sender, EventArgs e)
        {

        }
        private void ConfigureDataGridView()
        {
            if (dgvLichsumuon == null) return;

            // Bật hiển thị đường kẻ
            dgvLichsumuon.GridColor = Color.LightGray;
            dgvLichsumuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvLichsumuon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLichsumuon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Đảm bảo background color khác với grid color
            dgvLichsumuon.BackgroundColor = Color.White;
            dgvLichsumuon.EnableHeadersVisualStyles = false;

            // Cấu hình màu sắc cho header
            dgvLichsumuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLichsumuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Cấu hình màu cho các dòng
            dgvLichsumuon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvLichsumuon.RowsDefaultCellStyle.BackColor = Color.White;
            dgvLichsumuon.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình selection
            dgvLichsumuon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvLichsumuon.DefaultCellStyle.SelectionForeColor = Color.White;

            // Đảm bảo hiển thị đầy đủ
            dgvLichsumuon.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}


