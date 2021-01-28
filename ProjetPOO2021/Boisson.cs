using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Boisson : Produits_Annexes
    {
        float volume;

        public Boisson(string nom, float volume, float prix) : base(prix, nom)
        {
            this.volume = volume;
        }

        public float Taille
        {
            get { return this.volume; }
            set { this.volume = value; }
        }
    }
}
