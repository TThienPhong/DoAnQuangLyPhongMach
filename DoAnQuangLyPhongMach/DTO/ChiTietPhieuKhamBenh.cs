using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class ChiTietPhieuKhamBenh
    {
        public int Ma { get; set; }
        public PhieuKhamBenh PhieuKhamBenh { get; set; }
        public Thuoc Thuoc { get; set; }
        public DonViTinh DonViTinh { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public int TongGia { get; set; }
        public CachDung CachDung { get; set; }
    }
}
