namespace QLTVNhom3
{
    partial class ucTrasach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTrasach));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            btnXoa = new Button();
            btnhuytra = new Button();
            btnXacnhan = new Button();
            grdThongtintrasach = new DataGridView();
            colMasachtra = new DataGridViewTextBoxColumn();
            colTensachtra = new DataGridViewTextBoxColumn();
            colNgayTra = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colHan_tra = new DataGridViewTextBoxColumn();
            colSoNgayTraTre = new DataGridViewTextBoxColumn();
            colTinhTrangSach = new DataGridViewTextBoxColumn();
            colTienPhat = new DataGridViewTextBoxColumn();
            colMaPhieuMs = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            btnHuy = new Button();
            txtXacnhan = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox3 = new GroupBox();
            grdSachdangmuon = new DataGridView();
            colMaphieu = new DataGridViewTextBoxColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colTensachdamuon = new DataGridViewTextBoxColumn();
            colHantra = new DataGridViewTextBoxColumn();
            colTinhtrang = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.2F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel1.Location = new Point(67, 62);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 730F));
            tableLayoutPanel1.Size = new Size(2438, 1491);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnhuytra);
            groupBox4.Controls.Add(btnXacnhan);
            groupBox4.Controls.Add(grdThongtintrasach);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(txtXacnhan);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(5, 766);
            groupBox4.Margin = new Padding(5, 5, 5, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 5, 5, 5);
            groupBox4.Size = new Size(2428, 720);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin trả sách";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(2266, 45);
            btnXoa.Margin = new Padding(5, 5, 5, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 63);
            btnXoa.TabIndex = 150;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnhuytra
            // 
            btnhuytra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnhuytra.BackColor = Color.FromArgb(220, 53, 69);
            btnhuytra.FlatAppearance.BorderSize = 0;
            btnhuytra.FlatStyle = FlatStyle.Flat;
            btnhuytra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnhuytra.ForeColor = Color.White;
            btnhuytra.Location = new Point(1872, 631);
            btnhuytra.Margin = new Padding(5, 5, 5, 5);
            btnhuytra.Name = "btnhuytra";
            btnhuytra.Size = new Size(236, 61);
            btnhuytra.TabIndex = 149;
            btnhuytra.Text = "Hủy";
            btnhuytra.UseVisualStyleBackColor = false;
            btnhuytra.Click += btnhuytra_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacnhan.BackColor = SystemColors.Highlight;
            btnXacnhan.FlatAppearance.BorderSize = 0;
            btnXacnhan.FlatStyle = FlatStyle.Flat;
            btnXacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacnhan.ForeColor = Color.White;
            btnXacnhan.Location = new Point(2143, 631);
            btnXacnhan.Margin = new Padding(5, 5, 5, 5);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(236, 61);
            btnXacnhan.TabIndex = 148;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // grdThongtintrasach
            // 
            grdThongtintrasach.AllowUserToAddRows = false;
            grdThongtintrasach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdThongtintrasach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdThongtintrasach.BackgroundColor = Color.White;
            grdThongtintrasach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdThongtintrasach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdThongtintrasach.ColumnHeadersHeight = 50;
            grdThongtintrasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdThongtintrasach.Columns.AddRange(new DataGridViewColumn[] { colMasachtra, colTensachtra, colNgayTra, colNgaymuon, colHan_tra, colSoNgayTraTre, colTinhTrangSach, colTienPhat, colMaPhieuMs });
            grdThongtintrasach.EnableHeadersVisualStyles = false;
            grdThongtintrasach.Location = new Point(54, 118);
            grdThongtintrasach.Margin = new Padding(5, 5, 5, 5);
            grdThongtintrasach.Name = "grdThongtintrasach";
            grdThongtintrasach.RowHeadersVisible = false;
            grdThongtintrasach.RowHeadersWidth = 51;
            grdThongtintrasach.Size = new Size(2325, 447);
            grdThongtintrasach.TabIndex = 147;
            // 
            // colMasachtra
            // 
            colMasachtra.DataPropertyName = "MaSach";
            colMasachtra.FillWeight = 70F;
            colMasachtra.HeaderText = "Mã sách";
            colMasachtra.MinimumWidth = 6;
            colMasachtra.Name = "colMasachtra";
            // 
            // colTensachtra
            // 
            colTensachtra.DataPropertyName = "TenDauSach";
            colTensachtra.FillWeight = 120F;
            colTensachtra.HeaderText = "Tên sách";
            colTensachtra.MinimumWidth = 6;
            colTensachtra.Name = "colTensachtra";
            // 
            // colNgayTra
            // 
            colNgayTra.DataPropertyName = "NgayTra";
            colNgayTra.HeaderText = "Ngày trả";
            colNgayTra.MinimumWidth = 10;
            colNgayTra.Name = "colNgayTra";
            // 
            // colNgaymuon
            // 
            colNgaymuon.DataPropertyName = "NgayMuon";
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 10;
            colNgaymuon.Name = "colNgaymuon";
            // 
            // colHan_tra
            // 
            colHan_tra.DataPropertyName = "HanTra";
            colHan_tra.HeaderText = "Hạn trả";
            colHan_tra.MinimumWidth = 10;
            colHan_tra.Name = "colHan_tra";
            // 
            // colSoNgayTraTre
            // 
            colSoNgayTraTre.DataPropertyName = "SoNgayTraTre";
            colSoNgayTraTre.HeaderText = "Số ngày trả trễ";
            colSoNgayTraTre.MinimumWidth = 10;
            colSoNgayTraTre.Name = "colSoNgayTraTre";
            // 
            // colTinhTrangSach
            // 
            colTinhTrangSach.DataPropertyName = "TinhTrang";
            colTinhTrangSach.HeaderText = "Tình trạng sách";
            colTinhTrangSach.MinimumWidth = 10;
            colTinhTrangSach.Name = "colTinhTrangSach";
            // 
            // colTienPhat
            // 
            colTienPhat.DataPropertyName = "TongTienPhat";
            colTienPhat.HeaderText = "Tiền phạt";
            colTienPhat.MinimumWidth = 10;
            colTienPhat.Name = "colTienPhat";
            // 
            // colMaPhieuMs
            // 
            colMaPhieuMs.DataPropertyName = "MaPhieuMS";
            colMaPhieuMs.HeaderText = "Mã phiếu mượn";
            colMaPhieuMs.MinimumWidth = 6;
            colMaPhieuMs.Name = "colMaPhieuMs";
            colMaPhieuMs.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(220, 53, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(2795, 1605);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(236, 61);
            button1.TabIndex = 146;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3066, 1605);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(236, 61);
            button2.TabIndex = 145;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(3565, 2647);
            btnHuy.Margin = new Padding(5, 5, 5, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(236, 61);
            btnHuy.TabIndex = 144;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // txtXacnhan
            // 
            txtXacnhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtXacnhan.BackColor = SystemColors.Highlight;
            txtXacnhan.FlatAppearance.BorderSize = 0;
            txtXacnhan.FlatStyle = FlatStyle.Flat;
            txtXacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtXacnhan.ForeColor = Color.White;
            txtXacnhan.Location = new Point(3837, 2647);
            txtXacnhan.Margin = new Padding(5, 5, 5, 5);
            txtXacnhan.Name = "txtXacnhan";
            txtXacnhan.Size = new Size(236, 61);
            txtXacnhan.TabIndex = 143;
            txtXacnhan.Text = "Xác nhận";
            txtXacnhan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1033, 751);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTendocgia);
            groupBox2.Controls.Add(txtMadocgia);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(54, 98);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(938, 530);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(28, 184);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 45);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(28, 321);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(186, 45);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(294, 318);
            txtTendocgia.Margin = new Padding(5, 5, 5, 5);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(569, 50);
            txtTendocgia.TabIndex = 164;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(294, 181);
            txtMadocgia.Margin = new Padding(5, 5, 5, 5);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(569, 50);
            txtMadocgia.TabIndex = 163;
            txtMadocgia.KeyDown += txtMadocgia_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grdSachdangmuon);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(1048, 5);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(1385, 751);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            // 
            // grdSachdangmuon
            // 
            grdSachdangmuon.AllowUserToAddRows = false;
            grdSachdangmuon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdSachdangmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSachdangmuon.BackgroundColor = Color.White;
            grdSachdangmuon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdSachdangmuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdSachdangmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSachdangmuon.Columns.AddRange(new DataGridViewColumn[] { colMaphieu, colMasach, colTensachdamuon, colHantra, colTinhtrang });
            grdSachdangmuon.EnableHeadersVisualStyles = false;
            grdSachdangmuon.Location = new Point(28, 53);
            grdSachdangmuon.Margin = new Padding(5, 5, 5, 5);
            grdSachdangmuon.Name = "grdSachdangmuon";
            grdSachdangmuon.RowHeadersVisible = false;
            grdSachdangmuon.RowHeadersWidth = 51;
            grdSachdangmuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSachdangmuon.Size = new Size(1324, 667);
            grdSachdangmuon.TabIndex = 0;
            grdSachdangmuon.CellContentClick += grdThongtinsachmuon_CellContentClick;
            grdSachdangmuon.CellFormatting += grdSachdangmuon_CellFormatting;
            // 
            // colMaphieu
            // 
            colMaphieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMaphieu.DataPropertyName = "MaPhieuMS";
            colMaphieu.HeaderText = "Mã phiếu mượn";
            colMaphieu.MinimumWidth = 10;
            colMaphieu.Name = "colMaphieu";
            // 
            // colMasach
            // 
            colMasach.DataPropertyName = "MaSach";
            colMasach.FillWeight = 70F;
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            // 
            // colTensachdamuon
            // 
            colTensachdamuon.DataPropertyName = "TenDauSach";
            colTensachdamuon.HeaderText = "Tên sách";
            colTensachdamuon.MinimumWidth = 6;
            colTensachdamuon.Name = "colTensachdamuon";
            // 
            // colHantra
            // 
            colHantra.DataPropertyName = "HanTra";
            colHantra.HeaderText = "Hạn trả";
            colHantra.MinimumWidth = 6;
            colHantra.Name = "colHantra";
            // 
            // colTinhtrang
            // 
            colTinhtrang.DataPropertyName = "TrangThai";
            colTinhtrang.HeaderText = "Tình trạng";
            colTinhtrang.MinimumWidth = 6;
            colTinhtrang.Name = "colTinhtrang";
            // 
            // ucTrasach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ucTrasach";
            Size = new Size(2681, 1600);
            Load += ucTrasach_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView grdSachdangmuon;
        private GroupBox groupBox4;
        private Button btnXoa;
        private Button btnhuytra;
        private Button btnXacnhan;
        private DataGridView grdThongtintrasach;
        private Button button1;
        private Button button2;
        private Button btnHuy;
        private Button txtXacnhan;
        private DataGridViewTextBoxColumn colMaphieu;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensachdamuon;
        private DataGridViewTextBoxColumn colHantra;
        private DataGridViewTextBoxColumn colTinhtrang;
        private DataGridViewTextBoxColumn colMasachtra;
        private DataGridViewTextBoxColumn colTensachtra;
        private DataGridViewTextBoxColumn colNgayTra;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colHan_tra;
        private DataGridViewTextBoxColumn colSoNgayTraTre;
        private DataGridViewTextBoxColumn colTinhTrangSach;
        private DataGridViewTextBoxColumn colTienPhat;
        private DataGridViewTextBoxColumn colMaPhieuMs;
    }
}
