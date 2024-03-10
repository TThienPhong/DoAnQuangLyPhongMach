using DoAnQuangLyPhongMach.BUS;
using DoAnQuangLyPhongMach.GUI;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState= FormWindowState.Maximized;
            ThamSoBUS.DocDSThamSo();

        }

       

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu frmDT = new frmBaoCaoDoanhThu();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void khamBenhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void benhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBenhNhan frmDT = new frmQLBenhNhan();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void thamSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThamSo frmDT = new frmQLThamSo();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void benhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLLoaiBenh frmDT = new frmQLLoaiBenh();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void cachDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLCachDung frmDT = new frmQLCachDung();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();

        }

        private void donViTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDonViTinh frmDT = new frmQLDonViTinh();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void thuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLThuoc frmDT = new frmQLThuoc();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

      

        private void DSkhamBenhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDsKhamBenh frmDT = new frmDsKhamBenh();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void dSBenhNhanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDsBenhNhan frmDT = new frmDsBenhNhan();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }

        private void suDungThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoSuDungThuoc frmDT = new frmBaoCaoSuDungThuoc();
            this.IsMdiContainer = true;
            frmDT.MdiParent = this;
            frmDT.WindowState = FormWindowState.Maximized;
            frmDT.Show();
        }
    }
}
