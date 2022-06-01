
namespace khamsk
{
    partial class KSKTT14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KSKTT14));
            this.tabDS = new System.Windows.Forms.TabPage();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgDS_TT14 = new System.Windows.Forms.DataGridView();
            this.IDBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLayDS = new System.Windows.Forms.Button();
            this.tabCrlTT14 = new System.Windows.Forms.TabControl();
            this.tabThongtin = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntKetthuc = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtLydokham = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaycap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPLSK = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNguoiKL = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBenhkhac = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPLTL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHuyetap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMach = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCannang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChieucao = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS_TT14)).BeginInit();
            this.tabCrlTT14.SuspendLayout();
            this.tabThongtin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDS
            // 
            this.tabDS.BackColor = System.Drawing.Color.Azure;
            this.tabDS.Controls.Add(this.btnXoa);
            this.tabDS.Controls.Add(this.dtgDS_TT14);
            this.tabDS.Controls.Add(this.btnLayDS);
            this.tabDS.Location = new System.Drawing.Point(4, 25);
            this.tabDS.Name = "tabDS";
            this.tabDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabDS.Size = new System.Drawing.Size(992, 688);
            this.tabDS.TabIndex = 1;
            this.tabDS.Text = "Danh sách";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(100, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // dtgDS_TT14
            // 
            this.dtgDS_TT14.AllowUserToAddRows = false;
            this.dtgDS_TT14.AllowUserToDeleteRows = false;
            this.dtgDS_TT14.AllowUserToResizeRows = false;
            this.dtgDS_TT14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDS_TT14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDS_TT14.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBN,
            this.hoten,
            this.gioitinh,
            this.namsinh});
            this.dtgDS_TT14.Location = new System.Drawing.Point(6, 55);
            this.dtgDS_TT14.Name = "dtgDS_TT14";
            this.dtgDS_TT14.ReadOnly = true;
            this.dtgDS_TT14.RowHeadersVisible = false;
            this.dtgDS_TT14.RowHeadersWidth = 51;
            this.dtgDS_TT14.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDS_TT14.RowTemplate.Height = 24;
            this.dtgDS_TT14.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDS_TT14.Size = new System.Drawing.Size(980, 627);
            this.dtgDS_TT14.TabIndex = 2;
            this.dtgDS_TT14.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDS_TT14_CellDoubleClick);
            this.dtgDS_TT14.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDS_TT14_CellMouseLeave);
            this.dtgDS_TT14.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDS_TT14_CellMouseMove);
            // 
            // IDBN
            // 
            this.IDBN.DataPropertyName = "IDBN";
            this.IDBN.HeaderText = "IDBN";
            this.IDBN.MinimumWidth = 6;
            this.IDBN.Name = "IDBN";
            this.IDBN.ReadOnly = true;
            this.IDBN.Width = 80;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 90;
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.MinimumWidth = 6;
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            this.namsinh.Width = 95;
            // 
            // btnLayDS
            // 
            this.btnLayDS.Location = new System.Drawing.Point(6, 7);
            this.btnLayDS.Name = "btnLayDS";
            this.btnLayDS.Size = new System.Drawing.Size(75, 42);
            this.btnLayDS.TabIndex = 1;
            this.btnLayDS.Text = "Làm mới";
            this.btnLayDS.UseVisualStyleBackColor = true;
            this.btnLayDS.Click += new System.EventHandler(this.btnLayDS_Click);
            // 
            // tabCrlTT14
            // 
            this.tabCrlTT14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCrlTT14.Controls.Add(this.tabThongtin);
            this.tabCrlTT14.Controls.Add(this.tabDS);
            this.tabCrlTT14.Location = new System.Drawing.Point(13, 4);
            this.tabCrlTT14.Name = "tabCrlTT14";
            this.tabCrlTT14.SelectedIndex = 0;
            this.tabCrlTT14.Size = new System.Drawing.Size(1000, 717);
            this.tabCrlTT14.TabIndex = 0;
            // 
            // tabThongtin
            // 
            this.tabThongtin.BackColor = System.Drawing.Color.Azure;
            this.tabThongtin.Controls.Add(this.panel2);
            this.tabThongtin.Controls.Add(this.panel1);
            this.tabThongtin.Controls.Add(this.groupBox2);
            this.tabThongtin.Controls.Add(this.groupBox1);
            this.tabThongtin.Location = new System.Drawing.Point(4, 25);
            this.tabThongtin.Name = "tabThongtin";
            this.tabThongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongtin.Size = new System.Drawing.Size(992, 688);
            this.tabThongtin.TabIndex = 0;
            this.tabThongtin.Text = "Thông tin";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bntKetthuc);
            this.panel2.Controls.Add(this.btnMoi);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(6, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 84);
            this.panel2.TabIndex = 76;
            // 
            // bntKetthuc
            // 
            this.bntKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntKetthuc.Location = new System.Drawing.Point(870, 20);
            this.bntKetthuc.Name = "bntKetthuc";
            this.bntKetthuc.Size = new System.Drawing.Size(75, 37);
            this.bntKetthuc.TabIndex = 76;
            this.bntKetthuc.Text = "Kết Thúc";
            this.bntKetthuc.UseVisualStyleBackColor = true;
            this.bntKetthuc.Click += new System.EventHandler(this.bntKetthuc_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoi.Location = new System.Drawing.Point(595, 20);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 37);
            this.btnMoi.TabIndex = 75;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(778, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(685, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTuoi);
            this.panel1.Controls.Add(this.txtNamsinh);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.txtLydokham);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgaycap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 181);
            this.panel1.TabIndex = 75;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(909, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 17);
            this.label23.TabIndex = 88;
            this.label23.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "CMND/ Hộ chiếu";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(857, 9);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Size = new System.Drawing.Size(46, 22);
            this.txtTuoi.TabIndex = 79;
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.Location = new System.Drawing.Point(751, 9);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(100, 22);
            this.txtNamsinh.TabIndex = 78;
            this.txtNamsinh.Enter += new System.EventHandler(this.txtNamsinh_Enter_1);
            this.txtNamsinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNamsinh_KeyUp);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(159, 11);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(296, 22);
            this.txtHoten.TabIndex = 75;
            // 
            // txtLydokham
            // 
            this.txtLydokham.Location = new System.Drawing.Point(159, 144);
            this.txtLydokham.Name = "txtLydokham";
            this.txtLydokham.Size = new System.Drawing.Size(786, 22);
            this.txtLydokham.TabIndex = 86;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(159, 96);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(786, 22);
            this.txtDiachi.TabIndex = 85;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(159, 53);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(296, 22);
            this.txtCMND.TabIndex = 81;
            this.txtCMND.Click += new System.EventHandler(this.txtCMND_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Năm sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Giới tính";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Location = new System.Drawing.Point(554, 9);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(78, 24);
            this.cbGioitinh.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Họ và Tên";
            // 
            // dtpNgaycap
            // 
            this.dtpNgaycap.Location = new System.Drawing.Point(554, 53);
            this.dtpNgaycap.Name = "dtpNgaycap";
            this.dtpNgaycap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaycap.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Lý do khám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Chổ ở hiện tại ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Ngày cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbPLSK);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtNguoiKL);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtBenhkhac);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(6, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 199);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KẾT LUẬN";
            // 
            // cbPLSK
            // 
            this.cbPLSK.FormattingEnabled = true;
            this.cbPLSK.Location = new System.Drawing.Point(112, 32);
            this.cbPLSK.Name = "cbPLSK";
            this.cbPLSK.Size = new System.Drawing.Size(100, 24);
            this.cbPLSK.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "Người kết luận";
            // 
            // txtNguoiKL
            // 
            this.txtNguoiKL.Location = new System.Drawing.Point(112, 145);
            this.txtNguoiKL.Name = "txtNguoiKL";
            this.txtNguoiKL.Size = new System.Drawing.Size(288, 22);
            this.txtNguoiKL.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Các bệnh khác";
            // 
            // txtBenhkhac
            // 
            this.txtBenhkhac.Location = new System.Drawing.Point(112, 80);
            this.txtBenhkhac.Multiline = true;
            this.txtBenhkhac.Name = "txtBenhkhac";
            this.txtBenhkhac.Size = new System.Drawing.Size(833, 39);
            this.txtBenhkhac.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Phân loại SK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPLTL);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtHuyetap);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMach);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBMI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCannang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtChieucao);
            this.groupBox1.Location = new System.Drawing.Point(6, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 173);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KHÁM THỂ LỰC";
            // 
            // cbPLTL
            // 
            this.cbPLTL.FormattingEnabled = true;
            this.cbPLTL.Location = new System.Drawing.Point(112, 118);
            this.cbPLTL.Name = "cbPLTL";
            this.cbPLTL.Size = new System.Drawing.Size(100, 24);
            this.cbPLTL.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Phân loại TL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(513, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "mmHg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "Huyết áp";
            // 
            // txtHuyetap
            // 
            this.txtHuyetap.Location = new System.Drawing.Point(406, 75);
            this.txtHuyetap.Name = "txtHuyetap";
            this.txtHuyetap.Size = new System.Drawing.Size(100, 22);
            this.txtHuyetap.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "lần/phút";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Mạch";
            // 
            // txtMach
            // 
            this.txtMach.Location = new System.Drawing.Point(112, 75);
            this.txtMach.Name = "txtMach";
            this.txtMach.Size = new System.Drawing.Size(100, 22);
            this.txtMach.TabIndex = 24;
            this.txtMach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMach_MouseClick);
            this.txtMach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMach_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(573, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Chỉ số BMI";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(653, 28);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(100, 22);
            this.txtBMI.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cân nặng";
            // 
            // txtCannang
            // 
            this.txtCannang.Location = new System.Drawing.Point(406, 28);
            this.txtCannang.Name = "txtCannang";
            this.txtCannang.Size = new System.Drawing.Size(100, 22);
            this.txtCannang.TabIndex = 18;
            this.txtCannang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCannang_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "cm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chiều cao";
            // 
            // txtChieucao
            // 
            this.txtChieucao.Location = new System.Drawing.Point(112, 28);
            this.txtChieucao.Name = "txtChieucao";
            this.txtChieucao.Size = new System.Drawing.Size(100, 22);
            this.txtChieucao.TabIndex = 15;
            this.txtChieucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieucao_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KSKTT14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 733);
            this.Controls.Add(this.tabCrlTT14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KSKTT14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁM SỨC KHOẺ TT14";
            this.Load += new System.EventHandler(this.KSKTT14_Load);
            this.tabDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS_TT14)).EndInit();
            this.tabCrlTT14.ResumeLayout(false);
            this.tabThongtin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabDS;
        private System.Windows.Forms.Button btnLayDS;
        private System.Windows.Forms.TabControl tabCrlTT14;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgDS_TT14;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.TabPage tabThongtin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtLydokham;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaycap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPLSK;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNguoiKL;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBenhkhac;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPLTL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHuyetap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCannang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChieucao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntKetthuc;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}

