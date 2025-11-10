using QLTVNhom3.DAL;
using System;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmThemtheloai : Form
    {
        private TheLoaiDAL theLoaiDAL = new TheLoaiDAL();

        public frmThemtheloai()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTentheloai.Text.Trim();

            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                return;
            }

            try
            {
                int maMoi = theLoaiDAL.ThemTheLoai(tenTheLoai);
                if (maMoi > 0)
                {
                    MessageBox.Show($"Thêm thể loại thành công! Mã thể loại mới: {maMoi}");
                    this.DialogResult = DialogResult.OK; // ✅ Báo cho form cha biết là thêm thành công
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm thể loại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thể loại: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
