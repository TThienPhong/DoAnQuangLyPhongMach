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

namespace DoAnQuangLyPhongMach.GUI
{
    public partial class frmBaoCaoSuDungThuoc : Form
    {
        DataTable DS = new DataTable();
        DataView DSV = new DataView();

        ChiTietPhieuKhamBenhBUS ctpkbBUS = new ChiTietPhieuKhamBenhBUS();
        public frmBaoCaoSuDungThuoc()
        {
            InitializeComponent();
        }

        void DocDS(DateTime tg)
        {
            DS = ctpkbBUS.LayDuLieu_BaoCaoSuDungThuoc(tg);
            DSV = new DataView(DS);
            dgvDS.AutoGenerateColumns = false;
            dgvDS.DataSource = DSV;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DocDS(dtpNgay1.Value);
        }

        private void dtpNgay1_ValueChanged(object sender, EventArgs e)
        {
            DocDS(dtpNgay1.Value);
        }
    }
}
