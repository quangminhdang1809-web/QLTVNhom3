using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTVNhom3.UI
{
    public partial class ucVipham : UserControl
    {
        private ViPhamBLL viPhamBLL = new ViPhamBLL();
        private bool isNew = false;
        private bool isProcessing = false;

        // Dùng để lưu trữ danh sách gốc cho việc lọc
        private DataTable dtViPhamGoc;

        public ucVipham()
        {
            InitializeComponent();
            this.Load += ucVipham_Load;
        }

        private void ucVipham_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình ComboBox CHỈNH SỬA (cboLoaiViPham)
            cboLoaiViPham.Items.Add("Quá hạn");
            cboLoaiViPham.Items.Add("Lỗi sách");
            cboLoaiViPham.SelectedIndex = 0;

            // 2. Tải ComboBox LỌC (cbxLoaiViPham)
            LoadComboBoxLoc();

            // 3. Tải dữ liệu
            LoadData();
            SetViewMode(false);

            // Gán sự kiện LỌC
            btnTimkiem.Click += ApplyFilter;
            txtTimkiem.TextChanged += ApplyFilter;
            cbxLoaiViPham.SelectedIndexChanged += ApplyFilter;


        }

        // HÀM MỚI: Tải ComboBox LỌC (cbxLoaiViPham)
        private void LoadComboBoxLoc()
        {
            try
            {
                DataTable dtLoai = viPhamBLL.GetDistinctLoaiViPham();

                DataRow tatCaRow = dtLoai.NewRow();
                tatCaRow["LoaiViPham"] = "Tất cả";
                dtLoai.Rows.InsertAt(tatCaRow, 0);

                // Gán dữ liệu cho ComboBox LỌC
                cbxLoaiViPham.DataSource = dtLoai;
                cbxLoaiViPham.DisplayMember = "LoaiViPham";
                cbxLoaiViPham.ValueMember = "LoaiViPham";
                cbxLoaiViPham.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại vi phạm: " + ex.Message);
            }
        }

        // SỬA HÀM NÀY: Để lưu vào dtViPhamGoc
        private void LoadData()
        {
            try
            {
                int selectedIndex = 0;
                if (grdVipham.SelectedRows.Count > 0)
                    selectedIndex = grdVipham.SelectedRows[0].Index;

                // Tải dữ liệu vào biến DataTable GỐC
                dtViPhamGoc = viPhamBLL.GetDanhSachViPham();
                grdVipham.DataSource = dtViPhamGoc; // Hiển thị tất cả ban đầu

                if (grdVipham.Rows.Count > 0)
                {
                    if (selectedIndex >= grdVipham.Rows.Count)
                        selectedIndex = grdVipham.Rows.Count - 1;
                    if (selectedIndex < 0) selectedIndex = 0;

                    grdVipham.ClearSelection();
                    grdVipham.Rows[selectedIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // HÀM LỌC MỚI (Thay thế btnTimkiem_Click)
        private void ApplyFilter(object sender, EventArgs e)
        {
            if (dtViPhamGoc == null) return;

            string tuKhoa = txtTimkiem.Text.Trim().ToLower();
            string loaiVP = cbxLoaiViPham.SelectedValue.ToString();

            DataView dv = dtViPhamGoc.DefaultView;
            string filter = "1=1";

            // 1. Lọc theo Loại
            if (loaiVP != "Tất cả")
            {
                filter += $" AND LoaiViPham = '{loaiVP}'";
            }

            // 2. Lọc theo Từ khóa (Tên lỗi)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                filter += $" AND CONVERT(TenLoi, 'System.String') LIKE '%{tuKhoa}%'";
            }

            dv.RowFilter = filter;
            grdVipham.DataSource = dv.ToTable();
        }

        private void SetViewMode(bool isEditing)
        {
            // Panel chi tiết
            txtTenloi.ReadOnly = !isEditing;
            txtMucphat.ReadOnly = !isEditing;
            cboLoaiViPham.Enabled = isEditing; // ComboBox Sửa
            txtMota.ReadOnly = !isEditing;
            txtMaloi.ReadOnly = true;

            // Nút
            btnLuu.Enabled = isEditing;
            btnUndo.Enabled = isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnThemloi.Enabled = !isEditing;

            // Các thành phần khác
            grdVipham.Enabled = !isEditing;
            groupBox2.Enabled = !isEditing;
            txtTimkiem.Enabled = !isEditing;
            cbxLoaiViPham.Enabled = !isEditing; // ComboBox Lọc
            btnTimkiem.Enabled = !isEditing;
        }

        private void HienThiChiTiet()
        {
            if (grdVipham.SelectedRows.Count > 0 && grdVipham.SelectedRows[0].DataBoundItem != null)
            {
                DataRowView drv = (DataRowView)grdVipham.SelectedRows[0].DataBoundItem;
                txtMaloi.Text = drv["MaLoi"].ToString();
                txtTenloi.Text = drv["TenLoi"].ToString();
                txtMucphat.Text = Convert.ToDecimal(drv["MucPhat"]).ToString("N0");
                cboLoaiViPham.SelectedItem = drv["LoaiViPham"].ToString();
                txtMota.Text = drv["MoTa"].ToString();
            }
            else
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtMaloi.Text = "(Tự động)";
            txtTenloi.Text = "";
            txtMucphat.Text = "0";
            cboLoaiViPham.SelectedIndex = 0;
            txtMota.Text = "";
        }

        private void grdVipham_SelectionChanged(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                HienThiChiTiet();
            }
        }

        private void btnThemloi_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            btnThemloi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            try
            {
                isProcessing = true;
                using (frmThemvipham frm = new frmThemvipham())
                {
                    frm.ShowDialog();
                    if (frm.DaThemThanhCong)
                    {
                        LoadData();
                    }
                }
            }
            finally
            {
                Application.DoEvents();
                SetViewMode(false);
                isProcessing = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdVipham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lỗi để sửa.");
                return;
            }
            isNew = false;
            SetViewMode(true);
            txtTenloi.Focus();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SetViewMode(false);
            HienThiChiTiet();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            try
            {
                isProcessing = true;
                btnLuu.Enabled = false;

                ViPhamDTO dto = new ViPhamDTO();
                dto.TenLoi = txtTenloi.Text.Trim();
                dto.MucPhat = decimal.Parse(txtMucphat.Text.Replace(",", ""));
                dto.LoaiViPham = cboLoaiViPham.SelectedItem.ToString();
                dto.MoTa = txtMota.Text.Trim();

                if (isNew)
                {
                    dto.MaLoi = 0;
                }
                else
                {
                    dto.MaLoi = int.Parse(txtMaloi.Text);
                }

                if (viPhamBLL.LuuViPham(dto))
                {
                    MessageBox.Show("Lưu thành công!");
                    LoadData();
                    isNew = false; // Reset cờ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                btnLuu.Enabled = true;
            }
            finally
            {
                Application.DoEvents();
                SetViewMode(false);
                isProcessing = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            if (grdVipham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lỗi để xóa.");
                return;
            }

            int maLoi = int.Parse(txtMaloi.Text);
            string tenLoi = txtTenloi.Text;

            if (MessageBox.Show($"Bạn có chắc muốn xóa lỗi '{tenLoi}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    isProcessing = true;
                    btnXoa.Enabled = false;
                    btnThemloi.Enabled = false;
                    btnSua.Enabled = false;

                    if (viPhamBLL.XoaViPham(maLoi))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                finally
                {
                    Application.DoEvents();
                    SetViewMode(false);
                    isProcessing = false;
                }
            }
        }

        // HÀM NÀY BÂY GIỜ LÀ RỖNG VÌ ĐÃ GỘP VÀO APPLYFILTER
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // ApplyFilter(sender, e); // Đã gán sự kiện Click
        }
        // === CÁC NÚT ĐIỀU HƯỚNG ===
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdVipham.Rows.Count > 0)
            {
                grdVipham.ClearSelection();
                grdVipham.CurrentCell = grdVipham[0, 0];
            }
            HienThiChiTiet();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdVipham.CurrentRow == null) return;
            int i = grdVipham.CurrentRow.Index;
            if (i > 0)
                grdVipham.CurrentCell = grdVipham[0, i - 1];
            HienThiChiTiet();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdVipham.CurrentRow == null) return;
            int i = grdVipham.CurrentRow.Index;
            if (i < grdVipham.RowCount - 1)
                grdVipham.CurrentCell = grdVipham[0, i + 1];
            HienThiChiTiet();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdVipham.Rows.Count > 0)
            {
                int i = grdVipham.RowCount - 1;
                grdVipham.CurrentCell = grdVipham[0, i];
            }
            HienThiChiTiet();
        }
    }
}