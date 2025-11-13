// SỬA LỖI: Thêm " : UserControl"
namespace QLTVNhom3
{
    partial class ucBaoCao : System.Windows.Forms.UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            label2.Location = new Point(391, 95);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 1;
            label2.Text = "Chọn mẫu báo cáo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(391, 184);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(391, 273);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // cbxChonMauBaoCao
            // 
            cbxChonMauBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxChonMauBaoCao.FormattingEnabled = true;
            cbxChonMauBaoCao.Location = new Point(644, 95);
            cbxChonMauBaoCao.Name = "cbxChonMauBaoCao";
            cbxChonMauBaoCao.Size = new Size(486, 36);
            cbxChonMauBaoCao.TabIndex = 4;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(643, 185);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(487, 27);
            dtpTuNgay.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(644, 274);
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
            btnThongKe.Location = new Point(809, 372);
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
            btnIn.Location = new Point(988, 372);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(142, 38);
            btnIn.TabIndex = 141;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            // 
            // grdThongKe
            // 
            grdThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdThongKe.BackgroundColor = Color.White;
            grdThongKe.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdThongKe.ColumnHeadersHeight = 35;
            grdThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdThongKe.EnableHeadersVisualStyles = false;
            grdThongKe.Location = new Point(86, 497);
            grdThongKe.Name = "grdThongKe";
            grdThongKe.RowHeadersWidth = 51;
            grdThongKe.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grdThongKe.RowTemplate.Height = 35;
            grdThongKe.Size = new Size(1431, 527);
            grdThongKe.TabIndex = 142;
            grdThongKe.Visible = false;
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
            Size = new Size(1568, 1048);
            ((System.ComponentModel.ISupportInitialize)grdThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxChonMauBaoCao;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView grdThongKe;
    }
}