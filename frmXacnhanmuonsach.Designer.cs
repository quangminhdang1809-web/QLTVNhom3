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
            dataGridView1 = new DataGridView();
            colTensach = new DataGridViewTextBoxColumn();
            colMasach = new DataGridViewTextBoxColumn();
            colNamXB = new DataGridViewTextBoxColumn();
            colHantra = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dtpNgayhethan = new DateTimePicker();
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            btnXacnhan = new Button();
            btnHuy = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNgayhethan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
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
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(20, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 280);
            groupBox2.TabIndex = 178;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách mượn";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTensach, colMasach, colNamXB, colHantra });
            dataGridView1.Location = new Point(27, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(629, 202);
            dataGridView1.TabIndex = 0;
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            // 
            // colMasach
            // 
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            // 
            // colNamXB
            // 
            colNamXB.HeaderText = "Năm XB";
            colNamXB.MinimumWidth = 6;
            colNamXB.Name = "colNamXB";
            // 
            // colHantra
            // 
            colHantra.HeaderText = "Hạn trả";
            colHantra.MinimumWidth = 6;
            colHantra.Name = "colHantra";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Mượn tại chỗ";
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mượn tại chỗ", "Mượn về nhà" });
            comboBox1.Location = new Point(246, 347);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 36);
            comboBox1.TabIndex = 177;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(60, 346);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 176;
            label3.Text = "Hình thức mượn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(60, 273);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 175;
            label2.Text = "Ngày mượn";
            // 
            // dtpNgayhethan
            // 
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(246, 276);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 171;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(60, 54);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 174;
            label1.Text = "Mã phiếu mượn";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox2.Location = new Point(246, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 34);
            textBox2.TabIndex = 171;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(60, 127);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 170;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(60, 200);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 169;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(246, 202);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(356, 34);
            txtTendocgia.TabIndex = 168;
            // 
            // txtMadocgia
            // 
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(246, 128);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayhethan;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnXacnhan;
        private Button btnHuy;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colNamXB;
        private DataGridViewTextBoxColumn colHantra;
    }
}