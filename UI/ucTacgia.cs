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
    public partial class ucTacgia : UserControl
    {
        public ucTacgia()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdTacgia.ClearSelection();
            grdTacgia.CurrentCell = grdTacgia[0, 0];
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.CurrentRow.Index;
            if (i > 0)// Nếu chưa phải dòng đầu thì nhảy đến dòng trước đó
            {
                grdTacgia.CurrentCell = grdTacgia[0, i - 1];
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.CurrentRow.Index;
            if (i < grdTacgia.RowCount - 1)// Nếu chưa phải dòng cuối thì nhảy đến dòng tiếp the
            {
                grdTacgia.CurrentCell = grdTacgia[0, i + 1];
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdTacgia.RowCount - 1;
            grdTacgia.CurrentCell = grdTacgia[0, i];//Dòng  cuối cùng
        }

        private void grdTacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemtacgia_Click(object sender, EventArgs e)
        {
            frmThemtacgia f= new frmThemtacgia();
            f.ShowDialog();
        }
    }
}
