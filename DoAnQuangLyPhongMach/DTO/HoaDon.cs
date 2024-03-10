using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class HoaDon
    {
        public int Ma{get;set;}
        public PhieuKhamBenh PKB { get; set; }      
        public int TienKham { get; set; }
        public int TienThuoc { get; set; }
        public int TongTien { get; set; }
        public TrangThaiHD TrangThai { get; set; }

    }
}
