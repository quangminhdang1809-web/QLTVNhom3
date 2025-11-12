using QLTVNhom3.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLTVNhom3.DTO; // <-- Cần thêm DTO

namespace QLTVNhom3
{
    public partial class ucBaoCao : UserControl
    {
        // Sửa: Dùng ReportBLL thay vì BaoCaoBLL (khớp với file bạn gửi)
        private ReportBLL reportBLL = new ReportBLL();

        // Dùng Dictionary để lưu tên báo cáo và loại (enum)
        // Chúng ta sẽ dùng string key thay vì Enum để đơn giản hóa
        private readonly Dictionary<string, string> dsBaoCao;

        public ucBaoCao()
        {
            InitializeComponent();

            // Khởi tạo danh sách báo cáo
            dsBaoCao = new Dictionary<string, string>
            {
                { "Sách đang mượn", "SachDangMuon" },
                { "Sách quá hạn", "SachQuaHan" },
                { "Báo cáo tiền phạt", "TienPhat" },
                { "Sách được mượn nhiều nhất", "SachYeuThich" }
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

            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();

            // Nếu là báo cáo Tiền phạt hoặc Sách yêu thích, BẬT ô chọn ngày
            if (loaiBaoCao == "TienPhat" || loaiBaoCao == "SachYeuThich")
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

            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();

            // SỬA LỖI: Dùng List<DTO> thay vì DataTable
            // (Vì file BLL của bạn trả về List<DTO>)
            object dataSource = null;

            try
            {
                // Dùng switch-case để gọi hàm BLL tương ứng
                switch (loaiBaoCao)
                {
                    case "SachDangMuon":
                        dataSource = reportBLL.GetCurrentBorrowedBooks();
                        break;

                    case "SachQuaHan":
                        dataSource = reportBLL.GetOverdueBooks();
                        break;

                    case "TienPhat":
                        dataSource = reportBLL.GetFineReports(dtpTuNgay.Value, dtpDenNgay.Value);
                        break;

                    case "SachYeuThich":
                        dataSource = reportBLL.GetFavoriteBooks(dtpTuNgay.Value, dtpDenNgay.Value);
                        break;
                }

                // Gán kết quả cho 1 DataGridView duy nhất
                grdThongKe.DataSource = dataSource;

                // Tùy chỉnh định dạng tiền tệ (nếu là báo cáo tiền phạt)
                if (loaiBaoCao == "TienPhat")
                {
                    if (grdThongKe.Columns.Contains("TienPhatQuaHan"))
                        grdThongKe.Columns["TienPhatQuaHan"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("TienPhatLoiSach"))
                        grdThongKe.Columns["TienPhatLoiSach"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("TongTienPhat"))
                        grdThongKe.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
                }
                // Tùy chỉnh báo cáo quá hạn
                if (loaiBaoCao == "SachQuaHan")
                {
                    if (grdThongKe.Columns.Contains("TienPhatDuKien"))
                        grdThongKe.Columns["TienPhatDuKien"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // (Hàm btnIn của bạn sẽ được thêm logic sau)
        // private void btnIn_Click(object sender, EventArgs e) { ... }
    }
}