namespace QLTVNhom3
{
    partial class frmThemvitri
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
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            txtKe = new TextBox();
            label5 = new Label();
            txtTang = new TextBox();
            label3 = new Label();
            txtMota = new TextBox();
            label1 = new Label();
            txtTenvitri = new TextBox();
            txtMavitri = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(397, 548);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 143;
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
            btnLuu.Location = new Point(516, 548);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 142;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenvitri);
            groupBox1.Controls.Add(txtMavitri);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(43, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 460);
            groupBox1.TabIndex = 144;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vị trí sách";
            // 
            // txtKe
            // 
            txtKe.BorderStyle = BorderStyle.FixedSingle;
            txtKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtKe.Location = new Point(170, 261);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(326, 34);
            txtKe.TabIndex = 154;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(46, 264);
            label5.Name = "label5";
            label5.Size = new Size(35, 28);
            label5.TabIndex = 153;
            label5.Text = "Kệ";
            // 
            // txtTang
            // 
            txtTang.BorderStyle = BorderStyle.FixedSingle;
            txtTang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTang.Location = new Point(170, 200);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(326, 34);
            txtTang.TabIndex = 152;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 202);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 151;
            label3.Text = "Tầng";
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(170, 322);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(46, 78);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 145;
            label1.Text = "Mã vị trí";
            // 
            // txtTenvitri
            // 
            txtTenvitri.BorderStyle = BorderStyle.FixedSingle;
            txtTenvitri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenvitri.Location = new Point(170, 139);
            txtTenvitri.Name = "txtTenvitri";
            txtTenvitri.Size = new Size(326, 34);
            txtTenvitri.TabIndex = 149;
            // 
            // txtMavitri
            // 
            txtMavitri.BorderStyle = BorderStyle.FixedSingle;
            txtMavitri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMavitri.Location = new Point(170, 78);
            txtMavitri.Name = "txtMavitri";
            txtMavitri.Size = new Size(326, 34);
            txtMavitri.TabIndex = 146;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(46, 326);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 148;
            label4.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 140);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 147;
            label2.Text = "Tên vị trí";
            // 
            // frmThemvitri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 632);
            Controls.Add(groupBox1);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Name = "frmThemvitri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemkesach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox groupBox1;
        private TextBox txtKe;
        private Label label5;
        private TextBox txtTang;
        private Label label3;
        private TextBox txtMota;
        private Label label1;
        private TextBox txtTenvitri;
        private TextBox txtMavitri;
        private Label label4;
        private Label label2;
    }
}