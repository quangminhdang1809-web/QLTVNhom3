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

        /// <summary> a
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThemsach = new Button();
            btnTimkiem = new Button();
            cbxTheloaisach = new ComboBox();
            btnBanSach = new Button();
            txtTimkiem = new TextBox();
            grdSach = new DataGridView();
            colMadausach = new DataGridViewTextBoxColumn();
            AnhBia = new DataGridViewImageColumn();
            colTendausach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colSoluong = new DataGridViewTextBoxColumn();
            TrangThaiDS = new DataGridViewTextBoxColumn();
            colAnhBiaFileName = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label2 = new Label();
            btnThayAnh = new Button();
            cboViTri = new ComboBox();
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
            panel1.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1021F));
            tableLayoutPanel1.Controls.Add(btnThemsach, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(cbxTheloaisach, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBanSach, 3, 2);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(grdSach, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 3, 3);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Location = new Point(86, 112);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8247423F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.1752548F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.Size = new Size(3016, 2409);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThemsach
            // 
            btnThemsach.Dock = DockStyle.Right;
            btnThemsach.FlatAppearance.BorderSize = 0;
            btnThemsach.FlatStyle = FlatStyle.Flat;
            btnThemsach.Image = (Image)resources.GetObject("btnThemsach.Image");
            btnThemsach.Location = new Point(2861, 5);
            btnThemsach.Margin = new Padding(5);
            btnThemsach.Name = "btnThemsach";
            btnThemsach.Size = new Size(150, 221);
            btnThemsach.TabIndex = 103;
            btnThemsach.UseVisualStyleBackColor = true;
            btnThemsach.Click += btnThemsach_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.None;
            btnTimkiem.AutoSize = true;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1913, 70);
            btnTimkiem.Margin = new Padding(5);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(58, 90);
            btnTimkiem.TabIndex = 85;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click_1;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(1419, 89);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(468, 53);
            cbxTheloaisach.TabIndex = 84;
            cbxTheloaisach.SelectedIndexChanged += cbxTheloaisach_SelectedIndexChanged;
            // 
            // btnBanSach
            // 
            btnBanSach.BackColor = SystemColors.Highlight;
            btnBanSach.Dock = DockStyle.Right;
            btnBanSach.FlatAppearance.BorderSize = 0;
            btnBanSach.FlatStyle = FlatStyle.Flat;
            btnBanSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBanSach.ForeColor = Color.White;
            btnBanSach.Location = new Point(2758, 2139);
            btnBanSach.Margin = new Padding(5);
            btnBanSach.Name = "btnBanSach";
            btnBanSach.Size = new Size(253, 92);
            btnBanSach.TabIndex = 256;
            btnBanSach.Text = "Bản sách";
            btnBanSach.UseVisualStyleBackColor = false;
            btnBanSach.Click += btnBanSach_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(5, 90);
            txtTimkiem.Margin = new Padding(5);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1324, 50);
            txtTimkiem.TabIndex = 82;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.BackgroundColor = Color.White;
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
            grdSach.Columns.AddRange(new DataGridViewColumn[] { colMadausach, AnhBia, colTendausach, colTheLoai, colSoluong, TrangThaiDS, colAnhBiaFileName });
            tableLayoutPanel1.SetColumnSpan(grdSach, 2);
            grdSach.Dock = DockStyle.Fill;
            grdSach.EnableHeadersVisualStyles = false;
            grdSach.Location = new Point(3, 234);
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
            grdSach.RowHeadersVisible = false;
            grdSach.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            grdSach.RowTemplate.Height = 300;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(1884, 1897);
            grdSach.TabIndex = 81;
            grdSach.CellFormatting += grdSach_CellFormatting;
            grdSach.SelectionChanged += grdSach_SelectionChanged;
            // 
            // colMadausach
            // 
            colMadausach.DataPropertyName = "MaDauSach";
            colMadausach.FillWeight = 70F;
            colMadausach.HeaderText = "Mã đầu sách";
            colMadausach.MinimumWidth = 6;
            colMadausach.Name = "colMadausach";
            colMadausach.ReadOnly = true;
            // 
            // AnhBia
            // 
            AnhBia.HeaderText = "Ảnh bìa";
            AnhBia.MinimumWidth = 6;
            AnhBia.Name = "AnhBia";
            AnhBia.ReadOnly = true;
            // 
            // colTendausach
            // 
            colTendausach.DataPropertyName = "TenDauSach";
            colTendausach.FillWeight = 220F;
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
            colSoluong.FillWeight = 50F;
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
            // colAnhBiaFileName
            // 
            colAnhBiaFileName.DataPropertyName = "AnhBia";
            colAnhBiaFileName.HeaderText = "Ảnh bìa";
            colAnhBiaFileName.MinimumWidth = 6;
            colAnhBiaFileName.Name = "colAnhBiaFileName";
            colAnhBiaFileName.ReadOnly = true;
            colAnhBiaFileName.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(1999, 236);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1012, 1893);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThayAnh);
            panel1.Controls.Add(cboViTri);
            panel1.Controls.Add(dtpNamXB);
            panel1.Controls.Add(grdTacgia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtTenDauSach);
            panel1.Controls.Add(txtMaDauSach);
            panel1.Controls.Add(txtNhaXB);
            panel1.Controls.Add(picAnhBia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 54);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 1834);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(104, 807);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 45);
            label2.TabIndex = 259;
            label2.Text = "NXB";
            // 
            // btnThayAnh
            // 
            btnThayAnh.BackColor = SystemColors.Highlight;
            btnThayAnh.FlatAppearance.BorderSize = 0;
            btnThayAnh.FlatStyle = FlatStyle.Flat;
            btnThayAnh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThayAnh.ForeColor = Color.White;
            btnThayAnh.Location = new Point(355, 361);
            btnThayAnh.Margin = new Padding(5);
            btnThayAnh.Name = "btnThayAnh";
            btnThayAnh.Size = new Size(426, 66);
            btnThayAnh.TabIndex = 258;
            btnThayAnh.Text = "Thay Ảnh";
            btnThayAnh.UseVisualStyleBackColor = false;
            btnThayAnh.Click += btnThayAnh_Click;
            // 
            // cboViTri
            // 
            cboViTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboViTri.FormattingEnabled = true;
            cboViTri.Location = new Point(355, 899);
            cboViTri.Margin = new Padding(5);
            cboViTri.Name = "cboViTri";
            cboViTri.Size = new Size(556, 53);
            cboViTri.TabIndex = 257;
            // 
            // dtpNamXB
            // 
            dtpNamXB.CustomFormat = "yyyy";
            dtpNamXB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamXB.Format = DateTimePickerFormat.Custom;
            dtpNamXB.Location = new Point(355, 692);
            dtpNamXB.Margin = new Padding(5);
            dtpNamXB.Name = "dtpNamXB";
            dtpNamXB.ShowUpDown = true;
            dtpNamXB.Size = new Size(556, 50);
            dtpNamXB.TabIndex = 255;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTacgia.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdTacgia.ColumnHeadersHeight = 50;
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colHotentacgia, colNamsinh, colQuoctich });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grdTacgia.DefaultCellStyle = dataGridViewCellStyle5;
            grdTacgia.Location = new Point(104, 1127);
            grdTacgia.Margin = new Padding(5);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.RowHeadersVisible = false;
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdTacgia.Size = new Size(813, 150);
            grdTacgia.TabIndex = 254;
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
            label1.Location = new Point(104, 1003);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 45);
            label1.TabIndex = 253;
            label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSoLuong.Location = new Point(355, 998);
            txtSoLuong.Margin = new Padding(5);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(557, 50);
            txtSoLuong.TabIndex = 252;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(101, 476);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(205, 45);
            label5.TabIndex = 251;
            label5.Text = "Mã đầu sách";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(104, 907);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(90, 45);
            label12.TabIndex = 250;
            label12.Text = "Vị trí";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(104, 697);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(138, 45);
            label14.TabIndex = 248;
            label14.Text = "Năm XB";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(104, 587);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(209, 45);
            label15.TabIndex = 247;
            label15.Text = "Tên đầu sách";
            // 
            // txtTenDauSach
            // 
            txtTenDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenDauSach.Location = new Point(355, 582);
            txtTenDauSach.Margin = new Padding(5);
            txtTenDauSach.Name = "txtTenDauSach";
            txtTenDauSach.Size = new Size(557, 50);
            txtTenDauSach.TabIndex = 246;
            // 
            // txtMaDauSach
            // 
            txtMaDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaDauSach.Location = new Point(355, 476);
            txtMaDauSach.Margin = new Padding(5);
            txtMaDauSach.Name = "txtMaDauSach";
            txtMaDauSach.Size = new Size(557, 50);
            txtMaDauSach.TabIndex = 244;
            // 
            // txtNhaXB
            // 
            txtNhaXB.BorderStyle = BorderStyle.FixedSingle;
            txtNhaXB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNhaXB.Location = new Point(355, 802);
            txtNhaXB.Margin = new Padding(5);
            txtNhaXB.Name = "txtNhaXB";
            txtNhaXB.Size = new Size(557, 50);
            txtNhaXB.TabIndex = 245;
            // 
            // picAnhBia
            // 
            picAnhBia.BackColor = Color.Transparent;
            picAnhBia.Location = new Point(424, 43);
            picAnhBia.Margin = new Padding(5);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(289, 317);
            picAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhBia.TabIndex = 243;
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
            groupBox2.Location = new Point(2427, 2241);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(584, 163);
            groupBox2.TabIndex = 105;
            groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(98, 35);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 69);
            btnSua.TabIndex = 177;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(464, 40);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(72, 64);
            btnLuu.TabIndex = 168;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(240, 40);
            btnUndo.Margin = new Padding(5);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(72, 64);
            btnUndo.TabIndex = 167;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(352, 40);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(72, 64);
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
            groupBox3.Location = new Point(1399, 2241);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(486, 163);
            groupBox3.TabIndex = 106;
            groupBox3.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(133, 42);
            btnPrevious.Margin = new Padding(5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(91, 64);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(246, 42);
            btnNext.Margin = new Padding(5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(72, 64);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(341, 42);
            btnLast.Margin = new Padding(5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(85, 74);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(51, 42);
            btnFirst.Margin = new Padding(5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(72, 64);
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
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5);
            Name = "ucSachthuthu";
            Size = new Size(3200, 2560);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Panel panel1;
        private Label label2;
        private Button btnThayAnh;
        private ComboBox cboViTri;
        private Button btnBanSach;
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
        private Label label14;
        private Label label15;
        private TextBox txtTenDauSach;
        private TextBox txtMaDauSach;
        private TextBox txtNhaXB;
        private PictureBox picAnhBia;
        private DataGridViewTextBoxColumn colMadausach;
        private DataGridViewImageColumn AnhBia;
        private DataGridViewTextBoxColumn colTendausach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colSoluong;
        private DataGridViewTextBoxColumn TrangThaiDS;
        private DataGridViewTextBoxColumn colAnhBiaFileName;
    }
}
