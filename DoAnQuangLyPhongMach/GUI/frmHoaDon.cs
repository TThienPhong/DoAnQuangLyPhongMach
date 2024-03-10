using DoAnQuangLyPhongMach.BUS;
using DoAnQuangLyPhongMach.DTO;
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
    public partial class frmHoaDon : Form
    {
        public HoaDon hd;
        public frmDsKhamBenh frmDS;
        HoaDonBUS hdBUS = new HoaDonBUS();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            CapNhatMangHinh();

        }

        void CapNhatMangHinh()
        {
            tbTen.Text = hd.PKB.BenhNhanKham.Ten;
            tbTenTrangThai.Text = hd.TrangThai.Ten;
            dtpNgay.Value = hd.PKB.NgayKham;
            nudTienKham.Value = hd.TienKham;
            nudTienThuoc.Value = hd.TienThuoc;
            nudTongTien.Value = hd.TienKham + hd.TienThuoc;


            tbTen.Enabled = false;
            tbTenTrangThai.Enabled = false;
            dtpNgay.Enabled = false;
            nudTienKham.Enabled = false;
            nudTienThuoc.Enabled = false;
            nudTongTien.Enabled = false;
            btnThanhToan.Enabled = false;


            if (hd.TrangThai.Ma == 1)
            {
                btnThanhToan.Enabled = true;
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            hd.TongTien = int.Parse(nudTongTien.Value.ToString());
            int kq=hdBUS.CapNhatThanhToan(hd);
            if(kq>0)
            {
                MessageBox.Show("Thanh toán thành công!!!");
                TrangThaiHDBUS tthdBUS = new TrangThaiHDBUS();
                hd.TrangThai = tthdBUS.LayTrangThaiHoaDonThanhToan();
                CapNhatMangHinh();
            }
            else { MessageBox.Show("Có lỗi xảy ra!!!"); ; }
        }

        private void btnTroVeDS_Click(object sender, EventArgs e)
        {
            frmDS.WindowState = FormWindowState.Maximized;
            frmDS.Show();
        }
    }
}
