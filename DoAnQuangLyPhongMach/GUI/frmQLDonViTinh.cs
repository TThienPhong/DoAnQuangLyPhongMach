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
    public partial class frmQLDonViTinh : Form
    {
        DonViTinhBUS dvtBUS = new DonViTinhBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        public frmQLDonViTinh()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DocDS()
        {
            DS = dvtBUS.LayDuLieu();
            DSV = new DataView(DS);
            dgvDS.DataSource = DSV;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DonViTinh bn = new DonViTinh()
            {
                Ten = tbTen.Text,
                GhiChu = tbGhiChu.Text,
            };

            var kq = dvtBUS.Them(bn);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {

                    case -2:
                        loi = "Tên đơn vị tính không được rỗng!!!";
                        break;
                    case -1:
                        loi = "Đơn vị tính đã đạt tối đa số lượng cho phép!!!";
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
            if (dgvDS.SelectedRows.Count > 0)
            {
                DonViTinh dvt = new DonViTinh()
                {
                    Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GhiChu = tbGhiChu.Text,

                };
                int kq = dvtBUS.CapNhat(dvt);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -2:
                            loi = "Tên đơn vị tính không được rỗng!!!";
                            break;
                    }
                    MessageBox.Show(loi);
                }
                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Cập nhật thành công!!!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DonViTinh dvt = new DonViTinh()
                {
                    Ma = int.Parse(tbMa.Text),
                    //Ten = tbTen.Text,
                    //GhiChu = tbGhiChu.Text,
                };
                int kq = dvtBUS.Xoa(dvt);

                if (kq <= 0)
                {
                    string loi = "Chưa xóa!!!";
                    MessageBox.Show(loi);
                }

                if (kq > 0)
                {
                    DocDS();
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                tbMa.Text = dtr["dvt_ma"].ToString();
                tbTen.Text = dtr["dvt_ten"].ToString();
                tbGhiChu.Text = dtr["dvt_ghiChu"].ToString();

            }
        }

        private void frmQLDonViTinh_Load(object sender, EventArgs e)
        {
            DocDS();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
