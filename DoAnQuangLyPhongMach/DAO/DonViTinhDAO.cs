using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class DonViTinhDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from DonViTinh where dvt_xoa=0";
            return db.LayDuLieu(sql);
        }

        public int Them(DonViTinh dvt)
        {        
            string sql = string.Format("Insert Into DonViTinh(dvt_ten,dvt_ghiChu) " +
              "Values('{0}', '{1}')", dvt.Ten, dvt.GhiChu);
            return db.ThucThi(sql);           
        }
        public int CapNhat(DonViTinh dvt)
        {
            string sql = string.Format("Update DonViTinh Set dvt_ten='{0}', dvt_ghiChu='{1}'  " +
               "Where dvt_ma = {2}", dvt.Ten, dvt.GhiChu, dvt.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(DonViTinh dvt)
        {
            string sql = string.Format("Update DonViTinh Set dvt_xoa=1 " +
               "Where dvt_ma = {0}", dvt.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {           
            return db.TimMaSo("DonViTinh", "dvt_ma");
        }
    }
}
