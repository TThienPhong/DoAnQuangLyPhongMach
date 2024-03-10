using DoAnQuangLyPhongMach.DAO;
using DoAnQuangLyPhongMach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// test git 2024-03-10
namespace DoAnQuangLyPhongMach.BUS
{
    class BenhNhanBUS
    {
        BenhNhanDAO bnDAO = new BenhNhanDAO();
        public DataTable LayDuLieu()
        {        
            return bnDAO.LayDuLieu();
        }
        public int Them(BenhNhan bn)
        {
            if (String.IsNullOrEmpty(bn.Ten))
            {
                return -2; //tên loại bệnh không được rỗng
            }
            if (string.IsNullOrEmpty(bn.Ten)) return -2;
            return bnDAO.Them(bn);
        }
        public int CapNhat(BenhNhan bn)
        {
            if (string.IsNullOrEmpty(bn.Ten)) return -2;
            return bnDAO.CapNhat(bn);
        }
        public int Xoa(BenhNhan bn)
        {
            
            return bnDAO.Xoa(bn);
        }
        public int TimMaSo()
        {
            return bnDAO.TimMaSo();
        }
    }
}
