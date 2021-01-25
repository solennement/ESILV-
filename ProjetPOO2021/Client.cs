using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProjetPOO
{
    class Client : INotifyPropertyChanged
    {
        string nom;
        string prenom;
        DateTime date_premiere_commande;
        string tel;
        string adresse;
        public event PropertyChangedEventHandler PropertyChanged;

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

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }



    }
}
