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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucDocgiathuthu : UserControl
    {
        private DocGiaDAL docGiaDAL;
        private List<DocGiaDTO> danhSachDocGia;
        private DocGiaDTO docGiaHienTai;
        private DocGiaDTO docGiaBackup;
        public ucDocgiathuthu()
        {
            InitializeComponent();
            docGiaDAL = new DocGiaDAL();
            LoadDanhSachDocGia();
            LoadComboBoxes();
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
            txtIDAccount.ReadOnly = !isEdit;

            // Bật/tắt các nút
            btnLuu.Enabled = isEdit;
            btnUndo.Enabled = isEdit;
            btnThemdocgia.Enabled = !isEdit;
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

                HienThiChiTietDG(); // Refresh hiển thị
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
                danhSachDocGia = docGiaDAL.GetDanhSachDocGia();
                grdDocgia.AutoGenerateColumns = false;
                grdDocgia.DataSource = danhSachDocGia;
                if (danhSachDocGia.Count > 0)
                {
                    grdDocgia.Rows[0].Selected = true;
                    HienThiChiTietDG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DataTable dtAccounts = docGiaDAL.GetAllAccounts();
                if (dtAccounts.Rows.Count > 0)
                {
                    txtIDAccount.Text = dtAccounts.Rows[0]["IDAccount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void HienThiChiTietDG()
        {
            if (grdDocgia.SelectedRows.Count == 0) return;
            docGiaHienTai = (DocGiaDTO)grdDocgia.SelectedRows[0].DataBoundItem;
            txtMadocgia.Text = docGiaHienTai.MaDocGia.ToString();
            txtTendocgia.Text = docGiaHienTai.HoTen;
            dtpNgaysinh.Value = docGiaHienTai.NgaySinh;
            txtEmail.Text = docGiaHienTai.Email ?? "";
            txtDiachi.Text = docGiaHienTai.DiaChi ?? "";
            txtSdt.Text = docGiaHienTai.SoDienThoai ?? "";
            dtpNgaylapthe.Text = docGiaHienTai.NgayLapThe.ToString("dd/MM/yyyy");
            dtpNgayhethan.Text = docGiaHienTai.NgayHetHan.ToString("dd/MM/yyyy");
            txtIDAccount.Text = docGiaHienTai.IDAccount ?? "";

            // Chọn combobox
            if (cbbLoaidocgia.Items.Count > 0)
                cbbLoaidocgia.SelectedValue = docGiaHienTai.MaLoaiDG;

            SetEditMode(false); // Về chế độ xem
        }

        private void SetReadOnly(bool isReadOnly)
        {
            txtTendocgia.ReadOnly = isReadOnly;
            dtpNgaysinh.Enabled = !isReadOnly;
            txtEmail.ReadOnly = isReadOnly;
            txtDiachi.ReadOnly = isReadOnly;
            txtSdt.ReadOnly = isReadOnly;
            txtIDAccount.ReadOnly = isReadOnly;
            cbbLoaidocgia.Enabled = !isReadOnly;
        }
        private void ucDocgiathuthu_Load(object sender, EventArgs e)
        {
            grdDocgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDocgia.MultiSelect = false;
            LoadDanhSachDocGia();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DocGiaDAL dal = new DocGiaDAL();
            List<DocGiaDTO> list = dal.TimKiemDocGia(txtTimkiem.Text);
            grdDocgia.DataSource = list;
        }

        private void grdDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    grdDocgia.Rows[e.RowIndex].Selected = true; // đảm bảo chọn đúng dòng
                    docGiaHienTai = (DocGiaDTO)grdDocgia.Rows[e.RowIndex].DataBoundItem;
                    HienThiChiTietDG(); // cập nhật thông tin bên phải
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (docGiaHienTai == null) return;

            try
            {
                // Cập nhật thông tin từ controls
                docGiaHienTai.HoTen = txtTendocgia.Text.Trim();
                docGiaHienTai.NgaySinh = dtpNgaysinh.Value;
                docGiaHienTai.Email = txtEmail.Text.Trim();
                docGiaHienTai.DiaChi = txtDiachi.Text.Trim();
                docGiaHienTai.SoDienThoai = txtSdt.Text.Trim();
                docGiaHienTai.IDAccount = txtIDAccount.Text.Trim();
                docGiaHienTai.MaLoaiDG = cbbLoaidocgia.SelectedValue?.ToString();

                // Validate
                if (string.IsNullOrEmpty(docGiaHienTai.IDAccount))
                {
                    MessageBox.Show("Vui lòng nhập IDAccount");
                    return;
                }

                // Lưu vào database
                int result = docGiaDAL.CapNhatDocGia(docGiaHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật độc giả thành công!");
                    SetEditMode(false);
                    LoadDanhSachDocGia(); // Refresh danh sách
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
                    }
                }
            }
        }
    }
}
