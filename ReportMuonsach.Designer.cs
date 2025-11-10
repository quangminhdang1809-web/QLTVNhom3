namespace QLTVNhom3
{
    partial class ReportMuonsach
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnXembaocao = new Button();
            cbxLoc = new ComboBox();
            lblLoc = new Label();
            lblSoluotmuonsach = new Label();
            btnPrint = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(184, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(923, 594);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(btnXembaocao);
            panel1.Controls.Add(cbxLoc);
            panel1.Controls.Add(lblLoc);
            panel1.Controls.Add(lblSoluotmuonsach);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 192);
            panel1.TabIndex = 0;
            // 
            // btnXembaocao
            // 
            btnXembaocao.BackColor = SystemColors.ActiveBorder;
            btnXembaocao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXembaocao.Location = new Point(432, 109);
            btnXembaocao.Name = "btnXembaocao";
            btnXembaocao.RightToLeft = RightToLeft.No;
            btnXembaocao.Size = new Size(193, 43);
            btnXembaocao.TabIndex = 3;
            btnXembaocao.Text = "Xem báo cáo";
            btnXembaocao.UseVisualStyleBackColor = false;
            // 
            // cbxLoc
            // 
            cbxLoc.Font = new Font("Segoe UI", 12F);
            cbxLoc.FormattingEnabled = true;
            cbxLoc.Location = new Point(193, 112);
            cbxLoc.Name = "cbxLoc";
            cbxLoc.Size = new Size(182, 40);
            cbxLoc.TabIndex = 2;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Segoe UI", 12F);
            lblLoc.Location = new Point(66, 109);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(121, 32);
            lblLoc.TabIndex = 1;
            lblLoc.Text = "Thời gian ";
            // 
            // lblSoluotmuonsach
            // 
            lblSoluotmuonsach.Dock = DockStyle.Top;
            lblSoluotmuonsach.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSoluotmuonsach.Location = new Point(0, 0);
            lblSoluotmuonsach.Name = "lblSoluotmuonsach";
            lblSoluotmuonsach.Size = new Size(917, 60);
            lblSoluotmuonsach.TabIndex = 0;
            lblSoluotmuonsach.Text = "Báo cáo số lượt mượn sách";
            lblSoluotmuonsach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.HotTrack;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrint.Location = new Point(992, 741);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 41);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // ReportMuonsach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(tableLayoutPanel1);
            Name = "ReportMuonsach";
            Size = new Size(1313, 1031);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnXembaocao;
        private ComboBox cbxLoc;
        private Label lblLoc;
        private Label lblSoluotmuonsach;
        private Button btnPrint;
    }
}
