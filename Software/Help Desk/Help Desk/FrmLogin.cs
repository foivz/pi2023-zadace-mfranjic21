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
        public FrmLogin()
        {
            InitializeComponent();
        }
        public class Djelatnik : Object
        {
            public int ID { get; set; }
            public string ImePrezime { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (email == "djelatnik" && password == "test")
            {
                Hide();
                FrmZahtjevi frmZahtjevi = new FrmZahtjevi();
                frmZahtjevi.ShowDialog();
                Close();
            } else 
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu ispravni", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
