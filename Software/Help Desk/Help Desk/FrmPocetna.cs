using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnPopisKvarova_Click(object sender, EventArgs e)
        {
            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            Hide();
            frmZahtjevi.ShowDialog();
            Close();
        }
    }
}
