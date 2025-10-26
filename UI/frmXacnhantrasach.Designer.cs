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
            dtpNgayhethan = new DateTimePicker();
            label2 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            colMaphieumuon = new DataGridViewTextBoxColumn();
            colMasachtra = new DataGridViewTextBoxColumn();
            colTensachtra = new DataGridViewTextBoxColumn();
            colNgaymuon = new DataGridViewTextBoxColumn();
            colNgaytra = new DataGridViewTextBoxColumn();
            colTinhtrangsach = new DataGridViewTextBoxColumn();
            colTinhtrangphieu = new DataGridViewTextBoxColumn();
            colGhichu = new DataGridViewTextBoxColumn();
            colMaphieumuonphat = new DataGridViewTextBoxColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colTensach = new DataGridViewTextBoxColumn();
            colSongaytratre = new DataGridViewTextBoxColumn();
            colVipham = new DataGridViewTextBoxColumn();
            colSotien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtpNgayhethan);
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
            groupBox1.Size = new Size(784, 900);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác nhận phiếu trả";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(199, 129);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 185;
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
            btnHuy.Location = new Point(504, 844);
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
            btnLuu.Location = new Point(640, 844);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 38);
            btnLuu.TabIndex = 181;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(19, 464);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 348);
            groupBox2.TabIndex = 174;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phiếu phạt";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(485, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Hiện tiền";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuonphat, colMasach, colTensach, colSongaytratre, colVipham, colSotien });
            dataGridView2.Location = new Point(24, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(683, 256);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(286, 306);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền phạt:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(19, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(734, 269);
            groupBox3.TabIndex = 173;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin trả sách";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaphieumuon, colMasachtra, colTensachtra, colNgaymuon, colNgaytra, colTinhtrangsach, colTinhtrangphieu, colGhichu });
            dataGridView1.Location = new Point(24, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 210);
            dataGridView1.TabIndex = 0;
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
            // colNgaytra
            // 
            colNgaytra.HeaderText = "Hạn trả";
            colNgaytra.MinimumWidth = 6;
            colNgaytra.Name = "colNgaytra";
            colNgaytra.Width = 125;
            // 
            // colTinhtrangsach
            // 
            colTinhtrangsach.HeaderText = "Tình trạng sách";
            colTinhtrangsach.MinimumWidth = 6;
            colTinhtrangsach.Name = "colTinhtrangsach";
            colTinhtrangsach.Width = 125;
            // 
            // colTinhtrangphieu
            // 
            colTinhtrangphieu.HeaderText = "Tình trạng phiếu mượn";
            colTinhtrangphieu.MinimumWidth = 6;
            colTinhtrangphieu.Name = "colTinhtrangphieu";
            colTinhtrangphieu.Width = 125;
            // 
            // colGhichu
            // 
            colGhichu.HeaderText = "Ghi chú";
            colGhichu.MinimumWidth = 6;
            colGhichu.Name = "colGhichu";
            colGhichu.Width = 125;
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
            colSotien.HeaderText = "Số tiền";
            colSotien.MinimumWidth = 6;
            colSotien.Name = "colSotien";
            colSotien.Width = 125;
            // 
            // frmXacnhantrasach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(808, 914);
            Controls.Add(groupBox1);
            Name = "frmXacnhantrasach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmXacnhantrasach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private Button btnHuy;
        private Button btnLuu;
        private Label label2;
        private DateTimePicker dtpNgayhethan;
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
        private DataGridViewTextBoxColumn colNgaytra;
        private DataGridViewTextBoxColumn colTinhtrangsach;
        private DataGridViewTextBoxColumn colTinhtrangphieu;
        private DataGridViewTextBoxColumn colGhichu;
    }
}