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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            panelMenu = new Panel();
            lblTen = new Label();
            lblMSV = new Label();
            button4 = new Button();
            btnTimkiemsach = new Button();
            btnLichsumuonsach = new Button();
            btnThongtincanhan = new Button();
            pictureBox1 = new PictureBox();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Controls.Add(lblTen);
            panelMenu.Controls.Add(lblMSV);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnTimkiemsach);
            panelMenu.Controls.Add(btnLichsumuonsach);
            panelMenu.Controls.Add(btnThongtincanhan);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(328, 918);
            panelMenu.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTen.ForeColor = SystemColors.Control;
            lblTen.Location = new Point(98, 221);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(77, 25);
            lblTen.TabIndex = 6;
            lblTen.Text = "Họ & Tên";
            // 
            // lblMSV
            // 
            lblMSV.AutoSize = true;
            lblMSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMSV.ForeColor = SystemColors.Control;
            lblMSV.Location = new Point(75, 170);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(124, 25);
            lblMSV.TabIndex = 5;
            lblMSV.Text = "Mã Sinh Viên";
            // 
            // button4
            // 
            button4.Location = new Point(88, 549);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnTimkiemsach
            // 
            btnTimkiemsach.Location = new Point(41, 471);
            btnTimkiemsach.Name = "btnTimkiemsach";
            btnTimkiemsach.Size = new Size(206, 34);
            btnTimkiemsach.TabIndex = 3;
            btnTimkiemsach.Text = "Tìm kiếm sách";
            btnTimkiemsach.UseVisualStyleBackColor = true;
            // 
            // btnLichsumuonsach
            // 
            btnLichsumuonsach.Location = new Point(41, 402);
            btnLichsumuonsach.Name = "btnLichsumuonsach";
            btnLichsumuonsach.Size = new Size(206, 34);
            btnLichsumuonsach.TabIndex = 2;
            btnLichsumuonsach.Text = "Lịch sử mượn sách";
            btnLichsumuonsach.UseVisualStyleBackColor = true;
            // 
            // btnThongtincanhan
            // 
            btnThongtincanhan.Location = new Point(41, 327);
            btnThongtincanhan.Name = "btnThongtincanhan";
            btnThongtincanhan.Size = new Size(206, 34);
            btnThongtincanhan.TabIndex = 1;
            btnThongtincanhan.Text = "Thông tin cá nhân";
            btnThongtincanhan.UseVisualStyleBackColor = true;
            btnThongtincanhan.Click += btnThongtincanhan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.HotTrack;
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(328, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1047, 75);
            panelLogo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(976, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(61, 29);
            label1.Name = "label1";
            label1.Size = new Size(313, 32);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý thư viện";
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(328, 75);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1047, 843);
            pnlMain.TabIndex = 2;
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 918);
            Controls.Add(pnlMain);
            Controls.Add(panelLogo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDocGia";
            Text = "Độc giả";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lblTen;
        private Label lblMSV;
        private Button button4;
        private Button btnTimkiemsach;
        private Button btnLichsumuonsach;
        private Button btnThongtincanhan;
        private Panel pnlMain;
    }
}