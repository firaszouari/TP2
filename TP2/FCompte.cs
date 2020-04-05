using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FCompte : Form
    {
        public Compte cp;

        public FCompte()
        {
            InitializeComponent();
        }

        private void FCompte_Load(object sender, EventArgs e)
        {
            Frm_Cpt frm = new Frm_Cpt();
            frm.Dg_Client.DataSource = cp.list_mouv;
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            validerForm();
        }

        private void Txtsolde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                validerForm();
        }

        private void validerForm()
        {
            if (Txtnumcompte.Text != "" && Txttitulaire.Text != "" && Txtsolde.Text != "")
            {
                cp = new Compte(Txtnumcompte.Text, Txttitulaire.Text, Convert.ToDouble(Txtsolde.Text));
                this.Close();
            }
        }
    }
}
