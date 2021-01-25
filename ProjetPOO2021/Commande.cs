using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Commande : IPerte
    {
        private int no_de_commande;
        private DateTime date_heure;
        private List<Nourriture> items;
        private string nom_commis;
        private string nom_client;

        public Commande(int no_de_commande, DateTime date_heure, List<Nourriture> items, string nom_commis, string nom_client)
        {
            this.no_de_commande = no_de_commande;
            this.date_heure = date_heure;
            this.items = items;
            this.nom_commis = nom_commis;
            this.nom_client = nom_client;
        }

        public override string ToString()
        {
            string liste = this.no_de_commande + " " + this.date_heure + " " + this.nom_commis + " " + this.nom_client;
            foreach(Nourriture n in items)
            {
                liste += n.ToString();
            }
            return liste;
        }

        public bool EstPerte() /// pas fini
        {
            return true;
        }
    }
}
