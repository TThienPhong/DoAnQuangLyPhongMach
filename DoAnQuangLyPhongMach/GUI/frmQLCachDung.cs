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
    public partial class frmQLCachDung : Form
    {
        CachDungBUS cdBUS = new CachDungBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        public frmQLCachDung()
        {
            InitializeComponent();
        }

        private void DocDS()
        {
            DS = cdBUS.LayDuLieu();
            DSV = new DataView(DS);
            dgvDS.DataSource = DSV;
        }
        private void frmCachDung_Load(object sender, EventArgs e)
        {
            DocDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CachDung cd = new CachDung()
            {
                Ten = tbTen.Text,
                GhiChu = tbGhiChu.Text,
            };

            var kq = cdBUS.Them(cd);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {

                    case -2:
                        loi = "Tên cách dùng không được rỗng!!!";
                        break;
                    case -1:
                        loi = "Cách dùng đã đạt tối đa số lượng cho phép!!!";
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

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                tbMa.Text = dtr["cd_ma"].ToString();
                tbTen.Text = dtr["cd_ten"].ToString();
                tbGhiChu.Text = dtr["cd_ghiChu"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                CachDung lb = new CachDung()
                {
                    Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GhiChu = tbGhiChu.Text,

                };
                int kq=cdBUS.CapNhat(lb);

                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {                     
                        case -2:
                            loi = "Tên cách dùng không được rỗng!!!";
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
                CachDung cd = new CachDung()
                {
                    Ma = int.Parse(tbMa.Text),
                    //Ten = tbTen.Text,
                    //GhiChu = tbGhiChu.Text,
                };              
                int kq = cdBUS.Xoa(cd);

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
    }
}
