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
            txtTentheloai = new TextBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTentheloai);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(46, 35);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(834, 559);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại";
            // 
            // txtTentheloai
            // 
            txtTentheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTentheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTentheloai.Location = new Point(236, 232);
            txtTentheloai.Margin = new Padding(5, 5, 5, 5);
            txtTentheloai.Name = "txtTentheloai";
            txtTentheloai.Size = new Size(528, 50);
            txtTentheloai.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 237);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 63;
            label2.Text = "Tên thể loại";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(724, 634);
            btnLuu.Margin = new Padding(5, 5, 5, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 61);
            btnLuu.TabIndex = 141;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(503, 634);
            btnHuy.Margin = new Padding(5, 5, 5, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(156, 61);
            btnHuy.TabIndex = 142;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmThemtheloai
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 734);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmThemtheloai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemtheloai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTentheloai;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}