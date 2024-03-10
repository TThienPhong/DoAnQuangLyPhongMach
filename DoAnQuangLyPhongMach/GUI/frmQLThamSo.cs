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
    public partial class frmQLThamSo : Form
    {
        ThamSoBUS tsBUS = new ThamSoBUS();
        public frmQLThamSo()
        {
            InitializeComponent();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataRow dtr = ((DataRowView)dgvDS.SelectedRows[0].DataBoundItem).Row;

                tbMa.Text = dtr["ts_ma"].ToString();
                tbTen.Text = dtr["ts_ten"].ToString();
                tbKieuDuLieu.Text = dtr["ts_kieuDuLieu"].ToString();
                
                nudGiaTri.Value = int.Parse(dtr["ts_giaTri"].ToString());
                cbTat.Checked = bool.Parse(dtr["ts_trangThaiTat"].ToString());
            }
        }
        private void DocDS()
        {
            dgvDS.DataSource = tsBUS.LayDuLieu();
        }

        private void frmQLThamSo_Load(object sender, EventArgs e)
        {
            DocDS();
        }

        private void cbTat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                ThamSo ts = new ThamSo()
                {

                    Ma = int.Parse(tbMa.Text),
                    Ten = tbTen.Text,
                    KieuDuLieu=tbKieuDuLieu.Text,
                    GiaTri = int.Parse(nudGiaTri.Value.ToString()),
                    Tat = cbTat.Checked

                };
                //MessageBox.Show(String.Format("  ts.Ma={0}, ts.ten={1}, ts.KieuDulieu={2}, ts.Giatri={3}, ts.Tat={3}", ts.Ma, ts.Ten, ts.KieuDuLieu,ts.GiaTri, ts.Tat));

                var kq = tsBUS.CapNhat(ts);
                if (kq <= 0)
                {
                    string loi = "";
                    switch (kq)
                    {

                        case -1:
                            loi = "Nhập lại các giá trị 1 !!!";
                            break;

                        case -2:
                            loi = "Nhập lại các giá trị !!!";
                            break;
                    }

                    MessageBox.Show(loi);
                }
                if (kq ==100 )
                {
                   
                    MessageBox.Show("Chưa qua được kiểm tra đầu vào");
                }

                if (kq > 0)
                {
                    DocDS();
                    ThamSoBUS.DocDSThamSo();
                    MessageBox.Show("Cập Nhật thành công!!!");
                }
            }
        }
    }
}
