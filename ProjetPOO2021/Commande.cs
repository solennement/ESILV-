using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Commande
    {
        string no_de_commande;
        string date;
        string heure;
        List<Nourriture> items;
        string nom_commis;
        string nom_client;

        public Commande(string no_de_commande, string date, string heure, List<Nourriture> items, string nom_commis, string nom_client)
        {
            this.no_de_commande = no_de_commande;
            this.date = date;
            this.heure = heure;
            this.items = items;
            this.nom_commis = nom_commis;
            this.nom_client = nom_client;
        }

        public bool EstPerte() /// pas fini
        {
            return true;
        }
    }
}
