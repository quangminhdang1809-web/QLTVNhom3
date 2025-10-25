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
    public partial class ucDocgiathuthu : UserControl
    {
        public ucDocgiathuthu()
        {
            InitializeComponent();
        }

        private void btnThemdocgia_Click(object sender, EventArgs e)
        {
            frmThemdocgia frmThemdocgia = new frmThemdocgia();
            frmThemdocgia.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grdDocgia.ClearSelection();
            grdDocgia.CurrentCell = grdDocgia[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdDocgia.CurrentCell = grdDocgia[0, i - 1];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i < grdDocgia.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp theo
            {
                grdDocgia.CurrentCell = grdDocgia[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.RowCount - 1;
            grdDocgia.CurrentCell = grdDocgia[0, i];//Dòng  cuối cùng
        }

        private void grdDocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
