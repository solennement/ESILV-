using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Commis
    {
        private DateTime date_embauche;
        private int nb_perte_commande;
        private int nb_de_commis;

        public Commis(DateTime date_embauche, int nb_perte_commande, int nb_de_commis)
        {
            this.date_embauche = date_embauche;
            this.nb_perte_commande = nb_perte_commande;
            this.nb_de_commis = nb_de_commis;
        }

        public override string ToString()
        {
            return this.date_embauche + " " + this.nb_perte_commande + " " + this.nb_de_commis;
        }
    }
}
