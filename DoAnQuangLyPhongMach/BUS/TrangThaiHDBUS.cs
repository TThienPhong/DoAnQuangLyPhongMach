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
    class TrangThaiHDBUS
    {

        TrangThaiHDDAO tthdDAO = new TrangThaiHDDAO();
        public DataTable LayDuLieu()
        {        
            return tthdDAO.LayDuLieu();
        }
        public TrangThaiHD LayTrangThaiHoaDonMoi()
        {

            DataRow dtr= tthdDAO.LayTrangThaiHoaDonMoi().Rows[0];
            TrangThaiHD tthd = new TrangThaiHD()
            {
                Ma = int.Parse(dtr["tthd_ma"].ToString()),
                Ten =dtr["tthd_ten"].ToString(),
            };
            return tthd;
        }
        public TrangThaiHD LayTrangThaiHoaDonThanhToan()
        {

            DataRow dtr = tthdDAO.LayTrangThaiHoaDonThanhToan().Rows[0];
            TrangThaiHD tthd = new TrangThaiHD()
            {
                Ma = int.Parse(dtr["tthd_ma"].ToString()),
                Ten = dtr["tthd_ten"].ToString(),
            };
            return tthd;
        }
    }
}
