using QLTVNhom3.BLL;
using QLTVNhom3.DAL;
using QLTVNhom3.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer; 

namespace QLTVNhom3
{
    public partial class frmThemsach : Form
    {
        private DBHelper db = new DBHelper();

        public frmThemsach()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}