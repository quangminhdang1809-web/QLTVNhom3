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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dtpnamxb = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            txttensach = new TextBox();
            label1 = new Label();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtpnamxb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttensach);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(1022, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 756);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(176, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 34);
            textBox1.TabIndex = 75;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(74, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 371);
            groupBox2.TabIndex = 74;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sách của tác giả";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(29, 63);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(390, 270);
            dgvSach.TabIndex = 68;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(393, 688);
            button3.Name = "button3";
            button3.Size = new Size(45, 40);
            button3.TabIndex = 73;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(509, 688);
            button2.Name = "button2";
            button2.Size = new Size(45, 40);
            button2.TabIndex = 72;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(448, 688);
            button1.Name = "button1";
            button1.Size = new Size(45, 40);
            button1.TabIndex = 71;
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpnamxb
            // 
            dtpnamxb.CustomFormat = "yyyy";
            dtpnamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpnamxb.Format = DateTimePickerFormat.Custom;
            dtpnamxb.Location = new Point(176, 189);
            dtpnamxb.Name = "dtpnamxb";
            dtpnamxb.ShowUpDown = true;
            dtpnamxb.Size = new Size(118, 34);
            dtpnamxb.TabIndex = 66;
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
            // txttensach
            // 
            txttensach.BorderStyle = BorderStyle.FixedSingle;
            txttensach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttensach.Location = new Point(176, 82);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(326, 34);
            txttensach.TabIndex = 61;
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
            btnTimkiem.Location = new Point(788, 59);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(72, 49);
            btnTimkiem.TabIndex = 8;
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(224, 59);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(520, 34);
            txtTimkiem.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(130, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(730, 724);
            dataGridView1.TabIndex = 6;
            // 
            // ucTacgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(dataGridView1);
            Name = "ucTacgia";
            Size = new Size(1650, 1000);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dtpnamxb;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn tentacgia;
        private DataGridViewTextBoxColumn namsinh;
        private TextBox txttensach;
        private Button button7;
        private Button button6;
        private Button button4;
    }
}
