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
    public partial class ucKhosach : UserControl
    {
        public ucKhosach()
        {
            InitializeComponent();
        }

        private void btnThemkesach_Click(object sender, EventArgs e)
        {
            frmThemkesach frmThemkhosach = new frmThemkesach();
            frmThemkhosach.ShowDialog();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            grdVitrisach.ClearSelection();
            grdVitrisach.CurrentCell = grdVitrisach[0, 0];
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdVitrisach.CurrentCell = grdVitrisach[0, i - 1];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.CurrentRow.Index;
            if (i < grdVitrisach.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp theo
            {
                grdVitrisach.CurrentCell = grdVitrisach[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdVitrisach.RowCount - 1;
            grdVitrisach.CurrentCell = grdVitrisach[0, i];//Dòng  cuối cùng
        }
    }
}
