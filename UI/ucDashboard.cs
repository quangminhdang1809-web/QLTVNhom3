using DevExpress.Utils;
using DevExpress.XtraCharts; 
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System.Data;

namespace QLTVNhom3
{
    public partial class ucDashboard : UserControl
    {
        private DashboardDAL dashboardDAL;
        public ucDashboard()
        {
            InitializeComponent();
            dashboardDAL = new DashboardDAL();
        }

        private void TaiDuLieuDashboard()
        {
            try
            {
                // Load thống kê chính
                var thongKe = dashboardDAL.GetThongKeDashboard();
                CapNhatThongKe(thongKe);

                // Load sách yêu thích (sách mượn nhiều nhất)
                var sachYeuThich = dashboardDAL.GetSachMuonNhieuNhat();
                HienThiSachYeuThich(sachYeuThich);
                var sachQuaHan = dashboardDAL.GetSachQuaHanChiTiet();
                HienThiSachQuaHan((sachQuaHan));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapNhatThongKe(DashboardDTO thongKe)
        {
            lblTongDauSach.Text = thongKe.TongDauSach.ToString();
            lblSachDangMuon.Text = thongKe.SoSachMuon.ToString();
            lblSachQuaHan.Text = thongKe.SoSachQuaHan.ToString();
            lblTongDocGia.Text = thongKe.TongDocGia.ToString();
        }
        private void HienThiSachYeuThich(DataTable danhSach)
        {
            try
            {
                dgvSachYeuThich.DataSource = null;
                dgvSachYeuThich.Columns.Clear();
                dgvSachYeuThich.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị sách yêu thích: {ex.Message}");
            }
        }
        private void HienThiSachQuaHan(DataTable danhSach)
        {
            dgvSachQuaHan.DataSource = null;
            dgvSachQuaHan.Columns.Clear();
            // Cập nhật label tổng số sách đến hạn
            lblSoSachDenHan.Text = danhSach.Rows.Count.ToString();

            // Hiển thị DataGridView sách đến hạn
            dgvSachQuaHan.DataSource = danhSach;
            dgvSachQuaHan.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == dgvSachQuaHan.Columns["SoNgayQuaHan"].Index && e.Value != null)
                {
                    int soNgayQuaHan = Convert.ToInt32(e.Value);
                    if (soNgayQuaHan > 7)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(dgvSachQuaHan.Font, FontStyle.Bold);
                    }
                    else if (soNgayQuaHan > 3)
                    {
                        e.CellStyle.BackColor = Color.LightYellow;
                        e.CellStyle.ForeColor = Color.OrangeRed;
                    }
                }
            };
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemsach frm = new frmThemsach();
            frm.ShowDialog();
        }
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            frmThemdocgia frm = new frmThemdocgia();
            frm.ShowDialog();
        }
        private void AddUserControl(UserControl userControl)
        {
            pnlMaincontent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMaincontent.Controls.Add(userControl);
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            ucMuonsachthuthu uc = new ucMuonsachthuthu();
            AddUserControl(uc);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            ucTrasach uc = new ucTrasach();
            AddUserControl(uc);
        }
        private void LoadChartDataTheoNgay()
        {
            try
            {
                DashboardDAL dal = new DashboardDAL();
                DataTable data = dal.GetLuotMuonTheoNgayTrongThang();

                // Clear chart
                chartLuotmuon.Series.Clear();
                chartLuotmuon.Titles.Clear();
                chartLuotmuon.Legend.Visibility = DefaultBoolean.False;

                // Apply beautiful palette
                chartLuotmuon.PaletteName = "Office";

                // Create series
                Series series = new Series("Số lượt mượn", ViewType.Bar);

                // Configure series với style đẹp
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ValueScaleType = ScaleType.Numerical;
                series.LabelsVisibility = DefaultBoolean.False; // TẮT HIỂN THỊ LABEL

                // Bar appearance đẹp
                BarSeriesView barView = series.View as BarSeriesView;
                if (barView != null)
                {
                    barView.Color = Color.FromArgb(255, 106, 90, 205); // Màu xanh tím đẹp
                    barView.FillStyle.FillMode = FillMode.Gradient;
                    barView.Border.Color = Color.FromArgb(255, 72, 61, 139); // Viền đậm hơn
                    barView.Border.Visibility = DefaultBoolean.True;
                    barView.Border.Thickness = 2;
                    barView.Shadow.Size = 4;
                    barView.Shadow.Color = Color.FromArgb(50, 0, 0, 0);
                    barView.BarWidth = 0.8; // Độ rộng cột
                }
                int maxLuotMuon = 0;
                // Add data
                foreach (DataRow row in data.Rows)
                {
                    int ngay = Convert.ToInt32(row["Ngay"]);
                    int luotMuon = Convert.ToInt32(row["LuotMuon"]);

                    if (luotMuon > 0) // Chỉ thêm nếu có dữ liệu
                    {
                        series.Points.Add(new SeriesPoint(ngay, luotMuon));
                    }
                }
                // Nếu không có dữ liệu, thêm dữ liệu demo
                if (series.Points.Count == 0)
                {
                    series.Points.Add(new SeriesPoint(10, 5));
                    series.Points.Add(new SeriesPoint(15, 8));
                    series.Points.Add(new SeriesPoint(20, 3));
                }

                chartLuotmuon.Series.Add(series);

                // Configure diagram đẹp
                XYDiagram diagram = chartLuotmuon.Diagram as XYDiagram;
                if (diagram != null)
                {
                    // Background
                    diagram.AxisX.Interlaced = true;
                    diagram.AxisX.InterlacedColor = Color.FromArgb(15, 0, 0, 0);

                    // Trục X đẹp
                    diagram.AxisX.Title.Text = "NGÀY TRONG THÁNG";
                    diagram.AxisX.Title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    diagram.AxisX.Title.TextColor = Color.FromArgb(255, 64, 64, 64);
                    diagram.AxisX.Title.Visibility = DefaultBoolean.True;

                    diagram.AxisX.NumericOptions.Format = NumericFormat.Number;
                    diagram.AxisX.NumericOptions.Precision = 0;
                    diagram.AxisX.Label.Font = new Font("Segoe UI", 9);
                    diagram.AxisX.Label.TextColor = Color.FromArgb(255, 96, 96, 96);

                    // Range trục X
                    diagram.AxisX.VisualRange.Auto = false;
                    diagram.AxisX.VisualRange.SetMinMaxValues(1, 30);
                    diagram.AxisX.WholeRange.SetMinMaxValues(1, 30);
                    diagram.AxisX.NumericScaleOptions.GridAlignment = NumericGridAlignment.Custom;
                    diagram.AxisX.NumericScaleOptions.CustomGridAlignment = 5;

                    // TRỤC Y - SỬA QUAN TRỌNG: KHÔNG CHO HIỆN SỐ ÂM
                    diagram.AxisY.Title.Text = "SỐ LƯỢT MƯỢN";
                    diagram.AxisY.Title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    diagram.AxisY.Title.Visibility = DefaultBoolean.True;

                    diagram.AxisY.NumericOptions.Format = NumericFormat.Number;
                    diagram.AxisY.NumericOptions.Precision = 0;
                    diagram.AxisY.Label.Font = new Font("Segoe UI", 9);

                    // SỬA QUAN TRỌNG: Set range từ 0 đến max value
                    // SỬA: Set range từ 0 đến maxLuotMuon +2
                    int maxYValue = Math.Max(maxLuotMuon + 2, 5); // Đảm bảo ít nhất là 5

                    diagram.AxisY.VisualRange.Auto = false;
                    diagram.AxisY.VisualRange.SetMinMaxValues(0, maxYValue); // CHẮC CHẮN MIN = 0
                    diagram.AxisY.WholeRange.Auto = false;
                    diagram.AxisY.WholeRange.SetMinMaxValues(0, maxYValue);

                    // Khoảng cách = 1
                    diagram.AxisY.NumericScaleOptions.GridAlignment = NumericGridAlignment.Custom;
                    diagram.AxisY.NumericScaleOptions.CustomGridAlignment = 1;

                    // Grid lines
                    diagram.AxisY.GridLines.Visible = true;
                    diagram.AxisY.GridLines.Color = Color.LightGray;
                }

                // Title đẹp
                ChartTitle title = new ChartTitle();
                title.Text = "THỐNG KÊ LƯỢT MƯỢN SÁCH THEO NGÀY";
                title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                title.TextColor = Color.FromArgb(255, 42, 99, 195);
                title.Alignment = StringAlignment.Center;
                title.Dock = ChartTitleDockStyle.Top;
                chartLuotmuon.Titles.Add(title);

                // Refresh
                chartLuotmuon.RefreshData();
                chartLuotmuon.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cấu hình biểu đồ: " + ex.Message);
            }
        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadChartDataTheoNgay();
            TaiDuLieuDashboard();
        }
    }
}
