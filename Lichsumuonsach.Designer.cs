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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLichsumuon = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            clmMaphieumuon = new DataGridViewTextBoxColumn();
            clmNgaymuon = new DataGridViewTextBoxColumn();
            clmNgaytra = new DataGridViewTextBoxColumn();
            clmTrangthai = new DataGridViewTextBoxColumn();
            clmTensach = new DataGridViewTextBoxColumn();
            clmNXB = new DataGridViewTextBoxColumn();
            clmTacgia = new DataGridViewTextBoxColumn();
            cbxLocsach = new ComboBox();
            lblSosachmuon = new Label();
            label4 = new Label();
            txtPhat = new TextBox();
            txtSosachmuon = new TextBox();
            lblPhat = new Label();
            lblTratre = new Label();
            txtTratre = new TextBox();
            lblThongke = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblLichsumuon, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 5);
            tableLayoutPanel1.Controls.Add(cbxLocsach, 3, 2);
            tableLayoutPanel1.Controls.Add(lblSosachmuon, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(txtPhat, 1, 3);
            tableLayoutPanel1.Controls.Add(txtSosachmuon, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPhat, 0, 3);
            tableLayoutPanel1.Controls.Add(lblTratre, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTratre, 1, 2);
            tableLayoutPanel1.Controls.Add(lblThongke, 1, 0);
            tableLayoutPanel1.Location = new Point(67, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(882, 759);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLichsumuon
            // 
            lblLichsumuon.AutoSize = true;
            lblLichsumuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLichsumuon.Location = new Point(223, 375);
            lblLichsumuon.Name = "lblLichsumuon";
            lblLichsumuon.Size = new Size(168, 32);
            lblLichsumuon.TabIndex = 1;
            lblLichsumuon.Text = "Lịch sử mượn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 9;
            label1.Text = "Lịch sử mượn";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmMaphieumuon, clmNgaymuon, clmNgaytra, clmTrangthai, clmTensach, clmNXB, clmTacgia });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 453);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(876, 303);
            dataGridView1.TabIndex = 3;
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
            // cbxLocsach
            // 
            cbxLocsach.Font = new Font("Segoe UI", 12F);
            cbxLocsach.FormattingEnabled = true;
            cbxLocsach.Items.AddRange(new object[] { "Toàn bộ thời gian", "Năm này", "Tháng này" });
            cbxLocsach.Location = new Point(663, 153);
            cbxLocsach.Name = "cbxLocsach";
            cbxLocsach.Size = new Size(182, 40);
            cbxLocsach.TabIndex = 8;
            // 
            // lblSosachmuon
            // 
            lblSosachmuon.AutoSize = true;
            lblSosachmuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSosachmuon.Location = new Point(3, 75);
            lblSosachmuon.Name = "lblSosachmuon";
            lblSosachmuon.Size = new Size(174, 32);
            lblSosachmuon.TabIndex = 1;
            lblSosachmuon.Text = "Số sách mượn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(443, 150);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 7;
            label4.Text = "Lọc theo";
            // 
            // txtPhat
            // 
            txtPhat.BorderStyle = BorderStyle.FixedSingle;
            txtPhat.Font = new Font("Segoe UI", 12F);
            txtPhat.Location = new Point(223, 228);
            txtPhat.Name = "txtPhat";
            txtPhat.ReadOnly = true;
            txtPhat.Size = new Size(150, 39);
            txtPhat.TabIndex = 6;
            // 
            // txtSosachmuon
            // 
            txtSosachmuon.BorderStyle = BorderStyle.FixedSingle;
            txtSosachmuon.Font = new Font("Segoe UI", 12F);
            txtSosachmuon.Location = new Point(223, 78);
            txtSosachmuon.Name = "txtSosachmuon";
            txtSosachmuon.ReadOnly = true;
            txtSosachmuon.Size = new Size(150, 39);
            txtSosachmuon.TabIndex = 2;
            // 
            // lblPhat
            // 
            lblPhat.AutoSize = true;
            lblPhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhat.Location = new Point(3, 225);
            lblPhat.Name = "lblPhat";
            lblPhat.Size = new Size(121, 32);
            lblPhat.TabIndex = 4;
            lblPhat.Text = "Tiền phạt";
            // 
            // lblTratre
            // 
            lblTratre.AutoSize = true;
            lblTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTratre.Location = new Point(3, 150);
            lblTratre.Name = "lblTratre";
            lblTratre.Size = new Size(88, 32);
            lblTratre.TabIndex = 3;
            lblTratre.Text = "Trả trễ";
            // 
            // txtTratre
            // 
            txtTratre.BorderStyle = BorderStyle.FixedSingle;
            txtTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTratre.ForeColor = Color.Red;
            txtTratre.Location = new Point(223, 153);
            txtTratre.Name = "txtTratre";
            txtTratre.ReadOnly = true;
            txtTratre.Size = new Size(150, 39);
            txtTratre.TabIndex = 5;
            // 
            // lblThongke
            // 
            lblThongke.AutoSize = true;
            lblThongke.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThongke.Location = new Point(223, 0);
            lblThongke.Name = "lblThongke";
            lblThongke.Size = new Size(198, 32);
            lblThongke.TabIndex = 0;
            lblThongke.Text = "Thống kê nhanh";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ComboBox cbxLocsach;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmMaphieumuon;
        private DataGridViewTextBoxColumn clmNgaymuon;
        private DataGridViewTextBoxColumn clmNgaytra;
        private DataGridViewTextBoxColumn clmTrangthai;
        private DataGridViewTextBoxColumn clmTensach;
        private DataGridViewTextBoxColumn clmNXB;
        private DataGridViewTextBoxColumn clmTacgia;
        private Label label1;
    }
}
