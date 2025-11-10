using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVNhom3
{
    public partial class BaocaoMuonsach : DevExpress.XtraReports.UI.XtraReport
    {
        public BaocaoMuonsach()
        {
            InitializeComponent();
            lblNgaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
