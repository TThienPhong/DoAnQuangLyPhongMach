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
    class CachDungBUS
    {        
        CachDungDAO cdDAO = new CachDungDAO();
        public DataTable LayDuLieu()
        {        
            return cdDAO.LayDuLieu();
        }
        public int Them(CachDung cd)
        {
            int ktDauVao = KiemTraThongSoDauVao(cd);
            if (ktDauVao == 0)
            {
                return cdDAO.Them(cd);
            }
            else return ktDauVao;
        }
        public int CapNhat(CachDung cd)
        {
            int ktDauVao = KiemTraThongSoDauVao(cd);
            if (ktDauVao == 0 || ktDauVao == -1)
            {
                return cdDAO.CapNhat(cd);
            }
            else return ktDauVao;
        }
        public int Xoa(CachDung cd)
        {            
            return cdDAO.Xoa(cd);
        }
        public int TimMaSo()
        {
            return cdDAO.TimMaSo();
        }
        public int KiemTraThongSoDauVao(CachDung cd)
        {
            if (LayDuLieu().Select("cd_xoa=false").Length>=ThamSo.dsThamSo[4].GiaTri && ThamSo.dsThamSo[4].Tat==false)
            {
                return -1; // Vượt số lượng cho phép
            }

            if (string.IsNullOrEmpty(cd.Ten) )
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
    }
}
