using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Windows.Forms;

namespace QLTVNhom3.UI
{
    public partial class frmThemThuThu : Form
    {
        private ThuThuBLL thuThuBLL = new ThuThuBLL();

        // Thuộc tính này để báo cho 'ucThuThu' biết
        public bool DaThemThanhCong { get; private set; } = false;

        public frmThemThuThu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ Form
                ThuThuDTO tt = new ThuThuDTO
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    IDAccount = txtIDAccount.Text.Trim(),
                    Password = txtMatKhau.Text // BLL sẽ hash mật khẩu này
                };

                // 2. Gọi BLL (BLL sẽ Validate và gọi DAL Transaction)
                if (thuThuBLL.ThemThuThu(tt))
                {
                    MessageBox.Show("Thêm thủ thư mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DaThemThanhCong = true; // Đặt cờ
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}