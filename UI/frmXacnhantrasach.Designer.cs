namespace QLTVNhom3
{
    partial class frmXacnhantrasach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dtpNgaytra = new DateTimePicker();
            label2 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            txtTongtienphat = new TextBox();
            dgvThongTinPhat = new DataGridView();
            colMaphieumuonphat = new DataGridViewTextBoxColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colTensach = new DataGridViewTextBoxColumn();
            colSongaytratre = new DataGridViewTextBoxColumn();
            colVipham = new DataGridViewTextBoxColumn();
            colSotien = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtTongSachTra = new TextBox();
            dgvSachTra = new DataGridView();
            colMaphieumuon = new DataGridViewTextBoxColumn();
            colMasachtra = new DataGridViewTextBoxColumn();
            colTensachtra = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colNgaytrasach = new DataGridViewTextBoxColumn();
            colTinhTrangPhieu = new DataGridViewTextBoxColumn();
            colTinhtrangsach = new DataGridViewTextBoxColumn();
            colGhichu = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinPhat).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachTra).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtpNgaytra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1873, 1482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác nhận phiếu trả";
            // 
            // dtpNgaytra
            // 
            dtpNgaytra.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaytra.Font = new Font("Segoe UI", 10.8F);
            dtpNgaytra.Format = DateTimePickerFormat.Short;
            dtpNgaytra.Location = new Point(297, 267);
            dtpNgaytra.Margin = new Padding(5);
            dtpNgaytra.Name = "dtpNgaytra";
            dtpNgaytra.Size = new Size(298, 46);
            dtpNgaytra.TabIndex = 185;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(65, 269);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 45);
            label2.TabIndex = 184;
            label2.Text = "Ngày trả";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(1418, 1392);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(184, 61);
            btnHuy.TabIndex = 182;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(1639, 1392);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(184, 61);
            btnLuu.TabIndex = 181;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongtienphat);
            groupBox2.Controls.Add(dgvThongTinPhat);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(31, 933);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(1792, 408);
            groupBox2.TabIndex = 174;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phiếu phạt";
            // 
            // txtTongtienphat
            // 
            txtTongtienphat.BorderStyle = BorderStyle.None;
            txtTongtienphat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongtienphat.Location = new Point(1387, 342);
            txtTongtienphat.Margin = new Padding(5);
            txtTongtienphat.Name = "txtTongtienphat";
            txtTongtienphat.Size = new Size(364, 43);
            txtTongtienphat.TabIndex = 3;
            txtTongtienphat.Text = "Hiện tiền";
            // 
            // dgvThongTinPhat
            // 
            dgvThongTinPhat.AllowUserToAddRows = false;
            dgvThongTinPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTinPhat.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThongTinPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongTinPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinPhat.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuonphat, colMasach, colTensach, colSongaytratre, colVipham, colSotien });
            dgvThongTinPhat.Location = new Point(25, 80);
            dgvThongTinPhat.Margin = new Padding(5);
            dgvThongTinPhat.Name = "dgvThongTinPhat";
            dgvThongTinPhat.RowHeadersVisible = false;
            dgvThongTinPhat.RowHeadersWidth = 51;
            dgvThongTinPhat.Size = new Size(1731, 231);
            dgvThongTinPhat.TabIndex = 1;
            // 
            // colMaphieumuonphat
            // 
            colMaphieumuonphat.HeaderText = "Mã phiếu mượn";
            colMaphieumuonphat.MinimumWidth = 6;
            colMaphieumuonphat.Name = "colMaphieumuonphat";
            // 
            // colMasach
            // 
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            // 
            // colSongaytratre
            // 
            colSongaytratre.HeaderText = "Trả trễ";
            colSongaytratre.MinimumWidth = 6;
            colSongaytratre.Name = "colSongaytratre";
            // 
            // colVipham
            // 
            colVipham.HeaderText = "Vi phạm";
            colVipham.MinimumWidth = 6;
            colVipham.Name = "colVipham";
            // 
            // colSotien
            // 
            colSotien.HeaderText = "Tổng tiền phạt";
            colSotien.MinimumWidth = 6;
            colSotien.Name = "colSotien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(1064, 342);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền phạt:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSachTra);
            groupBox3.Controls.Add(dgvSachTra);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(31, 371);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(1792, 552);
            groupBox3.TabIndex = 173;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin trả sách";
            // 
            // txtTongSachTra
            // 
            txtTongSachTra.BorderStyle = BorderStyle.None;
            txtTongSachTra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongSachTra.Location = new Point(1318, 493);
            txtTongSachTra.Margin = new Padding(5);
            txtTongSachTra.Name = "txtTongSachTra";
            txtTongSachTra.Size = new Size(364, 43);
            txtTongSachTra.TabIndex = 3;
            // 
            // dgvSachTra
            // 
            dgvSachTra.AllowUserToAddRows = false;
            dgvSachTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachTra.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSachTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSachTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachTra.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuon, colMasachtra, colTensachtra, colNgaymuon, colNgaytrasach, colTinhTrangPhieu, colTinhtrangsach, colGhichu });
            dgvSachTra.Location = new Point(34, 53);
            dgvSachTra.Margin = new Padding(5);
            dgvSachTra.Name = "dgvSachTra";
            dgvSachTra.RowHeadersVisible = false;
            dgvSachTra.RowHeadersWidth = 51;
            dgvSachTra.Size = new Size(1731, 396);
            dgvSachTra.TabIndex = 0;
            // 
            // colMaphieumuon
            // 
            colMaphieumuon.HeaderText = "Mã phiếu MS";
            colMaphieumuon.MinimumWidth = 6;
            colMaphieumuon.Name = "colMaphieumuon";
            // 
            // colMasachtra
            // 
            colMasachtra.HeaderText = "Mã sách";
            colMasachtra.MinimumWidth = 6;
            colMasachtra.Name = "colMasachtra";
            // 
            // colTensachtra
            // 
            colTensachtra.HeaderText = "Tên sách";
            colTensachtra.MinimumWidth = 6;
            colTensachtra.Name = "colTensachtra";
            // 
            // colNgaymuon
            // 
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 6;
            colNgaymuon.Name = "colNgaymuon";
            // 
            // colNgaytrasach
            // 
            colNgaytrasach.HeaderText = "Ngày trả";
            colNgaytrasach.MinimumWidth = 10;
            colNgaytrasach.Name = "colNgaytrasach";
            // 
            // colTinhTrangPhieu
            // 
            colTinhTrangPhieu.HeaderText = "Tình trạng phiếu";
            colTinhTrangPhieu.MinimumWidth = 10;
            colTinhTrangPhieu.Name = "colTinhTrangPhieu";
            // 
            // colTinhtrangsach
            // 
            colTinhtrangsach.HeaderText = "Tình trạng sách";
            colTinhtrangsach.MinimumWidth = 6;
            colTinhtrangsach.Name = "colTinhtrangsach";
            // 
            // colGhichu
            // 
            colGhichu.HeaderText = "Ghi chú";
            colGhichu.MinimumWidth = 6;
            colGhichu.Name = "colGhichu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(1081, 493);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 45);
            label3.TabIndex = 2;
            label3.Text = "Tổng sách trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(65, 81);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 45);
            label5.TabIndex = 178;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(65, 178);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(186, 45);
            label15.TabIndex = 177;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(297, 173);
            txtTendocgia.Margin = new Padding(5);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(811, 50);
            txtTendocgia.TabIndex = 176;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(297, 76);
            txtMadocgia.Margin = new Padding(5);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(811, 50);
            txtMadocgia.TabIndex = 175;
            // 
            // frmXacnhantrasach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1912, 1504);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "frmXacnhantrasach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmXacnhantrasach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinPhat).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTongtienphat;
        private DataGridView dgvThongTinPhat;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dgvSachTra;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private Button btnHuy;
        private Button btnLuu;
        private Label label2;
        private DateTimePicker dtpNgaytra;
        private TextBox txtTongSachTra;
        private Label label3;
        private DataGridViewTextBoxColumn colMaphieumuonphat;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colSongaytratre;
        private DataGridViewTextBoxColumn colVipham;
        private DataGridViewTextBoxColumn colSotien;
        private DataGridViewTextBoxColumn colMaphieumuon;
        private DataGridViewTextBoxColumn colMasachtra;
        private DataGridViewTextBoxColumn colTensachtra;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colNgaytrasach;
        private DataGridViewTextBoxColumn colTinhTrangPhieu;
        private DataGridViewTextBoxColumn colTinhtrangsach;
        private DataGridViewTextBoxColumn colGhichu;
    }
}