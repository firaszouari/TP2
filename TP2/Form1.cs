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
        int IND;
        Compte c;
        ListeCompte lc;

        public Frm_Cpt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lc = new ListeCompte();
            Dg_Client.DataSource = lc.list_compte;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FCompte fc = new FCompte();
            fc.Show();
            lc.ajouter(fc.cp);
            Dg_Client.Rows.Add(fc.cp.numero_compte, fc.cp.titulaire_compte, fc.cp.solde_compte);
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            int rowIndex = Dg_Client.CurrentCell.RowIndex;
            Dg_Client.Rows.RemoveAt(rowIndex);
            lc.supprimer(rowIndex);
        }

        private void Btn_Rech_Click(object sender, EventArgs e)
        {
            if(Txt_Rech.Text!="")
            {
                c = lc.rechercher(Txt_Rech.Text);
                Txt_Rech.Text = c.numero_compte;
                Txt_Sld.Text = c.solde_compte.ToString();
                Txt_Tit.Text = c.titulaire_compte.ToString();
                IND = Convert.ToInt32(c.numero_compte);
            }
        }
    }
}
