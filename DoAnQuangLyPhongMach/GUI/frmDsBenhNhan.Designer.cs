
namespace DoAnQuangLyPhongMach.GUI
{
    partial class frmDsBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgay2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpNgay1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 154);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgay2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(56, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 30);
            this.panel2.TabIndex = 14;
            // 
            // dtpNgay2
            // 
            this.dtpNgay2.CustomFormat = "dd-MM-yyyy";
            this.dtpNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay2.Location = new System.Drawing.Point(86, 3);
            this.dtpNgay2.Name = "dtpNgay2";
            this.dtpNgay2.Size = new System.Drawing.Size(104, 20);
            this.dtpNgay2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến này";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(520, 82);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(121, 32);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dtpNgay1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(56, 63);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(203, 30);
            this.panel11.TabIndex = 13;
            // 
            // dtpNgay1
            // 
            this.dtpNgay1.CustomFormat = "dd-MM-yyyy";
            this.dtpNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay1.Location = new System.Drawing.Point(86, 3);
            this.dtpNgay1.Name = "dtpNgay1";
            this.dtpNgay1.Size = new System.Drawing.Size(104, 20);
            this.dtpNgay1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ này";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách bệnh nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 347);
            this.panel3.TabIndex = 13;
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.AllowUserToDeleteRows = false;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa,
            this.colTen,
            this.colGioiTinh,
            this.colLoaiBenh,
            this.colTrieuChung});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(0, 0);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(800, 347);
            this.dgvDS.TabIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 40;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "bn_ma";
            this.colMa.HeaderText = "Mã Bệnh nhân";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMa.Width = 60;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "bn_ten";
            this.colTen.HeaderText = "Họ và tên bệnh nhân";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTen.Width = 200;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "pkb_ngayKham";
            this.colGioiTinh.HeaderText = "Ngày khám";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colLoaiBenh
            // 
            this.colLoaiBenh.DataPropertyName = "lb_ten";
            this.colLoaiBenh.HeaderText = "Loại Bệnh";
            this.colLoaiBenh.Name = "colLoaiBenh";
            this.colLoaiBenh.ReadOnly = true;
            this.colLoaiBenh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiBenh.Width = 150;
            // 
            // colTrieuChung
            // 
            this.colTrieuChung.DataPropertyName = "pkb_trieuChung";
            this.colTrieuChung.HeaderText = "Triệu chứng";
            this.colTrieuChung.Name = "colTrieuChung";
            this.colTrieuChung.ReadOnly = true;
            this.colTrieuChung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrieuChung.Width = 200;
            // 
            // frmDsBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmDsBenhNhan";
            this.Text = "frmDsBenhNhan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgay2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker dtpNgay1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrieuChung;
    }
}