using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmThemtacgia : Form
    {
        private TacGiaDAL tacGiaDAL = new TacGiaDAL();

        public frmThemtacgia()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtHovaten.Text.Trim();
                string quocTich = txtQuoctich.Text.Trim();
                int namSinh = dtpNamsinhtacgia.Value.Year;

                int maMoi = tacGiaDAL.ThemTacGia(hoTen, namSinh, quocTich);

                if (maMoi > 0)
                {
                    MessageBox.Show($"Đã thêm tác giả thành công!\nMã tác giả mới: {maMoi}");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm tác giả. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tác giả: " + ex.Message);
            }
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
