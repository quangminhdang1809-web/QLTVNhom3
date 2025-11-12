namespace QLTVNhom3
{
    partial class ucDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label9 = new Label();
            panel5 = new Panel();
            lblTongDauSach = new Label();
            panel6 = new Panel();
            lblSachDangMuon = new Label();
            label11 = new Label();
            panel7 = new Panel();
            lblSachQuaHan = new Label();
            label13 = new Label();
            panel8 = new Panel();
            lblTongDocGia = new Label();
            label15 = new Label();
            groupBox2 = new GroupBox();
            dgvSachQuaHan = new DataGridView();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenDauSach = new DataGridViewTextBoxColumn();
            colTenDocGia = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colSoNgayQuaHan = new DataGridViewTextBoxColumn();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvSachYeuThich = new DataGridView();
            colMaDauSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colSoLanMuon = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnThemDocGia = new Button();
            btnThemSach = new Button();
            label2 = new Label();
            label3 = new Label();
            pnlMaincontent = new Panel();
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            chartLuotmuon = new DevExpress.XtraCharts.ChartControl();
            lblSoSachDenHan = new Label();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachQuaHan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSachYeuThich).BeginInit();
            groupBox3.SuspendLayout();
            pnlMaincontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLuotmuon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 45);
            label1.TabIndex = 0;
            label1.Text = "Đầu sách";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(777, 30);
            label9.Name = "label9";
            label9.Size = new Size(889, 71);
            label9.TabIndex = 2;
            label9.Text = "Dashboard - Thư viện đại học NEU";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Controls.Add(lblTongDauSach);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(76, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(401, 229);
            panel5.TabIndex = 3;
            // 
            // lblTongDauSach
            // 
            lblTongDauSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongDauSach.AutoSize = true;
            lblTongDauSach.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongDauSach.ForeColor = Color.White;
            lblTongDauSach.Location = new Point(241, 134);
            lblTongDauSach.Margin = new Padding(5, 0, 5, 0);
            lblTongDauSach.Name = "lblTongDauSach";
            lblTongDauSach.Size = new Size(120, 71);
            lblTongDauSach.TabIndex = 3;
            lblTongDauSach.Text = "100";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Controls.Add(lblSachDangMuon);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(654, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(401, 229);
            panel6.TabIndex = 4;
            // 
            // lblSachDangMuon
            // 
            lblSachDangMuon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSachDangMuon.AutoSize = true;
            lblSachDangMuon.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSachDangMuon.ForeColor = Color.White;
            lblSachDangMuon.Location = new Point(238, 134);
            lblSachDangMuon.Margin = new Padding(5, 0, 5, 0);
            lblSachDangMuon.Name = "lblSachDangMuon";
            lblSachDangMuon.Size = new Size(120, 71);
            lblSachDangMuon.TabIndex = 3;
            lblSachDangMuon.Text = "100";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.ForeColor = Color.White;
            label11.Location = new Point(15, 21);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(272, 45);
            label11.TabIndex = 0;
            label11.Text = "Sách đang mượn";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HotTrack;
            panel7.Controls.Add(lblSachQuaHan);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(1232, 35);
            panel7.Name = "panel7";
            panel7.Size = new Size(401, 229);
            panel7.TabIndex = 5;
            // 
            // lblSachQuaHan
            // 
            lblSachQuaHan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSachQuaHan.AutoSize = true;
            lblSachQuaHan.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSachQuaHan.ForeColor = Color.White;
            lblSachQuaHan.Location = new Point(252, 134);
            lblSachQuaHan.Margin = new Padding(5, 0, 5, 0);
            lblSachQuaHan.Name = "lblSachQuaHan";
            lblSachQuaHan.Size = new Size(120, 71);
            lblSachQuaHan.TabIndex = 3;
            lblSachQuaHan.Text = "100";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.ForeColor = Color.White;
            label13.Location = new Point(29, 21);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(218, 45);
            label13.TabIndex = 0;
            label13.Text = "Sách quá hạn";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.HotTrack;
            panel8.Controls.Add(lblTongDocGia);
            panel8.Controls.Add(label15);
            panel8.Location = new Point(1810, 35);
            panel8.Name = "panel8";
            panel8.Size = new Size(401, 229);
            panel8.TabIndex = 6;
            // 
            // lblTongDocGia
            // 
            lblTongDocGia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongDocGia.AutoSize = true;
            lblTongDocGia.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongDocGia.ForeColor = Color.White;
            lblTongDocGia.Location = new Point(262, 134);
            lblTongDocGia.Margin = new Padding(5, 0, 5, 0);
            lblTongDocGia.Name = "lblTongDocGia";
            lblTongDocGia.Size = new Size(120, 71);
            lblTongDocGia.TabIndex = 3;
            lblTongDocGia.Text = "100";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label15.ForeColor = Color.White;
            label15.Location = new Point(27, 21);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(134, 45);
            label15.TabIndex = 0;
            label15.Text = "Độc giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(panel8);
            groupBox2.Controls.Add(panel6);
            groupBox2.Controls.Add(panel7);
            groupBox2.Location = new Point(84, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2290, 283);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // dgvSachQuaHan
            // 
            dgvSachQuaHan.AllowUserToAddRows = false;
            dgvSachQuaHan.AllowUserToDeleteRows = false;
            dgvSachQuaHan.AllowUserToResizeColumns = false;
            dgvSachQuaHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachQuaHan.BackgroundColor = SystemColors.ControlLightLight;
            dgvSachQuaHan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSachQuaHan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSachQuaHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachQuaHan.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colTenDauSach, colTenDocGia, colSDT, colSoNgayQuaHan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSachQuaHan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSachQuaHan.EnableHeadersVisualStyles = false;
            dgvSachQuaHan.Location = new Point(44, 1155);
            dgvSachQuaHan.Name = "dgvSachQuaHan";
            dgvSachQuaHan.ReadOnly = true;
            dgvSachQuaHan.RowHeadersVisible = false;
            dgvSachQuaHan.RowHeadersWidth = 82;
            dgvSachQuaHan.Size = new Size(1188, 426);
            dgvSachQuaHan.TabIndex = 8;
            // 
            // colMaSach
            // 
            colMaSach.DataPropertyName = "MaSach";
            colMaSach.HeaderText = "Mã sách";
            colMaSach.MinimumWidth = 10;
            colMaSach.Name = "colMaSach";
            colMaSach.ReadOnly = true;
            // 
            // colTenDauSach
            // 
            colTenDauSach.DataPropertyName = "TenDauSach";
            colTenDauSach.HeaderText = "Tên sách";
            colTenDauSach.MinimumWidth = 10;
            colTenDauSach.Name = "colTenDauSach";
            colTenDauSach.ReadOnly = true;
            // 
            // colTenDocGia
            // 
            colTenDocGia.DataPropertyName = "TenDocGia";
            colTenDocGia.HeaderText = "Tên độc giả";
            colTenDocGia.MinimumWidth = 10;
            colTenDocGia.Name = "colTenDocGia";
            colTenDocGia.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SoDienThoai";
            colSDT.HeaderText = "Số điện thoại";
            colSDT.MinimumWidth = 10;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colSoNgayQuaHan
            // 
            colSoNgayQuaHan.DataPropertyName = "SoNgayQuaHan";
            colSoNgayQuaHan.HeaderText = "Quá hạn (ngày)";
            colSoNgayQuaHan.MinimumWidth = 10;
            colSoNgayQuaHan.Name = "colSoNgayQuaHan";
            colSoNgayQuaHan.ReadOnly = true;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // dgvSachYeuThich
            // 
            dgvSachYeuThich.AllowUserToAddRows = false;
            dgvSachYeuThich.AllowUserToDeleteRows = false;
            dgvSachYeuThich.AllowUserToResizeColumns = false;
            dgvSachYeuThich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachYeuThich.BackgroundColor = SystemColors.ControlLightLight;
            dgvSachYeuThich.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSachYeuThich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSachYeuThich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachYeuThich.Columns.AddRange(new DataGridViewColumn[] { colMaDauSach, colTenSach, colTheLoai, colSoLanMuon });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSachYeuThich.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSachYeuThich.EnableHeadersVisualStyles = false;
            dgvSachYeuThich.Location = new Point(1316, 1155);
            dgvSachYeuThich.Name = "dgvSachYeuThich";
            dgvSachYeuThich.ReadOnly = true;
            dgvSachYeuThich.RowHeadersVisible = false;
            dgvSachYeuThich.RowHeadersWidth = 82;
            dgvSachYeuThich.Size = new Size(1055, 301);
            dgvSachYeuThich.TabIndex = 8;
            // 
            // colMaDauSach
            // 
            colMaDauSach.DataPropertyName = "MaDauSach";
            colMaDauSach.HeaderText = "Mã sách";
            colMaDauSach.MinimumWidth = 10;
            colMaDauSach.Name = "colMaDauSach";
            colMaDauSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenDauSach";
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 10;
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            // 
            // colTheLoai
            // 
            colTheLoai.DataPropertyName = "TenTheLoai";
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.MinimumWidth = 10;
            colTheLoai.Name = "colTheLoai";
            colTheLoai.ReadOnly = true;
            // 
            // colSoLanMuon
            // 
            colSoLanMuon.DataPropertyName = "SoLanMuon";
            colSoLanMuon.HeaderText = "Số lần mượn";
            colSoLanMuon.MinimumWidth = 10;
            colSoLanMuon.Name = "colSoLanMuon";
            colSoLanMuon.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThemDocGia);
            groupBox3.Controls.Add(btnThemSach);
            groupBox3.Location = new Point(1584, 1534);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(790, 146);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // btnThemDocGia
            // 
            btnThemDocGia.BackColor = SystemColors.HotTrack;
            btnThemDocGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemDocGia.ForeColor = SystemColors.ControlLightLight;
            btnThemDocGia.Location = new Point(347, 42);
            btnThemDocGia.Name = "btnThemDocGia";
            btnThemDocGia.Size = new Size(249, 87);
            btnThemDocGia.TabIndex = 0;
            btnThemDocGia.Text = "Thêm độc giả";
            btnThemDocGia.UseVisualStyleBackColor = false;
            btnThemDocGia.Click += btnThemDocGia_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.BackColor = SystemColors.HotTrack;
            btnThemSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemSach.ForeColor = SystemColors.ControlLightLight;
            btnThemSach.Location = new Point(58, 42);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(229, 87);
            btnThemSach.TabIndex = 0;
            btnThemSach.Text = "Thêm sách";
            btnThemSach.UseVisualStyleBackColor = false;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1316, 1067);
            label2.Name = "label2";
            label2.Size = new Size(508, 45);
            label2.TabIndex = 10;
            label2.Text = "Sách được yêu thích trong tháng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 1067);
            label3.Name = "label3";
            label3.Size = new Size(227, 45);
            label3.TabIndex = 10;
            label3.Text = "Sách quá hạn:";
            // 
            // pnlMaincontent
            // 
            pnlMaincontent.BorderStyle = BorderStyle.FixedSingle;
            pnlMaincontent.Controls.Add(chartControl1);
            pnlMaincontent.Controls.Add(chartLuotmuon);
            pnlMaincontent.Controls.Add(groupBox2);
            pnlMaincontent.Controls.Add(groupBox3);
            pnlMaincontent.Controls.Add(dgvSachQuaHan);
            pnlMaincontent.Controls.Add(lblSoSachDenHan);
            pnlMaincontent.Controls.Add(label3);
            pnlMaincontent.Controls.Add(label9);
            pnlMaincontent.Controls.Add(label2);
            pnlMaincontent.Controls.Add(dgvSachYeuThich);
            pnlMaincontent.Location = new Point(0, 0);
            pnlMaincontent.Name = "pnlMaincontent";
            pnlMaincontent.Size = new Size(2469, 1763);
            pnlMaincontent.TabIndex = 11;
            // 
            // chartControl1
            // 
            chartControl1.Location = new Point(256, 470);
            chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = pieSeriesView1;
            chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            chartControl1.Size = new Size(734, 508);
            chartControl1.TabIndex = 12;
            // 
            // chartLuotmuon
            // 
            chartLuotmuon.Location = new Point(1319, 470);
            chartLuotmuon.Name = "chartLuotmuon";
            chartLuotmuon.Size = new Size(1055, 508);
            chartLuotmuon.TabIndex = 11;
            chartTitle1.Tag = "";
            chartTitle1.Text = "";
            chartTitle1.TitleID = 0;
            chartLuotmuon.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle1 });
            // 
            // lblSoSachDenHan
            // 
            lblSoSachDenHan.AutoSize = true;
            lblSoSachDenHan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoSachDenHan.Location = new Point(339, 1067);
            lblSoSachDenHan.Name = "lblSoSachDenHan";
            lblSoSachDenHan.Size = new Size(38, 45);
            lblSoSachDenHan.TabIndex = 10;
            lblSoSachDenHan.Text = "3";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMaincontent);
            Margin = new Padding(5);
            Name = "ucDashboard";
            Size = new Size(2472, 1766);
            Load += ucDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSachQuaHan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSachYeuThich).EndInit();
            groupBox3.ResumeLayout(false);
            pnlMaincontent.ResumeLayout(false);
            pnlMaincontent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLuotmuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel4;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private Label label11;
        private Panel panel7;
        private Label label13;
        private Panel panel8;
        private Label label15;
        private Label label16;
        private Label lblSachQuaHan;
        private Label lblTongDocGia;
        private GroupBox groupBox2;
        private DataGridView dgvSachQuaHan;
        private Label lblTongDauSach;
        private Label lblSachDangMuon;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private DataGridView dgvSachYeuThich;
        private GroupBox groupBox3;
        private Button btnThemDocGia;
        private Button btnThemSach;
        private Panel pnlMaincontent;
        private DevExpress.XtraCharts.ChartControl chartLuotmuon;
        private DataGridViewTextBoxColumn colMaDauSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colSoLanMuon;
        private Label lblSoSachDenHan;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenDauSach;
        private DataGridViewTextBoxColumn colTenDocGia;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colSoNgayQuaHan;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
