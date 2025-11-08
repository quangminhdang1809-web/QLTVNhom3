namespace QLTVNhom3
{
    // Đảm bảo tên class khớp với file .cs: frmMaCaBiet
    partial class frmMaCaBiet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaCaBiet));
            tableLayoutPanel1 = new TableLayoutPanel();
            grdSach = new DataGridView();
            Madausach = new DataGridViewTextBoxColumn();
            Masach = new DataGridViewTextBoxColumn();
            Tendausach = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            btnTimkiem = new Button();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            txtTenSach = new TextBox();
            btnLuu = new Button();
            label3 = new Label();
            btnUndo = new Button();
            cboTrangThai = new ComboBox();
            btnXoa = new Button();
            txtMaDauSach = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtMaSach = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            btnDong = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.26404F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.31601F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.34442F));
            tableLayoutPanel1.Controls.Add(grdSach, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(btnDong, 2, 2);
            tableLayoutPanel1.Location = new Point(12, 15);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3266563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.67334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.Size = new Size(1211, 698);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.BackgroundColor = Color.Gainsboro;
            grdSach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdSach.ColumnHeadersHeight = 50;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdSach.Columns.AddRange(new DataGridViewColumn[] { Madausach, Masach, Tendausach, Trangthai });
            grdSach.Dock = DockStyle.Fill;
            grdSach.EnableHeadersVisualStyles = false;
            grdSach.Location = new Point(3, 72);
            grdSach.Margin = new Padding(3, 4, 3, 4);
            grdSach.Name = "grdSach";
            grdSach.RowHeadersVisible = false;
            grdSach.RowHeadersWidth = 51;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(542, 476);
            grdSach.TabIndex = 89;
            // 
            // Madausach
            // 
            Madausach.HeaderText = "Mã đầu sách";
            Madausach.MinimumWidth = 6;
            Madausach.Name = "Madausach";
            // 
            // Masach
            // 
            Masach.HeaderText = "Mã sách";
            Masach.MinimumWidth = 6;
            Masach.Name = "Masach";
            // 
            // Tendausach
            // 
            Tendausach.HeaderText = "Tên sách";
            Tendausach.MinimumWidth = 6;
            Tendausach.Name = "Tendausach";
            // 
            // Trangthai
            // 
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Location = new Point(551, 13);
            btnTimkiem.Margin = new Padding(3, 4, 3, 4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(80, 42);
            btnTimkiem.TabIndex = 27;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtMaDauSach);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(688, 72);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(520, 468);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(238, 393);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(64, 43);
            btnSua.TabIndex = 181;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.Right;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenSach.Location = new Point(205, 132);
            txtTenSach.Margin = new Padding(3, 4, 3, 4);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(298, 34);
            txtTenSach.TabIndex = 78;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(452, 393);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(45, 40);
            btnLuu.TabIndex = 180;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 135);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 77;
            label3.Text = "Tên sách";
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(322, 393);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 179;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Right;
            cboTrangThai.Font = new Font("Segoe UI", 12F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(205, 272);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(298, 36);
            cboTrangThai.TabIndex = 76;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(387, 393);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 178;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaDauSach
            // 
            txtMaDauSach.Anchor = AnchorStyles.Right;
            txtMaDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaDauSach.Location = new Point(205, 202);
            txtMaDauSach.Margin = new Padding(3, 4, 3, 4);
            txtMaDauSach.Name = "txtMaDauSach";
            txtMaDauSach.Size = new Size(298, 34);
            txtMaDauSach.TabIndex = 75;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 278);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 65;
            label4.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 205);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 63;
            label2.Text = "Mã đầu sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.Right;
            txtMaSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaSach.Location = new Point(205, 62);
            txtMaSach.Margin = new Padding(3, 4, 3, 4);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(298, 34);
            txtMaSach.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã sách";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(130, 591);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(287, 103);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(82, 28);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(53, 33);
            btnPrevious.TabIndex = 82;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(150, 28);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(41, 33);
            btnNext.TabIndex = 81;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(206, 28);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(41, 33);
            btnLast.TabIndex = 80;
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(26, 28);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(41, 33);
            btnFirst.TabIndex = 79;
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.BackColor = Color.FromArgb(220, 53, 69);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1112, 657);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(96, 38);
            btnDong.TabIndex = 144;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // frmMaCaBiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 726);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMaCaBiet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Mã Cá Biệt";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdSach;
        private System.Windows.Forms.GroupBox groupBox1;

        // SỬA/THÊM CÁC CONTROL
        private System.Windows.Forms.ComboBox cboTrangThai; // Sửa
        private System.Windows.Forms.TextBox txtMaDauSach; // Sửa
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach; // Sửa
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madausach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendausach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.TextBox txtTenSach; // Sửa
        private System.Windows.Forms.Label label3;
        private Button btnSua;
        private Button btnLuu;
        private Button btnUndo;
        private Button btnXoa;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private Button btnDong;
    }
}