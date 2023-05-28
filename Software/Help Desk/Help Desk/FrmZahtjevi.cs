using Help_Desk.Models;
using Help_Desk.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk
{
    public partial class FrmZahtjevi : Form
    {
        public FrmZahtjevi()
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

        private void FrmZahtjevi_Load(object sender, EventArgs e)
        {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();

            dgvZahtjevi.AutoGenerateColumns = false;

            dgvZahtjevi.Columns.Clear();

            dgvZahtjevi.Columns.Add("ID_Zahtjev", "ID");
            dgvZahtjevi.Columns.Add("DjelatnikID", "Djelatnik ID");
            dgvZahtjevi.Columns.Add("Status", "Status");
            dgvZahtjevi.Columns.Add("Komentar", "Komentar");
            dgvZahtjevi.Columns.Add("VrijemePrijave", "Vrijeme Prijave");
            dgvZahtjevi.Columns.Add("Prioritet", "Prioritet");
            dgvZahtjevi.Columns.Add("Opis", "Opis");
            dgvZahtjevi.Columns.Add("Lokacija", "Lokacija");

            dgvZahtjevi.DataSource = zahtjevi;
        }
    }
}
