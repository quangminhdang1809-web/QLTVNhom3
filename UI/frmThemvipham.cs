using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTVNhom3.UI
{
    public partial class frmThemvipham : Form
    {
        private ViPhamBLL viPhamBLL = new ViPhamBLL();

        // Báo cho form cha (ucVipham) biết là đã thêm thành công
        public bool DaThemThanhCong { get; private set; } = false;

        public frmThemvipham()
        {
            InitializeComponent();

            // Gán sự kiện
      
        }

        private void frmThemvipham_Load(object sender, EventArgs e)
        {
            txtMaloi.Text = "(Tự động)";
            txtMaloi.ReadOnly = true;

            cboLoaiViPham.Items.Add("Quá hạn");
            cboLoaiViPham.Items.Add("Lỗi sách");
            cboLoaiViPham.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ViPhamDTO dto = new ViPhamDTO
                {
                    MaLoi = 0,
                    TenLoi = txtTenloi.Text.Trim(),
                    MucPhat = decimal.Parse(txtMucphat.Text),
                    LoaiViPham = cboLoaiViPham.SelectedItem.ToString(),
                    MoTa = txtMota.Text.Trim()
                };

                if (viPhamBLL.LuuViPham(dto))
                {
                    MessageBox.Show("Thêm quy định vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DaThemThanhCong = true;
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