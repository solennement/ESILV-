using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOOA3
{
    public class Commande : IPerte, INotifyPropertyChanged
    {
        string no_de_commande;
        string date;
        string heure;
        ObservableCollection<Nourriture> listen; 
        string nom_commis;
        string nom_client;
        string livraison;
        string etat;
        int nb_commande_effectuee;
        public event PropertyChangedEventHandler PropertyChanged;


        public string Numero
        {
            get { return this.no_de_commande; }
            set { this.no_de_commande = value; OnPropertyChanged("Numero"); }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; OnPropertyChanged("Date"); }
        }

        public string Heure
        {
            get { return this.heure; }
            set { this.heure = value; OnPropertyChanged("Heure"); }
        }

        public ObservableCollection<Nourriture> Nourriture
        {
            get { return this.listen; }
            set { this.listen = value; }
        }

        public string Nomc
        {
            get { return this.nom_commis; }
            set { this.nom_commis = value; OnPropertyChanged("Nomc"); }
        }

        public string Nomcl
        {
            get { return this.nom_client; }
            set { this.nom_client = value; OnPropertyChanged("Nomcl"); }
        }

        public string Livraison
        {
            get { return this.livraison; }
            set { this.livraison = value; OnPropertyChanged("Livraison"); }
        }

        public string Etat
        {
            get { return this.etat; }
            set { this.etat = value; OnPropertyChanged("Etat"); }
        }
        public Commande(string no_de_commande, string date, string heure, ObservableCollection<Nourriture> listen, string nom_commis, string nom_client)
        {
            this.no_de_commande = no_de_commande;
            this.date = date;
            this.heure = heure;
            this.listen=listen;
            this.nom_commis = nom_commis;
            this.nom_client = nom_client;
        }

        public Commande()
        {
            this.no_de_commande = null;
            this.date = null;
            this.heure = null;
            this.listen = null;
            this.nom_commis = null;
            this.nom_client = null;
        }

        public bool EstPerte() 
        {
            return true;
        }

        public override string ToString()
        {
            string liste = "";
            float somme = 0;
            foreach(Nourriture n in listen) //On parcours les items dans la liste
            {
                liste+= n.Type + " " + n.Taille + " " + n.Prix + " euros" + "\n"; //On donne les caractéristiques de chacune
            }
            for (int i = 0; i < listen.Count; i++)
            {
                somme += listen[i].Prix; //On calcule le prix total de la commande
            }
            return liste + "Le prix de la commande coûte : " + somme + " euros";
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public int CommandeEffectuee
        {
            get { return this.nb_commande_effectuee; }
            set { this.nb_commande_effectuee = value; OnPropertyChanged("CommandeEffectuee"); }
        }
    }
}
