using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO
{
    class Facture : Commande
    {
        int no_de_livreur;
        bool est_paye;

        public Facture(int no_de_commande, DateTime date_heure, List<Nourriture> items, string nom_commis, string nom_client, int no_de_livreur, bool est_paye): base(no_de_commande, date_heure, items, nom_commis, nom_client)
        {
            this.no_de_livreur = no_de_livreur;
            this.est_paye = est_paye;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + this.no_de_livreur + this.est_paye;
        }
    }
}
