using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    abstract class Produits_Annexes
    {
        protected string prix;
        protected string nom;

        public Produits_Annexes(string prix, string nom)
        {
            this.prix = prix;
            this.nom = nom;
        }

        public override string ToString()
        {
            return this.prix + " " + this.nom;
        }
    }
}
