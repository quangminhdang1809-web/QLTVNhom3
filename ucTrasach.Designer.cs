namespace QLTVNhom3
{
    partial class ucTrasach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTrasach));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            btnXoa = new Button();
            button3 = new Button();
            btnXacnhan = new Button();
            grdThongtintrasach = new DataGridView();
            colTensachtra = new DataGridViewTextBoxColumn();
            colMasachtra = new DataGridViewTextBoxColumn();
            colNamXBtra = new DataGridViewTextBoxColumn();
            colNguoimuon = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colHantratra = new DataGridViewTextBoxColumn();
            colTinhtrangtra = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            btnHuy = new Button();
            txtXacnhan = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox3 = new GroupBox();
            grdSachdangmuon = new DataGridView();
            colMasach = new DataGridViewTextBoxColumn();
            colTensachdamuon = new DataGridViewTextBoxColumn();
            colNXB = new DataGridViewTextBoxColumn();
            colHantra = new DataGridViewTextBoxColumn();
            colTinhtrang = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.2F));
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel1.Location = new Point(41, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 565F));
            tableLayoutPanel1.Size = new Size(1500, 913);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(btnXacnhan);
            groupBox4.Controls.Add(grdThongtintrasach);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(txtXacnhan);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(3, 351);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1494, 559);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin trả sách";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(1395, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(69, 54);
            btnXoa.TabIndex = 150;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(220, 53, 69);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1152, 503);
            button3.Name = "button3";
            button3.Size = new Size(145, 38);
            button3.TabIndex = 149;
            button3.Text = "Hủy";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacnhan.BackColor = SystemColors.Highlight;
            btnXacnhan.FlatAppearance.BorderSize = 0;
            btnXacnhan.FlatStyle = FlatStyle.Flat;
            btnXacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacnhan.ForeColor = Color.White;
            btnXacnhan.Location = new Point(1319, 503);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(145, 38);
            btnXacnhan.TabIndex = 148;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // grdThongtintrasach
            // 
            grdThongtintrasach.AllowUserToAddRows = false;
            grdThongtintrasach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdThongtintrasach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdThongtintrasach.BackgroundColor = Color.Gainsboro;
            grdThongtintrasach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdThongtintrasach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdThongtintrasach.ColumnHeadersHeight = 50;
            grdThongtintrasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdThongtintrasach.Columns.AddRange(new DataGridViewColumn[] { colTensachtra, colMasachtra, colNamXBtra, colNguoimuon, colNgaymuon, colHantratra, colTinhtrangtra });
            grdThongtintrasach.EnableHeadersVisualStyles = false;
            grdThongtintrasach.Location = new Point(33, 85);
            grdThongtintrasach.Name = "grdThongtintrasach";
            grdThongtintrasach.RowHeadersWidth = 51;
            grdThongtintrasach.Size = new Size(1431, 398);
            grdThongtintrasach.TabIndex = 147;
            grdThongtintrasach.CellContentClick += grdThongtintrasach_CellContentClick;
            // 
            // colTensachtra
            // 
            colTensachtra.FillWeight = 120F;
            colTensachtra.HeaderText = "Tên sách";
            colTensachtra.MinimumWidth = 6;
            colTensachtra.Name = "colTensachtra";
            // 
            // colMasachtra
            // 
            colMasachtra.FillWeight = 70F;
            colMasachtra.HeaderText = "Mã sách";
            colMasachtra.MinimumWidth = 6;
            colMasachtra.Name = "colMasachtra";
            // 
            // colNamXBtra
            // 
            colNamXBtra.FillWeight = 70F;
            colNamXBtra.HeaderText = "Năm XB";
            colNamXBtra.MinimumWidth = 6;
            colNamXBtra.Name = "colNamXBtra";
            // 
            // colNguoimuon
            // 
            colNguoimuon.HeaderText = "Người mượn";
            colNguoimuon.MinimumWidth = 6;
            colNguoimuon.Name = "colNguoimuon";
            // 
            // colNgaymuon
            // 
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 6;
            colNgaymuon.Name = "colNgaymuon";
            // 
            // colHantratra
            // 
            colHantratra.HeaderText = "Hạn trả";
            colHantratra.MinimumWidth = 6;
            colHantratra.Name = "colHantratra";
            // 
            // colTinhtrangtra
            // 
            colTinhtrangtra.HeaderText = "Tình trạng";
            colTinhtrangtra.MinimumWidth = 6;
            colTinhtrangtra.Name = "colTinhtrangtra";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(220, 53, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1720, 1112);
            button1.Name = "button1";
            button1.Size = new Size(145, 38);
            button1.TabIndex = 146;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1887, 1112);
            button2.Name = "button2";
            button2.Size = new Size(145, 38);
            button2.TabIndex = 145;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(2194, 1763);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(145, 38);
            btnHuy.TabIndex = 144;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // txtXacnhan
            // 
            txtXacnhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtXacnhan.BackColor = SystemColors.Highlight;
            txtXacnhan.FlatAppearance.BorderSize = 0;
            txtXacnhan.FlatStyle = FlatStyle.Flat;
            txtXacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtXacnhan.ForeColor = Color.White;
            txtXacnhan.Location = new Point(2361, 1763);
            txtXacnhan.Name = "txtXacnhan";
            txtXacnhan.Size = new Size(145, 38);
            txtXacnhan.TabIndex = 143;
            txtXacnhan.Text = "Xác nhận";
            txtXacnhan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 342);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTendocgia);
            groupBox2.Controls.Add(txtMadocgia);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(33, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 179);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 49);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(17, 115);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(181, 113);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(351, 34);
            txtTendocgia.TabIndex = 164;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(181, 47);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(351, 34);
            txtMadocgia.TabIndex = 163;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grdSachdangmuon);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(645, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(852, 342);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            // 
            // grdSachdangmuon
            // 
            grdSachdangmuon.AllowUserToAddRows = false;
            grdSachdangmuon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdSachdangmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSachdangmuon.BackgroundColor = Color.Gainsboro;
            grdSachdangmuon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdSachdangmuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdSachdangmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSachdangmuon.Columns.AddRange(new DataGridViewColumn[] { colMasach, colTensachdamuon, colNXB, colHantra, colTinhtrang });
            grdSachdangmuon.EnableHeadersVisualStyles = false;
            grdSachdangmuon.Location = new Point(17, 33);
            grdSachdangmuon.Name = "grdSachdangmuon";
            grdSachdangmuon.RowHeadersWidth = 51;
            grdSachdangmuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSachdangmuon.Size = new Size(813, 287);
            grdSachdangmuon.TabIndex = 0;
            grdSachdangmuon.CellContentClick += grdThongtinsachmuon_CellContentClick;
            // 
            // colMasach
            // 
            colMasach.FillWeight = 70F;
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            // 
            // colTensachdamuon
            // 
            colTensachdamuon.HeaderText = "Tên sách";
            colTensachdamuon.MinimumWidth = 6;
            colTensachdamuon.Name = "colTensachdamuon";
            // 
            // colNXB
            // 
            colNXB.FillWeight = 50F;
            colNXB.HeaderText = "Năm XB";
            colNXB.MinimumWidth = 6;
            colNXB.Name = "colNXB";
            // 
            // colHantra
            // 
            colHantra.HeaderText = "Hạn trả";
            colHantra.MinimumWidth = 6;
            colHantra.Name = "colHantra";
            // 
            // colTinhtrang
            // 
            colTinhtrang.HeaderText = "Tình trạng";
            colTinhtrang.MinimumWidth = 6;
            colTinhtrang.Name = "colTinhtrang";
            // 
            // ucTrasach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTrasach";
            Size = new Size(1650, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSachdangmuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView grdSachdangmuon;
        private GroupBox groupBox4;
        private Button btnXoa;
        private Button button3;
        private Button btnXacnhan;
        private DataGridView grdThongtintrasach;
        private Button button1;
        private Button button2;
        private Button btnHuy;
        private Button txtXacnhan;
        private DataGridViewTextBoxColumn colTensachtra;
        private DataGridViewTextBoxColumn colMasachtra;
        private DataGridViewTextBoxColumn colNamXBtra;
        private DataGridViewTextBoxColumn colNguoimuon;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colHantratra;
        private DataGridViewTextBoxColumn colTinhtrangtra;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensachdamuon;
        private DataGridViewTextBoxColumn colNXB;
        private DataGridViewTextBoxColumn colHantra;
        private DataGridViewTextBoxColumn colTinhtrang;
    }
}
