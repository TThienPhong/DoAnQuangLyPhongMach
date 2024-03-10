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
    class DonViTinhBUS
    {

        DonViTinhDAO dvtDAO = new DonViTinhDAO();
        public DataTable LayDuLieu()
        {        
            return dvtDAO.LayDuLieu();
        }
        public int Them(DonViTinh dvt)
        {
            int ktDauVao = KiemTraThongSoDauVao(dvt);
            if (ktDauVao == 0)
            {
                return dvtDAO.Them(dvt);
            }
            else return ktDauVao;
        }
        public int CapNhat(DonViTinh dvt)
        {
            int ktDauVao = KiemTraThongSoDauVao(dvt);
            if (ktDauVao == 0|| ktDauVao == -1)
            {
                return dvtDAO.CapNhat(dvt);
            }
            else return ktDauVao;
        }
        public int Xoa(DonViTinh dvt)
        {            
            return dvtDAO.Xoa(dvt);
        }
        public int TimMaSo()
        {
            return dvtDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(DonViTinh dvt)
        {
            if (LayDuLieu().Select("dvt_xoa=0").Length>=ThamSo.dsThamSo[3].GiaTri && ThamSo.dsThamSo[3].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }

            if (string.IsNullOrEmpty(dvt.Ten) )
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
    }
}
