using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class TrangThaiHDDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from TrangThaiHD ";
            return db.LayDuLieu(sql);

        }
        public DataTable LayTrangThaiHoaDonMoi()
        {
            string sql = "Select * from TrangThaiHD where tthd_ma=1 ";
            return db.LayDuLieu(sql);
        }
        public DataTable LayTrangThaiHoaDonThanhToan()
        {
            string sql = "Select * from TrangThaiHD where tthd_ma=2 ";
            return db.LayDuLieu(sql);
        }

        public int Them(TrangThaiHD tt)// Chưa Cần Dùng
        {
            string sql = string.Format("Insert Into TrangThaiHD(tthd_ten) " +
              "Values(N'{0}')", tt.Ten);
            return db.ThucThi(sql);
        }
        public int CapNhat(TrangThaiHD tt) // Chưa Cần Dùng
        {
            string sql = string.Format("Update TrangThaiHD Set tthd_ten=N'{0}' " +
               "Where tthd_ma = {1}", tt.Ten, tt.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(TrangThaiHD tt) // Chưa Cần Dùng
        {
            string sql = string.Format("Update GioiTinh Set tthd_xoa=1 " +
               "Where tthd_ma = {0}", tt.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo() // Chưa Cần Dùng
        {
            return db.TimMaSo("TrangThaiHH", "tthd_ma");
        }
    }
}
