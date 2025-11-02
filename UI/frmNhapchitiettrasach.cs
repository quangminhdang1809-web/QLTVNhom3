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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboTinhTrangSach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng sách!", "Thông báo");
                return;
            }
            // XỬ LÝ LỖI KHI PARSE MÃ PHIẾU MƯỢN
            if (!int.TryParse(txtMaPhieuMuon.Text, out int maPhieuMS))
            {
                MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi");
                return;
            }
            // Lấy thông tin lỗi
            var (maLoiSach, tienPhatLoiSach) = GetMaLoiVaMucPhat(cboTinhTrangSach.SelectedItem.ToString());
            decimal tienPhatTraTre = _soNgayTraTre * 5000;

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

                // Thông tin vi phạm
                TinhTrangSach = cboTinhTrangSach.SelectedItem.ToString(),
                MaLoiQuaHan = (_soNgayTraTre > 0) ? 1 : (int?)null, // MaLoi = 1 cho quá hạn
                MaLoiSach = maLoiSach,

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

            // Khởi tạo combo box tình trạng sách
            KhoiTaoComboBoxTinhTrang();
        }
        private int TinhSoNgayTraTre(DateTime hanTra, DateTime ngayTra)
        {
            if (ngayTra <= hanTra)
                return 0;

            TimeSpan diff = ngayTra - hanTra;
            return diff.Days;
        }
        private void KhoiTaoComboBoxTinhTrang()
        {
            // Thêm các tình trạng sách
            cboTinhTrangSach.Items.Add("Bình thường");
            cboTinhTrangSach.Items.Add("Rách bìa");
            cboTinhTrangSach.Items.Add("Rách trang");
            cboTinhTrangSach.Items.Add("Bẩn");
            cboTinhTrangSach.Items.Add("Mất sách");
            cboTinhTrangSach.SelectedIndex = 0; // Mặc định là "Bình thường"
        }
        private void TinhToanTienPhat()
        {
            // Tính tiền phạt do trả trễ
            decimal tienPhatTraTre = _soNgayTraTre * 5000;

            // Tính tiền phạt do lỗi sách (nếu có)
            var (maLoiSach, tienPhatLoiSach) = GetMaLoiVaMucPhat(cboTinhTrangSach.SelectedItem?.ToString());

            _tienPhat = tienPhatTraTre + tienPhatLoiSach;
            txtTienPhat.Text = _tienPhat.ToString("N0") + " VNĐ";
        }
        private (int maLoi, decimal mucPhat) GetMaLoiVaMucPhat(string tinhTrang)
        {
            // Ánh xạ tình trạng sang mã lỗi (bạn cần query từ database)
            switch (tinhTrang)
            {
                case "Bình thường": return (3, 0);      // MaLoi = 3
                case "Rách bìa": return (4, 20000);     // MaLoi = 4
                case "Rách trang": return (5, 20000);   // MaLoi = 5
                case "Bẩn": return (6, 5000);          // MaLoi = 6
                case "Mất sách": return (7, 500000);   // MaLoi = 7
                default: return (3, 0);
            }
        }
        private void cboTinhTrangSach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TinhToanTienPhat();
        }
    }
}
