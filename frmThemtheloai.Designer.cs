namespace QLTVNhom3
{
    partial class frmThemtheloai
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
            groupBox1 = new GroupBox();
            txtMota = new TextBox();
            txtTentheloai = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtMatheloai = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTentheloai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatheloai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(28, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 410);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại";
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(146, 262);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 76;
            // 
            // txtTentheloai
            // 
            txtTentheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTentheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTentheloai.Location = new Point(146, 185);
            txtTentheloai.Name = "txtTentheloai";
            txtTentheloai.Size = new Size(326, 34);
            txtTentheloai.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 268);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 65;
            label4.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 188);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 63;
            label2.Text = "Tên thể loại";
            // 
            // txtMatheloai
            // 
            txtMatheloai.BorderStyle = BorderStyle.FixedSingle;
            txtMatheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatheloai.Location = new Point(146, 108);
            txtMatheloai.Name = "txtMatheloai";
            txtMatheloai.Size = new Size(326, 34);
            txtMatheloai.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã thể loại";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(313, 496);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 142;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(449, 496);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 141;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmThemtheloai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 559);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmThemtheloai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemtheloai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTentheloai;
        private Label label4;
        private Label label2;
        private TextBox txtMatheloai;
        private Label label1;
        private Button btnHuy;
        private Button btnLuu;
    }
}