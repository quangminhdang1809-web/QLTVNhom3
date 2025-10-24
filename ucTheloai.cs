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
    public partial class ucTheloai : UserControl
    {
        public ucTheloai()
        {
            InitializeComponent();
        }

        private void btnThemtheloai_Click(object sender, EventArgs e)
        {
            frmThemtheloai frmThemtheloai = new frmThemtheloai();
            frmThemtheloai.ShowDialog();
        }
    }
}
