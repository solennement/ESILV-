using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Pizza
    {
        string type;
        string taille;
        float prix;

        public string Nom
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Taille
        {
            get { return this.taille; }
            set { this.taille = value; }
        }

        public float Prix
        {
            get { return this.prix; }
            set { this.prix= value; }
        }

        public Pizza(string type, string taille, float prix)
        {
            this.type = type;
            this.taille = taille;
            this.Prix = prix;
        }

    }
}
