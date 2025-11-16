using Microsoft.Data.SqlClient;
using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmXacnhanmuonsach : Form
    {
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        // Đã xóa dòng gán cứng: private int currentMaThuThu = 1;

        public frmXacnhanmuonsach(string maDG, string tenDG, DataTable danhSachSach)
        {
            InitializeComponent();

            txtMadocgia.Text = maDG;
            txtTendocgia.Text = tenDG;
            dtpNgaymuon.Value = DateTime.Now;

            dgrXacnhan.AutoGenerateColumns = false;
            dgrXacnhan.Rows.Clear();

            // 💡 SỬA LỖI: Đọc đúng tên cột từ DataTable (TenDauSach, MaSach, ...)
            // (DataTable này đến từ hàm TimKiemSach)
            foreach (DataRow row in danhSachSach.Rows)
            {
                dgrXacnhan.Rows.Add(
                    row["Tên sách"],  // Lấy từ cột TenDauSach
                    row["Mã sách"],      // Lấy từ cột MaSach
                    row["Năm xuất bản"],  // Lấy từ cột NamXuatBan
                    DateTime.Now.AddDays(7).ToShortDateString()
                );
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                int maDocGia = Convert.ToInt32(txtMadocgia.Text.Trim());

                // --- YÊU CẦU MỚI: KIỂM TRA SỐ LƯỢNG SÁCH ---
                // 1. Đếm số sách trong giỏ hàng (trên DataGridView)
                int soSachTrongGio = 0;
                foreach (DataGridViewRow row in dgrXacnhan.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới (nếu có)
                    soSachTrongGio++;
                }

                // 2. Lấy số liệu từ CSDL
                int soSachDaMuon = phieuMuonDAL.GetSoSachDangMuon(maDocGia);
                int soSachToiDa = phieuMuonDAL.GetSoSachToiDa(maDocGia);

                // 3. Kiểm tra logic
                if ((soSachDaMuon + soSachTrongGio) > soSachToiDa)
                {
                    MessageBox.Show(
                      $"Lỗi: Độc giả đã mượn {soSachDaMuon} cuốn.\n" +
                      $"Giới hạn tối đa của độc giả này là {soSachToiDa} cuốn.\n" +
                      $"Không thể mượn thêm {soSachTrongGio} cuốn này.",
                      "Vượt Quá Số Lượng Cho Phép",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                    );
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return; // Dừng xử lý
                }
                // --- KẾT THÚC KIỂM TRA ---

                DateTime ngayMuon = DateTime.Now;
                string hinhThuc = cbxHinhthucmuon.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(hinhThuc))
                {
                    MessageBox.Show("Vui lòng chọn hình thức mượn.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🌟 BƯỚC QUAN TRỌNG: Lấy mã thủ thư từ DTO (Session)
                int maThuThuHienTai = UserSession.MaThuThu;

                // Kiểm tra xem mã thủ thư có hợp lệ không
                if (maThuThuHienTai <= 0)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy thông tin thủ thư đang đăng nhập. Vui lòng đăng nhập lại.", "Lỗi Session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi hàm DAL với mã thủ thư đúng
                int newPhieuMuonID = phieuMuonDAL.InsertPhieuMuon(maDocGia, maThuThuHienTai, ngayMuon, hinhThuc);

                if (newPhieuMuonID <= 0)
                {
                    MessageBox.Show("❌ Không thể thêm phiếu mượn (ID = 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maTinhTrangCTPM = 2; // Giả sử 2 = "Đang mượn"
                int maTinhTrangSach = 2; // Giả sử 2 = "Đang mượn"

                foreach (DataGridViewRow row in dgrXacnhan.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maSach = row.Cells["colMasachmuon"].Value?.ToString();
                    string hanTraStr = row.Cells["colHantra"].Value?.ToString();

                    if (!string.IsNullOrEmpty(maSach))
                    {
                        DateTime hanTra = DateTime.Parse(hanTraStr);

                        phieuMuonDAL.InsertChiTietPhieuMuon(newPhieuMuonID, maSach, hanTra, maTinhTrangCTPM);
                        phieuMuonDAL.CapNhatTinhTrangSach(maSach, maTinhTrangSach);
                    }
                }

                MessageBox.Show("✅ Xác nhận mượn sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi xác nhận mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("❌ Lỗi khi xác nhận mượn: " + ex);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}