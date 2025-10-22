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
    public partial class ucSachthuthu : UserControl
    {
        public ucSachthuthu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemsach frm = new frmThemsach();
            frm.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdSach.ClearSelection();
            grdSach.CurrentCell = grdSach[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdSach.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdSach.CurrentCell = grdSach[0, i - 1];
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdSach.CurrentRow.Index;
            if (i < grdSach.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp the
            {
                grdSach.CurrentCell = grdSach[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdSach.RowCount - 1;
            grdSach.CurrentCell = grdSach[0, i];//Dòng  cuối cùng
        }
    }
}
