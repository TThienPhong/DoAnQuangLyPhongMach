using DoAnQuangLyPhongMach.DTO;
using DoAnQuangLyPhongMach.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.BUS
{
    public class ChiTietPhieuKhamBenhBUS

    {
       ChiTietPhieuKhamBenhDAO ctpkbDAO = new ChiTietPhieuKhamBenhDAO();
        public DataTable LayDuLieu()//chưa dùng
        {
            return ctpkbDAO.LayDuLieu();
        }
        public DataTable LayDuLieu(int maPKB)
        {
            return ctpkbDAO.LayDuLieu( maPKB);
        }
        public int Them(ChiTietPhieuKhamBenh ctpkb)
        {
            if (KiemTra_Them(ctpkb) == 0)
            {
                return ctpkbDAO.Them(ctpkb);
            }
            else return KiemTra_Them(ctpkb);
        }
        public int CapNhat(ChiTietPhieuKhamBenh ctpkb)// cập nhật theo pkb có sẵng, không sửa đổi thông tin phiếu khám bệnh
        {
            if (KiemTra_CapNhat(ctpkb) == 0)
            {
                return ctpkbDAO.CapNhat(ctpkb);
            }
            else return KiemTra_CapNhat(ctpkb);         
        }
        public int Xoa(ChiTietPhieuKhamBenh ctpkb)
        {

            if (KiemTra_Xoa(ctpkb) == 0)
            {
                return ctpkbDAO.Xoa(ctpkb);
            }
            else return KiemTra_Xoa(ctpkb);
        }

        public int TimMaSo()
        {
            return ctpkbDAO.TimMaSo();
        }

        public int KiemTra_Them(ChiTietPhieuKhamBenh ctpkb)
        {
           

            if (!(KiemTraPhieuKhamBenh_ChuaKhamTonTai(ctpkb)))
            {
                return -4; // Phiếu khám bệnh không thể thêm thông tin
            }
            if ((KiemTraChiTietPhieuKhamBenh_TonTai(ctpkb)))
            {
                return -3; // Thuốc đã được thêm vào đơn thuốc
            }
            /*
            if (pkbDAO.lay_SLBenhNhan_KhamTrongNgay(pkb.NgayKham) >= ThamSo.dsThamSo[0].GiaTri && ThamSo.dsThamSo[0].Tat == false)
            {
                return -1; // Vượt số lượng cho phép
            }*/
            
            if (ctpkb.PhieuKhamBenh == null || ctpkb.Thuoc == null || ctpkb.SoLuong <= 0|| ctpkb.DonViTinh == null|| ctpkb.Gia <0)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
        public int KiemTra_CapNhat(ChiTietPhieuKhamBenh ctpkb)
        {


            if (!(KiemTraPhieuKhamBenh_ChuaKhamTonTai(ctpkb)))
            {
                return -4; // Phiếu khám bệnh không thể cập nhật thông tin
            }
            if ((!KiemTraChiTietPhieuKhamBenh_TonTai(ctpkb)))
            {
                return -3; // Thuốc chưa được thêm vào đơn thuốc
            }
            /*
            if (pkbDAO.lay_SLBenhNhan_KhamTrongNgay(pkb.NgayKham) >= ThamSo.dsThamSo[0].GiaTri && ThamSo.dsThamSo[0].Tat == false)
            {
                return -1; // Vượt số lượng cho phép
            }*/

            if (ctpkb.PhieuKhamBenh == null || ctpkb.Thuoc == null || ctpkb.SoLuong == 0 || ctpkb.DonViTinh == null || ctpkb.Gia < 0)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
        public int KiemTra_Xoa(ChiTietPhieuKhamBenh ctpkb)
        {


            if (!(KiemTraPhieuKhamBenh_ChuaKhamTonTai(ctpkb)))
            {
                return -4; // Phiếu khám bệnh không thể xóa chi tiết đơn thuốc
            }
            if ((!KiemTraChiTietPhieuKhamBenh_TonTai(ctpkb)))
            {
                return -3; // Thuốc chưa được thêm vào đơn thuốc
            }
            /*
            if (pkbDAO.lay_SLBenhNhan_KhamTrongNgay(pkb.NgayKham) >= ThamSo.dsThamSo[0].GiaTri && ThamSo.dsThamSo[0].Tat == false)
            {
                return -1; // Vượt số lượng cho phép
            }*/

            /*if (ctpkb.PhieuKhamBenh != null || ctpkb.Thuoc != null || ctpkb.SoLuong != 0 || ctpkb.DonViTinh != null || ctpkb.Gia >= 0)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }*/
            return 0;// không lỗi đầu vào
        }


        public bool KiemTraPhieuKhamBenh_ChuaKhamTonTai(ChiTietPhieuKhamBenh ctpkb)
        {
            PhieuKhamBenhDAO pkbDAO = new PhieuKhamBenhDAO();
            DataTable ds = pkbDAO.LayPhieuKhamBenh_ChuaKham(ctpkb.PhieuKhamBenh.Ma);
            if (ds.Rows.Count > 0){ return true; }
            return false;
        }
        public bool KiemTraChiTietPhieuKhamBenh_TonTai(ChiTietPhieuKhamBenh ctpkb)
        {
           
            DataTable ds = ctpkbDAO.LayDuLieu(ctpkb.PhieuKhamBenh.Ma,ctpkb.Thuoc.Ma);
            if (ds.Rows.Count > 0) { return true; }
            return false;
        }
        public DataTable LayDuLieu_BaoCaoSuDungThuoc(DateTime tg)
        {
         
            return ctpkbDAO.LayDuLieu_BaoCaoSuDungThuoc(tg);
        }

    }
}
