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
        }
        // <<< THÊM HÀM MỚI NÀY VÀO CLASS frmDocGia >>>
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
                // 1. Đặt cờ là đang đăng xuất
                isLoggingOut = true;

                // 2. Tạo form đăng nhập mới và hiển thị
                frmDangnhap frmLogin = new frmDangnhap();
                frmLogin.Show();

                // 3. Đóng form Main hiện tại
                this.Close();
            }
        }
    }
}



