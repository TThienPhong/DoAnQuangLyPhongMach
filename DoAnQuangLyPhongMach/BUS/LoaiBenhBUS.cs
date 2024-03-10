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
    class LoaiBenhBUS
    {
        
        LoaiBenhDAO lbDAO = new LoaiBenhDAO();
        public DataTable LayDuLieu()
        {        
            return lbDAO.LayDuLieu();
        }
        public int Them(LoaiBenh lb) 
        {
            int ktDauVao = KiemTraThongSoDauVao(lb);
            if (ktDauVao == 0)
            {
                return lbDAO.Them(lb);
            }
            else return ktDauVao;
        }
        public int CapNhat(LoaiBenh lb) 
        {
            int ktDauVao = KiemTraThongSoDauVao(lb);
            if (ktDauVao == 0|| ktDauVao == -1)
            {
                return lbDAO.CapNhat(lb);
            }
            else return ktDauVao;
        }
        public int Xoa(LoaiBenh lb) 
        {            
            return lbDAO.Xoa(lb);
        }
        public int TimMaSo()  
        {
            return lbDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(LoaiBenh lb)  // chưa cần
        {
            if (LayDuLieu().Select("lb_xoa=false").Length>=ThamSo.dsThamSo[1].GiaTri && ThamSo.dsThamSo[1].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }

            if (string.IsNullOrEmpty(lb.Ten) )
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
    }
}
