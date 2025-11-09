using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private DauSachBLL dauSachBLL;
        private TacGiaDAL tacGiaDAL;
        private BindingList<TacGiaDTO> danhSachTacGiaChon;
        private BindingList<BanSachDTO> danhSachBanSach;
        private string tenFileAnh = null;

        public frmThemsach()
        {
            InitializeComponent();
            dauSachBLL = new DauSachBLL();
            tacGiaDAL = new TacGiaDAL(); // <- Khởi tạo DAL

            // Khởi tạo các danh sách
            danhSachTacGiaChon = new BindingList<TacGiaDTO>();
            danhSachBanSach = new BindingList<BanSachDTO>();
            grdTacgia.DataSource = danhSachTacGiaChon;
            grdSach.DataSource = danhSachBanSach;

        }
        private void frmThemsach_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            TaoMaDauSachMoi();
            ConfigureSearchableComboBox();

            // Ẩn grid tìm kiếm tác giả ban đầu
            grdTimkiemtacgia.Visible = false;
        }
        private void LoadComboBoxes()
        {
            // Load Thể Loại
            cbbTheloai.DataSource = dauSachBLL.LayDanhSachTheLoai();
            cbbTheloai.DisplayMember = "TenTheLoai";
            cbbTheloai.ValueMember = "MaTheLoai";

            // Load Vị Trí
            cbbVitri.DataSource = dauSachBLL.LayDanhSachViTri();
            cbbVitri.DisplayMember = "TenViTri";
            cbbVitri.ValueMember = "MaViTri";
        }
        private void ConfigureSearchableComboBox()
        {
            cbbVitri.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbVitri.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void TaoMaDauSachMoi()
        {
            txtMadausach.Text = dauSachBLL.GetMaDauSachMoi();
            txtMadausach.ReadOnly = true;
        }
        private void txtTacgia_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTacgia.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                grdTimkiemtacgia.Visible = false;
                return;
            }

            // Gọi DAL để tìm kiếm
            var ketQua = tacGiaDAL.TimKiemTacGia(tuKhoa);
            if (ketQua.Count > 0)
            {
                grdTimkiemtacgia.DataSource = ketQua;

                // Đặt vị trí grid tìm kiếm ngay dưới ô text
                grdTimkiemtacgia.Location = new Point(txtTacgia.Location.X, txtTacgia.Location.Y + txtTacgia.Height);
                grdTimkiemtacgia.Visible = true;
                grdTimkiemtacgia.BringToFront();
            }
            else
            {
                grdTimkiemtacgia.Visible = false;
            }
        }

        // Yêu cầu 4: Click vào grid tìm kiếm để thêm
        private void grdTimkiemtacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đây là chức năng duy nhất để thêm tác giả
            if (e.RowIndex < 0) return;
            var tacGiaChon = grdTimkiemtacgia.Rows[e.RowIndex].DataBoundItem as TacGiaDTO;
            if (tacGiaChon != null)
            {
                ThemTacGiaVaoDanhSach(tacGiaChon);
            }
        }
        private void ThemTacGiaVaoDanhSach(TacGiaDTO tacGiaChon)
        {
            if (!danhSachTacGiaChon.Any(tg => tg.MaTacGia == tacGiaChon.MaTacGia))
            {
                danhSachTacGiaChon.Add(tacGiaChon);
            }
            else
            {
                MessageBox.Show("Tác giả này đã được thêm.");
            }
            grdTimkiemtacgia.Visible = false;
            txtTacgia.Text = "";
            txtTacgia.Focus();
        }
        private void btnXoatg_Click(object sender, EventArgs e)
        {
            if (grdTacgia.SelectedRows.Count > 0)
            {
                var tacGiaCanXoa = grdTacgia.SelectedRows[0].DataBoundItem as TacGiaDTO;
                if (tacGiaCanXoa != null)
                {
                    danhSachTacGiaChon.Remove(tacGiaCanXoa);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa.");
            }
        }
        private void btnTaoMaSach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoluong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ (lớn hơn 0).");
                return;
            }

            string maDauSach = txtMadausach.Text;
            danhSachBanSach.Clear(); // Xóa danh sách cũ

            const int MA_TINH_TRANG_SAN_SANG = 1;
            const string TEN_TINH_TRANG_SAN_SANG = "Có sẵn";
            for (int i = 1; i <= soLuong; i++)
            {
                danhSachBanSach.Add(new BanSachDTO
                {
                    MaSach = $"{maDauSach}-{i:D3}", // DS001-001
                    MaDauSach = maDauSach,
                    MaTinhTrang = MA_TINH_TRANG_SAN_SANG,
                    TenTinhTrang = TEN_TINH_TRANG_SAN_SANG
                });
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Thu thập dữ liệu từ Form
                DauSachDTO dauSach = new DauSachDTO
                {
                    MaDauSach = txtMadausach.Text,
                    TenDauSach = txtTensach.Text,
                    MaTheLoai = (int)cbbTheloai.SelectedValue,
                    NamXuatBan = (short)dtpNamxb.Value.Year,
                    NhaXuatBan = txtNxb.Text,
                    MaViTri = (string)cbbVitri.SelectedValue,
                    SoLuongTong = int.Parse(txtSoluong.Text),
                    AnhBia = this.tenFileAnh
                };
                List<TacGiaDTO> tacGias = danhSachTacGiaChon.ToList();
                List<BanSachDTO> banSach = danhSachBanSach.ToList();

                // 3. Gọi BLL (BLL sẽ gọi DAL Transaction)
                bool success = dauSachBLL.ThemSachMoi(dauSach, tacGias, banSach);

                if (success)
                {
                    MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại. Giao dịch đã được Rollback. Vui lòng kiểm tra lại (có thể lỗi trùng mã).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu sách: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void grdTimkiemtacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourceFilePath = ofd.FileName;
                        string fileName = Path.GetFileName(sourceFilePath);

                        string imageFolderPath = Path.Combine(Application.StartupPath, "Image");

                        if (!Directory.Exists(imageFolderPath))
                        {
                            Directory.CreateDirectory(imageFolderPath);
                        }

                        string targetPath = Path.Combine(imageFolderPath, fileName);
                        File.Copy(sourceFilePath, targetPath, true);

                        using (Image tempImage = Image.FromFile(targetPath))
                        {
                            pbThemanh.Image = new Bitmap(tempImage);
                            pbThemanh.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        // 2. Lưu tên file vào biến
                        this.tenFileAnh = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc/copy file ảnh: " + ex.Message);
                    }
                }
            }
        }
    }
}