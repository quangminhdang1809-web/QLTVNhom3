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
            cbxLocsach = new ComboBox();
            label4 = new Label();
            txtPhat = new TextBox();
            txtTratre = new TextBox();
            lblPhat = new Label();
            lblTratre = new Label();
            txtSosachmuon = new TextBox();
            lblSosachmuon = new Label();
            lblThongke = new Label();
            btnXuatdulieu = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            clmMaphieumuon = new DataGridViewTextBoxColumn();
            clmNgaymuon = new DataGridViewTextBoxColumn();
            clmNgaytra = new DataGridViewTextBoxColumn();
            clmTrangthai = new DataGridViewTextBoxColumn();
            clmTensach = new DataGridViewTextBoxColumn();
            clmNXB = new DataGridViewTextBoxColumn();
            clmTacgia = new DataGridViewTextBoxColumn();
            lblLichsumuon = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxLocsach);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPhat);
            panel1.Controls.Add(txtTratre);
            panel1.Controls.Add(lblPhat);
            panel1.Controls.Add(lblTratre);
            panel1.Controls.Add(txtSosachmuon);
            panel1.Controls.Add(lblSosachmuon);
            panel1.Controls.Add(lblThongke);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 346);
            panel1.TabIndex = 0;
            // 
            // cbxLocsach
            // 
            cbxLocsach.Font = new Font("Segoe UI", 12F);
            cbxLocsach.FormattingEnabled = true;
            cbxLocsach.Items.AddRange(new object[] { "Toàn bộ thời gian", "Năm này", "Tháng này" });
            cbxLocsach.Location = new Point(744, 158);
            cbxLocsach.Name = "cbxLocsach";
            cbxLocsach.Size = new Size(182, 40);
            cbxLocsach.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(586, 158);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 7;
            label4.Text = "Lọc theo";
            // 
            // txtPhat
            // 
            txtPhat.BorderStyle = BorderStyle.FixedSingle;
            txtPhat.Font = new Font("Segoe UI", 12F);
            txtPhat.Location = new Point(274, 294);
            txtPhat.Name = "txtPhat";
            txtPhat.ReadOnly = true;
            txtPhat.Size = new Size(150, 39);
            txtPhat.TabIndex = 6;
            // 
            // txtTratre
            // 
            txtTratre.BorderStyle = BorderStyle.FixedSingle;
            txtTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTratre.ForeColor = Color.Red;
            txtTratre.Location = new Point(274, 221);
            txtTratre.Name = "txtTratre";
            txtTratre.ReadOnly = true;
            txtTratre.Size = new Size(150, 39);
            txtTratre.TabIndex = 5;
            // 
            // lblPhat
            // 
            lblPhat.AutoSize = true;
            lblPhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhat.Location = new Point(50, 294);
            lblPhat.Name = "lblPhat";
            lblPhat.Size = new Size(121, 32);
            lblPhat.TabIndex = 4;
            lblPhat.Text = "Tiền phạt";
            // 
            // lblTratre
            // 
            lblTratre.AutoSize = true;
            lblTratre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTratre.Location = new Point(50, 221);
            lblTratre.Name = "lblTratre";
            lblTratre.Size = new Size(88, 32);
            lblTratre.TabIndex = 3;
            lblTratre.Text = "Trả trễ";
            // 
            // txtSosachmuon
            // 
            txtSosachmuon.BorderStyle = BorderStyle.FixedSingle;
            txtSosachmuon.Font = new Font("Segoe UI", 12F);
            txtSosachmuon.Location = new Point(274, 162);
            txtSosachmuon.Name = "txtSosachmuon";
            txtSosachmuon.ReadOnly = true;
            txtSosachmuon.Size = new Size(150, 39);
            txtSosachmuon.TabIndex = 2;
            // 
            // lblSosachmuon
            // 
            lblSosachmuon.AutoSize = true;
            lblSosachmuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSosachmuon.Location = new Point(50, 159);
            lblSosachmuon.Name = "lblSosachmuon";
            lblSosachmuon.Size = new Size(174, 32);
            lblSosachmuon.TabIndex = 1;
            lblSosachmuon.Text = "Số sách mượn";
            // 
            // lblThongke
            // 
            lblThongke.AutoSize = true;
            lblThongke.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThongke.Location = new Point(395, 38);
            lblThongke.Name = "lblThongke";
            lblThongke.Size = new Size(198, 32);
            lblThongke.TabIndex = 0;
            lblThongke.Text = "Thống kê nhanh";
            // 
            // btnXuatdulieu
            // 
            btnXuatdulieu.BackColor = SystemColors.HotTrack;
            btnXuatdulieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXuatdulieu.ForeColor = SystemColors.Control;
            btnXuatdulieu.Location = new Point(821, 425);
            btnXuatdulieu.Name = "btnXuatdulieu";
            btnXuatdulieu.Size = new Size(182, 73);
            btnXuatdulieu.TabIndex = 2;
            btnXuatdulieu.Text = "Xuất dữ liệu";
            btnXuatdulieu.UseVisualStyleBackColor = false;
            btnXuatdulieu.Click += btnXuatdulieu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnXuatdulieu);
            panel2.Controls.Add(lblLichsumuon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 501);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmMaphieumuon, clmNgaymuon, clmNgaytra, clmTrangthai, clmTensach, clmNXB, clmTacgia });
            dataGridView1.Location = new Point(40, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(953, 320);
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
            // lblLichsumuon
            // 
            lblLichsumuon.AutoSize = true;
            lblLichsumuon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLichsumuon.Location = new Point(425, 48);
            lblLichsumuon.Name = "lblLichsumuon";
            lblLichsumuon.Size = new Size(168, 32);
            lblLichsumuon.TabIndex = 1;
            lblLichsumuon.Text = "Lịch sử mượn";
            // 
            // Lichsumuonsach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Lichsumuonsach";
            Size = new Size(1043, 847);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblThongke;
        private Panel panel2;
        private Label lblLichsumuon;
        private TextBox txtPhat;
        private TextBox txtTratre;
        private Label lblPhat;
        private Label lblTratre;
        private TextBox txtSosachmuon;
        private Label lblSosachmuon;
        private Button btnXuatdulieu;
        private ComboBox cbxLocsach;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmMaphieumuon;
        private DataGridViewTextBoxColumn clmNgaymuon;
        private DataGridViewTextBoxColumn clmNgaytra;
        private DataGridViewTextBoxColumn clmTrangthai;
        private DataGridViewTextBoxColumn clmTensach;
        private DataGridViewTextBoxColumn clmNXB;
        private DataGridViewTextBoxColumn clmTacgia;
    }
}
