namespace QLTVNhom3
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            panel1 = new Panel();
            chkHienmatkhau = new CheckBox();
            btnDangnhap = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtMatkhau = new TextBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            txtIDAccount = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(chkHienmatkhau);
            panel1.Controls.Add(btnDangnhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(449, 392);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 1049);
            panel1.TabIndex = 0;
            // 
            // chkHienmatkhau
            // 
            chkHienmatkhau.AutoSize = true;
            chkHienmatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkHienmatkhau.ForeColor = SystemColors.HotTrack;
            chkHienmatkhau.Location = new Point(692, 669);
            chkHienmatkhau.Margin = new Padding(5);
            chkHienmatkhau.Name = "chkHienmatkhau";
            chkHienmatkhau.Size = new Size(259, 49);
            chkHienmatkhau.TabIndex = 10;
            chkHienmatkhau.Text = "Hiện mật khẩu";
            chkHienmatkhau.UseVisualStyleBackColor = true;
            chkHienmatkhau.CheckedChanged += chkHienmatkhau_CheckedChanged;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.HotTrack;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangnhap.ForeColor = Color.White;
            btnDangnhap.Location = new Point(308, 802);
            btnDangnhap.Margin = new Padding(5);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(644, 86);
            btnDangnhap.TabIndex = 3;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(292, 163);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 60);
            label1.TabIndex = 8;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtMatkhau);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(292, 498);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(685, 134);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            txtMatkhau.BackColor = Color.White;
            txtMatkhau.BorderStyle = BorderStyle.None;
            txtMatkhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatkhau.Location = new Point(127, 53);
            txtMatkhau.Margin = new Padding(5);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '•';
            txtMatkhau.Size = new Size(496, 49);
            txtMatkhau.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 53);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(292, 317);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(685, 134);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên đăng nhập";
            // 
            // txtIDAccount
            // 
            txtIDAccount.BackColor = Color.White;
            txtIDAccount.BorderStyle = BorderStyle.None;
            txtIDAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(127, 64);
            txtIDAccount.Margin = new Padding(5);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(496, 49);
            txtIDAccount.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 53);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Right;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.Brown;
            btnThoat.Location = new Point(2035, 0);
            btnThoat.Margin = new Padding(5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 83);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(202, 246);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(567, 50);
            label2.TabIndex = 11;
            label2.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThoat);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2100, 83);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(585, 80);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(904, 313);
            panel3.TabIndex = 0;
            // 
            // frmDangnhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2100, 1531);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "frmDangnhap";
            Text = "frmDangnhap";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtIDAccount;
        private PictureBox pictureBox1;
        private Button btnThoat;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnDangnhap;
        private CheckBox chkHienmatkhau;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtMatkhau;
    }
}