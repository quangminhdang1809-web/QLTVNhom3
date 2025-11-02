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
                row.Cells["colTinhtrangphieu"].Value = phieuTra.SoNgayTraTre > 0 ? "Trả trễ" : "Đúng hạn";
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
            var Result = MessageBox.Show("Bạn có chắc muốn lưu phiếu trả này?",
                               "Xác nhận",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (Result != DialogResult.Yes) return;

            try
            {
                // DEBUG: Hiển thị chi tiết dữ liệu sẽ lưu
                string debugInfo = "=== THÔNG TIN SẼ LƯU ===\n";
                debugInfo += $"Tổng số sách: {danhSachPhieuTra.Count}\n";
                debugInfo += $"Mã thủ thư: {danhSachPhieuTra[0].MaThuThu}\n\n";

                foreach (var pt in danhSachPhieuTra)
                {
                    debugInfo += $"Sách: {pt.MaSach}\n";
                    debugInfo += $"  - Mã phiếu mượn: {pt.MaPhieuMS}\n";
                    debugInfo += $"  - Ngày trả: {pt.NgayTra}\n";
                    debugInfo += $"  - Số ngày trả trễ: {pt.SoNgayTraTre}\n";
                    debugInfo += $"  - Tiền phạt: {pt.TongTienPhat}\n";
                    debugInfo += $"  - Tình trạng: {pt.TinhTrangSach}\n\n";
                }
                MessageBox.Show(debugInfo, "DEBUG - Trước khi lưu");
                // Lưu danh sách phiếu trả vào CSDL
                bool result = phieuTraBLL.LuuDanhSachPhieuTra(danhSachPhieuTra);

                if (result)
                {
                    MessageBox.Show("Lưu phiếu trả thành công! Sách đã được cập nhật trạng thái.", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu phiếu trả! Vui lòng kiểm tra Console để biết chi tiết.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                string errorDetails = $"Lỗi UI: {ex.Message}\n\n";
                errorDetails += $"Stack Trace: {ex.StackTrace}";
                MessageBox.Show(errorDetails, "Lỗi nghiêm trọng");
            }
        }
    }
}
