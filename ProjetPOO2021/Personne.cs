using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Personne
    {
        string nom;
        string prenom;
        string tel;
        string adresse;

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public Personne(string nom, string prenom, string tel, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
        }


    }
}
