using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOOA3
{
    public class Livreur : Personne
    {
        string moyen_transport;

        public Livreur(string nom, string prenom, string tel, string adresse, string moyen_transport) : base(nom, prenom, tel, adresse)
        {
            this.moyen_transport = moyen_transport;
        }

        public string Moyen_transport
        {
            get { return this.moyen_transport; }
            set { this.moyen_transport = value; OnPropertyChanged("Moyen_transport"); }
        }
    }
}
