﻿namespace QLTVNhom3
{
    partial class ucMuonsachthuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMuonsachthuthu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            btnXoasach = new Button();
            drgTimkiemsach = new DataGridView();
            TenDauSach = new DataGridViewTextBoxColumn();
            colAnhbiatrongtimkiem = new DataGridViewImageColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            NamXuatBan = new DataGridViewTextBoxColumn();
            colTinhtrang = new DataGridViewTextBoxColumn();
            grdThongtinsachmuon = new DataGridView();
            colTensachmuon = new DataGridViewTextBoxColumn();
            colAnhbiasachmuon = new DataGridViewImageColumn();
            colMasachmuon = new DataGridViewTextBoxColumn();
            colNamxb = new DataGridViewTextBoxColumn();
            colTacgia = new DataGridViewTextBoxColumn();
            colHantra = new DataGridViewTextBoxColumn();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox5 = new GroupBox();
            grdSachdangmuon = new DataGridView();
            colTensach = new DataGridViewTextBoxColumn();
            colAnhbia = new DataGridViewImageColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colHantradamuon = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            lblQuahan = new Label();
            lblDangmuon = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblThongbao = new Label();
            label6 = new Label();
            dtpNgayhethan = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox1 = new GroupBox();
            btnXemphieumuon = new Button();
            btnXoatatca = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5080376F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4919624F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(63, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.0397339F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.9602661F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Size = new Size(1435, 955);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(btnXoasach);
            groupBox3.Controls.Add(drgTimkiemsach);
            groupBox3.Controls.Add(grdThongtinsachmuon);
            groupBox3.Controls.Add(btnTimkiem);
            groupBox3.Controls.Add(txtTimkiem);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(3, 390);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1429, 487);
            groupBox3.TabIndex = 175;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            // 
            // btnXoasach
            // 
            btnXoasach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoasach.FlatAppearance.BorderSize = 0;
            btnXoasach.FlatStyle = FlatStyle.Flat;
            btnXoasach.Image = (Image)resources.GetObject("btnXoasach.Image");
            btnXoasach.Location = new Point(1327, 422);
            btnXoasach.Name = "btnXoasach";
            btnXoasach.Size = new Size(69, 59);
            btnXoasach.TabIndex = 72;
            btnXoasach.UseVisualStyleBackColor = true;
            btnXoasach.Click += btnXoaSach_Click;
            // 
            // drgTimkiemsach
            // 
            drgTimkiemsach.AllowUserToAddRows = false;
            drgTimkiemsach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            drgTimkiemsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            drgTimkiemsach.BackgroundColor = Color.White;
            drgTimkiemsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgTimkiemsach.ColumnHeadersVisible = false;
            drgTimkiemsach.Columns.AddRange(new DataGridViewColumn[] { TenDauSach, colAnhbiatrongtimkiem, MaSach, TacGia, NamXuatBan, colTinhtrang });
            drgTimkiemsach.Location = new Point(25, 104);
            drgTimkiemsach.Name = "drgTimkiemsach";
            drgTimkiemsach.RowHeadersWidth = 51;
            drgTimkiemsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            drgTimkiemsach.Size = new Size(1123, 215);
            drgTimkiemsach.TabIndex = 9;
            drgTimkiemsach.Visible = false;
            drgTimkiemsach.CellDoubleClick += drgTimkiemsach_CellDoubleClick;
            // 
            // TenDauSach
            // 
            TenDauSach.DataPropertyName = "TenDauSach";
            TenDauSach.FillWeight = 150F;
            TenDauSach.HeaderText = "Tên sách";
            TenDauSach.MinimumWidth = 6;
            TenDauSach.Name = "TenDauSach";
            // 
            // colAnhbiatrongtimkiem
            // 
            colAnhbiatrongtimkiem.FillWeight = 30F;
            colAnhbiatrongtimkiem.HeaderText = "Ảnh bìa";
            colAnhbiatrongtimkiem.MinimumWidth = 6;
            colAnhbiatrongtimkiem.Name = "colAnhbiatrongtimkiem";
            colAnhbiatrongtimkiem.Resizable = DataGridViewTriState.True;
            colAnhbiatrongtimkiem.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // TacGia
            // 
            TacGia.DataPropertyName = "TacGia";
            TacGia.HeaderText = "Tác giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            // 
            // NamXuatBan
            // 
            NamXuatBan.DataPropertyName = "NamXuatBan";
            NamXuatBan.HeaderText = "Năm Xuất bản";
            NamXuatBan.MinimumWidth = 6;
            NamXuatBan.Name = "NamXuatBan";
            NamXuatBan.Visible = false;
            // 
            // colTinhtrang
            // 
            colTinhtrang.DataPropertyName = "TinhTrang";
            colTinhtrang.HeaderText = "Tình trạng";
            colTinhtrang.MinimumWidth = 6;
            colTinhtrang.Name = "colTinhtrang";
            // 
            // grdThongtinsachmuon
            // 
            grdThongtinsachmuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdThongtinsachmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdThongtinsachmuon.BackgroundColor = Color.Gainsboro;
            grdThongtinsachmuon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdThongtinsachmuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdThongtinsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtinsachmuon.Columns.AddRange(new DataGridViewColumn[] { colTensachmuon, colAnhbiasachmuon, colMasachmuon, colNamxb, colTacgia, colHantra });
            grdThongtinsachmuon.EnableHeadersVisualStyles = false;
            grdThongtinsachmuon.Location = new Point(25, 117);
            grdThongtinsachmuon.Name = "grdThongtinsachmuon";
            grdThongtinsachmuon.RowHeadersWidth = 51;
            grdThongtinsachmuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdThongtinsachmuon.Size = new Size(1371, 299);
            grdThongtinsachmuon.TabIndex = 0;
            grdThongtinsachmuon.CellClick += grdThongtinsachmuon_CellClick;
            // 
            // colTensachmuon
            // 
            colTensachmuon.DataPropertyName = "TenDauSach";
            colTensachmuon.HeaderText = "Tên sách";
            colTensachmuon.MinimumWidth = 6;
            colTensachmuon.Name = "colTensachmuon";
            // 
            // colAnhbiasachmuon
            // 
            colAnhbiasachmuon.FillWeight = 50F;
            colAnhbiasachmuon.HeaderText = "Ảnh bìa";
            colAnhbiasachmuon.MinimumWidth = 6;
            colAnhbiasachmuon.Name = "colAnhbiasachmuon";
            colAnhbiasachmuon.Resizable = DataGridViewTriState.True;
            colAnhbiasachmuon.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colMasachmuon
            // 
            colMasachmuon.DataPropertyName = "MaSach";
            colMasachmuon.FillWeight = 50F;
            colMasachmuon.HeaderText = "Mã sách";
            colMasachmuon.MinimumWidth = 6;
            colMasachmuon.Name = "colMasachmuon";
            // 
            // colNamxb
            // 
            colNamxb.DataPropertyName = "NamXuatBan";
            colNamxb.HeaderText = "NămXB";
            colNamxb.MinimumWidth = 6;
            colNamxb.Name = "colNamxb";
            // 
            // colTacgia
            // 
            colTacgia.DataPropertyName = "TacGia";
            colTacgia.HeaderText = "Tác giả";
            colTacgia.MinimumWidth = 6;
            colTacgia.Name = "colTacgia";
            // 
            // colHantra
            // 
            colHantra.FillWeight = 50F;
            colHantra.HeaderText = "Hạn trả";
            colHantra.MinimumWidth = 6;
            colHantra.Name = "colHantra";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1190, 33);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(68, 75);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(25, 64);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1123, 34);
            txtTimkiem.TabIndex = 6;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(grdSachdangmuon);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.Location = new Point(612, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(820, 381);
            groupBox5.TabIndex = 174;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách đã đăng kí mượn";
            // 
            // grdSachdangmuon
            // 
            grdSachdangmuon.AllowUserToAddRows = false;
            grdSachdangmuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdSachdangmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSachdangmuon.BackgroundColor = Color.Gainsboro;
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
            grdSachdangmuon.Columns.AddRange(new DataGridViewColumn[] { colTensach, colAnhbia, colMasach, colNgaymuon, colHantradamuon });
            grdSachdangmuon.EnableHeadersVisualStyles = false;
            grdSachdangmuon.Location = new Point(48, 115);
            grdSachdangmuon.Name = "grdSachdangmuon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdSachdangmuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdSachdangmuon.RowHeadersWidth = 51;
            grdSachdangmuon.Size = new Size(739, 228);
            grdSachdangmuon.TabIndex = 5;
            // 
            // colTensach
            // 
            colTensach.DataPropertyName = "TenSach";
            colTensach.FillWeight = 150F;
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            // 
            // colAnhbia
            // 
            colAnhbia.HeaderText = "Ảnh bìa";
            colAnhbia.MinimumWidth = 6;
            colAnhbia.Name = "colAnhbia";
            colAnhbia.Resizable = DataGridViewTriState.True;
            colAnhbia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colMasach
            // 
            colMasach.DataPropertyName = "MaSach";
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            // 
            // colNgaymuon
            // 
            colNgaymuon.DataPropertyName = "NgayMuon";
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 6;
            colNgaymuon.Name = "colNgaymuon";
            // 
            // colHantradamuon
            // 
            colHantradamuon.DataPropertyName = "HanTra";
            colHantradamuon.HeaderText = "Hạn trả";
            colHantradamuon.MinimumWidth = 6;
            colHantradamuon.Name = "colHantradamuon";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblQuahan);
            groupBox4.Controls.Add(lblDangmuon);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(48, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(517, 65);
            groupBox4.TabIndex = 172;
            groupBox4.TabStop = false;
            // 
            // lblQuahan
            // 
            lblQuahan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblQuahan.AutoSize = true;
            lblQuahan.ForeColor = Color.Red;
            lblQuahan.Location = new Point(453, 30);
            lblQuahan.Name = "lblQuahan";
            lblQuahan.Size = new Size(24, 28);
            lblQuahan.TabIndex = 7;
            lblQuahan.Text = "3";
            // 
            // lblDangmuon
            // 
            lblDangmuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDangmuon.AutoSize = true;
            lblDangmuon.ForeColor = SystemColors.Highlight;
            lblDangmuon.Location = new Point(184, 30);
            lblDangmuon.Name = "lblDangmuon";
            lblDangmuon.Size = new Size(24, 28);
            lblDangmuon.TabIndex = 6;
            lblDangmuon.Text = "3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(314, 30);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 5;
            label2.Text = "Quá hạn:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 4;
            label1.Text = "Đang mượn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblThongbao);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpNgayhethan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTendocgia);
            groupBox2.Controls.Add(txtMadocgia);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 381);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // lblThongbao
            // 
            lblThongbao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblThongbao.AutoSize = true;
            lblThongbao.ForeColor = Color.Red;
            lblThongbao.Location = new Point(25, 267);
            lblThongbao.Name = "lblThongbao";
            lblThongbao.Size = new Size(228, 28);
            lblThongbao.TabIndex = 172;
            lblThongbao.Text = "Thông báo thẻ hết hạn";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(19, 524);
            label6.Name = "label6";
            label6.Size = new Size(482, 56);
            label6.TabIndex = 171;
            label6.Text = "Thông báo thẻ quá hạn, sách mượn quá số lượng,\r\n sách quá hạn";
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(172, 177);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 170;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(19, 180);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 168;
            label8.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 43);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(19, 109);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(172, 109);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(351, 34);
            txtTendocgia.TabIndex = 164;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(172, 43);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(351, 34);
            txtMadocgia.TabIndex = 163;
            txtMadocgia.KeyDown += txtMadocgia_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXemphieumuon);
            groupBox1.Controls.Add(btnXoatatca);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(893, 883);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 69);
            groupBox1.TabIndex = 178;
            groupBox1.TabStop = false;
            // 
            // btnXemphieumuon
            // 
            btnXemphieumuon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXemphieumuon.BackColor = SystemColors.Highlight;
            btnXemphieumuon.FlatAppearance.BorderSize = 0;
            btnXemphieumuon.FlatStyle = FlatStyle.Flat;
            btnXemphieumuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXemphieumuon.ForeColor = Color.White;
            btnXemphieumuon.Location = new Point(285, 25);
            btnXemphieumuon.Name = "btnXemphieumuon";
            btnXemphieumuon.Size = new Size(210, 38);
            btnXemphieumuon.TabIndex = 177;
            btnXemphieumuon.Text = "Xem phiếu mượn";
            btnXemphieumuon.UseVisualStyleBackColor = false;
            btnXemphieumuon.Click += btnXemphieumuon_Click;
            // 
            // btnXoatatca
            // 
            btnXoatatca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoatatca.BackColor = Color.FromArgb(192, 0, 0);
            btnXoatatca.FlatAppearance.BorderSize = 0;
            btnXoatatca.FlatStyle = FlatStyle.Flat;
            btnXoatatca.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoatatca.ForeColor = Color.White;
            btnXoatatca.Location = new Point(48, 25);
            btnXoatatca.Name = "btnXoatatca";
            btnXoatatca.Size = new Size(210, 38);
            btnXoatatca.TabIndex = 177;
            btnXoatatca.Text = "Xóa tất cả";
            btnXoatatca.UseVisualStyleBackColor = false;
            btnXoatatca.Click += button1_Click;
            // 
            // ucMuonsachthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMuonsachthuthu";
            Size = new Size(1650, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label label6;
        private DateTimePicker dtpNgayhethan;
        private Label label8;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private GroupBox groupBox5;
        private DataGridView grdSachdangmuon;
        private GroupBox groupBox4;
        private Label lblQuahan;
        private Label lblDangmuon;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView drgTimkiemsach;
        private DataGridView grdThongtinsachmuon;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private GroupBox groupBox1;
        private Button btnXemphieumuon;
        private Button btnXoatatca;
        private DateTimePicker dtpNgay = new DateTimePicker();
        private Rectangle _rectangle;
        private Button btnXoasach;
        private Label lblThongbao;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewImageColumn colAnhbia;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colHantradamuon;
        private DataGridViewTextBoxColumn colTensachmuon;
        private DataGridViewImageColumn colAnhbiasachmuon;
        private DataGridViewTextBoxColumn colMasachmuon;
        private DataGridViewTextBoxColumn colNamxb;
        private DataGridViewTextBoxColumn colTacgia;
        private DataGridViewTextBoxColumn colHantra;
        private DataGridViewTextBoxColumn TenDauSach;
        private DataGridViewImageColumn colAnhbiatrongtimkiem;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn colTinhtrang;
    }
}
