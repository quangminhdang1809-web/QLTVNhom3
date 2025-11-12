using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
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
    public partial class frmDangnhap : Form
    {

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else return;
        }

        private void chkHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienmatkhau.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '•';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string id = txtIDAccount.Text;
            string pw = txtMatkhau.Text;

            AccountDAL dal = new AccountDAL();

            // 1. Kiểm tra đăng nhập (giữ nguyên logic của bạn)
            var acc = dal.CheckLogin(id, pw);

            if (acc != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- SỬA LOGIC PHÂN LUỒNG ---

                // 2. Nếu là THUTHU hoặc ADMIN, mở form chính
                if (acc.TypeOfAccount == "THUTHU" || acc.TypeOfAccount == "ADMIN")
                {
                    // Nếu là thủ thư, lưu lại MaThuThu (giống code cũ)
                    if (acc.TypeOfAccount == "THUTHU")
                    {
                        int maThuThu = dal.LayMaThuThuTuAccount(acc.IDAccount);
                        UserSession.MaThuThu = maThuThu; // Gán vào Session
                    }

                    // 3. Khởi động form chính và TRUYỀN CẢ TÀI KHOẢN (acc) sang
                    var frmmainthuthu = new frmmainthuthu(acc); // Sửa ở đây
                    this.Hide();
                    frmmainthuthu.ShowDialog();
                    this.Close();
                }
                // 4. Nếu là Độc giả, vào form Độc giả
                else if (acc.TypeOfAccount == "DOCGIA")
                {
                    var frmDocGia = new frmDocGia(acc.IDAccount);
                    this.Hide();
                    frmDocGia.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Loại tài khoản không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // --- KẾT THÚC SỬA ---
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
