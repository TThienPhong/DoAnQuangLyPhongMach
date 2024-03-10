using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class BenhNhan
    {
        public int Ma{get;set;}
        public string Ten { get; set; }
        public GioiTinh GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public bool Xoa { get; set; }
    }
}
