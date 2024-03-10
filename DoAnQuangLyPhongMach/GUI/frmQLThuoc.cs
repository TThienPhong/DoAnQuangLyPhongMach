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
    public partial class frmQLThuoc : Form
    {
        ThuocBUS tBUS = new ThuocBUS();
        DataTable DS = new DataTable();
        DataView DSV;
        public frmQLThuoc()
        {
            InitializeComponent();
        }
        private void DocDS()
        {
            DS = tBUS.LayDuLieu();
            DSV = new DataView(DS);
            dgvDS.DataSource = DSV;
            //dgvDS.Columns["colSTT"].Visible = false;
            for (int i=0;i< dgvDS.Columns.Count;i++)
            {

                if (dgvDS.Columns[i].Name.Substring(0,3) != "col")
                {
                    dgvDS.Columns[i].Visible = false;
                }
                //dgvDS.Columns[i].Visible = false;
            }    
        }
        private void DocDSDonViTinh()
        {
            DonViTinhBUS dvtBus = new DonViTinhBUS();
            DataTable tbDVT = dvtBus.LayDuLieu();           
            cbDonViTinh.DataSource = tbDVT;
            cbDonViTinh.DisplayMember = "dvt_ten";
            cbDonViTinh.ValueMember = "dvt_ma";
        }


        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            DocDS();
            DocDSDonViTinh();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DonViTinh dvt = new DonViTinh();
            if (cbDonViTinh.SelectedIndex>=0) {
                dvt = new DonViTinh()
                {
                    Ma = int.Parse(cbDonViTinh.SelectedValue.ToString()),
                    Ten = ((DataRowView)cbDonViTinh.SelectedItem)["dvt_ten"].ToString(),
                };
            }
            
            Thuoc t = new Thuoc()
            {
                Ten = tbTen.Text,
                GhiChu = tbGhiChu.Text,
                DoViTinh=dvt,
                Gia =int.Parse(nudGia.Value.ToString()),               
            };

            var kq = tBUS.Them(t);
            if (kq <= 0)
            {
                string loi = "";
                switch (kq)
                {

                    case -2:
                        loi = "Nhập lại giá trị đầu vào!!!";
                        break;
                    case -1:
                        loi = "Thuốc đã đạt tối số đa lượng cho phép!!!";
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
                DonViTinh dvt=new DonViTinh();
                if (cbDonViTinh.SelectedIndex >= 0)
                {
                    dvt = new DonViTinh()
                    {
                        Ma = int.Parse(cbDonViTinh.SelectedValue.ToString()),
                        Ten = ((DataRowView)cbDonViTinh.SelectedItem)["dvt_ten"].ToString(),
                    };
                }
                Thuoc t = new Thuoc()
                {
                    Ma=int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    GhiChu = tbGhiChu.Text,
                    DoViTinh = dvt,
                    Gia = int.Parse(nudGia.Value.ToString()),
                };

                int kq = tBUS.CapNhat(t);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {
                        case -1:
                            loi = "Solong vut";
                            break;
                        case -2:
                            loi = "Nhập lại giá trị đầu vào!!!";
                            break;
                        //case 100:
                            //loi = "qua thông số đầu vào";
                            //break;
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
                Thuoc t = new Thuoc()
                {
                    Ma = int.Parse(tbMa.Text),
                    //Ten = tbTen.Text,
                    //GhiChu = tbGhiChu.Text,
                };
                int kq = tBUS.Xoa(t);

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
                tbMa.Text = dtr["t_ma"].ToString();
                tbTen.Text = dtr["t_ten"].ToString();
                tbGhiChu.Text = dtr["t_ghiChu"].ToString();
                cbDonViTinh.SelectedValue = dtr["t_ma_donViTinh"].ToString();
                nudGia.Value = int.Parse(dtr["t_gia"].ToString());
                //MessageBox.Show(dtr["t_ma"].ToString());
            }
        }      
    }
}
