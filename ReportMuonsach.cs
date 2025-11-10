using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;

namespace QLTVNhom3
{
    public partial class ReportMuonsach : UserControl
    {
        private DocumentViewer documentViewer1;

        public ReportMuonsach()
        {
            InitializeComponent();
            LoadThang();
            KhoiTaoViewer();
        }

        private void LoadThang()
        {
            cbxLoc.Items.Clear();
            int year = DateTime.Now.Year;
            for (int month = 1; month <= 12; month++)
            {
                cbxLoc.Items.Add($"{year}-{month:D2}");
            }
            cbxLoc.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void KhoiTaoViewer()
        {
            documentViewer1 = new DocumentViewer
            {
                Name = "documentViewer1",
                Dock = DockStyle.Fill
            };

            tableLayoutPanel1.Controls.Add(documentViewer1, 0, 1);
            tableLayoutPanel1.SetColumnSpan(documentViewer1, 2);
            tableLayoutPanel1.SetRowSpan(documentViewer1, 2);
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string thangChon = cbxLoc.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(thangChon))
            {
                MessageBox.Show("Vui lòng chọn thời gian trước khi xem báo cáo!", "Thông báo");
                return;
            }

            try
            {
                var report = new BaocaoMuonsach();

                // Tạo SqlDataSource mới nếu report chưa có
                var sqlData = report.DataSource as SqlDataSource;
                if (sqlData == null)
                {
                    // Sử dụng ConnectionString từ app.config
                    var connectionParameters = new MsSqlConnectionParameters
                    {
                        ServerName = "YOUR_SERVER",
                        DatabaseName = "YOUR_DATABASE",
                        UserName = "YOUR_USER",
                        Password = "YOUR_PASSWORD",
                        AuthorizationType = MsSqlAuthorizationType.SqlServer
                    };
                    sqlData = new SqlDataSource(connectionParameters);
                    report.DataSource = sqlData;
                }

                // Tạo CustomSqlQuery với Parameter
                var query = new CustomSqlQuery
                {
                    Name = "PhieuMuonTheoThang",
                    Sql = "SELECT * FROM PhieuMuon WHERE Thang = @Thang"
                };

                // Tạo Parameter
                query.Parameters.Add(new QueryParameter
                {
                    Name = "Thang",
                    Type = typeof(string),
                    Value = thangChon
                });

                sqlData.Queries.Clear();
                sqlData.Queries.Add(query);
                sqlData.RebuildResultSchema();

                documentViewer1.DocumentSource = report;
                report.CreateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BaocaoMuonsach report = documentViewer1.DocumentSource as BaocaoMuonsach;
            /*BaocaoMuonsach report = new BaoCaoMuonsach(); 
            sql = select * from PhieuMuon where Thang = @Thang  
            da = new SqlDataAdapter(sql, conn); 
            DataTable rdt = new DataTable();  
            da.Fill(rdt);   
            rpt.xrgroupgby.Text = "Điều kiện lọc dữ liệu"  "+cbxLoc.SelectedItem.ToString(); -đoạn này là cái comnTruong nọ thầy dạy
            BaocaoMuonsach.Text = string.Format("Hà Nội, ngày {0} tháng {1} năm {2}", datetime.now.day, datetime.now.month, datetime.now.year);
            BaocaoMuonsach.datasource = rpt;
            rpt.ShowPreviewDialog();
            */
        }
    }
}