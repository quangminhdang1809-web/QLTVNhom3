using QLTVNhom3.DAL; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVNhom3.DTO;

namespace QLTVNhom3
{
    public partial class frmThemdocgia : Form
    {
        private DocGiaDAL docGiaDAL = new DocGiaDAL();
        private LoaiDocGiaDAL loaiDocGiaDAL = new LoaiDocGiaDAL();
        public frmThemdocgia()
        {
            InitializeComponent();
        }
        private void frmThemdocgia_Load(object sender, EventArgs e)
        {
            try
            {
                if (!TestConnection())
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra kết nối và thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                //Load loại độc giả 
                cbbLoaidocgia.DataSource = loaiDocGiaDAL.GetLoaiDocGia();
                cbbLoaidocgia.DisplayMember = "TenLoaiDG";
                cbbLoaidocgia.ValueMember = "MaLoaiDG";
                cbbLoaidocgia.SelectedIndex = -1;

                //Ngay lap the la hnay 
                dtpNgaylapthe.Value = DateTime.Now;
                dtpNgayhethan.Enabled = false;

                MessageBox.Show("Hệ thống sẽ tự động tạo tài khoản (docgiaX) với mật khẩu mặc định: 123456",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!KiemTraDuLieuHopLe())
                        return;

                    // Lấy dữ liệu từ form
                    string hoTen = txtTendocgia.Text.Trim();
                    DateTime ngaySinh = dtpNgaysinh.Value;
                    string diaChi = txtDiachi.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string soDienThoai = txtSdt.Text.Trim();
                    DateTime ngayLapThe = dtpNgaylapthe.Value;
                    DateTime ngayHetHan = dtpNgayhethan.Value;
                    int maLoaiDG = Convert.ToInt32(cbbLoaidocgia.SelectedValue);

                    // Gọi DAL để thêm
                    int result = docGiaDAL.ThemDocGia(hoTen, ngaySinh, diaChi, email, soDienThoai, "", maLoaiDG, ngayLapThe, ngayHetHan);
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm độc giả thành công!");
                        this.Close();
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Lỗi kết nối database!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm độc giả thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm độc giả: " + ex.Message);
                }
            }
        }
        private bool KiemTraDuLieuHopLe()
        {
            //Kiểm tra dữ liệu nhập vào 
            if (string.IsNullOrWhiteSpace(txtTendocgia.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendocgia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (cbbLoaidocgia.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbLoaidocgia.Focus();
                return false;
            }

            // Kiểm tra tuổi (ví dụ: ít nhất 18 tuổi)
            int tuoi = DateTime.Now.Year - dtpNgaysinh.Value.Year;
            if (tuoi < 18)
            {
                MessageBox.Show("Độc giả phải ít nhất 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaysinh.Focus();
                return false;
            }

            return true;
        }

        private int? GetMaLoaiDocGia()
        {
            if (cbbLoaidocgia.SelectedValue == null)
                return null;

            string selectedValue = cbbLoaidocgia.SelectedValue.ToString();

            // Kiểm tra nếu là DataRowView
            //if (selectedValue.Contains("System.Data.DataRowView"))
            //return null;

            //return selectedValue;
            try
            {
                return Convert.ToInt32(cbbLoaidocgia.SelectedValue);
            }
            catch
            {
                return null;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbLoaidocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaidocgia.SelectedValue == null || cbbLoaidocgia.SelectedValue is DataRowView)
                return;
            try
            {
                int maLoai = Convert.ToInt32(cbbLoaidocgia.SelectedValue);
                LoaiDocGiaDTO loai = loaiDocGiaDAL.GetLoaiDocGiaByMa(maLoai);

                if (loai != null && loai.ThoiHanThe > 0)
                {
                    dtpNgayhethan.Value = dtpNgaylapthe.Value.AddYears(loai.ThoiHanThe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật ngày hết hạn: " + ex.Message);
            }
        }
        private bool TestConnection()
        {
            try
            {
                DBHelper db = new DBHelper();
                using (var con = db.Getconnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}\n\nKiểm tra:\n1. SQL Server có đang chạy không?\n2. Database QLTV có tồn tại không?",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
