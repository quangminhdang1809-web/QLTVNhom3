using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class Thongtincanhan : UserControl
    {
        public Thongtincanhan()
        {
            InitializeComponent();

            this.btnChangePassword.Resize += BtnChangePassword_Resize;
            this.btnChangePassword.MouseEnter += BtnChangePassword_MouseEnter;
            this.btnChangePassword.MouseLeave += BtnChangePassword_MouseLeave;
        }

        private void Thongtincanhan_Load(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.DodgerBlue;
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.FlatAppearance.BorderSize = 0;

            BoTronButton(btnChangePassword, 15);
        }

        private void BoTronButton(Button btn, int radius)
        {
            if (btn.Width <= 0 || btn.Height <= 0) return; // tránh lỗi khi control chưa vẽ

            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void BtnChangePassword_Resize(object sender, EventArgs e)
        {
            BoTronButton((Button)sender, 15);
        }

        private void BtnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.FromArgb(0, 102, 204); // đậm hơn khi hover
        }

        private void BtnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.DodgerBlue; // trở lại màu gốc
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmChangePassword())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            }
        }
    }
}