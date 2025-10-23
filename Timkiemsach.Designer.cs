namespace QLTVNhom3
{
    partial class Timkiemsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemsach));
            panel1 = new Panel();
            btnTimkiem = new Button();
            lblTimtheo = new Label();
            cbxLocsach = new ComboBox();
            txtTimsach = new TextBox();
            lblTimkiemsach = new Label();
            btnRefresh = new Button();
            pbAnhbiasach = new PictureBox();
            lblTensach = new Label();
            lblTheloai = new Label();
            lblNXB = new Label();
            lblTacgia = new Label();
            lblNamxb = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            lblSoluong = new Label();
            txtNamxb = new TextBox();
            txtTacgia = new TextBox();
            txtNXB = new TextBox();
            txtTheloai = new TextBox();
            txtTensach = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhbiasach).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimkiem);
            panel1.Controls.Add(lblTimtheo);
            panel1.Controls.Add(cbxLocsach);
            panel1.Controls.Add(txtTimsach);
            panel1.Controls.Add(lblTimkiemsach);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 300);
            panel1.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackgroundImage = (Image)resources.GetObject("btnTimkiem.BackgroundImage");
            btnTimkiem.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimkiem.Location = new Point(851, 175);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(45, 45);
            btnTimkiem.TabIndex = 4;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // lblTimtheo
            // 
            lblTimtheo.AutoSize = true;
            lblTimtheo.Font = new Font("Segoe UI", 12F);
            lblTimtheo.Location = new Point(649, 147);
            lblTimtheo.Name = "lblTimtheo";
            lblTimtheo.Size = new Size(110, 32);
            lblTimtheo.TabIndex = 3;
            lblTimtheo.Text = "Tìm theo";
            // 
            // cbxLocsach
            // 
            cbxLocsach.Font = new Font("Segoe UI", 12F);
            cbxLocsach.FormattingEnabled = true;
            cbxLocsach.Location = new Point(626, 180);
            cbxLocsach.Name = "cbxLocsach";
            cbxLocsach.Size = new Size(182, 40);
            cbxLocsach.TabIndex = 2;
            // 
            // txtTimsach
            // 
            txtTimsach.BorderStyle = BorderStyle.FixedSingle;
            txtTimsach.Font = new Font("Segoe UI", 12F);
            txtTimsach.Location = new Point(23, 182);
            txtTimsach.Name = "txtTimsach";
            txtTimsach.Size = new Size(490, 39);
            txtTimsach.TabIndex = 1;
            // 
            // lblTimkiemsach
            // 
            lblTimkiemsach.AutoSize = true;
            lblTimkiemsach.Font = new Font("Segoe UI", 12F);
            lblTimkiemsach.Location = new Point(23, 147);
            lblTimkiemsach.Name = "lblTimkiemsach";
            lblTimkiemsach.Size = new Size(167, 32);
            lblTimkiemsach.TabIndex = 0;
            lblTimkiemsach.Text = "Tìm kiếm sách";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(835, 442);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(156, 68);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pbAnhbiasach
            // 
            pbAnhbiasach.BackColor = SystemColors.ActiveBorder;
            pbAnhbiasach.BackgroundImageLayout = ImageLayout.Stretch;
            pbAnhbiasach.Location = new Point(715, 29);
            pbAnhbiasach.Name = "pbAnhbiasach";
            pbAnhbiasach.Size = new Size(193, 234);
            pbAnhbiasach.TabIndex = 6;
            pbAnhbiasach.TabStop = false;
            // 
            // lblTensach
            // 
            lblTensach.AutoSize = true;
            lblTensach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTensach.Location = new Point(54, 80);
            lblTensach.Name = "lblTensach";
            lblTensach.Size = new Size(111, 32);
            lblTensach.TabIndex = 7;
            lblTensach.Text = "Tên sách";
            // 
            // lblTheloai
            // 
            lblTheloai.AccessibleRole = AccessibleRole.None;
            lblTheloai.AutoSize = true;
            lblTheloai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTheloai.Location = new Point(54, 160);
            lblTheloai.Name = "lblTheloai";
            lblTheloai.Size = new Size(104, 32);
            lblTheloai.TabIndex = 8;
            lblTheloai.Text = "Thể loại";
            // 
            // lblNXB
            // 
            lblNXB.AutoSize = true;
            lblNXB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNXB.Location = new Point(54, 240);
            lblNXB.Name = "lblNXB";
            lblNXB.Size = new Size(167, 32);
            lblNXB.TabIndex = 9;
            lblNXB.Text = "Nhà xuất bản";
            // 
            // lblTacgia
            // 
            lblTacgia.AutoSize = true;
            lblTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTacgia.Location = new Point(54, 320);
            lblTacgia.Name = "lblTacgia";
            lblTacgia.Size = new Size(93, 32);
            lblTacgia.TabIndex = 10;
            lblTacgia.Text = "Tác giả";
            // 
            // lblNamxb
            // 
            lblNamxb.AutoSize = true;
            lblNamxb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNamxb.Location = new Point(54, 400);
            lblNamxb.Name = "lblNamxb";
            lblNamxb.Size = new Size(175, 32);
            lblNamxb.TabIndex = 15;
            lblNamxb.Text = "Năm xuất bản";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblSoluong);
            panel2.Controls.Add(txtNamxb);
            panel2.Controls.Add(lblNamxb);
            panel2.Controls.Add(txtTacgia);
            panel2.Controls.Add(txtNXB);
            panel2.Controls.Add(txtTheloai);
            panel2.Controls.Add(txtTensach);
            panel2.Controls.Add(lblTacgia);
            panel2.Controls.Add(lblNXB);
            panel2.Controls.Add(lblTheloai);
            panel2.Controls.Add(lblTensach);
            panel2.Controls.Add(pbAnhbiasach);
            panel2.Controls.Add(btnRefresh);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 547);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(841, 325);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 18;
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSoluong.Location = new Point(636, 327);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new Size(117, 32);
            lblSoluong.TabIndex = 17;
            lblSoluong.Text = "Số lượng";
            // 
            // txtNamxb
            // 
            txtNamxb.BorderStyle = BorderStyle.FixedSingle;
            txtNamxb.Font = new Font("Segoe UI", 12F);
            txtNamxb.Location = new Point(278, 397);
            txtNamxb.Name = "txtNamxb";
            txtNamxb.ReadOnly = true;
            txtNamxb.Size = new Size(150, 39);
            txtNamxb.TabIndex = 16;
            txtNamxb.TextChanged += textBox5_TextChanged;
            // 
            // txtTacgia
            // 
            txtTacgia.BorderStyle = BorderStyle.FixedSingle;
            txtTacgia.Font = new Font("Segoe UI", 12F);
            txtTacgia.Location = new Point(278, 327);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.ReadOnly = true;
            txtTacgia.Size = new Size(150, 39);
            txtTacgia.TabIndex = 14;
            // 
            // txtNXB
            // 
            txtNXB.BorderStyle = BorderStyle.FixedSingle;
            txtNXB.Font = new Font("Segoe UI", 12F);
            txtNXB.Location = new Point(278, 246);
            txtNXB.Name = "txtNXB";
            txtNXB.ReadOnly = true;
            txtNXB.Size = new Size(150, 39);
            txtNXB.TabIndex = 13;
            // 
            // txtTheloai
            // 
            txtTheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTheloai.Font = new Font("Segoe UI", 12F);
            txtTheloai.Location = new Point(278, 161);
            txtTheloai.Name = "txtTheloai";
            txtTheloai.ReadOnly = true;
            txtTheloai.Size = new Size(150, 39);
            txtTheloai.TabIndex = 12;
            // 
            // txtTensach
            // 
            txtTensach.BorderStyle = BorderStyle.FixedSingle;
            txtTensach.Font = new Font("Segoe UI", 12F);
            txtTensach.Location = new Point(278, 71);
            txtTensach.Name = "txtTensach";
            txtTensach.ReadOnly = true;
            txtTensach.Size = new Size(150, 39);
            txtTensach.TabIndex = 11;
            // 
            // Timkiemsach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Timkiemsach";
            Size = new Size(1043, 847);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhbiasach).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimkiem;
        private Label lblTimtheo;
        private ComboBox cbxLocsach;
        private TextBox txtTimsach;
        private Label lblTimkiemsach;
        private Button btnRefresh;
        private PictureBox pbAnhbiasach;
        private Label lblTensach;
        private Label lblTheloai;
        private Label lblNXB;
        private Label lblTacgia;
        private Label lblNamxb;
        private Panel panel2;
        private TextBox txtNamxb;
        private TextBox txtTacgia;
        private TextBox txtNXB;
        private TextBox txtTheloai;
        private TextBox txtTensach;
        private TextBox textBox1;
        private Label lblSoluong;
    }
}
