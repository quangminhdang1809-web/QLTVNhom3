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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemsach));
            btnluu = new Button();
            pbthemanh = new PictureBox();
            btnthemanh = new Button();
            label1 = new Label();
            txttensach = new TextBox();
            txtnxb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpnamxb = new DateTimePicker();
            label5 = new Label();
            cbxtheloai = new ComboBox();
            txtsoluong = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txttacgia = new TextBox();
            dtpnamsinhtacgia = new DateTimePicker();
            namsinh = new DataGridViewTextBoxColumn();
            tentacgia = new DataGridViewTextBoxColumn();
            dgvtacgia = new DataGridView();
            btnthemtacgia = new Button();
            btnxoatacgia = new Button();
            btnHuy = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbthemanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).BeginInit();
            SuspendLayout();
            // 
            // btnluu
            // 
            btnluu.BackColor = SystemColors.Highlight;
            btnluu.FlatAppearance.BorderSize = 0;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnluu.ForeColor = Color.White;
            btnluu.Location = new Point(851, 615);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(96, 38);
            btnluu.TabIndex = 56;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = false;
            // 
            // pbthemanh
            // 
            pbthemanh.BackColor = SystemColors.AppWorkspace;
            pbthemanh.Location = new Point(66, 77);
            pbthemanh.Name = "pbthemanh";
            pbthemanh.Size = new Size(184, 206);
            pbthemanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbthemanh.TabIndex = 68;
            pbthemanh.TabStop = false;
            // 
            // btnthemanh
            // 
            btnthemanh.BackColor = SystemColors.Highlight;
            btnthemanh.FlatAppearance.BorderSize = 0;
            btnthemanh.FlatStyle = FlatStyle.Flat;
            btnthemanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnthemanh.ForeColor = SystemColors.ButtonHighlight;
            btnthemanh.Location = new Point(66, 273);
            btnthemanh.Name = "btnthemanh";
            btnthemanh.Size = new Size(184, 38);
            btnthemanh.TabIndex = 69;
            btnthemanh.Text = "Thêm ảnh";
            btnthemanh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(346, 75);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 50;
            label1.Text = "Tên sách";
            // 
            // txttensach
            // 
            txttensach.BorderStyle = BorderStyle.FixedSingle;
            txttensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttensach.Location = new Point(507, 77);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(390, 34);
            txttensach.TabIndex = 51;
            // 
            // txtnxb
            // 
            txtnxb.BorderStyle = BorderStyle.FixedSingle;
            txtnxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtnxb.Location = new Point(507, 170);
            txtnxb.Name = "txtnxb";
            txtnxb.Size = new Size(390, 34);
            txtnxb.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(346, 124);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 53;
            label2.Text = "Thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(346, 173);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 54;
            label3.Text = "NXB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(346, 222);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 55;
            label4.Text = "Năm xuất bản";
            // 
            // dtpnamxb
            // 
            dtpnamxb.CustomFormat = "yyyy";
            dtpnamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpnamxb.Format = DateTimePickerFormat.Custom;
            dtpnamxb.Location = new Point(507, 218);
            dtpnamxb.Name = "dtpnamxb";
            dtpnamxb.ShowUpDown = true;
            dtpnamxb.Size = new Size(118, 34);
            dtpnamxb.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(346, 271);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 58;
            label5.Text = "Tác giả";
            // 
            // cbxtheloai
            // 
            cbxtheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxtheloai.FormattingEnabled = true;
            cbxtheloai.Location = new Point(507, 125);
            cbxtheloai.Name = "cbxtheloai";
            cbxtheloai.Size = new Size(390, 36);
            cbxtheloai.TabIndex = 59;
            // 
            // txtsoluong
            // 
            txtsoluong.BorderStyle = BorderStyle.FixedSingle;
            txtsoluong.Font = new Font("Segoe UI", 10.8F);
            txtsoluong.Location = new Point(504, 508);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(393, 31);
            txtsoluong.TabIndex = 60;
            txtsoluong.TextChanged += txtsoluong_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(346, 508);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 61;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(346, 320);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 62;
            label7.Text = "Năm sinh";
            // 
            // txttacgia
            // 
            txttacgia.BorderStyle = BorderStyle.FixedSingle;
            txttacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttacgia.Location = new Point(507, 266);
            txttacgia.Name = "txttacgia";
            txttacgia.Size = new Size(390, 34);
            txttacgia.TabIndex = 63;
            // 
            // dtpnamsinhtacgia
            // 
            dtpnamsinhtacgia.CustomFormat = "yyyy";
            dtpnamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpnamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpnamsinhtacgia.Location = new Point(507, 314);
            dtpnamsinhtacgia.Name = "dtpnamsinhtacgia";
            dtpnamsinhtacgia.ShowUpDown = true;
            dtpnamsinhtacgia.Size = new Size(118, 34);
            dtpnamsinhtacgia.TabIndex = 64;
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
            // dgvtacgia
            // 
            dgvtacgia.AllowUserToAddRows = false;
            dgvtacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvtacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvtacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtacgia.Columns.AddRange(new DataGridViewColumn[] { tentacgia, namsinh });
            dgvtacgia.Location = new Point(507, 370);
            dgvtacgia.Name = "dgvtacgia";
            dgvtacgia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvtacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvtacgia.RowHeadersWidth = 51;
            dgvtacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvtacgia.Size = new Size(390, 112);
            dgvtacgia.TabIndex = 65;
            // 
            // btnthemtacgia
            // 
            btnthemtacgia.BackColor = Color.Transparent;
            btnthemtacgia.FlatAppearance.BorderSize = 0;
            btnthemtacgia.FlatStyle = FlatStyle.Flat;
            btnthemtacgia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnthemtacgia.ForeColor = SystemColors.ButtonHighlight;
            btnthemtacgia.Location = new Point(802, 329);
            btnthemtacgia.Name = "btnthemtacgia";
            btnthemtacgia.Size = new Size(43, 32);
            btnthemtacgia.TabIndex = 66;
            btnthemtacgia.UseVisualStyleBackColor = false;
            // 
            // btnxoatacgia
            // 
            btnxoatacgia.BackColor = Color.Transparent;
            btnxoatacgia.FlatAppearance.BorderSize = 0;
            btnxoatacgia.FlatStyle = FlatStyle.Flat;
            btnxoatacgia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnxoatacgia.ForeColor = SystemColors.ButtonHighlight;
            btnxoatacgia.Location = new Point(851, 327);
            btnxoatacgia.Name = "btnxoatacgia";
            btnxoatacgia.Size = new Size(46, 37);
            btnxoatacgia.TabIndex = 67;
            btnxoatacgia.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(777, 323);
            button1.Name = "button1";
            button1.Size = new Size(51, 29);
            button1.TabIndex = 142;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(846, 323);
            button2.Name = "button2";
            button2.Size = new Size(51, 29);
            button2.TabIndex = 143;
            button2.UseVisualStyleBackColor = false;
            // 
            // frmThemsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(967, 685);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnHuy);
            Controls.Add(btnthemanh);
            Controls.Add(pbthemanh);
            Controls.Add(btnxoatacgia);
            Controls.Add(btnthemtacgia);
            Controls.Add(dgvtacgia);
            Controls.Add(dtpnamsinhtacgia);
            Controls.Add(txttacgia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtsoluong);
            Controls.Add(cbxtheloai);
            Controls.Add(label5);
            Controls.Add(dtpnamxb);
            Controls.Add(btnluu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtnxb);
            Controls.Add(txttensach);
            Controls.Add(label1);
            Name = "frmThemsach";
            Text = "frmThemsach";
            ((System.ComponentModel.ISupportInitialize)pbthemanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnluu;
        private PictureBox pbthemanh;
        private Button btnthemanh;
        private Label label1;
        private TextBox txttensach;
        private TextBox txtnxb;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpnamxb;
        private Label label5;
        private ComboBox cbxtheloai;
        private TextBox txtsoluong;
        private Label label6;
        private Label label7;
        private TextBox txttacgia;
        private DateTimePicker dtpnamsinhtacgia;
        private DataGridViewTextBoxColumn namsinh;
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridView dgvtacgia;
        private Button btnthemtacgia;
        private Button btnxoatacgia;
        private Button btnHuy;
        private Button button1;
        private Button button2;
    }
}