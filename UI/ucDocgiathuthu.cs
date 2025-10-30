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
        }
        private void SetEditMode(bool isEdit)
        {
            // Bật/tắt chỉnh sửa các control
            txtTendocgia.ReadOnly = !isEdit;
            txtEmail.ReadOnly = !isEdit;
            txtDiachi.ReadOnly = !isEdit;
            txtSdt.ReadOnly = !isEdit;
            dtpNgaysinh.Enabled = isEdit;
            cbbLoaidocgia.Enabled = isEdit;
            txtIDAccount.ReadOnly = isEdit;

            // Bật/tắt các nút
            btnSua.Enabled = !isEdit;        // Chỉ bật khi KHÔNG ở chế độ sửa
            btnLuu.Enabled = isEdit;         // Chỉ bật khi ở chế độ sửa
            btnUndo.Enabled = isEdit;        // Chỉ bật khi ở chế độ sửa
            btnXoa.Enabled = !isEdit;        // Chỉ bật khi KHÔNG ở chế độ sửa
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

                HienThiChiTietDG(); // Refresh hiển thị
            }
        }
        private void LoadComboBoxLoc()
        {
            try
            {
                cbbLocDocGia.Items.Clear();
                cbbLocDocGia.Items.Add("-- Tất cả loại --"); // Item mặc định

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

        private void button5_Click(object sender, EventArgs e)
        {
            grdDocgia.ClearSelection();
            grdDocgia.CurrentCell = grdDocgia[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdDocgia.CurrentCell = grdDocgia[0, i - 1];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i < grdDocgia.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp theo
            {
                grdDocgia.CurrentCell = grdDocgia[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.RowCount - 1;
            grdDocgia.CurrentCell = grdDocgia[0, i];//Dòng  cuối cùng
        }
        private void LoadDanhSachDocGia()
        {
            try
            {
                dangTimKiem = true; // Bật cờ đang tìm kiếm để tránh lọc không cần thiết
                danhSachDocGia = docGiaDAL.GetDanhSachDocGia();
                danhSachDocGiaGoc = new List<DocGiaDTO>(danhSachDocGia); // Lưu bản gốc
                grdDocgia.AutoGenerateColumns = false;
                grdDocgia.DataSource = null;
                grdDocgia.DataSource = danhSachDocGia;

                grdDocgia.Refresh();
                if (cbbLocDocGia.Items.Count > 0)
                {
                    cbbLocDocGia.SelectedIndex = 0; // Reset combobox lọc
                }
                if (danhSachDocGia.Count > 0)
                {
                    grdDocgia.ClearSelection();
                    grdDocgia.Rows[0].Selected = true;
                    grdDocgia.CurrentCell = grdDocgia.Rows[0].Cells[0];
                    HienThiChiTietDG();
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
                dangTimKiem = false; // Đảm bảo tắt cờ tìm kiếm trong mọi trường hợp
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                // Load loại độc giả
                DataTable dtLoai = docGiaDAL.GetLoaiDocGia();
                cbbLoaidocgia.DataSource = dtLoai;
                cbbLoaidocgia.DisplayMember = "TenLoaiDG";
                cbbLoaidocgia.ValueMember = "MaLoaiDG";
                //DataTable dtAccounts = docGiaDAL.GetAllAccounts();
                //if (dtAccounts.Rows.Count > 0)
                //{
                  //  txtIDAccount.Text = dtAccounts.Rows[0]["IDAccount"].ToString();
                //}
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
                // KIỂM TRA CÁCH LẤY DÒNG ĐƯỢC CHỌN
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

                // Chọn combobox
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
                dangTimKiem = true; // Bật cờ đang tìm kiếm

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
                // SỬA: thêm kiểm tra
                if (cbbLocDocGia.Items.Count > 0)
                {
                    cbbLocDocGia.SelectedIndex = 0;
                }
                if (grdDocgia.Rows.Count > 0)
                {
                    grdDocgia.Rows[0].Selected = true;
                    HienThiChiTietDG();
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
                dangTimKiem = false; // Đảm bảo tắt cờ tìm kiếm trong mọi trường hợp
            }
        }

        private void grdDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    grdDocgia.Rows[e.RowIndex].Selected = true; // đảm bảo chọn đúng dòng
                    docGiaHienTai = (DocGiaDTO)grdDocgia.Rows[e.RowIndex].DataBoundItem;
                    HienThiChiTietDG(); // cập nhật thông tin bên phải
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để sửa!", "Thông báo");
                return;
            }
            // Backup dữ liệu trước khi sửa
            BackupCurrentData();
            SetEditMode(true);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null) return;
            try
            {
                // Validate
                if (string.IsNullOrEmpty(docGiaHienTai.IDAccount))
                {
                    MessageBox.Show("Vui lòng nhập IDAccount");
                    return;
                }
                // Cập nhật thông tin từ controls
                docGiaHienTai.HoTen = txtTendocgia.Text.Trim();
                docGiaHienTai.NgaySinh = dtpNgaysinh.Value;
                docGiaHienTai.Email = txtEmail.Text.Trim();
                docGiaHienTai.DiaChi = txtDiachi.Text.Trim();
                docGiaHienTai.SoDienThoai = txtSdt.Text.Trim();
                docGiaHienTai.IDAccount = txtIDAccount.Text.Trim();
                docGiaHienTai.MaLoaiDG = Convert.ToInt32(cbbLoaidocgia.SelectedValue);

                // Lưu vào database
                int result = docGiaDAL.CapNhatDocGia(docGiaHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật độc giả thành công!");
                    SetEditMode(false);
                    LoadDanhSachDocGia(); // Refresh danh sách
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null) return;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa độc giả '{docGiaHienTai.HoTen}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int ketQua = docGiaDAL.XoaDocGia(docGiaHienTai.MaDocGia);
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
                            HienThiChiTietDG();
                        }
                        MessageBox.Show($"Đã thêm độc giả thành công! Số lượng: {danhSachDocGia.Count}",
                         "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbbLocDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangTimKiem) return; // Nếu đang trong chế độ tìm kiếm thì không lọc

            LocTheoLoaiDocGia();
        }
        // Phương thức lọc theo loại độc giả
        private void LocTheoLoaiDocGia()
        {
            try
            {
                if (dangTimKiem || danhSachDocGiaGoc == null || danhSachDocGiaGoc.Count == 0)
                {
                    return;
                }
                string loaiDuocChon = cbbLocDocGia.SelectedItem?.ToString();

                if (loaiDuocChon == "-- Tất cả loại --" || string.IsNullOrEmpty(loaiDuocChon))
                {
                    // Hiển thị tất cả
                    grdDocgia.DataSource = danhSachDocGiaGoc;
                }
                else
                {
                    // Cần lấy MaLoaiDG từ tên loại
                    int maLoaiDuocChon = LayMaLoaiTheoTen(loaiDuocChon);

                    // Lọc theo mã loại
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
                // Cập nhật lại hiển thị chi tiết nếu có dòng được chọn
                if (grdDocgia.Rows.Count > 0)
                {
                    grdDocgia.ClearSelection();
                    grdDocgia.Rows[0].Selected = true;
                    HienThiChiTietDG();
                }
                else
                {
                    // Xóa thông tin chi tiết nếu không có kết quả
                    XoaThongTinChiTiet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }
        //lấy mã loại từ tên loại
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
        // Phương thức xóa thông tin chi tiết
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
        }
        private void grdDocgia_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDocgia.SelectedRows.Count > 0 && !btnLuu.Enabled)
            {
                HienThiChiTietDG();
            }
        }
    }
}
