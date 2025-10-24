namespace QLTVNhom3
{
    partial class frmNhapchitiettrasach
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
            dtpLoaidocgia = new ComboBox();
            dtpNgaysinh = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            label2 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dtpLoaidocgia);
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(47, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 533);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin trả sách";
            // 
            // dtpLoaidocgia
            // 
            dtpLoaidocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpLoaidocgia.FormattingEnabled = true;
            dtpLoaidocgia.Location = new Point(262, 279);
            dtpLoaidocgia.Name = "dtpLoaidocgia";
            dtpLoaidocgia.Size = new Size(365, 36);
            dtpLoaidocgia.TabIndex = 157;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(262, 205);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(365, 34);
            dtpNgaysinh.TabIndex = 156;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(68, 63);
            label11.Name = "label11";
            label11.Size = new Size(86, 28);
            label11.TabIndex = 150;
            label11.Text = "Mã sách";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(67, 285);
            label9.Name = "label9";
            label9.Size = new Size(172, 28);
            label9.TabIndex = 148;
            label9.Text = "Trạng thái hạn trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(68, 211);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 142;
            label2.Text = "Ngày trả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(262, 131);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(365, 34);
            txtTendocgia.TabIndex = 141;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(262, 57);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(365, 34);
            txtMadocgia.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(68, 137);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 138;
            label1.Text = "Tên sách";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(262, 355);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 36);
            comboBox1.TabIndex = 158;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(71, 359);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 159;
            label5.Text = "Trạng thái sách";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(265, 431);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 34);
            textBox1.TabIndex = 161;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(71, 433);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 160;
            label3.Text = "Số tiền phạt";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(549, 612);
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
            btnLuu.Location = new Point(685, 612);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 141;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmNhapchitiettrasach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(822, 681);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmNhapchitiettrasach";
            Text = "frmNhapchitiettrasach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox dtpLoaidocgia;
        private DateTimePicker dtpNgaysinh;
        private Label label11;
        private Label label9;
        private Label label2;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private Label label1;
        private Button btnHuy;
        private Button btnLuu;
    }
}