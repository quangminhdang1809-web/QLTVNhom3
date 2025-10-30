using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer; 

namespace QLTVNhom3
{
    public partial class frmThemsach : Form
    {
        private DBHelper db = new DBHelper();
        private SachBLL sachBLL;
        private List<TacGiaDTO> danhSachTacGia;
        private Timer searchTimer;

        public frmThemsach()
        {
            InitializeComponent();
            KhoiTaoForm();
            ThietLapTimerTimKiem();
        }

        private void KhoiTaoForm()
        {
            // Load combobox
            cbbTheloai.DataSource = sachBLL.LayDanhSachTheLoai();
            cbbTheloai.DisplayMember = "TenTheLoai";
            cbbTheloai.ValueMember = "MaTheLoai";
            
            cbbVitri.DataSource = sachBLL.LayDanhSachViTri();
            cbbVitri.DisplayMember = "TenViTri";
            cbbVitri.ValueMember = "MaViTri";

            grdTacgia.AutoGenerateColumns = true;
            grdTimkiemtacgia.AutoGenerateColumns = true;
            grdTimkiemtacgia.Visible = false;
        }
        private void ThietLapTimerTimKiem()
        {
            searchTimer = new Timer { Interval = 500 };
            searchTimer.Tick += (s, e) =>
            {
                searchTimer.Stop();
                TimKiemTacGia(txtTacgia.Text);
            };
        }

        private void SetupDataGridViews()
        {

            // DataGridView tác giả đã chọn (HIỆN TẤT CẢ)
            if (grdTacgia != null)
            {
                grdTacgia.AutoGenerateColumns = false;
                grdTacgia.Columns.Clear();

                grdTacgia.Columns.Add("MaTacGia", "Mã tác giả");
                grdTacgia.Columns.Add("HoTen", "Họ và tên");
                grdTacgia.Columns.Add("NamSinh", "Năm sinh");
            }

            // DataGridView tìm kiếm tác giả (ẨN NĂM SINH)
            if (grdTimkiemtacgia != null)
            {
                grdTimkiemtacgia.AutoGenerateColumns = false;
                grdTimkiemtacgia.Columns.Clear();

                grdTimkiemtacgia.Columns.Add("MaTacGia", "Mã tác giả");
                grdTimkiemtacgia.Columns.Add("HoTen", "Họ và tên");
                var namSinhColumn = grdTimkiemtacgia.Columns.Add("NamSinh", "Năm sinh");
                namSinhColumn.Visible = false; // SỬA: Đặt Visible sau khi tạo column
            }

            // DataGridView bản sách
            if (grdSach != null)
            {
                grdSach.AutoGenerateColumns = false;
                grdSach.Columns.Clear();
                grdSach.Columns.Add("MaSach", "Mã sách");
                grdSach.Columns.Add("MaTinhTrang", "Trạng thái");
            }
        }

        // ==================== XỬ LÝ SỰ KIỆN CHÍNH ====================

        private void btnTaoMaSach_Click(object sender, EventArgs e)
        {
            if (!KiemTraSoLuongHopLe()) return;

            int soLuong = int.Parse(txtSoluong.Text);
            var danhSachBanSach = TaoDanhSachBanSach(soLuong);

            grdSach.DataSource = danhSachBanSach;
            MessageBox.Show($"Đã tạo {soLuong} mã sách thành công!", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuHopLe()) return;

            try
            {
                var sach = TaoDoiTuongSach();

                bool success = sachBLL.ThemDauSachMoi(sach);
                if (success)
                {
                    MessageBox.Show("Thêm sách thành công!", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==================== TÌM KIẾM TÁC GIẢ TỰ ĐỘNG ====================

        private void txtTacgia_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            TimKiemTacGiaTuDong();
        }

        private async void TimKiemTacGia(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa))
            {
                grdTimkiemtacgia.DataSource = null;
                return;
            }
                var ketQuaTimKiem = await Task.Run(() => sachBLL.TimKiemTacGia(tuKhoa));
                grdTimkiemtacgia.DataSource = null;
                grdTimkiemtacgia.DataSource = ketQua;
                grdTimkiemtacgia.Visible = ketQua.Count > 0;
        }
         

        private void grdTimkiemtacgia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var tacGia = (TacGiaDTO)grdTimkiemtacgia.Rows[e.RowIndex].DataBoundItem;
            danhSachTacGia.Add(tacGia);
            grdTacgia.DataSource = null;
            grdTacgia.DataSource = danhSachTacGia;
            grdTimkiemtacgia.Visible = false;
            txtTacgia.Clear();
        }

