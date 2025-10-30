namespace QLTVNhom3
{
    partial class frmThemsach
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemsach));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnLuu = new Button();
            pbThemanh = new PictureBox();
            btnThemanh = new Button();
            label1 = new Label();
            txtTensach = new TextBox();
            txtNxb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpNamxb = new DateTimePicker();
            label5 = new Label();
            cbbTheloai = new ComboBox();
            txtSoluong = new TextBox();
            label6 = new Label();
            txtTacgia = new TextBox();
            grdTacgia = new DataGridView();
            colMatacgia = new DataGridViewTextBoxColumn();
            colHotentacgia = new DataGridViewTextBoxColumn();
            colNamsinh = new DataGridViewTextBoxColumn();
            btnHuy = new Button();
            btnThemtg = new Button();
            btnXoatg = new Button();
            label8 = new Label();
            txtMadausach = new TextBox();
            groupBox1 = new GroupBox();
            grdSach = new DataGridView();
            colMasach = new DataGridViewTextBoxColumn();
            colTensach = new DataGridViewTextBoxColumn();
            colTrangthai = new DataGridViewTextBoxColumn();
            lblViTri = new Label();
            btnTaoMaSach = new Button();
            cbbVitri = new ComboBox();
            grdTimkiemtacgia = new DataGridView();
            colma = new DataGridViewTextBoxColumn();
            colnamsinh_timkiem = new DataGridViewTextBoxColumn();
            colten = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbThemanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdTimkiemtacgia).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Highlight;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(1506, 1198);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 61);
            btnLuu.TabIndex = 56;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // pbThemanh
            // 
            pbThemanh.BackColor = SystemColors.AppWorkspace;
            pbThemanh.Location = new Point(106, 104);
            pbThemanh.Margin = new Padding(5);
            pbThemanh.Name = "pbThemanh";
            pbThemanh.Size = new Size(299, 330);
            pbThemanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThemanh.TabIndex = 68;
            pbThemanh.TabStop = false;
            // 
            // btnThemanh
            // 
            btnThemanh.BackColor = SystemColors.Highlight;
            btnThemanh.FlatAppearance.BorderSize = 0;
            btnThemanh.FlatStyle = FlatStyle.Flat;
            btnThemanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThemanh.ForeColor = SystemColors.ButtonHighlight;
            btnThemanh.Location = new Point(106, 418);
            btnThemanh.Margin = new Padding(5);
            btnThemanh.Name = "btnThemanh";
            btnThemanh.Size = new Size(299, 61);
            btnThemanh.TabIndex = 69;
            btnThemanh.Text = "Thêm ảnh";
            btnThemanh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(574, 123);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 45);
            label1.TabIndex = 50;
            label1.Text = "Tên sách";
            // 
            // txtTensach
            // 
            txtTensach.BorderStyle = BorderStyle.FixedSingle;
            txtTensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTensach.Location = new Point(835, 126);
            txtTensach.Margin = new Padding(5);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(632, 50);
            txtTensach.TabIndex = 51;
            // 
            // txtNxb
            // 
            txtNxb.BorderStyle = BorderStyle.FixedSingle;
            txtNxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNxb.Location = new Point(835, 275);
            txtNxb.Margin = new Padding(5);
            txtNxb.Name = "txtNxb";
            txtNxb.Size = new Size(632, 50);
            txtNxb.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(574, 202);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 45);
            label2.TabIndex = 53;
            label2.Text = "Thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(574, 280);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 45);
            label3.TabIndex = 54;
            label3.Text = "NXB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(574, 358);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(227, 45);
            label4.TabIndex = 55;
            label4.Text = "Năm xuất bản";
            // 
            // dtpNamxb
            // 
            dtpNamxb.CustomFormat = "yyyy";
            dtpNamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamxb.Format = DateTimePickerFormat.Custom;
            dtpNamxb.Location = new Point(835, 352);
            dtpNamxb.Margin = new Padding(5);
            dtpNamxb.Name = "dtpNamxb";
            dtpNamxb.ShowUpDown = true;
            dtpNamxb.Size = new Size(179, 50);
            dtpNamxb.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(581, 520);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(173, 45);
            label5.TabIndex = 58;
            label5.Text = "Mã tác giả";
            // 
            // cbbTheloai
            // 
            cbbTheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbbTheloai.FormattingEnabled = true;
            cbbTheloai.Location = new Point(835, 203);
            cbbTheloai.Margin = new Padding(5);
            cbbTheloai.Name = "cbbTheloai";
            cbbTheloai.Size = new Size(632, 53);
            cbbTheloai.TabIndex = 59;
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Font = new Font("Segoe UI", 10.8F);
            txtSoluong.Location = new Point(838, 832);
            txtSoluong.Margin = new Padding(5);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(631, 46);
            txtSoluong.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(582, 832);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 45);
            label6.TabIndex = 61;
            label6.Text = "Số lượng";
            // 
            // txtTacgia
            // 
            txtTacgia.BorderStyle = BorderStyle.FixedSingle;
            txtTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTacgia.Location = new Point(834, 511);
            txtTacgia.Margin = new Padding(5);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(632, 50);
            txtTacgia.TabIndex = 63;
            txtTacgia.TextChanged += txtTacgia_TextChanged;
            // 
            // grdTacgia
            // 
            grdTacgia.AllowUserToAddRows = false;
            grdTacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdTacgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTacgia.Columns.AddRange(new DataGridViewColumn[] { colMatacgia, colHotentacgia, colNamsinh });
            grdTacgia.Location = new Point(838, 643);
            grdTacgia.Margin = new Padding(5);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grdTacgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTacgia.Size = new Size(627, 179);
            grdTacgia.TabIndex = 65;
            // 
            // colMatacgia
            // 
            colMatacgia.HeaderText = "Tác giả";
            colMatacgia.MinimumWidth = 6;
            colMatacgia.Name = "colMatacgia";
            colMatacgia.ReadOnly = true;
            // 
            // colHotentacgia
            // 
            colHotentacgia.HeaderText = "Họ và tên";
            colHotentacgia.MinimumWidth = 6;
            colHotentacgia.Name = "colHotentacgia";
            colHotentacgia.ReadOnly = true;
            // 
            // colNamsinh
            // 
            colNamsinh.HeaderText = "Năm sinh";
            colNamsinh.MinimumWidth = 6;
            colNamsinh.Name = "colNamsinh";
            colNamsinh.ReadOnly = true;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(1313, 1198);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(156, 61);
            btnHuy.TabIndex = 141;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThemtg
            // 
            btnThemtg.BackColor = Color.Transparent;
            btnThemtg.FlatAppearance.BorderSize = 0;
            btnThemtg.FlatStyle = FlatStyle.Flat;
            btnThemtg.Image = (Image)resources.GetObject("btnThemtg.Image");
            btnThemtg.Location = new Point(1308, 587);
            btnThemtg.Margin = new Padding(5);
            btnThemtg.Name = "btnThemtg";
            btnThemtg.Size = new Size(76, 46);
            btnThemtg.TabIndex = 142;
            btnThemtg.UseVisualStyleBackColor = false;
            // 
            // btnXoatg
            // 
            btnXoatg.BackColor = Color.Transparent;
            btnXoatg.FlatAppearance.BorderSize = 0;
            btnXoatg.FlatStyle = FlatStyle.Flat;
            btnXoatg.Image = (Image)resources.GetObject("btnXoatg.Image");
            btnXoatg.Location = new Point(1394, 587);
            btnXoatg.Margin = new Padding(5);
            btnXoatg.Name = "btnXoatg";
            btnXoatg.Size = new Size(76, 46);
            btnXoatg.TabIndex = 143;
            btnXoatg.UseVisualStyleBackColor = false;
            btnXoatg.Click += btnXoatg_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(574, 53);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(205, 45);
            label8.TabIndex = 144;
            label8.Text = "Mã đầu sách";
            // 
            // txtMadausach
            // 
            txtMadausach.BorderStyle = BorderStyle.FixedSingle;
            txtMadausach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadausach.Location = new Point(835, 43);
            txtMadausach.Margin = new Padding(5);
            txtMadausach.Name = "txtMadausach";
            txtMadausach.Size = new Size(632, 50);
            txtMadausach.TabIndex = 145;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdSach);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(36, 891);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1627, 302);
            groupBox1.TabIndex = 147;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bản sách ";
            // 
            // grdSach
            // 
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Columns.AddRange(new DataGridViewColumn[] { colMasach, colTensach, colTrangthai });
            grdSach.Location = new Point(10, 53);
            grdSach.Margin = new Padding(5);
            grdSach.Name = "grdSach";
            grdSach.ReadOnly = true;
            grdSach.RowHeadersWidth = 51;
            grdSach.RowTemplate.Height = 35;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(1583, 213);
            grdSach.TabIndex = 147;
            // 
            // colMasach
            // 
            colMasach.FillWeight = 70F;
            colMasach.HeaderText = "Mã sách";
            colMasach.MinimumWidth = 6;
            colMasach.Name = "colMasach";
            colMasach.ReadOnly = true;
            // 
            // colTensach
            // 
            colTensach.HeaderText = "Tên sách";
            colTensach.MinimumWidth = 6;
            colTensach.Name = "colTensach";
            colTensach.ReadOnly = true;
            // 
            // colTrangthai
            // 
            colTrangthai.HeaderText = "Trạng thái";
            colTrangthai.MinimumWidth = 6;
            colTrangthai.Name = "colTrangthai";
            colTrangthai.ReadOnly = true;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblViTri.Location = new Point(585, 438);
            lblViTri.Margin = new Padding(5, 0, 5, 0);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(90, 45);
            lblViTri.TabIndex = 149;
            lblViTri.Text = "Vị trí";
            // 
            // btnTaoMaSach
            // 
            btnTaoMaSach.BackColor = Color.Transparent;
            btnTaoMaSach.FlatAppearance.BorderSize = 0;
            btnTaoMaSach.FlatStyle = FlatStyle.Flat;
            btnTaoMaSach.Image = (Image)resources.GetObject("btnTaoMaSach.Image");
            btnTaoMaSach.Location = new Point(1506, 830);
            btnTaoMaSach.Margin = new Padding(5);
            btnTaoMaSach.Name = "btnTaoMaSach";
            btnTaoMaSach.Size = new Size(76, 46);
            btnTaoMaSach.TabIndex = 151;
            btnTaoMaSach.UseVisualStyleBackColor = false;
            // 
            // cbbVitri
            // 
            cbbVitri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbbVitri.FormattingEnabled = true;
            cbbVitri.Location = new Point(834, 426);
            cbbVitri.Margin = new Padding(5);
            cbbVitri.Name = "cbbVitri";
            cbbVitri.Size = new Size(632, 53);
            cbbVitri.TabIndex = 59;
            // 
            // grdTimkiemtacgia
            // 
            grdTimkiemtacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdTimkiemtacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTimkiemtacgia.Columns.AddRange(new DataGridViewColumn[] { colma, colnamsinh_timkiem, colten });
            grdTimkiemtacgia.Location = new Point(28, 568);
            grdTimkiemtacgia.Name = "grdTimkiemtacgia";
            grdTimkiemtacgia.RowHeadersWidth = 82;
            grdTimkiemtacgia.Size = new Size(630, 265);
            grdTimkiemtacgia.TabIndex = 152;
            grdTimkiemtacgia.Visible = false;
            grdTimkiemtacgia.CellDoubleClick += grdTimkiemtacgia_CellDoubleClick;
            // 
            // colma
            // 
            colma.DataPropertyName = "MaTacGia";
            colma.HeaderText = "Mã tác giả";
            colma.MinimumWidth = 10;
            colma.Name = "colma";
            colma.Visible = false;
            // 
            // colnamsinh_timkiem
            // 
            colnamsinh_timkiem.DataPropertyName = "NamSinh";
            colnamsinh_timkiem.HeaderText = "Năm sinh";
            colnamsinh_timkiem.MinimumWidth = 10;
            colnamsinh_timkiem.Name = "colnamsinh_timkiem";
            colnamsinh_timkiem.Visible = false;
            // 
            // colten
            // 
            colten.DataPropertyName = "TenTacGia";
            colten.HeaderText = "Tên tác giả";
            colten.MinimumWidth = 10;
            colten.Name = "colten";
            colten.Visible = false;
            // 
            // frmThemsach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1682, 1278);
            Controls.Add(grdTimkiemtacgia);
            Controls.Add(btnTaoMaSach);
            Controls.Add(lblViTri);
            Controls.Add(groupBox1);
            Controls.Add(txtMadausach);
            Controls.Add(label8);
            Controls.Add(btnXoatg);
            Controls.Add(btnThemtg);
            Controls.Add(btnHuy);
            Controls.Add(btnThemanh);
            Controls.Add(pbThemanh);
            Controls.Add(grdTacgia);
            Controls.Add(txtTacgia);
            Controls.Add(label6);
            Controls.Add(txtSoluong);
            Controls.Add(cbbVitri);
            Controls.Add(cbbTheloai);
            Controls.Add(label5);
            Controls.Add(dtpNamxb);
            Controls.Add(btnLuu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNxb);
            Controls.Add(txtTensach);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "frmThemsach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemsach";
            ((System.ComponentModel.ISupportInitialize)pbThemanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdTimkiemtacgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private PictureBox pbThemanh;
        private Button btnThemanh;
        private Label label1;
        private TextBox txtTensach;
        private TextBox txtNxb;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNamxb;
        private Label label5;
        private ComboBox cbbTheloai;
        private TextBox txtSoluong;
        private Label label6;
        private TextBox txtTacgia;
        private DataGridView grdTacgia;
        private Button btnHuy;
        private Button btnThemtg;
        private Button btnXoatg;
        private Label label8;
        private TextBox txtMadausach;
        private GroupBox groupBox1;
        private DataGridView grdSach;
        private DataGridViewTextBoxColumn colMasach;
        private DataGridViewTextBoxColumn colTensach;
        private DataGridViewTextBoxColumn colTrangthai;
        private DataGridView grdGoiytacgia;
        private DataGridViewTextBoxColumn colMatacgiatimkiem;
        private DataGridViewTextBoxColumn colTentacgiatimkiem;
        private TextBox txtVaitro;
        private Label lblViTri;
        private Button btnTaoMaSach;
        private ComboBox cbbVitri;
        private DataGridViewTextBoxColumn colMatacgia;
        private DataGridViewTextBoxColumn colHotentacgia;
        private DataGridViewTextBoxColumn colNamsinh;
        private DataGridView grdTimkiemtacgia;
        private DataGridViewTextBoxColumn colma;
        private DataGridViewTextBoxColumn colnamsinh_timkiem;
        private DataGridViewTextBoxColumn colten;
    }
}