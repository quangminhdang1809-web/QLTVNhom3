namespace QLTVNhom3
{
    partial class Lichsumuonsach
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLichsumuon = new Label();
            dgvLichsumuon = new DataGridView();
            clmMaphieumuon = new DataGridViewTextBoxColumn();
            clmNgaymuon = new DataGridViewTextBoxColumn();
            clmNgaytra = new DataGridViewTextBoxColumn();
            clmTrangthai = new DataGridViewTextBoxColumn();
            clmTensach = new DataGridViewTextBoxColumn();
            clmNXB = new DataGridViewTextBoxColumn();
            clmTacgia = new DataGridViewTextBoxColumn();
            lblSosachmuon = new Label();
            txtSosachmuon = new TextBox();
            lblThongke = new Label();
            lblChitietphat = new Label();
            dgvChitietphat = new DataGridView();
            clmNgayphat = new DataGridViewTextBoxColumn();
            clmSachtre = new DataGridViewTextBoxColumn();
            clmSongaytre = new DataGridViewTextBoxColumn();
            clmSotienphat = new DataGridViewTextBoxColumn();
            lblPhat = new Label();
            txtPhat = new TextBox();
            lblTratre = new Label();
            txtTratre = new TextBox();
            lblSachdangmuon = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitietphat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 847);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblLichsumuon, 1, 5);
            tableLayoutPanel1.Controls.Add(dgvLichsumuon, 1, 5);
            tableLayoutPanel1.Controls.Add(lblSosachmuon, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSosachmuon, 1, 1);
            tableLayoutPanel1.Controls.Add(lblThongke, 1, 0);
            tableLayoutPanel1.Controls.Add(lblChitietphat, 3, 0);
            tableLayoutPanel1.Controls.Add(dgvChitietphat, 2, 1);
            tableLayoutPanel1.Controls.Add(lblPhat, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPhat, 1, 4);
            tableLayoutPanel1.Controls.Add(lblTratre, 0, 3);
            tableLayoutPanel1.Controls.Add(txtTratre, 1, 3);
            tableLayoutPanel1.Controls.Add(lblSachdangmuon, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(67, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0304146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.015207F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.656159F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.184171F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0190086F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0190086F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.0760345F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(882, 759);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLichsumuon
            // 
            lblLichsumuon.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblLichsumuon, 2);
            lblLichsumuon.Dock = DockStyle.Top;
            lblLichsumuon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLichsumuon.Location = new Point(179, 377);
            lblLichsumuon.Name = "lblLichsumuon";
            lblLichsumuon.Size = new Size(522, 41);
            lblLichsumuon.TabIndex = 1;
            lblLichsumuon.Text = "Lịch sử mượn";
            lblLichsumuon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLichsumuon
            // 
            dgvLichsumuon.AllowUserToAddRows = false;
            dgvLichsumuon.AllowUserToDeleteRows = false;
            dgvLichsumuon.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLichsumuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLichsumuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichsumuon.Columns.AddRange(new DataGridViewColumn[] { clmMaphieumuon, clmNgaymuon, clmNgaytra, clmTrangthai, clmTensach, clmNXB, clmTacgia });
            tableLayoutPanel1.SetColumnSpan(dgvLichsumuon, 4);
            dgvLichsumuon.Dock = DockStyle.Fill;
            dgvLichsumuon.EnableHeadersVisualStyles = false;
            dgvLichsumuon.GridColor = SystemColors.Control;
            dgvLichsumuon.Location = new Point(3, 456);
            dgvLichsumuon.Name = "dgvLichsumuon";
            dgvLichsumuon.ReadOnly = true;
            dgvLichsumuon.RowHeadersWidth = 62;
            dgvLichsumuon.Size = new Size(876, 300);
            dgvLichsumuon.TabIndex = 3;
            // 
            // clmMaphieumuon
            // 
            clmMaphieumuon.HeaderText = "Mã phiếu mượn";
            clmMaphieumuon.MinimumWidth = 8;
            clmMaphieumuon.Name = "clmMaphieumuon";
            clmMaphieumuon.ReadOnly = true;
            clmMaphieumuon.Width = 150;
            // 
            // clmNgaymuon
            // 
            clmNgaymuon.HeaderText = "Ngày mượn";
            clmNgaymuon.MinimumWidth = 8;
            clmNgaymuon.Name = "clmNgaymuon";
            clmNgaymuon.ReadOnly = true;
            clmNgaymuon.Width = 150;
            // 
            // clmNgaytra
            // 
            clmNgaytra.HeaderText = "Ngày trả";
            clmNgaytra.MinimumWidth = 8;
            clmNgaytra.Name = "clmNgaytra";
            clmNgaytra.ReadOnly = true;
            clmNgaytra.Width = 150;
            // 
            // clmTrangthai
            // 
            clmTrangthai.HeaderText = "Trạng thái";
            clmTrangthai.MinimumWidth = 8;
            clmTrangthai.Name = "clmTrangthai";
            clmTrangthai.ReadOnly = true;
            clmTrangthai.Width = 150;
            // 
            // clmTensach
            // 
            clmTensach.HeaderText = "Tên sách";
            clmTensach.MinimumWidth = 8;
            clmTensach.Name = "clmTensach";
            clmTensach.ReadOnly = true;
            clmTensach.Width = 150;
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
            // lblSosachmuon
            // 
            lblSosachmuon.AutoSize = true;
            lblSosachmuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSosachmuon.Location = new Point(3, 121);
            lblSosachmuon.Name = "lblSosachmuon";
            lblSosachmuon.Size = new Size(99, 60);
            lblSosachmuon.TabIndex = 1;
            lblSosachmuon.Text = "Số sách mượn";
            lblSosachmuon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSosachmuon
            // 
            txtSosachmuon.BorderStyle = BorderStyle.FixedSingle;
            txtSosachmuon.Font = new Font("Segoe UI", 12F);
            txtSosachmuon.Location = new Point(179, 124);
            txtSosachmuon.Name = "txtSosachmuon";
            txtSosachmuon.ReadOnly = true;
            txtSosachmuon.Size = new Size(258, 39);
            txtSosachmuon.TabIndex = 2;
            // 
            // lblThongke
            // 
            lblThongke.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblThongke, 2);
            lblThongke.Dock = DockStyle.Top;
            lblThongke.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblThongke.Location = new Point(179, 0);
            lblThongke.Name = "lblThongke";
            lblThongke.Size = new Size(522, 41);
            lblThongke.TabIndex = 0;
            lblThongke.Text = "Thống kê nhanh";
            lblThongke.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChitietphat
            // 
            lblChitietphat.AutoSize = true;
            lblChitietphat.Dock = DockStyle.Left;
            lblChitietphat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChitietphat.Location = new Point(707, 0);
            lblChitietphat.Name = "lblChitietphat";
            lblChitietphat.Size = new Size(153, 121);
            lblChitietphat.TabIndex = 7;
            lblChitietphat.Text = "Chi tiết phạt";
            lblChitietphat.TextAlign = ContentAlignment.BottomCenter;
            lblChitietphat.Visible = false;
            // 
            // dgvChitietphat
            // 
            dgvChitietphat.AllowUserToAddRows = false;
            dgvChitietphat.AllowUserToDeleteRows = false;
            dgvChitietphat.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvChitietphat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChitietphat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChitietphat.Columns.AddRange(new DataGridViewColumn[] { clmNgayphat, clmSachtre, clmSongaytre, clmSotienphat });
            tableLayoutPanel1.SetColumnSpan(dgvChitietphat, 2);
            dgvChitietphat.Dock = DockStyle.Top;
            dgvChitietphat.EnableHeadersVisualStyles = false;
            dgvChitietphat.GridColor = SystemColors.Control;
            dgvChitietphat.Location = new Point(443, 124);
            dgvChitietphat.Name = "dgvChitietphat";
            dgvChitietphat.ReadOnly = true;
            dgvChitietphat.RowHeadersWidth = 62;
            tableLayoutPanel1.SetRowSpan(dgvChitietphat, 4);
            dgvChitietphat.Size = new Size(436, 250);
            dgvChitietphat.TabIndex = 9;
            // 
            // clmNgayphat
            // 
            clmNgayphat.HeaderText = "Ngày phạt";
            clmNgayphat.MinimumWidth = 8;
            clmNgayphat.Name = "clmNgayphat";
            clmNgayphat.ReadOnly = true;
            clmNgayphat.Width = 150;
            // 
            // clmSachtre
            // 
            clmSachtre.HeaderText = "Sách trả trễ";
            clmSachtre.MinimumWidth = 8;
            clmSachtre.Name = "clmSachtre";
            clmSachtre.ReadOnly = true;
            clmSachtre.Width = 150;
            // 
            // clmSongaytre
            // 
            clmSongaytre.HeaderText = "Số ngày trễ";
            clmSongaytre.MinimumWidth = 8;
            clmSongaytre.Name = "clmSongaytre";
            clmSongaytre.ReadOnly = true;
            clmSongaytre.Width = 150;
            // 
            // clmSotienphat
            // 
            clmSotienphat.HeaderText = "Số tiền phạt";
            clmSotienphat.MinimumWidth = 8;
            clmSotienphat.Name = "clmSotienphat";
            clmSotienphat.ReadOnly = true;
            clmSotienphat.Width = 150;
            // 
            // lblPhat
            // 
            lblPhat.AutoSize = true;
            lblPhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhat.Location = new Point(3, 301);
            lblPhat.Name = "lblPhat";
            lblPhat.Size = new Size(121, 32);
            lblPhat.TabIndex = 4;
            lblPhat.Text = "Tiền phạt";
            lblPhat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPhat
            // 
            txtPhat.BorderStyle = BorderStyle.FixedSingle;
            txtPhat.Font = new Font("Segoe UI", 12F);
            txtPhat.Location = new Point(179, 304);
            txtPhat.Name = "txtPhat";
            txtPhat.ReadOnly = true;
            txtPhat.Size = new Size(258, 39);
            txtPhat.TabIndex = 6;
            // 
            // lblTratre
            // 
            lblTratre.AutoSize = true;
            lblTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTratre.Location = new Point(3, 239);
            lblTratre.Name = "lblTratre";
            lblTratre.Size = new Size(88, 32);
            lblTratre.TabIndex = 3;
            lblTratre.Text = "Trả trễ";
            lblTratre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTratre
            // 
            txtTratre.BorderStyle = BorderStyle.FixedSingle;
            txtTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTratre.ForeColor = Color.Red;
            txtTratre.Location = new Point(179, 242);
            txtTratre.Name = "txtTratre";
            txtTratre.ReadOnly = true;
            txtTratre.Size = new Size(258, 39);
            txtTratre.TabIndex = 5;
            // 
            // lblSachdangmuon
            // 
            lblSachdangmuon.AutoSize = true;
            lblSachdangmuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSachdangmuon.Location = new Point(3, 181);
            lblSachdangmuon.Name = "lblSachdangmuon";
            lblSachdangmuon.Size = new Size(150, 32);
            lblSachdangmuon.TabIndex = 10;
            lblSachdangmuon.Text = "Đang mượn";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(179, 184);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(258, 39);
            textBox1.TabIndex = 11;
            // 
            // Lichsumuonsach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Lichsumuonsach";
            Size = new Size(1043, 847);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichsumuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitietphat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblThongke;
        private Label lblLichsumuon;
        private TextBox txtPhat;
        private TextBox txtTratre;
        private Label lblPhat;
        private Label lblTratre;
        private TextBox txtSosachmuon;
        private Label lblSosachmuon;
        private Label lblChitietphat;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvLichsumuon;
        private DataGridViewTextBoxColumn clmMaphieumuon;
        private DataGridViewTextBoxColumn clmNgaymuon;
        private DataGridViewTextBoxColumn clmNgaytra;
        private DataGridViewTextBoxColumn clmTrangthai;
        private DataGridViewTextBoxColumn clmTensach;
        private DataGridViewTextBoxColumn clmNXB;
        private DataGridViewTextBoxColumn clmTacgia;
        private DataGridView dgvChitietphat;
        private Label lblSachdangmuon;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn clmNgayphat;
        private DataGridViewTextBoxColumn clmSachtre;
        private DataGridViewTextBoxColumn clmSongaytre;
        private DataGridViewTextBoxColumn clmSotienphat;
    }
}
