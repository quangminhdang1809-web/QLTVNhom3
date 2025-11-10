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
    public partial class ucMuonsachthuthu : UserControl
    {
        private DocGiaMuonDAL docGiaMuonDAL = new DocGiaMuonDAL();
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        // 💡 1. THÊM CÁC BIẾN CẦN THIẾT
        private int soNgayMuonToiDa = 7; // Lưu số ngày mượn tối đa, mặc định là 7
                                         // Dùng cho vị trí dtpNgay
                                         // Dùng cho ô Hạn trả

        public ucMuonsachthuthu()
        {
            InitializeComponent();

            // 💡 2. KHỞI TẠO DATETIMEPICKER ẨN
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            grdThongtinsachmuon.Controls.Add(dtpNgay);
            dtpNgay.Visible = false;
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.TextChanged += new EventHandler(dtpNgay_TextChanged);
        }

        private void ucMuonsachthuthu_Load(object sender, EventArgs e)
        {
            LoadThongTinDocGia();
            // LoadSachDangMuon(); // 💡 3. BỎ DÒNG LẶP NÀY
        }

        private void LoadThongTinDocGia()
        {
            string maDG = txtMadocgia.Text.Trim();
            if (string.IsNullOrEmpty(maDG))
            {
                // Xóa thông tin nếu không nhập mã
                txtTendocgia.Text = "";
                lblThongbao.Text = "Vui lòng nhập mã độc giả";
                lblDangmuon.Text = "0";
                lblQuahan.Text = "0";
                grdSachdangmuon.DataSource = null; // Xóa lưới
                this.soNgayMuonToiDa = 7; // Reset về mặc định
                return;
            }

            // 1. Lấy thông tin cơ bản của độc giả
            DataTable dtDocGia = docGiaMuonDAL.LayThongTinDocGia(maDG);

            if (dtDocGia == null || dtDocGia.Rows.Count == 0)
            {
                // ... (code xử lý không tìm thấy độc giả) ...
                this.soNgayMuonToiDa = 7; // Reset về mặc định
                return;
            }

            // 2. Tìm thấy độc giả -> Trích xuất thông tin
            DataRow docGia = dtDocGia.Rows[0];
            txtTendocgia.Text = docGia["HoTen"].ToString();
            DateTime ngayHetHan = Convert.ToDateTime(docGia["NgayHetHan"]);
            int soSachToiDa = Convert.ToInt32(docGia["SoSachToiDa"]);
            dtpNgayhethan.Value = ngayHetHan;

            // 💡 4. LẤY SỐ NGÀY MƯỢN TỐI ĐA (TỪ DAL)
            this.soNgayMuonToiDa = Convert.ToInt32(docGia["SoNgayMuonToiDa"]);

            // 3. Lấy thông tin sách đang mượn (đã tích hợp)
            DataTable dtSachMuon = docGiaMuonDAL.GetSachDangMuonTheoDocGia(maDG);
            grdSachdangmuon.DataSource = dtSachMuon;

            // ... (code ẩn cột QuaHan, đếm sách, logic lblThongbao) ...
            if (grdSachdangmuon.Columns["QuaHan"] != null)
            {
                grdSachdangmuon.Columns["QuaHan"].Visible = false;
            }
            int soSachDangMuon = dtSachMuon.Rows.Count;
            lblDangmuon.Text = soSachDangMuon.ToString();
            int soSachQuaHan = 0;
            foreach (DataRow row in dtSachMuon.Rows)
            {
                if (Convert.ToBoolean(row["QuaHan"]))
                    soSachQuaHan++;
            }
            lblQuahan.Text = soSachQuaHan.ToString();
            if (DateTime.Now > ngayHetHan)
            {
                lblThongbao.Text = "Thẻ đã hết hạn! Không thể mượn.";
            }
            else if (soSachQuaHan > 0)
            {
                lblThongbao.Text = "Có sách quá hạn! Không thể mượn.";
            }
            else if (soSachDangMuon >= soSachToiDa)
            {
                lblThongbao.Text = $"Đã mượn tối đa ({soSachToiDa}) quyển.";
            }
            else
            {
                lblThongbao.Text = "Thẻ còn hạn. Có thể mượn.";
            }
        }

        // 💡 5. XÓA BỎ HÀM LoadSachDangMuon() VÌ BỊ LẶP
        // private void LoadSachDangMuon() { ... }

        private void txtMadocgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng 'ding'
                LoadThongTinDocGia();      // 💡 6. CHỈ CẦN GỌI HÀM NÀY
                // LoadSachDangMuon();     // Bỏ dòng lặp
            }
        }

        // (Hàm grdThongtinsachmuon_CellClick của bạn đã đúng, giữ nguyên)
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

                if (grdThongtinsachmuon.CurrentCell.Value != null)
                {
                    DateTime giaTriTrongO;
                    if (DateTime.TryParse(grdThongtinsachmuon.CurrentCell.Value.ToString(), out giaTriTrongO))
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
                    dtpNgay.Value = ngayTraToiDa;
                }
            }
            else
            {
                dtpNgay.Visible = false;
            }
        }

        // (Hàm dtpNgay_TextChanged của bạn đã đúng, giữ nguyên)
        private void dtpNgay_TextChanged(object sender, EventArgs e)
        {
            grdThongtinsachmuon.CurrentCell.Value = dtpNgay.Text;
        }

        // (Hàm txtTimkiem_TextChanged của bạn đã đúng, giữ nguyên)
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
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

        // (Hàm drgTimkiemsach_CellDoubleClick của bạn đã đúng, giữ nguyên)
        private void drgTimkiemsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = drgTimkiemsach.Rows[e.RowIndex];
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
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
                DateTime hanTraMacDinh = DateTime.Now.Date.AddDays(this.soNgayMuonToiDa);
                grdThongtinsachmuon.Rows[n].Cells["colHantra"].Value = hanTraMacDinh.ToShortDateString();
                AnLuoiTimKiem();
            }
        }

        // (Hàm AnLuoiTimKiem của bạn đã đúng, giữ nguyên)
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

            // 💡 7. SỬA TÊN CỘT ĐỂ KHỚP VỚI 'frmXacnhanmuonsach'
            // Form xác nhận (theo code tôi gửi bạn) sẽ đọc "TenDauSach", "MaSach", và "NamXuatBan"
            dtSachMuon.Columns.Add("Tên sách");
            dtSachMuon.Columns.Add("Mã sách");
            dtSachMuon.Columns.Add("Năm xuất bản");
            // Không cần cột "Hạn trả", vì form xác nhận tự tính toán lại

            foreach (DataGridViewRow row in grdThongtinsachmuon.Rows)
            {
                if (row.IsNewRow) continue;
                dtSachMuon.Rows.Add(
                    row.Cells["colTensachmuon"].Value?.ToString(),
                    row.Cells["colMasachmuon"].Value?.ToString(),
                    row.Cells["colNamxb"].Value?.ToString()
                );
            }

            // Gọi form xác nhận và truyền dữ liệu
            frmXacnhanmuonsach frm = new frmXacnhanmuonsach(maDG, tenDG, dtSachMuon);
            DialogResult result = frm.ShowDialog();

            // 1. Kiểm tra nếu người dùng nhấn "Xác nhận" (DialogResult.OK)
            if (result == DialogResult.OK)
            {
                // 2. RELOAD: Tải lại toàn bộ thông tin độc giả (bao gồm lưới sách đang mượn)
                LoadThongTinDocGia();

                // 3. Xóa lưới sách "chuẩn bị mượn" vì đã mượn xong
                grdThongtinsachmuon.Rows.Clear();
            }
        }
        // Hàm này làm sạch toàn bộ form
        private void ResetForm()
        {
            // 1. Xóa thông tin độc giả
            txtMadocgia.Text = "";
            txtTendocgia.Text = "";
            dtpNgayhethan.Value = DateTime.Now; // Reset về ngày hiện tại
            lblThongbao.Text = "Vui lòng nhập mã độc giả";
            lblDangmuon.Text = "0";
            lblQuahan.Text = "0";
            this.soNgayMuonToiDa = 7; // Reset số ngày mượn về mặc định

            // 2. Xóa lưới sách ĐANG MƯỢN
            grdSachdangmuon.DataSource = null;

            // 3. Xóa lưới sách CHUẨN BỊ MƯỢN
            grdThongtinsachmuon.Rows.Clear();

            // 4. Xóa ô tìm kiếm sách và ẩn kết quả (nếu có)
            AnLuoiTimKiem();

            // 5. Đưa con trỏ chuột về ô Mã độc giả
            txtMadocgia.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn làm mới toàn bộ form không?\nTất cả thông tin độc giả và sách đã chọn sẽ bị xóa.",
                                      "Xác nhận làm mới",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Gọi hàm làm sạch toàn bộ form
                ResetForm();
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có dòng nào đang được chọn không
            if (grdThongtinsachmuon.CurrentRow != null && !grdThongtinsachmuon.CurrentRow.IsNewRow)
            {
                // 2. Lấy tên sách để hỏi xác nhận (cho thân thiện hơn)
                // (Đảm bảo tên cột của bạn là 'colTensachmuon')
                string tenSach = grdThongtinsachmuon.CurrentRow.Cells["colTensachmuon"].Value?.ToString() ?? "sách này";

                // 3. Hỏi xác nhận
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{tenSach}' khỏi danh sách mượn không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // 4. Xóa dòng đang chọn
                    grdThongtinsachmuon.Rows.Remove(grdThongtinsachmuon.CurrentRow);
                }
            }
            else
            {
                // Thông báo nếu chưa chọn sách
                MessageBox.Show("Vui lòng chọn một cuốn sách trong danh sách để xóa.", "Chưa chọn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}