using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucTheloai : UserControl
    {
        private TheLoaiDAL theLoaiDAL = new TheLoaiDAL();
        private List<TheLoaiDTO> danhSachTheLoai;
        private TheLoaiDTO theLoaiHienTai;
        private TheLoaiDTO theLoaiBackup;

        public ucTheloai()
        {
            InitializeComponent();
            theLoaiDAL = new TheLoaiDAL();
            LoadDanhSachTheLoai();
            SetEditMode(false);
        }
        private void SetEditMode(bool isEdit)
        {
            // Bật/tắt chỉnh sửa các control
            txtMatheloai.ReadOnly = true;
            txtTentheloai.ReadOnly = !isEdit;

            // Bật/tắt các nút
            btnLuu.Enabled = isEdit;
            btnUndo.Enabled = isEdit;
            btnThemtheloai.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
        }
        private void BackupCurrentData()
        {
            if (theLoaiHienTai != null)
            {
                theLoaiBackup = new TheLoaiDTO
                {
                    MaTheLoai = theLoaiHienTai.MaTheLoai,
                    TenTheLoai = theLoaiHienTai.TenTheLoai,
                };
            }
        }
        private void HienThiChiTietTL()
        {
            if (grdTheloai.SelectedRows.Count == 0) return;
            theLoaiHienTai = (TheLoaiDTO)grdTheloai.SelectedRows[0].DataBoundItem;
            txtMatheloai.Text = theLoaiHienTai.MaTheLoai.ToString();
            txtTentheloai.Text = theLoaiHienTai.TenTheLoai;
            SetEditMode(false); // Về chế độ xem
        }
        private void RestoreBackupData()
        {
            if (theLoaiBackup != null && theLoaiHienTai != null)
            {
                theLoaiHienTai.MaTheLoai = theLoaiBackup.MaTheLoai;
                theLoaiHienTai.TenTheLoai = theLoaiBackup.TenTheLoai;
                HienThiChiTietTL();
            }
        }

        private void LoadDanhSachTheLoai()
        {
            try
            {
                danhSachTheLoai = theLoaiDAL.GetDanhSachTheLoai();
                grdTheloai.AutoGenerateColumns = false;
                grdTheloai.DataSource = danhSachTheLoai;
                if (danhSachTheLoai.Count > 0)
                {
                    grdTheloai.Rows[0].Selected = true;
                    HienThiChiTietTL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ucTheloai_Load(object sender, EventArgs e)
        {
            grdTheloai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTheloai.MultiSelect = false;
            LoadDanhSachTheLoai();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (theLoaiHienTai == null) return;

            try
            {
                // Cập nhật thông tin từ controls
                theLoaiHienTai.TenTheLoai = txtTentheloai.Text.Trim();

                // Lưu vào database
                int result = theLoaiDAL.CapNhatTheLoai(theLoaiHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thể loại  thành công!");
                    SetEditMode(false);
                    LoadDanhSachTheLoai(); // Refresh danh sách
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

        // === BUTTON THÊM ===
        private void btnThemtheloai_Click(object sender, EventArgs e)
        {
            using (var frmThem = new frmThemtheloai())
            {
                if (frmThem.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachTheLoai();
                }
            }
        }
        

        // === BUTTON XÓA ===
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grdTheloai.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại để xóa!");
                return;
            }

            int ma = Convert.ToInt32(grdTheloai.CurrentRow.Cells["MaTheLoai"].Value);

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa thể loại này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (theLoaiDAL.XoaTheLoai(ma) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachTheLoai();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdTheloai.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại để sửa!");
                return;
            }

            theLoaiHienTai = (TheLoaiDTO)grdTheloai.CurrentRow.DataBoundItem;
            if (theLoaiHienTai == null)
            {
                MessageBox.Show("Không thể xác định thể loại cần sửa.");
                return;
            }

            BackupCurrentData();
            SetEditMode(true);
        }

        // === BUTTON TÌM KIẾM ===
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TheLoaiDAL dal = new TheLoaiDAL();
            List<TheLoaiDTO> list = dal.TimKiemTheLoai(txtTimkiem.Text);
            grdTheloai.DataSource = list;
        }

        // === CÁC NÚT ĐIỀU HƯỚNG ===
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdTheloai.Rows.Count > 0)
            {
                grdTheloai.ClearSelection();
                grdTheloai.CurrentCell = grdTheloai[0, 0];
            }
            HienThiChiTietTL();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdTheloai.CurrentRow == null) return;
            int i = grdTheloai.CurrentRow.Index;
            if (i > 0)
                grdTheloai.CurrentCell = grdTheloai[0, i - 1];
            HienThiChiTietTL();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdTheloai.CurrentRow == null) return;
            int i = grdTheloai.CurrentRow.Index;
            if (i < grdTheloai.RowCount - 1)
                grdTheloai.CurrentCell = grdTheloai[0, i + 1];
            HienThiChiTietTL();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdTheloai.Rows.Count > 0)
            {
                int i = grdTheloai.RowCount - 1;
                grdTheloai.CurrentCell = grdTheloai[0, i];
            }
            HienThiChiTietTL();
        }

        // === SỰ KIỆN CLICK LÊN LƯỚI ===
        private void grdTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    grdTheloai.Rows[e.RowIndex].Selected = true; // đảm bảo chọn đúng dòng
                    theLoaiHienTai = (TheLoaiDTO)grdTheloai.Rows[e.RowIndex].DataBoundItem;
                    HienThiChiTietTL(); // cập nhật thông tin bên phải
                }
            }
        }
    }
}
