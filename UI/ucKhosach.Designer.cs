namespace QLTVNhom3
{
    partial class ucVitri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVitri));
            tableLayoutPanel1 = new TableLayoutPanel();
            grdVitrisach = new DataGridView();
            Mavitri = new DataGridViewTextBoxColumn();
            Tenvitri = new DataGridViewTextBoxColumn();
            colTang = new DataGridViewTextBoxColumn();
            colKe = new DataGridViewTextBoxColumn();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            txtKe = new TextBox();
            label5 = new Label();
            txtTang = new TextBox();
            label3 = new Label();
            txtMota = new TextBox();
            txtTenvitri = new TextBox();
            btnUndo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label2 = new Label();
            txtMavitri = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            btnThemvitrisach = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVitrisach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.42709F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.850026F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6624947F));
            tableLayoutPanel1.Controls.Add(grdVitrisach, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(btnThemvitrisach, 2, 0);
            tableLayoutPanel1.Location = new Point(145, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3266563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.67334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.Size = new Size(2154, 1223);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grdVitrisach
            // 
            grdVitrisach.AllowUserToAddRows = false;
            grdVitrisach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVitrisach.BackgroundColor = Color.White;
            grdVitrisach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVitrisach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVitrisach.ColumnHeadersHeight = 50;
            grdVitrisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdVitrisach.Columns.AddRange(new DataGridViewColumn[] { Mavitri, Tenvitri, colTang, colKe });
            grdVitrisach.Dock = DockStyle.Fill;
            grdVitrisach.EnableHeadersVisualStyles = false;
            grdVitrisach.Location = new Point(3, 139);
            grdVitrisach.Name = "grdVitrisach";
            grdVitrisach.RowHeadersVisible = false;
            grdVitrisach.RowHeadersWidth = 50;
            grdVitrisach.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grdVitrisach.RowTemplate.Height = 40;
            grdVitrisach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVitrisach.Size = new Size(1102, 964);
            grdVitrisach.TabIndex = 31;
            grdVitrisach.CellClick += grdVitrisach_CellClick;
            // 
            // Mavitri
            // 
            Mavitri.DataPropertyName = "MaViTri";
            Mavitri.FillWeight = 70F;
            Mavitri.HeaderText = "Mã vị trí";
            Mavitri.MinimumWidth = 6;
            Mavitri.Name = "Mavitri";
            // 
            // Tenvitri
            // 
            Tenvitri.DataPropertyName = "TenViTri";
            Tenvitri.FillWeight = 150F;
            Tenvitri.HeaderText = "Tên vị trí";
            Tenvitri.MinimumWidth = 6;
            Tenvitri.Name = "Tenvitri";
            // 
            // colTang
            // 
            colTang.DataPropertyName = "Tang";
            colTang.HeaderText = "Tầng";
            colTang.MinimumWidth = 6;
            colTang.Name = "colTang";
            // 
            // colKe
            // 
            colKe.DataPropertyName = "Ke";
            colKe.HeaderText = "Kệ";
            colKe.MinimumWidth = 6;
            colKe.Name = "colKe";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1111, 29);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(141, 78);
            btnTimkiem.TabIndex = 27;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(3, 43);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1102, 50);
            txtTimkiem.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtKe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTenvitri);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMavitri);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1258, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(893, 663);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vị trí sách";
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(324, 580);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 77);
            btnSua.TabIndex = 81;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtKe
            // 
            txtKe.BorderStyle = BorderStyle.FixedSingle;
            txtKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtKe.Location = new Point(344, 394);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(472, 50);
            txtKe.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(107, 394);
            label5.Name = "label5";
            label5.Size = new Size(57, 45);
            label5.TabIndex = 79;
            label5.Text = "Kệ";
            // 
            // txtTang
            // 
            txtTang.BorderStyle = BorderStyle.FixedSingle;
            txtTang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTang.Location = new Point(344, 299);
            txtTang.Name = "txtTang";
            txtTang.Size = new Size(472, 50);
            txtTang.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(107, 299);
            label3.Name = "label3";
            label3.Size = new Size(93, 45);
            label3.TabIndex = 77;
            label3.Text = "Tầng";
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(344, 489);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(472, 50);
            txtMota.TabIndex = 76;
            // 
            // txtTenvitri
            // 
            txtTenvitri.BorderStyle = BorderStyle.FixedSingle;
            txtTenvitri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenvitri.Location = new Point(344, 204);
            txtTenvitri.Name = "txtTenvitri";
            txtTenvitri.Size = new Size(472, 50);
            txtTenvitri.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(471, 580);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(120, 77);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(618, 580);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 77);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(765, 580);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 77);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(107, 489);
            label4.Name = "label4";
            label4.Size = new Size(107, 45);
            label4.TabIndex = 65;
            label4.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(107, 204);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 63;
            label2.Text = "Tên vị trí";
            // 
            // txtMavitri
            // 
            txtMavitri.BorderStyle = BorderStyle.FixedSingle;
            txtMavitri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMavitri.Location = new Point(344, 109);
            txtMavitri.Name = "txtMavitri";
            txtMavitri.ReadOnly = true;
            txtMavitri.Size = new Size(472, 50);
            txtMavitri.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(107, 109);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 60;
            label1.Text = "Mã vị trí";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(710, 1109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 111);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(121, 26);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(50, 50);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(218, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(50, 50);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(315, 26);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(50, 50);
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
            btnFirst.Size = new Size(50, 50);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnThemvitrisach
            // 
            btnThemvitrisach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemvitrisach.FlatAppearance.BorderSize = 0;
            btnThemvitrisach.FlatStyle = FlatStyle.Flat;
            btnThemvitrisach.Image = (Image)resources.GetObject("btnThemvitrisach.Image");
            btnThemvitrisach.Location = new Point(2043, 3);
            btnThemvitrisach.Name = "btnThemvitrisach";
            btnThemvitrisach.Size = new Size(108, 125);
            btnThemvitrisach.TabIndex = 30;
            btnThemvitrisach.UseVisualStyleBackColor = true;
            btnThemvitrisach.Click += btnThemkesach_Click;
            // 
            // ucVitri
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucVitri";
            Size = new Size(2390, 1322);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdVitrisach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnThemvitrisach;
        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTenvitri;
        private Button btnUndo;
        private Button btnLuu;
        private Button btnXoa;
        private Label label4;
        private Label label2;
        private TextBox txtMavitri;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DataGridView grdVitrisach;
        private TextBox txtKe;
        private Label label5;
        private TextBox txtTang;
        private Label label3;
        private Button btnSua;
        private DataGridViewTextBoxColumn Mavitri;
        private DataGridViewTextBoxColumn Tenvitri;
        private DataGridViewTextBoxColumn colTang;
        private DataGridViewTextBoxColumn colKe;
    }
}
