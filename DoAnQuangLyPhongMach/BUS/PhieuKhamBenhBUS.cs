using DoAnQuangLyPhongMach.DAO;
using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.BUS
{
    class PhieuKhamBenhBUS
    {
        
       PhieuKhamBenhDAO pkbDAO = new PhieuKhamBenhDAO();
        public DataTable LayDuLieu()
        {        
            return pkbDAO.LayDuLieu();
        }
        public DataTable LayDuLieu_theoNgay(DateTime ngay)
        {
            return pkbDAO.LayDuLieu_theoNgay(ngay);
        }
        public DataTable LayDuLieu_BenhNhanDaKham(DateTime ngay1, DateTime ngay2)
        {
           
            return pkbDAO.LayDuLieu_BenhNhanDaKham(ngay1,  ngay2);
        }
        public int Them(PhieuKhamBenh pkb)
        {
            int ktDauVao = KiemTra_Them(pkb);
            if (ktDauVao == 0)
            {
                return pkbDAO.Them(pkb);
            }
            else return ktDauVao;
        }
        public int CapNhat(PhieuKhamBenh pkb)// chưa dùng
        {
            int ktDauVao = KiemTraThongSoDauVao(pkb);
            if (ktDauVao == 0|| ktDauVao == -1)
            {
                return pkbDAO.CapNhat(pkb);
            }
            else return ktDauVao;
        }
        public int Xoa(PhieuKhamBenh pkb)
        {
            int ktDauVao = KiemTra_Xoa(pkb);
            if (ktDauVao == 0)
            {
                return pkbDAO.Xoa(pkb);
            }
            else return ktDauVao;           
        }
        public int TimMaSo()
        {
            return pkbDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(PhieuKhamBenh pkb)// chưa sử dụng
        {
            if (LayDuLieu().Select("t_xoa=false").Length>=ThamSo.dsThamSo[2].GiaTri && ThamSo.dsThamSo[2].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }

            if (string.IsNullOrEmpty("ád") ||pkb.BenhNhanKham.Ma<1||pkb.Ma < 0)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
        public bool KiemTraBenhNhanĐKKham(DateTime ngay, int maBN)
        {
            DataTable dt = pkbDAO.LayDuLieu_theoBNvaNgay(ngay, maBN);
            if (dt.Rows.Count > 0 ) return true;
            return false;
        }
        public int KiemTraTrangThaiPhieuKhamBenh(PhieuKhamBenh pkb)
        {
            return pkb.TrangThai.Ma;
           
        }
        public int KiemTra_Them(PhieuKhamBenh pkb)
        {
            if (KiemTraBenhNhanĐKKham(pkb.NgayKham, pkb.BenhNhanKham.Ma))
            {
                return -3; // bệnh nhân đã đăng ký khám tại ngày này rồi
            }
            if (pkbDAO.lay_SLBenhNhan_KhamTrongNgay(pkb.NgayKham)>= ThamSo.dsThamSo[0].GiaTri && ThamSo.dsThamSo[0].Tat == false) 
            {
                return -1; // Vượt số lượng cho phép
            }
            if (pkb.NgayKham ==null|| pkb.BenhNhanKham.Ma < 1)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
        public int DoiTrangThaiDaKham(PhieuKhamBenh pkb)
        {
            if (pkb.TrangThai == null|| pkb.BenhNhanKham == null|| pkb.BenhDuDoan== null||pkb.NgayKham==null|| pkb.Ma <0)
            {
                return -4; // trường giá trị phải đảm bảo có nghĩa
            }

           
            if (pkb.TrangThai.Ma == 3)
            {
                return -3;//// Phiếu khám bệnh đã xóa không thể thây đổi
            }
            if (pkb.TrangThai.Ma == 2)
            {
                return -2;// Phiếu khám bệnh đã khám không thể thây đổi
            }


            return pkbDAO.DoiTrangThaiDaKham(pkb);
        }

        public int KiemTra_Xoa(PhieuKhamBenh pkb)
        {
            if (KiemTraTrangThaiPhieuKhamBenh(pkb) == 3)
            {
                return -5; // phiếu khám bệnh đã xóa 
            }
            if (KiemTraTrangThaiPhieuKhamBenh(pkb)==2)
            {
                return -4; // bệnh nhân đã khám bệnh 
            }
            /*
            if (KiemTraBenhNhanĐKKham(pkb.NgayKham, pkb.BenhNhanKham.Ma))
            {
                return -3; // bệnh nhân đã đăng ký khám tại ngày này rồi
            }
            if (pkbDAO.lay_SLBenhNhan_KhamTrongNgay(pkb.NgayKham) >= ThamSo.dsThamSo[0].GiaTri && ThamSo.dsThamSo[0].Tat == false)
            {
                return -1; // Vượt số lượng cho phép
            }
            if (pkb.NgayKham == null || pkb.BenhNhanKham.Ma < 1)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            } */
            return 0;// không lỗi đầu vào
        }
    }
}
