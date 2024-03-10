using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class GioiTinhDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from GioiTinh ";
            return db.LayDuLieu(sql);

        }

        public int Them(GioiTinh gt)
        {
            string sql = string.Format("Insert Into GioiTinh(gt_ten) " +
              "Values(N'{0}')", gt.Ten);
            return db.ThucThi(sql);         
        }
        public int CapNhat(GioiTinh gt)
        {
            string sql = string.Format("Update GioiTinh Set gt_ten=N'{0}' " +
               "Where gt_ma = {1}", gt.Ten,  gt.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(GioiTinh gt)
        {
            string sql = string.Format("Update GioiTinh Set gt_xoa=1 " +
               "Where gt_ma = {0}", gt.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {           
            return db.TimMaSo("GioiTinh","gt_ma");
        }
    }
}
