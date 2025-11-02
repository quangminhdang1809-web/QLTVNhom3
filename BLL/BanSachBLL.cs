using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.BLL
{
    public class BanSachBLL
    {
        private BanSachDAL banSachDAL = new BanSachDAL();
        public List<BanSachDTO> LayDanhSachBanSach(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
                throw new ArgumentException("Mã đầu sách không được để trống");

            return banSachDAL.LayDanhSachBanSach(maDauSach);
        }

        public int DemSoSachSanCo(string maDauSach)
        {
            if (string.IsNullOrEmpty(maDauSach))
                return 0;

            return banSachDAL.DemSoSachSanCo(maDauSach);
        }
    }
}
