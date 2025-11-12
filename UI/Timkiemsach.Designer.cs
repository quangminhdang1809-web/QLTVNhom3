namespace QLTVNhom3
{
    partial class Timkiemsach
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemsach));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTimtheo = new Label();
            lblTimkiemsach = new Label();
            txtTimsach = new TextBox();
            dgvHienthisach = new DataGridView();
            clmTensach = new DataGridViewTextBoxColumn();
            clmAnhbia = new DataGridViewTextBoxColumn();
            clmNamxb = new DataGridViewTextBoxColumn();
            clmNXB = new DataGridViewTextBoxColumn();
            clmTacgia = new DataGridViewTextBoxColumn();
            clmSoluong = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnTimkiem = new Button();
            cbxLocsach = new ComboBox();
            panel3 = new Panel();
            label10 = new Label();
            btnRefresh = new Button();
            lblSoluong = new Label();
            label8 = new Label();
            label7 = new Label();
            lblVitri = new Label();
            lblNamxuatban = new Label();
            label4 = new Label();
            lblTacgia = new Label();
            label2 = new Label();
            lblTensach = new Label();
            pbAnhbia = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienthisach).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2098, 1337);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33555F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0016689F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.66278F));
            tableLayoutPanel1.Controls.Add(lblTimtheo, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTimkiemsach, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTimsach, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvHienthisach, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 2, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 5);
            tableLayoutPanel1.Controls.Add(pbAnhbia, 2, 2);
            tableLayoutPanel1.Location = new Point(44, 108);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.289204F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2994347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844906F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.847457647F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5894547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844906F));
            tableLayoutPanel1.Size = new Size(1978, 1062);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // lblTimtheo
            // 
            lblTimtheo.AutoSize = true;
            lblTimtheo.Dock = DockStyle.Top;
            lblTimtheo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTimtheo.Location = new Point(1157, 0);
            lblTimtheo.Margin = new Padding(4, 0, 4, 0);
            lblTimtheo.Name = "lblTimtheo";
            lblTimtheo.Size = new Size(817, 45);
            lblTimtheo.TabIndex = 3;
            lblTimtheo.Text = "Tìm theo";
            lblTimtheo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTimkiemsach
            // 
            lblTimkiemsach.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTimkiemsach, 2);
            lblTimkiemsach.Dock = DockStyle.Top;
            lblTimkiemsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTimkiemsach.Location = new Point(4, 0);
            lblTimkiemsach.Margin = new Padding(4, 0, 4, 0);
            lblTimkiemsach.Name = "lblTimkiemsach";
            lblTimkiemsach.Size = new Size(1145, 45);
            lblTimkiemsach.TabIndex = 0;
            lblTimkiemsach.Text = "Tìm kiếm sách";
            lblTimkiemsach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTimsach
            // 
            txtTimsach.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txtTimsach, 2);
            txtTimsach.Dock = DockStyle.Fill;
            txtTimsach.Font = new Font("Segoe UI", 12F);
            txtTimsach.ForeColor = SystemColors.ScrollBar;
            txtTimsach.Location = new Point(4, 102);
            txtTimsach.Margin = new Padding(4);
            txtTimsach.Name = "txtTimsach";
            txtTimsach.Size = new Size(1145, 50);
            txtTimsach.TabIndex = 1;
            txtTimsach.Text = "Khám phá 50.000+ đầu sách tại NEU Lib";
            // 
            // dgvHienthisach
            // 
            dgvHienthisach.AllowUserToAddRows = false;
            dgvHienthisach.AllowUserToDeleteRows = false;
            dgvHienthisach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHienthisach.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHienthisach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHienthisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienthisach.Columns.AddRange(new DataGridViewColumn[] { clmTensach, clmAnhbia, clmNamxb, clmNXB, clmTacgia, clmSoluong });
            tableLayoutPanel1.SetColumnSpan(dgvHienthisach, 2);
            dgvHienthisach.EnableHeadersVisualStyles = false;
            dgvHienthisach.Location = new Point(4, 222);
            dgvHienthisach.Margin = new Padding(4);
            dgvHienthisach.Name = "dgvHienthisach";
            dgvHienthisach.ReadOnly = true;
            dgvHienthisach.RowHeadersWidth = 62;
            tableLayoutPanel1.SetRowSpan(dgvHienthisach, 5);
            dgvHienthisach.Size = new Size(1145, 836);
            dgvHienthisach.TabIndex = 4;
            // 
            // clmTensach
            // 
            clmTensach.HeaderText = "Tên sách";
            clmTensach.MinimumWidth = 8;
            clmTensach.Name = "clmTensach";
            clmTensach.ReadOnly = true;
            clmTensach.Width = 150;
            // 
            // clmAnhbia
            // 
            clmAnhbia.HeaderText = "Ảnh bìa";
            clmAnhbia.MinimumWidth = 8;
            clmAnhbia.Name = "clmAnhbia";
            clmAnhbia.ReadOnly = true;
            clmAnhbia.Width = 150;
            // 
            // clmNamxb
            // 
            clmNamxb.HeaderText = "Năm xuất bản";
            clmNamxb.MinimumWidth = 8;
            clmNamxb.Name = "clmNamxb";
            clmNamxb.ReadOnly = true;
            clmNamxb.Width = 150;
            // 
            // clmNXB
            // 
            clmNXB.HeaderText = "NXB";
            clmNXB.MinimumWidth = 8;
            clmNXB.Name = "clmNXB";
            clmNXB.ReadOnly = true;
            clmNXB.Width = 150;
            // 
            // clmTacgia
            // 
            clmTacgia.HeaderText = "Tác giả";
            clmTacgia.MinimumWidth = 8;
            clmTacgia.Name = "clmTacgia";
            clmTacgia.ReadOnly = true;
            clmTacgia.Width = 150;
            // 
            // clmSoluong
            // 
            clmSoluong.HeaderText = "Số lượng";
            clmSoluong.MinimumWidth = 8;
            clmSoluong.Name = "clmSoluong";
            clmSoluong.ReadOnly = true;
            clmSoluong.Width = 150;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTimkiem);
            panel2.Controls.Add(cbxLocsach);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1243, 102);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 112);
            panel2.TabIndex = 5;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackgroundImage = (Image)resources.GetObject("btnTimkiem.BackgroundImage");
            btnTimkiem.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.ImageAlign = ContentAlignment.TopLeft;
            btnTimkiem.Location = new Point(346, 0);
            btnTimkiem.Margin = new Padding(4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(58, 58);
            btnTimkiem.TabIndex = 4;
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // cbxLocsach
            // 
            cbxLocsach.Font = new Font("Segoe UI", 12F);
            cbxLocsach.FormattingEnabled = true;
            cbxLocsach.Location = new Point(0, 0);
            cbxLocsach.Margin = new Padding(4);
            cbxLocsach.Name = "cbxLocsach";
            cbxLocsach.Size = new Size(302, 53);
            cbxLocsach.TabIndex = 2;
            cbxLocsach.SelectedIndexChanged += cbxLocsach_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(lblSoluong);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblVitri);
            panel3.Controls.Add(lblNamxuatban);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblTacgia);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblTensach);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 10F);
            panel3.Location = new Point(1157, 618);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(817, 440);
            panel3.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(332, 292);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(122, 45);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(610, 349);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(203, 87);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSoluong.Location = new Point(86, 292);
            lblSoluong.Margin = new Padding(4, 0, 4, 0);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new Size(156, 45);
            lblSoluong.TabIndex = 8;
            lblSoluong.Text = "Số lượng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(332, 218);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 45);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(332, 157);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 45);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // lblVitri
            // 
            lblVitri.AutoSize = true;
            lblVitri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVitri.Location = new Point(86, 218);
            lblVitri.Margin = new Padding(4, 0, 4, 0);
            lblVitri.Name = "lblVitri";
            lblVitri.Size = new Size(102, 45);
            lblVitri.TabIndex = 5;
            lblVitri.Text = "Vị trí ";
            // 
            // lblNamxuatban
            // 
            lblNamxuatban.AutoSize = true;
            lblNamxuatban.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNamxuatban.Location = new Point(86, 157);
            lblNamxuatban.Margin = new Padding(4, 0, 4, 0);
            lblNamxuatban.Name = "lblNamxuatban";
            lblNamxuatban.Size = new Size(231, 45);
            lblNamxuatban.TabIndex = 4;
            lblNamxuatban.Text = "Năm xuất bản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(332, 96);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 45);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // lblTacgia
            // 
            lblTacgia.AutoSize = true;
            lblTacgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTacgia.Location = new Point(86, 96);
            lblTacgia.Margin = new Padding(4, 0, 4, 0);
            lblTacgia.Name = "lblTacgia";
            lblTacgia.Size = new Size(123, 45);
            lblTacgia.TabIndex = 2;
            lblTacgia.Text = "Tác giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(332, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 45);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lblTensach
            // 
            lblTensach.AutoSize = true;
            lblTensach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTensach.Location = new Point(86, 35);
            lblTensach.Margin = new Padding(4, 0, 4, 0);
            lblTensach.Name = "lblTensach";
            lblTensach.Size = new Size(146, 45);
            lblTensach.TabIndex = 0;
            lblTensach.Text = "Tên sách";
            // 
            // pbAnhbia
            // 
            pbAnhbia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pbAnhbia.BackColor = SystemColors.ButtonShadow;
            pbAnhbia.ErrorImage = (Image)resources.GetObject("pbAnhbia.ErrorImage");
            pbAnhbia.Location = new Point(1414, 222);
            pbAnhbia.Margin = new Padding(4);
            pbAnhbia.Name = "pbAnhbia";
            tableLayoutPanel1.SetRowSpan(pbAnhbia, 3);
            pbAnhbia.Size = new Size(302, 388);
            pbAnhbia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnhbia.TabIndex = 6;
            pbAnhbia.TabStop = false;
            // 
            // Timkiemsach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Timkiemsach";
            Size = new Size(2098, 1337);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienthisach).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhbia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimkiem;
        private Label lblTimtheo;
        private ComboBox cbxLocsach;
        private TextBox txtTimsach;
        private Label lblTimkiemsach;
        private Button btnRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvHienthisach;
        private Panel panel2;
        private DataGridViewTextBoxColumn clmTensach;
        private DataGridViewTextBoxColumn clmAnhbia;
        private DataGridViewTextBoxColumn clmNamxb;
        private DataGridViewTextBoxColumn clmNXB;
        private DataGridViewTextBoxColumn clmTacgia;
        private DataGridViewTextBoxColumn clmSoluong;
        private PictureBox pbAnhbia;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label lblVitri;
        private Label lblNamxuatban;
        private Label label4;
        private Label lblTacgia;
        private Label label2;
        private Label lblTensach;
        private Label label10;
        private Label lblSoluong;
    }
}
