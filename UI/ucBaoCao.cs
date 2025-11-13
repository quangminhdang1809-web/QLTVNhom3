using QLTVNhom3.BLL;
using QLTVNhom3.DTO;
using QLTVNhom3.UI.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLTVNhom3
{
    public partial class ucBaoCao : UserControl
    {
        private ReportBLL reportBLL = new ReportBLL();
        private readonly Dictionary<string, string> dsBaoCao;

        public ucBaoCao()
        {
            InitializeComponent();

            dsBaoCao = new Dictionary<string, string>
            {
                { "Sách quá hạn", "SachQuaHan" },
                { "Báo cáo tiền phạt", "TienPhat" },
                { "Báo cáo tình trạng sách theo nhan đề", "TinhTrangSach" }
            };

            this.Load += ucBaoCao_Load;
            this.btnThongKe.Click += btnThongKe_Click;
            this.cbxChonMauBaoCao.SelectedIndexChanged += cbxChonMauBaoCao_SelectedIndexChanged;
        }

        private void ucBaoCao_Load(object sender, EventArgs e)
        {
            cbxChonMauBaoCao.DataSource = new BindingSource(dsBaoCao, null);
            cbxChonMauBaoCao.DisplayMember = "Key";
            cbxChonMauBaoCao.ValueMember = "Value";

            grdThongKe.ReadOnly = true;
            grdThongKe.AllowUserToAddRows = false;
            grdThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Chọn mục đầu tiên
            if (cbxChonMauBaoCao.Items.Count > 0)
                cbxChonMauBaoCao.SelectedIndex = 0;
        }

        private void cbxChonMauBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null) return;
            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();

            if (loaiBaoCao == "TienPhat")
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
            else
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }

            // Xóa dữ liệu cũ khi chọn báo cáo mới
            grdThongKe.DataSource = null;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo!", "Thông báo");
                return;
            }

            string loaiBaoCao = cbxChonMauBaoCao.SelectedValue.ToString();

            try
            {
                Cursor = Cursors.WaitCursor;
                btnThongKe.Enabled = false;

                object data = GetReportData(loaiBaoCao);

                if (data != null)
                {
                    grdThongKe.DataSource = data;
                    grdThongKe.Visible = true;

                    MessageBox.Show($"Đã tìm thấy {GetRowCount(data)} bản ghi", "Thông báo");
                }
                else
                {
                    grdThongKe.DataSource = null;
                    grdThongKe.Visible = false;
                    MessageBox.Show("Không có dữ liệu cho báo cáo này!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi");
                grdThongKe.DataSource = null;
                grdThongKe.Visible = false;
            }
            finally
            {
                Cursor = Cursors.Default;
                btnThongKe.Enabled = true;
            }
        }

        // PHƯƠNG THỨC ĐẾM SỐ DÒNG
        private int GetRowCount(object data)
        {
            if (data is DataTable dt) return dt.Rows.Count;
            if (data is System.Collections.IList list) return list.Count;
            return 0;
        }

        private object GetReportData(string loaiBaoCao)
        {
            return loaiBaoCao switch
            {
                "SachQuaHan" => reportBLL.GetOverdueBooks(),
                "TienPhat" => reportBLL.GetSimpleFineReports(dtpTuNgay.Value, dtpDenNgay.Value), // DÙNG SIMPLE
                "TinhTrangSach" => reportBLL.GetBookInventoryStatus(),
                _ => throw new ArgumentException("Loại báo cáo không hợp lệ")
            };
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cbxChonMauBaoCao.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo!", "Thông báo");
                return;
            }

            string reportType = cbxChonMauBaoCao.SelectedValue.ToString();

            try
            {
                Cursor = Cursors.WaitCursor;
                btnIn.Enabled = false;

                // LẤY DỮ LIỆU TRỰC TIẾP TỪ BLL
                object reportData = GetReportData(reportType);

                if (reportData == null)
                {
                    MessageBox.Show("Không có dữ liệu để in!", "Thông báo");
                    return;
                }

                // CHUYỂN SANG DATATABLE VÀ TÙY CHỈNH
                DataTable dt = ConvertAndCustomizeDataTable(reportData, reportType);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in!", "Thông báo");
                    return;
                }

                // DEBUG: Hiển thị thông tin DataTable
                DebugDataTable(dt, reportType);

                // CHỌN REPORT VÀ HIỂN THỊ
                switch (reportType)
                {
                    case "SachQuaHan":
                        ShowReportWithData<rptSachQuaHan>(dt, "DANH SÁCH MƯỢN QUÁ HẠN CHƯA TRẢ");
                        break;
                    case "TienPhat":
                        ShowReportWithData<rptTienPhatvaSoLuongPP>(dt, "BÁO CÁO TIỀN PHẠT");
                        break;
                    case "TinhTrangSach":
                        ShowReportWithData<rptSachTheoTieuDe>(dt, "BÁO CÁO TÌNH TRẠNG SÁCH THEO NHAN ĐỀ");
                        break;
                    default:
                        MessageBox.Show("Loại báo cáo này chưa được hỗ trợ in!", "Thông báo");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Lỗi");
            }
            finally
            {
                Cursor = Cursors.Default;
                btnIn.Enabled = true;
            }
        }

        // PHƯƠNG THỨC TÙY CHỈNH DATATABLE THEO LOẠI BÁO CÁO
        private DataTable ConvertAndCustomizeDataTable(object data, string reportType)
        {
            if (data == null) return null;

            try
            {
                DataTable dt = ConvertToDataTable(data);

                if (dt == null) return null;

                // TÙY CHỈNH DATATABLE CHO BÁO CÁO TIỀN PHẠT
                if (reportType == "TienPhat")
                {
                    return CreateSimpleFineReportTable(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tùy chỉnh dữ liệu: " + ex.Message, "Lỗi");
                return null;
            }
        }

        // TẠO BÁO CÁO TIỀN PHẠT ĐƠN GIẢN
        // TẠO BÁO CÁO TIỀN PHẠT GROUP THEO NGÀY
        // TẠO BÁO CÁO TIỀN PHẠT ĐƠN GIẢN
        private DataTable CreateSimpleFineReportTable(DataTable originalTable)
        {
            DataTable simpleTable = new DataTable();

            // CÁC CỘT CHO BÁO CÁO MỚI
            simpleTable.Columns.Add("STT", typeof(int));
            simpleTable.Columns.Add("NgayPhat", typeof(DateTime));
            simpleTable.Columns.Add("SoLuongPhieu", typeof(int));
            simpleTable.Columns.Add("TongTienPhat", typeof(decimal));

            // COPY DỮ LIỆU - ĐÃ GROUP SẴN TỪ SQL
            foreach (DataRow row in originalTable.Rows)
            {
                DataRow newRow = simpleTable.NewRow();

                newRow["STT"] = row["STT"];
                newRow["NgayPhat"] = row["NgayPhat"];
                newRow["SoLuongPhieu"] = row["SoLuongPhieu"];
                newRow["TongTienPhat"] = row["TongTienPhat"];

                simpleTable.Rows.Add(newRow);
            }

            return simpleTable;
        }

        // PHƯƠNG THỨC HIỂN THỊ REPORT VỚI DATA
        // PHƯƠNG THỨC HIỂN THỊ REPORT VỚI DATA VÀ PARAMETERS
        private void ShowReportWithData<T>(DataTable dt, string title) where T : XtraReport, new()
        {
            try
            {
                T report = new T();

                // SET DATASOURCE
                report.DataSource = dt;

                // SET PARAMETERS - QUAN TRỌNG!
                if (report.Parameters["TuNgay"] != null)
                    report.Parameters["TuNgay"].Value = dtpTuNgay.Value;

                if (report.Parameters["DenNgay"] != null)
                    report.Parameters["DenNgay"].Value = dtpDenNgay.Value;

                if (report.Parameters["ReportTitle"] != null)
                    report.Parameters["ReportTitle"].Value = title;

                if (report.Parameters["NgayIn"] != null)
                    report.Parameters["NgayIn"].Value = DateTime.Now;
                // THÊM DÒNG NÀY ĐỂ SET TEXT CHO LABEL NGÀY IN
                SetReportDateText(report, "rptNgayIn"); // Hoặc tên control thực tế trong report

                // Đảm bảo các parameters được truyền vào data source
                foreach (DevExpress.XtraReports.Parameters.Parameter param in report.Parameters)
                {
                    param.Visible = false; // Ẩn parameters khỏi UI
                }

                // TẠO DOCUMENT
                report.CreateDocument();

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo báo cáo: {ex.Message}", "Lỗi");
            }
        }
        // PHƯƠNG THỨC SET TEXT CHO LABEL NGÀY IN
        private void SetReportDateText(XtraReport report, string controlName)
        {
            try
            {
                // Tìm control trong report
                var control = report.FindControl(controlName, false);
                if (control is XRLabel label)
                {
                    label.Text = string.Format("NEU, ngày {0} tháng {1} năm {2}",
                        DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Không tìm thấy control {controlName}: {ex.Message}");
            }
        }

        // CHUYỂN ĐỔI LIST SANG DATATABLE
        private DataTable ConvertToDataTable(object data)
        {
            if (data == null) return null;

            try
            {
                // Nếu đã là DataTable thì return luôn
                if (data is DataTable dataTable)
                    return dataTable;

                // Nếu là List<T>
                var dataType = data.GetType();

                if (dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var itemType = dataType.GetGenericArguments()[0];
                    var dt = new DataTable();

                    // Lấy properties của DTO để tạo columns
                    var properties = itemType.GetProperties();
                    foreach (var prop in properties)
                    {
                        // Chỉ lấy các property đơn giản
                        if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                            continue;

                        Type columnType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                        dt.Columns.Add(prop.Name, columnType);
                    }

                    // Thêm dữ liệu
                    foreach (var item in (System.Collections.IEnumerable)data)
                    {
                        var row = dt.NewRow();
                        foreach (var prop in properties)
                        {
                            if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                                continue;

                            var value = prop.GetValue(item);
                            row[prop.Name] = value ?? DBNull.Value;
                        }
                        dt.Rows.Add(row);
                    }

                    return dt;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển đổi dữ liệu: " + ex.Message, "Lỗi");
                return null;
            }
        }

        // PHƯƠNG THỨC DEBUG
        private void DebugDataTable(DataTable dt, string reportType)
        {
            Console.WriteLine($"=== DEBUG {reportType} ===");
            Console.WriteLine($"Số dòng: {dt.Rows.Count}, Số cột: {dt.Columns.Count}");

            Console.WriteLine("Các cột trong DataTable:");
            foreach (DataColumn col in dt.Columns)
            {
                Console.WriteLine($"  - {col.ColumnName} ({col.DataType})");
            }

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Dữ liệu mẫu:");
                for (int i = 0; i < Math.Min(3, dt.Rows.Count); i++)
                {
                    Console.Write($"Dòng {i + 1}: ");
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write($"{col.ColumnName}={dt.Rows[i][col]} | ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=== END DEBUG ===");
        }
    }
}