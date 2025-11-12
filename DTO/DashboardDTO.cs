using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVNhom3.DTO
{
    public class DashboardDTO
    {
        public int TongDauSach { get; set; }
        public int SoSachMuon { get; set; }
        public int SoSachQuaHan { get; set; }
        public int TongDocGia { get; set; }
        public int SachYeuThich { get; set; }
    }
    public class LuotMuonTheoThangDTO
    { 
        public string Thang {  get; set; }
        public int LuotMuon { get; set; }
    }
}
