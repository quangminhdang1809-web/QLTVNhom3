namespace QLTVNhom3
{
    partial class ucTacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTacgia));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThemtacgia = new Button();
            grdTacgia = new DataGridView();
            colMatacgia = new DataGridViewTextBoxColumn();
            colTentacgia = new DataGridViewTextBoxColumn();
            colNamsinh = new DataGridViewTextBoxColumn();
            colQuoctich = new DataGridViewTextBoxColumn();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtQuoctich = new TextBox();
            label3 = new Label();
            txtHovaten = new TextBox();
            dtpNamsinhtacgia = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUndo = new Button();
            txtMatacgia = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.07143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.928572F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 893F));
            tableLayoutPanel1.Controls.Add(btnThemtacgia, 2, 0);
            tableLayoutPanel1.Controls.Add(grdTacgia, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(groupBox4, 2, 4);
            tableLayoutPanel1.Location = new Point(59, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.901453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.09855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(1958, 1309);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnThemtacgia
            // 
            btnThemtacgia.Dock = DockStyle.Right;
            btnThemtacgia.FlatAppearance.BorderSize = 0;
            btnThemtacgia.FlatStyle = FlatStyle.Flat;
            btnThemtacgia.Image = (Image)resources.GetObject("btnThemtacgia.Image");
            btnThemtacgia.Location = new Point(1861, 3);
            btnThemtacgia.Name = "btnThemtacgia";
            btnThemtacgia.Size = new Size(94, 111);
            btnThemtacgia.TabIndex = 104;
            btnThemtacgia.UseVisualStyleBackColor = true;
            btnThemtacgia.Click += btnThemtacgia_Click;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTacgia.BackgroundColor = Color.White;
            grdTacgia.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdTacgia.ColumnHeadersHeight = 50;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colTentacgia, colNamsinh, colQuoctich });
            grdTacgia.Dock = DockStyle.Fill;
            grdTacgia.EnableHeadersVisualStyles = false;
            grdTacgia.Location = new Point(3, 120);
            grdTacgia.Name = "grdTacgia";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grdTacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grdTacgia.RowHeadersVisible = false;
            grdTacgia.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            grdTacgia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            tableLayoutPanel1.SetRowSpan(grdTacgia, 5);
            grdTacgia.RowTemplate.Height = 50;
            grdTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTacgia.Size = new Size(963, 1087);
            grdTacgia.TabIndex = 93;
            grdTacgia.CellClick += grdTacgia_CellClick;
            // 
            // colMatacgia
            // 
            colMatacgia.DataPropertyName = "MaTacGia";
            colMatacgia.FillWeight = 80F;
            colMatacgia.HeaderText = "Mã tác giả";
            colMatacgia.MinimumWidth = 6;
            colMatacgia.Name = "colMatacgia";
            // 
            // colTentacgia
            // 
            colTentacgia.DataPropertyName = "TenTacGia";
            colTentacgia.FillWeight = 150F;
            colTentacgia.HeaderText = "Họ và tên";
            colTentacgia.MinimumWidth = 6;
            colTentacgia.Name = "colTentacgia";
            // 
            // colNamsinh
            // 
            colNamsinh.DataPropertyName = "NamSinh";
            colNamsinh.HeaderText = "Năm sinh";
            colNamsinh.MinimumWidth = 6;
            colNamsinh.Name = "colNamsinh";
            // 
            // colQuoctich
            // 
            colQuoctich.DataPropertyName = "QuocTich";
            colQuoctich.HeaderText = "Quốc tịch";
            colQuoctich.MinimumWidth = 6;
            colQuoctich.Name = "colQuoctich";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(972, 21);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(89, 74);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 33);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(963, 50);
            txtTimkiem.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(686, 1221);
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
            groupBox1.Controls.Add(txtQuoctich);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHovaten);
            groupBox1.Controls.Add(dtpNamsinhtacgia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1067, 120);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(888, 693);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtQuoctich
            // 
            txtQuoctich.BorderStyle = BorderStyle.FixedSingle;
            txtQuoctich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtQuoctich.Location = new Point(276, 461);
            txtQuoctich.Name = "txtQuoctich";
            txtQuoctich.Size = new Size(406, 50);
            txtQuoctich.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(71, 463);
            label3.Name = "label3";
            label3.Size = new Size(160, 45);
            label3.TabIndex = 76;
            label3.Text = "Quốc tịch";
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHovaten.Location = new Point(276, 233);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(406, 50);
            txtHovaten.TabIndex = 75;
            // 
            // dtpNamsinhtacgia
            // 
            dtpNamsinhtacgia.CustomFormat = "yyyy";
            dtpNamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpNamsinhtacgia.Location = new Point(276, 347);
            dtpNamsinhtacgia.Name = "dtpNamsinhtacgia";
            dtpNamsinhtacgia.ShowUpDown = true;
            dtpNamsinhtacgia.Size = new Size(118, 50);
            dtpNamsinhtacgia.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(72, 350);
            label4.Name = "label4";
            label4.Size = new Size(159, 45);
            label4.TabIndex = 65;
            label4.Text = "Năm sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(72, 237);
            label2.Name = "label2";
            label2.Size = new Size(161, 45);
            label2.TabIndex = 63;
            label2.Text = "Họ và tên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUndo);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(1589, 842);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(366, 132);
            groupBox4.TabIndex = 95;
            groupBox4.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(62, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(45, 40);
            btnSua.TabIndex = 77;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(249, 35);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(44, 40);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(187, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(44, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(125, 35);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(44, 40);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // txtMatacgia
            // 
            txtMatacgia.BorderStyle = BorderStyle.FixedSingle;
            txtMatacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatacgia.Location = new Point(276, 119);
            txtMatacgia.Name = "txtMatacgia";
            txtMatacgia.ReadOnly = true;
            txtMatacgia.Size = new Size(406, 50);
            txtMatacgia.TabIndex = 61;
            txtMatacgia.TextChanged += txtMatacgia_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(72, 124);
            label1.Name = "label1";
            label1.Size = new Size(173, 45);
            label1.TabIndex = 60;
            label1.Text = "Mã tác giả";
            // 
            // ucTacgia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTacgia";
            Size = new Size(2114, 1368);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridViewTextBoxColumn namsinh;
        private Button button7;
        private Button button6;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private GroupBox groupBox1;
        private TextBox txtHovaten;
        private DateTimePicker dtpNamsinhtacgia;
        private Label label4;
        private Label label2;
        private TextBox txtMatacgia;
        private Label label1;
        private DataGridView grdTacgia;
        private TextBox txtQuoctich;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUndo;
        private Button btnThemtacgia;
        private DataGridViewTextBoxColumn colMatacgia;
        private DataGridViewTextBoxColumn colTentacgia;
        private DataGridViewTextBoxColumn colNamsinh;
        private DataGridViewTextBoxColumn colQuoctich;
        private Button btnSua;
    }
}
