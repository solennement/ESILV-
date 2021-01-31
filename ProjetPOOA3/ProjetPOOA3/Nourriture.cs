using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOOA3
{
   public class Nourriture
    {
        string type;
        string taille;
        float prix;

        public string Type
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
            set { this.prix = value; }
        }

        public Nourriture(string type, string taille, float prix)
        {
            this.type = type;
            this.taille = taille;
            this.Prix = prix;
        }
    }
}
