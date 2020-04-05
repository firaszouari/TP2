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
    public partial class Frm_Cpt : Form
    {
        Compte c;
        ListeCompte lc = new ListeCompte();
        public Frm_Cpt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FCompte fc = new FCompte();
            fc.Show();
            lc.ajouter(FCompte.cp);
            DataTable dt = new DataTable();
            Dg_Client.Rows.Add(FCompte.cp.numcompte, FCompte.cp.titulaire, FCompte.cp.solde);
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            int rowIndex = Dg_Client.CurrentCell.RowIndex;
            Dg_Client.Rows.RemoveAt(rowIndex);
        }
    }
}
