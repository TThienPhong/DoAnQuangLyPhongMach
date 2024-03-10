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
    class GioiTinhBUS
    {

        GioiTinhDAO lbDAO = new GioiTinhDAO();
        public DataTable LayDuLieu()
        {        
            return lbDAO.LayDuLieu();
        }
        public int Them(GioiTinh gt) // chưa cần
        {
            int ktDauVao = KiemTraThongSoDauVao(gt);
            if (ktDauVao == 0)
            {
                return lbDAO.Them(gt);
            }
            else return ktDauVao;
        }
        public int CapNhat(GioiTinh gt) // chưa cần
        {
            int ktDauVao = KiemTraThongSoDauVao(gt);
            if (ktDauVao == 0|| ktDauVao == -1)
            {
                return lbDAO.CapNhat(gt);
            }
            else return ktDauVao;
        }
        public int Xoa(GioiTinh gt) // chưa cần
        {            
            return lbDAO.Xoa(gt);
        }
        public int TimMaSo() // chưa cần
        {
            return lbDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(GioiTinh gt) // chưa cần
        {
            /*if (LayDuLieu().Select("gt_xoa=false").Length>=ThamSo.dsThamSo[1].GiaTri && ThamSo.dsThamSo[1].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }*/

            if (string.IsNullOrEmpty(gt.Ten) )
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
    }
}
