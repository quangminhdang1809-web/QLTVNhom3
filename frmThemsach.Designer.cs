namespace QLTVNhom3
{
    partial class frmThemsach
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemsach));
            btnLuu = new Button();
            pbThemanh = new PictureBox();
            btnThemanh = new Button();
            label1 = new Label();
            txtTensach = new TextBox();
            txtNxb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNamxb = new DateTimePicker();
            label5 = new Label();
            txtTheloai = new ComboBox();
            txtSoluong = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTacgia = new TextBox();
            dtpNamsinhtacgia = new DateTimePicker();
            namsinh = new DataGridViewTextBoxColumn();
            tentacgia = new DataGridViewTextBoxColumn();
            dgvTacgia = new DataGridView();
            btnHuy = new Button();
            btnThemtg = new Button();
            btnXoatg = new Button();
            label8 = new Label();
            txtMadausach = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbThemanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTacgia).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(851, 615);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 38);
            btnLuu.TabIndex = 56;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // pbThemanh
            // 
            pbThemanh.BackColor = SystemColors.AppWorkspace;
            pbThemanh.Location = new Point(65, 65);
            pbThemanh.Name = "pbThemanh";
            pbThemanh.Size = new Size(184, 206);
            pbThemanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThemanh.TabIndex = 68;
            pbThemanh.TabStop = false;
            // 
            // btnThemanh
            // 
            btnThemanh.BackColor = SystemColors.Highlight;
            btnThemanh.FlatAppearance.BorderSize = 0;
            btnThemanh.FlatStyle = FlatStyle.Flat;
            btnThemanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThemanh.ForeColor = SystemColors.ButtonHighlight;
            btnThemanh.Location = new Point(65, 261);
            btnThemanh.Name = "btnThemanh";
            btnThemanh.Size = new Size(184, 38);
            btnThemanh.TabIndex = 69;
            btnThemanh.Text = "Thêm ảnh";
            btnThemanh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(346, 109);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 50;
            label1.Text = "Tên sách";
            // 
            // txtTensach
            // 
            txtTensach.BorderStyle = BorderStyle.FixedSingle;
            txtTensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTensach.Location = new Point(507, 111);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(390, 34);
            txtTensach.TabIndex = 51;
            // 
            // txtNxb
            // 
            txtNxb.BorderStyle = BorderStyle.FixedSingle;
            txtNxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNxb.Location = new Point(507, 204);
            txtNxb.Name = "txtNxb";
            txtNxb.Size = new Size(390, 34);
            txtNxb.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(346, 158);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 53;
            label2.Text = "Thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(346, 207);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 54;
            label3.Text = "NXB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(346, 256);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 55;
            label4.Text = "Năm xuất bản";
            // 
            // dtpNamxb
            // 
            dtpNamxb.CustomFormat = "yyyy";
            dtpNamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamxb.Format = DateTimePickerFormat.Custom;
            dtpNamxb.Location = new Point(507, 252);
            dtpNamxb.Name = "dtpNamxb";
            dtpNamxb.ShowUpDown = true;
            dtpNamxb.Size = new Size(118, 34);
            dtpNamxb.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(346, 305);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 58;
            label5.Text = "Tác giả";
            // 
            // txtTheloai
            // 
            txtTheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTheloai.FormattingEnabled = true;
            txtTheloai.Location = new Point(507, 159);
            txtTheloai.Name = "txtTheloai";
            txtTheloai.Size = new Size(390, 36);
            txtTheloai.TabIndex = 59;
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Font = new Font("Segoe UI", 10.8F);
            txtSoluong.Location = new Point(504, 542);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(393, 31);
            txtSoluong.TabIndex = 60;
            txtSoluong.TextChanged += txtsoluong_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(346, 542);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 61;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(346, 354);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 62;
            label7.Text = "Năm sinh";
            // 
            // txtTacgia
            // 
            txtTacgia.BorderStyle = BorderStyle.FixedSingle;
            txtTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTacgia.Location = new Point(507, 300);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(390, 34);
            txtTacgia.TabIndex = 63;
            // 
            // dtpNamsinhtacgia
            // 
            dtpNamsinhtacgia.CustomFormat = "yyyy";
            dtpNamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpNamsinhtacgia.Location = new Point(507, 348);
            dtpNamsinhtacgia.Name = "dtpNamsinhtacgia";
            dtpNamsinhtacgia.ShowUpDown = true;
            dtpNamsinhtacgia.Size = new Size(118, 34);
            dtpNamsinhtacgia.TabIndex = 64;
            // 
            // namsinh
            // 
            namsinh.HeaderText = "Năm sinh";
            namsinh.MinimumWidth = 6;
            namsinh.Name = "namsinh";
            namsinh.ReadOnly = true;
            // 
            // tentacgia
            // 
            tentacgia.HeaderText = "Tên tác giả";
            tentacgia.MinimumWidth = 6;
            tentacgia.Name = "tentacgia";
            tentacgia.ReadOnly = true;
            // 
            // dgvTacgia
            // 
            dgvTacgia.AllowUserToAddRows = false;
            dgvTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacgia.Columns.AddRange(new DataGridViewColumn[] { tentacgia, namsinh });
            dgvTacgia.Location = new Point(507, 404);
            dgvTacgia.Name = "dgvTacgia";
            dgvTacgia.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTacgia.RowHeadersWidth = 51;
            dgvTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTacgia.Size = new Size(390, 112);
            dgvTacgia.TabIndex = 65;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(732, 615);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 141;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThemtg
            // 
            btnThemtg.BackColor = Color.Transparent;
            btnThemtg.FlatAppearance.BorderSize = 0;
            btnThemtg.FlatStyle = FlatStyle.Flat;
            btnThemtg.Image = (Image)resources.GetObject("btnThemtg.Image");
            btnThemtg.Location = new Point(798, 353);
            btnThemtg.Name = "btnThemtg";
            btnThemtg.Size = new Size(47, 29);
            btnThemtg.TabIndex = 142;
            btnThemtg.UseVisualStyleBackColor = false;
            // 
            // btnXoatg
            // 
            btnXoatg.BackColor = Color.Transparent;
            btnXoatg.FlatAppearance.BorderSize = 0;
            btnXoatg.FlatStyle = FlatStyle.Flat;
            btnXoatg.Image = (Image)resources.GetObject("btnXoatg.Image");
            btnXoatg.Location = new Point(851, 353);
            btnXoatg.Name = "btnXoatg";
            btnXoatg.Size = new Size(47, 29);
            btnXoatg.TabIndex = 143;
            btnXoatg.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(346, 65);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 144;
            label8.Text = "Mã đầu sách";
            // 
            // txtMadausach
            // 
            txtMadausach.BorderStyle = BorderStyle.FixedSingle;
            txtMadausach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadausach.Location = new Point(507, 59);
            txtMadausach.Name = "txtMadausach";
            txtMadausach.Size = new Size(390, 34);
            txtMadausach.TabIndex = 145;
            // 
            // frmThemsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(967, 685);
            Controls.Add(txtMadausach);
            Controls.Add(label8);
            Controls.Add(btnXoatg);
            Controls.Add(btnThemtg);
            Controls.Add(btnHuy);
            Controls.Add(btnThemanh);
            Controls.Add(pbThemanh);
            Controls.Add(dgvTacgia);
            Controls.Add(dtpNamsinhtacgia);
            Controls.Add(txtTacgia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSoluong);
            Controls.Add(txtTheloai);
            Controls.Add(label5);
            Controls.Add(dtpNamxb);
            Controls.Add(btnLuu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNxb);
            Controls.Add(txtTensach);
            Controls.Add(label1);
            Name = "frmThemsach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemsach";
            ((System.ComponentModel.ISupportInitialize)pbThemanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTacgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private PictureBox pbThemanh;
        private Button btnThemanh;
        private Label label1;
        private TextBox txtTensach;
        private TextBox txtNxb;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNamxb;
        private Label label5;
        private ComboBox txtTheloai;
        private TextBox txtSoluong;
        private Label label6;
        private Label label7;
        private TextBox txtTacgia;
        private DateTimePicker dtpNamsinhtacgia;
        private DataGridViewTextBoxColumn namsinh;
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridView dgvTacgia;
        private Button btnHuy;
        private Button btnThemtg;
        private Button btnXoatg;
        private Label label8;
        private TextBox txtMadausach;
    }
}