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
    public partial class FrmLogin : Form
    {
        public static Djelatnik LoggedDjelatnik { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtPassword.Text == "")
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu ispravni", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                LoggedDjelatnik = DjelatnikRepository.GetDjelatnik(txtEmail.Text);
                if (LoggedDjelatnik != null && LoggedDjelatnik.CheckPassword(txtPassword.Text))
                {
                    FrmPocetna frmPocetna = new FrmPocetna();
                    Hide();
                    frmPocetna.ShowDialog();
                    Close();
                } else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
