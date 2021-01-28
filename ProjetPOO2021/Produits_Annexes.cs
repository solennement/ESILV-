using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    abstract class Produits_Annexes
    {
        float prix;
        string nom;

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public float Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public Produits_Annexes(float prix, string nom)
        {
            this.prix = prix;
            this.nom = nom;
        }

    }
}
