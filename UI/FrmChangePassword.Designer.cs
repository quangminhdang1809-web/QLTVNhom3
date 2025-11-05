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
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            llbLuuy = new Label();
            SuspendLayout();
            // 
            // lblMatkhauhientai
            // 
            lblMatkhauhientai.AutoSize = true;
            lblMatkhauhientai.Location = new Point(75, 59);
            lblMatkhauhientai.Margin = new Padding(4, 0, 4, 0);
            lblMatkhauhientai.Name = "lblMatkhauhientai";
            lblMatkhauhientai.Size = new Size(202, 32);
            lblMatkhauhientai.TabIndex = 0;
            lblMatkhauhientai.Text = "Mật khẩu hiện tại";
            // 
            // lblMatkhaumoi
            // 
            lblMatkhaumoi.AutoSize = true;
            lblMatkhaumoi.Location = new Point(75, 145);
            lblMatkhaumoi.Margin = new Padding(4, 0, 4, 0);
            lblMatkhaumoi.Name = "lblMatkhaumoi";
            lblMatkhaumoi.Size = new Size(163, 32);
            lblMatkhaumoi.TabIndex = 1;
            lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblXacnhanlaimatkhaumoi
            // 
            lblXacnhanlaimatkhaumoi.AutoSize = true;
            lblXacnhanlaimatkhaumoi.Location = new Point(75, 241);
            lblXacnhanlaimatkhaumoi.Margin = new Padding(4, 0, 4, 0);
            lblXacnhanlaimatkhaumoi.Name = "lblXacnhanlaimatkhaumoi";
            lblXacnhanlaimatkhaumoi.Size = new Size(298, 32);
            lblXacnhanlaimatkhaumoi.TabIndex = 2;
            lblXacnhanlaimatkhaumoi.Text = "Xác nhận lại mật khẩu mới";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(393, 51);
            txtOldPassword.Margin = new Padding(4);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(313, 39);
            txtOldPassword.TabIndex = 3;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(393, 141);
            txtMatKhauMoi.Margin = new Padding(4);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(313, 39);
            txtMatKhauMoi.TabIndex = 4;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(393, 237);
            txtXacNhanMatKhau.Margin = new Padding(4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(313, 39);
            txtXacNhanMatKhau.TabIndex = 5;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(481, 383);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 55);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(682, 383);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 55);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // llbLuuy
            // 
            llbLuuy.AutoSize = true;
            llbLuuy.ForeColor = Color.Red;
            llbLuuy.Location = new Point(27, 321);
            llbLuuy.Margin = new Padding(4, 0, 4, 0);
            llbLuuy.Name = "llbLuuy";
            llbLuuy.Size = new Size(846, 32);
            llbLuuy.TabIndex = 8;
            llbLuuy.Text = "Lưu ý: Mật khẩu có độ dài dưới 20 kí tự, bao gồm chữ, chữ số và kí tự đặc biệt";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 484);
            Controls.Add(llbLuuy);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtOldPassword);
            Controls.Add(lblXacnhanlaimatkhaumoi);
            Controls.Add(lblMatkhaumoi);
            Controls.Add(lblMatkhauhientai);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatkhauhientai;
        private Label lblMatkhaumoi;
        private Label lblXacnhanlaimatkhaumoi;
        private TextBox txtOldPassword;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private Button btnSave;
        private Button btnCancel;
        private Label llbLuuy;
    }
}