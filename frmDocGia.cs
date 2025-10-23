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
        public frmDocGia()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Thongtincanhan ttcndg = new Thongtincanhan();
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
            Timkiemsach tks = new Timkiemsach();
            tks.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(tks);
        }

        private void btnLichsumuonsach_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();   
            Lichsumuonsach lsm = new Lichsumuonsach();
            lsm.Dock = DockStyle.Fill;  
            pnlMain.Controls.Add(lsm);
        }
    }
}
