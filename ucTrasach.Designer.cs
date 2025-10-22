namespace QLTVNhom3
{
    partial class ucTrasach
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtsdt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label15 = new Label();
            txttendocgia = new TextBox();
            txtmadocgia = new TextBox();
            groupBox3 = new GroupBox();
            grdThongtinsachmuon = new DataGridView();
            groupBox4 = new GroupBox();
            grdThongtintrasach = new DataGridView();
            btnHuy = new Button();
            btnluu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(115, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 914);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mượn sách";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtsdt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txttendocgia);
            groupBox2.Controls.Add(txtmadocgia);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(33, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 273);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // txtsdt
            // 
            txtsdt.BorderStyle = BorderStyle.FixedSingle;
            txtsdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtsdt.Location = new Point(181, 178);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(351, 34);
            txtsdt.TabIndex = 174;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(17, 178);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 173;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(17, 49);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 166;
            label5.Text = "Mã độc giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(17, 115);
            label15.Name = "label15";
            label15.Size = new Size(116, 28);
            label15.TabIndex = 165;
            label15.Text = "Tên độc giả";
            // 
            // txttendocgia
            // 
            txttendocgia.BorderStyle = BorderStyle.FixedSingle;
            txttendocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttendocgia.Location = new Point(181, 113);
            txttendocgia.Name = "txttendocgia";
            txttendocgia.Size = new Size(351, 34);
            txttendocgia.TabIndex = 164;
            // 
            // txtmadocgia
            // 
            txtmadocgia.BorderStyle = BorderStyle.FixedSingle;
            txtmadocgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtmadocgia.Location = new Point(181, 47);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(351, 34);
            txtmadocgia.TabIndex = 163;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grdThongtinsachmuon);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(33, 406);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(623, 414);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách mượn";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // grdThongtinsachmuon
            // 
            grdThongtinsachmuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtinsachmuon.Location = new Point(17, 46);
            grdThongtinsachmuon.Name = "grdThongtinsachmuon";
            grdThongtinsachmuon.RowHeadersWidth = 51;
            grdThongtinsachmuon.Size = new Size(583, 344);
            grdThongtinsachmuon.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(grdThongtintrasach);
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(btnluu);
            groupBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.Location = new Point(923, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(706, 739);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin trả sách";
            // 
            // grdThongtintrasach
            // 
            grdThongtintrasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdThongtintrasach.Location = new Point(71, 113);
            grdThongtintrasach.Name = "grdThongtintrasach";
            grdThongtintrasach.RowHeadersWidth = 51;
            grdThongtintrasach.Size = new Size(583, 439);
            grdThongtintrasach.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(356, 665);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(145, 38);
            btnHuy.TabIndex = 144;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnluu
            // 
            btnluu.BackColor = SystemColors.Highlight;
            btnluu.FlatAppearance.BorderSize = 0;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnluu.ForeColor = Color.White;
            btnluu.Location = new Point(523, 665);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(145, 38);
            btnluu.TabIndex = 143;
            btnluu.Text = "Xác nhận";
            btnluu.UseVisualStyleBackColor = false;
            // 
            // ucTrasach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "ucTrasach";
            Size = new Size(1650, 1000);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdThongtinsachmuon).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdThongtintrasach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView grdThongtinsachmuon;
        private GroupBox groupBox2;
        private TextBox txtsdt;
        private Label label6;
        private Label label5;
        private Label label15;
        private TextBox txttendocgia;
        private TextBox txtmadocgia;
        private GroupBox groupBox4;
        private Button btnHuy;
        private Button btnluu;
        private DataGridView grdThongtintrasach;
    }
}
