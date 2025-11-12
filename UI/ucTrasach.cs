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
    public partial class ucTrasach : UserControl

    {
        private PhieuTraBLL phieuTraBLL = new PhieuTraBLL();

        public ucTrasach()
        {
            InitializeComponent();
        }
        private void ucTrasach_Load(object sender, EventArgs e)
        {
            grdThongtintrasach.Rows.Clear();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (grdThongtintrasach.Rows.Count == 0 ||
        (grdThongtintrasach.Rows.Count == 1 && grdThongtintrasach.Rows[0].IsNewRow))
            {
                MessageBox.Show("Vui lòng chọn sách để trả!", "Thông báo");
                return;
            }

            try
            {
                // Tạo DANH SÁCH PhieuTraDTO (mỗi sách trả là 1 PhieuTraDTO)
                List<PhieuTraDTO> danhSachPhieuTra = new List<PhieuTraDTO>();
                string maDG = txtMadocgia.Text.Trim();
                string tenDG = txtTendocgia.Text;
                DateTime ngayTra = DateTime.Now;
                decimal tongTienPhat = 0;

                foreach (DataGridViewRow row in grdThongtintrasach.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Xử lý parse ngày tháng an toàn
                    DateTime ngayMuon, hanTra, ngayTraItem;
                    DateTime.TryParse(row.Cells["colNgaymuon"].Value?.ToString(), out ngayMuon);
                    DateTime.TryParse(row.Cells["colHan_tra"].Value?.ToString(), out hanTra);
                    DateTime.TryParse(row.Cells["colNgayTra"].Value?.ToString(), out ngayTraItem);

                    // Xử lý parse tiền phạt
                    string tienPhatStr = row.Cells["colTienPhat"].Value?.ToString();
                    decimal tienPhat = 0;
                    if (!string.IsNullOrEmpty(tienPhatStr))
                    {
                        tienPhatStr = tienPhatStr.Replace(" VNĐ", "").Replace(",", "").Replace(".", "").Trim();
                        decimal.TryParse(tienPhatStr, out tienPhat);
                    }

                    // Tạo 1 PhieuTraDTO cho mỗi sách trả
                    var phieuTra = new PhieuTraDTO
                    {
                        MaPhieuMS = Convert.ToInt32(row.Cells["colMaPhieuMS"].Value),
                        MaDocGia = maDG,
                        TenDocGia = tenDG,
                        MaSach = row.Cells["colMasachtra"].Value?.ToString(),
                        TenDauSach = row.Cells["colTensachtra"].Value?.ToString(),
                        NgayMuon = ngayMuon,
                        HanTra = hanTra,
                        NgayTra = ngayTraItem,
                        SoNgayTraTre = Convert.ToInt32(row.Cells["colSongaytratre"].Value),
                        TinhTrangSach = row.Cells["colTinhTrangSach"].Value?.ToString(),
                        TongTienPhat = tienPhat,
                        // Các trường khác có thể để mặc định (0 hoặc null)
                        MaThuThu = UserSession.MaThuThu
                    };

                    danhSachPhieuTra.Add(phieuTra);
                    tongTienPhat += phieuTra.TongTienPhat;
                }

                // Truyền DANH SÁCH PhieuTraDTO sang form xác nhận
                frmXacnhantrasach frm = new frmXacnhantrasach (danhSachPhieuTra, maDG, tenDG, ngayTra, tongTienPhat);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu lưu thành công, xóa danh sách trả
                    grdThongtintrasach.Rows.Clear();
                    MessageBox.Show("Trả sách thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xác nhận trả sách: {ex.Message}", "Lỗi");
            }
        }

        private void grdThongtinsachmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdSachdangmuon.Rows.Count)
            {
                DataGridViewRow selectedRow = grdSachdangmuon.Rows[e.RowIndex];
                DataRowView rowView = (DataRowView)selectedRow.DataBoundItem;
                DataRow sachMuon = rowView.Row;

                // SỬA: Kiểm tra trong DataGridViewRow thay vì DataRow
                string maSach = sachMuon["MaSach"].ToString();
                foreach (DataGridViewRow row in grdThongtintrasach.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới
                    if (row.Cells["colMasachtra"].Value?.ToString() == maSach)
                    {
                        MessageBox.Show("Sách này đã được thêm vào danh sách trả!", "Thông báo");
                        return;
                    }
                }
                frmNhapchitiettrasach f = new frmNhapchitiettrasach(sachMuon, txtTendocgia.Text);
                if (f.ShowDialog() == DialogResult.OK && f.ThongTinSachTra != null)
                {
                    var info = f.ThongTinSachTra;
                    int newRowIndex = grdThongtintrasach.Rows.Add();
                    DataGridViewRow newRow = grdThongtintrasach.Rows[newRowIndex];

                    // GÁN GIÁ TRỊ VÀO CÁC CỘT
                    newRow.Cells["colMasachtra"].Value = info.MaSach;
                    newRow.Cells["colTensachtra"].Value = info.TenDauSach;
                    newRow.Cells["colNgaymuon"].Value = info.NgayMuon.ToString("dd/MM/yyyy");
                    newRow.Cells["colHan_tra"].Value = info.HanTra.ToString("dd/MM/yyyy");
                    newRow.Cells["colNgayTra"].Value = info.NgayTra.ToString("dd/MM/yyyy");
                    newRow.Cells["colSongaytratre"].Value = info.SoNgayTraTre;
                    newRow.Cells["colTinhTrangSach"].Value = info.TinhTrangSach;
                    newRow.Cells["colTienPhat"].Value = info.TongTienPhat.ToString("N0") + " VNĐ";
                    newRow.Cells["colMaPhieuMS"].Value = info.MaPhieuMS;

                    // XÓA KHỎI DANH SÁCH MƯỢN
                    DataTable dtSachMuon = grdSachdangmuon.DataSource as DataTable;
                    if (dtSachMuon != null)
                    {
                        var rowToRemove = dtSachMuon.AsEnumerable()
                            .FirstOrDefault(row => row["MaSach"].ToString() == maSach);
                        if (rowToRemove != null)
                        {
                            dtSachMuon.Rows.Remove(rowToRemove);
                        }
                    }
                }
            }
        }
        private void txtMadocgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadThongTinDocGia();
            }
        }
        private void LoadThongTinDocGia()
        {
            string maDG = txtMadocgia.Text.Trim();
            if (string.IsNullOrEmpty(maDG))
            {
                ClearForm();
                return;
            }

            // Load thông tin độc giả
            DataTable dtDocGia = phieuTraBLL.LayThongTinDocGia(maDG);
            if (dtDocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy độc giả!");
                ClearForm();
                return;
            }

            DataRow docGia = dtDocGia.Rows[0];
            txtTendocgia.Text = docGia["HoTen"].ToString();

            // Load sách đang mượn
            DataTable dtSachMuon = phieuTraBLL.LaySachDangMuonTheoDocGia(maDG);

            // Hiển thị lên grid
            grdSachdangmuon.AutoGenerateColumns = false;
            grdSachdangmuon.DataSource = dtSachMuon;

            Console.WriteLine($"Grid có {grdSachdangmuon.Rows.Count} dòng sau khi binding");

            grdThongtintrasach.Rows.Clear();
        }
        private void ClearForm()
        {
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            grdSachdangmuon.DataSource = null;
            grdThongtintrasach.Rows.Clear();
            txtMadocgia.Focus();
        }

        private void grdSachdangmuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && grdSachdangmuon.Columns[e.ColumnIndex].Name == "colTinhtrang")
            {
                if (e.Value != null && e.Value.ToString() == "Quá hạn")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn trong grid sách trả không
            if (grdThongtintrasach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa khỏi danh sách trả!", "Thông báo");
                return;
            }

            // Lấy dòng được chọn
            DataGridViewRow selectedRow = grdThongtintrasach.SelectedRows[0];
            string maSach = selectedRow.Cells["colMasachtra"].Value?.ToString();
            string tenSach = selectedRow.Cells["colTensachtra"].Value?.ToString();

            if (string.IsNullOrEmpty(maSach))
            {
                MessageBox.Show("Không thể xóa sách này!", "Lỗi");
                return;
            }

            // HIỆN THÔNG BÁO XÁC NHẬN
            var result = MessageBox.Show($"Bạn có chắc muốn xóa sách '{tenSach}' khỏi danh sách trả?",
                                       "Xác nhận xóa",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // CHUYỂN SÁCH TỪ TRẢ VỀ MƯỢN
                ChuyenSachTuTraVeMuon(selectedRow);

                // XÓA KHỎI DANH SÁCH TRẢ
                grdThongtintrasach.Rows.Remove(selectedRow);

                MessageBox.Show($"Đã xóa sách '{tenSach}' khỏi danh sách trả!", "Thông báo");
            }
        }
        private void ChuyenSachTuTraVeMuon(DataGridViewRow rowTra)
        {
            string maSach = rowTra.Cells["colMasachtra"].Value?.ToString();
            if (string.IsNullOrEmpty(maSach)) return;

            // Lấy DataTable từ grid sách mượn
            DataTable dtSachMuon = grdSachdangmuon.DataSource as DataTable;
            if (dtSachMuon == null) return;

            // Kiểm tra xem sách đã có trong danh sách mượn chưa
            bool sachDaTonTai = dtSachMuon.AsEnumerable()
                .Any(row => row["MaSach"].ToString() == maSach);

            if (!sachDaTonTai)
            {
                // Tìm lại thông tin gốc từ database
                string maDG = txtMadocgia.Text.Trim();
                DataTable dtSachMuonGoc = phieuTraBLL.LaySachDangMuonTheoDocGia(maDG);

                var sachGoc = dtSachMuonGoc.AsEnumerable()
                    .FirstOrDefault(row => row["MaSach"].ToString() == maSach);
                if (sachGoc != null)
                {
                    // Tạo dòng mới cho sách mượn
                    DataRow newRow = dtSachMuon.NewRow();

                    newRow["MaPhieuMS"] = sachGoc["MaPhieuMS"]; // Lấy từ database, không phải từ rowTra
                    newRow["MaSach"] = sachGoc["MaSach"];
                    newRow["TenDauSach"] = sachGoc["TenDauSach"];
                    newRow["NgayMuon"] = sachGoc["NgayMuon"];
                    newRow["HanTra"] = sachGoc["HanTra"];
                    newRow["TrangThai"] = sachGoc["TrangThai"];

                    dtSachMuon.Rows.Add(newRow);

                    // Refresh grid sách mượn
                    grdSachdangmuon.DataSource = dtSachMuon;
                }
            }
        }

        private void btnhuytra_Click(object sender, EventArgs e)
        {
            if (grdThongtintrasach.Rows.Count == 0 ||
        (grdThongtintrasach.Rows.Count == 1 && grdThongtintrasach.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có sách nào trong danh sách trả!", "Thông báo");
                return;
            }

            // HIỆN THÔNG BÁO XÁC NHẬN
            var result = MessageBox.Show("Bạn có chắc muốn hủy tất cả sách trong danh sách trả?",
                                       "Xác nhận hủy",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // CHUYỂN TẤT CẢ SÁCH TỪ TRẢ VỀ MƯỢN
                ChuyenTatCaSachTuTraVeMuon();

                // XÓA TẤT CẢ KHỎI DANH SÁCH TRẢ
                grdThongtintrasach.Rows.Clear();

                MessageBox.Show("Đã hủy tất cả sách trong danh sách trả!", "Thông báo");
            }
        }
        private void ChuyenTatCaSachTuTraVeMuon()
        {
            DataTable dtSachMuon = grdSachdangmuon.DataSource as DataTable;
            if (dtSachMuon == null) return;

            // Tìm lại thông tin gốc từ database
            string maDG = txtMadocgia.Text.Trim();
            DataTable dtSachMuonGoc = phieuTraBLL.LaySachDangMuonTheoDocGia(maDG);

            foreach (DataGridViewRow row in grdThongtintrasach.Rows)
            {
                if (row.IsNewRow) continue;

                string maSach = row.Cells["colMasachtra"].Value?.ToString();
                if (string.IsNullOrEmpty(maSach)) continue;

                // Kiểm tra xem sách đã có trong danh sách mượn chưa
                bool sachDaTonTai = dtSachMuon.AsEnumerable()
                    .Any(r => r["MaSach"].ToString() == maSach);

                if (!sachDaTonTai)
                {
                    var sachGoc = dtSachMuonGoc.AsEnumerable()
                .FirstOrDefault(r => r["MaSach"].ToString() == maSach);

                    if (sachGoc != null)
                    {
                        DataRow newRow = dtSachMuon.NewRow();
                        newRow["MaPhieuMS"] = sachGoc["MaPhieuMS"];
                        newRow["MaSach"] = sachGoc["MaSach"];
                        newRow["TenDauSach"] = sachGoc["TenDauSach"];
                        newRow["NgayMuon"] = sachGoc["NgayMuon"];
                        newRow["HanTra"] = sachGoc["HanTra"];
                        newRow["TrangThai"] = sachGoc["TrangThai"];

                        dtSachMuon.Rows.Add(newRow);
                    }
                }
            }

            // Refresh grid sách mượn
            grdSachdangmuon.DataSource = dtSachMuon;
        }
    }
}
