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
    public partial class frmDsKhamBenh : Form
    {
        PhieuKhamBenhBUS pkbBUS = new PhieuKhamBenhBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        DataTable DSGioiTinh = new DataTable();
        DataTable DSBenhNhan = new DataTable();
        DataView DSBenhNhanV = new DataView();
        BenhNhanBUS bnBUS = new BenhNhanBUS();
        public frmDsKhamBenh()
        {
            InitializeComponent();
            DocDS();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDsKhamBenh_Load(object sender, EventArgs e)
        {
            DocDS();
            DocDSGioiTinh();
            DocDSBenhNhan();
            btnXoaBN.Visible= false;
            btnCapNhatBN.Visible = false;
            //btCapNhatHoSo.Visible = false;
            
        }
        private void DocDS()
        {
            //DateTime ngay= DateTime.ParseExact("2022-11-19", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            //MessageBox.Show(String.Format("ngay={0},thang={1},nam={2}", ngay.Day, ngay.Month, ngay.Year));

            //DateTime ngay = DateTime.ParseExact(dtpNgay.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime ngay = dtpNgay.Value;
            DS = pkbBUS.LayDuLieu_theoNgay(ngay);
            DSV = new DataView(DS);

            //Set AutoGenerateColumns False
            //dgvDS02.AutoGenerateColumns = false;
            dgvDS.AutoGenerateColumns = false;
            dgvDS.DataSource = DSV;

            //Set Columns Count
            //dgvDS02.ColumnCount = DS.Columns.Count;

            /*dgvDS02.ColumnCount = DS.Columns.Count;

            
            dgvDS02.Columns["colSTT"].HeaderText = "STT"; // header text
            dgvDS02.Columns[0].DataPropertyName = "STT"; // field name

            dgvDS02.Columns[1].DataPropertyName = "bn_ma";
            dgvDS02.Columns[2].DataPropertyName = "bn_ten";
            dgvDS02.Columns[3].DataPropertyName = "gt_ten";
            dgvDS02.Columns[4].DataPropertyName = "bn_namSinh";
            dgvDS02.Columns[5].DataPropertyName = "bn_diaChi";
            dgvDS02.Columns[6].DataPropertyName = "ttpbn_ten";

            dgvDS02.DataSource = DSV;
            */


            /*
            for (int i = 0; i < dgvDS.Columns.Count; i++)
            {
                
                
                if (dgvDS.Columns[i].Name.Substring(0, 3) != "col")
                {
                    dgvDS.Columns[i].Visible = false;
                }
                //dgvDS.Columns[i].Visible = false;
            }*/
        }
        private void DocDSGioiTinh()
        {
            GioiTinhBUS gtBUS = new GioiTinhBUS();

            DSGioiTinh = gtBUS.LayDuLieu();

            cbGioiTinh.DataSource = DSGioiTinh;
            cbGioiTinh.DisplayMember = "gt_ten";
            cbGioiTinh.ValueMember = "gt_ma";

        }
        private void DocDSBenhNhan()
        {
            BenhNhanBUS bnBUS = new BenhNhanBUS();
            DSBenhNhan = bnBUS.LayDuLieu();
            DSBenhNhanV = new DataView(DSBenhNhan);
            dgvDSBenhNhan.DataSource = DSBenhNhanV;
            dgvDSBenhNhan.Columns["bn_gioiTinh"].Visible = false;
            dgvDSBenhNhan.Columns["gt_ma"].Visible = false;
            dgvDSBenhNhan.Columns["bn_xoa"].Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            DocDS();
        }

        private void tbTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text != "")
            {
                DSBenhNhanV.RowFilter = "bn_ten like '%" + tbTimKiem.Text + "%'";
            }
            else DSBenhNhanV.RowFilter = "";
        }

        private void dgvDSBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSBenhNhan.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDSBenhNhan.SelectedRows[0].DataBoundItem).Row;

                tbMa.Text = dtr["bn_ma"].ToString();
                tbTen.Text = dtr["bn_ten"].ToString();
                cbGioiTinh.SelectedValue = int.Parse(dtr["bn_gioiTinh"].ToString());
                nudNamSinh.Value = int.Parse(dtr["bn_namSinh"].ToString());
                tbDiaChi.Text = dtr["bn_diaChi"].ToString();

                btnKhamBenh.Enabled = false;
                btThemVaoDSKham.Enabled = true;
                btXoakhoiDSKham.Enabled = false;
                btCapNhatHoSo.Enabled = false;

                btnCapNhatBN.Enabled = true;
                btnXoaBN.Enabled = true;
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;

                tbMa.Text = dtr["bn_ma"].ToString();
                tbTen.Text = dtr["bn_ten"].ToString();
                cbGioiTinh.SelectedValue = int.Parse(dtr["bn_gioiTinh"].ToString());
                nudNamSinh.Value = int.Parse(dtr["bn_namSinh"].ToString());
                tbDiaChi.Text = dtr["bn_diaChi"].ToString();

                btThemVaoDSKham.Enabled = false;
                btXoakhoiDSKham.Enabled = true;
                btCapNhatHoSo.Enabled = true;
                btnKhamBenh.Enabled = true;
            }
        }

        private void btThemVaoDSKham_Click(object sender, EventArgs e)
        {

            
            if (dgvDSBenhNhan.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDSBenhNhan.SelectedRows[0].DataBoundItem).Row;
                BenhNhan bn = new BenhNhan()
                {
                    Ma = int.Parse(dtr["bn_ma"].ToString()),
                };
                PhieuKhamBenh pkb = new PhieuKhamBenh()
                {                   
                    BenhNhanKham = bn,
                    NgayKham = dtpNgay.Value,
                };
                var kq = pkbBUS.Them(pkb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -3:
                            loi = "Bệnh nhân đã nằm trong danh sách khám!!!";
                            break;
                        case -2:
                            loi = "Nhập lại giá trị đầu vào!!!";
                            break;
                        case -1:
                            loi = "Số bệnh nhân khám trong ngày đã đạt số lượng tối đa !!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Thêm thành công!!!");
                }
            }  
        }

        private void btXoakhoiDSKham_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;

                TrangThaiPKB tt = new TrangThaiPKB()
                {
                    Ma = int.Parse(dtr["pkb_ma_trangThai"].ToString()),
                };
                PhieuKhamBenh pkb = new PhieuKhamBenh()
                {
                    Ma = int.Parse(dtr["pkb_ma"].ToString()),
                    TrangThai = tt,
                };
                var kq = pkbBUS.Xoa(pkb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -5:
                            loi = "Bệnh nhân này đã xóa khỏi danh sách rồi, không thể xoá tiếp!!!";
                            break;
                        case -4:
                            loi = "Bệnh nhân này đã khám bệnh không thể xóa!!!";
                            break;
                        case -3:
                            //loi = "Bệnh nhân đã nằm trong danh sách khám!!!";
                            break;
                        case -2:
                            //loi = "Nhập lại giá trị đầu vào!!!";
                            break;
                        case -1:
                            //loi = "Số bệnh nhân khám trong ngày đã đạt số lượng tối đa !!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Xóa bệnh nhân khỏi DS khám bệnh thành công!!!");
                }
            }
        }

        private void btCapNhatHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                GioiTinh gt = new GioiTinh()
                {
                    Ma = int.Parse(((DataRowView)cbGioiTinh.SelectedItem)["gt_ma"].ToString()),
                    Ten = ((DataRowView)cbGioiTinh.SelectedItem)["gt_ten"].ToString(),
                };
                BenhNhan bn = new BenhNhan()
                {
                    /*Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GioiTinh = rbtNam.Checked,
                    NamSinh = int.Parse(nudNamSinh.Value.ToString()),
                    DiaChi = tbDiaChi.Text,*/

                    Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GioiTinh = gt,
                    NamSinh = int.Parse(nudNamSinh.Value.ToString()),
                    DiaChi = tbDiaChi.Text,

                };

                var kq = bnBUS.CapNhat(bn);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -2:
                            loi = "Tên bệnh nhân không được rỗng!!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }

                if (kq > 0)
                {
                    DocDS();
                    DocDSBenhNhan();
                    MessageBox.Show("Cập Nhật thành công!!!");
                }
            }
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            GioiTinh gt = new GioiTinh()
            {
                Ma = int.Parse(((DataRowView)cbGioiTinh.SelectedItem)["gt_ma"].ToString()),
                Ten = ((DataRowView)cbGioiTinh.SelectedItem)["gt_ten"].ToString(),
            };
            BenhNhan bn = new BenhNhan()
            {
                Ten = tbTen.Text,
                GioiTinh = gt,
                NamSinh = int.Parse(nudNamSinh.Value.ToString()),
                DiaChi = tbDiaChi.Text,
            };

            var kq = bnBUS.Them(bn);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {

                    case -2:
                        loi = "Tên bệnh nhân không được rỗng!!!";
                        break;
                }

                MessageBox.Show(loi);
            }

            if (kq > 0)
            {
                DocDSBenhNhan();
                MessageBox.Show("Thêm thành công!!!");
            }
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                GioiTinh gt = new GioiTinh()
                {
                    Ma = int.Parse(dtr["gt_ma"].ToString()),
                    Ten =dtr["gt_ten"].ToString(),
                    
                };
                BenhNhan bn = new BenhNhan()
                {
                    Ma = int.Parse(dtr["bn_ma"].ToString()),
                    Ten = dtr["bn_ten"].ToString(),
                    GioiTinh = gt,
                    NamSinh = int.Parse(dtr["bn_namSinh"].ToString()),
                    DiaChi = dtr["bn_diaChi"].ToString(),
                };

                TrangThaiPKB tt = new TrangThaiPKB()
                {
                    Ma = int.Parse(dtr["pkb_ma_trangThai"].ToString()),
                    Ten = dtr["ttpkb_ten"].ToString(),
                };

                PhieuKhamBenh pkb = new PhieuKhamBenh()
                {
                    Ma = int.Parse(dtr["pkb_ma"].ToString()),
                    BenhNhanKham=bn,
                    NgayKham=dtpNgay.Value,
                    TrangThai = tt,
                };
                if (pkb.TrangThai.Ma == 2)
                {
                    pkb.TrieuChung = dtr["pkb_trieuChung"].ToString();
                    LoaiBenh lb = new LoaiBenh()
                    {
                        Ma= int.Parse(dtr["pkb_ma_loaiBenh"].ToString()),
                        Ten =dtr["lb_ten"].ToString(),
                    };
                    pkb.BenhDuDoan = lb;
                }
                frmPhieuKhamBenh frmDT = new frmPhieuKhamBenh();
                frmDT.pkb = pkb;
                frmDT.frmDS = this;
                //this.IsMdiContainer = true;
                frmDT.MdiParent = this.MdiParent;
                frmDT.WindowState = FormWindowState.Maximized;
                frmDT.Show();

                DocDS();
            }

               
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            DocDS();
        }
    }
}
