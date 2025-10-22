namespace QLTVNhom3
{
    partial class ucSachthuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSachthuthu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grdSach = new DataGridView();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            btnThemsach = new Button();
            cbxTheloai1 = new ComboBox();
            groupBox1 = new GroupBox();
            txtMadausach = new TextBox();
            label5 = new Label();
            btnTrolai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label6 = new Label();
            txtsoluong = new TextBox();
            dgvtacgia = new DataGridView();
            tentacgia = new DataGridViewTextBoxColumn();
            namsinh = new DataGridViewTextBoxColumn();
            cbxtheloai = new ComboBox();
            dtpnamxb = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtnxb = new TextBox();
            txttensach = new TextBox();
            label1 = new Label();
            pbAnhbia = new PictureBox();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnEnd = new Button();
            btnFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // grdSach
            // 
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Location = new Point(130, 134);
            grdSach.Name = "grdSach";
            grdSach.RowHeadersWidth = 51;
            grdSach.Size = new Size(730, 755);
            grdSach.TabIndex = 0;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(130, 59);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(520, 34);
            txtTimkiem.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(864, 48);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(72, 49);
            btnTimkiem.TabIndex = 2;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemsach
            // 
            btnThemsach.FlatAppearance.BorderSize = 0;
            btnThemsach.FlatStyle = FlatStyle.Flat;
            btnThemsach.Image = (Image)resources.GetObject("btnThemsach.Image");
            btnThemsach.Location = new Point(1528, 42);
            btnThemsach.Name = "btnThemsach";
            btnThemsach.Size = new Size(94, 60);
            btnThemsach.TabIndex = 3;
            btnThemsach.UseVisualStyleBackColor = true;
            btnThemsach.Click += button1_Click;
            // 
            // cbxTheloai1
            // 
            cbxTheloai1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloai1.FormattingEnabled = true;
            cbxTheloai1.Location = new Point(681, 58);
            cbxTheloai1.Name = "cbxTheloai1";
            cbxTheloai1.Size = new Size(151, 36);
            cbxTheloai1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMadausach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnTrolai);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(dgvtacgia);
            groupBox1.Controls.Add(cbxtheloai);
            groupBox1.Controls.Add(dtpnamxb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtnxb);
            groupBox1.Controls.Add(txttensach);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbAnhbia);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1025, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 800);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMadausach
            // 
            txtMadausach.BorderStyle = BorderStyle.FixedSingle;
            txtMadausach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadausach.Location = new Point(161, 314);
            txtMadausach.Name = "txtMadausach";
            txtMadausach.Size = new Size(326, 34);
            txtMadausach.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 314);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 74;
            label5.Text = "Mã sách";
            // 
            // btnTrolai
            // 
            btnTrolai.FlatAppearance.BorderSize = 0;
            btnTrolai.FlatStyle = FlatStyle.Flat;
            btnTrolai.Image = (Image)resources.GetObject("btnTrolai.Image");
            btnTrolai.Location = new Point(391, 733);
            btnTrolai.Name = "btnTrolai";
            btnTrolai.Size = new Size(45, 40);
            btnTrolai.TabIndex = 73;
            btnTrolai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(519, 733);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(45, 40);
            btnSua.TabIndex = 72;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(455, 733);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(48, 566);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 70;
            label6.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.BorderStyle = BorderStyle.FixedSingle;
            txtsoluong.Font = new Font("Segoe UI", 10.8F);
            txtsoluong.Location = new Point(161, 563);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(326, 31);
            txtsoluong.TabIndex = 69;
            // 
            // dgvtacgia
            // 
            dgvtacgia.AllowUserToAddRows = false;
            dgvtacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvtacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvtacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtacgia.Columns.AddRange(new DataGridViewColumn[] { tentacgia, namsinh });
            dgvtacgia.Location = new Point(161, 615);
            dgvtacgia.Name = "dgvtacgia";
            dgvtacgia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvtacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvtacgia.RowHeadersWidth = 51;
            dgvtacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvtacgia.Size = new Size(326, 90);
            dgvtacgia.TabIndex = 68;
            // 
            // tentacgia
            // 
            tentacgia.HeaderText = "Tên tác giả";
            tentacgia.MinimumWidth = 6;
            tentacgia.Name = "tentacgia";
            tentacgia.ReadOnly = true;
            // 
            // namsinh
            // 
            namsinh.HeaderText = "Năm sinh";
            namsinh.MinimumWidth = 6;
            namsinh.Name = "namsinh";
            namsinh.ReadOnly = true;
            // 
            // cbxtheloai
            // 
            cbxtheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxtheloai.FormattingEnabled = true;
            cbxtheloai.Location = new Point(161, 417);
            cbxtheloai.Name = "cbxtheloai";
            cbxtheloai.Size = new Size(326, 36);
            cbxtheloai.TabIndex = 67;
            // 
            // dtpnamxb
            // 
            dtpnamxb.CustomFormat = "yyyy";
            dtpnamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpnamxb.Format = DateTimePickerFormat.Custom;
            dtpnamxb.Location = new Point(161, 510);
            dtpnamxb.Name = "dtpnamxb";
            dtpnamxb.ShowUpDown = true;
            dtpnamxb.Size = new Size(118, 34);
            dtpnamxb.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(48, 515);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 65;
            label4.Text = "Năm XB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 470);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 64;
            label3.Text = "NXB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 417);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 63;
            label2.Text = "Thể loại";
            // 
            // txtnxb
            // 
            txtnxb.BorderStyle = BorderStyle.FixedSingle;
            txtnxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtnxb.Location = new Point(161, 464);
            txtnxb.Name = "txtnxb";
            txtnxb.Size = new Size(326, 34);
            txtnxb.TabIndex = 62;
            // 
            // txttensach
            // 
            txttensach.BorderStyle = BorderStyle.FixedSingle;
            txttensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttensach.Location = new Point(161, 368);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(326, 34);
            txttensach.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 368);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 60;
            label1.Text = "Tên sách";
            // 
            // pbAnhbia
            // 
            pbAnhbia.Location = new Point(195, 64);
            pbAnhbia.Name = "pbAnhbia";
            pbAnhbia.Size = new Size(225, 225);
            pbAnhbia.TabIndex = 1;
            pbAnhbia.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnEnd);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Location = new Point(568, 905);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(292, 85);
            groupBox3.TabIndex = 74;
            groupBox3.TabStop = false;
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
            btnPrevious.Click += btnPrevious_Click;
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
            btnNext.Click += btnNext_Click;
            // 
            // btnEnd
            // 
            btnEnd.FlatAppearance.BorderSize = 0;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Image = (Image)resources.GetObject("btnEnd.Image");
            btnEnd.Location = new Point(221, 26);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(53, 46);
            btnEnd.TabIndex = 76;
            btnEnd.UseVisualStyleBackColor = true;
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
            btnFirst.Click += btnFirst_Click;
            // 
            // ucSachthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(cbxTheloai1);
            Controls.Add(btnThemsach);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(grdSach);
            Name = "ucSachthuthu";
            Size = new Size(1650, 1000);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtacgia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSach;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnThemsach;
        private ComboBox cbxTheloai1;
        private GroupBox groupBox1;
        private PictureBox pbAnhbia;
        private ComboBox cbxtheloai;
        private DateTimePicker dtpnamxb;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtnxb;
        private TextBox txttensach;
        private Label label1;
        private DataGridView dgvtacgia;
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridViewTextBoxColumn namsinh;
        private Button btnXoa;
        private Label label6;
        private TextBox txtsoluong;
        private Button btnTrolai;
        private Button btnSua;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnEnd;
        private Button btnFirst;
        private TextBox txtMadausach;
        private Label label5;
    }
}
