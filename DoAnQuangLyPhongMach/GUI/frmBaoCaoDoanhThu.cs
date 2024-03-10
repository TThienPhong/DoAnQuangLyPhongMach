using DoAnQuangLyPhongMach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuangLyPhongMach
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        DataTable DS = new DataTable();
        DataView DSV = new DataView();

        HoaDonBUS hdBUS = new HoaDonBUS();

        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
       
        void DocDS(DateTime tg)
        {
            DS = hdBUS.LayDuLieu_BaoCaoDoanhThu(tg);
            DSV = new DataView(DS);
            dgvDS.AutoGenerateColumns = false;
            dgvDS.DataSource = DSV;
        }

        private void dtpNgay1_ValueChanged(object sender, EventArgs e)
        {
            DocDS(dtpNgay1.Value);
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DocDS(dtpNgay1.Value);
        }
    }
}
