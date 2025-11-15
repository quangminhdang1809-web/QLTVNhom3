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
    public partial class frmDoiMatKhau : Form
    {
        public string OldPassword => txtOldPassword.Text;
        public string NewPassword => txtNewPassword.Text;
        public string ConfirmPassword => txtConfirmPassword.Text;

        private string accountId;

        // Constructor mới nhận accountId
        public frmDoiMatKhau(string accountId = null)
        {
            InitializeComponent();
            this.accountId = accountId;
        }

        // Các phương thức khác giữ nguyên...
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            // Tự động focus vào ô mật khẩu hiện tại
            txtOldPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập (giữ nguyên)
            if (string.IsNullOrWhiteSpace(OldPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(NewPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (NewPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Cảnh báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (NewPassword != ConfirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            if (NewPassword == OldPassword)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Cảnh báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Xác nhận đổi mật khẩu
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn đổi mật khẩu?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Các sự kiện khác giữ nguyên...
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '•';
                txtNewPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPassword.Focus();
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}


