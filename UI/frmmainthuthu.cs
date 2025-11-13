using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO; // <-- THÊM DÒNG NÀY
using QLTVNhom3.UI;  // <-- THÊM DÒNG NÀY
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmmainthuthu : Form
    {
        // SỬA 1: Dùng AccountDTO để lưu trữ, không dùng string
        private AccountDTO currentUser;
        private bool isLoggingOut = false;

        // SỬA 2: Hàm khởi tạo nhận AccountDTO (thay vì string)
        public frmmainthuthu(AccountDTO account)
        {
            InitializeComponent();
            this.currentUser = account; // Lưu lại thông tin tài khoản
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhmuc.Visible == true)
            {
                pnlDanhmuc.Visible = false;
            }
            else
            {
                pnlDanhmuc.Visible = true;
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ucBaoCao uc = new ucBaoCao();
            AddUserControl(uc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else return;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            pnlMaincontent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMaincontent.Controls.Add(userControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            AddUserControl(uc);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            ucSachthuthu uc = new ucSachthuthu();
            AddUserControl(uc);
        }
        private void btnTheloai_Click(object sender, EventArgs e)
        {
            ucTheloai uc = new ucTheloai();
            AddUserControl(uc);
        }
        private void btnTacgia_Click(object sender, EventArgs e)
        {
            ucTacgia uc = new ucTacgia();
            AddUserControl(uc);
        }

        private void btnDocgia_Click(object sender, EventArgs e)
        {
            ucDocgiathuthu uc = new ucDocgiathuthu();
            AddUserControl(uc);
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            ucMuonsachthuthu uc = new ucMuonsachthuthu();
            AddUserControl(uc);
        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            ucTrasach uc = new ucTrasach();
            AddUserControl(uc);
        }

        private void btnKhosach_Click(object sender, EventArgs e)
        {
            ucVitri uc = new ucVitri();
            AddUserControl(uc);
        }

        // SỬA 3: Toàn bộ hàm Load (Gộp logic cũ và logic phân quyền)
        private void frmmainthuthu_Load(object sender, EventArgs e)
        {
            // 1. Hiển thị ID (Lấy từ biến currentUser)
            lblmatt.Text = currentUser.IDAccount;

            // 2. Tải tên
            try
            {
                AccountDAL dal = new AccountDAL();
                string tenNguoiDung = "";

                if (currentUser.TypeOfAccount == "THUTHU")
                {
                    tenNguoiDung = dal.GetTenThuThu(currentUser.IDAccount);
                }
                else if (currentUser.TypeOfAccount == "ADMIN")
                {
                    tenNguoiDung = "Administrator";
                }

                lblten.Text = string.IsNullOrEmpty(tenNguoiDung) ? "(Không có tên)" : tenNguoiDung;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 3. PHÂN QUYỀN (Ẩn/Hiện nút)
            if (currentUser.TypeOfAccount == "ADMIN")
            {
                btnHethong.Visible = true;
                btnQuanlytaikhoan.Visible = true;
                btnVipham.Visible = true;
                btnMuonsach.Visible = false;
                btnTrasach.Visible = false;
            }
            else if (currentUser.TypeOfAccount == "THUTHU")
            {
                btnHethong.Visible = false;
                btnQuanlytaikhoan.Visible = false;
                btnVipham.Visible = false;
                btnMuonsach.Visible = true;
                btnTrasach.Visible = true;
            }
        }

        private void btnQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            ucQuanLyTaiKhoan uc = new ucQuanLyTaiKhoan();
            AddUserControl(uc);
        }

        // --- CÁC HÀM CỦA BẠN ĐÃ ĐƯỢC GIỮ LẠI ---
        private void btnVipham_Click(object sender, EventArgs e)
        {
            ucVipham ucVipham = new ucVipham();
            AddUserControl(ucVipham);
        }

        private void btnHethong_Click(object sender, EventArgs e)
        {
            if (pnlHethong.Visible == true)
            {
                pnlHethong.Visible = false;
            }
            else
            {
                pnlHethong.Visible = true;
            }
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            ucThuThu ucThuThu = new ucThuThu();
            AddUserControl(ucThuThu);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // 2. Đặt cờ là đang đăng xuất
                isLoggingOut = true;

                // 3. Tìm lại form Login đang bị ẩn
                // (Thay "frmLogin" bằng tên thật của Form Login của bạn)
                Form frmLogin = Application.OpenForms["frmDangnhap"];

                if (frmLogin != null)
                {
                    // 4. Hiển thị lại form Login
                    frmLogin.Show();
                }
                else
                {
                    // Phòng trường hợp form Login bị lỗi/đóng
                    frmLogin = new frmDangnhap();
                    frmLogin.Show();
                }

                // 5. Đóng form Main hiện tại
                this.Close();
            }


        }
    }
}