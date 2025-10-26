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
            var acc = dal.CheckLogin(id, pw);

            if (acc != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (acc.TypeOfAccount == "THUTHU")
                {
                    var frmmainthuthu = new frmmainthuthu(acc.IDAccount); 
                    this.Hide();
                    frmmainthuthu.ShowDialog();
                    this.Close(); 
                }
                else
                {
                    var frmDocGia = new frmDocGia (acc.IDAccount);
                    this.Hide();
                    frmDocGia.ShowDialog();
                    this.Close();
                }   

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
