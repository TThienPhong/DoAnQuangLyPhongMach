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
    class ThamSoBUS
    {
       
        ThamSoDAO tsDAO = new ThamSoDAO();
        public  DataTable LayDuLieu()
        {
            return tsDAO.LayDuLieu();
        }
        public  int Them(ThamSo ts)
        {
            int ktDauVao = KiemTraThongSoDauVao(ts);
            if (ktDauVao == 0)
            {
                DocDSThamSo();
                return tsDAO.Them(ts);
            } else return ktDauVao;
            

        }
        public int CapNhat(ThamSo ts)
        {
            int ktDauVao = KiemTraThongSoDauVao(ts);
            if (ktDauVao == 0)
            {
                DocDSThamSo();
                return tsDAO.CapNhat(ts);
            }
            else return ktDauVao;
            //return 100;//
        }

        public int TimMaSo()
        {
            return tsDAO.TimMaSo();
        }
        public static bool DocDSThamSo()
        {
            ThamSoBUS tsb = new ThamSoBUS();        
            List<ThamSo> dsThamSo = new List<ThamSo>();
            DataTable tbThamSo = tsb.LayDuLieu();
            foreach (DataRow ts in tbThamSo.Rows)
            {
                ThamSo thamSo = new ThamSo();
                thamSo.Ten = ts["ts_ten"].ToString();
                thamSo.KieuDuLieu = ts["ts_KieuDuLieu"].ToString();
                thamSo.GiaTri = int.Parse(ts["ts_giaTri"].ToString());
                thamSo.Tat = bool.Parse(ts["ts_trangThaiTat"].ToString());
                dsThamSo.Add(thamSo);
            }

            if (dsThamSo.Count > 0)
            {
                ThamSo.dsThamSo = dsThamSo;
                return true;
            }
            else {
                ThamSo.dsThamSo = new List<ThamSo>();
                return false;
            }
           

        }
        public int KiemTraThongSoDauVao(ThamSo ts)
        {
            
            if (string.IsNullOrEmpty(ts.Ten) || ts.GiaTri < 0 || string.IsNullOrEmpty(ts.KieuDuLieu))
            {
                return -2; // các trường giá trị đảm bảo có nghĩa
            }
            return 0;// không lỗi đầu vào
        }
            
    }
}
