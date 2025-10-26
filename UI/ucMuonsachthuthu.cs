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
    public partial class ucMuonsachthuthu : UserControl
    {
        public ucMuonsachthuthu()
        {
            InitializeComponent();
            grdThongtinsachmuon.Controls.Add(dtpNgay);
            dtpNgay.Visible = false;
            dtpNgay.Format = DateTimePickerFormat.Short;

            dtpNgay.TextChanged += new EventHandler(dtpNgay_TextChanged);
        }
        private void grdThongtinsachmuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra cột có phải là cột ngày không
            if (e.RowIndex >= 0 && (e.ColumnIndex == grdThongtinsachmuon.Columns["colHanmuon"].Index))
            {
                _rectangle = grdThongtinsachmuon.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpNgay.Size = new Size(_rectangle.Width, _rectangle.Height);
                dtpNgay.Location = new Point(_rectangle.X, _rectangle.Y);

                // Hiện DateTimePicker
                dtpNgay.Visible = true;

                // Gán giá trị hiện có (nếu có)
                if (grdThongtinsachmuon.CurrentCell.Value != null)
                    dtpNgay.Value = Convert.ToDateTime(grdThongtinsachmuon.CurrentCell.Value);
                else
                    dtpNgay.Value = DateTime.Now;
            }
            else
            {
                dtpNgay.Visible = false;
            }
        }
        private void dtpNgay_TextChanged(object sender, EventArgs e)
        {
            grdThongtinsachmuon.CurrentCell.Value = dtpNgay.Text;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            frmXacnhanmuonsach f = new frmXacnhanmuonsach();
            f.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemphieumuon_Click(object sender, EventArgs e)
        {
            frmXacnhanmuonsach f = new frmXacnhanmuonsach();
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
