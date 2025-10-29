using Microsoft.Data.SqlClient;
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
    public partial class ucVitri : UserControl
    {
        private ViTriDAL viTriDAL;
        private List<ViTriDTO> danhSachViTri;
        private ViTriDTO viTriHienTai;
        private ViTriDTO viTriBackup;
        public ucVitri()
        {
            InitializeComponent();
            viTriDAL = new ViTriDAL();
            LoadDanhSachViTri();
            SetEditMode(false);
        }
        private void SetEditMode(bool isEdit)
        {
            // Bật/tắt chỉnh sửa các control
            txtMavitri.ReadOnly = !isEdit;
            txtTenvitri.ReadOnly = !isEdit;
            txtTang.ReadOnly = !isEdit;
            txtKe.ReadOnly = !isEdit;
            txtMota.ReadOnly = !isEdit;

            // Bật/tắt các nút
            btnLuu.Enabled = isEdit;
            btnUndo.Enabled = isEdit;
            btnThemvitrisach.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
        }
        private void BackupCurrentData()
        {
            if (viTriHienTai != null)
            {
                viTriBackup = new ViTriDTO
                {
                    MaViTri = viTriHienTai.MaViTri,
                    TenViTri = viTriHienTai.TenViTri,
                    Tang = viTriHienTai.Tang,
                    Ke = viTriHienTai.Ke,
                    MoTa = viTriHienTai.MoTa
                };
            }
        }
        private void RestoreBackupData()
        {
            if (viTriBackup != null)
            {
                viTriHienTai.TenViTri = viTriBackup.TenViTri;
                viTriHienTai.Tang = viTriBackup.Tang;
                viTriHienTai.Ke = viTriBackup.Ke;
                viTriHienTai.MoTa = viTriBackup.MoTa;
                HienThiChiTietVT();
            }
        }
        private void LoadDanhSachViTri()
        {
            try
            {
                danhSachViTri = viTriDAL.GetDanhSachViTri();
                grdVitrisach.AutoGenerateColumns = false;
                grdVitrisach.DataSource = danhSachViTri;
                if (danhSachViTri.Count > 0)
                {
                    grdVitrisach.Rows[0].Selected = true;
                    HienThiChiTietVT();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách vị trí: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiChiTietVT()
        {
            if (grdVitrisach.SelectedRows.Count == 0) return;
            viTriHienTai = (ViTriDTO)grdVitrisach.SelectedRows[0].DataBoundItem;
            txtMavitri.Text = viTriHienTai.MaViTri.ToString();
            txtTenvitri.Text = viTriHienTai.TenViTri;
            txtTang.Text = viTriHienTai.Tang.ToString();
            txtKe.Text = viTriHienTai.Ke.ToString();
            txtMota.Text = viTriHienTai.MoTa;
            SetEditMode(false); // Về chế độ xem
        }
        private void ucViTri_Load(object sender, EventArgs e)
        {
            grdVitrisach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVitrisach.MultiSelect = false;
            LoadDanhSachViTri();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            ViTriDAL dal = new ViTriDAL();
            List<ViTriDTO> list = dal.TimKiemViTri(txtTimkiem.Text);
            grdVitrisach.DataSource = list;
        }
        private void grdVitrisach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdVitrisach.Rows[e.RowIndex].Selected = true; // đảm bảo chọn đúng dòng
                viTriHienTai = (ViTriDTO)grdVitrisach.Rows[e.RowIndex].DataBoundItem;
                HienThiChiTietVT(); // cập nhật thông tin bên phải
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (viTriHienTai == null) return;

            try
            {
                // Cập nhật thông tin từ controls
                viTriHienTai.TenViTri = txtTenvitri.Text.Trim();
                viTriHienTai.Tang = int.Parse(txtTang.Text.Trim());
                viTriHienTai.Ke = int.Parse(txtKe.Text.Trim());
                viTriHienTai.MoTa = txtMota.Text.Trim();
                if (string.IsNullOrWhiteSpace(viTriHienTai.MaViTri))
                {
                    MessageBox.Show("Vui lòng nhập Mã Vị Trí hợp lệ");
                    return;
                }


                // Lưu vào database
                int result = viTriDAL.CapNhatViTri(viTriHienTai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật vị trí  thành công!");
                    SetEditMode(false);
                    LoadDanhSachViTri(); // Refresh danh sách
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
            if (viTriHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn vị trí cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa vị trí '{viTriHienTai.TenViTri}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int ketQua = viTriDAL.XoaViTri(viTriHienTai.MaViTri); // truyền string
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Xóa vị trí thành công!");
                        LoadDanhSachViTri();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vị trí (có thể đang được sử dụng).");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa vị trí: " + ex.Message);
                }
            }
        }

        private void btnThemkesach_Click(object sender, EventArgs e)
        {
            using (var frmThem = new frmThemvitri())
            {
                if (frmThem.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachViTri();
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            grdVitrisach.ClearSelection();
            grdVitrisach.CurrentCell = grdVitrisach[0, 0];
            HienThiChiTietVT();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdVitrisach.CurrentCell = grdVitrisach[0, i - 1];
            }
            HienThiChiTietVT();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.CurrentRow.Index;
            if (i < grdVitrisach.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp theo
            {
                grdVitrisach.CurrentCell = grdVitrisach[0, i + 1];
            }
            HienThiChiTietVT();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.RowCount - 1;
            grdVitrisach.CurrentCell = grdVitrisach[0, i];//Dòng  cuối cùng
            HienThiChiTietVT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdVitrisach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vị trí sách để sửa!");
                return;
            }

            viTriHienTai = (ViTriDTO)grdVitrisach.CurrentRow.DataBoundItem;
            if (viTriHienTai == null)
            {
                MessageBox.Show("Không thể xác định vị trí cần sửa.");
                return;
            }

            BackupCurrentData();
            SetEditMode(true);
        }
    }
}
