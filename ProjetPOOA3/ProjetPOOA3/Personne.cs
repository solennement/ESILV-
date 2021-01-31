using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProjetPOOA3
{
    public class Personne : INotifyPropertyChanged, IComparable
    {
        string nom;
        string prenom;
        string tel;
        string adresse;
        public event PropertyChangedEventHandler PropertyChanged; //Permet de modifier les attributs d'une personne 

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; OnPropertyChanged("Nom"); } //On les rajoute dans les propriétés
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; OnPropertyChanged("Prenom"); }
        }

        public string NometPrenom
        {
            get { return this.nom + this.prenom; }
        }

        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; OnPropertyChanged("Tel"); }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; OnPropertyChanged("Adresse"); }
        }

        public Personne(string nom, string prenom, string tel, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
        }

        public Personne()
        {
            this.nom = null;
            this.prenom = null;
            this.tel = null;
            this.adresse = null;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public int CompareTo(object val)
        {
            Personne valA = (Personne)val;
            return this.NometPrenom.CompareTo(valA.NometPrenom); //On compare entre deux objets ses noms et prénoms 
        }

        public int CompareTo1(object val)
        {
            Personne valA = (Personne)val;
            return this.Adresse.CompareTo(valA.Adresse);//On compare entre deux objets sa ville
        }
    }
}
