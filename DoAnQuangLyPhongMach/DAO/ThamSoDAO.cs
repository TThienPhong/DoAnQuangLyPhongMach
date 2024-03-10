using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    class ThamSoDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from ThamSo";
            return db.LayDuLieu(sql);
        }

        public int Them(ThamSo ts)
        {
            int sotat = Convert.ToInt32(ts.Tat);
            
            string sql = string.Format("Insert Into ThamSo(ts_ten, ts_kieuDuLieu,ts_giaTri,ts_trangThaiTat) " +
              "Values(N'{0}', N'{1}', {2}, {3})", ts.Ten, ts.KieuDuLieu, ts.GiaTri, sotat);
            return db.ThucThi(sql);

        }
        public int CapNhat(ThamSo ts)
        {
            int sotat = Convert.ToInt32(ts.Tat);
            string sql = string.Format("Update ThamSo Set ts_ten=N'{0}', ts_giaTri={1}, ts_trangThaiTat={2} " +
               "Where ts_ma = {3}", ts.Ten,  ts.GiaTri, sotat, ts.Ma);
            return db.ThucThi(sql);
        }
       
        public int TimMaSo()
        {
            return db.TimMaSo("ThamSo", "ts_ma");
        }
       
    }
}
