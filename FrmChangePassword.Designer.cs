namespace QLTVNhom3
{
    partial class FrmChangePassword
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
            SuspendLayout();
            // 
            // lblMatkhauhientai
            // 
            lblMatkhauhientai.AutoSize = true;
            lblMatkhauhientai.Location = new Point(58, 46);
            lblMatkhauhientai.Name = "lblMatkhauhientai";
            lblMatkhauhientai.Size = new Size(148, 25);
            lblMatkhauhientai.TabIndex = 0;
            lblMatkhauhientai.Text = "Mật khẩu hiện tại";
            // 
            // lblMatkhaumoi
            // 
            lblMatkhaumoi.AutoSize = true;
            lblMatkhaumoi.Location = new Point(58, 113);
            lblMatkhaumoi.Name = "lblMatkhaumoi";
            lblMatkhaumoi.Size = new Size(122, 25);
            lblMatkhaumoi.TabIndex = 1;
            lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblXacnhanlaimatkhaumoi
            // 
            lblXacnhanlaimatkhaumoi.AutoSize = true;
            lblXacnhanlaimatkhaumoi.Location = new Point(58, 188);
            lblXacnhanlaimatkhaumoi.Name = "lblXacnhanlaimatkhaumoi";
            lblXacnhanlaimatkhaumoi.Size = new Size(221, 25);
            lblXacnhanlaimatkhaumoi.TabIndex = 2;
            lblXacnhanlaimatkhaumoi.Text = "Xác nhận lại mật khẩu mới";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(302, 40);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(242, 31);
            txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(302, 110);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(242, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(302, 185);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(242, 31);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(370, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(525, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // llbLuuy
            // 
            llbLuuy.AutoSize = true;
            llbLuuy.ForeColor = Color.Red;
            llbLuuy.Location = new Point(21, 251);
            llbLuuy.Name = "llbLuuy";
            llbLuuy.Size = new Size(635, 25);
            llbLuuy.TabIndex = 8;
            llbLuuy.Text = "Lưu ý: Mật khẩu có độ dài dưới 20 kí tự, bao gồm chữ, chữ số và kí tự đặc biệt";
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 366);
            Controls.Add(llbLuuy);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblXacnhanlaimatkhaumoi);
            Controls.Add(lblMatkhaumoi);
            Controls.Add(lblMatkhauhientai);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChangePassword";
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
    }
}