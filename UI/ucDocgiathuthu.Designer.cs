namespace QLTVNhom3
{
    partial class ucDocgiathuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDocgiathuthu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtTimkiem = new TextBox();
            cbxLoaidocgia1 = new ComboBox();
            btnTimkiem = new Button();
            btnThemdocgia = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            grdDocgia = new DataGridView();
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dgvLichsumuontra = new DataGridView();
            colMaphieumuon = new DataGridViewTextBoxColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colTensach = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cbbLoaidocgia = new ComboBox();
            btnUndo = new Button();
            dtpNgaysinh = new DateTimePicker();
            dtpNgayhethan = new DateTimePicker();
            btnXoa = new Button();
            dtpNgaylapthe = new DateTimePicker();
            txtSdt = new TextBox();
            txtTendocgia = new TextBox();
            txtIDAccount = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtMadocgia = new TextBox();
            label11 = new Label();
            txtDiachi = new TextBox();
            label10 = new Label();
            label2 = new Label();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            colMadocgia = new DataGridViewTextBoxColumn();
            colTenDocGia = new DataGridViewTextBoxColumn();
            colNgaylapthe = new DataGridViewTextBoxColumn();
            colNgayhethan = new DataGridViewTextBoxColumn();
            colLoaidocgia = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDocgia).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuontra).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(5, 55);
            txtTimkiem.Margin = new Padding(5);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(823, 50);
            txtTimkiem.TabIndex = 15;
            // 
            // cbxLoaidocgia1
            // 
            cbxLoaidocgia1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxLoaidocgia1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaidocgia1.FormattingEnabled = true;
            cbxLoaidocgia1.Location = new Point(838, 54);
            cbxLoaidocgia1.Margin = new Padding(5);
            cbxLoaidocgia1.Name = "cbxLoaidocgia1";
            cbxLoaidocgia1.Size = new Size(350, 53);
            cbxLoaidocgia1.TabIndex = 17;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1198, 18);
            btnTimkiem.Margin = new Padding(5);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(92, 125);
            btnTimkiem.TabIndex = 18;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemdocgia
            // 
            btnThemdocgia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemdocgia.FlatAppearance.BorderSize = 0;
            btnThemdocgia.FlatStyle = FlatStyle.Flat;
            btnThemdocgia.Image = (Image)resources.GetObject("btnThemdocgia.Image");
            btnThemdocgia.Location = new Point(2344, 5);
            btnThemdocgia.Margin = new Padding(5);
            btnThemdocgia.Name = "btnThemdocgia";
            btnThemdocgia.Size = new Size(153, 144);
            btnThemdocgia.TabIndex = 19;
            btnThemdocgia.UseVisualStyleBackColor = true;
            btnThemdocgia.Click += btnThemdocgia_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3118973F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4051447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.11575556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.167202F));
            tableLayoutPanel1.Controls.Add(grdDocgia, 0, 1);
            tableLayoutPanel1.Controls.Add(btnThemdocgia, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(cbxLoaidocgia1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 4);
            tableLayoutPanel1.Location = new Point(80, 58);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.29032F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 342F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 448F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.Size = new Size(2502, 1409);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grdDocgia
            // 
            grdDocgia.AllowUserToAddRows = false;
            grdDocgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdDocgia.BackgroundColor = Color.Gainsboro;
            grdDocgia.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdDocgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdDocgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDocgia.Columns.AddRange(new DataGridViewColumn[] { colMadocgia, colTenDocGia, colNgaylapthe, colNgayhethan, colLoaidocgia });
            tableLayoutPanel1.SetColumnSpan(grdDocgia, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdDocgia.DefaultCellStyle = dataGridViewCellStyle2;
            grdDocgia.Dock = DockStyle.Fill;
            grdDocgia.EnableHeadersVisualStyles = false;
            grdDocgia.Location = new Point(5, 166);
            grdDocgia.Margin = new Padding(5);
            grdDocgia.Name = "grdDocgia";
            grdDocgia.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(grdDocgia, 3);
            grdDocgia.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grdDocgia.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            grdDocgia.RowTemplate.Height = 50;
            grdDocgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDocgia.Size = new Size(1183, 1034);
            grdDocgia.TabIndex = 20;
            grdDocgia.CellClick += grdDocgia_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbbLoaidocgia);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(dtpNgayhethan);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(dtpNgaylapthe);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1300, 166);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            tableLayoutPanel1.SetRowSpan(groupBox1, 4);
            groupBox1.Size = new Size(1197, 1238);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin độc giả";
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(1006, 1170);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(73, 64);
            btnLuu.TabIndex = 165;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLichsumuontra);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(63, 654);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(1016, 506);
            groupBox2.TabIndex = 163;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch sử mượn trả";
            // 
            // dgvLichsumuontra
            // 
            dgvLichsumuontra.AllowUserToAddRows = false;
            dgvLichsumuontra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLichsumuontra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLichsumuontra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichsumuontra.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuon, colMasach, colTensach, colNgaymuon, colTrangthai });
            dgvLichsumuontra.Location = new Point(32, 69);
            dgvLichsumuontra.Margin = new Padding(5);
            dgvLichsumuontra.Name = "dgvLichsumuontra";
            dgvLichsumuontra.ReadOnly = true;
            dgvLichsumuontra.RowHeadersWidth = 51;
            dgvLichsumuontra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichsumuontra.Size = new Size(951, 405);
            dgvLichsumuontra.TabIndex = 68;
            // 
            // colMaphieumuon
            // 
            colMaphieumuon.HeaderText = "Mã Phiếu mượn";
            colMaphieumuon.MinimumWidth = 6;
            colMaphieumuon.Name = "colMaphieumuon";
            colMaphieumuon.ReadOnly = true;
            // 
            // colMasach
            // 
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            colMasach.ReadOnly = true;
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            colTensach.ReadOnly = true;
            // 
            // colNgaymuon
            // 
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 6;
            colNgaymuon.Name = "colNgaymuon";
            colNgaymuon.ReadOnly = true;
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            colTrangthai.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(16, 114);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 45);
            label5.TabIndex = 162;
            label5.Text = "Mã độc giả";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(16, 573);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(98, 45);
            label12.TabIndex = 161;
            label12.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(16, 458);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(119, 45);
            label13.TabIndex = 160;
            label13.Text = "Địa chỉ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(16, 341);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(166, 45);
            label14.TabIndex = 159;
            label14.Text = "Ngày sinh";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(16, 226);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(186, 45);
            label15.TabIndex = 158;
            label15.Text = "Tên độc giả";
            // 
            // cbbLoaidocgia
            // 
            cbbLoaidocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbbLoaidocgia.FormattingEnabled = true;
            cbbLoaidocgia.Location = new Point(800, 336);
            cbbLoaidocgia.Margin = new Padding(5);
            cbbLoaidocgia.Name = "cbbLoaidocgia";
            cbbLoaidocgia.Size = new Size(298, 53);
            cbbLoaidocgia.TabIndex = 157;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(785, 1170);
            btnUndo.Margin = new Padding(5);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(73, 64);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(205, 339);
            dtpNgaysinh.Margin = new Padding(5);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(339, 50);
            dtpNgaysinh.TabIndex = 156;
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(800, 224);
            dtpNgayhethan.Margin = new Padding(5);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(298, 46);
            dtpNgayhethan.TabIndex = 155;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(900, 1170);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 64);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtpNgaylapthe
            // 
            dtpNgaylapthe.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaylapthe.CustomFormat = "";
            dtpNgaylapthe.Font = new Font("Segoe UI", 10.8F);
            dtpNgaylapthe.Format = DateTimePickerFormat.Short;
            dtpNgaylapthe.Location = new Point(800, 112);
            dtpNgaylapthe.Margin = new Padding(5);
            dtpNgaylapthe.Name = "dtpNgaylapthe";
            dtpNgaylapthe.Size = new Size(298, 46);
            dtpNgaylapthe.TabIndex = 154;
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSdt.Location = new Point(800, 563);
            txtSdt.Margin = new Padding(5);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(299, 50);
            txtSdt.TabIndex = 153;
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(212, 226);
            txtTendocgia.Margin = new Padding(5);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(340, 50);
            txtTendocgia.TabIndex = 141;
            // 
            // txtIDAccount
            // 
            txtIDAccount.BorderStyle = BorderStyle.FixedSingle;
            txtIDAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(800, 451);
            txtIDAccount.Margin = new Padding(5);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(299, 50);
            txtIDAccount.TabIndex = 152;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(-275, 274);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 45);
            label1.TabIndex = 138;
            label1.Text = "Tên độc giả";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(205, 566);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 50);
            txtEmail.TabIndex = 151;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(205, 112);
            txtMadocgia.Margin = new Padding(5);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(340, 50);
            txtMadocgia.TabIndex = 139;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(-275, 162);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(182, 45);
            label11.TabIndex = 150;
            label11.Text = "Mã độc giả";
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDiachi.Location = new Point(205, 453);
            txtDiachi.Margin = new Padding(5);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(340, 50);
            txtDiachi.TabIndex = 140;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(572, 451);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(172, 45);
            label10.TabIndex = 149;
            label10.Text = "IDAccount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(-275, 389);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 45);
            label2.TabIndex = 142;
            label2.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(572, 338);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(195, 45);
            label9.TabIndex = 148;
            label9.Text = "Loại độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(-275, 506);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 45);
            label3.TabIndex = 143;
            label3.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(572, 224);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(218, 45);
            label8.TabIndex = 147;
            label8.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(-275, 621);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 45);
            label4.TabIndex = 144;
            label4.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(572, 110);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(207, 45);
            label7.TabIndex = 146;
            label7.Text = "Ngày lập thẻ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(572, 565);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(212, 45);
            label6.TabIndex = 145;
            label6.Text = "Số điện thoại";
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnLast);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(751, 1210);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(437, 194);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(135, 42);
            btnPrevious.Margin = new Padding(5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(93, 64);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(250, 42);
            btnNext.Margin = new Padding(5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(73, 64);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(346, 42);
            btnLast.Margin = new Padding(5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(86, 74);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(39, 42);
            btnFirst.Margin = new Padding(5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(73, 64);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += button5_Click;
            // 
            // colMadocgia
            // 
            colMadocgia.DataPropertyName = "MaDocGia";
            colMadocgia.FillWeight = 8F;
            colMadocgia.HeaderText = "Mã Độc Giả";
            colMadocgia.MinimumWidth = 6;
            colMadocgia.Name = "colMadocgia";
            // 
            // colTenDocGia
            // 
            colTenDocGia.DataPropertyName = "HoTen";
            colTenDocGia.FillWeight = 10.6906252F;
            colTenDocGia.HeaderText = "Họ và tên";
            colTenDocGia.MinimumWidth = 6;
            colTenDocGia.Name = "colTenDocGia";
            // 
            // colNgaylapthe
            // 
            colNgaylapthe.DataPropertyName = "NgayLapThe";
            colNgaylapthe.FillWeight = 8F;
            colNgaylapthe.HeaderText = "Ngày lập thẻ";
            colNgaylapthe.MinimumWidth = 6;
            colNgaylapthe.Name = "colNgaylapthe";
            // 
            // colNgayhethan
            // 
            colNgayhethan.DataPropertyName = "NgayHetHan";
            colNgayhethan.FillWeight = 8F;
            colNgayhethan.HeaderText = "Ngày hết hạn";
            colNgayhethan.MinimumWidth = 6;
            colNgayhethan.Name = "colNgayhethan";
            // 
            // colLoaidocgia
            // 
            colLoaidocgia.DataPropertyName = "TenLoaiDG";
            colLoaidocgia.FillWeight = 8F;
            colLoaidocgia.HeaderText = "Loại độc giả";
            colLoaidocgia.MinimumWidth = 6;
            colLoaidocgia.Name = "colLoaidocgia";
            // 
            // ucDocgiathuthu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5);
            Name = "ucDocgiathuthu";
            Size = new Size(2656, 1567);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdDocgia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuontra).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTimkiem;
        private ComboBox cbxLoaidocgia1;
        private Button btnTimkiem;
        private Button btnThemdocgia;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView grdDocgia;
        private GroupBox groupBox1;
        private Button btnLuu;
        private GroupBox groupBox2;
        private DataGridView dgvLichsumuontra;
        private Label label5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cbbLoaidocgia;
        private Button btnUndo;
        private DateTimePicker dtpNgaysinh;
        private DateTimePicker dtpNgayhethan;
        private Button btnXoa;
        private DateTimePicker dtpNgaylapthe;
        private TextBox txtSdt;
        private TextBox txtTendocgia;
        private TextBox txtIDAccount;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtMadocgia;
        private Label label11;
        private TextBox txtDiachi;
        private Label label10;
        private Label label2;
        private Label label9;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DataGridViewTextBoxColumn colMaphieumuon;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colTrangthai;
        private DataGridViewTextBoxColumn colMadocgia;
        private DataGridViewTextBoxColumn colTenDocGia;
        private DataGridViewTextBoxColumn colNgaylapthe;
        private DataGridViewTextBoxColumn colNgayhethan;
        private DataGridViewTextBoxColumn colLoaidocgia;
    }
}
