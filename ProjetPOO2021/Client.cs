using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProjetPOO2021
{
    class Client
    {
        private string nom;
        private string prenom;
        private DateTime date_premiere_commande;
        private string tel;
        private string adresse;
 
        public Client(string nom, string prenom, DateTime date_premiere_commande, string tel, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_premiere_commande = date_premiere_commande;
            this.tel = tel;
            this.adresse = adresse;
        }

        public override string ToString()
        {
            return this.nom + " " + this.prenom + " " + this.date_premiere_commande + " "+ this.tel + " " + this.adresse;
        }
    }
}
