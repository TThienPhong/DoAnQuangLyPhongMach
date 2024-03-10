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
    class ThuocBUS
    {
        
        ThuocDAO tDAO = new ThuocDAO();
        public DataTable LayDuLieu()
        {        
            return tDAO.LayDuLieu();
        }
        public int Them(Thuoc t)
        {
            int ktDauVao = KiemTraThongSoDauVao(t);
            if (ktDauVao == 0)
            {
                return tDAO.Them(t);
            }
            else return ktDauVao;
        }
        public int CapNhat(Thuoc t)
        {
            int ktDauVao = KiemTraThongSoDauVao(t);
            if (ktDauVao == 0|| ktDauVao == -1)
            {
                //return 1000;
                return tDAO.CapNhat(t);
            }
            else return ktDauVao;
        }
        public int Xoa(Thuoc t)
        {            
            return tDAO.Xoa(t);
        }
        public int TimMaSo()
        {
            return tDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(Thuoc t)
        {
            if (LayDuLieu().Select("t_xoa=0").Length>=ThamSo.dsThamSo[2].GiaTri && ThamSo.dsThamSo[2].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }

            if (string.IsNullOrEmpty(t.Ten) ||t.DoViTinh.Ma<1|| t.Gia < 0)
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
    }
}
