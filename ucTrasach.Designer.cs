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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            grdThongtintrasach = new DataGridView();
            btnHuy = new Button();
            txtXacnhan = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox3 = new GroupBox();
            grdThongtinsachmuon = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(41, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1500, 913);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(grdThongtintrasach);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(txtXacnhan);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(753, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(744, 739);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin trả sách";
            // 
            // grdThongtintrasach
            // 
            grdThongtintrasach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdThongtintrasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtintrasach.Location = new Point(53, 78);
            grdThongtintrasach.Name = "grdThongtintrasach";
            grdThongtintrasach.RowHeadersWidth = 51;
            grdThongtintrasach.Size = new Size(639, 546);
            grdThongtintrasach.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(356, 665);
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
            txtXacnhan.Location = new Point(523, 665);
            txtXacnhan.Name = "txtXacnhan";
            txtXacnhan.Size = new Size(145, 38);
            txtXacnhan.TabIndex = 143;
            txtXacnhan.Text = "Xác nhận";
            txtXacnhan.UseVisualStyleBackColor = false;
            txtXacnhan.Click += txtXacnhan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 907);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn sách";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTendocgia);
            groupBox2.Controls.Add(txtMadocgia);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(33, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(656, 181);
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
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(grdThongtinsachmuon);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(33, 266);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(656, 588);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            // 
            // grdThongtinsachmuon
            // 
            grdThongtinsachmuon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdThongtinsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtinsachmuon.Location = new Point(17, 58);
            grdThongtinsachmuon.Name = "grdThongtinsachmuon";
            grdThongtinsachmuon.RowHeadersWidth = 51;
            grdThongtinsachmuon.Size = new Size(621, 492);
            grdThongtinsachmuon.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private GroupBox groupBox3;
        private DataGridView grdThongtinsachmuon;
        private GroupBox groupBox4;
        private DataGridView grdThongtintrasach;
        private Button btnHuy;
        private Button txtXacnhan;
    }
}
