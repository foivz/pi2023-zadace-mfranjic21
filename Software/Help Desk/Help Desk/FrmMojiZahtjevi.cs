using Help_Desk.Models;
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
    public partial class FrmMojiZahtjevi : Form
    {
        Djelatnik loggedUser = FrmLogin.LoggedDjelatnik;

        public static Djelatnik LoggedDjelatnik { get; set; }

        public FrmMojiZahtjevi()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
            Hide();
            frmZahtjevi.ShowDialog();
            Close();
        }
        private void FrmZahtjevi_Load(object sender, EventArgs e)
        {

            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjeviFromDjelatnik(loggedUser.ID_djelatnik);

            dgvZahtjevi.DataSource = zahtjevi;
        }
    }
}
