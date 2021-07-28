using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip
{
    public partial class GecmisRapor : Form
    {
        public GecmisRapor()
        {
            InitializeComponent();
        }

        private void GecmisRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ybsdbDataSet1.gecmis' table. You can move, or remove it, as needed.
            this.gecmisTableAdapter.Fill(this.ybsdbDataSet1.gecmis);

            this.reportViewer1.RefreshReport();
        }
    }
}
