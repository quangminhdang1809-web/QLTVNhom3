namespace QLTVNhom3.UI
{
    partial class ucVipham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVipham));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbxLoaiViPham = new ComboBox();
            btnThemloi = new Button();
            btnTimkiem = new Button();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtTenloi = new TextBox();
            txtMota = new TextBox();
            txtMucphat = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            cboLoaiViPham = new ComboBox();
            txtMaloi = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUndo = new Button();
            txtTimkiem = new TextBox();
            grdVipham = new DataGridView();
            colMaloi = new DataGridViewTextBoxColumn();
            colTenloi = new DataGridViewTextBoxColumn();
            colMucphat = new DataGridViewTextBoxColumn();
            colLoaivipham = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVipham).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 647F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.9484978F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.0515022F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 693F));
            tableLayoutPanel1.Controls.Add(cbxLoaiViPham, 1, 0);
            tableLayoutPanel1.Controls.Add(btnThemloi, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 2, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(groupBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(groupBox4, 3, 3);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(grdVipham, 0, 1);
            tableLayoutPanel1.Location = new Point(78, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.54546F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(1807, 1096);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // cbxLoaiViPham
            // 
            cbxLoaiViPham.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxLoaiViPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaiViPham.FormattingEnabled = true;
            cbxLoaiViPham.Location = new Point(649, 52);
            cbxLoaiViPham.Margin = new Padding(2);
            cbxLoaiViPham.Name = "cbxLoaiViPham";
            cbxLoaiViPham.Size = new Size(294, 36);
            cbxLoaiViPham.TabIndex = 105;
            // 
            // btnThemloi
            // 
            btnThemloi.Dock = DockStyle.Right;
            btnThemloi.FlatAppearance.BorderSize = 0;
            btnThemloi.FlatStyle = FlatStyle.Flat;
            btnThemloi.Image = (Image)resources.GetObject("btnThemloi.Image");
            btnThemloi.Location = new Point(1710, 3);
            btnThemloi.Name = "btnThemloi";
            btnThemloi.Size = new Size(94, 134);
            btnThemloi.TabIndex = 104;
            btnThemloi.UseVisualStyleBackColor = true;
            btnThemloi.Click += btnThemloi_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(948, 33);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(90, 74);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(650, 1000);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 93);
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
            groupBox1.Controls.Add(txtTenloi);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtMucphat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboLoaiViPham);
            groupBox1.Controls.Add(txtMaloi);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1116, 143);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(688, 448);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lỗi vi phạm";
            // 
            // txtTenloi
            // 
            txtTenloi.BorderStyle = BorderStyle.FixedSingle;
            txtTenloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenloi.Location = new Point(234, 118);
            txtTenloi.Name = "txtTenloi";
            txtTenloi.Size = new Size(326, 34);
            txtTenloi.TabIndex = 106;
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(234, 290);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 80;
            // 
            // txtMucphat
            // 
            txtMucphat.BorderStyle = BorderStyle.FixedSingle;
            txtMucphat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMucphat.Location = new Point(234, 177);
            txtMucphat.Name = "txtMucphat";
            txtMucphat.Size = new Size(326, 34);
            txtMucphat.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 292);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 78;
            label5.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 234);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 76;
            label3.Text = "Loại vi phạm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 179);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 65;
            label4.Text = "Mức phạt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 124);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 63;
            label2.Text = "Tên lỗi";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Location = new Point(234, 229);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(326, 36);
            cboLoaiViPham.TabIndex = 105;
            // 
            // txtMaloi
            // 
            txtMaloi.BorderStyle = BorderStyle.FixedSingle;
            txtMaloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaloi.Location = new Point(234, 69);
            txtMaloi.Name = "txtMaloi";
            txtMaloi.Size = new Size(326, 34);
            txtMaloi.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã lỗi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUndo);
            groupBox4.Dock = DockStyle.Right;
            groupBox4.Location = new Point(1486, 597);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(318, 121);
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
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 53);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(641, 34);
            txtTimkiem.TabIndex = 32;
            // 
            // grdVipham
            // 
            grdVipham.AllowUserToAddRows = false;
            grdVipham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVipham.BackgroundColor = Color.Gainsboro;
            grdVipham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVipham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVipham.ColumnHeadersHeight = 50;
            grdVipham.Columns.AddRange(new DataGridViewColumn[] { colMaloi, colTenloi, colMucphat, colLoaivipham });
            tableLayoutPanel1.SetColumnSpan(grdVipham, 2);
            grdVipham.Dock = DockStyle.Fill;
            grdVipham.EnableHeadersVisualStyles = false;
            grdVipham.Location = new Point(3, 143);
            grdVipham.Name = "grdVipham";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVipham.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVipham.RowHeadersVisible = false;
            grdVipham.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            grdVipham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tableLayoutPanel1.SetRowSpan(grdVipham, 5);
            grdVipham.RowTemplate.Height = 50;
            grdVipham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVipham.Size = new Size(939, 851);
            grdVipham.TabIndex = 93;
            grdVipham.SelectionChanged += grdVipham_SelectionChanged;
            // 
            // colMaloi
            // 
            colMaloi.DataPropertyName = "MaLoi";
            colMaloi.FillWeight = 80F;
            colMaloi.HeaderText = "Mã lỗi";
            colMaloi.MinimumWidth = 6;
            colMaloi.Name = "colMaloi";
            // 
            // colTenloi
            // 
            colTenloi.DataPropertyName = "TenLoi";
            colTenloi.FillWeight = 150F;
            colTenloi.HeaderText = "Tên lỗi";
            colTenloi.MinimumWidth = 6;
            colTenloi.Name = "colTenloi";
            // 
            // colMucphat
            // 
            colMucphat.DataPropertyName = "MucPhat";
            colMucphat.HeaderText = "Mức phạt";
            colMucphat.MinimumWidth = 6;
            colMucphat.Name = "colMucphat";
            // 
            // colLoaivipham
            // 
            colLoaivipham.DataPropertyName = "LoaiViPham";
            colLoaivipham.HeaderText = "Loại vi phạm";
            colLoaivipham.MinimumWidth = 6;
            colLoaivipham.Name = "colLoaivipham";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ucVipham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucVipham";
            Size = new Size(1963, 1155);
            Load += ucVipham_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdVipham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnThemloi;
        private DataGridView grdVipham;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtHovaten;
        private DateTimePicker dtpNamsinhtacgia;
        private Label label4;
        private Label label2;
        private TextBox txtMaloi;
        private Label label1;
        private GroupBox groupBox4;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUndo;
        private DataGridViewTextBoxColumn colMaloi;
        private DataGridViewTextBoxColumn colTenloi;
        private DataGridViewTextBoxColumn colMucphat;
        private DataGridViewTextBoxColumn colLoaivipham;
        private TextBox txtMota;
        private TextBox txtMucphat;
        private Label label5;
        private ComboBox cboLoaiViPham;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtTenloi;
        private ComboBox cbxLoaiViPham;
    }
}
