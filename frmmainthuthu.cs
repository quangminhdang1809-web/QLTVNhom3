using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVNhom3
{
    public partial class frmmainthuthu : Form
    {
        public frmmainthuthu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhmuc.Visible == true)
            {
                pnlDanhmuc.Visible = false;
            }
            else
            {
                pnlDanhmuc.Visible = true;
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if (pnlBaocao.Visible == true)
            {
                pnlBaocao.Visible = false;
            }
            else
            {
                pnlBaocao.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else return;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            // 1. Xóa tất cả các control cũ khỏi Panel Main Content
            pnlMaincontent.Controls.Clear();

            // 2. Thiết lập User Control mới
            userControl.Dock = DockStyle.Fill; // Đảm bảo User Control lấp đầy Panel

            // 3. Thêm User Control mới vào Panel
            pnlMaincontent.Controls.Add(userControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            AddUserControl(uc);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            ucSachthuthu uc = new ucSachthuthu();
            AddUserControl(uc);
        }
        private void btnTheloai_Click(object sender, EventArgs e)
        {
            ucTheloai uc = new ucTheloai();
            AddUserControl(uc);
        }
        private void btnTacgia_Click(object sender, EventArgs e)
        {
            ucTacgia uc = new ucTacgia();
            AddUserControl(uc);
        }

        private void btnDocgia_Click(object sender, EventArgs e)
        {
            ucDocgiathuthu uc = new ucDocgiathuthu();
            AddUserControl(uc);
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            ucMuonsachthuthu uc = new ucMuonsachthuthu();
            AddUserControl(uc);
        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            ucTrasach uc = new ucTrasach();
            AddUserControl(uc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pnlQuanlysach.Visible == true)
            {
                pnlQuanlysach.Visible = false;
            }
            else
            {
                pnlQuanlysach.Visible = true;
            }
        }

        private void btnKhosach_Click(object sender, EventArgs e)
        {
            ucKhosach uc = new ucKhosach();
            AddUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucMacabiet uc = new ucMacabiet();
            AddUserControl(uc);
        }
    }
}
