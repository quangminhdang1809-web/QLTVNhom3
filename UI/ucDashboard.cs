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
        private ChartControl chartLuotMuon;
        private ChartControl chartTinhTrangSach;

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
                if (dgvSachYeuThich.Columns.Count > 0)
                {
                    dgvSachYeuThich.Columns["MaDauSach"].HeaderText = "Mã đầu sách";
                    dgvSachYeuThich.Columns["TenDauSach"].HeaderText = "Tên sách";
                    dgvSachYeuThich.Columns["TenTheLoai"].HeaderText = "Thể loại";
                    dgvSachYeuThich.Columns["SoLanMuon"].HeaderText = "Số lần mượn";
                }

                // Căn giữa nội dung các cột
                foreach (DataGridViewColumn column in dgvSachYeuThich.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
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

            // Cập nhật label tổng số sách quá hạn
            lblSoSachDenHan.Text = danhSach.Rows.Count.ToString();

            // Hiển thị DataGridView sách quá hạn
            dgvSachQuaHan.DataSource = danhSach;

            // Đặt tên cột tiếng Việt
            if (dgvSachQuaHan.Columns.Count > 0)
            {
                dgvSachQuaHan.Columns["MaSach"].HeaderText = "Mã sách";
                dgvSachQuaHan.Columns["TenDauSach"].HeaderText = "Tên sách";
                dgvSachQuaHan.Columns["TenDocGia"].HeaderText = "Tên độc giả";
                dgvSachQuaHan.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgvSachQuaHan.Columns["SoNgayQuaHan"].HeaderText = "Quá hạn (Ngày)";
            }

            // Căn giữa nội dung các cột
            foreach (DataGridViewColumn column in dgvSachQuaHan.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

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

        private void InitializeChart()
        {
            try
            {
                // Tạo ChartControl
                chartLuotMuon = new ChartControl();
                chartLuotMuon.Location = new Point(1319, 470);
                chartLuotMuon.Size = new Size(1055, 508);
                chartLuotMuon.Name = "chartLuotMuon";

                // Thêm vào panel
                pnlMaincontent.Controls.Add(chartLuotMuon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo chart: " + ex.Message);
            }
        }

        private void LoadChartDataTheoNgay()
        {
            try
            {
                if (chartLuotMuon == null) return;

                // Load dữ liệu
                DashboardDAL dal = new DashboardDAL();
                DataTable data = dal.GetLuotMuonTheoNgayTrongThang();

                // Clear chart
                chartLuotMuon.Series.Clear();
                chartLuotMuon.Titles.Clear();
                chartLuotMuon.Legend.Visibility = DefaultBoolean.False;

                // Apply beautiful palette
                chartLuotMuon.PaletteName = "Office";

                // Create series
                Series series = new Series("Số lượt mượn", ViewType.Bar);

                // Configure series với style đẹp
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ValueScaleType = ScaleType.Numerical;
                series.LabelsVisibility = DefaultBoolean.False;

                // Bar appearance đẹp
                BarSeriesView barView = series.View as BarSeriesView;
                if (barView != null)
                {
                    barView.Color = Color.FromArgb(255, 106, 90, 205);
                    barView.FillStyle.FillMode = FillMode.Gradient;
                    barView.Border.Color = Color.FromArgb(255, 72, 61, 139);
                    barView.Border.Visibility = DefaultBoolean.True;
                    barView.Border.Thickness = 2;
                    barView.Shadow.Size = 4;
                    barView.Shadow.Color = Color.FromArgb(50, 0, 0, 0);
                    barView.BarWidth = 0.8;
                }

                int maxLuotMuon = 0;

                // Add data từ database
                foreach (DataRow row in data.Rows)
                {
                    int ngay = Convert.ToInt32(row["Ngay"]);
                    int luotMuon = Convert.ToInt32(row["LuotMuon"]);

                    if (luotMuon > 0)
                    {
                        series.Points.Add(new SeriesPoint(ngay, luotMuon));
                        if (luotMuon > maxLuotMuon)
                            maxLuotMuon = luotMuon;
                    }
                }

                // Nếu không có dữ liệu, thêm dữ liệu demo
                if (series.Points.Count == 0)
                {
                    series.Points.Add(new SeriesPoint(10, 5));
                    series.Points.Add(new SeriesPoint(15, 8));
                    series.Points.Add(new SeriesPoint(20, 3));
                    maxLuotMuon = 8;
                }

                chartLuotMuon.Series.Add(series);

                // Configure diagram đẹp
                XYDiagram diagram = chartLuotMuon.Diagram as XYDiagram;
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

                    // TRỤC Y
                    diagram.AxisY.Title.Text = "SỐ LƯỢT MƯỢN";
                    diagram.AxisY.Title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    diagram.AxisY.Title.Visibility = DefaultBoolean.True;

                    diagram.AxisY.NumericOptions.Format = NumericFormat.Number;
                    diagram.AxisY.NumericOptions.Precision = 0;
                    diagram.AxisY.Label.Font = new Font("Segoe UI", 9);

                    // Set range từ 0 đến max value
                    int maxYValue = Math.Max(maxLuotMuon + 2, 5);

                    diagram.AxisY.VisualRange.Auto = false;
                    diagram.AxisY.VisualRange.SetMinMaxValues(0, maxYValue);
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
                chartLuotMuon.Titles.Add(title);

                // Refresh
                chartLuotMuon.RefreshData();
                chartLuotMuon.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo biểu đồ: " + ex.Message);
            }
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

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            TaiDuLieuDashboard();
            InitializeChart();     // Khởi tạo chart
            LoadChartDataTheoNgay(); // Load dữ liệu chart
            InitializePieChart();     // Pie chart tình trạng sách - THÊM DÒNG NÀY
            LoadPieChartData();
        }

        private void pnlMaincontent_Paint(object sender, PaintEventArgs e)
        {
            // Có thể để trống hoặc xóa method này nếu không cần
        }
        private void InitializePieChart()
        {
            try
            {
                // Tạo Pie Chart
                chartTinhTrangSach = new ChartControl();
                chartTinhTrangSach.Location = new Point(256, 470); // Vị trí bên trái
                chartTinhTrangSach.Size = new Size(734, 508);
                chartTinhTrangSach.Name = "chartTinhTrangSach";

                // Thêm vào panel
                pnlMaincontent.Controls.Add(chartTinhTrangSach);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo pie chart: " + ex.Message);
            }
        }

        private void LoadPieChartData()
        {
            try
            {
                if (chartTinhTrangSach == null) return;

                DashboardDAL dal = new DashboardDAL();
                DataTable data = dal.GetThongKeTinhTrangSach();

                chartTinhTrangSach.Series.Clear();
                chartTinhTrangSach.Titles.Clear();

                Series series = new Series("Tình trạng sách", ViewType.Pie);

                Font vietnameseFont = new Font("Arial", 9, FontStyle.Regular);

                series.LabelsVisibility = DefaultBoolean.False;
                series.Label.TextPattern = "{A}: {V} ({VP:P0})";
                series.Label.Font = vietnameseFont;

                // Add data
                foreach (DataRow row in data.Rows)
                {
                    string tinhTrang = row[0].ToString();  // Cột đầu tiên
                    int soLuong = Convert.ToInt32(row[1]); // Cột thứ hai
                    series.Points.Add(new SeriesPoint(tinhTrang, soLuong));
                }

                string[] colors = { "#2E7D32", // Xanh lá đậm
    "#1565C0", // Xanh dương đậm  
    "#C62828", // Đỏ đậm
    "#EF6C00", // Cam đậm
    "#6A1B9A", // Tím đậm
    "#00695C"};
                for (int i = 0; i < series.Points.Count; i++)
                {
                    if (i < colors.Length)
                    {
                        series.Points[i].Color = ColorTranslator.FromHtml(colors[i]);
                    }
                }

                chartTinhTrangSach.Series.Add(series);

                PieSeriesView pieView = series.View as PieSeriesView;
                if (pieView != null)
                {
                    pieView.Border.Visibility = DefaultBoolean.True;
                    pieView.Border.Color = Color.White;
                    pieView.Border.Thickness = 2;
                }

                // Legend
                chartTinhTrangSach.Legend.Visibility = DefaultBoolean.True;
                chartTinhTrangSach.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right;
                chartTinhTrangSach.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
                chartTinhTrangSach.Legend.Font = vietnameseFont;
                // ✅ HIỂN THỊ THÔNG TIN TRONG LEGEND
                series.LegendTextPattern = "{A}: {V} ({VP:P0})";

                // ✅ TITLE ĐƠN GIẢN
                ChartTitle title = new ChartTitle();
                title.Text = "THỐNG KÊ TÌNH TRẠNG SÁCH";
                title.Font = new Font("Arial", 12, FontStyle.Bold);
                title.TextColor = Color.FromArgb(255, 42, 99, 195);
                title.Alignment = StringAlignment.Center;
                title.Dock = ChartTitleDockStyle.Top;
                chartTinhTrangSach.Titles.Add(title);

                chartTinhTrangSach.RefreshData();
                chartTinhTrangSach.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo pie chart: " + ex.Message);
            }
        }
    }
}