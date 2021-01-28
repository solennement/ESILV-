using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Client : Personne
    {
        string date_premiere_commande;

        public string Date_premiere_commande
        {
            get { return this.date_premiere_commande; }
            set { this.date_premiere_commande = value; }
        }

        public Client(string nom, string prenom, string tel, string adresse, string date_premiere_commande): base(nom, prenom, tel, adresse)
        {
            this.date_premiere_commande = date_premiere_commande;
        }
    }
}
