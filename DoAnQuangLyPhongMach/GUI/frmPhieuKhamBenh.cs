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
   
    public partial class frmPhieuKhamBenh : Form
    {

        public frmDsKhamBenh frmDS;
        DataTable DS = new DataTable();

        DataTable DSThuoc = new DataTable();
        DataView DSThuocV = new DataView();

        DataTable DSBenh = new DataTable();
        //DataTable DSBenh = new DataTable();
        DataTable DSDonViTinh = new DataTable();
        public PhieuKhamBenh pkb=new PhieuKhamBenh();
        ChiTietPhieuKhamBenhBUS ctpkbBUS = new ChiTietPhieuKhamBenhBUS();
        DataTable DSCachDung = new DataTable();
        DataTable DSTrangThai = new DataTable();

        public frmPhieuKhamBenh()
        {
            InitializeComponent();
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            DocDSBenh();
            cb_LoaiBenh.SelectedIndex = 0;
            DocDSThuoc();
            DocDSDonViTinh();
            DocDS();
            DocDSCachDung();
            DocDSTrangThaiPKB();
            DocLaiMangHinh();
           
             
            //if (pkb.BenhDuDoan != null)
            //{ cb_LoaiBenh.}    
            //if(pkb.BenhDuDoan == null) { MessageBox.Show("chưa có bệnh"); }
        }
        void DocDSTrangThaiPKB()
        {
            TrangThaiPKBBUS ttpkbBUS = new TrangThaiPKBBUS();
            DSTrangThai= ttpkbBUS.LayDuLieu();

            cbTrangThaiPKB.DataSource = DSTrangThai;
            cbTrangThaiPKB.DisplayMember = "ttpkb_ten";
            cbTrangThaiPKB.ValueMember = "ttpkb_ma";
        }
        void DocLaiMangHinh()
        {
            tbTen.Text = pkb.BenhNhanKham.Ten;
            dtpNgay.Value = pkb.NgayKham;
            cbTrangThaiPKB.SelectedValue = pkb.TrangThai.Ma;
           

            tbMa.ReadOnly = true;
            tbTenThuoc.ReadOnly = true;
            cbDonViTinh.Enabled = false;
            tbGia.ReadOnly = true;
            nudGiaSL.ReadOnly = true;
            tbTen.ReadOnly = true;
            dtpNgay.Enabled = false;
            cbTrangThaiPKB.Enabled = false;
            btnThanhToan.Enabled = false;
            //btnHoanThanh.Enabled = false;
            if (pkb.TrangThai.Ma == 2)
            {
                tbTrieuChung.Text = pkb.TrieuChung;
                cb_LoaiBenh.SelectedValue = pkb.BenhNhanKham.Ma;
                tbTrieuChung.Enabled = false;
                cb_LoaiBenh.Enabled = false;
                btnHoanThanh.Enabled = false;
                btnThanhToan.Enabled = true;

            }
        }
        void DocDSBenh()
        {
            LoaiBenhBUS lbBUS = new LoaiBenhBUS();
            DSBenh = lbBUS.LayDuLieu();
            
            cb_LoaiBenh.DataSource = DSBenh;
            cb_LoaiBenh.DisplayMember = "lb_ten";
            cb_LoaiBenh.ValueMember = "lb_ma";
        }
        void DocDSDonViTinh()
        {
            DonViTinhBUS dvtBUS = new DonViTinhBUS();
            DSDonViTinh = dvtBUS.LayDuLieu();

            cbDonViTinh.DataSource = DSDonViTinh;
            cbDonViTinh.DisplayMember = "dvt_ten";
            cbDonViTinh.ValueMember = "dvt_ma";
        }
        void DocDSCachDung()
        {
            CachDungBUS cdBUS = new CachDungBUS();
            DSCachDung = cdBUS.LayDuLieu();

            cbCachDung.DataSource = DSCachDung;
            cbCachDung.DisplayMember = "cd_ten";
            cbCachDung.ValueMember = "cd_ma";
        }
        void DocDSThuoc()
        {
            ThuocBUS tBUS = new ThuocBUS();
            DSThuoc =tBUS.LayDuLieu();
            DSThuocV = new DataView(DSThuoc);
            dgvDSThuoc.AutoGenerateColumns = false;
            dgvDSThuoc.DataSource = DSThuocV;
            
        }
        void DocDS()
        {
           
            DS = ctpkbBUS.LayDuLieu(pkb.Ma);
            dgvDS.AutoGenerateColumns = false;
            dgvDS.DataSource = DS;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSThuoc.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDSThuoc.SelectedRows[0].DataBoundItem).Row;

                tbMa.Text = dtr["t_ma"].ToString();
                tbTenThuoc.Text = dtr["t_ten"].ToString();
                cbDonViTinh.SelectedValue = int.Parse(dtr["t_ma_donViTinh"].ToString());
                tbGia.Text = dtr["t_gia"].ToString();
                nudSoLuong.Value = 1;
                nudGiaSL.Value = int.Parse(tbGia.Text)* nudSoLuong.Value;
                //cbCachDung.SelectedValue = int.Parse(dtr["_ma_cachDung"].ToString());

                btXoakhoiDSDonThuoc.Enabled = false;
                btCapNhatDonThuoc.Enabled = false;
                btThemVaoDSDonthuoc.Enabled = true;               
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;

                tbMa.Text = dtr["t_ma"].ToString();
                tbTenThuoc.Text = dtr["t_ten"].ToString();
                cbDonViTinh.SelectedValue = int.Parse(dtr["t_ma_donViTinh"].ToString());
                tbGia.Text = dtr["ctpkb_gia"].ToString();
                nudSoLuong.Value = int.Parse(dtr["ctpkb_soLuong"].ToString()); ;
                nudGiaSL.Value = int.Parse(tbGia.Text) * nudSoLuong.Value;
                cbCachDung.SelectedValue= int.Parse(dtr["ctpkb_ma_cachDung"].ToString());

                btXoakhoiDSDonThuoc.Enabled =true;
                btCapNhatDonThuoc.Enabled = true;
                btThemVaoDSDonthuoc.Enabled = false;
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            nudGiaSL.Value = nudSoLuong.Value * int.Parse(tbGia.Text);
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text != "")
            {
                DSThuocV.RowFilter = "t_ten like '%" + tbTimKiem.Text + "%'";
            }
            else DSThuocV.RowFilter = "";
        }

        private void btThemVaoDSDonthuoc_Click(object sender, EventArgs e)
        {
            if (dgvDSThuoc.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDSThuoc.SelectedRows[0].DataBoundItem).Row;
                Thuoc t = new Thuoc()
                {
                    Ma = int.Parse(dtr["t_ma"].ToString()),
                    Ten = dtr["t_ten"].ToString()
                };
                DonViTinh dvt = new DonViTinh()
                {
                    Ma = int.Parse(dtr["dvt_ma"].ToString()),
                    Ten = dtr["dvt_ten"].ToString()
                };
                CachDung cd = new CachDung()
                {
                    Ma = int.Parse(cbCachDung.SelectedValue.ToString()),
                    Ten = ((DataRowView)cbCachDung.SelectedItem)["cd_ten"].ToString(),
                };

                ChiTietPhieuKhamBenh ctpkb = new ChiTietPhieuKhamBenh()
                {
                    PhieuKhamBenh = pkb,
                    Thuoc = t,
                    DonViTinh = dvt,
                    Gia = int.Parse(dtr["t_gia"].ToString()),
                    SoLuong = int.Parse(nudSoLuong.Value.ToString()),
                    CachDung=cd,

                };
                ctpkb.TongGia = ctpkb.Gia * ctpkb.SoLuong;

                var kq = ctpkbBUS.Them(ctpkb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -4:
                            loi = "Phiếu khám bệnh này không thể thêm đơn thuốc!!!";
                            break;
                        case -3:
                            loi = "Đơn thuốc đã tồn tại!!!";
                            break;
                        case -2:
                            loi = "Nhập lại thông số đầu vào !!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Thêm vào đơn thuốc thành công!!!");
                }
            }
        }

        private void btCapNhatDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                Thuoc t = new Thuoc()
                {
                    Ma = int.Parse(dtr["t_ma"].ToString()),
                    Ten = dtr["t_ten"].ToString(),
                };
                DonViTinh dvt = new DonViTinh()
                {
                    Ma = int.Parse(dtr["dvt_ma"].ToString()),
                    Ten = dtr["dvt_ten"].ToString(),
                };
                CachDung cd = new CachDung()
                {
                    Ma = int.Parse(cbCachDung.SelectedValue.ToString()),
                    Ten = ((DataRowView)cbCachDung.SelectedItem)["cd_ten"].ToString(),
                };

                ChiTietPhieuKhamBenh ctpkb = new ChiTietPhieuKhamBenh()
                {
                    Ma = int.Parse(dtr["ctpkb_ma"].ToString()),
                    PhieuKhamBenh = pkb,
                    Thuoc = t,
                    DonViTinh = dvt,
                    Gia = int.Parse(dtr["t_gia"].ToString()),
                    SoLuong = int.Parse(nudSoLuong.Value.ToString()),
                    CachDung = cd,

                };
                ctpkb.TongGia = ctpkb.Gia * ctpkb.SoLuong;

                var kq = ctpkbBUS.CapNhat(ctpkb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -4:
                            loi = "Phiếu khám bệnh này không thể thêm đơn thuốc!!!";
                            break;
                        case -3:
                            loi = "Đơn thuốc chưa tồn tại!!!";
                            break;
                        case -2:
                            loi = "Nhập lại thông số đầu vào !!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Cập nhật đơn thuốc thành công!!!");
                }
            }
        }

        private void btXoakhoiDSDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                Thuoc t = new Thuoc()
                {
                    Ma = int.Parse(dtr["t_ma"].ToString()),
                    Ten = dtr["t_ten"].ToString(),
                };
                DonViTinh dvt = new DonViTinh()
                {
                    Ma = int.Parse(dtr["dvt_ma"].ToString()),
                    Ten = dtr["dvt_ten"].ToString(),
                };
                CachDung cd = new CachDung()
                {
                    Ma = int.Parse(cbCachDung.SelectedValue.ToString()),
                    Ten = ((DataRowView)cbCachDung.SelectedItem)["cd_ten"].ToString(),
                };

                ChiTietPhieuKhamBenh ctpkb = new ChiTietPhieuKhamBenh()
                {
                    Ma = int.Parse(dtr["ctpkb_ma"].ToString()),
                    PhieuKhamBenh = pkb,
                    Thuoc = t,
                    DonViTinh = dvt,
                    Gia = int.Parse(dtr["t_gia"].ToString()),
                    SoLuong = int.Parse(nudSoLuong.Value.ToString()),
                    CachDung = cd,
                };
                ctpkb.TongGia = ctpkb.Gia * ctpkb.SoLuong;
                var kq = ctpkbBUS.Xoa(ctpkb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -4:
                            loi = "Phiếu khám bệnh này không thể xóa đơn thuốc!!!";
                            break;
                        case -3:
                            loi = "Đơn thuốc chưa tồn tại!!!";
                            break;
                        case -2:
                            //loi = "Nhập lại thông số đầu vào !!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("xóa đơn thuốc thành công!!!");
                }
            }
        }

        private void btnTroVeDS_Click(object sender, EventArgs e)
        {
            frmDS.WindowState = FormWindowState.Maximized;
            frmDS.Show();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            PhieuKhamBenhBUS pkbBUS = new PhieuKhamBenhBUS();
            LoaiBenh lb = new LoaiBenh() {
                Ma = int.Parse(cb_LoaiBenh.SelectedValue.ToString()),
                Ten= ((DataRowView)cb_LoaiBenh.SelectedItem)["lb_ten"].ToString(),
            };

            pkb.BenhDuDoan = lb;
            pkb.TrieuChung = tbTrieuChung.Text;
            int kq = pkbBUS.DoiTrangThaiDaKham(pkb);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {
                    case -4:
                        loi = "Các trường giá trị của Phiếu khám bệnh phải đảm bảo có nghĩa!!!";
                        break;
                    case -3:
                        loi = "Phiếu khám bệnh đã xóa không thể thay đổi!!!";
                        break;
                    case -2:
                        loi = "Phiếu khám bệnh đã khám không thể thây đổi !!!";
                        break;
                }
                MessageBox.Show(loi);
            }
            if (kq > 0)
            {
                
                MessageBox.Show("Đã khám bệnh xong tiến Hành thanh toán hóa đơn!!!");
                btnThanhToan.Enabled = true;
                pkb.TrangThai.Ma = 2;
                DocLaiMangHinh();

            }
            
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (pkb.TrangThai.Ma == 2)
            {
                HoaDonBUS hdBUS = new HoaDonBUS();
                DataTable dsHD = hdBUS.TimHoaDonChuaHuy(pkb.Ma);
                TrangThaiHD tthd;
                if (dsHD.Rows.Count==0)
                {
                    int sum = 0;
                    foreach (var i in DS.Rows)
                    {
                        sum += int.Parse(((DataRow)i)["ctpkb_tongTien"].ToString());
                    }

                    TrangThaiHDBUS tthdBUS = new TrangThaiHDBUS();
                    tthd = tthdBUS.LayTrangThaiHoaDonMoi();

                    HoaDon hd = new HoaDon()
                    {
                        PKB = pkb,
                        TienKham = ThamSo.dsThamSo[5].GiaTri,
                        TienThuoc = sum,
                        TrangThai = tthd,
                    };
                    //hd.TongTien = hd.TienKham + hd.TienThuoc;

                    hdBUS.Them(hd);
                    dsHD = hdBUS.TimHoaDonChuaHuy(pkb.Ma);
                }
                DataRow dtr = dsHD.Rows[0];


                tthd = new TrangThaiHD()
                {
                    Ma = int.Parse(dtr["tthd_ma"].ToString()),
                    Ten = (dtr["tthd_ten"].ToString()),
                };
                HoaDon hoadon = new HoaDon
                {
                    Ma = int.Parse(dtr["hd_ma"].ToString()),
                    PKB = pkb,
                    TienKham = int.Parse(dtr["hd_tienKham"].ToString()),
                    TienThuoc = int.Parse(dtr["hd_tienThuoc"].ToString()),
                    TrangThai = tthd,
                    TongTien= int.Parse(dtr["hd_tongTien"].ToString()),
                };


                frmHoaDon frmDT = new frmHoaDon();
                //frmHoaDon.
                frmDT.hd = hoadon;
                frmDT.frmDS = this.frmDS;
                //this.IsMdiContainer = true;
                frmDT.MdiParent = this.MdiParent;
                frmDT.WindowState = FormWindowState.Maximized;
                frmDT.Show();
            }
            else { MessageBox.Show("Cần hoàng thành khám trước khi thanh toán!!!"); }
            
        }
    }
}
