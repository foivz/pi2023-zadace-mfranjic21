using Help_Desk.Repositories;
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
    public partial class FrmKomentar : Form
    {
        private int id_Zahtjev;
        public FrmKomentar(int idZahtjev)
        {
            InitializeComponent();
            id_Zahtjev = idZahtjev;
        }

        private void btnKomentar_Click(object sender, EventArgs e)
        {
            var Komentar = txtKomentar.Text;
            ZahtjevRepository.DodajKomentar(id_Zahtjev, Komentar);
            Close();
        }
    }
}
