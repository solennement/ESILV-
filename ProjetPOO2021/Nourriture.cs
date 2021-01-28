using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Nourriture
    {
        List<Pizza> liste_p;
        List<Produits_Annexes> liste_a;

        public Nourriture(List<Pizza> liste_p, List<Produits_Annexes> liste_a)
        {
            this.liste_p = liste_p;
            this.liste_a = liste_a;
        }

    }
}
