namespace QLTVNhom3
{
    partial class ucSachthuthu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSachthuthu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThemsach = new Button();
            btnTimkiem = new Button();
            cbxTheloaisach = new ComboBox();
            txtTimkiem = new TextBox();
            grdSach = new DataGridView();
            colMadausach = new DataGridViewTextBoxColumn();
            colTendausach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colSoluong = new DataGridViewTextBoxColumn();
            TrangThaiDS = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cboViTri = new ComboBox();
            btnBanSach = new Button();
            dtpNamXB = new DateTimePicker();
            grdTacgia = new DataGridView();
            colMatacgia = new DataGridViewTextBoxColumn();
            colHotentacgia = new DataGridViewTextBoxColumn();
            colNamsinh = new DataGridViewTextBoxColumn();
            colQuoctich = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtTenDauSach = new TextBox();
            txtMaDauSach = new TextBox();
            txtNhaXB = new TextBox();
            picAnhBia = new PictureBox();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnLuu = new Button();
            btnUndo = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89301F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10699F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 609F));
            tableLayoutPanel1.Controls.Add(btnThemsach, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(cbxTheloaisach, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(grdSach, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Location = new Point(115, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9669809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.03302F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.Size = new Size(1749, 1448);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThemsach
            // 
            btnThemsach.Dock = DockStyle.Right;
            btnThemsach.FlatAppearance.BorderSize = 0;
            btnThemsach.FlatStyle = FlatStyle.Flat;
            btnThemsach.Image = (Image)resources.GetObject("btnThemsach.Image");
            btnThemsach.Location = new Point(1652, 3);
            btnThemsach.Name = "btnThemsach";
            btnThemsach.Size = new Size(94, 141);
            btnThemsach.TabIndex = 103;
            btnThemsach.UseVisualStyleBackColor = true;
            btnThemsach.Click += button1_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.None;
            btnTimkiem.AutoSize = true;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1076, 38);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(58, 70);
            btnTimkiem.TabIndex = 85;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click_1;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(805, 55);
            cbxTheloaisach.Margin = new Padding(2);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(265, 36);
            cbxTheloaisach.TabIndex = 84;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 56);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(797, 34);
            txtTimkiem.TabIndex = 82;
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.BackgroundColor = Color.Gainsboro;
            grdSach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Columns.AddRange(new DataGridViewColumn[] { colMadausach, colTendausach, colTheLoai, colSoluong, TrangThaiDS });
            tableLayoutPanel1.SetColumnSpan(grdSach, 2);
            grdSach.Dock = DockStyle.Fill;
            grdSach.EnableHeadersVisualStyles = false;
            grdSach.Location = new Point(2, 149);
            grdSach.Margin = new Padding(2);
            grdSach.MultiSelect = false;
            grdSach.Name = "grdSach";
            grdSach.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdSach.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(1068, 1197);
            grdSach.TabIndex = 81;
            grdSach.SelectionChanged += grdSach_SelectionChanged;
            // 
            // colMadausach
            // 
            colMadausach.DataPropertyName = "MaDauSach";
            colMadausach.HeaderText = "Mã đầu sách";
            colMadausach.MinimumWidth = 6;
            colMadausach.Name = "colMadausach";
            colMadausach.ReadOnly = true;
            // 
            // colTendausach
            // 
            colTendausach.DataPropertyName = "TenDauSach";
            colTendausach.FillWeight = 160F;
            colTendausach.HeaderText = "Tên đầu sách";
            colTendausach.MinimumWidth = 6;
            colTendausach.Name = "colTendausach";
            colTendausach.ReadOnly = true;
            // 
            // colTheLoai
            // 
            colTheLoai.DataPropertyName = "TenTheLoai";
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.MinimumWidth = 6;
            colTheLoai.Name = "colTheLoai";
            colTheLoai.ReadOnly = true;
            // 
            // colSoluong
            // 
            colSoluong.DataPropertyName = "SoLuongTong";
            colSoluong.HeaderText = "Số lượng";
            colSoluong.MinimumWidth = 6;
            colSoluong.Name = "colSoluong";
            colSoluong.ReadOnly = true;
            // 
            // TrangThaiDS
            // 
            TrangThaiDS.DataPropertyName = "TrangThai";
            TrangThaiDS.HeaderText = "Trạng thái";
            TrangThaiDS.MinimumWidth = 6;
            TrangThaiDS.Name = "TrangThaiDS";
            TrangThaiDS.ReadOnly = true;
            TrangThaiDS.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboViTri);
            groupBox1.Controls.Add(btnBanSach);
            groupBox1.Controls.Add(dtpNamXB);
            groupBox1.Controls.Add(grdTacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtTenDauSach);
            groupBox1.Controls.Add(txtMaDauSach);
            groupBox1.Controls.Add(txtNhaXB);
            groupBox1.Controls.Add(picAnhBia);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(1142, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 1195);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // cboViTri
            // 
            cboViTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboViTri.FormattingEnabled = true;
            cboViTri.Location = new Point(198, 515);
            cboViTri.Name = "cboViTri";
            cboViTri.Size = new Size(349, 36);
            cboViTri.TabIndex = 207;
            // 
            // btnBanSach
            // 
            btnBanSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBanSach.BackColor = SystemColors.Highlight;
            btnBanSach.FlatAppearance.BorderSize = 0;
            btnBanSach.FlatStyle = FlatStyle.Flat;
            btnBanSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBanSach.ForeColor = Color.White;
            btnBanSach.Location = new Point(389, 822);
            btnBanSach.Name = "btnBanSach";
            btnBanSach.Size = new Size(158, 38);
            btnBanSach.TabIndex = 206;
            btnBanSach.Text = "Bản sách";
            btnBanSach.UseVisualStyleBackColor = false;
            btnBanSach.Click += btnBanSach_Click;
            // 
            // dtpNamXB
            // 
            dtpNamXB.CustomFormat = "yyyy";
            dtpNamXB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamXB.Format = DateTimePickerFormat.Custom;
            dtpNamXB.Location = new Point(198, 414);
            dtpNamXB.Name = "dtpNamXB";
            dtpNamXB.ShowUpDown = true;
            dtpNamXB.Size = new Size(349, 34);
            dtpNamXB.TabIndex = 205;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTacgia.ColumnHeadersHeight = 40;
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colHotentacgia, colNamsinh, colQuoctich });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdTacgia.DefaultCellStyle = dataGridViewCellStyle4;
            grdTacgia.Location = new Point(39, 622);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.Size = new Size(508, 164);
            grdTacgia.TabIndex = 204;
            // 
            // colMatacgia
            // 
            colMatacgia.DataPropertyName = "MaTacGia";
            colMatacgia.HeaderText = "Mã tác giả";
            colMatacgia.MinimumWidth = 6;
            colMatacgia.Name = "colMatacgia";
            // 
            // colHotentacgia
            // 
            colHotentacgia.DataPropertyName = "TenTacGia";
            colHotentacgia.HeaderText = "Họ và tên";
            colHotentacgia.MinimumWidth = 6;
            colHotentacgia.Name = "colHotentacgia";
            // 
            // colNamsinh
            // 
            colNamsinh.DataPropertyName = "NamSinh";
            colNamsinh.HeaderText = "Năm sinh";
            colNamsinh.MinimumWidth = 6;
            colNamsinh.Name = "colNamsinh";
            // 
            // colQuoctich
            // 
            colQuoctich.DataPropertyName = "QuocTich";
            colQuoctich.HeaderText = "Quốc tịch";
            colQuoctich.MinimumWidth = 10;
            colQuoctich.Name = "colQuoctich";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(39, 573);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 203;
            label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSoLuong.Location = new Point(198, 573);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(349, 34);
            txtSoLuong.TabIndex = 202;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(39, 308);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 201;
            label5.Text = "Mã đầu sách";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(39, 520);
            label12.Name = "label12";
            label12.Size = new Size(55, 28);
            label12.TabIndex = 200;
            label12.Text = "Vị trí";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(39, 467);
            label13.Name = "label13";
            label13.Size = new Size(51, 28);
            label13.TabIndex = 199;
            label13.Text = "NXB";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(39, 414);
            label14.Name = "label14";
            label14.Size = new Size(85, 28);
            label14.TabIndex = 198;
            label14.Text = "Năm XB";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(39, 361);
            label15.Name = "label15";
            label15.Size = new Size(130, 28);
            label15.TabIndex = 197;
            label15.Text = "Tên đầu sách";
            // 
            // txtTenDauSach
            // 
            txtTenDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenDauSach.Location = new Point(198, 361);
            txtTenDauSach.Name = "txtTenDauSach";
            txtTenDauSach.Size = new Size(349, 34);
            txtTenDauSach.TabIndex = 195;
            // 
            // txtMaDauSach
            // 
            txtMaDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaDauSach.Location = new Point(198, 308);
            txtMaDauSach.Name = "txtMaDauSach";
            txtMaDauSach.Size = new Size(349, 34);
            txtMaDauSach.TabIndex = 193;
            // 
            // txtNhaXB
            // 
            txtNhaXB.BorderStyle = BorderStyle.FixedSingle;
            txtNhaXB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNhaXB.Location = new Point(198, 467);
            txtNhaXB.Name = "txtNhaXB";
            txtNhaXB.Size = new Size(349, 34);
            txtNhaXB.TabIndex = 194;
            // 
            // picAnhBia
            // 
            picAnhBia.Location = new Point(234, 83);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(173, 186);
            picAnhBia.TabIndex = 192;
            picAnhBia.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnUndo);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(1381, 1351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 94);
            groupBox2.TabIndex = 105;
            groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(61, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(64, 43);
            btnSua.TabIndex = 177;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(290, 25);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(45, 40);
            btnLuu.TabIndex = 168;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(150, 25);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 167;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(220, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 166;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnLast);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(765, 1351);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 94);
            groupBox3.TabIndex = 106;
            groupBox3.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(83, 26);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(57, 40);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(154, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 40);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(213, 26);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 46);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(32, 26);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(45, 40);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // ucSachthuthu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucSachthuthu";
            Size = new Size(2000, 1600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView grdSach;
        private TextBox txtTimkiem;
        private ComboBox cbxTheloaisach;
        private Button btnTimkiem;
        private Button btnThemsach;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnUndo;
        private Button btnXoa;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnSua;
        private DataGridViewTextBoxColumn colMadausach;
        private DataGridViewTextBoxColumn colTendausach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colSoluong;
        private DataGridViewTextBoxColumn TrangThaiDS;
        private DateTimePicker dtpNamXB;
        private DataGridView grdTacgia;
        private DataGridViewTextBoxColumn colMatacgia;
        private DataGridViewTextBoxColumn colHotentacgia;
        private DataGridViewTextBoxColumn colNamsinh;
        private DataGridViewTextBoxColumn colQuoctich;
        private Label label1;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtTenDauSach;
        private TextBox txtMaDauSach;
        private TextBox txtNhaXB;
        private PictureBox picAnhBia;
        private Button btnBanSach;
        private ComboBox cboViTri;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}
