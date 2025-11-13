using QLTVNhom3.BLL; // Đổi tên BLL
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLTVNhom3
{
    // ▼▼▼ SỬA LỖI: PHẢI KẾ THỪA TỪ USERCONTROL ▼▼▼
    public partial class ucBaoCao : UserControl
    {
        private ReportBLL reportBLL = new ReportBLL(); // Đổi tên BLL

        private readonly Dictionary<string, string> dsBaoCao;

        public ucBaoCao()
        {
            InitializeComponent(); // Dòng này BẮT BUỘC

            dsBaoCao = new Dictionary<string, string>
            {
                { "Sách đang mượn (Trong hạn)", "SachDangMuon" },
                { "Sách quá hạn", "SachQuaHan" },
                { "Báo cáo tiền phạt", "TienPhat" },
                { "Sách được mượn nhiều nhất", "SachYeuThich" },
                { "Thống kê tình trạng sách", "TinhTrangSach" }
            };

            // Gán sự kiện
            this.Load += ucBaoCao_Load;
            this.btnThongKe.Click += btnThongKe_Click;
            this.cbxChonMauBaoCao.SelectedIndexChanged += cbxChonMauBaoCao_SelectedIndexChanged;
        }

        private void ucBaoCao_Load(object sender, EventArgs e)
        {
            cbxChonMauBaoCao.DataSource = new BindingSource(dsBaoCao, null);
            cbxChonMauBaoCao.DisplayMember = "Key";
            cbxChonMauBaoCao.ValueMember = "Value";

            grdThongKe.ReadOnly = true;
            grdThongKe.AllowUserToAddRows = false;
            grdThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbxChonMauBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null) return;
            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();

            if (loaiBaoCao == "TienPhat" || loaiBaoCao == "SachYeuThich")
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
            else
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null) return;
            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();
            object dataSource = null;

            try
            {
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
                    case "TinhTrangSach": 
                        dataSource = reportBLL.GetBookInventoryStatus(); // Gọi BLL method mới
                        break;
                }

                grdThongKe.DataSource = dataSource;

                // Tùy chỉnh định dạng
                if (loaiBaoCao == "TienPhat")
                {
                    if (grdThongKe.Columns.Contains("TienPhatQuaHan"))
                        grdThongKe.Columns["TienPhatQuaHan"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("TienPhatLoiSach"))
                        grdThongKe.Columns["TienPhatLoiSach"].DefaultCellStyle.Format = "N0";
                    if (grdThongKe.Columns.Contains("TongTienPhat"))
                        grdThongKe.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
                }
                if (loaiBaoCao == "SachQuaHan")
                {
                    if (grdThongKe.Columns.Contains("TienPhatDuKien"))
                        grdThongKe.Columns["TienPhatDuKien"].DefaultCellStyle.Format = "N0";
                }
                grdThongKe.Visible = true;
                SetVietnameseColumnHeaders(loaiBaoCao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grdThongKe.Visible = false;
            }
            
        }
        private void SetVietnameseColumnHeaders(string loaiBaoCao)
        {
            // Đảm bảo grid có cột trước khi set
            if (grdThongKe.Columns.Count == 0) return;

            try
            {
                switch (loaiBaoCao)
                {
                    case "TinhTrangSach":
                        grdThongKe.Columns["STT"].HeaderText = "STT";
                        grdThongKe.Columns["MaDauSach"].HeaderText = "Mã Đầu Sách";
                        grdThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
                        grdThongKe.Columns["TongSoLuong"].HeaderText = "Tổng Sách";
                        grdThongKe.Columns["CoSan"].HeaderText = "Có sẵn";
                        grdThongKe.Columns["DangMuon"].HeaderText = "Đang Mượn";
                        break;

                    case "SachQuaHan":
                        grdThongKe.Columns["STT"].HeaderText = "STT";
                        grdThongKe.Columns["MaPhieuMS"].HeaderText = "Mã Phiếu";
                        grdThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
                        grdThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
                        grdThongKe.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
                        grdThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                        grdThongKe.Columns["HanTra"].HeaderText = "Hạn Trả";
                        grdThongKe.Columns["SoNgayQuaHan"].HeaderText = "Số Ngày Quá Hạn";
                        grdThongKe.Columns["TienPhatDuKien"].HeaderText = "Phạt Dự Kiến";
                        break;

                    case "TienPhat":
                        grdThongKe.Columns["STT"].HeaderText = "STT";
                        grdThongKe.Columns["MaPhieuTra"].HeaderText = "Mã Phiếu Trả";
                        grdThongKe.Columns["NgayTra"].HeaderText = "Ngày Trả";
                        grdThongKe.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
                        grdThongKe.Columns["LyDoPhat"].HeaderText = "Lý Do Phạt";
                        grdThongKe.Columns["SoNgayQuaHan"].HeaderText = "Ngày Quá Hạn";
                        grdThongKe.Columns["TienPhatQuaHan"].HeaderText = "Phạt Quá Hạn";
                        grdThongKe.Columns["TienPhatLoiSach"].HeaderText = "Phạt Hỏng Sách";
                        grdThongKe.Columns["TongTienPhat"].HeaderText = "Tổng Phạt";
                        grdThongKe.Columns["TrangThaiThu"].HeaderText = "Trạng Thái";
                        break;

                    case "SachYeuThich":
                        grdThongKe.Columns["STT"].HeaderText = "STT";
                        grdThongKe.Columns["MaDauSach"].HeaderText = "Mã Đầu Sách";
                        grdThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
                        grdThongKe.Columns["SoLuotMuon"].HeaderText = "Số Lượt Mượn";
                        break;
                }
            }
            catch (Exception ex)
            {
                // Có thể một tên cột bị sai (ví dụ: "STT" thay vì "Stt")
                // Bỏ qua lỗi này để chương trình không bị crash
                Console.WriteLine("Loi dat ten cot: " + ex.Message);
            }
        }
    }
    }