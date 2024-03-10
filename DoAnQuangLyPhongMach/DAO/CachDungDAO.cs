using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class CachDungDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from CachDung where cd_xoa=0";
            return db.LayDuLieu(sql);
        }

        public int Them(CachDung cd)
        {
            string sql = string.Format("Insert Into CachDung(cd_ten, cd_ghiChu) " +
              "Values('{0}', '{1}')", cd.Ten, cd.GhiChu);
            return db.ThucThi(sql);
           
        }
        public int CapNhat(CachDung cd)
        {
            string sql = string.Format("Update CachDung Set cd_ten='{0}', cd_ghiChu='{1}'  " +
               "Where cd_ma = {2}", cd.Ten,cd.GhiChu, cd.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(CachDung cd)
        {
            string sql = string.Format("Update CachDung Set cd_xoa=1 " +
               "Where cd_ma = {0}", cd.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {           
            return db.TimMaSo("CachDung","cd_ma");
        }
    }
}
