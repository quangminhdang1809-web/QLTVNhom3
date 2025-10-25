namespace QLTVNhom3
{
    partial class frmThemtacgia
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
            textBox1 = new TextBox();
            label3 = new Label();
            txtHovaten = new TextBox();
            dtpNamsinhtacgia = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            txtMatacgia = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHovaten);
            groupBox1.Controls.Add(dtpNamsinhtacgia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(63, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 399);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(176, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 34);
            textBox1.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 234);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 76;
            label3.Text = "Quốc tịch";
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHovaten.Location = new Point(176, 124);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(326, 34);
            txtHovaten.TabIndex = 75;
            // 
            // dtpNamsinhtacgia
            // 
            dtpNamsinhtacgia.CustomFormat = "yyyy";
            dtpNamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpNamsinhtacgia.Location = new Point(176, 179);
            dtpNamsinhtacgia.Name = "dtpNamsinhtacgia";
            dtpNamsinhtacgia.ShowUpDown = true;
            dtpNamsinhtacgia.Size = new Size(118, 34);
            dtpNamsinhtacgia.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 179);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 65;
            label4.Text = "Năm sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 124);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 63;
            label2.Text = "Họ và tên";
            // 
            // txtMatacgia
            // 
            txtMatacgia.BorderStyle = BorderStyle.FixedSingle;
            txtMatacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatacgia.Location = new Point(176, 69);
            txtMatacgia.Name = "txtMatacgia";
            txtMatacgia.Size = new Size(326, 34);
            txtMatacgia.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã tác giả";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(423, 507);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 144;
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
            btnLuu.Location = new Point(559, 507);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 143;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmThemtacgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 576);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmThemtacgia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemtacgia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtHovaten;
        private DateTimePicker dtpNamsinhtacgia;
        private Label label4;
        private Label label2;
        private TextBox txtMatacgia;
        private Label label1;
        private Button btnHuy;
        private Button btnLuu;
    }
}