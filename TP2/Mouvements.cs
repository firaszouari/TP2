using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Mouvements
    {
        private DateTime dateop;
        private double montant;
        private String typop;

        public DateTime date_op{ get; set;}
        public double montant_op { get; set; }
        public String typ_oper { get; set; }

        public Mouvements(DateTime dop, string type, double mt)
        {
            this.date_op = dop;
            this.typ_oper = type;
            this.montant = mt;
        }
    }
}
