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

        private void Txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && Txtnum.Text != "")
            {
                c = lc.rechercher(Txtnum.Text);
                Txtnum.Text = c.numero_compte;
                Txttitulaire.Text = c.titulaire_compte;
                TxtSolde.Text = c.solde_compte.ToString();
                Dg_Mouv.DataSource = c.list_mouv;
            }
        }

        private void addMouvement(String type)
        {
            if (TxtMt.Text != "")
            {
                Mouvements mvt = new Mouvements(Datm.Value, type, Convert.ToDouble(TxtMt.Text));
                c.nouveauMvt(mvt);
            }
        }

        private void Btn_Creer_Mouv_Click(object sender, EventArgs e)
        {
            if (Rdb_Ret.Checked)
            {
                if (Convert.ToDouble(TxtSolde.Text) > Convert.ToDouble(TxtMt.Text))
                {
                    lc.list_compte[Convert.ToInt32(c.numero_compte)].retirer(Convert.ToDouble(TxtMt.Text));
                    addMouvement("Retrait");
                }
                else
                {
                    MessageBox.Show("Votre solde est insuffisant !");
                }
            }
            else if (Rdb_Vers.Checked)
            {
                lc.list_compte[Convert.ToInt32(c.numero_compte)].verser(Convert.ToDouble(TxtMt.Text));
                addMouvement("Verssement");
            }
            else
            {
                MessageBox.Show("Il faut selectionner un choix !");
            }
        }

        private void Btn_Affiche_Click(object sender, EventArgs e)
        {
            if (Txt_Nume.Text != "")
            {
                c = lc.rechercher(Txt_Nume.Text);
                Txt_Nume.Text = c.numero_compte;
                Txt_Tite.Text = c.titulaire_compte;
                Txt_Slde.Text = c.solde_compte.ToString();
                List<Mouvements> lmouv = new List<Mouvements>();
                for (int i = 0; i < c.nbMouv(); i++)
                {
                    if (c.list_mouv[i].date_op <= Dat_Deb.Value && c.list_mouv[i].date_op >= Dat_Fin.Value)
                        lmouv.Add(c.list_mouv[i]);
                }
                Dg_Extrait.DataSource = lmouv;
            }
        }
    }
}
