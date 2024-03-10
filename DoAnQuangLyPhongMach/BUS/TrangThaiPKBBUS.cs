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
    class TrangThaiPKBBUS
    {

        TrangThaiPKBDAO ttpkbDAO = new TrangThaiPKBDAO();
        public DataTable LayDuLieu()
        {        
            return ttpkbDAO.LayDuLieu();
        }
        
       
    }
}
