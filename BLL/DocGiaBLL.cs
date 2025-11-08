using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Data;

namespace QLTVNhom3.BLL
{
    public class DocGiaBLL
    {
        private DocGiaDAL docGiaDAL = new DocGiaDAL();

        // Hàm này được gọi bởi ucDocgiathuthu
        public DataTable LayLichSuMuonTra(int maDocGia)
        {
            if (maDocGia <= 0)
            {
                return new DataTable();
            }
            return docGiaDAL.LayLichSuMuonTra(maDocGia);
        }
        public bool KiemTraPhieuMuonTonTai(int maDocGia)
        {
            return docGiaDAL.KiemTraPhieuMuonTonTai(maDocGia);
        }

        // (Bạn có thể thêm các hàm BLL khác ở đây nếu muốn
        // thay vì gọi DAL trực tiếp từ UI)
    }
}