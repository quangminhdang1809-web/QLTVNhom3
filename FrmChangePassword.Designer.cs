using System;
using System.Drawing;
using System.Windows.Forms;
namespace QLTVNhom3
{
    public partial class FrmChangePassword : Form
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
            lblMatkhauhientai.Location = new Point(46, 37);
            lblMatkhauhientai.Margin = new Padding(2, 0, 2, 0);
            lblMatkhauhientai.Name = "lblMatkhauhientai";
            lblMatkhauhientai.Size = new Size(123, 20);
            lblMatkhauhientai.TabIndex = 0;
            lblMatkhauhientai.Text = "Mật khẩu hiện tại";
            // 
            // lblMatkhaumoi
            // 
            lblMatkhaumoi.AutoSize = true;
            lblMatkhaumoi.Location = new Point(46, 90);
            lblMatkhaumoi.Margin = new Padding(2, 0, 2, 0);
            lblMatkhaumoi.Name = "lblMatkhaumoi";
            lblMatkhaumoi.Size = new Size(100, 20);
            lblMatkhaumoi.TabIndex = 1;
            lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblXacnhanlaimatkhaumoi
            // 
            lblXacnhanlaimatkhaumoi.AutoSize = true;
            lblXacnhanlaimatkhaumoi.Location = new Point(46, 150);
            lblXacnhanlaimatkhaumoi.Margin = new Padding(2, 0, 2, 0);
            lblXacnhanlaimatkhaumoi.Name = "lblXacnhanlaimatkhaumoi";
            lblXacnhanlaimatkhaumoi.Size = new Size(184, 20);
            lblXacnhanlaimatkhaumoi.TabIndex = 2;
            lblXacnhanlaimatkhaumoi.Text = "Xác nhận lại mật khẩu mới";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(242, 32);
            txtOldPassword.Margin = new Padding(2, 2, 2, 2);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(194, 27);
            txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(242, 88);
            txtNewPassword.Margin = new Padding(2, 2, 2, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(194, 27);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(242, 148);
            txtConfirmPassword.Margin = new Padding(2, 2, 2, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(194, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(296, 239);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(420, 239);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // llbLuuy
            // 
            llbLuuy.AutoSize = true;
            llbLuuy.ForeColor = Color.Red;
            llbLuuy.Location = new Point(17, 201);
            llbLuuy.Margin = new Padding(2, 0, 2, 0);
            llbLuuy.Name = "llbLuuy";
            llbLuuy.Size = new Size(523, 20);
            llbLuuy.TabIndex = 8;
            llbLuuy.Text = "Lưu ý: Mật khẩu có độ dài dưới 20 kí tự, bao gồm chữ, chữ số và kí tự đặc biệt";
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 311);
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
            Margin = new Padding(2, 2, 2, 2);
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