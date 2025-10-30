namespace QLTVNhom3
{
    partial class frmXacnhanmuonsach
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgrXacnhan = new DataGridView();
            colTensachmuon = new DataGridViewTextBoxColumn();
            colMasachmuon = new DataGridViewTextBoxColumn();
            colNamxb = new DataGridViewTextBoxColumn();
            colHantra = new DataGridViewTextBoxColumn();
            cbxHinhthucmuon = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dtpNgaymuon = new DateTimePicker();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            btnXacnhan = new Button();
            btnHuy = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrXacnhan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbxHinhthucmuon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgaymuon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtTendocgia);
            groupBox1.Controls.Add(txtMadocgia);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(25, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 698);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phiếu mượn sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgrXacnhan);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(16, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 336);
            groupBox2.TabIndex = 178;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách mượn";
            // 
            // dgrXacnhan
            // 
            dgrXacnhan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgrXacnhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrXacnhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrXacnhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrXacnhan.Columns.AddRange(new DataGridViewColumn[] { colTensachmuon, colMasachmuon, colNamxb, colHantra });
            dgrXacnhan.Location = new Point(24, 62);
            dgrXacnhan.Name = "dgrXacnhan";
            dgrXacnhan.RowHeadersWidth = 51;
            dgrXacnhan.Size = new Size(636, 224);
            dgrXacnhan.TabIndex = 0;
            // 
            // colTensachmuon
            // 
            colTensachmuon.HeaderText = "Tên sách";
            colTensachmuon.MinimumWidth = 6;
            colTensachmuon.Name = "colTensachmuon";
            // 
            // colMasachmuon
            // 
            colMasachmuon.HeaderText = "Mã sách";
            colMasachmuon.MinimumWidth = 6;
            colMasachmuon.Name = "colMasachmuon";
            // 
            // colNamxb
            // 
            colNamxb.HeaderText = "Năm XB";
            colNamxb.MinimumWidth = 6;
            colNamxb.Name = "colNamxb";
            // 
            // colHantra
            // 
            colHantra.HeaderText = "Hạn trả";
            colHantra.MinimumWidth = 6;
            colHantra.Name = "colHantra";
            // 
            // cbxHinhthucmuon
            // 
            cbxHinhthucmuon.DisplayMember = "Tại chỗ";
            cbxHinhthucmuon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxHinhthucmuon.FormattingEnabled = true;
            cbxHinhthucmuon.Items.AddRange(new object[] { "Tại chỗ", "Mang về" });
            cbxHinhthucmuon.Location = new Point(245, 288);
            cbxHinhthucmuon.Name = "cbxHinhthucmuon";
            cbxHinhthucmuon.Size = new Size(185, 36);
            cbxHinhthucmuon.TabIndex = 177;
            cbxHinhthucmuon.ValueMember = "Tại chỗ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 287);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 176;
            label3.Text = "Hình thức mượn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(59, 214);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 175;
            label2.Text = "Ngày mượn";
            // 
            // dtpNgaymuon
            // 
            dtpNgaymuon.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaymuon.Font = new Font("Segoe UI", 10.8F);
            dtpNgaymuon.Format = DateTimePickerFormat.Short;
            dtpNgaymuon.Location = new Point(245, 217);
            dtpNgaymuon.Name = "dtpNgaymuon";
            dtpNgaymuon.Size = new Size(185, 31);
            dtpNgaymuon.TabIndex = 171;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(59, 68);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 170;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(59, 141);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 169;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(245, 143);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(356, 34);
            txtTendocgia.TabIndex = 168;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(245, 69);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(356, 34);
            txtMadocgia.TabIndex = 167;
            // 
            // btnXacnhan
            // 
            btnXacnhan.BackColor = SystemColors.Highlight;
            btnXacnhan.FlatAppearance.BorderSize = 0;
            btnXacnhan.FlatStyle = FlatStyle.Flat;
            btnXacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacnhan.ForeColor = Color.White;
            btnXacnhan.Location = new Point(593, 753);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(145, 38);
            btnXacnhan.TabIndex = 142;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(414, 753);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(145, 38);
            btnHuy.TabIndex = 143;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmXacnhanmuonsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(765, 831);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(groupBox1);
            Name = "frmXacnhanmuonsach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmXacnhanmuonsach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrXacnhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private ComboBox cbxHinhthucmuon;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgaymuon;
        private GroupBox groupBox2;
        private DataGridView dgrXacnhan;
        private Button btnXacnhan;
        private Button btnHuy;
        private DataGridViewTextBoxColumn colTensachmuon;
        private DataGridViewTextBoxColumn colMasachmuon;
        private DataGridViewTextBoxColumn colNamxb;
        private DataGridViewTextBoxColumn colHantra;
    }
}