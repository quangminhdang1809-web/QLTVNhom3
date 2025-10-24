namespace QLTVNhom3
{
    partial class ucMuonsachthuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMuonsachthuthu));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            drgTimkiemsach = new DataGridView();
            grdThongtinsachmuon = new DataGridView();
            cbxTheloaisach = new ComboBox();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            groupBox5 = new GroupBox();
            grdSach = new DataGridView();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            dtpNgayhethan = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            btnXemphieumuon = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5080376F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4919624F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnXemphieumuon, 1, 2);
            tableLayoutPanel1.Location = new Point(63, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.0397339F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.9602661F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Size = new Size(1435, 955);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(drgTimkiemsach);
            groupBox3.Controls.Add(grdThongtinsachmuon);
            groupBox3.Controls.Add(cbxTheloaisach);
            groupBox3.Controls.Add(btnTimkiem);
            groupBox3.Controls.Add(txtTimkiem);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(3, 390);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1429, 487);
            groupBox3.TabIndex = 175;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // drgTimkiemsach
            // 
            drgTimkiemsach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            drgTimkiemsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgTimkiemsach.Location = new Point(25, 104);
            drgTimkiemsach.Name = "drgTimkiemsach";
            drgTimkiemsach.RowHeadersWidth = 51;
            drgTimkiemsach.Size = new Size(1123, 299);
            drgTimkiemsach.TabIndex = 9;
            drgTimkiemsach.Visible = false;
            // 
            // grdThongtinsachmuon
            // 
            grdThongtinsachmuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdThongtinsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtinsachmuon.Location = new Point(25, 117);
            grdThongtinsachmuon.Name = "grdThongtinsachmuon";
            grdThongtinsachmuon.RowHeadersWidth = 51;
            grdThongtinsachmuon.Size = new Size(1371, 299);
            grdThongtinsachmuon.TabIndex = 0;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(1176, 62);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(139, 36);
            cbxTheloaisach.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1327, 23);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(68, 75);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(25, 64);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1123, 34);
            txtTimkiem.TabIndex = 6;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(grdSach);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.Location = new Point(612, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(820, 381);
            groupBox5.TabIndex = 174;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách đã đăng kí mượn";
            // 
            // grdSach
            // 
            grdSach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Location = new Point(48, 115);
            grdSach.Name = "grdSach";
            grdSach.RowHeadersWidth = 51;
            grdSach.Size = new Size(739, 228);
            grdSach.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(48, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(517, 65);
            groupBox4.TabIndex = 172;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(453, 30);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 7;
            label4.Text = "3";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(184, 30);
            label3.Name = "label3";
            label3.Size = new Size(24, 28);
            label3.TabIndex = 6;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(314, 30);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 5;
            label2.Text = "Quá hạn:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 4;
            label1.Text = "Đang mượn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpNgayhethan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTendocgia);
            groupBox2.Controls.Add(txtMadocgia);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 381);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(19, 524);
            label6.Name = "label6";
            label6.Size = new Size(482, 56);
            label6.TabIndex = 171;
            label6.Text = "Thông báo thẻ quá hạn, sách mượn quá số lượng,\r\n sách quá hạn";
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(172, 177);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 170;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(19, 180);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 168;
            label8.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 43);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(19, 109);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(172, 109);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(351, 34);
            txtTendocgia.TabIndex = 164;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(172, 43);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(351, 34);
            txtMadocgia.TabIndex = 163;
            // 
            // btnXemphieumuon
            // 
            btnXemphieumuon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXemphieumuon.BackColor = SystemColors.Highlight;
            btnXemphieumuon.FlatAppearance.BorderSize = 0;
            btnXemphieumuon.FlatStyle = FlatStyle.Flat;
            btnXemphieumuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXemphieumuon.ForeColor = Color.White;
            btnXemphieumuon.Location = new Point(1222, 914);
            btnXemphieumuon.Name = "btnXemphieumuon";
            btnXemphieumuon.Size = new Size(210, 38);
            btnXemphieumuon.TabIndex = 176;
            btnXemphieumuon.Text = "Xem phiếu mượn";
            btnXemphieumuon.UseVisualStyleBackColor = false;
            btnXemphieumuon.Click += btnXemphieumuon_Click;
            // 
            // ucMuonsachthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMuonsachthuthu";
            Size = new Size(1650, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label label6;
        private DateTimePicker dtpNgayhethan;
        private Label label8;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private GroupBox groupBox5;
        private DataGridView grdSach;
        private GroupBox groupBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView drgTimkiemsach;
        private DataGridView grdThongtinsachmuon;
        private ComboBox cbxTheloaisach;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private Button btnXemphieumuon;
    }
}
