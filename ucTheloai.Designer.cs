namespace QLTVNhom3
{
    partial class ucTheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTheloai));
            groupBox2 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnFirst = new Button();
            btnThemtheloai = new Button();
            groupBox1 = new GroupBox();
            txtMota = new TextBox();
            txtTentheloai = new TextBox();
            btnUndo = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label4 = new Label();
            label2 = new Label();
            txtMatheloai = new TextBox();
            label1 = new Label();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            grdTheloai = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(btnLast);
            groupBox2.Controls.Add(btnFirst);
            groupBox2.Location = new Point(517, 897);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 85);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
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
            btnFirst.Click += btnFirst_Click;
            // 
            // btnThemtheloai
            // 
            btnThemtheloai.FlatAppearance.BorderSize = 0;
            btnThemtheloai.FlatStyle = FlatStyle.Flat;
            btnThemtheloai.Image = (Image)resources.GetObject("btnThemtheloai.Image");
            btnThemtheloai.Location = new Point(1437, 51);
            btnThemtheloai.Name = "btnThemtheloai";
            btnThemtheloai.Size = new Size(72, 49);
            btnThemtheloai.TabIndex = 17;
            btnThemtheloai.UseVisualStyleBackColor = true;
            btnThemtheloai.Click += btnThemtheloai_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMota);
            groupBox1.Controls.Add(txtTentheloai);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatheloai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(953, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 489);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại";
            // 
            // txtMota
            // 
            txtMota.BorderStyle = BorderStyle.FixedSingle;
            txtMota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMota.Location = new Point(146, 262);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(326, 34);
            txtMota.TabIndex = 76;
            // 
            // txtTentheloai
            // 
            txtTentheloai.BorderStyle = BorderStyle.FixedSingle;
            txtTentheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTentheloai.Location = new Point(146, 185);
            txtTentheloai.Name = "txtTentheloai";
            txtTentheloai.Size = new Size(326, 34);
            txtTentheloai.TabIndex = 75;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(369, 430);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(433, 430);
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
            btnXoa.Location = new Point(484, 430);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 268);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 65;
            label4.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 188);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 63;
            label2.Text = "Tên thể loại";
            // 
            // txtMatheloai
            // 
            txtMatheloai.BorderStyle = BorderStyle.FixedSingle;
            txtMatheloai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatheloai.Location = new Point(146, 108);
            txtMatheloai.Name = "txtMatheloai";
            txtMatheloai.Size = new Size(326, 34);
            txtMatheloai.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 108);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã thể loại";
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(725, 66);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(72, 49);
            btnTimkiem.TabIndex = 20;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(156, 66);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(520, 34);
            txtTimkiem.TabIndex = 19;
            // 
            // grdTheloai
            // 
            grdTheloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTheloai.Location = new Point(67, 141);
            grdTheloai.Name = "grdTheloai";
            grdTheloai.RowHeadersWidth = 51;
            grdTheloai.Size = new Size(730, 724);
            grdTheloai.TabIndex = 18;
            // 
            // ucTheloai
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(grdTheloai);
            Controls.Add(btnThemtheloai);
            Controls.Add(groupBox2);
            Name = "ucTheloai";
            Size = new Size(1650, 1000);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTheloai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Button btnFirst;
        private Button btnThemtheloai;
        private GroupBox groupBox1;
        private TextBox txtMota;
        private TextBox txtTentheloai;
        private Button btnUndo;
        private Button btnSua;
        private Button btnXoa;
        private Label label4;
        private Label label2;
        private TextBox txtMatheloai;
        private Label label1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private DataGridView grdTheloai;
    }
}
