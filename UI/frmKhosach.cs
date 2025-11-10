using QLTVNhom3.DTO;
using QLTVNhom3.DAL;
using System;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmThemvitri : Form
    {
        private ViTriDAL viTriDAL = new ViTriDAL();

        public frmThemvitri()
        {
            InitializeComponent();
            btnLuu.Click += btnLuu_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy dữ liệu từ textbox
                ViTriDTO viTri = new ViTriDTO
                {
                    MaViTri = txtMavitri.Text.Trim(),
                    TenViTri = txtTenvitri.Text.Trim(),
                    MoTa = txtMota.Text.Trim(),
                };

                // Kiểm tra dữ liệu tầng và kệ
                if (!int.TryParse(txtTang.Text, out int tang))
                {
                    MessageBox.Show("Tầng phải là số nguyên!");
                    txtTang.Focus();
                    return;
                }

                if (!int.TryParse(txtKe.Text, out int ke))
                {
                    MessageBox.Show("Kệ phải là số nguyên!");
                    txtKe.Focus();
                    return;
                }

                viTri.Tang = tang;
                viTri.Ke = ke;

                // 2️⃣ Gọi DAL để thêm
                int ketQua = viTriDAL.ThemViTri(viTri);

                // 3️⃣ Xử lý kết quả
                if (ketQua > 0)
                {
                    MessageBox.Show("✅ Thêm vị trí thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("⚠️ Không thể thêm vị trí (kiểm tra mã trùng hoặc lỗi DB).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm vị trí: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
