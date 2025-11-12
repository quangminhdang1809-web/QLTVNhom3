using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucDocgiathuthu : UserControl
    {
        private DocGiaDAL docGiaDAL;
        private List<DocGiaDTO> danhSachDocGia;
        private List<DocGiaDTO> danhSachDocGiaGoc;
        private DocGiaDTO docGiaHienTai;
        private DocGiaDTO docGiaBackup;
        private bool dangTimKiem = false;
        private DocGiaBLL docGiaBLL = new DocGiaBLL();

        public ucDocgiathuthu()
        {
            InitializeComponent();
            docGiaDAL = new DocGiaDAL();
            danhSachDocGia = new List<DocGiaDTO>();
            danhSachDocGiaGoc = new List<DocGiaDTO>();
            LoadDanhSachDocGia();
            LoadComboBoxes();
            LoadComboBoxLoc();
            SetEditMode(false);

            // Cấu hình lưới Lịch sử
            dgvLichsumuontra.AutoGenerateColumns = false;
        }
        private void SetEditMode(bool isEdit)
        {
            txtTendocgia.ReadOnly = !isEdit;
            txtEmail.ReadOnly = !isEdit;
            txtDiachi.ReadOnly = !isEdit;
            txtSdt.ReadOnly = !isEdit;
            dtpNgaysinh.Enabled = isEdit;
            cbbLoaidocgia.Enabled = isEdit;
            txtIDAccount.ReadOnly = true; // IDAccount không bao giờ được sửa

            btnSua.Enabled = !isEdit;
            btnLuu.Enabled = isEdit;
            btnUndo.Enabled = isEdit;
            btnXoa.Enabled = !isEdit;
        }
        private void BackupCurrentData()
        {
            if (docGiaHienTai != null)
            {
                docGiaBackup = new DocGiaDTO
                {
                    MaDocGia = docGiaHienTai.MaDocGia,
                    HoTen = docGiaHienTai.HoTen,
                    NgaySinh = docGiaHienTai.NgaySinh,
                    Email = docGiaHienTai.Email,
                    DiaChi = docGiaHienTai.DiaChi,
                    SoDienThoai = docGiaHienTai.SoDienThoai,
                    IDAccount = docGiaHienTai.IDAccount,
                    MaLoaiDG = docGiaHienTai.MaLoaiDG
                };
            }
        }

        private void RestoreBackupData()
        {
            if (docGiaBackup != null)
            {
                docGiaHienTai.HoTen = docGiaBackup.HoTen;
                docGiaHienTai.NgaySinh = docGiaBackup.NgaySinh;
                docGiaHienTai.Email = docGiaBackup.Email;
                docGiaHienTai.DiaChi = docGiaBackup.DiaChi;
                docGiaHienTai.SoDienThoai = docGiaBackup.SoDienThoai;
                docGiaHienTai.IDAccount = docGiaBackup.IDAccount;
                docGiaHienTai.MaLoaiDG = docGiaBackup.MaLoaiDG;

                HienThiChiTietDG();
            }
        }
        private void LoadComboBoxLoc()
        {
            try
            {
                cbbLocDocGia.Items.Clear();
                cbbLocDocGia.Items.Add("-- Tất cả loại --");

                DataTable dtLoai = docGiaDAL.GetLoaiDocGia();
                foreach (DataRow row in dtLoai.Rows)
                {
                    cbbLocDocGia.Items.Add(row["TenLoaiDG"].ToString());
                }

                cbbLocDocGia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lọc: " + ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdDocgia.Rows.Count > 0)
            {
                grdDocgia.ClearSelection();
                grdDocgia.Rows[0].Selected = true;
                grdDocgia.CurrentCell = grdDocgia.Rows[0].Cells[0];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdDocgia.Rows.Count == 0 || grdDocgia.SelectedRows.Count == 0) return;
            int i = grdDocgia.SelectedRows[0].Index;
            if (i > 0)
            {
                grdDocgia.ClearSelection();
                grdDocgia.Rows[i - 1].Selected = true;
                grdDocgia.CurrentCell = grdDocgia.Rows[i - 1].Cells[0];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdDocgia.Rows.Count == 0 || grdDocgia.SelectedRows.Count == 0) return;
            int i = grdDocgia.SelectedRows[0].Index;
            if (i < grdDocgia.RowCount - 1)
            {
                grdDocgia.ClearSelection();
                grdDocgia.Rows[i + 1].Selected = true;
                grdDocgia.CurrentCell = grdDocgia.Rows[i + 1].Cells[0];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdDocgia.Rows.Count > 0)
            {
                int i = grdDocgia.RowCount - 1;
                grdDocgia.ClearSelection();
                grdDocgia.Rows[i].Selected = true;
                grdDocgia.CurrentCell = grdDocgia.Rows[i].Cells[0];
            }
        }
        private void LoadDanhSachDocGia()
        {
            try
            {
                dangTimKiem = true;
                danhSachDocGia = docGiaDAL.GetDanhSachDocGia();
                danhSachDocGiaGoc = new List<DocGiaDTO>(danhSachDocGia);
                grdDocgia.AutoGenerateColumns = false;
                grdDocgia.DataSource = null;
                grdDocgia.DataSource = danhSachDocGia;

                grdDocgia.Refresh();
                if (cbbLocDocGia.Items.Count > 0)
                {
                    cbbLocDocGia.SelectedIndex = 0;
                }
                if (danhSachDocGia.Count > 0)
                {
                    grdDocgia.ClearSelection();
                    grdDocgia.Rows[0].Selected = true;
                    grdDocgia.CurrentCell = grdDocgia.Rows[0].Cells[0];
                }
                else
                {
                    XoaThongTinChiTiet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dangTimKiem = false;
                // Tải chi tiết và lịch sử cho dòng đầu tiên
                grdDocgia_SelectionChanged(null, null);
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                DataTable dtLoai = docGiaDAL.GetLoaiDocGia();
                cbbLoaidocgia.DataSource = dtLoai;
                cbbLoaidocgia.DisplayMember = "TenLoaiDG";
                cbbLoaidocgia.ValueMember = "MaLoaiDG";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void HienThiChiTietDG()
        {
            try
            {
                DataGridViewRow selectedRow = null;

                if (grdDocgia.SelectedRows.Count > 0)
                {
                    selectedRow = grdDocgia.SelectedRows[0];
                }
                else if (grdDocgia.CurrentRow != null && grdDocgia.CurrentRow.Index >= 0)
                {
                    selectedRow = grdDocgia.CurrentRow;
                }

                if (selectedRow == null || selectedRow.DataBoundItem == null)
                {
                    XoaThongTinChiTiet();
                    return;
                }
                docGiaHienTai = (DocGiaDTO)selectedRow.DataBoundItem;
                txtMadocgia.Text = docGiaHienTai.MaDocGia.ToString();
                txtTendocgia.Text = docGiaHienTai.HoTen;
                dtpNgaysinh.Value = docGiaHienTai.NgaySinh;
                txtEmail.Text = docGiaHienTai.Email ?? "";
                txtDiachi.Text = docGiaHienTai.DiaChi ?? "";
                txtSdt.Text = docGiaHienTai.SoDienThoai ?? "";
                dtpNgaylapthe.Value = docGiaHienTai.NgayLapThe;
                dtpNgayhethan.Value = docGiaHienTai.NgayHetHan;
                txtIDAccount.Text = docGiaHienTai.IDAccount ?? "";

                if (cbbLoaidocgia.Items.Count > 0)
                {
                    try
                    {
                        cbbLoaidocgia.SelectedValue = docGiaHienTai.MaLoaiDG;
                    }
                    catch
                    {
                        if (cbbLoaidocgia.Items.Count > 0)
                        {
                            cbbLoaidocgia.SelectedIndex = 0;
                        }
                    }
                }
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị chi tiết độc giả: " + ex.Message);
                XoaThongTinChiTiet();
            }
        }
        private void ucDocgiathuthu_Load(object sender, EventArgs e)
        {
            grdDocgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDocgia.MultiSelect = false;
            grdDocgia.AutoGenerateColumns = false;
            LoadDanhSachDocGia();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                dangTimKiem = true;
                string tuKhoa = txtTimkiem.Text.Trim();

                if (string.IsNullOrEmpty(tuKhoa))
                {
                    grdDocgia.DataSource = danhSachDocGiaGoc ?? new List<DocGiaDTO>();
                }
                else
                {
                    List<DocGiaDTO> list = docGiaDAL.TimKiemDocGia(tuKhoa);
                    grdDocgia.DataSource = list;
                }
                if (cbbLocDocGia.Items.Count > 0)
                {
                    cbbLocDocGia.SelectedIndex = 0;
                }
                if (grdDocgia.Rows.Count > 0)
                {
                    grdDocgia.Rows[0].Selected = true;
                }
                else
                {
                    XoaThongTinChiTiet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
            finally
            {
                dangTimKiem = false;
                grdDocgia_SelectionChanged(null, null); // Cập nhật chi tiết + lịch sử
            }
        }

        // --- HÀM SELECTIONCHANGED DUY NHẤT ---
        private void grdDocgia_SelectionChanged(object sender, EventArgs e)
        {
            // Không làm gì nếu đang sửa hoặc đang tải dữ liệu
            if (btnLuu.Enabled || dangTimKiem) return;

            if (grdDocgia.SelectedRows.Count > 0)
            {
                try
                {
                    int maDocGia = Convert.ToInt32(grdDocgia.SelectedRows[0].Cells["colMaDocGia"].Value);

                    // 1. Tải chi tiết
                    HienThiChiTietDG();

                    // 2. Tải lịch sử mượn trả
                    LoadLichSuMuonTra(maDocGia);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy mã độc giả: " + ex.Message);
                    dgvLichsumuontra.DataSource = null;
                }
            }
            else
            {
                XoaThongTinChiTiet();
                dgvLichsumuontra.DataSource = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để sửa!", "Thông báo");
                return;
            }
            BackupCurrentData();
            SetEditMode(true);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null) return;
            try
            {
                if (string.IsNullOrEmpty(txtTendocgia.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên độc giả");
                    return;
                }

                docGiaHienTai.HoTen = txtTendocgia.Text.Trim();
                docGiaHienTai.NgaySinh = dtpNgaysinh.Value;
                docGiaHienTai.Email = txtEmail.Text.Trim();
                docGiaHienTai.DiaChi = txtDiachi.Text.Trim();
                docGiaHienTai.SoDienThoai = txtSdt.Text.Trim();
                docGiaHienTai.IDAccount = txtIDAccount.Text.Trim();
                docGiaHienTai.MaLoaiDG = Convert.ToInt32(cbbLoaidocgia.SelectedValue);

                int result = docGiaDAL.CapNhatDocGia(docGiaHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật độc giả thành công!");
                    SetEditMode(false);
                    LoadDanhSachDocGia();
                }
                else
                {
                    MessageBox.Show("Cập nhật độc giả thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            RestoreBackupData();
            SetEditMode(false);
        }

        // [THAY THẾ HÀM NÀY TRONG ucDocgiathuthu.cs]

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null) return;

            // BƯỚC 1: KIỂM TRA RÀNG BUỘC TRƯỚC
            try
            {
                bool daMuonSach = docGiaBLL.KiemTraPhieuMuonTonTai(docGiaHienTai.MaDocGia);

                if (daMuonSach)
                {
                    // BƯỚC 2: THÔNG BÁO CHO THỦ THƯ (NẾU BỊ CẤM XÓA)
                    MessageBox.Show(
                        $"Không thể xóa độc giả '{docGiaHienTai.HoTen}'.\n\n" +
                        "Nguyên nhân: Độc giả này đã có lịch sử mượn trả sách trong hệ thống.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // Hiển thị icon Cảnh báo
                    return; // Dừng lại, không làm gì cả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra xóa: " + ex.Message);
                return;
            }

            // BƯỚC 3: XÓA (NẾU KHÔNG VƯỚNG)
            // Đoạn code này chỉ chạy nếu KiemTraPhieuMuonTonTai == false
            DialogResult result = MessageBox.Show(
                $"Độc giả '{docGiaHienTai.HoTen}' chưa có lịch sử mượn trả.\n" +
                "Bạn có chắc muốn xóa vĩnh viễn độc giả này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Chỗ này bạn có 2 lựa chọn:
                    // 1. Xóa cứng (Vì họ chưa mượn gì):
                    // int ketQua = docGiaDAL.XoaCungDocGia(docGiaHienTai.MaDocGia); // Bạn cần viết hàm này

                    // 2. Xóa mềm (An toàn hơn):
                    int ketQua = docGiaDAL.XoaDocGia(docGiaHienTai.MaDocGia); // Dùng hàm Xóa Mềm (UPDATE TrangThai = 0)

                    if (ketQua > 0)
                    {
                        MessageBox.Show("Xóa độc giả thành công!");
                        LoadDanhSachDocGia();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private void btnThemdocgia_Click(object sender, EventArgs e)
        {
            {
                using (var frmThem = new frmThemdocgia())
                {
                    if (frmThem.ShowDialog() == DialogResult.OK)
                    {
                        LoadDanhSachDocGia();

                        if (grdDocgia.Rows.Count > 0)
                        {
                            int lastIndex = grdDocgia.Rows.Count - 1;
                            grdDocgia.ClearSelection();
                            grdDocgia.Rows[lastIndex].Selected = true;
                            grdDocgia.CurrentCell = grdDocgia.Rows[lastIndex].Cells[0];
                        }
                        MessageBox.Show($"Đã thêm độc giả thành công! Số lượng: {danhSachDocGia.Count}",
                         "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbbLocDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangTimKiem) return;

            LocTheoLoaiDocGia();
        }

        private void LocTheoLoaiDocGia()
        {
            try
            {
                if (danhSachDocGiaGoc == null || danhSachDocGiaGoc.Count == 0)
                {
                    return;
                }
                string loaiDuocChon = cbbLocDocGia.SelectedItem?.ToString();

                if (loaiDuocChon == "-- Tất cả loại --" || string.IsNullOrEmpty(loaiDuocChon))
                {
                    grdDocgia.DataSource = danhSachDocGiaGoc;
                }
                else
                {
                    int maLoaiDuocChon = LayMaLoaiTheoTen(loaiDuocChon);
                    if (maLoaiDuocChon != -1)
                    {
                        var danhSachLoc = danhSachDocGiaGoc.Where(dg =>
                            dg.MaLoaiDG == maLoaiDuocChon).ToList();
                        grdDocgia.AutoGenerateColumns = false;
                        grdDocgia.DataSource = danhSachLoc;
                    }
                    else
                    {
                        grdDocgia.DataSource = danhSachDocGiaGoc;
                    }

                }
                if (grdDocgia.Rows.Count > 0)
                {
                    grdDocgia.ClearSelection();
                    grdDocgia.Rows[0].Selected = true;
                }
                else
                {
                    XoaThongTinChiTiet();
                }
                // Cập nhật chi tiết và lịch sử sau khi lọc
                grdDocgia_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }

        private int LayMaLoaiTheoTen(string tenLoai)
        {
            try
            {
                DataTable dtLoai = docGiaDAL.GetLoaiDocGia();
                foreach (DataRow row in dtLoai.Rows)
                {
                    if (row["TenLoaiDG"].ToString() == tenLoai)
                    {
                        return Convert.ToInt32(row["MaLoaiDG"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã loại: " + ex.Message);
            }
            return -1;
        }

        private void XoaThongTinChiTiet()
        {
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            txtEmail.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtIDAccount.Text = "";
            docGiaHienTai = null;
            SetEditMode(false);
            dgvLichsumuontra.DataSource = null; // Thêm dòng này
        }

        // --- HÀM TẢI LỊCH SỬ ---
        private void LoadLichSuMuonTra(int maDocGia)
        {
            try
            {
                // Giả sử lưới lịch sử tên là dgvLichsumuontra
                dgvLichsumuontra.DataSource = docGiaBLL.LayLichSuMuonTra(maDocGia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử mượn trả: " + ex.Message);
            }
        }
    }
}