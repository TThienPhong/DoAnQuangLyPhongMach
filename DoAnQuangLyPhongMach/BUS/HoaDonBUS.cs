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
    class HoaDonBUS
    {        
        HoaDonDAO hdDAO = new HoaDonDAO();
        public DataTable LayDuLieu()
        {
           
            return hdDAO.LayDuLieu();
        }

        public DataTable TimHoaDon(int maPKB)
        {
            
            return hdDAO.TimHoaDon(maPKB);
        }
        public DataTable TimHoaDonChuaHuy(int maPKB)
        {

            return hdDAO.TimHoaDonChuaHuy(maPKB);
        }
        public int Them(HoaDon hd)
        {
            DataTable tb = hdDAO.TimHoaDonChuaHuy(hd.PKB.Ma);
            if (tb.Rows.Count>0)
            {
                return -1;// hóa đơn đã tồn tại
            }    
            return hdDAO.Them(hd);
        }
        public int CapNhatThanhToan(HoaDon hd)
        {

            return hdDAO.CapNhatThanhToan(hd);
        }
        public DataTable LayDuLieu_BaoCaoDoanhThu(DateTime tg)
        {
            return hdDAO.LayDuLieu_BaoCaoDoanhThu(tg);
        }
    }
}
