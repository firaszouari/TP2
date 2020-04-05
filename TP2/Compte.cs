using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Compte
    {
        List<Mouvements> lmouv = new List<Mouvements>();
        String numcompt;
        double sold;
        string titulaire;

        public List<Mouvements> list_mouv { get; set; }
        public string numero_compte { get; set; }
        public double solde_compte { get; set; }
        public string titulaire_compte{get; set;}

        public Compte(string num, string titu, double sol)
        {
            this.numero_compte = num;
            this.titulaire_compte = titu;
            this.solde_compte = sol;
        }

        public int nbMouv()
        {
            return list_mouv.Count();
        }

        public void nouveauMvt(Mouvements m)
        {
            list_mouv.Add(m);
        }

        public void retirer(double val)
        {
            sold -= val;
        }

        public void verser(double val)
        {
            sold += val;
        }
    }
}
