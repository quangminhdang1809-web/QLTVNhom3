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
            btnDong = new Button();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7118034F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.416454F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8717422F));
            tableLayoutPanel1.Controls.Add(grdSach, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDong, 2, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Location = new Point(20, 47);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3266563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.67334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 232F));
            tableLayoutPanel1.Size = new Size(1957, 1094);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.BackgroundColor = Color.White;
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
            grdSach.Location = new Point(5, 112);
            grdSach.Margin = new Padding(5, 6, 5, 6);
            grdSach.Name = "grdSach";
            grdSach.RowHeadersVisible = false;
            grdSach.RowHeadersWidth = 51;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(1002, 743);
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
            btnTimkiem.Location = new Point(1017, 19);
            btnTimkiem.Margin = new Padding(5, 6, 5, 6);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(96, 67);
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
            groupBox1.Location = new Point(1123, 112);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(829, 743);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(387, 629);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 69);
            btnSua.TabIndex = 181;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.Right;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenSach.Location = new Point(317, 208);
            txtTenSach.Margin = new Padding(5, 6, 5, 6);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(483, 50);
            txtTenSach.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(734, 629);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(73, 64);
            btnLuu.TabIndex = 180;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 213);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 45);
            label3.TabIndex = 77;
            label3.Text = "Tên sách";
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(523, 629);
            btnUndo.Margin = new Padding(5);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(73, 64);
            btnUndo.TabIndex = 179;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Right;
            cboTrangThai.Font = new Font("Segoe UI", 12F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(317, 432);
            cboTrangThai.Margin = new Padding(5, 6, 5, 6);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(482, 53);
            cboTrangThai.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(629, 629);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 64);
            btnXoa.TabIndex = 178;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaDauSach
            // 
            txtMaDauSach.Anchor = AnchorStyles.Right;
            txtMaDauSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaDauSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaDauSach.Location = new Point(317, 320);
            txtMaDauSach.Margin = new Padding(5, 6, 5, 6);
            txtMaDauSach.Name = "txtMaDauSach";
            txtMaDauSach.Size = new Size(483, 50);
            txtMaDauSach.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(36, 442);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 45);
            label4.TabIndex = 65;
            label4.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 325);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 45);
            label2.TabIndex = 63;
            label2.Text = "Mã đầu sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.Right;
            txtMaSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaSach.Location = new Point(317, 96);
            txtMaSach.Margin = new Padding(5, 6, 5, 6);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(483, 50);
            txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 101);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 60;
            label1.Text = "Mã sách";
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.BackColor = Color.FromArgb(220, 53, 69);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1796, 1028);
            btnDong.Margin = new Padding(5);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(156, 61);
            btnDong.TabIndex = 144;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(541, 867);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(466, 165);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(133, 45);
            btnPrevious.Margin = new Padding(5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 53);
            btnPrevious.TabIndex = 82;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(244, 45);
            btnNext.Margin = new Padding(5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(67, 53);
            btnNext.TabIndex = 81;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(335, 45);
            btnLast.Margin = new Padding(5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(67, 53);
            btnLast.TabIndex = 80;
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(42, 45);
            btnFirst.Margin = new Padding(5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(67, 53);
            btnFirst.TabIndex = 79;
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // frmMaCaBiet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2049, 1162);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
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