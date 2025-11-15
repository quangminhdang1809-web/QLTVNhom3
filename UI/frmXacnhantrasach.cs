using QLTVNhom3.BLL;
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
    public partial class frmXacnhantrasach : Form
    {
        private List<PhieuTraDTO> danhSachPhieuTra;
        private string maDocGia;
        private string tenDocGia;
        private DateTime ngayTra;
        private decimal tongTienPhat;
        private PhieuTraBLL phieuTraBLL = new PhieuTraBLL();
        public frmXacnhantrasach(List<PhieuTraDTO> danhSachPhieuTra, string maDocGia, string tenDocGia, DateTime ngayTra, decimal tongTienPhat)
        {
            InitializeComponent();
            this.danhSachPhieuTra = danhSachPhieuTra;
            this.maDocGia = maDocGia;
            this.tenDocGia = tenDocGia;
            this.ngayTra = ngayTra;
            this.tongTienPhat = tongTienPhat;

            LoadThongTinPhieuTra();
        }
        private void LoadThongTinPhieuTra()
        {
            if (danhSachPhieuTra == null || danhSachPhieuTra.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sách trả!", "Thông báo");
                return;
            }
            // Hiển thị thông tin độc giả
            txtMadocgia.Text = maDocGia;
            txtTendocgia.Text = tenDocGia;
            dtpNgaytra.Value = ngayTra;
            txtTongSachTra.Text = danhSachPhieuTra.Count.ToString(); 

            // Hiển thị danh sách sách trả
            LoadDanhSachSachTra();
            LoadThongTinPhat();

            // Hiển thị tổng tiền phạt
            txtTongtienphat.Text = tongTienPhat.ToString("N0") + " VNĐ";
        }
        private void LoadDanhSachSachTra()
        {
            // Clear existing rows
            dgvSachTra.Rows.Clear();

            foreach (var phieuTra in danhSachPhieuTra)
            {
                int rowIndex = dgvSachTra.Rows.Add();
                DataGridViewRow row = dgvSachTra.Rows[rowIndex];

                row.Cells["colMaphieumuon"].Value = phieuTra.MaPhieuMS; // Nếu có
                row.Cells["colMasachtra"].Value = phieuTra.MaSach;
                row.Cells["colTensachtra"].Value = phieuTra.TenDauSach;
                row.Cells["colNgaymuon"].Value = phieuTra.NgayMuon.ToString("dd/MM/yyyy");
                row.Cells["colNgaytrasach"].Value = phieuTra.NgayTra.ToString("dd/MM/yyyy");
                row.Cells["colTinhtrangsach"].Value = phieuTra.TinhTrangSach;
                row.Cells["colTinhTrangPhieu"].Value = phieuTra.SoNgayTraTre > 0 ? "Trả trễ" : "Đúng hạn";
                row.Cells["colGhichu"].Value = phieuTra.SoNgayTraTre > 0 ? $"Trả trễ {phieuTra.SoNgayTraTre} ngày" : "";
            }
        }
        private void LoadThongTinPhat()
        {
            // DEBUG: Kiểm tra DataGridView
            if (dgvThongTinPhat == null)
            {
                MessageBox.Show("LỖI: dgvThongTinPhat là NULL!", "Debug");
                return;
            }

            // Clear existing rows
            dgvThongTinPhat.Rows.Clear();

            int countSachBiPhat = 0;

            foreach (var phieuTra in danhSachPhieuTra)
            {
                // DEBUG: Kiểm tra từng sách
                bool coPhat = phieuTra.TongTienPhat > 0;
                Console.WriteLine($"Sách {phieuTra.MaSach}: Tiền phạt = {phieuTra.TongTienPhat}, Có phạt = {coPhat}");

                // Chỉ hiển thị những sách có phạt
                if (coPhat)
                {
                    countSachBiPhat++;

                    int rowIndex = dgvThongTinPhat.Rows.Add();
                    DataGridViewRow row = dgvThongTinPhat.Rows[rowIndex];

                    // Kiểm tra từng cột trước khi gán giá trị
                    try
                    {
                        row.Cells["colMaphieumuonphat"].Value = phieuTra.MaPhieuMS;
                        row.Cells["colMasach"].Value = phieuTra.MaSach;
                        row.Cells["colTensach"].Value = phieuTra.TenDauSach;
                        row.Cells["colSongaytratre"].Value = phieuTra.SoNgayTraTre > 0 ? $"{phieuTra.SoNgayTraTre} ngày" : "0 ngày";
                        row.Cells["colVipham"].Value = GetLoaiViPham(phieuTra);
                        row.Cells["colSotien"].Value = phieuTra.TongTienPhat.ToString("N0") + " VNĐ";

                        Console.WriteLine($"→ Đã thêm sách {phieuTra.MaSach} vào grid phạt");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi thêm sách {phieuTra.MaSach}: {ex.Message}", "Lỗi");
                    }
                }
            }
        }
        private string GetLoaiViPham(PhieuTraDTO phieuTra)
        {
            List<string> viPham = new List<string>();

            if (phieuTra.SoNgayTraTre > 0)
                viPham.Add($"Trả trễ ({phieuTra.SoNgayTraTre} ngày)");

            // 2. Vi phạm về tình trạng sách - CHỈ HIỆN KHI KHÔNG PHẢI "Bình thường"
            if (!string.IsNullOrEmpty(phieuTra.TinhTrangSach) &&
                phieuTra.TinhTrangSach != "Bình thường") 
            {
                // Hiển thị chính xác tình trạng sách
                viPham.Add(phieuTra.TinhTrangSach);
            }

            return viPham.Count > 0 ? string.Join(", ", viPham) : "Không";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Xác nhận từ người dùng
            var Result = MessageBox.Show("Bạn có chắc chắn muốn lưu phiếu trả này?",
                                         "Xác nhận",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (Result != DialogResult.Yes) return;

            try
            {
                // ** LOẠI BỎ CODE DEBUG TRƯỚC KHI LƯU **
                // Nếu cần, bạn có thể thêm logic xác thực cuối cùng ở đây.

                // 2. Gọi DAL/BLL để Lưu dữ liệu
                // GIẢ ĐỊNH: phieuTraBLL.LuuDanhSachPhieuTra sẽ ném lỗi (throw) nếu transaction thất bại
                bool result = phieuTraBLL.LuuDanhSachPhieuTra(danhSachPhieuTra);

                // 3. Xử lý kết quả THÀNH CÔNG
                if (result)
                {
                    MessageBox.Show("Lưu phiếu trả thành công! Sách đã được cập nhật trạng thái.",
                                    "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Trường hợp BLL/DAL trả về 'false' mà không ném lỗi (ít xảy ra)
                    MessageBox.Show("Lỗi khi lưu phiếu trả! Giao dịch thất bại. Vui lòng thử lại.",
                                    "Lỗi Giao dịch",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // 4. Bắt lỗi được ném từ DAL/BLL (Lỗi CSDL/Transaction)

                // Ghi log chi tiết (chỉ hiển thị trong cửa sổ Console)
                Console.WriteLine($"=== LỖI NGHIÊM TRỌNG BỊ BẮT TẠI UI ===");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                // Hiển thị lỗi chi tiết từ ex.Message (lỗi SQL/Transaction)
                string errorMessage = $"LỖI GIAO DỊCH CSDL: Thao tác không thành công.\n\nChi tiết: {ex.Message}";

                MessageBox.Show(errorMessage,
                                "Lỗi Hệ thống",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
