using QLTVNhom3.BLL;
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
    public partial class ucSachthuthu : UserControl
    {
        private DauSachBLL dauSachBLL;
        private List<TacGiaDTO> danhSachTacGia;
        private string maSachDangChon;
        private DauSachDTO dauSachHienTai;
        public ucSachthuthu()
        {
            InitializeComponent();
            dauSachBLL = new DauSachBLL();
            danhSachTacGia = new List<TacGiaDTO>();
            grdSach.AutoGenerateColumns = false;
            LoadDanhSachDauSach();
        }
        private void LoadDanhSachDauSach()
        {
            try
            {
                var data = dauSachBLL.LayDanhSachDauSach();
                grdSach.DataSource = data;
                if (grdSach.Rows.Count > 0)
                {
                    grdSach.ClearSelection();
                    grdSach.CurrentCell = grdSach.Rows[0].Cells[0];
                    grdSach.Rows[0].Selected = true;
                    string ma = grdSach.Rows[0].Cells["colMadausach"].Value?.ToString();
                    if (!string.IsNullOrEmpty(ma))
                    {
                        maSachDangChon = ma; 
                        HienThiChiTietSach(ma);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemsach frm = new frmThemsach();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachDauSach();
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[0].Cells[0];
                grdSach.Rows[0].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[0].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null) return;

            int i = grdSach.CurrentRow.Index;
            if (i > 0)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i - 1].Cells[0];
                grdSach.Rows[i - 1].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i - 1].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdSach.CurrentRow == null) return;

            int i = grdSach.CurrentRow.Index;
            if (i < grdSach.RowCount - 1)
            {
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i + 1].Cells[0];
                grdSach.Rows[i + 1].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i + 1].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdSach.Rows.Count > 0)
            {
                int i = grdSach.RowCount - 1;
                grdSach.ClearSelection();
                grdSach.CurrentCell = grdSach.Rows[i].Cells[0];
                grdSach.Rows[i].Selected = true;
                grdSach.Focus();
                string ma = grdSach.Rows[i].Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }

        private void grdSach_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSach.SelectedRows.Count != null)
            {
                string ma = grdSach.CurrentRow.Cells["colMadausach"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    maSachDangChon = ma;
                    HienThiChiTietSach(ma);
                }
            }
        }
        private void HienThiChiTietSach(string maDauSach)
        {
            try
            {
                var sach = dauSachBLL.LayChiTietSach(maDauSach);
                if (sach != null)
                {
                    txtMaDauSach.Text = sach.MaDauSach;
                    txtTenDauSach.Text = sach.TenDauSach;
                    // XỬ LÝ DateTimePicker ĐÚNG CÁCH
                    if (sach.NamXuatBan > 0)
                    {
                        DateTime namXuatBan = new DateTime(sach.NamXuatBan, 1, 1);
                        dtpNamXB.Value = namXuatBan;
                    }
                    else
                    {
                        dtpNamXB.Value = DateTime.Now;
                    }
                    txtNhaXB.Text = sach.NhaXuatBan ?? "";
                    txtViTri.Text = sach.TenViTri ?? "";
                    txtSoLuong.Text = sach.SoLuongTong.ToString();

                    // Hiển thị ảnh bìa
                    if (sach.AnhBia != null && sach.AnhBia.Length > 0)
                    {
                        using (var ms = new System.IO.MemoryStream(sach.AnhBia))
                        {
                            picAnhBia.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picAnhBia.Image = null;
                    }

                    // Hiển thị danh sách tác giả
                    grdTacgia.DataSource = sach.DanhSachTacGia;
                    dauSachHienTai = sach;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var data = dauSachBLL.TimKiemSach(txtTimkiem.Text.Trim());
                grdSach.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSachDangChon))
            {
                MessageBox.Show("Vui lòng chọn sách để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool success = dauSachBLL.XoaSach(maSachDangChon);
                    if (success)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachDauSach();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearForm()
        {
            txtMaDauSach.Clear();
            txtTenDauSach.Clear();
            txtNhaXB.Clear();
            txtViTri.Clear();
            txtSoLuong.Clear();
            picAnhBia.Image = null;
            grdTacgia.DataSource = null;
            maSachDangChon = null;
        }

        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimkiem_Click_1(sender, e);
            }
        }
    }
}
