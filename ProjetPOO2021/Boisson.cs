using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO
{
    class Boisson : Produits_Annexes
    {
        float volume;

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
