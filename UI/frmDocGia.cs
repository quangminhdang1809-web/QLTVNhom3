using QLTVNhom3.DAL;
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
    public partial class frmDocGia : Form
    {
        public string IDAccount;
        public frmDocGia(string iDAccount)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.IDAccount = iDAccount;
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Thongtincanhan ttcndg = new Thongtincanhan(this.IDAccount);
            ttcndg.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ttcndg);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiemsach_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucSachthuthu tks = new ucSachthuthu(true);
            tks.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(tks);
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            lblMSV.Text = IDAccount;
            AccountDAL dal = new AccountDAL();
            string tenDG = dal.GetTenDocGia(IDAccount);
            if (!string.IsNullOrEmpty(tenDG))
            {
                lblTen.Text = tenDG;
            }
        }
    }
}
