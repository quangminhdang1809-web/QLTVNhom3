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
            tableLayoutPanel1 = new TableLayoutPanel();
            grdTacgia = new DataGridView();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtHovaten = new TextBox();
            groupBox3 = new GroupBox();
            grdSach = new DataGridView();
            btnUndo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            dtpNamsinhtacgia = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            txtMatacgia = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.50707F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4929276F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 574F));
            tableLayoutPanel1.Controls.Add(grdTacgia, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(groupBox4, 2, 6);
            tableLayoutPanel1.Location = new Point(59, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.54546F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(1494, 941);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grdTacgia
            // 
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTacgia.Dock = DockStyle.Fill;
            grdTacgia.Location = new Point(3, 120);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(grdTacgia, 5);
            grdTacgia.Size = new Size(789, 719);
            grdTacgia.TabIndex = 93;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(798, 7);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(118, 103);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 41);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(789, 34);
            txtTimkiem.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(512, 853);
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHovaten);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(dtpNamsinhtacgia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(922, 120);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 5);
            groupBox1.Size = new Size(569, 719);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHovaten.Location = new Point(176, 118);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(326, 34);
            txtHovaten.TabIndex = 75;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grdSach);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(63, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(448, 371);
            groupBox3.TabIndex = 74;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sách của tác giả";
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Location = new Point(23, 51);
            grdSach.Name = "grdSach";
            grdSach.ReadOnly = true;
            grdSach.RowHeadersWidth = 51;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(390, 270);
            grdSach.TabIndex = 68;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(48, 34);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(44, 40);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(164, 34);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(44, 40);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(103, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(44, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtpNamsinhtacgia
            // 
            dtpNamsinhtacgia.CustomFormat = "yyyy";
            dtpNamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpNamsinhtacgia.Location = new Point(176, 176);
            dtpNamsinhtacgia.Name = "dtpNamsinhtacgia";
            dtpNamsinhtacgia.ShowUpDown = true;
            dtpNamsinhtacgia.Size = new Size(118, 34);
            dtpNamsinhtacgia.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 176);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 65;
            label4.Text = "Năm sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 118);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 63;
            label2.Text = "Họ và tên";
            // 
            // txtMatacgia
            // 
            txtMatacgia.BorderStyle = BorderStyle.FixedSingle;
            txtMatacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatacgia.Location = new Point(176, 69);
            txtMatacgia.Name = "txtMatacgia";
            txtMatacgia.Size = new Size(326, 34);
            txtMatacgia.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã tác giả";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUndo);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(1241, 845);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 93);
            groupBox4.TabIndex = 94;
            groupBox4.TabStop = false;
            // 
            // ucTacgia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTacgia";
            Size = new Size(1650, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
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
        private GroupBox groupBox3;
        private DataGridView grdSach;
        private Button btnUndo;
        private Button btnLuu;
        private Button btnXoa;
        private DateTimePicker dtpNamsinhtacgia;
        private Label label4;
        private Label label2;
        private TextBox txtMatacgia;
        private Label label1;
        private DataGridView grdTacgia;
        private GroupBox groupBox4;
    }
}
