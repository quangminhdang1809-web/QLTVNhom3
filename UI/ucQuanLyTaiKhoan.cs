using QLTVNhom3.BLL;
using QLTVNhom3.DAL; // Cần AccountDAL
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTVNhom3.UI
{
    public partial class ucQuanLyTaiKhoan : UserControl
    {
        private AccountBLL accountBLL = new AccountBLL();
        private DataTable dtTaiKhoanGoc; // Lưu danh sách gốc
        private bool dangTaiDuLieu = false;

        public ucQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        // --- GÁN SỰ KIỆN KHI FORM LOAD ---
        private void ucQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Cấu hình cột Grid (dùng tên control từ Designer)
            grdTaikhoan.AutoGenerateColumns = false;
            colAccount.DataPropertyName = "IDAccount";
            colHoten.DataPropertyName = "HoTen"; // Tái sử dụng cột Tên Tác Giả
            colTypeOfAccount.DataPropertyName = "TypeOfAccount";
            colMatkhau.Visible = false; // Ẩn cột mật khẩu đi

            // Cấu hình ComboBox lọc
            cboLoaiTaiKhoan.Items.Add("Tất cả");
            cboLoaiTaiKhoan.Items.Add("DOCGIA");
            cboLoaiTaiKhoan.Items.Add("THUTHU");
            cboLoaiTaiKhoan.Items.Add("ADMIN");
            cboLoaiTaiKhoan.SelectedIndex = 0;

            // Tải dữ liệu
            LoadData();

            // Gán sự kiện
            grdTaikhoan.SelectionChanged += grdTaikhoan_SelectionChanged;
            txtTimkiem.TextChanged += TimKiemVaLoc;
            cboLoaiTaiKhoan.SelectedIndexChanged += TimKiemVaLoc;

            // Gán sự kiện cho các nút Sửa/Xóa (đổi tên btnLuu -> btnReset)
            btnSua.Visible = false; // Ẩn nút Sửa
            btnXoa.Visible = false; // Ẩn nút Xóa
            btnResetmatkau.Visible = false; // Ẩn nút Undo
            btnLuu.Text = "Reset Mật khẩu"; // Đổi tên nút Lưu thành Reset
            btnLuu.Click += btnResetMatKhau_Click;

            // Vô hiệu hóa panel chi tiết (chỉ xem)
            SetEditMode(false);
        }

        private void LoadData()
        {
            dangTaiDuLieu = true;
            try
            {
                dtTaiKhoanGoc = accountBLL.GetAccountListView();
                grdTaikhoan.DataSource = dtTaiKhoanGoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message);
            }
            dangTaiDuLieu = false;
            grdTaikhoan_SelectionChanged(null, null); // Tải chi tiết
        }

        private void TimKiemVaLoc(object sender, EventArgs e)
        {
            if (dtTaiKhoanGoc == null) return;

            string tuKhoa = txtTimkiem.Text.Trim().ToLower();
            string loaiTK = cboLoaiTaiKhoan.SelectedItem.ToString();

            DataView dv = dtTaiKhoanGoc.DefaultView;

            string filter = "";

            // 1. Lọc theo Loại
            if (loaiTK != "Tất cả")
            {
                filter = $"TypeOfAccount = '{loaiTK}'";
            }

            // 2. Lọc theo Từ khóa
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                string searchFilter = $"(IDAccount LIKE '%{tuKhoa}%' OR HoTen LIKE '%{tuKhoa}%')";
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND " + searchFilter;
                }
                else
                {
                    filter = searchFilter;
                }
            }

            dv.RowFilter = filter;
            grdTaikhoan.DataSource = dv.ToTable();
        }

        private void grdTaikhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDuLieu) return;
            HienThiChiTiet();
        }

        private void HienThiChiTiet()
        {
            if (grdTaikhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdTaikhoan.SelectedRows[0];
                txtIDAccount.Text = row.Cells["colAccount"].Value.ToString();
                txtHovaten.Text = row.Cells["colHoten"].Value.ToString(); // Dùng txtHovaten
                txtLoaitaikhoan.Text = row.Cells["colTypeOfAccount"].Value.ToString();
                txtMatkhau.Text = "**********"; // Luôn ẩn mật khẩu
            }
            else
            {
                txtIDAccount.Text = "";
                txtHovaten.Text = "";
                txtLoaitaikhoan.Text = "";
                txtMatkhau.Text = "";
            }
        }

        // Chỉ cho phép xem, không cho sửa
        private void SetEditMode(bool isEdit)
        {
            txtIDAccount.ReadOnly = true;
            txtHovaten.ReadOnly = true;
            txtLoaitaikhoan.ReadOnly = true;
            txtMatkhau.ReadOnly = true;
        }

        // Sự kiện cho nút Reset (dùng nút btnLuu)
        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if (grdTaikhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để reset.");
                return;
            }

            string idAccount = txtIDAccount.Text;
            string hoTen = txtHovaten.Text;

            if (MessageBox.Show($"Bạn có chắc muốn reset mật khẩu cho tài khoản '{hoTen}' ({idAccount})?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string matKhauMoi = accountBLL.ResetPassword(idAccount);

                    MessageBox.Show($"Đã reset mật khẩu thành công.\n\n" +
                                    $"Tài khoản: {idAccount}\n" +
                                    $"Mật khẩu mới: {matKhauMoi}\n\n" +
                                    "(Hãy thông báo cho người dùng)",
                                    "Thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi reset mật khẩu: " + ex.Message);
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdTaikhoan.ClearSelection();
            grdTaikhoan.CurrentCell = grdTaikhoan[0, 0];
            HienThiChiTiet();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdTaikhoan.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdTaikhoan.CurrentCell = grdTaikhoan[0, i - 1];
            }
            HienThiChiTiet();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdTaikhoan.CurrentRow.Index;
            if (i < grdTaikhoan.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp the
            {
                grdTaikhoan.CurrentCell = grdTaikhoan[0, i + 1];
            }
            HienThiChiTiet();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdTaikhoan.RowCount - 1;
            grdTaikhoan.CurrentCell = grdTaikhoan[0, i];//Dòng  cuối cùng
            HienThiChiTiet();
        }

    }
}