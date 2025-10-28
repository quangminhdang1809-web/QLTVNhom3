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
        public frmThemdocgia()
        {
            InitializeComponent();
        }
        private void frmThemdocgia_Load(object sender, EventArgs e)
        {
            try
            {
                LoaiDocGiaDAL loaiDocGiaDAL = new LoaiDocGiaDAL();

                //Load loại độc giả 
                cbbLoaidocgia.DataSource = loaiDocGiaDAL.GetLoaiDocGia();
                cbbLoaidocgia.DisplayMember = "TenLoaiDG";
                cbbLoaidocgia.ValueMember = "MaLoaiDG";
                cbbLoaidocgia.SelectedIndex = -1;

                //Ngay lap the la hnay 
                dtpNgaylapthe.Value = DateTime.Now;
                dtpNgayhethan.Enabled= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtTendocgia.Text;
                DateTime ngaySinh = dtpNgaysinh.Value;
                string diaChi = txtDiachi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string soDienThoai = txtSdt.Text.Trim();
                string idAccount = txtIDAccount.Text.Trim();

                if (cbbLoaidocgia.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn loại độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maLoaiDG = cbbLoaidocgia.SelectedValue.ToString();
                DateTime ngayLapThe = dtpNgaylapthe.Value;
                DateTime ngayHetHan = dtpNgayhethan.Value;

                //Kiểm tra dữ liệu nhập vào 
                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(diaChi))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(soDienThoai))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi DAL để thêm
                int result = docGiaDAL.ThemDocGia(hoTen, ngaySinh, diaChi, email, soDienThoai, idAccount, maLoaiDG, ngayLapThe, ngayHetHan);
                if (result > 0)
                {
                    MessageBox.Show("Thêm độc giả thành công!");
                    this.Close();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbLoaidocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaidocgia.SelectedValue == null) return;

            string maLoai = cbbLoaidocgia.SelectedValue.ToString();
            LoaiDocGiaDAL loaiDAL = new LoaiDocGiaDAL();
            LoaiDocGiaDTO loai = loaiDAL.GetLoaiDocGiaByMa(maLoai);

            if (loai != null)
            {
                DateTime ngayLap = dtpNgaylapthe.Value;
                dtpNgayhethan.Value = ngayLap.AddYears(loai.ThoiHanThe);
            }
        }

    }
}
