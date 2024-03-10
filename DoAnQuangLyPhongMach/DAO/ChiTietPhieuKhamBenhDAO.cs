using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class ChiTietPhieuKhamBenhDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()//chưa dùng
        {
            string sql = string.Format("select * from(PhieuKhamBenh join " +
                "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
                "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
                "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma");
            return db.LayDuLieu(sql);
        }

        public DataTable LayDuLieu_BaoCaoSuDungThuoc(DateTime tg)
        {
            string sql = string.Format("select  ROW_NUMBER() OVER (ORDER BY t_ma) STT, t_ten,dvt_ten,sum(ctpkb_soLuong) soLuong,count(ctpkb_ma_pkb) soLanDung " +
                " from Thuoc " +
                "left join " +
                "(PhieuKhamBenh join HoaDon on pkb_ma = hd_ma_pkb and hd_trangThai = 2 " +
                "join ChiTietPKB on pkb_ma = ctpkb_ma_pkb " +
                "join DonViTinh on ctpkb_ma_donViTinh = dvt_ma) " +
                "on t_ma = ctpkb_ma_thuoc " +
                "where MONTH(pkb_ngayKham)= {0} and YEAR(pkb_ngayKham)= {1} " +
                "group by t_ma,t_ten,dvt_ten", tg.ToString("MM"),tg.ToString("yyyy"));
            return db.LayDuLieu(sql);
        }
        public DataTable LayDuLieu(int maPKB)
        {
            string sql = string.Format("select ROW_NUMBER() OVER (ORDER BY ctpkb_ma) STT,* from ChiTietPKB " +
                "left join Thuoc  on ctpkb_ma_Thuoc = t_ma " +
                "left join DonViTinh on ctpkb_ma_donViTinh = dvt_ma " +
                "left join CachDung on ctpkb_ma_cachDung = cd_ma " +
                "where ctpkb_ma_pkb = {0}", maPKB);
            return db.LayDuLieu(sql);
        }
        public DataTable LayDuLieu(int maPKB, int maThuoc)
        {
            string sql = string.Format("select * from ChiTietPKB " +
                "left join Thuoc  on ctpkb_ma_Thuoc = t_ma " +
                "left join DonViTinh on ctpkb_ma_donViTinh = dvt_ma " +
                "where ctpkb_ma_pkb = {0} and ctpkb_ma_thuoc = {1} ", maPKB, maThuoc);
            return db.LayDuLieu(sql);
        }
      
        public int Them(ChiTietPhieuKhamBenh ctpkb)
        {
            string sql = string.Format("Insert Into ChiTietPKB(ctpkb_ma_pkb, ctpkb_ma_thuoc,ctpkb_ma_donViTinh,ctpkb_gia,ctpkb_soLuong,ctpkb_tongTien,ctpkb_ma_cachDung) " +
                "Values({0}, {1}, {2},{3}, {4}, {5}, {6})", ctpkb.PhieuKhamBenh.Ma, ctpkb.Thuoc.Ma,ctpkb.DonViTinh.Ma, ctpkb.Gia,ctpkb.SoLuong,ctpkb.Gia* ctpkb.SoLuong,ctpkb.CachDung.Ma);
            return db.ThucThi(sql);
        }
        public int CapNhat(ChiTietPhieuKhamBenh ctpkb)// cập nhật theo pkb có sẵng, không sửa đổi thông tin phiếu khám bệnh
        {
            string sql = string.Format("Update ChiTietPKB Set ctpkb_ma_thuoc={0},ctpkb_ma_donViTinh={1},ctpkb_gia={2},ctpkb_soLuong={3},ctpkb_tongTien={4},ctpkb_ma_cachDung={5} " +
                "Where ctpkb_ma = {6}", ctpkb.Thuoc.Ma, ctpkb.DonViTinh.Ma, ctpkb.Gia, ctpkb.SoLuong, ctpkb.Gia * ctpkb.SoLuong, ctpkb.CachDung.Ma,ctpkb.Ma);
            return db.ThucThi(sql);
        }
        public int Xoa(ChiTietPhieuKhamBenh ctpkb)
        {
            string sql = string.Format("DELETE FROM ChiTietPKB WHERE ctpkb_ma={0} ", ctpkb.Ma);
            return db.ThucThi(sql);
        }
       

        public int TimMaSo()
        {
            return db.TimMaSo("ChiTietPKB", "ctpkb_ma");
        }
    }
}
