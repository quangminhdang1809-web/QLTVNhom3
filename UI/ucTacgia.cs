using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
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
    public partial class ucTacgia : UserControl
    {
        private TacGiaDAL tacGiaDAL;
        private List<TacGiaDTO> danhSachTacGia;
        private TacGiaDTO tacGiaHienTai;
        private TacGiaDTO tacGiaBackup;
        public ucTacgia()
        {
            InitializeComponent();
            tacGiaDAL = new TacGiaDAL();
            LoadDanhSachTacGia();
            SetEditMode(false);
        }
        private void SetEditMode(bool isEdit)
        {
            // Bật/tắt chỉnh sửa các control
            txtMatacgia.ReadOnly = !isEdit;
            txtHovaten.ReadOnly = !isEdit;
            dtpNamsinhtacgia.Enabled = isEdit;
            txtQuoctich.ReadOnly = !isEdit;

            // Bật/tắt các nút
            btnLuu.Enabled = isEdit;
            btnUndo.Enabled = isEdit;
            btnThemtacgia.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
        }
        private void BackupCurrentData()
        {
            if (tacGiaHienTai != null)
            {
                tacGiaBackup = new TacGiaDTO
                {
                    MaTacGia = tacGiaHienTai.MaTacGia,
                    TenTacGia = tacGiaHienTai.TenTacGia,
                    NamSinh = tacGiaHienTai.NamSinh,
                    QuocTich = tacGiaHienTai.QuocTich
                };
            }
        }
        private void RestoreBackupData()
        {
            if (tacGiaBackup != null)
            {
                tacGiaHienTai.TenTacGia = tacGiaBackup.TenTacGia;
                tacGiaHienTai.NamSinh = tacGiaBackup.NamSinh;
                tacGiaHienTai.QuocTich = tacGiaBackup.QuocTich;

                HienThiChiTietTG(); // Refresh hiển thị
            }
        }
        private void LoadDanhSachTacGia()
        {
            try
            {
                danhSachTacGia = tacGiaDAL.GetDanhSachTacGia();
                grdTacgia.AutoGenerateColumns = false;
                grdTacgia.DataSource = danhSachTacGia;
                if (danhSachTacGia.Count > 0)
                {
                    grdTacgia.Rows[0].Selected = true;
                    HienThiChiTietTG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiChiTietTG()
        {
            if (grdTacgia.SelectedRows.Count == 0) return;
            tacGiaHienTai = (TacGiaDTO)grdTacgia.SelectedRows[0].DataBoundItem;
            txtMatacgia.Text = tacGiaHienTai.MaTacGia.ToString();
            txtHovaten.Text = tacGiaHienTai.TenTacGia;
            if (tacGiaHienTai.NamSinh.HasValue)
            {
                dtpNamsinhtacgia.Value = new DateTime(tacGiaHienTai.NamSinh.Value, 1, 1);
            }
            else
            {
                dtpNamsinhtacgia.Value = DateTime.Now; // hoặc để mặc định
            }

            txtQuoctich.Text = tacGiaHienTai.QuocTich ?? "";
            SetEditMode(false); // Về chế độ xem
        }
        private void ucTacgia_Load(object sender, EventArgs e)
        {
            grdTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTacgia.MultiSelect = false;
            LoadDanhSachTacGia();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TacGiaDAL dal = new TacGiaDAL();
            List<TacGiaDTO> list = dal.TimKiemTacGia(txtTimkiem.Text);
            grdTacgia.DataSource = list;
        }
        private void grdTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    grdTacgia.Rows[e.RowIndex].Selected = true; // đảm bảo chọn đúng dòng
                    tacGiaHienTai = (TacGiaDTO)grdTacgia.Rows[e.RowIndex].DataBoundItem;
                    HienThiChiTietTG(); // cập nhật thông tin bên phải
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tacGiaHienTai == null) return;

            try
            {
                // Cập nhật thông tin từ controls
                tacGiaHienTai.TenTacGia = txtHovaten.Text.Trim();
                tacGiaHienTai.NamSinh = dtpNamsinhtacgia.Value.Year;
                tacGiaHienTai.QuocTich = txtQuoctich.Text.Trim();

                if (tacGiaHienTai.MaTacGia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập Mã Tác Giả hợp lệ");
                    return;
                }

                // Lưu vào database
                int result = tacGiaDAL.CapNhatTacGia(tacGiaHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật tác giả  thành công!");
                    SetEditMode(false);
                    LoadDanhSachTacGia(); // Refresh danh sách
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
            if (tacGiaHienTai == null) return;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa tác giả '{tacGiaHienTai.TenTacGia}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int ketQua = tacGiaDAL.XoaTacGia(tacGiaHienTai.MaTacGia);
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Xóa tác giả thành công!");
                        LoadDanhSachTacGia();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdTacgia.ClearSelection();
            grdTacgia.CurrentCell = grdTacgia[0, 0];
            HienThiChiTietTG();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdTacgia.CurrentCell = grdTacgia[0, i - 1];
            }
            HienThiChiTietTG();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.CurrentRow.Index;
            if (i < grdTacgia.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp the
            {
                grdTacgia.CurrentCell = grdTacgia[0, i + 1];
            }
            HienThiChiTietTG();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.RowCount - 1;
            grdTacgia.CurrentCell = grdTacgia[0, i];//Dòng  cuối cùng
            HienThiChiTietTG();
        }

        private void btnThemtacgia_Click(object sender, EventArgs e)
        {
            using (var frmThem = new frmThemtacgia())
            {
                if (frmThem.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachTacGia();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdTacgia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tác giả để sửa!");
                return;
            }

            tacGiaHienTai = (TacGiaDTO)grdTacgia.CurrentRow.DataBoundItem;
            if (tacGiaHienTai == null)
            {
                MessageBox.Show("Không thể xác định tác giả cần sửa.");
                return;
            }

            BackupCurrentData();
            SetEditMode(true);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMatacgia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
