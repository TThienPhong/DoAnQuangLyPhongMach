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



namespace DoAnQuangLyPhongMach
{
    public partial class frmQLBenhNhan : Form
    {
        BenhNhanBUS bnBUS = new BenhNhanBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        DataTable DSGioiTinh;
        public frmQLBenhNhan()
        {
            InitializeComponent();
        }

        private void dtpNamSinh_ValueChanged(object sender, EventArgs e)
        {

        }
        private RadioButton isCheckBox(Panel pnl)
        {
            RadioButton ckb = null;

            foreach (RadioButton item in pnl.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        ckb = item;
                        break;
                    }
            }
            return ckb;
        }

        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            nudNamSinh.Minimum = 1900;
            nudNamSinh.Maximum = 2500;
            
            DocDS();
            DocDSGioiTinh();
            cbGioiTinh.SelectedIndex = 0;
        }
        private void DocDSGioiTinh()
        {
            GioiTinhBUS gtBUS = new GioiTinhBUS();

            DSGioiTinh = gtBUS.LayDuLieu();
           
            cbGioiTinh.DataSource = DSGioiTinh;
            cbGioiTinh.DisplayMember = "gt_ten";
            cbGioiTinh.ValueMember = "gt_ma";
            

        }
        private void DocDS()
        {
            DS = bnBUS.LayDuLieu();
            DSV = new DataView(DS);
            dgvDS.DataSource = DSV;
            dgvDS.Columns["bn_gioiTinh"].Visible = false;
            dgvDS.Columns["gt_ma"].Visible = false;
            dgvDS.Columns["bn_xoa"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                DocDS();
                MessageBox.Show("Thêm thành công!!!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count>0)
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
                    MessageBox.Show("Cập Nhật thành công!!!");
                }
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
            }          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                BenhNhan bn = new BenhNhan()
                {
                    /*Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GioiTinh = rbtNam.Checked,
                    NamSinh = int.Parse(nudNamSinh.Value.ToString()),
                    DiaChi = tbDiaChi.Text,*/
                    Ma = int.Parse(tbMa.Text),                  

                };

                var kq = bnBUS.Xoa(bn);
                if (kq <= 0)
                {
                    string loi = "Chưa Xóa!!!";
                    MessageBox.Show(loi);
                }

                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text != "")
            {
                DSV.RowFilter = "bn_ten like '%" + tbTimKiem.Text + "%'";
            }
            else DSV.RowFilter = "";
        }
    }
}
