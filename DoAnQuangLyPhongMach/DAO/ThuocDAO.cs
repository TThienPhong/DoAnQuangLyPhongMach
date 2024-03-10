using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class ThuocDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            //string sql = "Select t_ma, t_ten, dvt_ten,t_gia, t_ghiChu, t_ma_donViTinh, t_xoa from Thuoc, DonViTinh where t_ma_donViTinh=dvt_ma and t_xoa=false";
            string sql = "Select * ,ROW_NUMBER() OVER (ORDER BY t_ma) STT From Thuoc LEFT JOIN DonViTinh on t_ma_donViTinh=dvt_ma where t_xoa='false'";
            return db.LayDuLieu(sql);
        }

        public int Them(Thuoc t)
        {

            string sql = string.Format("Insert Into Thuoc(t_ten,t_ma_donViTinh,t_gia, t_ghiChu) " +
              "Values( N'{0}', {1}, {2}, N'{3}')", t.Ten, t.DoViTinh.Ma, t.Gia, t.GhiChu);
            return db.ThucThi(sql);

        }
        public int CapNhat(Thuoc t)
        {
            string sql = string.Format("Update Thuoc Set t_ten=N'{0}', t_ma_donViTinh={1}, t_gia={2}, t_ghiChu=N'{3}' " +
               "Where t_ma = {4}", t.Ten, t.DoViTinh.Ma, t.Gia, t.GhiChu,t.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(Thuoc t)
        {
            string sql = string.Format("Update Thuoc Set t_xoa='true' " +
               "Where t_ma = {0}", t.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {
            return db.TimMaSo("Thuoc", "t_ma");
        }
    }
}
