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
            cbxLoaiViPham = new ComboBox();
            btnThemloi = new Button();
            btnTimkiem = new Button();
            groupBox4 = new GroupBox();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUndo = new Button();
            txtTimkiem = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            grdVipham = new DataGridView();
            colMaloi = new DataGridViewTextBoxColumn();
            colTenloi = new DataGridViewTextBoxColumn();
            colMucphat = new DataGridViewTextBoxColumn();
            colLoaivipham = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnNext = new Button();
            btnLast = new Button();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVipham).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbxLoaiViPham
            // 
            cbxLoaiViPham.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxLoaiViPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaiViPham.FormattingEnabled = true;
            cbxLoaiViPham.Location = new Point(990, 285);
            cbxLoaiViPham.Name = "cbxLoaiViPham";
            cbxLoaiViPham.Size = new Size(498, 53);
            cbxLoaiViPham.TabIndex = 105;
            // 
            // btnThemloi
            // 
            btnThemloi.FlatAppearance.BorderSize = 0;
            btnThemloi.FlatStyle = FlatStyle.Flat;
            btnThemloi.Image = (Image)resources.GetObject("btnThemloi.Image");
            btnThemloi.Location = new Point(2259, 181);
            btnThemloi.Margin = new Padding(5);
            btnThemloi.Name = "btnThemloi";
            btnThemloi.Size = new Size(153, 170);
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
            btnTimkiem.Location = new Point(1205, 246);
            btnTimkiem.Margin = new Padding(5);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(123, 118);
            btnTimkiem.TabIndex = 34;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUndo);
            groupBox4.Location = new Point(1738, 1366);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(517, 193);
            groupBox4.TabIndex = 95;
            groupBox4.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(101, 56);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(73, 64);
            btnSua.TabIndex = 77;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(405, 56);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(72, 64);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(304, 56);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(72, 64);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(203, 56);
            btnUndo.Margin = new Padding(5);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(72, 64);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(117, 286);
            txtTimkiem.Margin = new Padding(5);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1078, 50);
            txtTimkiem.TabIndex = 32;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
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
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1435, 408);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1060, 833);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lỗi vi phạm";
            // 
            // txtTenloi
            // 
            txtTenloi.BorderStyle = BorderStyle.FixedSingle;
            txtTenloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenloi.Location = new Point(380, 227);
            txtTenloi.Margin = new Padding(5);
            txtTenloi.Name = "txtTenloi";
            txtTenloi.Size = new Size(597, 50);
            txtTenloi.TabIndex = 106;
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(380, 581);
            txtMota.Margin = new Padding(5);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(597, 50);
            txtMota.TabIndex = 80;
            // 
            // txtMucphat
            // 
            txtMucphat.BorderStyle = BorderStyle.FixedSingle;
            txtMucphat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMucphat.Location = new Point(380, 344);
            txtMucphat.Margin = new Padding(5);
            txtMucphat.Name = "txtMucphat";
            txtMucphat.Size = new Size(597, 50);
            txtMucphat.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(102, 582);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 45);
            label5.TabIndex = 78;
            label5.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(102, 464);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 45);
            label3.TabIndex = 76;
            label3.Text = "Loại vi phạm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(102, 346);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 45);
            label4.TabIndex = 65;
            label4.Text = "Mức phạt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(102, 228);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 45);
            label2.TabIndex = 63;
            label2.Text = "Tên lỗi";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Location = new Point(380, 461);
            cboLoaiViPham.Margin = new Padding(5);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(597, 53);
            cboLoaiViPham.TabIndex = 105;
            // 
            // txtMaloi
            // 
            txtMaloi.BorderStyle = BorderStyle.FixedSingle;
            txtMaloi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMaloi.Location = new Point(380, 110);
            txtMaloi.Margin = new Padding(5);
            txtMaloi.Name = "txtMaloi";
            txtMaloi.Size = new Size(597, 50);
            txtMaloi.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(102, 110);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 45);
            label1.TabIndex = 60;
            label1.Text = "Mã lỗi";
            // 
            // grdVipham
            // 
            grdVipham.AllowUserToAddRows = false;
            grdVipham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVipham.BackgroundColor = Color.White;
            grdVipham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVipham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVipham.ColumnHeadersHeight = 50;
            grdVipham.Columns.AddRange(new DataGridViewColumn[] { colMaloi, colTenloi, colMucphat, colLoaivipham });
            grdVipham.EnableHeadersVisualStyles = false;
            grdVipham.Location = new Point(117, 408);
            grdVipham.Margin = new Padding(5);
            grdVipham.Name = "grdVipham";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
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
            grdVipham.RowTemplate.Height = 50;
            grdVipham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVipham.Size = new Size(1058, 833);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Location = new Point(709, 1374);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(486, 185);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(143, 63);
            btnPrevious.Margin = new Padding(5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(93, 64);
            btnPrevious.TabIndex = 78;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(47, 63);
            btnFirst.Margin = new Padding(5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(73, 64);
            btnFirst.TabIndex = 75;
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(258, 63);
            btnNext.Margin = new Padding(5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(73, 64);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(362, 58);
            btnLast.Margin = new Padding(5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(86, 74);
            btnLast.TabIndex = 76;
            // 
            // ucVipham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnThemloi);
            Controls.Add(groupBox1);
            Controls.Add(cbxLoaiViPham);
            Controls.Add(grdVipham);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Margin = new Padding(5);
            Name = "ucVipham";
            Size = new Size(2757, 1848);
            Load += ucVipham_Load;
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdVipham).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThemloi;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private TextBox txtHovaten;
        private DateTimePicker dtpNamsinhtacgia;
        private GroupBox groupBox4;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUndo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbxLoaiViPham;
        private GroupBox groupBox1;
        private TextBox txtTenloi;
        private DataGridView grdVipham;
        private DataGridViewTextBoxColumn colMaloi;
        private DataGridViewTextBoxColumn colTenloi;
        private DataGridViewTextBoxColumn colMucphat;
        private DataGridViewTextBoxColumn colLoaivipham;
        private TextBox txtMota;
        private TextBox txtMucphat;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private ComboBox cboLoaiViPham;
        private TextBox txtMaloi;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
    }
}
