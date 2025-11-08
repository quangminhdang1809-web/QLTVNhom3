namespace QLTVNhom3.UI
{
    partial class frmThemvipham
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
            groupBox3 = new GroupBox();
            txtTenloi = new TextBox();
            txtMota = new TextBox();
            txtMucphat = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cboLoaiViPham = new ComboBox();
            txtMaloi = new TextBox();
            label10 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenloi);
            groupBox3.Controls.Add(txtMota);
            groupBox3.Controls.Add(txtMucphat);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cboLoaiViPham);
            groupBox3.Controls.Add(txtMaloi);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.ForeColor = SystemColors.Desktop;
            groupBox3.Location = new Point(29, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(682, 420);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin lỗi vi phạm";
            // 
            // txtTenloi
            // 
            txtTenloi.BorderStyle = BorderStyle.FixedSingle;
            txtTenloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenloi.Location = new Point(234, 118);
            txtTenloi.Name = "txtTenloi";
            txtTenloi.Size = new Size(326, 34);
            txtTenloi.TabIndex = 106;
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(234, 290);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 80;
            // 
            // txtMucphat
            // 
            txtMucphat.BorderStyle = BorderStyle.FixedSingle;
            txtMucphat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMucphat.Location = new Point(234, 177);
            txtMucphat.Name = "txtMucphat";
            txtMucphat.Size = new Size(326, 34);
            txtMucphat.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(63, 292);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 78;
            label6.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(63, 234);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 76;
            label7.Text = "Loại vi phạm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(63, 179);
            label8.Name = "label8";
            label8.Size = new Size(98, 28);
            label8.TabIndex = 65;
            label8.Text = "Mức phạt";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(63, 124);
            label9.Name = "label9";
            label9.Size = new Size(72, 28);
            label9.TabIndex = 63;
            label9.Text = "Tên lỗi";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Location = new Point(234, 229);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(326, 36);
            cboLoaiViPham.TabIndex = 105;
            // 
            // txtMaloi
            // 
            txtMaloi.BorderStyle = BorderStyle.FixedSingle;
            txtMaloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaloi.Location = new Point(234, 69);
            txtMaloi.Name = "txtMaloi";
            txtMaloi.Size = new Size(326, 34);
            txtMaloi.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(63, 69);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 60;
            label10.Text = "Mã lỗi";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(475, 476);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 145;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(594, 476);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 144;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmThemvipham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 555);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox3);
            Name = "frmThemvipham";
            Text = "frmThemvipham";
            Load += frmThemvipham_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtTenloi;
        private TextBox txtMota;
        private TextBox txtMucphat;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cboLoaiViPham;
        private TextBox txtMaloi;
        private Label label10;
        private Button btnHuy;
        private Button btnLuu;
    }
}