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
    public partial class ucMacabiet : UserControl
    {
        public ucMacabiet()
        {
            InitializeComponent();
        }

        private void grdTheloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdSach.CurrentRow.Index;
            if (i < grdSach.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp theo
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
