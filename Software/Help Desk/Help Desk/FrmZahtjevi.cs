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
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;

        public FrmZahtjevi()
        {
            InitializeComponent();

            contextMenuStrip = new ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem("Delete");
            deleteToolStripMenuItem.Click += IzbrisiPodatke;
            contextMenuStrip.Items.Add(deleteToolStripMenuItem);

            dgvZahtjevi.ContextMenuStrip = contextMenuStrip;
        }

        private void IzbrisiPodatke(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvZahtjevi.SelectedRows[0];
                int id_Zahtjev = Convert.ToInt32(selectedRow.Cells["ID_Zahtjev"].Value);
                ZahtjevRepository.DeleteZahtjev(id_Zahtjev);
                OsvjeziDataGridView();
            }
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

            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void btnMojiZahtjevi_Click(object sender, EventArgs e)
        {
            FrmMojiZahtjevi frmMojiZahtjevi = new FrmMojiZahtjevi();
            Hide();
            frmMojiZahtjevi.ShowDialog();
            Close();
        }

        private void btnPreuzmiZahtjev_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvZahtjevi.SelectedRows[0];
                int zahtjevId = Convert.ToInt32(selectedRow.Cells["ID_Zahtjev"].Value);
                ZahtjevRepository.PreuzmiZahtjev(zahtjevId);
                OsvjeziDataGridView();
            }
        }

        private void OsvjeziDataGridView()
        {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void btnKomentar_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvZahtjevi.SelectedRows[0];
                int id_Zahtjev = Convert.ToInt32(selectedRow.Cells["ID_Zahtjev"].Value);

                FrmKomentar frmKomentar = new FrmKomentar(id_Zahtjev);
                frmKomentar.FormClosed += FrmKomentar_FormClosed;
                frmKomentar.ShowDialog();
            }
            
        }
        private void FrmKomentar_FormClosed(object sender, FormClosedEventArgs e)
        {
            OsvjeziDataGridView();
        }
    }
}
