using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class BenhNhanDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select ROW_NUMBER() OVER (ORDER BY bn_ma) STT , BenhNhan.*,GioiTinh.* from BenhNhan left join GioiTinh on bn_gioiTinh=gt_ma where bn_xoa=0";
            return db.LayDuLieu(sql);
        }

        public int Them(BenhNhan bn)
        {
           
            string sql = string.Format("Insert Into BenhNhan(bn_ten,bn_gioiTinh,bn_namSinh,bn_diaChi) " +
              "Values(N'{0}', {1}, {2}, N'{3}')", bn.Ten, bn.GioiTinh.Ma, bn.NamSinh, bn.DiaChi);
            return db.ThucThi(sql);
           
        }
        public int CapNhat(BenhNhan bn)
        {
            
            string sql = string.Format("Update BenhNhan Set bn_ten=N'{0}', bn_gioiTinh={1}, bn_namSinh={2}, bn_diaChi=N'{3}' " +
               "Where bn_ma = {4}", bn.Ten, bn.GioiTinh.Ma, bn.NamSinh, bn.DiaChi, bn.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(BenhNhan bn)
        {
           
            string sql = string.Format("Update BenhNhan Set bn_xoa=1 " +
               "Where bn_ma = {0}", bn.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {           
            return db.TimMaSo("BenhNhan","bn_ma");
        }
    }
}
