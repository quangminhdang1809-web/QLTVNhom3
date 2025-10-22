namespace QLTVNhom3
{
    partial class ucDocgiathuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDocgiathuthu));
            btnThemdocgia = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvLichsumuontra = new DataGridView();
            label5 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cbxloaidocgia = new ComboBox();
            button3 = new Button();
            dtpngaysinh = new DateTimePicker();
            dtpngayhethan = new DateTimePicker();
            button1 = new Button();
            dtpngaylapthe = new DateTimePicker();
            txtsdt = new TextBox();
            txttendocgia = new TextBox();
            txtIDAccount = new TextBox();
            label1 = new Label();
            txtemail = new TextBox();
            txtmadocgia = new TextBox();
            label11 = new Label();
            txtdiachi = new TextBox();
            label10 = new Label();
            label2 = new Label();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbxLoaidocgia1 = new ComboBox();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            grdDocgia = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdDocgia).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemdocgia
            // 
            btnThemdocgia.FlatAppearance.BorderSize = 0;
            btnThemdocgia.FlatStyle = FlatStyle.Flat;
            btnThemdocgia.Image = (Image)resources.GetObject("btnThemdocgia.Image");
            btnThemdocgia.Location = new Point(1520, 35);
            btnThemdocgia.Name = "btnThemdocgia";
            btnThemdocgia.Size = new Size(94, 60);
            btnThemdocgia.TabIndex = 7;
            btnThemdocgia.UseVisualStyleBackColor = true;
            btnThemdocgia.Click += btnThemdocgia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbxloaidocgia);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(dtpngayhethan);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtpngaylapthe);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txttendocgia);
            groupBox1.Controls.Add(txtIDAccount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtmadocgia);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(929, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 720);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin độc giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLichsumuontra);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(39, 409);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 250);
            groupBox2.TabIndex = 163;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch sử mượn trả";
            // 
            // dgvLichsumuontra
            // 
            dgvLichsumuontra.AllowUserToAddRows = false;
            dgvLichsumuontra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichsumuontra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichsumuontra.Location = new Point(22, 43);
            dgvLichsumuontra.Name = "dgvLichsumuontra";
            dgvLichsumuontra.ReadOnly = true;
            dgvLichsumuontra.RowHeadersWidth = 51;
            dgvLichsumuontra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichsumuontra.Size = new Size(585, 182);
            dgvLichsumuontra.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(10, 71);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 162;
            label5.Text = "Mã độc giả";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(10, 358);
            label12.Name = "label12";
            label12.Size = new Size(60, 28);
            label12.TabIndex = 161;
            label12.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(10, 286);
            label13.Name = "label13";
            label13.Size = new Size(73, 28);
            label13.TabIndex = 160;
            label13.Text = "Địa chỉ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(10, 213);
            label14.Name = "label14";
            label14.Size = new Size(103, 28);
            label14.TabIndex = 159;
            label14.Text = "Ngày sinh";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(10, 141);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 158;
            label15.Text = "Tên độc giả";
            // 
            // cbxloaidocgia
            // 
            cbxloaidocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxloaidocgia.FormattingEnabled = true;
            cbxloaidocgia.Location = new Point(492, 210);
            cbxloaidocgia.Name = "cbxloaidocgia";
            cbxloaidocgia.Size = new Size(185, 36);
            cbxloaidocgia.TabIndex = 157;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(483, 665);
            button3.Name = "button3";
            button3.Size = new Size(45, 40);
            button3.TabIndex = 73;
            button3.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpngaysinh.Format = DateTimePickerFormat.Short;
            dtpngaysinh.Location = new Point(126, 212);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(210, 34);
            dtpngaysinh.TabIndex = 156;
            // 
            // dtpngayhethan
            // 
            dtpngayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpngayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpngayhethan.Format = DateTimePickerFormat.Short;
            dtpngayhethan.Location = new Point(492, 140);
            dtpngayhethan.Name = "dtpngayhethan";
            dtpngayhethan.Size = new Size(185, 31);
            dtpngayhethan.TabIndex = 155;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(554, 665);
            button1.Name = "button1";
            button1.Size = new Size(45, 40);
            button1.TabIndex = 71;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpngaylapthe
            // 
            dtpngaylapthe.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpngaylapthe.CustomFormat = "";
            dtpngaylapthe.Font = new Font("Segoe UI", 10.8F);
            dtpngaylapthe.Format = DateTimePickerFormat.Short;
            dtpngaylapthe.Location = new Point(492, 70);
            dtpngaylapthe.Name = "dtpngaylapthe";
            dtpngaylapthe.Size = new Size(185, 31);
            dtpngaylapthe.TabIndex = 154;
            // 
            // txtsdt
            // 
            txtsdt.BorderStyle = BorderStyle.FixedSingle;
            txtsdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtsdt.Location = new Point(492, 352);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(185, 34);
            txtsdt.TabIndex = 153;
            // 
            // txttendocgia
            // 
            txttendocgia.BorderStyle = BorderStyle.FixedSingle;
            txttendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttendocgia.Location = new Point(126, 141);
            txttendocgia.Name = "txttendocgia";
            txttendocgia.Size = new Size(210, 34);
            txttendocgia.TabIndex = 141;
            // 
            // txtIDAccount
            // 
            txtIDAccount.BorderStyle = BorderStyle.FixedSingle;
            txtIDAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDAccount.Location = new Point(492, 282);
            txtIDAccount.Name = "txtIDAccount";
            txtIDAccount.Size = new Size(185, 34);
            txtIDAccount.TabIndex = 152;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(-169, 171);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 138;
            label1.Text = "Tên độc giả";
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtemail.Location = new Point(126, 354);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(210, 34);
            txtemail.TabIndex = 151;
            // 
            // txtmadocgia
            // 
            txtmadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtmadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtmadocgia.Location = new Point(126, 70);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(210, 34);
            txtmadocgia.TabIndex = 139;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(-169, 101);
            label11.Name = "label11";
            label11.Size = new Size(112, 28);
            label11.TabIndex = 150;
            label11.Text = "Mã độc giả";
            // 
            // txtdiachi
            // 
            txtdiachi.BorderStyle = BorderStyle.FixedSingle;
            txtdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtdiachi.Location = new Point(126, 283);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(210, 34);
            txtdiachi.TabIndex = 140;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(352, 282);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 149;
            label10.Text = "IDAccount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(-169, 243);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 142;
            label2.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(352, 211);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 148;
            label9.Text = "Loại độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(-169, 316);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 143;
            label3.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(352, 140);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 147;
            label8.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(-169, 388);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 144;
            label4.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(352, 69);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 146;
            label7.Text = "Ngày lập thẻ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(352, 353);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 145;
            label6.Text = "Số điện thoại";
            // 
            // cbxLoaidocgia1
            // 
            cbxLoaidocgia1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaidocgia1.FormattingEnabled = true;
            cbxLoaidocgia1.Location = new Point(681, 59);
            cbxLoaidocgia1.Name = "cbxLoaidocgia1";
            cbxLoaidocgia1.Size = new Size(181, 36);
            cbxLoaidocgia1.TabIndex = 11;
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(881, 46);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(72, 49);
            btnTimkiem.TabIndex = 10;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(130, 59);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(520, 34);
            txtTimkiem.TabIndex = 9;
            // 
            // grdDocgia
            // 
            grdDocgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDocgia.Location = new Point(130, 134);
            grdDocgia.Name = "grdDocgia";
            grdDocgia.RowHeadersWidth = 51;
            grdDocgia.Size = new Size(730, 775);
            grdDocgia.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnLast);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Location = new Point(591, 922);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 78);
            groupBox3.TabIndex = 13;
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
            // 
            // btnLast
            // 
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(213, 26);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(53, 46);
            btnLast.TabIndex = 76;
            btnLast.UseVisualStyleBackColor = true;
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
            btnFirst.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(619, 665);
            button4.Name = "button4";
            button4.Size = new Size(45, 40);
            button4.TabIndex = 165;
            button4.UseVisualStyleBackColor = true;
            // 
            // ucDocgiathuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(cbxLoaidocgia1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(grdDocgia);
            Controls.Add(btnThemdocgia);
            Name = "ucDocgiathuthu";
            Size = new Size(1650, 1000);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdDocgia).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemdocgia;
        private GroupBox groupBox1;
        private Button button3;
        private Button button1;
        private DataGridView dgvLichsumuontra;
        private ComboBox cbxLoaidocgia1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private DataGridView grdDocgia;
        private ComboBox cbxloaidocgia;
        private DateTimePicker dtpngaysinh;
        private DateTimePicker dtpngayhethan;
        private DateTimePicker dtpngaylapthe;
        private TextBox txtsdt;
        private TextBox txttendocgia;
        private TextBox txtIDAccount;
        private Label label1;
        private TextBox txtemail;
        private TextBox txtmadocgia;
        private Label label11;
        private TextBox txtdiachi;
        private Label label10;
        private Label label2;
        private Label label9;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private Label label5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private Button button4;
    }
}
