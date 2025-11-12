using QLTVNhom3.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucBaoCao : UserControl
    {
        private BaoCaoBLL baoCaoBLL = new BaoCaoBLL();

        // Dùng Dictionary để lưu tên báo cáo và loại (enum)
        private readonly Dictionary<string, BaoCaoBLL.LoaiBaoCao> dsBaoCao;

        public ucBaoCao()
        {
            InitializeComponent();

            // Khởi tạo danh sách báo cáo
            dsBaoCao = new Dictionary<string, BaoCaoBLL.LoaiBaoCao>
            {
                { "Sách đang mượn", BaoCaoBLL.LoaiBaoCao.SachDangMuon },
                { "Sách quá hạn", BaoCaoBLL.LoaiBaoCao.SachQuaHan },
                { "Báo cáo tiền phạt", BaoCaoBLL.LoaiBaoCao.TienPhat },
                { "Sách được mượn nhiều nhất", BaoCaoBLL.LoaiBaoCao.SachYeuThich }
            };

            // Gán sự kiện
            this.Load += ucBaoCao_Load;
            this.btnThongKe.Click += btnThongKe_Click;
            this.cbxChonMauBaoCao.SelectedIndexChanged += cbxChonMauBaoCao_SelectedIndexChanged;
        }

        private void ucBaoCao_Load(object sender, EventArgs e)
        {
            // Tải ComboBox
            cbxChonMauBaoCao.DataSource = new BindingSource(dsBaoCao, null);
            cbxChonMauBaoCao.DisplayMember = "Key";
            cbxChonMauBaoCao.ValueMember = "Value";

            // Cấu hình DataGridView
            grdThongKe.ReadOnly = true;
            grdThongKe.AllowUserToAddRows = false;
            grdThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm này BẬT/TẮT ô chọn ngày
        private void cbxChonMauBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null) return;

            var loaiBaoCao = (BaoCaoBLL.LoaiBaoCao)cbxChonMauBaoCao.SelectedValue;

            // Nếu là báo cáo Tiền phạt hoặc Sách yêu thích, BẬT ô chọn ngày
            if (loaiBaoCao == BaoCaoBLL.LoaiBaoCao.TienPhat ||
                loaiBaoCao == BaoCaoBLL.LoaiBaoCao.SachYeuThich)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
            else // Ngược lại (Sách đang mượn, Sách quá hạn), TẮT ô chọn ngày
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null) return;

            var loaiBaoCao = (BaoCaoBLL.LoaiBaoCao)cbxChonMauBaoCao.SelectedValue;
            DataTable dtKetQua = new DataTable();

            try
            {
                // Dùng switch-case để gọi hàm BLL tương ứng
                switch (loaiBaoCao)
                {
                    case BaoCaoBLL.LoaiBaoCao.SachDangMuon:
                        dtKetQua = baoCaoBLL.GetSachDangMuon();
                        break;

                    case BaoCaoBLL.LoaiBaoCao.SachQuaHan:
                        dtKetQua = baoCaoBLL.GetSachQuaHan();
                        break;

                    case BaoCaoBLL.LoaiBaoCao.TienPhat:
                        dtKetQua = baoCaoBLL.GetTienPhat(dtpTuNgay.Value, dtpDenNgay.Value);
                        break;

                    case BaoCaoBLL.LoaiBaoCao.SachYeuThich:
                        dtKetQua = baoCaoBLL.GetSachYeuThich(dtpTuNgay.Value, dtpDenNgay.Value);
                        break;
                }

                // Gán kết quả cho 1 DataGridView duy nhất
                grdThongKe.DataSource = dtKetQua;

                // Tùy chỉnh định dạng tiền tệ (nếu là báo cáo tiền phạt)
                if (loaiBaoCao == BaoCaoBLL.LoaiBaoCao.TienPhat)
                {
                    if (grdThongKe.Columns.Contains("Tiền Quá Hạn"))
                        grdThongKe.Columns["Tiền Quá Hạn"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("Tiền Lỗi Sách"))
                        grdThongKe.Columns["Tiền Lỗi Sách"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("Tổng Tiền Phạt"))
                        grdThongKe.Columns["Tổng Tiền Phạt"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}