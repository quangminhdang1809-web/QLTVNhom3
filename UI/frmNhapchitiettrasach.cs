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
    public partial class frmNhapchitiettrasach : Form
    {
        private DataRow _sachMuon;
        private int _soNgayTraTre;
        private decimal _tienPhat = 0;
        public PhieuTraDTO ThongTinSachTra { get; set; }

        public frmNhapchitiettrasach(DataRow sachMuon, string tenDocGia)
        {
            InitializeComponent();
            _sachMuon = sachMuon;
            KhoiTaoThongTin();
            TinhToanTienPhat();
        }
        private (int maLoi, decimal mucPhat) GetMaLoiVaMucPhat()
        {
            // 1. Kiểm tra SelectedItem
            if (cboTinhTrangSach.SelectedItem == null)
                return (0, 0); // Không có lỗi

            // Lấy DataRowView (cần thiết khi DataSource là DataTable)
            if (cboTinhTrangSach.SelectedItem is DataRowView drv)
            {
                // 2. Lấy Mã lỗi (MaLoi) từ ValueMember
                // LƯU Ý: Nếu ValueMember là int, SelectedValue sẽ trả về object kiểu int
                int maLoi = (int)cboTinhTrangSach.SelectedValue;

                // 3. Lấy mức phạt (MucPhat) từ DataRowView
                // Cột MucPhat phải được định nghĩa trong DataTable của bạn
                decimal mucPhat = (decimal)drv["MucPhat"];

                return (maLoi, mucPhat);
            }

            // Trường hợp không phải DataRowView (lỗi bất thường)
            return (0, 0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ComboBox đã chọn
            if (cboTinhTrangSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng sách!", "Thông báo");
                return;
            }

            // Lấy mã lỗi và mức phạt
            var (maLoiSach, tienPhatLoiSach) = GetMaLoiVaMucPhat(); // Dùng hàm sửa lỗi

            int maPhieuMS;
            if (!int.TryParse(txtMaPhieuMuon.Text, out maPhieuMS))
            {
                MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi");
                return;
            }

            // Tính tiền phạt trả trễ
            decimal tienPhatTraTre = _soNgayTraTre * 5000;

            // TẠO DANH SÁCH LỖI (CHỈ LƯU MÃ LỖI)
            List<int> dsMaLoi = new List<int>();
            if (maLoiSach > 0)
            {
                dsMaLoi.Add(maLoiSach); // Thêm Mã lỗi sách đã chọn
            }
            // LƯU Ý: Tầng DAL sẽ tự thêm lỗi Quá hạn nếu SoNgayTraTre > 0

            // TẠO DTO VỚI ĐẦY ĐỦ THÔNG TIN
            ThongTinSachTra = new PhieuTraDTO
            {
                MaPhieuMS = maPhieuMS,
                MaSach = txtMaSach.Text,
                TenDauSach = txtTenSach.Text,
                NgayMuon = Convert.ToDateTime(_sachMuon["NgayMuon"]),
                HanTra = Convert.ToDateTime(_sachMuon["HanTra"]),
                NgayTra = DateTime.Now,
                SoNgayTraTre = _soNgayTraTre,

                // Gán Mã lỗi cho DAL (quan trọng cho CTVIPHAM)
                DsMaLoiViPham = dsMaLoi,

                // Gán Mã Tình trạng mới (MaTinhTrangMoi) - Cần được tính toán từ tên tình trạng
                // Giả sử 1 là mã 'Bình thường/Tốt'
                MaTinhTrangMoi = (maLoiSach == 0 || maLoiSach == 3) ? 1 : 3, // Logic giả định: Nếu không có lỗi nghiêm trọng, trạng thái sách là Tốt (1). Nếu có lỗi, trạng thái là Cần sửa (3). 

                // Tiền phạt
                TienPhatQuaHan = tienPhatTraTre,
                TienPhatLoiSach = tienPhatLoiSach,
                TongTienPhat = tienPhatTraTre + tienPhatLoiSach,
                GhiChu = txtGhiChu.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void KhoiTaoThongTin()
        {
            // Hiển thị thông tin cơ bản
            txtMaPhieuMuon.Text = _sachMuon["MaPhieuMS"].ToString();
            txtMaSach.Text = _sachMuon["MaSach"].ToString();
            txtTenSach.Text = _sachMuon["TenDauSach"].ToString();

            // Hiển thị ngày mượn và hạn trả
            DateTime ngayMuon = Convert.ToDateTime(_sachMuon["NgayMuon"]);
            DateTime hanTra = Convert.ToDateTime(_sachMuon["HanTra"]);
            DateTime ngayHienTai = DateTime.Now;
            dtpNgayTra.Value = ngayHienTai;
            dtpNgayTra.Enabled = false;

            // Tính số ngày trả trễ
            _soNgayTraTre = TinhSoNgayTraTre(hanTra, ngayHienTai);
            txtSoNgayTraTre.Text = _soNgayTraTre.ToString();
            LoadCboLoaiViPham();

        }
        private int TinhSoNgayTraTre(DateTime hanTra, DateTime ngayTra)
        {
            if (ngayTra <= hanTra)
                return 0;

            TimeSpan diff = ngayTra - hanTra;
            return diff.Days;
        }
        public void LoadCboLoaiViPham()
        {
            PhieuTraDAL dal = new PhieuTraDAL();
            DataTable dt = dal.LayDanhSachLoaiViPham();

            // --- Bổ sung hàng "Không lỗi" (MaLoi = 0) ---
            DataRow noErrorRow = dt.NewRow();
            noErrorRow["MaLoi"] = 0;
            noErrorRow["TenLoi"] = "Không lỗi";
            noErrorRow["MucPhat"] = 0m; // Mức phạt là 0

            // Thêm hàng "Không lỗi" vào đầu DataTable
            dt.Rows.InsertAt(noErrorRow, 0);

            cboTinhTrangSach.DataSource = dt;
            cboTinhTrangSach.DisplayMember = "TenLoi";
            cboTinhTrangSach.ValueMember = "MaLoi";

            // Chọn giá trị "Không lỗi" (SelectedIndex = 0) làm mặc định
            cboTinhTrangSach.SelectedIndex = 0;
        }
        private void TinhToanTienPhat()
        {
            // Tính tiền phạt do trả trễ (Nên dùng hàm DAL TinhTienPhat nếu có)
            decimal tienPhatTraTre = _soNgayTraTre * 5000;

            // SỬA LỖI: Gọi hàm mới KHÔNG tham số
            var (maLoiSach, tienPhatLoiSach) = GetMaLoiVaMucPhat();

            _tienPhat = tienPhatTraTre + tienPhatLoiSach;
            txtTienPhat.Text = _tienPhat.ToString("N0") + " VNĐ";
        }

        private void cboTinhTrangSach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Bắt lỗi SelectionChanged xảy ra khi load dữ liệu (SelectedIndex = -1)
            if (cboTinhTrangSach.SelectedIndex == -1) return;

            TinhToanTienPhat();
        }
    }
}
