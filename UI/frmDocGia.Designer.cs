namespace QLTVNhom3
{
    partial class frmDocGia
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
            Label lblExit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            panelMenu = new Panel();
            panel2 = new Panel();
            lblDangxuat = new Label();
            btnDangxuat = new Button();
            panel1 = new Panel();
            lblMSV = new Label();
            lblTen = new Label();
            btnTimkiemsach = new Button();
            btnThongtincanhan = new Button();
            pictureBox1 = new PictureBox();
            panelLogo = new Panel();
            label1 = new Label();
            pnlMain = new Panel();
            lblExit = new Label();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Dock = DockStyle.Right;
            lblExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(1302, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(60, 72);
            lblExit.TabIndex = 1;
            lblExit.Text = "x";
            lblExit.Click += lblExit_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnTimkiemsach);
            panelMenu.Controls.Add(btnThongtincanhan);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(426, 1102);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDangxuat);
            panel2.Controls.Add(btnDangxuat);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 929);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 173);
            panel2.TabIndex = 6;
            // 
            // lblDangxuat
            // 
            lblDangxuat.AutoSize = true;
            lblDangxuat.FlatStyle = FlatStyle.Flat;
            lblDangxuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDangxuat.ForeColor = SystemColors.Control;
            lblDangxuat.Location = new Point(135, 83);
            lblDangxuat.Name = "lblDangxuat";
            lblDangxuat.Size = new Size(175, 45);
            lblDangxuat.TabIndex = 1;
            lblDangxuat.Text = "Đăng xuất";
            // 
            // btnDangxuat
            // 
            btnDangxuat.Cursor = Cursors.No;
            btnDangxuat.FlatAppearance.BorderColor = Color.White;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Image = (Image)resources.GetObject("btnDangxuat.Image");
            btnDangxuat.Location = new Point(49, 74);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(78, 86);
            btnDangxuat.TabIndex = 0;
            btnDangxuat.UseVisualStyleBackColor = true;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMSV);
            panel1.Controls.Add(lblTen);
            panel1.Location = new Point(0, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 155);
            panel1.TabIndex = 5;
            // 
            // lblMSV
            // 
            lblMSV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMSV.ForeColor = SystemColors.Control;
            lblMSV.Location = new Point(0, 16);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(432, 45);
            lblMSV.TabIndex = 5;
            lblMSV.Text = "Mã Sinh Viên";
            lblMSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTen.ForeColor = SystemColors.Control;
            lblTen.Location = new Point(0, 84);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(426, 45);
            lblTen.TabIndex = 6;
            lblTen.Text = "Họ & Tên";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTimkiemsach
            // 
            btnTimkiemsach.FlatAppearance.BorderSize = 0;
            btnTimkiemsach.FlatStyle = FlatStyle.Flat;
            btnTimkiemsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimkiemsach.ForeColor = Color.White;
            btnTimkiemsach.Image = (Image)resources.GetObject("btnTimkiemsach.Image");
            btnTimkiemsach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimkiemsach.Location = new Point(49, 590);
            btnTimkiemsach.Name = "btnTimkiemsach";
            btnTimkiemsach.Size = new Size(315, 93);
            btnTimkiemsach.TabIndex = 3;
            btnTimkiemsach.Text = "      Tìm kiếm sách";
            btnTimkiemsach.TextAlign = ContentAlignment.MiddleLeft;
            btnTimkiemsach.UseVisualStyleBackColor = true;
            btnTimkiemsach.Click += btnTimkiemsach_Click;
            // 
            // btnThongtincanhan
            // 
            btnThongtincanhan.FlatAppearance.BorderSize = 0;
            btnThongtincanhan.FlatStyle = FlatStyle.Flat;
            btnThongtincanhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongtincanhan.ForeColor = SystemColors.Control;
            btnThongtincanhan.Image = (Image)resources.GetObject("btnThongtincanhan.Image");
            btnThongtincanhan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongtincanhan.Location = new Point(49, 477);
            btnThongtincanhan.Name = "btnThongtincanhan";
            btnThongtincanhan.Size = new Size(315, 93);
            btnThongtincanhan.TabIndex = 1;
            btnThongtincanhan.Text = "      Hồ sơ độc giả";
            btnThongtincanhan.TextAlign = ContentAlignment.MiddleLeft;
            btnThongtincanhan.UseVisualStyleBackColor = true;
            btnThongtincanhan.Click += btnThongtincanhan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.HotTrack;
            panelLogo.Controls.Add(lblExit);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(426, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1362, 96);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(567, 50);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(426, 96);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1362, 1006);
            pnlMain.TabIndex = 2;
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 1102);
            Controls.Add(pnlMain);
            Controls.Add(panelLogo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDocGia";
            Text = "Độc giả";
            Load += frmDocGia_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTen;
        private Label lblMSV;
        private Button btnTimkiemsach;
        private Button btnThongtincanhan;
        private Panel pnlMain;
        private Panel panel1;
        private Panel panel2;
        private Button btnDangxuat;
        private Label lblDangxuat;
    }
}


