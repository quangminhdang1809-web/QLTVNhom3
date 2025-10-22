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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtIDAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else return;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienmatkhau.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';                                  
            }
            else
            {
                txtMatkhau.PasswordChar = '•'; 
            }
        }
    }
}
