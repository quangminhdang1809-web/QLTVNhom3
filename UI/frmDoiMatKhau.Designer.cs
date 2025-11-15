namespace QLTVNhom3
{
    partial class frmDoiMatKhau
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
            lblMatkhauhientai = new Label();
            lblMatkhaumoi = new Label();
            lblXacnhanlaimatkhaumoi = new Label();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            llbLuuy = new Label();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblMatkhauhientai
            // 
            lblMatkhauhientai.AutoSize = true;
            lblMatkhauhientai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMatkhauhientai.Location = new Point(195, 82);
            lblMatkhauhientai.Margin = new Padding(4, 0, 4, 0);
            lblMatkhauhientai.Name = "lblMatkhauhientai";
            lblMatkhauhientai.Size = new Size(282, 45);
            lblMatkhauhientai.TabIndex = 0;
            lblMatkhauhientai.Text = "Mật khẩu hiện tại";
            // 
            // lblMatkhaumoi
            // 
            lblMatkhaumoi.AutoSize = true;
            lblMatkhaumoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMatkhaumoi.Location = new Point(195, 168);
            lblMatkhaumoi.Margin = new Padding(4, 0, 4, 0);
            lblMatkhaumoi.Name = "lblMatkhaumoi";
            lblMatkhaumoi.Size = new Size(229, 45);
            lblMatkhaumoi.TabIndex = 1;
            lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblXacnhanlaimatkhaumoi
            // 
            lblXacnhanlaimatkhaumoi.AutoSize = true;
            lblXacnhanlaimatkhaumoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblXacnhanlaimatkhaumoi.Location = new Point(195, 264);
            lblXacnhanlaimatkhaumoi.Margin = new Padding(4, 0, 4, 0);
            lblXacnhanlaimatkhaumoi.Name = "lblXacnhanlaimatkhaumoi";
            lblXacnhanlaimatkhaumoi.Size = new Size(416, 45);
            lblXacnhanlaimatkhaumoi.TabIndex = 2;
            lblXacnhanlaimatkhaumoi.Text = "Xác nhận lại mật khẩu mới";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Font = new Font("Segoe UI", 12F);
            txtOldPassword.Location = new Point(650, 84);
            txtOldPassword.Margin = new Padding(4);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '•';
            txtOldPassword.Size = new Size(422, 50);
            txtOldPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(650, 174);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new Size(422, 50);
            txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(650, 270);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(422, 50);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(885, 549);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 55);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1086, 549);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 55);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // llbLuuy
            // 
            llbLuuy.AutoSize = true;
            llbLuuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbLuuy.ForeColor = Color.Red;
            llbLuuy.Location = new Point(88, 440);
            llbLuuy.Margin = new Padding(4, 0, 4, 0);
            llbLuuy.Name = "llbLuuy";
            llbLuuy.Size = new Size(1127, 45);
            llbLuuy.TabIndex = 8;
            llbLuuy.Text = "Lưu ý: Mật khẩu có độ dài dưới 20 kí tự, bao gồm chữ, chữ số và kí tự đặc biệt";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkShowPassword.ForeColor = SystemColors.HotTrack;
            chkShowPassword.Location = new Point(939, 365);
            chkShowPassword.Margin = new Padding(5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(259, 49);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1261, 645);
            Controls.Add(chkShowPassword);
            Controls.Add(llbLuuy);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblXacnhanlaimatkhaumoi);
            Controls.Add(lblMatkhaumoi);
            Controls.Add(lblMatkhauhientai);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatkhauhientai;
        private Label lblMatkhaumoi;
        private Label lblXacnhanlaimatkhaumoi;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label llbLuuy;
        private CheckBox chkShowPassword;
    }
}

