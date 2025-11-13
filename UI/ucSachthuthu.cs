using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using QLTVNhom3.DAL; // Cần cho TacGiaDAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Cần cho xử lý Ảnh
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucSachthuthu : UserControl
    {
        private DauSachBLL dauSachBLL;
        private TacGiaDAL tacGiaDAL; // Dùng để tìm tác giả
        private BindingList<TacGiaDTO> danhSachTacGiaSua;
        private string maSachDangChon;
        private DauSachDTO dauSachHienTai;
        private bool dangTaiDuLieu = false;
        private bool isProcessing = false;
        private DataTable dtSachGoc;
        private bool isDocGiaMode;

        public ucSachthuthu(bool docGiaMode = false)
        {
            InitializeComponent();
            isDocGiaMode = docGiaMode; // 🔹 LƯU CHẾ ĐỘ

            dauSachBLL = new DauSachBLL();
            tacGiaDAL = new TacGiaDAL();
            danhSachTacGiaSua = new BindingList<TacGiaDTO>();

            grdSach.AutoGenerateColumns = false;
            grdTacgia.AutoGenerateColumns = false;
            grdTacgia.DataSource = danhSachTacGiaSua;

            LoadViTriComboBox();
            LoadComboBoxLoc();
            LoadDanhSachDauSach();

            SetDocGiaMode(); // 🔹 ÁP DỤNG CHẾ ĐỘ ĐỘC GIẢ
        }
        // 🔹 THÊM PHƯƠNG THỨC NÀY
        private void SetDocGiaMode()
        {
            if (isDocGiaMode)
            {
                // Ẩn các nút chức năng CRUD
                btnThemsach.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Visible = false;
                btnUndo.Visible = false;
                btnThayAnh.Visible = false;
                btnBanSach.Visible = false;

                // Đặt tất cả controls thành ReadOnly
                SetAllControlsReadOnly();

                // DataGridView chỉ đọc
                grdSach.ReadOnly = true;
                grdSach.AllowUserToAddRows = false;
                grdSach.AllowUserToDeleteRows = false;

                // Grid tác giả chỉ đọc
                grdTacgia.ReadOnly = true;
                grdTacgia.AllowUserToAddRows = false;
                grdTacgia.AllowUserToDeleteRows = false;

                // Ẩn các tab/panel không cần thiết nếu có
                // tabControl1.TabPages.Remove(tabPageQuanLy);
            }
        }

        // 🔹 PHƯƠNG THỨC ĐẶT TẤT CẢ CONTROLS THÀNH READONLY
        private void SetAllControlsReadOnly()
        {
            txtMaDauSach.ReadOnly = true;
            txtTenDauSach.ReadOnly = true;
            txtNhaXB.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            dtpNamXB.Enabled = false;
            cboViTri.Enabled = false;

            // Đổi màu nền để thể hiện trạng thái chỉ đọc
            Color readOnlyColor = Color.FromArgb(240, 240, 240);
            txtMaDauSach.BackColor = readOnlyColor;
            txtTenDauSach.BackColor = readOnlyColor;
            txtNhaXB.BackColor = readOnlyColor;
            txtSoLuong.BackColor = readOnlyColor;
            cboViTri.BackColor = readOnlyColor;
        }
        public ucSachthuthu()
        {
            InitializeComponent();
            dauSachBLL = new DauSachBLL();
            tacGiaDAL = new TacGiaDAL(); // Khởi tạo
            danhSachTacGiaSua = new BindingList<TacGiaDTO>();

            grdSach.AutoGenerateColumns = false;
            grdTacgia.AutoGenerateColumns = false;
            grdTacgia.DataSource = danhSachTacGiaSua;

            LoadViTriComboBox();
            LoadComboBoxLoc();
            LoadDanhSachDauSach();

        }

        // 1. HIỂN THỊ ẢNH (ĐÃ SỬA)
        // [THAY THẾ HÀM NÀY TRONG ucSachthuthu.cs]
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
                panel1.AutoScrollPosition = new Point(0, 0);
                dauSachHienTai = dauSachBLL.LayChiTietSach(maDauSach);
                if (dauSachHienTai != null)
                {
                    txtMaDauSach.Text = dauSachHienTai.MaDauSach;
                    txtTenDauSach.Text = dauSachHienTai.TenDauSach;
                    txtNhaXB.Text = dauSachHienTai.NhaXuatBan ?? "";
                    cboViTri.SelectedValue = dauSachHienTai.MaViTri;
                    txtSoLuong.Text = dauSachHienTai.SoLuongTong.ToString();

                    try
                    {
                        if (dauSachHienTai.NamXuatBan > 1000 && dauSachHienTai.NamXuatBan < 9999)
                            dtpNamXB.Value = new DateTime(dauSachHienTai.NamXuatBan, 1, 1);
                        else
                            dtpNamXB.Value = DateTime.Now;
                    }
                    catch { dtpNamXB.Value = DateTime.Now; }

                    danhSachTacGiaSua.Clear();
                    if (dauSachHienTai.DanhSachTacGia != null)
                    {
                        foreach (var tg in dauSachHienTai.DanhSachTacGia)
                        {
                            danhSachTacGiaSua.Add(tg);
                        }
                    }

                    // --- DEBUGGING ẢNH BÌA ---
                    string tenFileAnh = dauSachHienTai.AnhBia;

                    // 1. Kiểm tra xem CSDL có trả về tên file không
                    if (string.IsNullOrEmpty(tenFileAnh))
                    {
                        picAnhBia.Image = null;
                        // Không cần báo lỗi, vì có thể sách này không có ảnh
                    }
                    else
                    {
                        try
                        {
                            // 2. Kiểm tra đường dẫn (DÙNG "Image" - không có 's')
                            string imageFolderPath = Path.Combine(Application.StartupPath, "Image");
                            string fullPath = Path.Combine(imageFolderPath, tenFileAnh.Trim()); // Thêm Trim()

                            // 3. Kiểm tra file có tồn tại không
                            if (File.Exists(fullPath))
                            {
                                using (Image tempImage = Image.FromFile(fullPath))
                                {
                                    picAnhBia.Image = new Bitmap(tempImage);
                                }
                            }
                            else
                            {
                                // 4. BÁO LỖI NẾU KHÔNG TÌM THẤY
                                MessageBox.Show($"Debug: Không tìm thấy file ảnh.\n" +
                                                $"Đã kiểm tra tại: {fullPath}",
                                                "Lỗi đường dẫn ảnh");
                                picAnhBia.Image = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            // 5. BÁO LỖI NẾU FILE BỊ HỎNG
                            MessageBox.Show($"Debug: Lỗi khi tải file ảnh (file có thể bị hỏng).\n" +
                                            $"Lỗi: {ex.Message}",
                                            "Lỗi đọc file ảnh");
                            picAnhBia.Image = null;
                        }
                    }
                    // --- KẾT THÚC DEBUGGING ---

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
        // 2. UPLOAD ẢNH (ĐÃ SỬA)
        private void btnThayAnh_Click(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                MessageBox.Show("Vui lòng nhấn nút 'Sửa' trước khi thay đổi ảnh.");
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourceFilePath = ofd.FileName;
                        string fileName = Path.GetFileName(sourceFilePath);

                        string imageFolderPath = Path.Combine(Application.StartupPath, "Image");

                        if (!Directory.Exists(imageFolderPath))
                        {
                            Directory.CreateDirectory(imageFolderPath);
                        }

                        string targetPath = Path.Combine(imageFolderPath, fileName);
                        File.Copy(sourceFilePath, targetPath, true);

                        using (Image tempImage = Image.FromFile(targetPath))
                        {
                            picAnhBia.Image = new Bitmap(tempImage);
                        }

                        dauSachHienTai.AnhBia = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc/copy file ảnh: " + ex.Message);
                    }
                }
            }
        }

        #region Các hàm CRUD và Quản lý Giao diện

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

        private void SetViewMode(bool isEditing)
        {
            // 🔹 NẾU LÀ CHẾ ĐỘ ĐỘC GIẢ, LUÔN Ở CHẾ ĐỘ XEM
            if (isDocGiaMode)
            {
                isEditing = false;
            }

            txtTenDauSach.ReadOnly = !isEditing;
            dtpNamXB.Enabled = isEditing;
            txtNhaXB.ReadOnly = !isEditing;
            txtSoLuong.ReadOnly = !isEditing;
            cboViTri.Enabled = isEditing;
            txtMaDauSach.ReadOnly = true;

            // 🔹 ẨN/HIỆN NÚT THEO CHẾ ĐỘ
            if (!isDocGiaMode)
            {
                btnSua.Enabled = !isEditing;
                btnLuu.Enabled = isEditing;
                btnUndo.Enabled = isEditing;
                btnXoa.Enabled = !isEditing;
                btnThemsach.Enabled = !isEditing;
                btnThayAnh.Enabled = isEditing;
                btnBanSach.Enabled = !isEditing;
            }

            grdSach.Enabled = !isEditing;

            btnFirst.Enabled = !isEditing;
            btnPrevious.Enabled = !isEditing;
            btnNext.Enabled = !isEditing;
            btnLast.Enabled = !isEditing;

            grdTacgia.Enabled = isEditing;
        }

        private void LoadDanhSachDauSach()
        {
            try
            {
                dangTaiDuLieu = true;

                dtSachGoc = dauSachBLL.LayDanhSachDauSach();

                // 🔹 FILTER CHO ĐỘC GIẢ
                if (isDocGiaMode)
                {
                    DataView dv = dtSachGoc.DefaultView;
                    dv.RowFilter = "SoLuongTong > 0";
                    grdSach.DataSource = dv.ToTable();
                }
                else
                {
                    grdSach.DataSource = dtSachGoc;
                }

                grdSach.DataSource = dtSachGoc;

                if (grdSach.Rows.Count > 0 && grdSach.Columns.Contains("colMadausach"))
                {
                    grdSach.ClearSelection();
                    grdSach.Rows[0].Selected = true;
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
                dangTaiDuLieu = false;
                if (grdSach.Rows.Count > 0)
                {
                    grdSach_SelectionChanged(null, null);
                }
            }
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            frmThemsach frm = new frmThemsach();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachDauSach();
            }
        }

        private void grdSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu || grdSach.SelectedRows.Count == 0) return;

            string ma = grdSach.SelectedRows[0].Cells["colMadausach"].Value?.ToString();
            if (!string.IsNullOrEmpty(ma))
            {
                maSachDangChon = ma;
                HienThiChiTietSach(ma);
            }
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            ApplyFilter(sender, e);
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
            cboViTri.SelectedIndex = -1;
            txtSoLuong.Text = "";
            dtpNamXB.Value = DateTime.Now;
            picAnhBia.Image = null;
            danhSachTacGiaSua.Clear();
            maSachDangChon = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dauSachHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để sửa.");
                return;
            }
            SetViewMode(true);
            txtTenDauSach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            try
            {
                isProcessing = true;
                btnLuu.Enabled = false;

                if (dauSachHienTai == null)
                {
                    MessageBox.Show("Không có sách nào được chọn để lưu.");
                    return;
                }
                if (cboViTri.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một vị trí.");
                    return;
                }
                if (!int.TryParse(txtSoLuong.Text, out int soLuongMoi) || soLuongMoi < 0)
                {
                    MessageBox.Show("Số lượng phải là một số không âm!");
                    return;
                }

                int soLuongCu = dauSachHienTai.SoLuongTong;

                DauSachDTO sachDaSua = dauSachHienTai;
                sachDaSua.TenDauSach = txtTenDauSach.Text;
                sachDaSua.NamXuatBan = (short)dtpNamXB.Value.Year;
                sachDaSua.NhaXuatBan = txtNhaXB.Text;
                sachDaSua.SoLuongTong = soLuongMoi;
                sachDaSua.MaViTri = cboViTri.SelectedValue.ToString();
                // (sachDaSua.AnhBia đã được cập nhật bởi btnThayAnh_Click)

                List<TacGiaDTO> tacGiasMoi = danhSachTacGiaSua.ToList();

                bool success = dauSachBLL.CapNhatSach(sachDaSua, tacGiasMoi, soLuongCu);

                if (success)
                {
                    MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int selectedRowIndex = grdSach.CurrentRow?.Index ?? 0;
                    LoadDanhSachDauSach();

                    if (grdSach.Rows.Count > selectedRowIndex)
                    {
                        grdSach.ClearSelection();
                        grdSach.Rows[selectedRowIndex].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetViewMode(true);
            }
            finally
            {
                Application.DoEvents();
                isProcessing = false;
                SetViewMode(false);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (dauSachHienTai != null)
            {
                HienThiChiTietSach(dauSachHienTai.MaDauSach);
                SetViewMode(false);
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

            // Tải lại chi tiết phòng trường hợp số lượng thay đổi (do xóa mềm)
            HienThiChiTietSach(dauSachHienTai.MaDauSach);
        }
        #endregion

        #region Nút điều hướng
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.Rows[0].Selected = true;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null || grdSach.CurrentRow.Index == 0) return;
            int i = grdSach.CurrentRow.Index;
            grdSach.ClearSelection();
            grdSach.Rows[i - 1].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null || grdSach.CurrentRow.Index == grdSach.RowCount - 1) return;
            int i = grdSach.CurrentRow.Index;
            grdSach.ClearSelection();
            grdSach.Rows[i + 1].Selected = true;
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.Rows[grdSach.RowCount - 1].Selected = true;
            }
        }
        private void grdSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đây có phải là cột "Ảnh bìa" (ImageColumn) của chúng ta không
            if (grdSach.Columns[e.ColumnIndex].Name == "AnhBia")
            {
                // 1. Lấy tên file từ cột ẩn (cột TextColumn)
                // (Tên cột ẩn này là "colAnhBiaFileName" sau khi bạn sửa ở Bước 2)
                string tenFileAnh = grdSach.Rows[e.RowIndex].Cells["colAnhBiaFileName"].Value.ToString();

                // 2. Kiểm tra
                if (!string.IsNullOrEmpty(tenFileAnh))
                {
                    try
                    {
                        // 3. Tạo đường dẫn đầy đủ (ví dụ: C:\...\bin\Debug\Image\1984.jpg)
                        string fullPath = Path.Combine(Application.StartupPath, "Image", tenFileAnh.Trim());

                        if (File.Exists(fullPath))
                        {
                            // 4. Tải ảnh và gán vào cell
                            // (Chúng ta tải ảnh dưới dạng "không khóa file")
                            using (Image tempImage = Image.FromFile(fullPath))
                            {
                                e.Value = new Bitmap(tempImage);
                            }
                        }
                        else
                        {
                            e.Value = null; // Không tìm thấy file
                        }
                    }
                    catch
                    {
                        e.Value = null; // Lỗi đọc file
                    }
                }
                else
                {
                    e.Value = null; // Sách này không có ảnh
                }
            }

        }
        private void LoadComboBoxLoc()
        {
            try
            {
                // 1. Lấy danh sách thể loại từ BLL
                // (Giả sử bạn đã có hàm LayDanhSachTheLoai trả về List<TheLoaiDTO> hoặc DataTable)
                var dsTheLoai = dauSachBLL.LayDanhSachTheLoai();

                // 2. Tạo một DataTable mới để thêm "Tất cả"
                DataTable dtFilter = new DataTable();
                dtFilter.Columns.Add("MaTheLoai", typeof(int));
                dtFilter.Columns.Add("TenTheLoai", typeof(string));

                // 3. Thêm dòng "Tất cả"
                dtFilter.Rows.Add(0, "-- Tất cả thể loại --");

                // 4. Copy dữ liệu từ BLL sang
                foreach (var tl in dsTheLoai)
                {
                    dtFilter.Rows.Add(tl.MaTheLoai, tl.TenTheLoai);
                }

                // 5. Gán DataSource
                cbxTheloaisach.DataSource = dtFilter;
                cbxTheloaisach.DisplayMember = "TenTheLoai";
                cbxTheloaisach.ValueMember = "MaTheLoai";
                cbxTheloaisach.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách thể loại: " + ex.Message);
            }
        }
        // [THÊM HÀM MỚI NÀY VÀO ucSachthuthu.cs]

        private void ApplyFilter(object sender, EventArgs e)
        {
            if (dtSachGoc == null) return;

            string tuKhoa = txtTimkiem.Text.Trim().ToLower();
            string tenTheLoai = cbxTheloaisach.Text; // Lấy TÊN thể loại

            DataView dv = dtSachGoc.DefaultView;
            string filter = "1=1";

            // 1. Lọc theo Thể loại
            if (tenTheLoai != "-- Tất cả thể loại --")
            {
                filter += $" AND TenTheLoai = '{tenTheLoai}'";
            }

            // 2. Lọc theo Từ khóa (Tên sách)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                filter += $" AND (CONVERT(TenDauSach, 'System.String') LIKE '%{tuKhoa}%' OR " +
                  $"      CONVERT(MaDauSach, 'System.String') LIKE '%{tuKhoa}%')";
            }

            dv.RowFilter = filter;
            grdSach.DataSource = dv.ToTable();
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(sender, e);
        }
        private void cbxTheloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter(sender, e);
        }


        #endregion
    }
}

