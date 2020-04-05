using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ListeCompte
    {
        List<Compte> lCompt = new List<Compte>();
        public List<Compte> list_compte { get; set; }
        public void ajouter(Compte c)
        {
            list_compte.Add(c);
        }

        public Compte rechercher(String numc)
        {
            Compte c = null;
            if (list_compte.Count == 0)
                return null;
            else
                for(int i =0; i< list_compte.Count; i++)
                {
                    c = (Compte)list_compte[i];
                    if (c.numero_compte == numc)
                        break;
                }
            return c;
        }

        public void supprimer(Compte c)
        {
            list_compte.Remove(c);
        }

        public void supprimer(int i)
        {
            list_compte.RemoveAt(i);
        }
    }
}
