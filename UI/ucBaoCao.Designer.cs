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
            grdThongKe = new DataGridView();
            groupBox1 = new GroupBox();
            btnIn = new Button();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            cbxChonMauBaoCao = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdThongKe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            grdThongKe.ColumnHeadersHeight = 45;
            grdThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdThongKe.EnableHeadersVisualStyles = false;
            grdThongKe.Location = new Point(140, 850);
            grdThongKe.Margin = new Padding(5);
            grdThongKe.Name = "grdThongKe";
            grdThongKe.RowHeadersVisible = false;
            grdThongKe.RowHeadersWidth = 51;
            grdThongKe.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grdThongKe.RowTemplate.Height = 45;
            grdThongKe.Size = new Size(2263, 788);
            grdThongKe.TabIndex = 142;
            grdThongKe.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIn);
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(cbxChonMauBaoCao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(402, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1670, 678);
            groupBox1.TabIndex = 143;
            groupBox1.TabStop = false;
            groupBox1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // btnIn
            // 
            btnIn.BackColor = SystemColors.Highlight;
            btnIn.FlatAppearance.BorderSize = 0;
            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(1194, 550);
            btnIn.Margin = new Padding(5);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(231, 61);
            btnIn.TabIndex = 149;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.Highlight;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(903, 550);
            btnThongKe.Margin = new Padding(5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(231, 61);
            btnThongKe.TabIndex = 148;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpDenNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(634, 414);
            dtpDenNgay.Margin = new Padding(5);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(787, 50);
            dtpDenNgay.TabIndex = 147;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpTuNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(633, 272);
            dtpTuNgay.Margin = new Padding(5);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(789, 50);
            dtpTuNgay.TabIndex = 146;
            // 
            // cbxChonMauBaoCao
            // 
            cbxChonMauBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxChonMauBaoCao.FormattingEnabled = true;
            cbxChonMauBaoCao.Location = new Point(634, 128);
            cbxChonMauBaoCao.Margin = new Padding(5);
            cbxChonMauBaoCao.Name = "cbxChonMauBaoCao";
            cbxChonMauBaoCao.Size = new Size(787, 53);
            cbxChonMauBaoCao.TabIndex = 145;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(223, 413);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 45);
            label4.TabIndex = 144;
            label4.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(223, 270);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 45);
            label3.TabIndex = 143;
            label3.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(223, 128);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 45);
            label2.TabIndex = 142;
            label2.Text = "Chọn mẫu báo cáo";
            // 
            // ucBaoCao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(grdThongKe);
            Margin = new Padding(5);
            Name = "ucBaoCao";
            Size = new Size(2548, 1677);
            Load += ucBaoCao_Load_1;
            ((System.ComponentModel.ISupportInitialize)grdThongKe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView grdThongKe;
        private GroupBox groupBox1;
        private Button btnIn;
        private Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private ComboBox cbxChonMauBaoCao;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}