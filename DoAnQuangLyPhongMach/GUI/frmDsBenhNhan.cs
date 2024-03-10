using DoAnQuangLyPhongMach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuangLyPhongMach.GUI
{
    public partial class frmDsBenhNhan : Form
    {
        PhieuKhamBenhDAO pkpDAO = new PhieuKhamBenhDAO();
        DataTable DS = new DataTable();
        DataView DSV = new DataView();
        public frmDsBenhNhan()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngay1 = dtpNgay1.Value;
            DateTime ngay2 = dtpNgay2.Value;
            DocDS(ngay1, ngay2);
        }
        void DocDS(DateTime ngay1, DateTime ngay2)
        {
            DS = pkpDAO.LayDuLieu_BenhNhanDaKham(ngay1, ngay2);
            DSV = new DataView(DS);
            dgvDS.AutoGenerateColumns = false;
            dgvDS.DataSource = DSV;
        }
    }
}
