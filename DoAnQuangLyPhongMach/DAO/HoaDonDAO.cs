using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class HoaDonDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "Select * from HoaDon where hd_trang_thai=2 ";
            return db.LayDuLieu(sql);
        }
        public DataTable LayDuLieu_BaoCaoDoanhThu(DateTime tg)
        {
            string sql = string.Format("select pkb_ngayKham,count(pkb_ma) soBenhNhan,sum(hd_tongTien)doanhThu, " +
                "sum(hd_tongTien) * 100.0 / sum(Sum(hd_tongTien)) over() tyLe " +
                "from PhieuKhamBenh " +
                "left join HoaDon on hd_ma_pkb = pkb_ma " +
                "where pkb_ma_trangThai = 2 and MONTH(pkb_ngayKham) = {0} " +
                "and YEAR(pkb_ngayKham) = {1} group by pkb_ngayKham",tg.ToString("MM"), tg.ToString("yyyy"));
            return db.LayDuLieu(sql);
        }

        public DataTable TimHoaDon(int maPKB)
        {
            string sql = string.Format("Select * from HoaDon " +
                "left join TrangThaiHD on hd_trangThai=tthd_ma " +
                "where hd_ma_pkb={0}",maPKB);
            return db.LayDuLieu(sql);
        }
        public DataTable TimHoaDonChuaHuy(int maPKB)
        {
            string sql = string.Format("Select * from HoaDon " +
                "left join TrangThaiHD on hd_trangThai=tthd_ma " +
                " where hd_ma_pkb={0} and hd_trangThai<>3", maPKB);
            return db.LayDuLieu(sql);
        }
        public int Them(HoaDon hd)
        {
            string sql = string.Format("Insert Into HoaDon(hd_ma_pkb, hd_tienKham, hd_tienThuoc, hd_tongTien, hd_trangThai) " +
              "Values({0},{1},{2},{3},{4})", hd.PKB.Ma,hd.TienKham,hd.TienThuoc,0,1);
            return db.ThucThi(sql);         
        }
        public int CapNhatThanhToan(HoaDon hd)
        {
            string sql = string.Format("Update HoaDon Set hd_trangThai=2, hd_tongTien={0} " +
               "Where hd_ma = {1}", hd.TongTien,hd.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(GioiTinh gt)//chưa dùng
        {
            string sql = string.Format("Update GioiTinh Set gt_xoa=1 " +
               "Where gt_ma = {0}", gt.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()// chưa dùng
        {           
            return db.TimMaSo("HoaDon","hd_ma");
        }
    }
}
