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
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(409, 50);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(635, 152);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(294, 45);
            label2.TabIndex = 1;
            label2.Text = "Chọn mẫu báo cáo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(635, 294);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 45);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(635, 437);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 45);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // cbxChonMauBaoCao
            // 
            cbxChonMauBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxChonMauBaoCao.FormattingEnabled = true;
            cbxChonMauBaoCao.Location = new Point(1046, 152);
            cbxChonMauBaoCao.Margin = new Padding(5);
            cbxChonMauBaoCao.Name = "cbxChonMauBaoCao";
            cbxChonMauBaoCao.Size = new Size(787, 53);
            cbxChonMauBaoCao.TabIndex = 4;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(1045, 296);
            dtpTuNgay.Margin = new Padding(5);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(789, 39);
            dtpTuNgay.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(1046, 438);
            dtpDenNgay.Margin = new Padding(5);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(787, 39);
            dtpDenNgay.TabIndex = 6;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Highlight;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1315, 595);
            btnThongKe.Margin = new Padding(5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(231, 61);
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
            btnIn.Location = new Point(1606, 595);
            btnIn.Margin = new Padding(5);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(231, 61);
            btnIn.TabIndex = 141;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
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
            grdThongKe.Location = new Point(140, 795);
            grdThongKe.Margin = new Padding(5);
            grdThongKe.Name = "grdThongKe";
            grdThongKe.RowHeadersWidth = 51;
            grdThongKe.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grdThongKe.RowTemplate.Height = 35;
            grdThongKe.Size = new Size(2263, 843);
            grdThongKe.TabIndex = 142;
            grdThongKe.Visible = false;
            // 
            // ucBaoCao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
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
            Margin = new Padding(5);
            Name = "ucBaoCao";
            Size = new Size(2548, 1677);
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