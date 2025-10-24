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
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnEnd = new Button();
            btnFirst = new Button();
            cbxTheloaisach = new ComboBox();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            grdSach = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtMadausach = new TextBox();
            label5 = new Label();
            grdUndo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label6 = new Label();
            txtSoluong = new TextBox();
            grdTacgia = new DataGridView();
            tentacgia = new DataGridViewTextBoxColumn();
            namsinh = new DataGridViewTextBoxColumn();
            cbxTheloaisach1 = new ComboBox();
            dtpNamxb = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNxb = new TextBox();
            txtTensach = new TextBox();
            label1 = new Label();
            pbAnhbia = new PictureBox();
            btnThemsach = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.878788F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.121212F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1600, 1000);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(cbxTheloaisach);
            panel1.Controls.Add(btnTimkiem);
            panel1.Controls.Add(txtTimkiem);
            panel1.Controls.Add(grdSach);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 994);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnEnd);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Location = new Point(482, 894);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 100);
            groupBox3.TabIndex = 81;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(75, 26);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(57, 40);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(146, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 40);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            btnEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnd.FlatAppearance.BorderSize = 0;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Image = (Image)resources.GetObject("btnEnd.Image");
            btnEnd.Location = new Point(201, 23);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(53, 46);
            btnEnd.TabIndex = 76;
            btnEnd.UseVisualStyleBackColor = true;
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
            btnFirst.Click += btnFirst_Click_1;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(480, 55);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(151, 36);
            cbxTheloaisach.TabIndex = 79;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.AutoSize = true;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(662, 46);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(58, 58);
            btnTimkiem.TabIndex = 77;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(51, 56);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(396, 34);
            txtTimkiem.TabIndex = 76;
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdSach.ColumnHeadersHeight = 40;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdSach.Location = new Point(51, 131);
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
            grdSach.Size = new Size(700, 744);
            grdSach.TabIndex = 75;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnThemsach);
            panel2.Location = new Point(801, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 994);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtMadausach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(grdUndo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSoluong);
            groupBox1.Controls.Add(grdTacgia);
            groupBox1.Controls.Add(cbxTheloaisach1);
            groupBox1.Controls.Add(dtpNamxb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNxb);
            groupBox1.Controls.Add(txtTensach);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbAnhbia);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(83, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 800);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtMadausach
            // 
            txtMadausach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMadausach.BorderStyle = BorderStyle.FixedSingle;
            txtMadausach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadausach.Location = new Point(161, 314);
            txtMadausach.Name = "txtMadausach";
            txtMadausach.Size = new Size(326, 34);
            txtMadausach.TabIndex = 75;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 314);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 74;
            label5.Text = "Mã sách";
            // 
            // grdUndo
            // 
            grdUndo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdUndo.FlatAppearance.BorderSize = 0;
            grdUndo.FlatStyle = FlatStyle.Flat;
            grdUndo.Image = (Image)resources.GetObject("grdUndo.Image");
            grdUndo.Location = new Point(391, 733);
            grdUndo.Name = "grdUndo";
            grdUndo.Size = new Size(45, 40);
            grdUndo.TabIndex = 73;
            grdUndo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(519, 733);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(45, 40);
            btnSua.TabIndex = 72;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(455, 733);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(48, 566);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 70;
            label6.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            txtSoluong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSoluong.Location = new Point(161, 563);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(326, 34);
            txtSoluong.TabIndex = 69;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { tentacgia, namsinh });
            grdTacgia.Location = new Point(161, 615);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.ReadOnly = true;
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTacgia.Size = new Size(326, 90);
            grdTacgia.TabIndex = 68;
            // 
            // tentacgia
            // 
            tentacgia.HeaderText = "Tên tác giả";
            tentacgia.MinimumWidth = 6;
            tentacgia.Name = "tentacgia";
            tentacgia.ReadOnly = true;
            // 
            // namsinh
            // 
            namsinh.HeaderText = "Năm sinh";
            namsinh.MinimumWidth = 6;
            namsinh.Name = "namsinh";
            namsinh.ReadOnly = true;
            // 
            // cbxTheloaisach1
            // 
            cbxTheloaisach1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxTheloaisach1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach1.FormattingEnabled = true;
            cbxTheloaisach1.Location = new Point(161, 417);
            cbxTheloaisach1.Name = "cbxTheloaisach1";
            cbxTheloaisach1.Size = new Size(326, 36);
            cbxTheloaisach1.TabIndex = 67;
            // 
            // dtpNamxb
            // 
            dtpNamxb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNamxb.CustomFormat = "yyyy";
            dtpNamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamxb.Format = DateTimePickerFormat.Custom;
            dtpNamxb.Location = new Point(161, 510);
            dtpNamxb.Name = "dtpNamxb";
            dtpNamxb.ShowUpDown = true;
            dtpNamxb.Size = new Size(118, 34);
            dtpNamxb.TabIndex = 66;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(48, 515);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 65;
            label4.Text = "Năm XB";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 470);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 64;
            label3.Text = "NXB";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 417);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 63;
            label2.Text = "Thể loại";
            // 
            // txtNxb
            // 
            txtNxb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNxb.BorderStyle = BorderStyle.FixedSingle;
            txtNxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNxb.Location = new Point(161, 464);
            txtNxb.Name = "txtNxb";
            txtNxb.Size = new Size(326, 34);
            txtNxb.TabIndex = 62;
            // 
            // txtTensach
            // 
            txtTensach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTensach.BorderStyle = BorderStyle.FixedSingle;
            txtTensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTensach.Location = new Point(161, 368);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(326, 34);
            txtTensach.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 368);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 60;
            label1.Text = "Tên sách";
            // 
            // pbAnhbia
            // 
            pbAnhbia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbAnhbia.Location = new Point(195, 64);
            pbAnhbia.Name = "pbAnhbia";
            pbAnhbia.Size = new Size(225, 225);
            pbAnhbia.TabIndex = 1;
            pbAnhbia.TabStop = false;
            // 
            // btnThemsach
            // 
            btnThemsach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemsach.FlatAppearance.BorderSize = 0;
            btnThemsach.FlatStyle = FlatStyle.Flat;
            btnThemsach.Image = (Image)resources.GetObject("btnThemsach.Image");
            btnThemsach.Location = new Point(591, 46);
            btnThemsach.Name = "btnThemsach";
            btnThemsach.Size = new Size(56, 56);
            btnThemsach.TabIndex = 81;
            btnThemsach.UseVisualStyleBackColor = true;
            // 
            // ucSachthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucSachthuthu";
            Size = new Size(1600, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnEnd;
        private Button btnFirst;
        private ComboBox cbxTheloaisach;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private DataGridView grdSach;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtMadausach;
        private Label label5;
        private Button grdUndo;
        private Button btnSua;
        private Button btnXoa;
        private Label label6;
        private TextBox txtSoluong;
        private DataGridView grdTacgia;
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridViewTextBoxColumn namsinh;
        private ComboBox cbxTheloaisach1;
        private DateTimePicker dtpNamxb;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNxb;
        private TextBox txtTensach;
        private Label label1;
        private PictureBox pbAnhbia;
        private Button btnThemsach;
    }
}
