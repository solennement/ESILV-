using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Boisson : Produits_Annexes
    {
        private float volume;

        public Boisson(string prix, string nom, float volume): base(prix, nom)
        {
            this.volume = volume;
        }

        public override string ToString()
        {
            return this.volume + " ";
        }
    }
}
