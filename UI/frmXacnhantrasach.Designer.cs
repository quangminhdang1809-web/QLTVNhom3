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
            colTinhtrangphieu = new DataGridViewTextBoxColumn();
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
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(818, 926);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác nhận phiếu trả";
            // 
            // dtpNgaytra
            // 
            dtpNgaytra.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaytra.Font = new Font("Segoe UI", 10.8F);
            dtpNgaytra.Format = DateTimePickerFormat.Short;
            dtpNgaytra.Location = new Point(199, 129);
            dtpNgaytra.Name = "dtpNgaytra";
            dtpNgaytra.Size = new Size(185, 31);
            dtpNgaytra.TabIndex = 185;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(62, 131);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
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
            btnHuy.Location = new Point(538, 870);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(113, 38);
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
            btnLuu.Location = new Point(674, 870);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 38);
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
            groupBox2.Location = new Point(19, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 360);
            groupBox2.TabIndex = 174;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phiếu phạt";
            // 
            // txtTongtienphat
            // 
            txtTongtienphat.BorderStyle = BorderStyle.None;
            txtTongtienphat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongtienphat.Location = new Point(485, 318);
            txtTongtienphat.Name = "txtTongtienphat";
            txtTongtienphat.Size = new Size(224, 27);
            txtTongtienphat.TabIndex = 3;
            txtTongtienphat.Text = "Hiện tiền";
            // 
            // dgvThongTinPhat
            // 
            dgvThongTinPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinPhat.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuonphat, colMasach, colTensach, colSongaytratre, colVipham, colSotien });
            dgvThongTinPhat.Location = new Point(24, 45);
            dgvThongTinPhat.Name = "dgvThongTinPhat";
            dgvThongTinPhat.RowHeadersWidth = 51;
            dgvThongTinPhat.Size = new Size(683, 256);
            dgvThongTinPhat.TabIndex = 1;
            // 
            // colMaphieumuonphat
            // 
            colMaphieumuonphat.HeaderText = "Mã phiếu mượn";
            colMaphieumuonphat.MinimumWidth = 6;
            colMaphieumuonphat.Name = "colMaphieumuonphat";
            colMaphieumuonphat.Width = 125;
            // 
            // colMasach
            // 
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            colMasach.Width = 125;
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            colTensach.Width = 125;
            // 
            // colSongaytratre
            // 
            colSongaytratre.HeaderText = "Trả trễ";
            colSongaytratre.MinimumWidth = 6;
            colSongaytratre.Name = "colSongaytratre";
            colSongaytratre.Width = 125;
            // 
            // colVipham
            // 
            colVipham.HeaderText = "Vi phạm";
            colVipham.MinimumWidth = 6;
            colVipham.Name = "colVipham";
            colVipham.Width = 125;
            // 
            // colSotien
            // 
            colSotien.HeaderText = "Tổng tiền phạt";
            colSotien.MinimumWidth = 6;
            colSotien.Name = "colSotien";
            colSotien.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(286, 318);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền phạt:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTongSachTra);
            groupBox3.Controls.Add(dgvSachTra);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(19, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(734, 301);
            groupBox3.TabIndex = 173;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin trả sách";
            // 
            // txtTongSachTra
            // 
            txtTongSachTra.BorderStyle = BorderStyle.None;
            txtTongSachTra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongSachTra.Location = new Point(485, 263);
            txtTongSachTra.Name = "txtTongSachTra";
            txtTongSachTra.Size = new Size(224, 27);
            txtTongSachTra.TabIndex = 3;
            // 
            // dgvSachTra
            // 
            dgvSachTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachTra.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuon, colMasachtra, colTensachtra, colNgaymuon, colNgaytrasach, colTinhtrangphieu, colTinhtrangsach, colGhichu });
            dgvSachTra.Location = new Point(24, 46);
            dgvSachTra.Name = "dgvSachTra";
            dgvSachTra.RowHeadersWidth = 51;
            dgvSachTra.Size = new Size(683, 210);
            dgvSachTra.TabIndex = 0;
            // 
            // colMaphieumuon
            // 
            colMaphieumuon.HeaderText = "Mã phiếu mượn";
            colMaphieumuon.MinimumWidth = 6;
            colMaphieumuon.Name = "colMaphieumuon";
            colMaphieumuon.Width = 125;
            // 
            // colMasachtra
            // 
            colMasachtra.HeaderText = "Mã sách";
            colMasachtra.MinimumWidth = 6;
            colMasachtra.Name = "colMasachtra";
            colMasachtra.Width = 125;
            // 
            // colTensachtra
            // 
            colTensachtra.HeaderText = "Tên sách";
            colTensachtra.MinimumWidth = 6;
            colTensachtra.Name = "colTensachtra";
            colTensachtra.Width = 125;
            // 
            // colNgaymuon
            // 
            colNgaymuon.HeaderText = "Ngày mượn";
            colNgaymuon.MinimumWidth = 6;
            colNgaymuon.Name = "colNgaymuon";
            colNgaymuon.Width = 125;
            // 
            // colNgaytrasach
            // 
            colNgaytrasach.HeaderText = "Ngày trả";
            colNgaytrasach.MinimumWidth = 10;
            colNgaytrasach.Name = "colNgaytrasach";
            colNgaytrasach.Width = 200;
            // 
            // colTinhtrangphieu
            // 
            colTinhtrangphieu.HeaderText = "Tình trạng phiếu";
            colTinhtrangphieu.MinimumWidth = 10;
            colTinhtrangphieu.Name = "colTinhtrangphieu";
            colTinhtrangphieu.Width = 200;
            // 
            // colTinhtrangsach
            // 
            colTinhtrangsach.HeaderText = "Tình trạng sách";
            colTinhtrangsach.MinimumWidth = 6;
            colTinhtrangsach.Name = "colTinhtrangsach";
            colTinhtrangsach.Width = 125;
            // 
            // colGhichu
            // 
            colGhichu.HeaderText = "Ghi chú";
            colGhichu.MinimumWidth = 6;
            colGhichu.Name = "colGhichu";
            colGhichu.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(286, 262);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "Tổng sách trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(62, 39);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 178;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(62, 85);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 177;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(199, 84);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(500, 34);
            txtTendocgia.TabIndex = 176;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(199, 39);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(500, 34);
            txtMadocgia.TabIndex = 175;
            // 
            // frmXacnhantrasach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 940);
            Controls.Add(groupBox1);
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
        private DataGridViewTextBoxColumn colMaphieumuon;
        private DataGridViewTextBoxColumn colMasachtra;
        private DataGridViewTextBoxColumn colTensachtra;
        private DataGridViewTextBoxColumn colNgaymuon;
        private DataGridViewTextBoxColumn colNgaytrasach;
        private DataGridViewTextBoxColumn colTinhtrangphieu;
        private DataGridViewTextBoxColumn colTinhtrangsach;
        private DataGridViewTextBoxColumn colGhichu;
        private TextBox txtTongSachTra;
        private Label label3;
        private DataGridViewTextBoxColumn colMaphieumuonphat;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colSongaytratre;
        private DataGridViewTextBoxColumn colVipham;
        private DataGridViewTextBoxColumn colSotien;
    }
}