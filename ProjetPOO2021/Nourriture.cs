using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Nourriture
    {
        private List<Pizza> liste_p;
        private List<Produits_Annexes> liste_a;

        public Nourriture(List<Pizza> liste_p, List<Produits_Annexes> liste_a)
        {
            this.liste_p = liste_p;
            this.liste_a = liste_a;
        }

        public override string ToString()
        {
            string liste = "";
            foreach(Pizza p in liste_p)
            {
                liste += p + " ";
            }
            foreach(Produits_Annexes a in liste_a)
            {
                liste += a + " ";
            }
            return liste;
        }
    }
}
