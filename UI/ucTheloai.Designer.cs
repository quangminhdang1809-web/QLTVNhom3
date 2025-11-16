namespace QLTVNhom3
{
    partial class ucTheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTheloai));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            txtTentheloai = new TextBox();
            btnUndo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            label2 = new Label();
            txtMatheloai = new TextBox();
            label1 = new Label();
            btnThemtheloai = new Button();
            grdTheloai = new DataGridView();
            MaTheLoai = new DataGridViewTextBoxColumn();
            colTentheloai = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.93062F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.57340956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.49597F));
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnThemtheloai, 2, 0);
            tableLayoutPanel1.Controls.Add(grdTheloai, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel1.Location = new Point(146, 69);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.72973F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.27027F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.Size = new Size(2213, 1394);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1132, 47);
            btnTimkiem.Margin = new Padding(5, 5, 5, 5);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(157, 125);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(5, 84);
            txtTimkiem.Margin = new Padding(5, 5, 5, 5);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1117, 50);
            txtTimkiem.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTentheloai);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatheloai);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1299, 224);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.SetRowSpan(groupBox1, 4);
            groupBox1.Size = new Size(909, 821);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại";
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(439, 677);
            btnSua.Margin = new Padding(5, 5, 5, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(73, 64);
            btnSua.TabIndex = 76;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtTentheloai
            // 
            txtTentheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTentheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTentheloai.Location = new Point(268, 378);
            txtTentheloai.Margin = new Padding(5, 5, 5, 5);
            txtTentheloai.Name = "txtTentheloai";
            txtTentheloai.Size = new Size(528, 50);
            txtTentheloai.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(538, 677);
            btnUndo.Margin = new Padding(5, 5, 5, 5);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(73, 64);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(731, 677);
            btnLuu.Margin = new Padding(5, 5, 5, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(73, 64);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(642, 677);
            btnXoa.Margin = new Padding(5, 5, 5, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 64);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(67, 382);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 63;
            label2.Text = "Tên thể loại";
            // 
            // txtMatheloai
            // 
            txtMatheloai.BorderStyle = BorderStyle.FixedSingle;
            txtMatheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatheloai.Location = new Point(268, 254);
            txtMatheloai.Margin = new Padding(5, 5, 5, 5);
            txtMatheloai.Name = "txtMatheloai";
            txtMatheloai.Size = new Size(528, 50);
            txtMatheloai.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(67, 254);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 45);
            label1.TabIndex = 60;
            label1.Text = "Mã thể loại";
            // 
            // btnThemtheloai
            // 
            btnThemtheloai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemtheloai.FlatAppearance.BorderSize = 0;
            btnThemtheloai.FlatStyle = FlatStyle.Flat;
            btnThemtheloai.Image = (Image)resources.GetObject("btnThemtheloai.Image");
            btnThemtheloai.Location = new Point(2029, 5);
            btnThemtheloai.Margin = new Padding(5, 5, 5, 5);
            btnThemtheloai.Name = "btnThemtheloai";
            btnThemtheloai.Size = new Size(179, 128);
            btnThemtheloai.TabIndex = 29;
            btnThemtheloai.UseVisualStyleBackColor = true;
            btnThemtheloai.Click += btnThemtheloai_Click;
            // 
            // grdTheloai
            // 
            grdTheloai.AllowUserToAddRows = false;
            grdTheloai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTheloai.BackgroundColor = Color.White;
            grdTheloai.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdTheloai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdTheloai.ColumnHeadersHeight = 50;
            grdTheloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdTheloai.Columns.AddRange(new DataGridViewColumn[] { MaTheLoai, colTentheloai });
            grdTheloai.Dock = DockStyle.Fill;
            grdTheloai.EnableHeadersVisualStyles = false;
            grdTheloai.Location = new Point(5, 224);
            grdTheloai.Margin = new Padding(5, 5, 5, 5);
            grdTheloai.Name = "grdTheloai";
            grdTheloai.RowHeadersVisible = false;
            grdTheloai.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            grdTheloai.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tableLayoutPanel1.SetRowSpan(grdTheloai, 5);
            grdTheloai.RowTemplate.Height = 40;
            grdTheloai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTheloai.Size = new Size(1117, 986);
            grdTheloai.TabIndex = 33;
            grdTheloai.CellClick += grdTheloai_CellClick;
            // 
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.FillWeight = 80F;
            MaTheLoai.HeaderText = "Mã thể loại";
            MaTheLoai.MinimumWidth = 6;
            MaTheLoai.Name = "MaTheLoai";
            // 
            // colTentheloai
            // 
            colTentheloai.DataPropertyName = "TenTheLoai";
            colTentheloai.HeaderText = "Tên thể loại";
            colTentheloai.MinimumWidth = 6;
            colTentheloai.Name = "colTentheloai";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(667, 1253);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(455, 136);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(135, 42);
            btnPrevious.Margin = new Padding(5, 5, 5, 5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(93, 64);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(250, 42);
            btnNext.Margin = new Padding(5, 5, 5, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(73, 64);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(346, 42);
            btnLast.Margin = new Padding(5, 5, 5, 5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(86, 74);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(39, 42);
            btnFirst.Margin = new Padding(5, 5, 5, 5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(73, 64);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // ucTheloai
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ucTheloai";
            Size = new Size(2681, 1600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtTentheloai;
        private Button btnUndo;
        private Button btnLuu;
        private Button btnXoa;
        private Label label2;
        private TextBox txtMatheloai;
        private Label label1;
        private Button btnThemtheloai;
        private TextBox txtTimkiem;
        private DataGridView grdTheloai;
        private Button btnTimkiem;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn colTentheloai;
        private Button btnSua;
    }
}