        private void ThemTacGiaTuTimKiem(TacGiaDTO tacGia)
        {
            if (danhSachTacGia.Exists(tg => tg.MaTacGia == tacGia.MaTacGia))
            {
                MessageBox.Show("Tác giả này đã được thêm!");
                return;
            }
            // Thêm vào danh sách chính - CÙNG DATA SOURCE
            danhSachTacGia.Add(tacGia);

            // Cập nhật hiển thị
            grdTacgia.DataSource = null;
            grdTacgia.DataSource = danhSachTacGia;

            // Clear ô tìm kiếm
            txtTacgia.Clear();
            grdTimkiemtacgia.DataSource = null;

            MessageBox.Show($"Đã thêm tác giả: {tacGia.HoTen}", "Thông báo");

        }

        // ==================== PHƯƠNG THỨC HỖ TRỢ ====================

        private bool KiemTraSoLuongHopLe()
        {
            if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return false;
            }

            if (!int.TryParse(txtSoluong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return false;
            }

            if (soLuong > 20)
            {
                MessageBox.Show("Số lượng tối đa là 20!");
                return false;
            }

            return true;
        }
        private bool KiemTraDuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtTensach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!");
                return false;
            }

            if (danhSachTacGia.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một tác giả!");
                return false;
            }

            if (grdSach.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo mã sách' trước khi lưu!");
                return false;
            }

            return true;
        }

        private List<BanSachDTO> TaoDanhSachBanSach(int soLuong)
        {
            var danhSach = new List<BanSachDTO>();
            for (int i = 1; i <= soLuong; i++)
            {
                danhSach.Add(new BanSachDTO
                {
                    MaSach = $"{txtMadausach.Text}_{i.ToString().PadLeft(3, '0')}",
                    MaDauSach = txtMadausach.Text,
                    MaTinhTrang = 1
                });
            }
            return danhSach;
        }

        private SachDTO TaoDoiTuongSach()
        {
            // SỬA LẠI PHẦN NÀY - Đảm bảo kiểu dữ liệu khớp
            return new SachDTO
            {
                MaDauSach = txtMadausach.Text,
                TenDauSach = txtTensach.Text,
                MaTheLoai = (int)cbbTheloai.SelectedValue,
                NhaXuatBan = txtNxb.Text,
                NamXuatBan = short.Parse(dtpNamxb.Text), // SỬA: dtpNamxb phải là TextBox hoặc DateTimePicker
                SoLuongTong = int.Parse(txtSoluong.Text),
                MaViTri = cbbVitri.Text,
                DanhSachTacGia = danhSachTacGia,
                DanhSachBanSach = LayDanhSachBanSachTuGrid()
            };
        }

        private List<BanSachDTO> LayDanhSachBanSachTuGrid()
        {
            var danhSach = new List<BanSachDTO>();
            foreach (DataGridViewRow row in grdSach.Rows)
            {
                if (row.DataBoundItem is BanSachDTO banSach)
                {
                    danhSach.Add(banSach);
                }
            }
            return danhSach;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            searchTimer?.Stop();
            searchTimer?.Dispose();
            base.OnFormClosing(e);
        }

        private void btnXoatg_Click(object sender, EventArgs e)
        {
            if (grdTacgia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa!");
                return;
            }

            var selectedTacGia = grdTacgia.SelectedRows[0].DataBoundItem as TacGiaDTO;
            if (selectedTacGia != null)
            {
                danhSachTacGia.Remove(selectedTacGia);
                grdTacgia.DataSource = null;
                grdTacgia.DataSource = danhSachTacGia;
            }
        }
    }
}