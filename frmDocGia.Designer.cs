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
            btnLichsumuonsach = new Button();
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
            lblExit.Location = new Point(1301, 0);
            lblExit.Margin = new Padding(4, 0, 4, 0);
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
            panelMenu.Controls.Add(btnLichsumuonsach);
            panelMenu.Controls.Add(btnThongtincanhan);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(427, 1175);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDangxuat);
            panel2.Controls.Add(btnDangxuat);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1003);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 172);
            panel2.TabIndex = 6;
            // 
            // lblDangxuat
            // 
            lblDangxuat.AutoSize = true;
            lblDangxuat.FlatStyle = FlatStyle.Flat;
            lblDangxuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDangxuat.ForeColor = SystemColors.Control;
            lblDangxuat.Location = new Point(135, 84);
            lblDangxuat.Margin = new Padding(4, 0, 4, 0);
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
            btnDangxuat.Location = new Point(50, 75);
            btnDangxuat.Margin = new Padding(4);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(78, 85);
            btnDangxuat.TabIndex = 0;
            btnDangxuat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMSV);
            panel1.Controls.Add(lblTen);
            panel1.Location = new Point(32, 244);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 155);
            panel1.TabIndex = 5;
            // 
            // lblMSV
            // 
            lblMSV.AutoSize = true;
            lblMSV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMSV.ForeColor = SystemColors.Control;
            lblMSV.Location = new Point(54, 23);
            lblMSV.Margin = new Padding(4, 0, 4, 0);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(217, 45);
            lblMSV.TabIndex = 5;
            lblMSV.Text = "Mã Sinh Viên";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTen.ForeColor = SystemColors.Control;
            lblTen.Location = new Point(82, 90);
            lblTen.Margin = new Padding(4, 0, 4, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(135, 45);
            lblTen.TabIndex = 6;
            lblTen.Text = "Họ & Tên";
            // 
            // btnTimkiemsach
            // 
            btnTimkiemsach.FlatAppearance.BorderSize = 0;
            btnTimkiemsach.FlatStyle = FlatStyle.Flat;
            btnTimkiemsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimkiemsach.ForeColor = SystemColors.Control;
            btnTimkiemsach.Location = new Point(53, 749);
            btnTimkiemsach.Margin = new Padding(4);
            btnTimkiemsach.Name = "btnTimkiemsach";
            btnTimkiemsach.Size = new Size(316, 62);
            btnTimkiemsach.TabIndex = 3;
            btnTimkiemsach.Text = "Tìm kiếm sách";
            btnTimkiemsach.TextAlign = ContentAlignment.MiddleLeft;
            btnTimkiemsach.UseVisualStyleBackColor = true;
            btnTimkiemsach.Click += btnTimkiemsach_Click;
            // 
            // btnLichsumuonsach
            // 
            btnLichsumuonsach.FlatAppearance.BorderSize = 0;
            btnLichsumuonsach.FlatStyle = FlatStyle.Flat;
            btnLichsumuonsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLichsumuonsach.ForeColor = SystemColors.Control;
            btnLichsumuonsach.Location = new Point(53, 606);
            btnLichsumuonsach.Margin = new Padding(4);
            btnLichsumuonsach.Name = "btnLichsumuonsach";
            btnLichsumuonsach.Size = new Size(316, 69);
            btnLichsumuonsach.TabIndex = 2;
            btnLichsumuonsach.Text = "Lịch sử mượn sách";
            btnLichsumuonsach.TextAlign = ContentAlignment.MiddleLeft;
            btnLichsumuonsach.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLichsumuonsach.UseVisualStyleBackColor = true;
            btnLichsumuonsach.Click += btnLichsumuonsach_Click;
            // 
            // btnThongtincanhan
            // 
            btnThongtincanhan.FlatAppearance.BorderSize = 0;
            btnThongtincanhan.FlatStyle = FlatStyle.Flat;
            btnThongtincanhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongtincanhan.ForeColor = SystemColors.Control;
            btnThongtincanhan.Location = new Point(53, 473);
            btnThongtincanhan.Margin = new Padding(4);
            btnThongtincanhan.Name = "btnThongtincanhan";
            btnThongtincanhan.Size = new Size(316, 63);
            btnThongtincanhan.TabIndex = 1;
            btnThongtincanhan.Text = "Thông tin cá nhân";
            btnThongtincanhan.TextAlign = ContentAlignment.MiddleLeft;
            btnThongtincanhan.UseVisualStyleBackColor = true;
            btnThongtincanhan.Click += btnThongtincanhan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 37);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 199);
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
            panelLogo.Location = new Point(427, 0);
            panelLogo.Margin = new Padding(4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1361, 96);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(34, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 50);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(427, 96);
            pnlMain.Margin = new Padding(4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1361, 1079);
            pnlMain.TabIndex = 2;
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 1175);
            Controls.Add(pnlMain);
            Controls.Add(panelLogo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmDocGia";
            Text = "Độc giả";
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Label lblExit;
        private Label label1;
        private Label lblTen;
        private Label lblMSV;
        private Button btnTimkiemsach;
        private Button btnLichsumuonsach;
        private Button btnThongtincanhan;
        private Panel pnlMain;
        private Panel panel1;
        private Panel panel2;
        private Button btnDangxuat;
        private Label lblDangxuat;
    }
}