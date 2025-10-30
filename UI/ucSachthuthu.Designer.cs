namespace QLTVNhom3
{
    partial class ucSachthuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSachthuthu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThemsach = new Button();
            btnTimkiem = new Button();
            cbxTheloaisach = new ComboBox();
            txtTimkiem = new TextBox();
            grdSach = new DataGridView();
            groupBox1 = new GroupBox();
            dtpNamxb = new DateTimePicker();
            drgTacgia = new DataGridView();
            colMatacgia = new DataGridViewTextBoxColumn();
            colHotentacgia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txTemail = new TextBox();
            txtMadocgia = new TextBox();
            txtDiachi = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnLuu = new Button();
            btnUndo = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            colMadausach = new DataGridViewTextBoxColumn();
            colAnhbia = new DataGridViewTextBoxColumn();
            colTendausach = new DataGridViewTextBoxColumn();
            colNamXB = new DataGridViewTextBoxColumn();
            colSoluong = new DataGridViewTextBoxColumn();
            colVaitro = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgTacgia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89301F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.10699F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 639F));
            tableLayoutPanel1.Controls.Add(btnThemsach, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(cbxTheloaisach, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(grdSach, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Location = new Point(115, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9669809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.03302F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.Size = new Size(1419, 913);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThemsach
            // 
            btnThemsach.Dock = DockStyle.Right;
            btnThemsach.FlatAppearance.BorderSize = 0;
            btnThemsach.FlatStyle = FlatStyle.Flat;
            btnThemsach.Image = (Image)resources.GetObject("btnThemsach.Image");
            btnThemsach.Location = new Point(1322, 3);
            btnThemsach.Name = "btnThemsach";
            btnThemsach.Size = new Size(94, 85);
            btnThemsach.TabIndex = 103;
            btnThemsach.UseVisualStyleBackColor = true;
            btnThemsach.Click += button1_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.None;
            btnTimkiem.AutoSize = true;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(712, 10);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(58, 70);
            btnTimkiem.TabIndex = 85;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(529, 27);
            cbxTheloaisach.Margin = new Padding(2);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(173, 36);
            cbxTheloaisach.TabIndex = 84;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 28);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(456, 34);
            txtTimkiem.TabIndex = 82;
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
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Columns.AddRange(new DataGridViewColumn[] { colMadausach, colAnhbia, colTendausach, colNamXB, colSoluong });
            tableLayoutPanel1.SetColumnSpan(grdSach, 2);
            grdSach.Dock = DockStyle.Fill;
            grdSach.EnableHeadersVisualStyles = false;
            grdSach.Location = new Point(2, 93);
            grdSach.Margin = new Padding(2);
            grdSach.Name = "grdSach";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdSach.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(700, 738);
            grdSach.TabIndex = 81;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNamxb);
            groupBox1.Controls.Add(drgTacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txTemail);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(782, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 736);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
           // 
            // dtpNamxb
            // 
            dtpNamxb.CustomFormat = "yyyy";
            dtpNamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamxb.Format = DateTimePickerFormat.Custom;
            dtpNamxb.Location = new Point(203, 368);
            dtpNamxb.Name = "dtpNamxb";
            dtpNamxb.ShowUpDown = true;
            dtpNamxb.Size = new Size(386, 34);
            dtpNamxb.TabIndex = 176;
            // 
            // drgTacgia
            // 
            drgTacgia.AllowUserToAddRows = false;
            drgTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            drgTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            drgTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colHotentacgia, colVaitro });
            drgTacgia.Location = new Point(203, 572);
            drgTacgia.Name = "drgTacgia";
            drgTacgia.RowHeadersWidth = 51;
            drgTacgia.Size = new Size(386, 142);
            drgTacgia.TabIndex = 175;
            // 
            // colMatacgia
            // 
            colMatacgia.HeaderText = "Mã tác giả";
            colMatacgia.MinimumWidth = 6;
            colMatacgia.Name = "colMatacgia";
            // 
            // colHotentacgia
            // 
            colHotentacgia.HeaderText = "Họ và tên";
            colHotentacgia.MinimumWidth = 6;
            colHotentacgia.Name = "colHotentacgia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(44, 527);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 174;
            label1.Text = "Số lượng";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(203, 527);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 34);
            textBox1.TabIndex = 173;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(44, 262);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 172;
            label5.Text = "Mã đầu sách";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(44, 474);
            label12.Name = "label12";
            label12.Size = new Size(55, 28);
            label12.TabIndex = 171;
            label12.Text = "Vị trí";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(44, 421);
            label13.Name = "label13";
            label13.Size = new Size(51, 28);
            label13.TabIndex = 170;
            label13.Text = "NXB";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(44, 368);
            label14.Name = "label14";
            label14.Size = new Size(85, 28);
            label14.TabIndex = 169;
            label14.Text = "Năm XB";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(44, 315);
            label15.Name = "label15";
            label15.Size = new Size(130, 28);
            label15.TabIndex = 168;
            label15.Text = "Tên đầu sách";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(203, 315);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(386, 34);
            txtTendocgia.TabIndex = 165;
            // 
            // txTemail
            // 
            txTemail.BorderStyle = BorderStyle.FixedSingle;
            txTemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txTemail.Location = new Point(203, 474);
            txTemail.Name = "txTemail";
            txTemail.Size = new Size(386, 34);
            txTemail.TabIndex = 166;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(203, 262);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(386, 34);
            txtMadocgia.TabIndex = 163;
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDiachi.Location = new Point(203, 421);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(386, 34);
            txtDiachi.TabIndex = 164;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(203, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 210);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnUndo);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(1167, 836);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 74);
            groupBox2.TabIndex = 105;
            groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(175, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(45, 40);
            btnLuu.TabIndex = 168;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(35, 26);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 167;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(105, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 166;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnLast);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(397, 836);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 74);
            groupBox3.TabIndex = 106;
            groupBox3.TabStop = false;
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
            btnFirst.Location = new Point(32, 26);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(45, 40);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // colMadausach
            // 
            colMadausach.HeaderText = "Mã đầu sách";
            colMadausach.MinimumWidth = 6;
            colMadausach.Name = "colMadausach";
            // 
            // colAnhbia
            // 
            colAnhbia.HeaderText = "Ảnh bìa";
            colAnhbia.MinimumWidth = 6;
            colAnhbia.Name = "colAnhbia";
            // 
            // colTendausach
            // 
            colTendausach.FillWeight = 160F;
            colTendausach.HeaderText = "Tên đầu sách";
            colTendausach.MinimumWidth = 6;
            colTendausach.Name = "colTendausach";
            // 
            // colNamXB
            // 
            colNamXB.HeaderText = "Năm XB";
            colNamXB.MinimumWidth = 6;
            colNamXB.Name = "colNamXB";
            // 
            // colSoluong
            // 
            colSoluong.HeaderText = "SL";
            colSoluong.MinimumWidth = 6;
            colSoluong.Name = "colSoluong";
            // 
            // colVaitro
            // 
            colVaitro.HeaderText = "Vai trò";
            colVaitro.MinimumWidth = 6;
            colVaitro.Name = "colVaitro";
            // 
            // ucSachthuthu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucSachthuthu";
            Size = new Size(1625, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drgTacgia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView grdSach;
        private TextBox txtTimkiem;
        private ComboBox cbxTheloaisach;
        private Button btnTimkiem;
        private Button btnThemsach;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private TextBox txtDiachi;
        private Label label1;
        private TextBox textBox1;
        private Label label12;
        private TextBox txTemail;
        private DataGridView drgTacgia;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnUndo;
        private Button btnXoa;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DateTimePicker dtpNamxb;
        private DataGridViewTextBoxColumn colMatacgia;
        private DataGridViewTextBoxColumn colHotentacgia;
        private DataGridViewTextBoxColumn colMadausach;
        private DataGridViewTextBoxColumn colAnhbia;
        private DataGridViewTextBoxColumn colTendausach;
        private DataGridViewTextBoxColumn colNamXB;
        private DataGridViewTextBoxColumn colSoluong;
        private DataGridViewTextBoxColumn colVaitro;
    }
}
