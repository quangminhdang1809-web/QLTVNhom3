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
            txtTimkiem = new TextBox();
            grdSach = new DataGridView();
            groupBox1 = new GroupBox();
            btnXemphieumuon = new Button();
            groupBox3 = new GroupBox();
            grdThongtinsachmuon = new DataGridView();
            groupBox2 = new GroupBox();
            dtpNgayhethan = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            label15 = new Label();
            txtTendocgia = new TextBox();
            txtMadocgia = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            drgTimkiemsach = new DataGridView();
            cbxTheloaisach = new ComboBox();
            btnTimkiem = new Button();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).BeginInit();
            SuspendLayout();
            // 
<<<<<<< HEAD
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(2189, 78);
            comboBox1.Margin = new Padding(5, 5, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 53);
            comboBox1.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(2449, 56);
            btnTimkiem.Margin = new Padding(5, 5, 5, 5);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(110, 78);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            txtTimkiem.Location = new Point(1373, 80);
            txtTimkiem.Margin = new Padding(5, 5, 5, 5);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(785, 50);
=======
            txtTimkiem.Location = new Point(25, 64);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(1123, 34);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            txtTimkiem.TabIndex = 6;
            // 
            // grdSach
            // 
<<<<<<< HEAD
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1370, 192);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1186, 1158);
            dataGridView1.TabIndex = 5;
=======
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Location = new Point(30, 115);
            grdSach.Name = "grdSach";
            grdSach.RowHeadersWidth = 51;
            grdSach.Size = new Size(598, 249);
            grdSach.TabIndex = 5;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(btnXemphieumuon);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(112, 56);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1060, 1496);
=======
            groupBox1.Size = new Size(1508, 935);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mượn sách";
            // 
            // btnXemphieumuon
            // 
<<<<<<< HEAD
            btnluu.BackColor = SystemColors.Highlight;
            btnluu.FlatAppearance.BorderSize = 0;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnluu.ForeColor = Color.White;
            btnluu.Location = new Point(791, 1408);
            btnluu.Margin = new Padding(5, 5, 5, 5);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(236, 61);
            btnluu.TabIndex = 141;
            btnluu.Text = "Xác nhận";
            btnluu.UseVisualStyleBackColor = false;
=======
            btnXemphieumuon.BackColor = SystemColors.Highlight;
            btnXemphieumuon.FlatAppearance.BorderSize = 0;
            btnXemphieumuon.FlatStyle = FlatStyle.Flat;
            btnXemphieumuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXemphieumuon.ForeColor = Color.White;
            btnXemphieumuon.Location = new Point(1280, 878);
            btnXemphieumuon.Name = "btnXemphieumuon";
            btnXemphieumuon.Size = new Size(210, 38);
            btnXemphieumuon.TabIndex = 141;
            btnXemphieumuon.Text = "Xem phiếu mượn";
            btnXemphieumuon.UseVisualStyleBackColor = false;
            btnXemphieumuon.Click += btnXacnhan_Click;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(drgTimkiemsach);
            groupBox3.Controls.Add(grdThongtinsachmuon);
            groupBox3.Controls.Add(cbxTheloaisach);
            groupBox3.Controls.Add(btnTimkiem);
            groupBox3.Controls.Add(txtTimkiem);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            groupBox3.Location = new Point(49, 869);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(925, 498);
=======
            groupBox3.Location = new Point(30, 437);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1421, 435);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            // 
            // grdThongtinsachmuon
            // 
