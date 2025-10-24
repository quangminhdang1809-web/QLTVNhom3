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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdTheloai.ClearSelection();
            grdTheloai.CurrentCell = grdTheloai[0, 0];
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdTheloai.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdTheloai.CurrentCell = grdTheloai[0, i - 1];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdTheloai.CurrentRow.Index;
            if (i < grdTheloai.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp the
            {
                grdTheloai.CurrentCell = grdTheloai[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdTheloai.RowCount - 1;
            grdTheloai.CurrentCell = grdTheloai[0, i];//Dòng  cuối cùng
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
