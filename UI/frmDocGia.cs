using QLTVNhom3.DAL;
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
    public partial class frmDocGia : Form
    {
        public string IDAccount;
        private bool isLoggingOut = false;
        public frmDocGia(string iDAccount)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.IDAccount = iDAccount;
            this.FormClosing += new FormClosingEventHandler(frmDocGia_FormClosing);
        }
        // <<< THÊM HÀM MỚI NÀY VÀO CLASS frmDocGia >>>
        private void frmDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem có phải đang đăng xuất không
            if (isLoggingOut == true)
            {
                // Nếu ĐÚNG (do nhấn btnDangxuat), 
                // thì không làm gì cả, cứ để form đóng bình thường.
                // frmDangnhap sẽ hiện ra.
                return;
            }
            // thì hỏi người dùng có muốn THOÁT HẲN không
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Thoát toàn bộ ứng dụng (tắt cả frmDangnhap đang ẩn)
                Application.Exit();
            }
            else
            {
                // Hủy việc đóng form
                e.Cancel = true;
            }
        }
        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Thongtincanhan ttcndg = new Thongtincanhan(this.IDAccount);
            ttcndg.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ttcndg);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiemsach_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucSachthuthu tks = new ucSachthuthu(true);
            tks.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(tks);
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            lblMSV.Text = IDAccount;
            AccountDAL dal = new AccountDAL();
            string tenDG = dal.GetTenDocGia(IDAccount);
            if (!string.IsNullOrEmpty(tenDG))
            {
                lblTen.Text = tenDG;
            }
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



