
namespace DoAnQuangLyPhongMach.GUI
{
    partial class frmDsKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dgvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnCapNhatBN = new System.Windows.Forms.Button();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btCapNhatHoSo = new System.Windows.Forms.Button();
            this.btXoakhoiDSKham = new System.Windows.Forms.Button();
            this.btThemVaoDSKham = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCCCD = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nudNamSinh = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSinh)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 450);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 319);
            this.panel2.TabIndex = 3;
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
            this.colNamSinh,
            this.colDiaChi,
            this.colTrangThai});
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(0, 0);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(635, 319);
            this.dgvDS.TabIndex = 2;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
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
            this.colTen.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "gt_ten";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGioiTinh.Width = 40;
            // 
            // colNamSinh
            // 
            this.colNamSinh.DataPropertyName = "bn_namSinh";
            this.colNamSinh.HeaderText = "Năm Sinh";
            this.colNamSinh.Name = "colNamSinh";
            this.colNamSinh.ReadOnly = true;
            this.colNamSinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNamSinh.Width = 40;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "bn_diaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDiaChi.Width = 200;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "ttpkb_ten";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThai.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemDS);
            this.panel1.Controls.Add(this.btnKhamBenh);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 131);
            this.panel1.TabIndex = 2;
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.Enabled = false;
            this.btnKhamBenh.Location = new System.Drawing.Point(485, 87);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(121, 32);
            this.btnKhamBenh.TabIndex = 8;
            this.btnKhamBenh.Text = "Khám Bệnh";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dtpNgay);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(12, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(203, 30);
            this.panel11.TabIndex = 4;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd-MM-yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(86, 3);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(104, 20);
            this.dtpNgay.TabIndex = 2;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khám bệnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel14);
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm bệnh nhân";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dgvDSBenhNhan);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(3, 90);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(530, 131);
            this.panel14.TabIndex = 1;
            // 
            // dgvDSBenhNhan
            // 
            this.dgvDSBenhNhan.AllowUserToAddRows = false;
            this.dgvDSBenhNhan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSBenhNhan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvDSBenhNhan.Name = "dgvDSBenhNhan";
            this.dgvDSBenhNhan.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBenhNhan.Size = new System.Drawing.Size(530, 131);
            this.dgvDSBenhNhan.TabIndex = 2;
            this.dgvDSBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBenhNhan_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bn_ma";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Bệnh nhân";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bn_ten";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ và tên bệnh nhân";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gt_ten";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bn_namSinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Năm Sinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bn_diaChi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 400;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel5);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(3, 17);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(530, 73);
            this.panel12.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoaBN);
            this.panel5.Controls.Add(this.btnCapNhatBN);
            this.panel5.Controls.Add(this.btnThemBN);
            this.panel5.Location = new System.Drawing.Point(262, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 32);
            this.panel5.TabIndex = 20;
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.Location = new System.Drawing.Point(189, 3);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(89, 23);
            this.btnXoaBN.TabIndex = 2;
            this.btnXoaBN.Text = "Xóa BN";
            this.btnXoaBN.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatBN
            // 
            this.btnCapNhatBN.Location = new System.Drawing.Point(93, 3);
            this.btnCapNhatBN.Name = "btnCapNhatBN";
            this.btnCapNhatBN.Size = new System.Drawing.Size(90, 23);
            this.btnCapNhatBN.TabIndex = 1;
            this.btnCapNhatBN.Text = "Cập Nhật BN";
            this.btnCapNhatBN.UseVisualStyleBackColor = true;
            // 
            // btnThemBN
            // 
            this.btnThemBN.Location = new System.Drawing.Point(0, 3);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(87, 23);
            this.btnThemBN.TabIndex = 0;
            this.btnThemBN.Text = "Thêm BN";
            this.btnThemBN.UseVisualStyleBackColor = true;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.tbTimKiem);
            this.panel13.Location = new System.Drawing.Point(11, 16);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(245, 31);
            this.panel13.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm theo tên";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(85, 3);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(147, 20);
            this.tbTimKiem.TabIndex = 0;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimkiem_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 226);
            this.panel3.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btCapNhatHoSo);
            this.panel15.Controls.Add(this.btXoakhoiDSKham);
            this.panel15.Controls.Add(this.btThemVaoDSKham);
            this.panel15.Location = new System.Drawing.Point(3, 64);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(138, 140);
            this.panel15.TabIndex = 19;
            // 
            // btCapNhatHoSo
            // 
            this.btCapNhatHoSo.Enabled = false;
            this.btCapNhatHoSo.Location = new System.Drawing.Point(6, 95);
            this.btCapNhatHoSo.Name = "btCapNhatHoSo";
            this.btCapNhatHoSo.Size = new System.Drawing.Size(121, 32);
            this.btCapNhatHoSo.TabIndex = 9;
            this.btCapNhatHoSo.Text = "Cập nhật lại hồ sơ BN";
            this.btCapNhatHoSo.UseVisualStyleBackColor = true;
            this.btCapNhatHoSo.Click += new System.EventHandler(this.btCapNhatHoSo_Click);
            // 
            // btXoakhoiDSKham
            // 
            this.btXoakhoiDSKham.Enabled = false;
            this.btXoakhoiDSKham.Location = new System.Drawing.Point(6, 54);
            this.btXoakhoiDSKham.Name = "btXoakhoiDSKham";
            this.btXoakhoiDSKham.Size = new System.Drawing.Size(121, 32);
            this.btXoakhoiDSKham.TabIndex = 8;
            this.btXoakhoiDSKham.Text = "Xóa khỏi ds Khám";
            this.btXoakhoiDSKham.UseVisualStyleBackColor = true;
            this.btXoakhoiDSKham.Click += new System.EventHandler(this.btXoakhoiDSKham_Click);
            // 
            // btThemVaoDSKham
            // 
            this.btThemVaoDSKham.Enabled = false;
            this.btThemVaoDSKham.Location = new System.Drawing.Point(6, 16);
            this.btThemVaoDSKham.Name = "btThemVaoDSKham";
            this.btThemVaoDSKham.Size = new System.Drawing.Size(121, 32);
            this.btThemVaoDSKham.TabIndex = 7;
            this.btThemVaoDSKham.Text = "Thêm vào ds Khám";
            this.btThemVaoDSKham.UseVisualStyleBackColor = true;
            this.btThemVaoDSKham.Click += new System.EventHandler(this.btThemVaoDSKham_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.tbCCCD);
            this.panel7.Location = new System.Drawing.Point(156, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 31);
            this.panel7.TabIndex = 18;
            this.panel7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CCCD/CMND";
            // 
            // tbCCCD
            // 
            this.tbCCCD.Location = new System.Drawing.Point(85, 6);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Size = new System.Drawing.Size(147, 20);
            this.tbCCCD.TabIndex = 0;
            this.tbCCCD.Text = "visible=false";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.tbMa);
            this.panel6.Location = new System.Drawing.Point(156, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 31);
            this.panel6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã bệnh nhân";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(85, 3);
            this.tbMa.Name = "tbMa";
            this.tbMa.ReadOnly = true;
            this.tbMa.Size = new System.Drawing.Size(147, 20);
            this.tbMa.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbDiaChi);
            this.panel4.Location = new System.Drawing.Point(156, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 31);
            this.panel4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(85, 3);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(147, 20);
            this.tbDiaChi.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbGioiTinh);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(156, 110);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 36);
            this.panel8.TabIndex = 16;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(85, 3);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(148, 21);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới Tính";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.nudNamSinh);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(156, 81);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(245, 31);
            this.panel9.TabIndex = 15;
            // 
            // nudNamSinh
            // 
            this.nudNamSinh.Location = new System.Drawing.Point(85, 3);
            this.nudNamSinh.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNamSinh.Name = "nudNamSinh";
            this.nudNamSinh.Size = new System.Drawing.Size(147, 20);
            this.nudNamSinh.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Năm sinh";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.tbTen);
            this.panel10.Location = new System.Drawing.Point(156, 51);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(245, 31);
            this.panel10.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên bệnh nhân";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(85, 3);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(147, 20);
            this.tbTen.TabIndex = 0;
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(235, 70);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(60, 32);
            this.btnXemDS.TabIndex = 9;
            this.btnXemDS.Text = "Xem";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // frmDsKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDsKhamBenh";
            this.Text = "frmDsKhamBenh";
            this.Load += new System.EventHandler(this.frmDsKhamBenh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBenhNhan)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSinh)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown nudNamSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCCCD;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView dgvDSBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoaBN;
        private System.Windows.Forms.Button btnCapNhatBN;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btCapNhatHoSo;
        private System.Windows.Forms.Button btXoakhoiDSKham;
        private System.Windows.Forms.Button btThemVaoDSKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnXemDS;
    }
}