namespace QLTVNhom3
{
    partial class ucTacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTacgia));
            groupBox3 = new GroupBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnEnd = new Button();
            btnFirst = new Button();
            groupBox1 = new GroupBox();
            txtHovaten = new TextBox();
            groupBox2 = new GroupBox();
            grdSach = new DataGridView();
            btnUndo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            dtpNamsinhtacgia = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            txtMatacgia = new TextBox();
            label1 = new Label();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            grdTacgia = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnEnd);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Location = new Point(531, 887);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 100);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(75, 26);
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
            btnNext.Location = new Point(146, 26);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 40);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            btnEnd.FlatAppearance.BorderSize = 0;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Image = (Image)resources.GetObject("btnEnd.Image");
            btnEnd.Location = new Point(201, 23);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHovaten);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnUndo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(dtpNamsinhtacgia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatacgia);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(962, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 756);
            groupBox1.TabIndex = 86;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHovaten.Location = new Point(176, 131);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(326, 34);
            txtHovaten.TabIndex = 75;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grdSach);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(74, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 371);
            groupBox2.TabIndex = 74;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sách của tác giả";
            // 
            // grdSach
            // 
            grdSach.AllowUserToAddRows = false;
            grdSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSach.Location = new Point(29, 63);
            grdSach.Name = "grdSach";
            grdSach.ReadOnly = true;
            grdSach.RowHeadersWidth = 51;
            grdSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSach.Size = new Size(390, 270);
            grdSach.TabIndex = 68;
            // 
            // btnUndo
            // 
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(393, 688);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(45, 40);
            btnUndo.TabIndex = 73;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(509, 688);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(45, 40);
            btnLuu.TabIndex = 72;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(448, 688);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(45, 40);
            btnXoa.TabIndex = 71;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtpNamsinhtacgia
            // 
            dtpNamsinhtacgia.CustomFormat = "yyyy";
            dtpNamsinhtacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNamsinhtacgia.Format = DateTimePickerFormat.Custom;
            dtpNamsinhtacgia.Location = new Point(176, 189);
            dtpNamsinhtacgia.Name = "dtpNamsinhtacgia";
            dtpNamsinhtacgia.ShowUpDown = true;
            dtpNamsinhtacgia.Size = new Size(118, 34);
            dtpNamsinhtacgia.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 189);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 65;
            label4.Text = "Năm sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 131);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 63;
            label2.Text = "Họ và tên";
            // 
            // txtMatacgia
            // 
            txtMatacgia.BorderStyle = BorderStyle.FixedSingle;
            txtMatacgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtMatacgia.Location = new Point(176, 82);
            txtMatacgia.Name = "txtMatacgia";
            txtMatacgia.Size = new Size(326, 34);
            txtMatacgia.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 82);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 60;
            label1.Text = "Mã tác giả";
            // 
            // btnTimkiem
            // 
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.Location = new Point(728, 61);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(72, 49);
            btnTimkiem.TabIndex = 85;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(164, 61);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(520, 34);
            txtTimkiem.TabIndex = 84;
            // 
            // grdTacgia
            // 
            grdTacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTacgia.Location = new Point(70, 136);
            grdTacgia.Name = "grdTacgia";
            grdTacgia.RowHeadersWidth = 51;
            grdTacgia.Size = new Size(730, 724);
            grdTacgia.TabIndex = 83;
            // 
            // ucTacgia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(grdTacgia);
            Controls.Add(groupBox3);
            Name = "ucTacgia";
            Size = new Size(1650, 1000);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdTacgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridViewTextBoxColumn namsinh;
        private Button button7;
        private Button button6;
        private Button button4;
        private GroupBox groupBox3;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnEnd;
        private Button btnFirst;
        private GroupBox groupBox1;
        private TextBox txtHovaten;
        private GroupBox groupBox2;
        private DataGridView grdSach;
        private Button btnUndo;
        private Button btnLuu;
        private Button btnXoa;
        private DateTimePicker dtpNamsinhtacgia;
        private Label label4;
        private Label label2;
        private TextBox txtMatacgia;
        private Label label1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private DataGridView grdTacgia;
    }
}
