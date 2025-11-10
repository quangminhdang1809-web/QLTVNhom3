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
        private bool isEditMode = false; 

        public Thongtincanhan(string idAccount)
        {
            InitializeComponent();
            docGiaDAL = new DocGiaDAL();
            currentAccountId = idAccount;
            this.btnChangePassword.Resize += BtnChangePassword_Resize;
            this.btnChangePassword.MouseEnter += BtnChangePassword_MouseEnter;
            this.btnChangePassword.MouseLeave += BtnChangePassword_MouseLeave;
            LoadThongTinDocGia(); 
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
            using (var frmDoiMatKhau = new frmDoiMatKhau(currentAccountId))
            {
                if (frmDoiMatKhau.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    txtTenTaiKhoan.Text = thongTinDocGia.IDAccount;
                    txtMatKhau.Text = "••••••••"; // Hiển thị dấu * thay vì mật khẩu thật
                    txtLoaiTaiKhoan.Text = thongTinDocGia.TypeOfAccount;

                    // Thông tin độc giả
                    txtMaDocGia.Text = thongTinDocGia.MaDocGia.ToString();
                    txtHoTen.Text = thongTinDocGia.HoTen;
                    txtSoDienThoai.Text = thongTinDocGia.SoDienThoai;
                    txtEmail.Text = thongTinDocGia.Email;
                    txtDiaChi.Text = thongTinDocGia.DiaChi;
                    txtNgayMoThe.Text = thongTinDocGia.NgayLapThe.ToString("dd/MM/yyyy");
                    txtNgayHetHan.Text = thongTinDocGia.NgayHetHan.ToString("dd/MM/yyyy");
                    txtLoaiDocGia.Text = thongTinDocGia.TenLoaiDG;

                    // Kiểm tra trạng thái thẻ
                    KiemTraTrangThaiThe();
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
            if (thongTinDocGia.NgayHetHan < DateTime.Now)
            {
                txtTrangThaiThe.Text = "THẺ ĐÃ HẾT HẠN";
                txtTrangThaiThe.ForeColor = Color.Red;
                txtTrangThaiThe.Font = new Font(lblTrangThaiThe.Font, FontStyle.Bold);
                txtTrangThaiThe.Visible = true;
            }
            else if (thongTinDocGia.NgayHetHan.AddDays(-7) <= DateTime.Now)
            {
                txtTrangThaiThe.Text = "THẺ SẮP HẾT HẠN";
                txtTrangThaiThe.ForeColor = Color.Orange;
                txtTrangThaiThe.Font = new Font(lblTrangThaiThe.Font, FontStyle.Bold);
                txtTrangThaiThe.Visible = true;
            }
            else
            {
                txtTrangThaiThe.Text = "THẺ CÒN HẠN";
                txtTrangThaiThe.ForeColor = Color.Green;
                txtTrangThaiThe.Font = new Font(lblTrangThaiThe.Font, FontStyle.Bold);
                txtTrangThaiThe.Visible = true;
            }
        }

        private void Thongtincanhan_Load(object sender, EventArgs e)
        {
            SetupButtonStyles();
            LoadThongTinDocGia();
            SetEditMode(false);
        }
        private void SetupButtonStyles()
        {
            // Thiết lập style cho các button
            SetupButton(btnChangePassword, Color.DodgerBlue);
            SetupButton(btnSua, Color.ForestGreen);
            SetupButton(btnLuu, Color.Orange);
            SetupButton(btnHuy, Color.Gray);

            // Ẩn nút Lưu và Hủy ban đầu
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void SetupButton(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            BoTronButton(btn, 15);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Cập nhật thông tin từ các textbox
                    thongTinDocGia.HoTen = txtHoTen.Text;
                    thongTinDocGia.SoDienThoai = txtSoDienThoai.Text;
                    thongTinDocGia.Email = txtEmail.Text;
                    thongTinDocGia.DiaChi = txtDiaChi.Text;

                    // Lấy mã loại độc giả từ tên loại
                    thongTinDocGia.MaLoaiDG = docGiaDAL.GetMaLoaiDGFromTenLoai(thongTinDocGia.TenLoaiDG);

                    // Gọi DAL để cập nhật
                    int result = docGiaDAL.CapNhatDocGia(thongTinDocGia);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Quay lại chế độ chỉ đọc
                        SetEditMode(false);

                        // Load lại để đảm bảo hiển thị đúng
                        LoadThongTinDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            LoadThongTinDocGia();
        }
        private void SetEditMode(bool edit)
        {
            isEditMode = edit;

            if (edit)
            {
                // Chế độ chỉnh sửa
                SetReadOnlyMode(false);
                btnSua.Visible = false;
                btnLuu.Visible = true;
                btnHuy.Visible = true;
                btnChangePassword.Enabled = false;
            }
            else
            {
                // Chế độ chỉ đọc
                SetReadOnlyMode(true);
                btnSua.Visible = true;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                btnChangePassword.Enabled = true;
            }
        }
        private void SetReadOnlyMode(bool readOnly)
        {
            // Chỉ cho phép sửa các trường thông tin cá nhân
            txtHoTen.ReadOnly = readOnly;
            txtSoDienThoai.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtDiaChi.ReadOnly = readOnly;

            // Các trường hệ thống luôn chỉ đọc
            txtTenTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            txtLoaiTaiKhoan.ReadOnly = true;
            txtMaDocGia.ReadOnly = true;
            txtNgayMoThe.ReadOnly = true;
            txtNgayHetHan.ReadOnly = true;
            txtLoaiDocGia.ReadOnly = true;

            // Đặt màu nền
            Color editableColor = readOnly ? Color.LightGray : Color.White;
            Color readonlyColor = Color.LightGray;

            txtHoTen.BackColor = editableColor;
            txtSoDienThoai.BackColor = editableColor;
            txtEmail.BackColor = editableColor;
            txtDiaChi.BackColor = editableColor;

            txtTenTaiKhoan.BackColor = readonlyColor;
            txtMatKhau.BackColor = readonlyColor;
            txtLoaiTaiKhoan.BackColor = readonlyColor;
            txtMaDocGia.BackColor = readonlyColor;
            txtNgayMoThe.BackColor = readonlyColor;
            txtNgayHetHan.BackColor = readonlyColor;
            txtLoaiDocGia.BackColor = readonlyColor;
        }

        // THÊM PHƯƠNG THỨC NÀY
        private bool ValidateInput()
        {
            // Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // Kiểm tra Số điện thoại
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra định dạng email cơ bản
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra Địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }
    }
}