using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Windows.Forms;
// XÓA DÒNG "using ... VisualStyles" NẾU CÓ

namespace QLTVNhom3
{
    public partial class frmMaCaBiet : Form
    {
        private BanSachBLL sachBLL;
        private BanSachDTO banSachHienTai;
        private bool dangTaiDuLieu = false;
        private string _maDauSachFilter = null;

        // Constructor 1
        public frmMaCaBiet()
        {
            InitializeComponent();
            sachBLL = new BanSachBLL();
            AssignEvents();
        }

        // Constructor 2
        public frmMaCaBiet(string maDauSach, string tenDauSach)
        {
            InitializeComponent();
            sachBLL = new BanSachBLL();
            AssignEvents();

            _maDauSachFilter = maDauSach;
            this.Text = $"Mã Cá Biệt: {tenDauSach}";
        }

        private void AssignEvents()
        {
            this.Load += frmMaCaBiet_Load;
            this.grdSach.SelectionChanged += grdSach_SelectionChanged;

            this.btnFirst.Click += btnFirst_Click;
            this.btnPrevious.Click += btnPrevious_Click;
            this.btnNext.Click += btnNext_Click;
            this.btnLast.Click += btnLast_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnLuu.Click += btnLuu_Click;
            this.btnUndo.Click += btnUndo_Click;
            this.btnXoa.Click += btnXoa_Click;
        }

        private void frmMaCaBiet_Load(object sender, EventArgs e)
        {
            grdSach.AutoGenerateColumns = false;
            Madausach.DataPropertyName = "MaDauSach";
            Masach.DataPropertyName = "MaSach";
            Tendausach.DataPropertyName = "TenDauSach";
            Trangthai.DataPropertyName = "TenTinhTrang";

            LoadTinhTrangComboBox();
            LoadData();
            SetViewMode(false);
        }

        private void LoadData()
        {
            dangTaiDuLieu = true; // Bật cờ

            if (string.IsNullOrEmpty(_maDauSachFilter))
            {
                grdSach.DataSource = sachBLL.LayTatCaSach();
            }
            else
            {
                grdSach.DataSource = sachBLL.LaySachTheoDauSach(_maDauSachFilter);
            }

            dangTaiDuLieu = false; // Tắt cờ

            // SỬA LỖI "TRỐNG TRƠN": 
            // Tải chi tiết cho dòng đầu tiên (nếu có)
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.Rows[0].Selected = true;
                // Gọi thủ công
                HienThiChiTiet(grdSach.Rows[0].Cells["Masach"].Value.ToString());
            }
            else
            {
                // Nếu không có sách nào, xóa trắng form
                HienThiChiTiet(null);
            }
        }

        private void LoadTinhTrangComboBox()
        {
            cboTrangThai.DataSource = sachBLL.LayDanhSachTinhTrang();
            cboTrangThai.DisplayMember = "TenTinhTrang";
            cboTrangThai.ValueMember = "MaTinhTrang";
        }

        private void grdSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu) return; // Không làm gì nếu đang tải dữ liệu

            if (grdSach.SelectedRows.Count > 0) // Dùng SelectedRows cho an toàn
            {
                string maSach = grdSach.SelectedRows[0].Cells["Masach"].Value.ToString();
                HienThiChiTiet(maSach);
            }
        }

        private void HienThiChiTiet(string maSach)
        {
            dangTaiDuLieu = true;

            if (string.IsNullOrEmpty(maSach))
            {
                // Xóa trắng form
                banSachHienTai = null;
                txtMaSach.Text = "";
                txtMaDauSach.Text = "";
                txtTenSach.Text = "";
                cboTrangThai.SelectedIndex = -1;
                SetViewMode(false);
                btnSua.Enabled = false; // Tắt nút Sửa/Xóa
                btnXoa.Enabled = false;
            }
            else
            {
                banSachHienTai = sachBLL.LayChiTietSach(maSach);
                if (banSachHienTai != null)
                {
                    // Dùng tên control ĐÚNG (khớp với Bước 1)
                    txtMaSach.Text = banSachHienTai.MaSach;
                    txtMaDauSach.Text = banSachHienTai.MaDauSach;
                    txtTenSach.Text = banSachHienTai.TenDauSach;
                    cboTrangThai.SelectedValue = banSachHienTai.MaTinhTrang;
                }
                SetViewMode(false);
            }

            dangTaiDuLieu = false;
        }

        private void SetViewMode(bool isEditing)
        {
            cboTrangThai.Enabled = isEditing;
            txtMaSach.ReadOnly = true;
            txtMaDauSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;

            btnSua.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnUndo.Enabled = isEditing;
            btnXoa.Enabled = !isEditing;

            // Nếu không có sách nào, Sửa/Xóa phải luôn tắt
            if (banSachHienTai == null)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            grdSach.Enabled = !isEditing;
            btnTimkiem.Enabled = !isEditing && string.IsNullOrEmpty(_maDauSachFilter);
            groupBox2.Enabled = !isEditing;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (banSachHienTai == null) return;
            SetViewMode(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                banSachHienTai.MaTinhTrang = (int)cboTrangThai.SelectedValue;

                if (sachBLL.CapNhatSach(banSachHienTai))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    int currentIndex = 0;
                    if (grdSach.SelectedRows.Count > 0)
                        currentIndex = grdSach.SelectedRows[0].Index;

                    LoadData();

                    if (grdSach.Rows.Count > currentIndex)
                    {
                        grdSach.ClearSelection();
                        grdSach.Rows[currentIndex].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            HienThiChiTiet(banSachHienTai.MaSach);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (banSachHienTai == null) return;

            // SỬA DÒNG NÀY:
            if (MessageBox.Show($"Bạn có chắc muốn XÓA mã sách {banSachHienTai.MaSach}?",
                                 "Xác nhận xóa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    sachBLL.XoaSach(banSachHienTai.MaSach);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }


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
            if (grdSach.Rows.Count == 0) return;
            int i = 0;
            if (grdSach.SelectedRows.Count > 0)
                i = grdSach.SelectedRows[0].Index;

            if (i > 0)
            {
                grdSach.ClearSelection();
                grdSach.Rows[i - 1].Selected = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count == 0) return;
            int i = 0;
            if (grdSach.SelectedRows.Count > 0)
                i = grdSach.SelectedRows[0].Index;

            if (i < grdSach.RowCount - 1)
            {
                grdSach.ClearSelection();
                grdSach.Rows[i + 1].Selected = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.Rows[grdSach.RowCount - 1].Selected = true;
            }
        }
        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}