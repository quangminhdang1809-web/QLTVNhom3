using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTVNhom3.UI
{
    public partial class ucThuThu : UserControl
    {
        private ThuThuBLL thuThuBLL = new ThuThuBLL();
        private bool isNew = false;
        private bool isProcessing = false;
        private DataRowView selectedThuThu;

        // BIẾN KHAI BÁO (KHÔNG CẦN THIẾT NỮA VÌ DESIGNER ĐÃ CÓ)
        // private TextBox txtMaThuThu;
        // private TextBox txtHoTen;
        // ... (xóa các khai báo control ở đây)

        public ucThuThu()
        {
            InitializeComponent();

            // SỬA LẠI NHÃN (LABEL)
            label1.Text = "Mã Thủ thư";
            label3.Text = "Họ tên";
            label4.Text = "Ngày sinh";
            label2.Text = "Email";
            label5.Text = "Số điện thoại";
            label6.Text = "ID Account";
        }

        private void ucThuThu_Load(object sender, EventArgs e)
        {
            grdThuthu.AutoGenerateColumns = false;
            colMaThuThu.DataPropertyName = "MaThuThu";
            colHoTen.DataPropertyName = "HoTen";
            colNgaySinh.DataPropertyName = "NgaySinh";
            colIDAccount.DataPropertyName = "IDAccount";

            LoadData();
            SetViewMode(false);

            // Gán sự kiện
            grdThuthu.SelectionChanged += grdThuthu_SelectionChanged;
            btnThemthuthu.Click += btnThemthuthu_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;
            btnUndo.Click += btnUndo_Click;
            btnTimkiem.Click += btnTimkiem_Click;

            btnFirst.Click += btnFirst_Click;
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            btnLast.Click += btnLast_Click;
        }

        private void LoadData()
        {
            try
            {
                grdThuthu.DataSource = thuThuBLL.GetDanhSachThuThu();
                if (grdThuthu.Rows.Count > 0)
                {
                    grdThuthu.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void SetViewMode(bool isEditing)
        {
            // SỬA TÊN CONTROL CHO KHỚP DESIGNER
            txtHoten.ReadOnly = !isEditing;
            dtpNgaysinh.Enabled = isEditing;
            txtEmail.ReadOnly = !isEditing;
            txtSdt.ReadOnly = !isEditing;

            txtMathuthu.ReadOnly = true;
            txtIDAccount.ReadOnly = !isNew;

            btnLuu.Enabled = isEditing;
            btnUndo.Enabled = isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnThemthuthu.Enabled = !isEditing;

            grdThuthu.Enabled = !isEditing;
            groupBox2.Enabled = !isEditing;
        }

        private void HienThiChiTiet()
        {
            if (grdThuthu.SelectedRows.Count > 0 && grdThuthu.SelectedRows[0].DataBoundItem != null)
            {
                selectedThuThu = (DataRowView)grdThuthu.SelectedRows[0].DataBoundItem;

                // SỬA TÊN CONTROL CHO KHỚP DESIGNER
                txtMathuthu.Text = selectedThuThu["MaThuThu"].ToString();
                txtHoten.Text = selectedThuThu["HoTen"].ToString();
                dtpNgaysinh.Value = (DateTime)selectedThuThu["NgaySinh"];
                txtEmail.Text = selectedThuThu["Email"].ToString();
                txtSdt.Text = selectedThuThu["SoDienThoai"].ToString();
                txtIDAccount.Text = selectedThuThu["IDAccount"].ToString();
            }
            else
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            // SỬA TÊN CONTROL CHO KHỚP DESIGNER
            txtMathuthu.Text = "(Tự động)";
            txtHoten.Text = "";
            dtpNgaysinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSdt.Text = "";
            txtIDAccount.Text = "";
        }

        private void grdThuthu_SelectionChanged(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                HienThiChiTiet();
            }
        }

        private void btnThemthuthu_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            btnThemthuthu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            try
            {
                isProcessing = true;
                using (frmThemThuThu frm = new frmThemThuThu())
                {
                    frm.ShowDialog();
                    if (frm.DaThemThanhCong)
                    {
                        LoadData();
                    }
                }
            }
            finally
            {
                Application.DoEvents();
                SetViewMode(false);
                isProcessing = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdThuthu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thủ thư để sửa.");
                return;
            }
            isNew = false;
            SetViewMode(true);
            txtHoten.Focus(); // SỬA TÊN
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SetViewMode(false);
            HienThiChiTiet();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;

            try
            {
                isProcessing = true;
                btnLuu.Enabled = false;

                // SỬA TÊN CONTROL CHO KHỚP DESIGNER
                ThuThuDTO tt = new ThuThuDTO
                {
                    MaThuThu = int.Parse(txtMathuthu.Text),
                    HoTen = txtHoten.Text.Trim(),
                    NgaySinh = dtpNgaysinh.Value,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSdt.Text.Trim(),
                    IDAccount = txtIDAccount.Text
                };

                if (thuThuBLL.CapNhatThuThu(tt))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                btnLuu.Enabled = true;
            }
            finally
            {
                Application.DoEvents();
                SetViewMode(false);
                isProcessing = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isProcessing) return;
            if (grdThuthu.SelectedRows.Count == 0) return;

            // SỬA TÊN CONTROL CHO KHỚP DESIGNER
            string idAccount = txtIDAccount.Text;
            string hoTen = txtHoten.Text;

            if (MessageBox.Show($"Bạn có chắc muốn vô hiệu hóa tài khoản của '{hoTen}'?", "Xác nhận vô hiệu hóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    isProcessing = true;
                    btnXoa.Enabled = false;
                    btnThemthuthu.Enabled = false;
                    btnSua.Enabled = false;

                    if (thuThuBLL.XoaThuThu(idAccount))
                    {
                        MessageBox.Show("Vô hiệu hóa tài khoản thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                finally
                {
                    Application.DoEvents();
                    SetViewMode(false);
                    isProcessing = false;
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                grdThuthu.DataSource = thuThuBLL.TimKiemThuThu(txtTimkiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        #region Nút điều hướng
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (grdThuthu.Rows.Count > 0)
            {
                grdThuthu.ClearSelection();
                grdThuthu.Rows[0].Selected = true;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grdThuthu.Rows.Count == 0 || grdThuthu.SelectedRows.Count == 0) return;
            int i = grdThuthu.SelectedRows[0].Index;
            if (i > 0)
            {
                grdThuthu.ClearSelection();
                grdThuthu.Rows[i - 1].Selected = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grdThuthu.Rows.Count == 0 || grdThuthu.SelectedRows.Count == 0) return;
            int i = grdThuthu.SelectedRows[0].Index;
            if (i < grdThuthu.RowCount - 1)
            {
                grdThuthu.ClearSelection();
                grdThuthu.Rows[i + 1].Selected = true;
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (grdThuthu.Rows.Count > 0)
            {
                grdThuthu.ClearSelection();
                grdThuthu.Rows[grdThuthu.RowCount - 1].Selected = true;
            }
        }
        #endregion
    }
}