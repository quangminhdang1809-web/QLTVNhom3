namespace QLTVNhom3.UI
{
    partial class ucQuanLyTaiKhoan
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyTaiKhoan));
            tableLayoutPanel1 = new TableLayoutPanel();
            grdTaikhoan = new DataGridView();
            colAccount = new DataGridViewTextBoxColumn();
            colHoten = new DataGridViewTextBoxColumn();
            colMatkhau = new DataGridViewTextBoxColumn();
            colTypeOfAccount = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtMatkhau = new TextBox();
            txtLoaitaikhoan = new TextBox();
            label3 = new Label();
            txtHovaten = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtIDAccount = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnResetmatkau = new Button();
            btnTimkiem = new Button();
            cboLoaiTaiKhoan = new ComboBox();
            txtTimkiem = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTaikhoan).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.9644F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0355988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 701F));
            tableLayoutPanel1.Controls.Add(grdTaikhoan, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox4, 3, 3);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(cboLoaiTaiKhoan, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Location = new Point(78, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.54546F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(1591, 1028);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // grdTaikhoan
            // 
            grdTaikhoan.AllowUserToAddRows = false;
            grdTaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTaikhoan.BackgroundColor = Color.Gainsboro;
            grdTaikhoan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTaikhoan.ColumnHeadersHeight = 50;
            grdTaikhoan.Columns.AddRange(new DataGridViewColumn[] { colAccount, colHoten, colMatkhau, colTypeOfAccount });
            tableLayoutPanel1.SetColumnSpan(grdTaikhoan, 2);
            grdTaikhoan.Dock = DockStyle.Fill;
            grdTaikhoan.EnableHeadersVisualStyles = false;
            grdTaikhoan.Location = new Point(3, 120);
            grdTaikhoan.Name = "grdTaikhoan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdTaikhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdTaikhoan.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            grdTaikhoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tableLayoutPanel1.SetRowSpan(grdTaikhoan, 5);
            grdTaikhoan.RowTemplate.Height = 50;
            grdTaikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTaikhoan.Size = new Size(705, 806);
            grdTaikhoan.TabIndex = 93;
            grdTaikhoan.SelectionChanged += grdTaikhoan_SelectionChanged;
            // 
            // colAccount
            // 
            colAccount.DataPropertyName = "IDAccount";
            colAccount.FillWeight = 80F;
            colAccount.HeaderText = "IDAccount";
            colAccount.MinimumWidth = 6;
            colAccount.Name = "colAccount";
            // 
            // colHoten
            // 
            colHoten.DataPropertyName = "HoTen";
            colHoten.FillWeight = 150F;
            colHoten.HeaderText = "Họ và tên";
            colHoten.MinimumWidth = 6;
            colHoten.Name = "colHoten";
            // 
            // colMatkhau
            // 
            colMatkhau.DataPropertyName = "Password";
            colMatkhau.HeaderText = "Mật khẩu";
            colMatkhau.MinimumWidth = 6;
            colMatkhau.Name = "colMatkhau";
            // 
            // colTypeOfAccount
            // 
            colTypeOfAccount.DataPropertyName = "TypeOfAccount";
            colTypeOfAccount.HeaderText = "Loại tài khoản";
            colTypeOfAccount.MinimumWidth = 6;
            colTypeOfAccount.Name = "colTypeOfAccount";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(279, 940);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 85);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(83, 26);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(57, 40);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(154, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 40);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(213, 26);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 46);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(24, 26);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(45, 40);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatkhau);
            groupBox1.Controls.Add(txtLoaitaikhoan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHovaten);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(892, 120);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(696, 412);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtMatkhau
            // 
            txtMatkhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatkhau.Location = new Point(236, 179);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(326, 34);
            txtMatkhau.TabIndex = 78;
            // 
            // txtLoaitaikhoan
            // 
            txtLoaitaikhoan.BorderStyle = BorderStyle.FixedSingle;
            txtLoaitaikhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtLoaitaikhoan.Location = new Point(236, 234);
            txtLoaitaikhoan.Name = "txtLoaitaikhoan";
            txtLoaitaikhoan.Size = new Size(326, 34);
            txtLoaitaikhoan.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 234);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 76;
            label3.Text = "Loại tài khoản";
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHovaten.Location = new Point(236, 124);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(326, 34);
            txtHovaten.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 179);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 65;
            label4.Text = "Mật khẩu";
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
            // txtIDAccount
            // 
            txtIDAccount.BorderStyle = BorderStyle.FixedSingle;
            txtIDAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(236, 69);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(326, 34);
            txtIDAccount.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 60;
            label1.Text = "IDAccount";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnResetmatkau);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(1281, 538);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 112);
            groupBox4.TabIndex = 95;
            groupBox4.TabStop = false;
            // 
            // btnResetmatkau
            // 
            btnResetmatkau.BackColor = SystemColors.Highlight;
            btnResetmatkau.FlatAppearance.BorderSize = 0;
            btnResetmatkau.FlatStyle = FlatStyle.Flat;
            btnResetmatkau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetmatkau.ForeColor = Color.White;
            btnResetmatkau.Location = new Point(59, 35);
            btnResetmatkau.Name = "btnResetmatkau";
            btnResetmatkau.Size = new Size(204, 52);
            btnResetmatkau.TabIndex = 73;
            btnResetmatkau.Text = "Reset mật khẩu";
            btnResetmatkau.UseVisualStyleBackColor = false;
            btnResetmatkau.Click += btnResetMatKhau_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(714, 21);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(90, 74);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // cboLoaiTaiKhoan
            // 
            cboLoaiTaiKhoan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLoaiTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboLoaiTaiKhoan.FormattingEnabled = true;
            cboLoaiTaiKhoan.Location = new Point(565, 40);
            cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            cboLoaiTaiKhoan.Size = new Size(143, 36);
            cboLoaiTaiKhoan.TabIndex = 107;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 41);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(556, 34);
            txtTimkiem.TabIndex = 32;
            // 
            // ucQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucQuanLyTaiKhoan";
            Size = new Size(1963, 1155);
            Load += ucQuanLyTaiKhoan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTaikhoan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView grdTaikhoan;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DateTimePicker dtpNamsinhtacgia;
        private GroupBox groupBox4;
        private Button btnResetmatkau;
        private GroupBox groupBox1;
        private TextBox txtMatkhau;
        private TextBox txtLoaitaikhoan;
        private Label label3;
        private TextBox txtHovaten;
        private Label label4;
        private Label label2;
        private TextBox txtIDAccount;
        private Label label1;
        private ComboBox cboLoaiTaiKhoan;
        private DataGridViewTextBoxColumn colAccount;
        private DataGridViewTextBoxColumn colHoten;
        private DataGridViewTextBoxColumn colMatkhau;
        private DataGridViewTextBoxColumn colTypeOfAccount;
    }
}
