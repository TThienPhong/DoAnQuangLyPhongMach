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
    public partial class frmQLLoaiBenh : Form
    {
        LoaiBenhBUS lbBUS = new LoaiBenhBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        public frmQLLoaiBenh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiBenh bn = new LoaiBenh()
            {
                Ten = tbTen.Text,
                GhiChu = tbGhiChu.Text,              
            };

            var kq = lbBUS.Them(bn);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {

                    case -2:
                        loi = "Tên loại bệnh không được rỗng!!!";
                        break;
                    case -1:
                        loi = "Loại bệnh đã đạt tối đa số lượng cho phép!!!";
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

        private void frmQLLoaiBenh_Load(object sender, EventArgs e)
        {
            DocDS();
        }   
        private void DocDS()
        {
            DS = lbBUS.LayDuLieu();
            DSV = new DataView(DS);
            dgvDS.DataSource = DSV;
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;
                tbMa.Text = dtr["lb_ma"].ToString();
                tbTen.Text = dtr["lb_ten"].ToString();
                tbGhiChu.Text = dtr["lb_ghiChu"].ToString();
               
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                LoaiBenh lb = new LoaiBenh()
                {
                    Ma=int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GhiChu = tbGhiChu.Text,

                };
                int kq= lbBUS.CapNhat(lb);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -2:
                            loi = "Tên loại bệnh không được rỗng!!!";
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
                LoaiBenh lb = new LoaiBenh()
                {
                    Ma = int.Parse(tbMa.Text),
                    //Ten = tbTen.Text,
                    //GhiChu = tbGhiChu.Text,
                };
                int kq=lbBUS.Xoa(lb);

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
