﻿namespace QLTVNhom3
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtTacgia = new TextBox();
            grdTacgia = new DataGridView();
            colMatacgia = new DataGridViewTextBoxColumn();
            colHotentacgia = new DataGridViewTextBoxColumn();
            colVaitro = new DataGridViewTextBoxColumn();
            btnHuy = new Button();
            btnThemtg = new Button();
            btnXoatg = new Button();
            label8 = new Label();
            txtMadausach = new TextBox();
            groupBox1 = new GroupBox();
            grdSach = new DataGridView();
            colMasach = new DataGridViewTextBoxColumn();
            colTensach = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            grdGoiytacgia = new DataGridView();
            colMatacgiatimkiem = new DataGridViewTextBoxColumn();
            colTentacgiatimkiem = new DataGridViewTextBoxColumn();
            txtVaitro = new TextBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbThemanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdGoiytacgia).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(927, 749);
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
            label1.Location = new Point(353, 77);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 50;
            label1.Text = "Tên sách";
            // 
            // txtTensach
            // 
            txtTensach.BorderStyle = BorderStyle.FixedSingle;
            txtTensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTensach.Location = new Point(514, 79);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(390, 34);
            txtTensach.TabIndex = 51;
            // 
            // txtNxb
            // 
            txtNxb.BorderStyle = BorderStyle.FixedSingle;
            txtNxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNxb.Location = new Point(514, 172);
            txtNxb.Name = "txtNxb";
            txtNxb.Size = new Size(390, 34);
            txtNxb.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(353, 126);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 53;
            label2.Text = "Thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(353, 175);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 54;
            label3.Text = "NXB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(353, 224);
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
            dtpNamxb.Location = new Point(514, 220);
            dtpNamxb.Name = "dtpNamxb";
            dtpNamxb.ShowUpDown = true;
            dtpNamxb.Size = new Size(118, 34);
            dtpNamxb.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(358, 274);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 58;
            label5.Text = "Mã tác giả";
            // 
            // txtTheloai
            // 
            txtTheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTheloai.FormattingEnabled = true;
            txtTheloai.Location = new Point(514, 127);
            txtTheloai.Name = "txtTheloai";
            txtTheloai.Size = new Size(390, 36);
            txtTheloai.TabIndex = 59;
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Font = new Font("Segoe UI", 10.8F);
            txtSoluong.Location = new Point(516, 520);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(389, 31);
            txtSoluong.TabIndex = 60;
            txtSoluong.TextChanged += txtsoluong_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(358, 520);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 61;
            label6.Text = "Số lượng";
            // 
            // txtTacgia
            // 
            txtTacgia.BorderStyle = BorderStyle.FixedSingle;
            txtTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTacgia.Location = new Point(514, 268);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(390, 34);
            txtTacgia.TabIndex = 63;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colHotentacgia, colVaitro });
            grdTacgia.Location = new Point(515, 402);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdTacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTacgia.Size = new Size(390, 112);
            grdTacgia.TabIndex = 65;
            // 
            // colMatacgia
            // 
            colMatacgia.HeaderText = "Tác giả";
            colMatacgia.MinimumWidth = 6;
            colMatacgia.Name = "colMatacgia";
            colMatacgia.ReadOnly = true;
            // 
            // colHotentacgia
            // 
            colHotentacgia.HeaderText = "Họ và tên";
            colHotentacgia.MinimumWidth = 6;
            colHotentacgia.Name = "colHotentacgia";
            colHotentacgia.ReadOnly = true;
            // 
            // colVaitro
            // 
            colVaitro.HeaderText = "Vai trò";
            colVaitro.MinimumWidth = 6;
            colVaitro.Name = "colVaitro";
            colVaitro.ReadOnly = true;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(808, 749);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 38);
            btnHuy.TabIndex = 141;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThemtg
            // 
            btnThemtg.BackColor = Color.Transparent;
            btnThemtg.FlatAppearance.BorderSize = 0;
            btnThemtg.FlatStyle = FlatStyle.Flat;
            btnThemtg.Image = (Image)resources.GetObject("btnThemtg.Image");
            btnThemtg.Location = new Point(805, 367);
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
            btnXoatg.Location = new Point(858, 367);
            btnXoatg.Name = "btnXoatg";
            btnXoatg.Size = new Size(47, 29);
            btnXoatg.TabIndex = 143;
            btnXoatg.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(353, 33);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 144;
            label8.Text = "Mã đầu sách";
            // 
            // txtMadausach
            // 
            txtMadausach.BorderStyle = BorderStyle.FixedSingle;
            txtMadausach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadausach.Location = new Point(514, 27);
            txtMadausach.Name = "txtMadausach";
            txtMadausach.Size = new Size(390, 34);
            txtMadausach.TabIndex = 145;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdSach);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(22, 557);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1001, 189);
            groupBox1.TabIndex = 147;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bản sách ";
            // 
            // grdSach
            // 
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Columns.AddRange(new DataGridViewColumn[] { colMasach, colTensach, colTrangthai });
            grdSach.Location = new Point(6, 33);
            grdSach.Name = "grdSach";
            grdSach.ReadOnly = true;
            grdSach.RowHeadersWidth = 51;
            grdSach.RowTemplate.Height = 35;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(974, 133);
            grdSach.TabIndex = 147;
            grdSach.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMasach
            // 
            colMasach.FillWeight = 70F;
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            colMasach.ReadOnly = true;
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            colTensach.ReadOnly = true;
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            colTrangthai.ReadOnly = true;
            // 
            // grdGoiytacgia
            // 
            grdGoiytacgia.AllowUserToAddRows = false;
            grdGoiytacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdGoiytacgia.BackgroundColor = Color.White;
            grdGoiytacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGoiytacgia.ColumnHeadersVisible = false;
            grdGoiytacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgiatimkiem, colTentacgiatimkiem });
            grdGoiytacgia.Location = new Point(516, 308);
            grdGoiytacgia.Name = "grdGoiytacgia";
            grdGoiytacgia.RowHeadersWidth = 51;
            grdGoiytacgia.Size = new Size(390, 121);
            grdGoiytacgia.TabIndex = 148;
            grdGoiytacgia.Visible = false;
            // 
            // colMatacgiatimkiem
            // 
            colMatacgiatimkiem.HeaderText = "Mã TG";
            colMatacgiatimkiem.MinimumWidth = 6;
            colMatacgiatimkiem.Name = "colMatacgiatimkiem";
            // 
            // colTentacgiatimkiem
            // 
            colTentacgiatimkiem.HeaderText = "Tên tác giả";
            colTentacgiatimkiem.MinimumWidth = 6;
            colTentacgiatimkiem.Name = "colTentacgiatimkiem";
            // 
            // txtVaitro
            // 
            txtVaitro.BorderStyle = BorderStyle.FixedSingle;
            txtVaitro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtVaitro.Location = new Point(516, 318);
            txtVaitro.Name = "txtVaitro";
            txtVaitro.Size = new Size(390, 34);
            txtVaitro.TabIndex = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(360, 324);
            label7.Name = "label7";
            label7.Size = new Size(71, 28);
            label7.TabIndex = 149;
            label7.Text = "Vai trò";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(927, 519);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 151;
            button1.UseVisualStyleBackColor = false;
            // 
            // frmThemsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 799);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(grdGoiytacgia);
            Controls.Add(groupBox1);
            Controls.Add(txtMadausach);
            Controls.Add(label8);
            Controls.Add(btnXoatg);
            Controls.Add(btnThemtg);
            Controls.Add(btnHuy);
            Controls.Add(btnThemanh);
            Controls.Add(pbThemanh);
            Controls.Add(grdTacgia);
            Controls.Add(txtTacgia);
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
            Controls.Add(txtVaitro);
            Name = "frmThemsach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemsach";
            ((System.ComponentModel.ISupportInitialize)pbThemanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdGoiytacgia).EndInit();
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
        private TextBox txtTacgia;
        private DataGridView grdTacgia;
        private Button btnHuy;
        private Button btnThemtg;
        private Button btnXoatg;
        private Label label8;
        private TextBox txtMadausach;
        private GroupBox groupBox1;
        private DataGridView grdSach;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colTrangthai;
        private DataGridViewTextBoxColumn colMatacgia;
        private DataGridViewTextBoxColumn colHotentacgia;
        private DataGridView grdGoiytacgia;
        private DataGridViewTextBoxColumn colMatacgiatimkiem;
        private DataGridViewTextBoxColumn colTentacgiatimkiem;
        private DataGridViewTextBoxColumn colVaitro;
        private TextBox txtVaitro;
        private Label label7;
        private Button button1;
    }
}