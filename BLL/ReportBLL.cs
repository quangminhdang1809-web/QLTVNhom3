using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;

namespace QLTVNhom3.BLL
{
    public class ReportBLL
    {
        private ReportDAL reportDAL;

        public ReportBLL()
        {
            reportDAL = new ReportDAL();
        }

        // 2. Sách quá hạn
        public List<ReportDTO.OverdueBookDTO> GetOverdueBooks()
        {
            return reportDAL.GetOverdueBooks();
        }

        public ReportDTO.OverdueSummaryDTO GetOverdueSummary()
        {
            return reportDAL.GetOverdueSummary();
        }

        // 3. Tiền phạt
        public List<ReportDTO.FineReportDTO> GetFineReports(DateTime startDate, DateTime endDate)
        {
            // Validate ngày tháng
            if (startDate > endDate)
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc");

            return reportDAL.GetFineReports(startDate, endDate);
        }

        public ReportDTO.FineReportSummaryDTO GetFineReportSummary(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc");

            return reportDAL.GetFineReportSummary(startDate, endDate);
        }
        public List<ReportDTO.BookInventoryDTO> GetBookInventoryStatus()
        {
            // Giả sử ReportDAL của bạn tên là reportDAL
            return reportDAL.GetBookInventoryStatus();
        }
        public List<ReportDTO.SimpleFineReportDTO> GetSimpleFineReports(DateTime startDate, DateTime endDate)
        {
            // Validate ngày tháng
            if (startDate > endDate)
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc");

            return reportDAL.GetSimpleFineReports(startDate, endDate);
        }
    }
}

