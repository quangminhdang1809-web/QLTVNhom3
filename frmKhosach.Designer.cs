namespace QLTVNhom3
{
    partial class frmThemkesach
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
            txtTenke = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtMake = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTenke);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(56, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 382);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin kệ sách";
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
            // txtTenke
            // 
            txtTenke.BorderStyle = BorderStyle.FixedSingle;
            txtTenke.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenke.Location = new Point(146, 185);
            txtTenke.Name = "txtTenke";
            txtTenke.Size = new Size(326, 34);
            txtTenke.TabIndex = 75;
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
            label2.Size = new Size(72, 28);
            label2.TabIndex = 63;
            label2.Text = "Tên kệ";
            // 
            // txtMake
            // 
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMake.Location = new Point(146, 108);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(326, 34);
            txtMake.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã kệ";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(397, 484);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 143;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(516, 484);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 142;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmThemkesach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(651, 571);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmThemkesach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemkesach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTenke;
        private Label label4;
        private Label label2;
        private TextBox txtMake;
        private Label label1;
        private Button btnHuy;
        private Button btnLuu;
    }
}