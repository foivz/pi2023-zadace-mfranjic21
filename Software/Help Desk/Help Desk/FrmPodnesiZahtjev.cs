using Help_Desk.Models;
using Help_Desk.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk
{
    public partial class FrmPodnesiZahtjev : Form
    {
        
        public FrmPodnesiZahtjev()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FrmPocetna frmPocetna = new FrmPocetna();
            Hide();
            frmPocetna.ShowDialog();
            Close();
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            FrmPodnesiZahtjev frmPodnesiZahtjev = new FrmPodnesiZahtjev();
            Hide();
            frmPodnesiZahtjev.ShowDialog();
            Close();
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            Djelatnik loggedUser = FrmLogin.LoggedDjelatnik;

            int Prioritet = 0;
            switch (cmbPrioritet.Text.ToLower())
            {
                case "visok":
                    Prioritet = 1;
                    break;
                case "srednji":
                    Prioritet = 2;
                    break;
                case "nizak":
                    Prioritet = 3;
                    break;
                default:
                    break;
            }

            Zahtjev newZahtjev = new Zahtjev();
            newZahtjev.DjelatnikID = loggedUser.ID_djelatnik;
            newZahtjev.Status = 0;
            newZahtjev.Komentar = "";
            newZahtjev.Prioritet = Prioritet;
            newZahtjev.Opis = txtOpis.Text;
            newZahtjev.Lokacija = txtLokacija.Text;


            ZahtjevRepository.InsertZahtjev(newZahtjev);
            Close();

        }

        private void FrmPodnesiZahtjev_Load(object sender, EventArgs e)
        {

        }
    }
}
