using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    public class PhieuKhamBenhDAO
    {
        XLDuLieu db = new XLDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = string.Format("select * from(PhieuKhamBenh join " +
                "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
                "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
                "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma");
            return db.LayDuLieu(sql);
        }
        public DataTable LayDuLieu_BenhNhanDaKham(DateTime ngay1, DateTime ngay2)
        {
            string sql = string.Format("select ROW_NUMBER() OVER (ORDER BY pkb_ma) STT,* " +
                "from PhieuKhamBenh " +
                "left join BenhNhan on pkb_ma_benhNhan = bn_ma " +
                "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma " +
                "where  pkb_ma_trangThai=2 and pkb_ngayKham >= '{0}' and pkb_ngayKham <= '{1}'", ngay1.ToString("yyyy-MM-dd"), ngay2.ToString("yyyy-MM-dd"));
            return db.LayDuLieu(sql);
        }
        public DataTable LayPhieuKhamBenh(int maPKB)
        {
            string sql = string.Format("select * from(PhieuKhamBenh join " +
                "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
                "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
                "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma" +
                "where pkb_ma={0}",maPKB);
            return db.LayDuLieu(sql);
        }
        public DataTable LayPhieuKhamBenh_ChuaKham(int maPKB)
        {
            string sql = string.Format("select * from(PhieuKhamBenh join " +
                "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
                "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
                "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma " +
                "where pkb_ma={0} and pkb_ma_trangThai=1", maPKB);
            return db.LayDuLieu(sql);
        }

        public DataTable LayDuLieu_theoNgay(DateTime ngay)
        {
            string sql = string.Format("select  ROW_NUMBER() OVER (ORDER BY pkb_ma) STT,* from(PhieuKhamBenh join " +
               "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
               "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
               "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma " +
               "where pkb_ngayKham='{0}' and pkb_ma_trangThai <> 3", ngay.ToString("yyyy-MM-dd"));
            return db.LayDuLieu(sql);
        }

        public DataTable LayDuLieu_theoBNvaNgay(DateTime ngay,int maBN)
        {
            string sql = string.Format("select  ROW_NUMBER() OVER (ORDER BY pkb_ma) STT,* from(PhieuKhamBenh join " +
               "(BenhNhan left join GioiTinh on bn_gioiTinh = gt_ma) on pkb_ma_benhNhan = bn_ma) " +
               "left join TrangThaiPKB on pkb_ma_trangThai = ttpkb_ma " +
               "left join LoaiBenh on pkb_ma_loaiBenh = lb_ma " +
               "where pkb_ngayKham='{0}' and pkb_ma_benhNhan={1} and pkb_ma_trangThai<>3", ngay.ToString("yyyy-MM-dd"),maBN);
            return db.LayDuLieu(sql);
        }
        public int lay_SLBenhNhan_KhamTrongNgay(DateTime ngay)
        {
            string sql = string.Format("select  count(*) from PhieuKhamBenh join BenhNhan " +
                "on pkb_ma_benhNhan = bn_ma " +
                "where pkb_ma_trangThai <> 3 and pkb_ngayKham = '{0}'",ngay.ToString("yyyy-MM-dd"));
            DataTable tb= db.LayDuLieu(sql);
            return int.Parse(tb.Rows[0][0].ToString());
        }
        public int Them(PhieuKhamBenh pkb)
        {
            string sql = string.Format("Insert Into PhieuKhamBenh(pkb_ma_benhNhan, pkb_ngayKham) " +
              "Values({0}, '{1}')", pkb.BenhNhanKham.Ma, pkb.NgayKham.ToString("yyyy-MM-dd"));
            return db.ThucThi(sql);
        }
        public int CapNhat(PhieuKhamBenh pkb)// chưa dùng
        {
            string sql = string.Format("Update Thuoc Set t_ten=N'{0}', t_ma_donViTinh={1}, t_gia={2}, t_ghiChu=N'{3}' " +
               "Where t_ma = {4}");
            return db.ThucThi(sql);
        }
        public int Xoa(PhieuKhamBenh pkb)
        {
            string sql = string.Format("Update PhieuKhamBenh Set pkb_ma_trangThai=3 " +
               "Where pkb_ma = {0}", pkb.Ma);
            return db.ThucThi(sql);
        }
        public int DoiTrangThaiDaKham(PhieuKhamBenh pkb)
        {
            string sql = string.Format("Update PhieuKhamBenh Set pkb_ma_TrangThai=2,pkb_ma_loaiBenh={0},pkb_trieuChung=N'{1}' Where pkb_ma = {2}",pkb.BenhDuDoan.Ma,pkb.TrieuChung, pkb.Ma);
            return db.ThucThi(sql);
        }
        public int TimMaSo()
        {
            return db.TimMaSo("Thuoc", "t_ma");
        }
    }
}
