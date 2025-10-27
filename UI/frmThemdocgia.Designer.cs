namespace QLTVNhom3
{
    partial class frmThemdocgia
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
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpLoaidocgia = new ComboBox();
            dtpNgaysinh = new DateTimePicker();
            dtpNgayhethan = new DateTimePicker();
            dtpNgaylapthe = new DateTimePicker();
            txtSdt = new TextBox();
            txtIDAccount = new TextBox();
            txtEmail = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTendocgia = new TextBox();
            txtDiachi = new TextBox();
            txtMadocgia = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dtpLoaidocgia);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(dtpNgayhethan);
            groupBox1.Controls.Add(dtpNgaylapthe);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin độc giả";
            // 
            // dtpLoaidocgia
            // 
            dtpLoaidocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpLoaidocgia.FormattingEnabled = true;
            dtpLoaidocgia.Location = new Point(564, 203);
            dtpLoaidocgia.Name = "dtpLoaidocgia";
            dtpLoaidocgia.Size = new Size(185, 36);
            dtpLoaidocgia.TabIndex = 137;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(160, 205);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(210, 34);
            dtpNgaysinh.TabIndex = 135;
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(564, 133);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 134;
            // 
            // dtpNgaylapthe
            // 
            dtpNgaylapthe.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaylapthe.CustomFormat = "";
            dtpNgaylapthe.Font = new Font("Segoe UI", 10.8F);
            dtpNgaylapthe.Format = DateTimePickerFormat.Short;
            dtpNgaylapthe.Location = new Point(564, 63);
            dtpNgaylapthe.Name = "dtpNgaylapthe";
            dtpNgaylapthe.Size = new Size(185, 31);
            dtpNgaylapthe.TabIndex = 133;
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSdt.Location = new Point(564, 345);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(185, 34);
            txtSdt.TabIndex = 132;
            // 
            // txtIDAccount
            // 
            txtIDAccount.BorderStyle = BorderStyle.FixedSingle;
            txtIDAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(564, 275);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(185, 34);
            txtIDAccount.TabIndex = 131;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(160, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 34);
            txtEmail.TabIndex = 130;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(43, 63);
            label11.Name = "label11";
            label11.Size = new Size(112, 28);
            label11.TabIndex = 129;
            label11.Text = "Mã độc giả";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(424, 275);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 128;
            label10.Text = "IDAccount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(424, 204);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 127;
            label9.Text = "Loại độc giả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(424, 133);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 126;
            label8.Text = "Ngày hết hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(424, 62);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 125;
            label7.Text = "Ngày lập thẻ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(424, 346);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 124;
            label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(43, 350);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 123;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(43, 278);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 122;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(43, 205);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 121;
            label2.Text = "Ngày sinh";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(160, 134);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(210, 34);
            txtTendocgia.TabIndex = 120;
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDiachi.Location = new Point(160, 276);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(210, 34);
            txtDiachi.TabIndex = 119;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(160, 63);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(210, 34);
            txtMadocgia.TabIndex = 118;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 133);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 117;
            label1.Text = "Tên độc giả";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(569, 505);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 140;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(705, 505);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 139;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmThemdocgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(822, 564);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmThemdocgia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemdocgia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox groupBox1;
        private ComboBox dtpLoaidocgia;
        private DateTimePicker dtpNgaysinh;
        private DateTimePicker dtpNgayhethan;
        private DateTimePicker dtpNgaylapthe;
        private TextBox txtSdt;
        private TextBox txtIDAccount;
        private TextBox txtEmail;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTendocgia;
        private TextBox txtDiachi;
        private TextBox txtMadocgia;
        private Label label1;
        private Button btnHuy;
        private Button btnLuu;
    }
}