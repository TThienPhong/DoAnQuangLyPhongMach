using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class TrangThaiPKBDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from TrangThaiPKB ";
            return db.LayDuLieu(sql);

        }

        public int Them(LoaiBenh lb)
        {
            string sql = string.Format("Insert Into LoaiBenh(lb_ten,lb_ghiChu) " +
              "Values(N'{0}', N'{1}')", lb.Ten, lb.GhiChu);
            return db.ThucThi(sql);
           
        }
        public int CapNhat(LoaiBenh lb)
        {
            string sql = string.Format("Update LoaiBenh Set lb_ten=N'{0}', lb_ghiChu=N'{1}' " +
               "Where lb_ma = {2}", lb.Ten, lb.GhiChu, lb.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(LoaiBenh lb)
        {
            string sql = string.Format("Update LoaiBenh Set lb_xoa=1 " +
               "Where lb_ma = {0}", lb.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {           
            return db.TimMaSo("LoaiBenh","lb_ma");
        }
    }
}
