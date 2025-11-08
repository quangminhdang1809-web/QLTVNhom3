namespace QLTVNhom3.UI
{
    partial class ucThuThu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThuThu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox1 = new GroupBox();
            dtpNgaysinh = new DateTimePicker();
            txtIDAccount = new TextBox();
            txtSdt = new TextBox();
            txtHoten = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnSua = new Button();
            txtEmail = new TextBox();
            btnUndo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            label2 = new Label();
            txtMathuthu = new TextBox();
            label1 = new Label();
            btnThemthuthu = new Button();
            grdThuthu = new DataGridView();
            colMaThuThu = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colIDAccount = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThuthu).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.93062F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.57341F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.49597F));
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnThemthuthu, 2, 0);
            tableLayoutPanel1.Controls.Add(grdThuthu, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel1.Controls.Add(groupBox3, 2, 5);
            tableLayoutPanel1.Location = new Point(243, 42);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.47514F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.51909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.51909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.80162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0091829F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.47842F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8659325F));
            tableLayoutPanel1.Size = new Size(1362, 1089);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(696, 31);
            btnTimkiem.Margin = new Padding(3, 4, 3, 4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(97, 94);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 61);
            txtTimkiem.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(687, 34);
            txtTimkiem.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMathuthu);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(799, 160);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.SetRowSpan(groupBox1, 4);
            groupBox1.Size = new Size(560, 649);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thủ thư";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(187, 255);
            dtpNgaysinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(326, 34);
            dtpNgaysinh.TabIndex = 84;
            // 
            // txtIDAccount
            // 
            txtIDAccount.BorderStyle = BorderStyle.FixedSingle;
            txtIDAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(187, 472);
            txtIDAccount.Margin = new Padding(3, 4, 3, 4);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(326, 34);
            txtIDAccount.TabIndex = 83;
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSdt.Location = new Point(187, 400);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(326, 34);
            txtSdt.TabIndex = 82;
            // 
            // txtHoten
            // 
            txtHoten.BorderStyle = BorderStyle.FixedSingle;
            txtHoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHoten.Location = new Point(187, 182);
            txtHoten.Margin = new Padding(3, 4, 3, 4);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(326, 34);
            txtHoten.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(48, 475);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 80;
            label6.Text = "IDAccount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 402);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 79;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(48, 258);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 78;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 185);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 77;
            label3.Text = "Họ tên";
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(49, 38);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(45, 50);
            btnSua.TabIndex = 76;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(187, 328);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 34);
            txtEmail.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(110, 38);
            btnUndo.Margin = new Padding(3, 4, 3, 4);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 50);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(229, 38);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(45, 50);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(174, 38);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 50);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 330);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 63;
            label2.Text = "Email";
            // 
            // txtMathuthu
            // 
            txtMathuthu.BorderStyle = BorderStyle.FixedSingle;
            txtMathuthu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMathuthu.Location = new Point(187, 110);
            txtMathuthu.Margin = new Padding(3, 4, 3, 4);
            txtMathuthu.Name = "txtMathuthu";
            txtMathuthu.Size = new Size(326, 34);
            txtMathuthu.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 112);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã thủ thư";
            // 
            // btnThemthuthu
            // 
            btnThemthuthu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemthuthu.FlatAppearance.BorderSize = 0;
            btnThemthuthu.FlatStyle = FlatStyle.Flat;
            btnThemthuthu.Image = (Image)resources.GetObject("btnThemthuthu.Image");
            btnThemthuthu.Location = new Point(1237, 4);
            btnThemthuthu.Margin = new Padding(3, 4, 3, 4);
            btnThemthuthu.Name = "btnThemthuthu";
            btnThemthuthu.Size = new Size(122, 108);
            btnThemthuthu.TabIndex = 29;
            btnThemthuthu.UseVisualStyleBackColor = true;
            btnThemthuthu.Click += btnThemthuthu_Click;
            // 
            // grdThuthu
            // 
            grdThuthu.AllowUserToAddRows = false;
            grdThuthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdThuthu.BackgroundColor = Color.Gainsboro;
            grdThuthu.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdThuthu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdThuthu.ColumnHeadersHeight = 50;
            grdThuthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdThuthu.Columns.AddRange(new DataGridViewColumn[] { colMaThuThu, colHoTen, colNgaySinh, colIDAccount });
            tableLayoutPanel1.SetColumnSpan(grdThuthu, 2);
            grdThuthu.Dock = DockStyle.Fill;
            grdThuthu.EnableHeadersVisualStyles = false;
            grdThuthu.Location = new Point(3, 160);
            grdThuthu.Margin = new Padding(3, 4, 3, 4);
            grdThuthu.Name = "grdThuthu";
            grdThuthu.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            grdThuthu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tableLayoutPanel1.SetRowSpan(grdThuthu, 5);
            grdThuthu.RowTemplate.Height = 40;
            grdThuthu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdThuthu.Size = new Size(790, 773);
            grdThuthu.TabIndex = 33;
            // 
            // colMaThuThu
            // 
            colMaThuThu.DataPropertyName = "MaThuThu";
            colMaThuThu.FillWeight = 80F;
            colMaThuThu.HeaderText = "Mã thủ thư";
            colMaThuThu.MinimumWidth = 6;
            colMaThuThu.Name = "colMaThuThu";
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            // 
            // colIDAccount
            // 
            colIDAccount.DataPropertyName = "IDAccount";
            colIDAccount.HeaderText = "IDAccount";
            colIDAccount.MinimumWidth = 6;
            colIDAccount.Name = "colIDAccount";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(513, 979);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(280, 106);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(83, 32);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(57, 50);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(154, 32);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 50);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(213, 32);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 58);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(24, 32);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(45, 50);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUndo);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(1059, 816);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 118);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            // 
            // ucThuThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucThuThu";
            Size = new Size(1849, 1172);
            Load += ucThuThu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdThuthu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMathuthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemthuthu;
        private System.Windows.Forms.DataGridView grdThuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtIDAccount;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private GroupBox groupBox3;
    }
}