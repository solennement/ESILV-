using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Facture : Commande
    {
        int no_de_livreur;
        bool est_paye;

        public Facture(string no_de_commande, string date, string heure, List<Nourriture> items, string nom_commis, string nom_client, int no_de_livreur, bool est_paye) : base(no_de_commande, date, heure, items, nom_commis, nom_client)
        {
            this.no_de_livreur = no_de_livreur;
            this.est_paye = est_paye;
        }
    }
}
