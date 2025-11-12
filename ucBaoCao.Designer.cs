namespace QLTVNhom3
{
    partial class ucBaoCao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxChonMauBaoCao = new ComboBox();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            btnIn = new Button();
            grdThongKe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 31);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(287, 107);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 1;
            label2.Text = "Chọn mẫu báo cáo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(287, 196);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(287, 285);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // cbxChonMauBaoCao
            // 
            cbxChonMauBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxChonMauBaoCao.FormattingEnabled = true;
            cbxChonMauBaoCao.Location = new Point(540, 107);
            cbxChonMauBaoCao.Name = "cbxChonMauBaoCao";
            cbxChonMauBaoCao.Size = new Size(486, 36);
            cbxChonMauBaoCao.TabIndex = 4;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(539, 197);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(487, 27);
            dtpTuNgay.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(540, 286);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(486, 27);
            dtpDenNgay.TabIndex = 6;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Highlight;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(705, 384);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(142, 38);
            btnThongKe.TabIndex = 140;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnIn
            // 
            btnIn.BackColor = SystemColors.Highlight;
            btnIn.FlatAppearance.BorderSize = 0;
            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(884, 384);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(142, 38);
            btnIn.TabIndex = 141;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            // 
            // grdThongKe
            // 
            grdThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongKe.Location = new Point(86, 497);
            grdThongKe.Name = "grdThongKe";
            grdThongKe.RowHeadersWidth = 51;
            grdThongKe.Size = new Size(1185, 362);
            grdThongKe.TabIndex = 142;
            // 
            // ucBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(grdThongKe);
            Controls.Add(btnIn);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(cbxChonMauBaoCao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucBaoCao";
            Size = new Size(1415, 873);
            ((System.ComponentModel.ISupportInitialize)grdThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxChonMauBaoCao;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Button btnIn;
        private DataGridView grdThongKe;
    }
}
