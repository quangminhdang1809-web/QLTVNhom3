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
    public partial class ucSachthuthu : UserControl
    {
        private DauSachBLL dauSachBLL;
        private List<TacGiaDTO> danhSachTacGia;
        private string maSachDangChon;
        private DauSachDTO dauSachHienTai;
        private bool dangTaiDuLieu = false;
        public ucSachthuthu()
        {
            InitializeComponent();
            dauSachBLL = new DauSachBLL();
            danhSachTacGia = new List<TacGiaDTO>();
            grdSach.AutoGenerateColumns = false;
            LoadDanhSachDauSach();
            LoadViTriComboBox();
        }

        private void SetViewMode(bool isEditing)
        {
            // 1. Bật/Tắt các ô nhập liệu
            // Chỉ các ô này được sửa
            txtTenDauSach.ReadOnly = !isEditing;
            dtpNamXB.Enabled = isEditing; // DateTimePicker không có ReadOnly
            txtNhaXB.ReadOnly = !isEditing;
            txtSoLuong.ReadOnly = !isEditing;

            // Các ô này luôn khóa
            txtMaDauSach.ReadOnly = true;
            cboViTri.Enabled = true;

            // 2. Bật/Tắt các nút hành động chính
            btnSua.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnUndo.Enabled = isEditing;

            // 3. Khóa các hành động "nguy hiểm" khi đang sửa
            btnXoa.Enabled = !isEditing;
            btnThemsach.Enabled = !isEditing;
            grdSach.Enabled = !isEditing; // Khóa lưới chính

            // Khóa các nút điều hướng
            btnFirst.Enabled = !isEditing;
            btnPrevious.Enabled = !isEditing;
            btnNext.Enabled = !isEditing;
            btnLast.Enabled = !isEditing;
        }
        private void LoadDanhSachDauSach()
        {
            try
            {
                dangTaiDuLieu = true;
                var data = dauSachBLL.LayDanhSachDauSach();
                grdSach.DataSource = data;
                if (grdSach.Rows.Count > 0 && grdSach.Columns.Contains("colMadausach"))
                {
                    grdSach.ClearSelection();
                    grdSach.CurrentCell = grdSach.Rows[0].Cells[0];
                    grdSach.Rows[0].Selected = true;

                    var cellValue = grdSach.Rows[0].Cells["colMadausach"]?.Value;
                    if (cellValue != null)
                    {
                        string ma = cellValue.ToString();
                        if (!string.IsNullOrEmpty(ma))
                        {
                            maSachDangChon = ma;
                            HienThiChiTietSach(ma);
                        }
                    }
                }
                else
                {
                    ClearForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false; // THÊM DÒNG NÀY
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemsach frm = new frmThemsach();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachDauSach();
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[0].Cells[0];
                grdSach.Rows[0].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[0].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null) return;

            int i = grdSach.CurrentRow.Index;
            if (i > 0)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i - 1].Cells[0];
                grdSach.Rows[i - 1].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i - 1].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null) return;

            int i = grdSach.CurrentRow.Index;
            if (i < grdSach.RowCount - 1)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i + 1].Cells[0];
                grdSach.Rows[i + 1].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i + 1].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                int i = grdSach.RowCount - 1;
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i].Cells[0];
                grdSach.Rows[i].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void grdSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu) return;
            if (grdSach.SelectedRows.Count > 0 && grdSach.CurrentRow != null)
            {
                string ma = grdSach.CurrentRow.Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }
        // [THAY THẾ HÀM NÀY TRONG ucSachthuthu.cs]

        // [TRONG FILE ucSachthuthu.cs]
        // THAY THẾ HÀM NÀY

        private void HienThiChiTietSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
            {
                ClearForm();
                SetViewMode(false);
                return;
            }

            dangTaiDuLieu = true;
            try
            {
                dauSachHienTai = dauSachBLL.LayChiTietSach(maDauSach);

                if (dauSachHienTai != null)
                {
                    txtMaDauSach.Text = dauSachHienTai.MaDauSach;
                    txtTenDauSach.Text = dauSachHienTai.TenDauSach;
                    txtNhaXB.Text = dauSachHienTai.NhaXuatBan ?? "";

                    // SỬA DÒNG NÀY:
                    cboViTri.SelectedValue = dauSachHienTai.MaViTri;

                    txtSoLuong.Text = dauSachHienTai.SoLuongTong.ToString();

                    try
                    {
                        if (dauSachHienTai.NamXuatBan > 1000)
                            dtpNamXB.Value = new DateTime(dauSachHienTai.NamXuatBan, 1, 1);
                        else
                            dtpNamXB.Value = DateTime.Now;
                    }
                    catch { dtpNamXB.Value = DateTime.Now; }

                    grdTacgia.DataSource = dauSachHienTai.DanhSachTacGia;

                    SetViewMode(false);
                }
                else
                {
                    ClearForm();
                    SetViewMode(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }
        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var data = dauSachBLL.TimKiemSach(txtTimkiem.Text.Trim());
                grdSach.DataSource = data;
                if (grdSach.Rows.Count > 0)
                {
                    grdSach.ClearSelection();
                    grdSach.Rows[0].Selected = true;
                    string ma = grdSach.Rows[0].Cells["colMadausach"].Value?.ToString();
                    if (!string.IsNullOrEmpty(ma))
                    {
                        maSachDangChon = ma;
                        HienThiChiTietSach(ma);
                    }
                }
                else
                {
                    ClearForm(); // Clear form nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSachDangChon))
            {
                MessageBox.Show("Vui lòng chọn sách để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = dauSachBLL.XoaSach(maSachDangChon);
                    if (success)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachDauSach();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearForm()
        {
            txtMaDauSach.Text = "";
            txtTenDauSach.Text = "";
            txtNhaXB.Text = "";
            cboViTri.Text = "";
            txtSoLuong.Text = "";
            dtpNamXB.Value = DateTime.Now; // Reset date
            picAnhBia.Image = null;
            grdTacgia.DataSource = new List<TacGiaDTO>();
            maSachDangChon = null;
        }
        // [THÊM 3 HÀM NÀY VÀO ucSachthuthu.cs]

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn sách
            if (dauSachHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để sửa.");
                return;
            }

            // Chuyển sang chế độ SỬA
            SetViewMode(true);
            txtTenDauSach.Focus(); // Đặt con trỏ vào ô Tên sách
        }

        // [TRONG FILE ucSachthuthu.cs]
        // THAY THẾ HÀM NÀY

        // [TRONG FILE ucSachthuthu.cs]
        // THAY THẾ HÀM NÀY

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // ▼▼▼ THÊM KIỂM TRA 1 ▼▼▼
                if (dauSachHienTai == null)
                {
                    MessageBox.Show("Không có sách nào được chọn để lưu.");
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int soLuongMoi) || soLuongMoi < 0)
                {
                    MessageBox.Show("Số lượng phải là một số không âm!");
                    return;
                }

                // ▼▼▼ THÊM KIỂM TRA 2 ▼▼▼
                if (cboViTri.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một vị trí.");
                    return;
                }

                int soLuongCu = dauSachHienTai.SoLuongTong;

                DauSachDTO sachDaSua = dauSachHienTai;
                sachDaSua.TenDauSach = txtTenDauSach.Text;
                sachDaSua.NamXuatBan = (short)dtpNamXB.Value.Year;
                sachDaSua.NhaXuatBan = txtNhaXB.Text;
                sachDaSua.SoLuongTong = soLuongMoi;
                sachDaSua.MaViTri = cboViTri.SelectedValue.ToString();

                // Lưu ý: Code này của bạn đã bỏ qua việc cập nhật Tác giả
                bool success = dauSachBLL.CapNhatSach(sachDaSua, soLuongCu);

                if (success)
                {
                    MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ... (code tải lại lưới) ...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetViewMode(true);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Chỉ cần tải lại thông tin gốc của sách đang chọn
            // Hàm HienThiChiTietSach sẽ tự động gọi SetViewMode(false)
            if (dauSachHienTai != null)
            {
                HienThiChiTietSach(dauSachHienTai.MaDauSach);
            }
        }

        private void btnBanSach_Click(object sender, EventArgs e)
        {
            if (dauSachHienTai == null || string.IsNullOrEmpty(dauSachHienTai.MaDauSach))
            {
                MessageBox.Show("Vui lòng chọn một đầu sách trước.");
                return;
            }
            frmMaCaBiet frm = new frmMaCaBiet(dauSachHienTai.MaDauSach, dauSachHienTai.TenDauSach);
            frm.ShowDialog();
            int selectedRowIndex = grdSach.CurrentRow?.Index ?? 0;
            LoadDanhSachDauSach();

        }
        private void LoadViTriComboBox()
        {
            try
            {
                cboViTri.DataSource = dauSachBLL.LayDanhSachViTri();
                cboViTri.DisplayMember = "TenViTri";
                cboViTri.ValueMember = "MaViTri";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách vị trí: " + ex.Message);
            }
        }
    }
}
