using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class ThamSo
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string KieuDuLieu { get; set; }
        public int GiaTri { get; set; }
        public bool Tat { get; set; }

        public static List<ThamSo> dsThamSo;
    }
}
