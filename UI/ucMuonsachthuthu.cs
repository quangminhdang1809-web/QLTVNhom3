using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class ucMuonsachthuthu : UserControl
    {
        private DocGiaMuonDAL docGiaMuonDAL = new DocGiaMuonDAL();
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();
        private int soNgayMuonToiDa = 7;

        private DateTimePicker dtpNgay;
        private Rectangle _rectangle;

        public ucMuonsachthuthu()
        {
            InitializeComponent();

            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            grdThongtinsachmuon.Controls.Add(dtpNgay);
            dtpNgay.Visible = false;
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.TextChanged += new EventHandler(dtpNgay_TextChanged);

            // GÁN SỰ KIỆN TẢI ẢNH CHO CẢ 3 LƯỚI
            this.grdSachdangmuon.CellFormatting += new DataGridViewCellFormattingEventHandler(grdSachdangmuon_CellFormatting);
            this.drgTimkiemsach.CellFormatting += new DataGridViewCellFormattingEventHandler(drgTimkiemsach_CellFormatting);
            this.grdThongtinsachmuon.CellFormatting += new DataGridViewCellFormattingEventHandler(grdThongtinsachmuon_CellFormatting);
            CapNhatTrangThaiTimKiem();
        }

        private void ucMuonsachthuthu_Load(object sender, EventArgs e)
        {
            LoadThongTinDocGia();
        }

        private void LoadThongTinDocGia()
        {
            string maDG = txtMadocgia.Text.Trim();
            if (string.IsNullOrEmpty(maDG))
            {
                ResetForm();
                return;
            }

            try
            {
                DataTable dtDocGia = docGiaMuonDAL.LayThongTinDocGia(maDG);

                if (dtDocGia == null || dtDocGia.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy độc giả!");
                    ResetForm();
                    return;
                }

                DataRow docGia = dtDocGia.Rows[0];
                txtTendocgia.Text = docGia["HoTen"].ToString();
                DateTime ngayHetHan = Convert.ToDateTime(docGia["NgayHetHan"]);
                int soSachToiDa = Convert.ToInt32(docGia["SoSachToiDa"]);
                dtpNgayhethan.Value = ngayHetHan;
                this.soNgayMuonToiDa = Convert.ToInt32(docGia["SoNgayMuonToiDa"]);

                DataTable dtSachMuon = docGiaMuonDAL.GetSachDangMuonTheoDocGia(maDG);
                grdSachdangmuon.DataSource = dtSachMuon;

                // Ẩn cột tên file cho lưới Đang Mượn
                if (grdSachdangmuon.Columns.Contains("QuaHan"))
                    grdSachdangmuon.Columns["QuaHan"].Visible = false;
                if (grdSachdangmuon.Columns.Contains("AnhBia"))
                    grdSachdangmuon.Columns["AnhBia"].Visible = false;

                // Đếm sách
                int soSachDangMuon = dtSachMuon.Rows.Count;
                lblDangmuon.Text = soSachDangMuon.ToString();
                int soSachQuaHan = dtSachMuon.AsEnumerable().Count(row => Convert.ToBoolean(row["QuaHan"]));
                lblQuahan.Text = soSachQuaHan.ToString();

                // Kiểm tra trạng thái
                if (DateTime.Now > ngayHetHan)
                    lblThongbao.Text = "Thẻ đã hết hạn! Không thể mượn.";
                else if (soSachQuaHan > 0)
                    lblThongbao.Text = "Có sách quá hạn! Không thể mượn.";
                else if (soSachDangMuon >= soSachToiDa)
                    lblThongbao.Text = $"Đã mượn tối đa ({soSachToiDa}) quyển.";
                else
                    lblThongbao.Text = "Thẻ còn hạn. Có thể mượn.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã độc giả không hợp lệ. Vui lòng kiểm tra lại. \nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetForm();

            }
            CapNhatTrangThaiTimKiem();
        }


        private void txtMadocgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadThongTinDocGia();
            }
        }

        private void grdThongtinsachmuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == grdThongtinsachmuon.Columns["colHantra"].Index))
            {
                _rectangle = grdThongtinsachmuon.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpNgay.Size = new Size(_rectangle.Width, _rectangle.Height);
                dtpNgay.Location = new Point(_rectangle.X, _rectangle.Y);

                DateTime ngayHienTai = DateTime.Now.Date;
                DateTime ngayTraToiDa = ngayHienTai.AddDays(this.soNgayMuonToiDa);

                dtpNgay.MinDate = ngayHienTai;
                dtpNgay.MaxDate = ngayTraToiDa;
                dtpNgay.Visible = true;

                object cellValue = grdThongtinsachmuon.CurrentCell.Value;
                DateTime giaTriTrongO;

                if (cellValue != null && DateTime.TryParse(cellValue.ToString(), out giaTriTrongO))
                {
                    if (giaTriTrongO > dtpNgay.MaxDate)
                        dtpNgay.Value = dtpNgay.MaxDate;
                    else if (giaTriTrongO < dtpNgay.MinDate)
                        dtpNgay.Value = dtpNgay.MinDate;
                    else
                        dtpNgay.Value = giaTriTrongO;
                }
                else
                {
                    dtpNgay.Value = ngayTraToiDa;
                }
            }
            else
            {
                dtpNgay.Visible = false;
            }
        }

        private void dtpNgay_TextChanged(object sender, EventArgs e)
        {
            grdThongtinsachmuon.CurrentCell.Value = dtpNgay.Text;
            dtpNgay.Visible = false;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            {
                string keyword = txtTimkiem.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    drgTimkiemsach.Visible = false;
                    drgTimkiemsach.DataSource = null;
                }
                else
                {
                    DataTable dt = phieuMuonDAL.TimKiemSach(keyword);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Ẩn cột tên file (cột AnhBia từ DAL)
                        if (drgTimkiemsach.Columns.Contains("AnhBia"))
                            drgTimkiemsach.Columns["AnhBia"].Visible = false;

                        drgTimkiemsach.DataSource = dt;
                        drgTimkiemsach.Visible = true;
                    }
                    else
                    {
                        drgTimkiemsach.Visible = false;
                        drgTimkiemsach.DataSource = null;
                    }
                }
            }
        }

        // SỬA LỖI: CỘT ẨN CHO LƯỚI CHUẨN BỊ MƯỢN LÀ "colAnhBiaFileName"
        private void drgTimkiemsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = drgTimkiemsach.Rows[e.RowIndex];

                object maSachValue = selectedRow.Cells["MaSach"].Value;
                if (maSachValue == null || maSachValue == DBNull.Value)
                {
                    MessageBox.Show("Lỗi: Không thể đọc mã sách. Vui lòng thử lại.");
                    return;
                }
                string maSach = maSachValue.ToString();

                // Kiểm tra trùng
                foreach (DataGridViewRow row in grdThongtinsachmuon.Rows)
                {
                    if (row.Cells["colMasachmuon"].Value != null && row.Cells["colMasachmuon"].Value.ToString() == maSach)
                    {
                        MessageBox.Show("Sách này đã được thêm vào danh sách mượn.", "Thông báo");
                        AnLuoiTimKiem();
                        return;
                    }
                }

                int n = grdThongtinsachmuon.Rows.Add();
                grdThongtinsachmuon.Rows[n].Cells["colTensachmuon"].Value = selectedRow.Cells["TenDauSach"].Value?.ToString();
                grdThongtinsachmuon.Rows[n].Cells["colMasachmuon"].Value = selectedRow.Cells["MaSach"].Value?.ToString();
                grdThongtinsachmuon.Rows[n].Cells["colNamxb"].Value = selectedRow.Cells["NamXuatBan"].Value?.ToString();
                grdThongtinsachmuon.Rows[n].Cells["colTacgia"].Value = selectedRow.Cells["TacGia"].Value?.ToString();
                string tenFileAnh = selectedRow.Cells["AnhBia"].Value?.ToString();
                // Gán tên file ảnh vào cột ẩn colAnhBiaFileName
                // LƯU Ý: Nếu không có cột này trong Designer sẽ bị lỗi CS0103.
                if (grdThongtinsachmuon.Columns.Contains("colAnhBiaFileName"))
                {
                    grdThongtinsachmuon.Rows[n].Cells["colAnhBiaFileName"].Value = tenFileAnh;
                }

                DateTime hanTraMacDinh = DateTime.Now.Date.AddDays(this.soNgayMuonToiDa);
                grdThongtinsachmuon.Rows[n].Cells["colHantra"].Value = hanTraMacDinh.ToShortDateString();

                AnLuoiTimKiem();
            }
        }


        private void AnLuoiTimKiem()
        {
            txtTimkiem.Text = "";
            drgTimkiemsach.DataSource = null;
            drgTimkiemsach.Visible = false;
            txtTimkiem.Focus();
        }

        private void btnXemphieumuon_Click(object sender, EventArgs e)
        {
            string maDG = txtMadocgia.Text.Trim();
            string tenDG = txtTendocgia.Text.Trim();

            DataTable dtSachMuon = new DataTable();

            dtSachMuon.Columns.Add("Tên sách");
            dtSachMuon.Columns.Add("Mã sách");
            dtSachMuon.Columns.Add("Năm xuất bản");
            dtSachMuon.Columns.Add("Hạn trả");

            foreach (DataGridViewRow row in grdThongtinsachmuon.Rows)
            {
                if (row.IsNewRow) continue;
                dtSachMuon.Rows.Add(
                    row.Cells["colTensachmuon"].Value?.ToString(),
                    row.Cells["colMasachmuon"].Value?.ToString(),
                    row.Cells["colNamxb"].Value?.ToString(),
                    row.Cells["colHantra"].Value?.ToString()
                );
            }

            frmXacnhanmuonsach frm = new frmXacnhanmuonsach(maDG, tenDG, dtSachMuon);
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadThongTinDocGia();
                grdThongtinsachmuon.Rows.Clear();
            }
        }

        private void ResetForm()
        {
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            dtpNgayhethan.Value = DateTime.Now;
            lblThongbao.Text = "Vui lòng nhập mã độc giả";
            lblDangmuon.Text = "0";
            lblQuahan.Text = "0";
            this.soNgayMuonToiDa = 7;
            grdSachdangmuon.DataSource = null;
            grdThongtinsachmuon.Rows.Clear();
            AnLuoiTimKiem();
            txtMadocgia.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn làm mới toàn bộ form không?",
                                           "Xác nhận làm mới",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (grdThongtinsachmuon.CurrentRow != null && !grdThongtinsachmuon.CurrentRow.IsNewRow)
            {
                string tenSach = grdThongtinsachmuon.CurrentRow.Cells["colTensachmuon"].Value?.ToString() ?? "sách này";

                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{tenSach}' khỏi danh sách mượn không?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    grdThongtinsachmuon.Rows.Remove(grdThongtinsachmuon.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách trong danh sách để xóa.", "Chưa chọn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // ▼▼▼ CÁC HÀM XỬ LÝ ẢNH ▼▼▼

        // Hàm chung để tải ảnh
        private void LoadImageToCell(DataGridViewCellFormattingEventArgs e, string tenFileAnh)
        {
            if (string.IsNullOrEmpty(tenFileAnh))
            {
                e.Value = null;
                return;
            }

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, "Image", tenFileAnh.Trim());
                if (File.Exists(fullPath))
                {
                    using (Image tempImage = Image.FromFile(fullPath))
                    {
                        e.Value = new Bitmap(tempImage);
                    }
                }
                else
                {
                    e.Value = null;
                }
            }
            catch
            {
                e.Value = null;
            }
        }

        // Sự kiện cho lưới SÁCH ĐANG MƯỢN
        private void grdSachdangmuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdSachdangmuon.Columns[e.ColumnIndex].Name == "colAnhbia")
            {
                string tenFileAnh = grdSachdangmuon.Rows[e.RowIndex].Cells["AnhBia"].Value?.ToString();
                LoadImageToCell(e, tenFileAnh);
            }
        }

        // Sự kiện cho lưới TÌM KIẾM
        private void drgTimkiemsach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (drgTimkiemsach.Columns[e.ColumnIndex].Name == "colAnhbiatrongtimkiem")
            {
                string tenFileAnh = drgTimkiemsach.Rows[e.RowIndex].Cells["AnhBia"].Value?.ToString();
                LoadImageToCell(e, tenFileAnh);
            }
        }

        // Sự kiện cho lưới SÁCH CHUẨN BỊ MƯỢN
        private void grdThongtinsachmuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdThongtinsachmuon.Columns[e.ColumnIndex].Name == "AnhBia")
            {
                string tenFileAnh = grdThongtinsachmuon.Rows[e.RowIndex].Cells["colAnhBiaFileName"].Value?.ToString();
                LoadImageToCell(e, tenFileAnh);
            }
        }
        private void CapNhatTrangThaiTimKiem()
        {
            if (lblThongbao.Text == "Thẻ còn hạn. Có thể mượn.")
            {
                // === TRƯỜNG HỢP HỢP LỆ ===

                // 1. Cho phép nhập liệu
                txtTimkiem.ReadOnly = false;

                // 2. Đổi lại màu nền trắng (nếu bạn muốn)
                txtTimkiem.BackColor = SystemColors.Window;

                txtTimkiem.Focus();
            }
            else
            {
                // === TRƯỜNG HỢP KHÔNG HỢP LỆ ===

                // 1. KHÓA nhập liệu
                txtTimkiem.ReadOnly = true;

                // 2. (Nên làm) Xóa từ khóa tìm kiếm cũ và kết quả cũ
                txtTimkiem.Text = "";
                drgTimkiemsach.Visible = false;
                drgTimkiemsach.DataSource = null;

                // 3. (Nên làm) Đổi màu nền sang xám nhạt để báo hiệu
                txtTimkiem.BackColor = SystemColors.ControlLight;
            }
        }

        private void lblDangmuon_Click(object sender, EventArgs e)
        {

        }

        private void lblThongbao_Click(object sender, EventArgs e)
        {

        }
    }
}