namespace QLTVNhom3
{
    partial class ucKhosach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhosach));
            tableLayoutPanel1 = new TableLayoutPanel();
            grdVitrisach = new DataGridView();
            btnThemkesach = new Button();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox1 = new GroupBox();
            txtMota = new TextBox();
            txtTenke = new TextBox();
            btnUndo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label2 = new Label();
            txtMake = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            Mavitri = new DataGridViewTextBoxColumn();
            Tenvitri = new DataGridViewTextBoxColumn();
            Mota = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.48216F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.173422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.34442F));
            tableLayoutPanel1.Controls.Add(grdVitrisach, 0, 1);
            tableLayoutPanel1.Controls.Add(btnThemkesach, 2, 0);
            tableLayoutPanel1.Controls.Add(btnTimkiem, 1, 0);
            tableLayoutPanel1.Controls.Add(txtTimkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Location = new Point(75, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3266563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.67334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.Size = new Size(1491, 889);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grdVitrisach
            // 
            grdVitrisach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVitrisach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVitrisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVitrisach.Columns.AddRange(new DataGridViewColumn[] { Mavitri, Tenvitri, Mota });
            grdVitrisach.Dock = DockStyle.Fill;
            grdVitrisach.Location = new Point(3, 98);
            grdVitrisach.Name = "grdVitrisach";
            grdVitrisach.RowHeadersWidth = 51;
            grdVitrisach.Size = new Size(701, 671);
            grdVitrisach.TabIndex = 31;
            // 
            // btnThemkesach
            // 
            btnThemkesach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemkesach.FlatAppearance.BorderSize = 0;
            btnThemkesach.FlatStyle = FlatStyle.Flat;
            btnThemkesach.Image = (Image)resources.GetObject("btnThemkesach.Image");
            btnThemkesach.Location = new Point(1416, 3);
            btnThemkesach.Name = "btnThemkesach";
            btnThemkesach.Size = new Size(72, 49);
            btnThemkesach.TabIndex = 30;
            btnThemkesach.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTenke);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(846, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 464);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin kệ sách";
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(146, 262);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 76;
            // 
            // txtTenke
            // 
            txtTenke.BorderStyle = BorderStyle.FixedSingle;
            txtTenke.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenke.Location = new Point(146, 185);
            txtTenke.Name = "txtTenke";
            txtTenke.Size = new Size(326, 34);
            txtTenke.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(399, 372);
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
            btnSua.Location = new Point(456, 372);
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
            btnXoa.Location = new Point(513, 372);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 268);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 65;
            label4.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 188);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 63;
            label2.Text = "Tên kệ";
            // 
            // txtMake
            // 
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMake.Location = new Point(146, 108);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(326, 34);
            txtMake.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã kệ";
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
            // Mavitri
            // 
            Mavitri.FillWeight = 20F;
            Mavitri.HeaderText = "Mã vị trí";
            Mavitri.MinimumWidth = 6;
            Mavitri.Name = "Mavitri";
            // 
            // Tenvitri
            // 
            Tenvitri.FillWeight = 50F;
            Tenvitri.HeaderText = "Tên vị trí";
            Tenvitri.MinimumWidth = 6;
            Tenvitri.Name = "Tenvitri";
            // 
            // Mota
            // 
            Mota.FillWeight = 55.7122459F;
            Mota.HeaderText = "Mô tả";
            Mota.MinimumWidth = 6;
            Mota.Name = "Mota";
            // 
            // ucKhosach
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucKhosach";
            Size = new Size(1650, 1000);
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
        private Button btnThemkesach;
        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTenke;
        private Button btnUndo;
        private Button btnSua;
        private Button btnXoa;
        private Label label4;
        private Label label2;
        private TextBox txtMake;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private DataGridView grdVitrisach;
        private DataGridViewTextBoxColumn Mavitri;
        private DataGridViewTextBoxColumn Tenvitri;
        private DataGridViewTextBoxColumn Mota;
    }
}
