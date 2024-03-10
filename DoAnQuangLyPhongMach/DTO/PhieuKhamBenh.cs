using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class PhieuKhamBenh
    {
        public int Ma { get; set; }
        public BenhNhan BenhNhanKham{ get; set; }
        public DateTime NgayKham { get; set; }// true : nam, false: nữ
        public string TrieuChung { get; set; }
        public LoaiBenh BenhDuDoan { get; set; }
        public  TrangThaiPKB TrangThai { get; set; }
    }
}
