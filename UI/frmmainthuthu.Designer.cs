﻿namespace QLTVNhom3
{
    partial class frmmainthuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmainthuthu));
            btnThoat = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel4 = new Panel();
            pnlDanhmuc = new Panel();
            btnKhosach = new Button();
            btnTheloai = new Button();
            btnTacgia = new Button();
            btnDocgia = new Button();
            btnDanhmuc = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            lblmatt = new Label();
            lblten = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnQuanlysach = new Button();
            pnlQuanlysach = new Panel();
            btnMacabiet = new Button();
            btnSach = new Button();
            btnMuonsach = new Button();
            btnTrasach = new Button();
            btnBaocao = new Button();
            pnlBaocao = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            label4 = new Label();
            btnDangxuat = new Button();
            panel1 = new Panel();
            pnlMaincontent = new Panel();
            pnlDanhmuc.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnlQuanlysach.SuspendLayout();
            pnlBaocao.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Right;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1641, 0);
            btnThoat.Margin = new Padding(5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 96);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 11);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 50);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 902);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 0);
            panel4.TabIndex = 14;
            // 
            // pnlDanhmuc
            // 
            pnlDanhmuc.BackColor = SystemColors.Highlight;
            pnlDanhmuc.Controls.Add(btnKhosach);
            pnlDanhmuc.Controls.Add(btnTheloai);
            pnlDanhmuc.Controls.Add(btnTacgia);
            pnlDanhmuc.Location = new Point(41, 591);
            pnlDanhmuc.Margin = new Padding(41, 5, 5, 5);
            pnlDanhmuc.Name = "pnlDanhmuc";
            pnlDanhmuc.Size = new Size(325, 301);
            pnlDanhmuc.TabIndex = 4;
            pnlDanhmuc.Visible = false;
            // 
            // btnKhosach
            // 
            btnKhosach.BackColor = SystemColors.Highlight;
            btnKhosach.FlatAppearance.BorderSize = 0;
            btnKhosach.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnKhosach.FlatStyle = FlatStyle.Flat;
            btnKhosach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnKhosach.ForeColor = Color.White;
            btnKhosach.Image = (Image)resources.GetObject("btnKhosach.Image");
            btnKhosach.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhosach.Location = new Point(-5, 206);
            btnKhosach.Margin = new Padding(41, 5, 5, 5);
            btnKhosach.Name = "btnKhosach";
            btnKhosach.Size = new Size(325, 85);
            btnKhosach.TabIndex = 10;
            btnKhosach.Text = "        Vị trí sách";
            btnKhosach.TextAlign = ContentAlignment.MiddleLeft;
            btnKhosach.UseVisualStyleBackColor = false;
            btnKhosach.Click += btnKhosach_Click;
            // 
            // btnTheloai
            // 
            btnTheloai.BackColor = SystemColors.Highlight;
            btnTheloai.FlatAppearance.BorderSize = 0;
            btnTheloai.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnTheloai.FlatStyle = FlatStyle.Flat;
            btnTheloai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTheloai.ForeColor = Color.White;
            btnTheloai.Image = (Image)resources.GetObject("btnTheloai.Image");
            btnTheloai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheloai.Location = new Point(0, 106);
            btnTheloai.Margin = new Padding(41, 5, 5, 5);
            btnTheloai.Name = "btnTheloai";
            btnTheloai.Size = new Size(325, 85);
            btnTheloai.TabIndex = 9;
            btnTheloai.Text = "        Thể loại";
            btnTheloai.TextAlign = ContentAlignment.MiddleLeft;
            btnTheloai.UseVisualStyleBackColor = false;
            btnTheloai.Click += btnTheloai_Click;
            // 
            // btnTacgia
            // 
            btnTacgia.BackColor = SystemColors.Highlight;
            btnTacgia.FlatAppearance.BorderSize = 0;
            btnTacgia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnTacgia.FlatStyle = FlatStyle.Flat;
            btnTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTacgia.ForeColor = Color.White;
            btnTacgia.Image = (Image)resources.GetObject("btnTacgia.Image");
            btnTacgia.ImageAlign = ContentAlignment.MiddleLeft;
            btnTacgia.Location = new Point(0, 5);
            btnTacgia.Margin = new Padding(41, 5, 5, 5);
            btnTacgia.Name = "btnTacgia";
            btnTacgia.Size = new Size(325, 85);
            btnTacgia.TabIndex = 8;
            btnTacgia.Text = "        Tác giả";
            btnTacgia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacgia.UseVisualStyleBackColor = false;
            btnTacgia.Click += btnTacgia_Click;
            // 
            // btnDocgia
            // 
            btnDocgia.BackColor = SystemColors.HotTrack;
            btnDocgia.FlatAppearance.BorderSize = 0;
            btnDocgia.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnDocgia.FlatStyle = FlatStyle.Flat;
            btnDocgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDocgia.ForeColor = Color.White;
            btnDocgia.Image = (Image)resources.GetObject("btnDocgia.Image");
            btnDocgia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocgia.Location = new Point(41, 912);
            btnDocgia.Margin = new Padding(41, 5, 5, 5);
            btnDocgia.Name = "btnDocgia";
            btnDocgia.Size = new Size(325, 85);
            btnDocgia.TabIndex = 7;
            btnDocgia.Text = "        Độc giả";
            btnDocgia.TextAlign = ContentAlignment.MiddleLeft;
            btnDocgia.UseVisualStyleBackColor = false;
            btnDocgia.Click += btnDocgia_Click;
            // 
            // btnDanhmuc
            // 
            btnDanhmuc.BackColor = SystemColors.HotTrack;
            btnDanhmuc.FlatAppearance.BorderSize = 0;
            btnDanhmuc.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnDanhmuc.FlatStyle = FlatStyle.Flat;
            btnDanhmuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDanhmuc.ForeColor = Color.White;
            btnDanhmuc.Image = (Image)resources.GetObject("btnDanhmuc.Image");
            btnDanhmuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhmuc.Location = new Point(41, 496);
            btnDanhmuc.Margin = new Padding(41, 5, 5, 5);
            btnDanhmuc.Name = "btnDanhmuc";
            btnDanhmuc.Size = new Size(325, 85);
            btnDanhmuc.TabIndex = 5;
            btnDanhmuc.Text = "        Danh mục";
            btnDanhmuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhmuc.UseVisualStyleBackColor = false;
            btnDanhmuc.Click += btnDanhmuc_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.HotTrack;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(41, 401);
            btnDashboard.Margin = new Padding(41, 5, 5, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(325, 85);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "        Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(lblmatt);
            panel3.Controls.Add(lblten);
            panel3.Location = new Point(5, 242);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 149);
            panel3.TabIndex = 1;
            // 
            // lblmatt
            // 
            lblmatt.AutoSize = true;
            lblmatt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblmatt.ForeColor = Color.White;
            lblmatt.Location = new Point(146, 90);
            lblmatt.Margin = new Padding(5, 0, 5, 0);
            lblmatt.Name = "lblmatt";
            lblmatt.Size = new Size(68, 45);
            lblmatt.TabIndex = 1;
            lblmatt.Text = "Mã";
            lblmatt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblten
            // 
            lblten.AutoSize = true;
            lblten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblten.ForeColor = Color.White;
            lblten.Location = new Point(101, 19);
            lblten.Margin = new Padding(5, 0, 5, 0);
            lblten.Name = "lblten";
            lblten.Size = new Size(174, 45);
            lblten.TabIndex = 0;
            lblten.Text = "Họ và tên ";
            lblten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 32);
            pictureBox1.Margin = new Padding(81, 32, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.HotTrack;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnDanhmuc);
            flowLayoutPanel1.Controls.Add(pnlDanhmuc);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(btnDocgia);
            flowLayoutPanel1.Controls.Add(btnQuanlysach);
            flowLayoutPanel1.Controls.Add(pnlQuanlysach);
            flowLayoutPanel1.Controls.Add(btnMuonsach);
            flowLayoutPanel1.Controls.Add(btnTrasach);
            flowLayoutPanel1.Controls.Add(btnBaocao);
            flowLayoutPanel1.Controls.Add(pnlBaocao);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 1617);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnQuanlysach
            // 
            btnQuanlysach.BackColor = SystemColors.HotTrack;
            btnQuanlysach.FlatAppearance.BorderSize = 0;
            btnQuanlysach.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnQuanlysach.FlatStyle = FlatStyle.Flat;
            btnQuanlysach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnQuanlysach.ForeColor = Color.White;
            btnQuanlysach.Image = (Image)resources.GetObject("btnQuanlysach.Image");
            btnQuanlysach.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanlysach.Location = new Point(41, 1007);
            btnQuanlysach.Margin = new Padding(41, 5, 5, 5);
            btnQuanlysach.Name = "btnQuanlysach";
            btnQuanlysach.Size = new Size(325, 85);
            btnQuanlysach.TabIndex = 9;
            btnQuanlysach.Text = "        Quản lý sách";
            btnQuanlysach.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanlysach.UseVisualStyleBackColor = false;
            btnQuanlysach.Click += button6_Click;
            // 
            // pnlQuanlysach
            // 
            pnlQuanlysach.BackColor = SystemColors.Highlight;
            pnlQuanlysach.Controls.Add(btnMacabiet);
            pnlQuanlysach.Controls.Add(btnSach);
            pnlQuanlysach.Location = new Point(41, 1102);
            pnlQuanlysach.Margin = new Padding(41, 5, 5, 5);
            pnlQuanlysach.Name = "pnlQuanlysach";
            pnlQuanlysach.Size = new Size(325, 198);
            pnlQuanlysach.TabIndex = 23;
            pnlQuanlysach.Visible = false;
            // 
            // btnMacabiet
            // 
            btnMacabiet.BackColor = SystemColors.Highlight;
            btnMacabiet.FlatAppearance.BorderSize = 0;
            btnMacabiet.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnMacabiet.FlatStyle = FlatStyle.Flat;
            btnMacabiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnMacabiet.ForeColor = Color.White;
            btnMacabiet.Image = (Image)resources.GetObject("btnMacabiet.Image");
            btnMacabiet.ImageAlign = ContentAlignment.MiddleLeft;
            btnMacabiet.Location = new Point(-5, 99);
            btnMacabiet.Margin = new Padding(41, 5, 5, 5);
            btnMacabiet.Name = "btnMacabiet";
            btnMacabiet.Size = new Size(325, 85);
            btnMacabiet.TabIndex = 10;
            btnMacabiet.Text = "        Tài liệu";
            btnMacabiet.TextAlign = ContentAlignment.MiddleLeft;
            btnMacabiet.UseVisualStyleBackColor = false;
            btnMacabiet.Click += button5_Click;
            // 
            // btnSach
            // 
            btnSach.BackColor = SystemColors.Highlight;
            btnSach.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSach.ForeColor = Color.White;
            btnSach.Image = (Image)resources.GetObject("btnSach.Image");
            btnSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnSach.Location = new Point(-5, 5);
            btnSach.Margin = new Padding(41, 5, 5, 5);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(325, 85);
            btnSach.TabIndex = 6;
            btnSach.Text = "        Đầu sách";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.UseVisualStyleBackColor = false;
            btnSach.Click += btnSach_Click;
            // 
            // btnMuonsach
            // 
            btnMuonsach.BackColor = SystemColors.HotTrack;
            btnMuonsach.FlatAppearance.BorderSize = 0;
            btnMuonsach.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnMuonsach.FlatStyle = FlatStyle.Flat;
            btnMuonsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnMuonsach.ForeColor = Color.White;
            btnMuonsach.Image = (Image)resources.GetObject("btnMuonsach.Image");
            btnMuonsach.ImageAlign = ContentAlignment.MiddleLeft;
            btnMuonsach.Location = new Point(41, 1310);
            btnMuonsach.Margin = new Padding(41, 5, 5, 5);
            btnMuonsach.Name = "btnMuonsach";
            btnMuonsach.Size = new Size(325, 85);
            btnMuonsach.TabIndex = 24;
            btnMuonsach.Text = "        Mượn sách";
            btnMuonsach.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonsach.UseVisualStyleBackColor = false;
            btnMuonsach.Click += btnMuonsach_Click;
            // 
            // btnTrasach
            // 
            btnTrasach.BackColor = SystemColors.HotTrack;
            btnTrasach.FlatAppearance.BorderSize = 0;
            btnTrasach.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnTrasach.FlatStyle = FlatStyle.Flat;
            btnTrasach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTrasach.ForeColor = Color.White;
            btnTrasach.Image = (Image)resources.GetObject("btnTrasach.Image");
            btnTrasach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrasach.Location = new Point(41, 1405);
            btnTrasach.Margin = new Padding(41, 5, 5, 5);
            btnTrasach.Name = "btnTrasach";
            btnTrasach.Size = new Size(325, 85);
            btnTrasach.TabIndex = 25;
            btnTrasach.Text = "        Trả sách";
            btnTrasach.TextAlign = ContentAlignment.MiddleLeft;
            btnTrasach.UseVisualStyleBackColor = false;
            btnTrasach.Click += btnTrasach_Click;
            // 
            // btnBaocao
            // 
            btnBaocao.BackColor = SystemColors.HotTrack;
            btnBaocao.FlatAppearance.BorderSize = 0;
            btnBaocao.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnBaocao.FlatStyle = FlatStyle.Flat;
            btnBaocao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBaocao.ForeColor = Color.White;
            btnBaocao.Image = (Image)resources.GetObject("btnBaocao.Image");
            btnBaocao.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaocao.Location = new Point(41, 1500);
            btnBaocao.Margin = new Padding(41, 5, 5, 5);
            btnBaocao.Name = "btnBaocao";
            btnBaocao.Size = new Size(325, 85);
            btnBaocao.TabIndex = 26;
            btnBaocao.Text = "        Báo cáo";
            btnBaocao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaocao.UseVisualStyleBackColor = false;
            btnBaocao.Click += btnBaocao_Click;
            // 
            // pnlBaocao
            // 
            pnlBaocao.BackColor = SystemColors.Highlight;
            pnlBaocao.Controls.Add(button2);
            pnlBaocao.Controls.Add(button3);
            pnlBaocao.Controls.Add(button4);
            pnlBaocao.Location = new Point(41, 1595);
            pnlBaocao.Margin = new Padding(41, 5, 5, 5);
            pnlBaocao.Name = "pnlBaocao";
            pnlBaocao.Size = new Size(325, 286);
            pnlBaocao.TabIndex = 27;
            pnlBaocao.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 194);
            button2.Margin = new Padding(41, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(325, 85);
            button2.TabIndex = 8;
            button2.Text = "Tình trạng phạt";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 99);
            button3.Margin = new Padding(41, 5, 5, 5);
            button3.Name = "button3";
            button3.Size = new Size(325, 85);
            button3.TabIndex = 7;
            button3.Text = "Sách trả trễ";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 5);
            button4.Margin = new Padding(41, 5, 5, 5);
            button4.Name = "button4";
            button4.Size = new Size(325, 85);
            button4.TabIndex = 6;
            button4.Text = "Sách đang mượn";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.HotTrack;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.28675F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.71324873F));
            tableLayoutPanel1.Size = new Size(406, 1763);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(btnDangxuat);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(5, 1632);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(396, 126);
            panel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(122, 45);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(175, 45);
            label4.TabIndex = 13;
            label4.Text = "Đăng xuất";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = SystemColors.HotTrack;
            btnDangxuat.FlatAppearance.BorderColor = Color.White;
            btnDangxuat.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangxuat.ForeColor = Color.White;
            btnDangxuat.Image = (Image)resources.GetObject("btnDangxuat.Image");
            btnDangxuat.Location = new Point(20, 24);
            btnDangxuat.Margin = new Padding(41, 5, 5, 5);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(86, 88);
            btnDangxuat.TabIndex = 12;
            btnDangxuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(406, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1706, 96);
            panel1.TabIndex = 3;
            // 
            // pnlMaincontent
            // 
            pnlMaincontent.Dock = DockStyle.Fill;
            pnlMaincontent.Location = new Point(406, 96);
            pnlMaincontent.Margin = new Padding(5);
            pnlMaincontent.Name = "pnlMaincontent";
            pnlMaincontent.Size = new Size(1706, 1667);
            pnlMaincontent.TabIndex = 4;
            pnlMaincontent.Paint += panel2_Paint_1;
            // 
            // frmmainthuthu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2112, 1763);
            Controls.Add(pnlMaincontent);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MinimumSize = new Size(2112, 1456);
            Name = "frmmainthuthu";
            Text = "frmmainthuthu";
            WindowState = FormWindowState.Maximized;
            Load += frmmainthuthu_Load;
            pnlDanhmuc.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pnlQuanlysach.ResumeLayout(false);
            pnlBaocao.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnThoat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel4;
        private Panel pnlDanhmuc;
        private Button btnTheloai;
        private Button btnTacgia;
        private Button btnDocgia;
        private Button btnDanhmuc;
        private Button btnDashboard;
        private Panel panel3;
        private Label lblmatt;
        private Label lblten;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDangxuat;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Panel pnlMaincontent;
        private Button btnKhosach;
        private Button btnQuanlysach;
        private Panel pnlQuanlysach;
        private Button btnMacabiet;
        private Button btnSach;
        private Button btnMuonsach;
        private Button btnTrasach;
        private Button btnBaocao;
        private Panel pnlBaocao;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}