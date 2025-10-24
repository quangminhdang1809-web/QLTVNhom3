namespace QLTVNhom3
{
    partial class ucMacabiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMacabiet));
            tableLayoutPanel1 = new TableLayoutPanel();
            grdTheloai = new DataGridView();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtMota = new TextBox();
            txtTentheloai = new TextBox();
            btnUndo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label2 = new Label();
            txtMatheloai = new TextBox();
            label1 = new Label();
            Madausach = new DataGridViewTextBoxColumn();
            Masach = new DataGridViewTextBoxColumn();
            Tendausach = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.48216F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.173422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.34442F));
            tableLayoutPanel1.Controls.Add(grdTheloai, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Location = new Point(80, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3266563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.67334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.Size = new Size(1491, 889);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // grdTheloai
            // 
            grdTheloai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTheloai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTheloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTheloai.Columns.AddRange(new DataGridViewColumn[] { Madausach, Masach, Tendausach, Trangthai });
            grdTheloai.Location = new Point(3, 98);
            grdTheloai.Name = "grdTheloai";
            grdTheloai.RowHeadersWidth = 51;
            grdTheloai.Size = new Size(701, 671);
            grdTheloai.TabIndex = 89;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(710, 14);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(130, 67);
            btnTimkiem.TabIndex = 27;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 30);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(701, 34);
            txtTimkiem.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(424, 801);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 85);
            groupBox2.TabIndex = 33;
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
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTentheloai);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatheloai);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(846, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 489);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtMota
            // 
            txtMota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(169, 315);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(429, 34);
            txtMota.TabIndex = 76;
            // 
            // txtTentheloai
            // 
            txtTentheloai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTentheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTentheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTentheloai.Location = new Point(169, 238);
            txtTentheloai.Name = "txtTentheloai";
            txtTentheloai.Size = new Size(429, 34);
            txtTentheloai.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(458, 429);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(522, 429);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(45, 40);
            btnSua.TabIndex = 72;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(573, 429);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 320);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 65;
            label4.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 240);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 63;
            label2.Text = "Mã đầu sách";
            // 
            // txtMatheloai
            // 
            txtMatheloai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMatheloai.BorderStyle = BorderStyle.FixedSingle;
            txtMatheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatheloai.Location = new Point(169, 109);
            txtMatheloai.Name = "txtMatheloai";
            txtMatheloai.Size = new Size(429, 34);
            txtMatheloai.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã sách";
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(169, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 34);
            textBox1.TabIndex = 78;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 171);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 77;
            label3.Text = "Tên sách";
            // 
            // ucMacabiet
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMacabiet";
            Size = new Size(1650, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DataGridView grdTheloai;
        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTentheloai;
        private Button btnUndo;
        private Button btnSua;
        private Button btnXoa;
        private Label label4;
        private Label label2;
        private TextBox txtMatheloai;
        private Label label1;
        private DataGridViewTextBoxColumn Madausach;
        private DataGridViewTextBoxColumn Masach;
        private DataGridViewTextBoxColumn Tendausach;
        private DataGridViewTextBoxColumn Trangthai;
        private TextBox textBox1;
        private Label label3;
    }
}