<<<<<<< HEAD
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(28, 62);
            dataGridView2.Margin = new Padding(5, 5, 5, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(853, 386);
            dataGridView2.TabIndex = 0;
=======
            grdThongtinsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtinsachmuon.Location = new Point(25, 117);
            grdThongtinsachmuon.Name = "grdThongtinsachmuon";
            grdThongtinsachmuon.RowHeadersWidth = 51;
            grdThongtinsachmuon.Size = new Size(1371, 299);
            grdThongtinsachmuon.TabIndex = 0;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
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
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            groupBox2.Location = new Point(49, 91);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(925, 718);
=======
            groupBox2.Location = new Point(30, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(652, 383);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // dtpNgayhethan
            // 
<<<<<<< HEAD
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(28, 613);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 45);
            label1.TabIndex = 175;
            label1.Text = "Thông báo";
            // 
            // txtsdt
            // 
            txtsdt.BorderStyle = BorderStyle.FixedSingle;
            txtsdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtsdt.Location = new Point(276, 496);
            txtsdt.Margin = new Padding(5, 5, 5, 5);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(569, 50);
            txtsdt.TabIndex = 174;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(28, 496);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(212, 45);
            label6.TabIndex = 173;
            label6.Text = "Số điện thoại";
            // 
            // dtpngayhethan
            // 
            dtpngayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpngayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpngayhethan.Format = DateTimePickerFormat.Short;
            dtpngayhethan.Location = new Point(276, 390);
            dtpngayhethan.Margin = new Padding(5, 5, 5, 5);
            dtpngayhethan.Name = "dtpngayhethan";
            dtpngayhethan.Size = new Size(298, 46);
            dtpngayhethan.TabIndex = 170;
            // 
            // dtpngaylapthe
            // 
            dtpngaylapthe.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpngaylapthe.CustomFormat = "";
            dtpngaylapthe.Font = new Font("Segoe UI", 10.8F);
            dtpngaylapthe.Format = DateTimePickerFormat.Short;
            dtpngaylapthe.Location = new Point(276, 290);
            dtpngaylapthe.Margin = new Padding(5, 5, 5, 5);
            dtpngaylapthe.Name = "dtpngaylapthe";
            dtpngaylapthe.Size = new Size(298, 46);
            dtpngaylapthe.TabIndex = 169;
=======
            dtpNgayhethan.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgayhethan.Font = new Font("Segoe UI", 10.8F);
            dtpNgayhethan.Format = DateTimePickerFormat.Short;
            dtpNgayhethan.Location = new Point(172, 177);
            dtpNgayhethan.Name = "dtpNgayhethan";
            dtpNgayhethan.Size = new Size(185, 31);
            dtpNgayhethan.TabIndex = 170;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
<<<<<<< HEAD
            label8.Location = new Point(28, 395);
            label8.Margin = new Padding(5, 0, 5, 0);
=======
            label8.Location = new Point(19, 180);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            label8.Name = "label8";
            label8.Size = new Size(218, 45);
            label8.TabIndex = 168;
            label8.Text = "Ngày hết hạn";
            // 
<<<<<<< HEAD
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(28, 290);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(207, 45);
            label7.TabIndex = 167;
            label7.Text = "Ngày lập thẻ";
            // 
=======
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
<<<<<<< HEAD
            label5.Location = new Point(28, 78);
            label5.Margin = new Padding(5, 0, 5, 0);
=======
            label5.Location = new Point(19, 43);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            label5.Name = "label5";
            label5.Size = new Size(182, 45);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
<<<<<<< HEAD
            label15.Location = new Point(28, 184);
            label15.Margin = new Padding(5, 0, 5, 0);
=======
            label15.Location = new Point(19, 109);
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            label15.Name = "label15";
            label15.Size = new Size(186, 45);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
<<<<<<< HEAD
            txttendocgia.BorderStyle = BorderStyle.FixedSingle;
            txttendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttendocgia.Location = new Point(276, 184);
            txttendocgia.Margin = new Padding(5, 5, 5, 5);
            txttendocgia.Name = "txttendocgia";
            txttendocgia.Size = new Size(569, 50);
            txttendocgia.TabIndex = 164;
=======
            txtTendocgia.BorderStyle = BorderStyle.FixedSingle;
            txtTendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTendocgia.Location = new Point(172, 109);
            txtTendocgia.Name = "txtTendocgia";
            txtTendocgia.Size = new Size(351, 34);
            txtTendocgia.TabIndex = 164;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // 
            // txtMadocgia
            // 
<<<<<<< HEAD
            txtmadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtmadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtmadocgia.Location = new Point(276, 78);
            txtmadocgia.Margin = new Padding(5, 5, 5, 5);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(569, 50);
            txtmadocgia.TabIndex = 163;
=======
            txtMadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtMadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMadocgia.Location = new Point(172, 43);
            txtMadocgia.Name = "txtMadocgia";
            txtMadocgia.Size = new Size(351, 34);
            txtMadocgia.TabIndex = 163;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(30, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 65);
            groupBox4.TabIndex = 172;
            groupBox4.TabStop = false;
            groupBox4.Enter += groupBox4_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(grdSach);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.Location = new Point(805, 47);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(646, 384);
            groupBox5.TabIndex = 173;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách đã đăng kí mượn";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(486, 30);
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
            label3.Location = new Point(200, 30);
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
            label2.Location = new Point(347, 30);
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
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 4;
            label1.Text = "Đang mượn:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(19, 241);
            label6.Name = "label6";
            label6.Size = new Size(482, 56);
            label6.TabIndex = 171;
            label6.Text = "Thông báo thẻ quá hạn, sách mượn quá số lượng,\r\n sách quá hạn";
            // 
            // drgTimkiemsach
            // 
            drgTimkiemsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgTimkiemsach.Location = new Point(25, 104);
            drgTimkiemsach.Name = "drgTimkiemsach";
            drgTimkiemsach.RowHeadersWidth = 51;
            drgTimkiemsach.Size = new Size(1123, 299);
            drgTimkiemsach.TabIndex = 9;
            drgTimkiemsach.Visible = false;
            // 
            // cbxTheloaisach
            // 
            cbxTheloaisach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheloaisach.FormattingEnabled = true;
            cbxTheloaisach.Location = new Point(1176, 62);
            cbxTheloaisach.Name = "cbxTheloaisach";
            cbxTheloaisach.Size = new Size(139, 36);
            cbxTheloaisach.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(1327, 49);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(68, 49);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.UseVisualStyleBackColor = true;
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            // 
            // ucMuonsachthuthu
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(groupBox1);
<<<<<<< HEAD
            Controls.Add(comboBox1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(dataGridView1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ucMuonsachthuthu";
            Size = new Size(2681, 1600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
=======
            Name = "ucMuonsachthuthu";
            Size = new Size(1650, 1000);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
>>>>>>> c95b45b514b7d1b0be4890ee53d1654e103b3e1e
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drgTimkiemsach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimkiem;
        private DataGridView grdSach;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label15;
        private TextBox txtTendocgia;
        private TextBox txtMadocgia;
        private DateTimePicker dtpNgayhethan;
        private Label label8;
        private GroupBox groupBox3;
        private DataGridView grdThongtinsachmuon;
        private Button btnXemphieumuon;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView drgTimkiemsach;
        private ComboBox cbxTheloaisach;
        private Label label6;
        private Button btnTimkiem;
    }
}
