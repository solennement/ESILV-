using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Livreur
    {
        private int no_de_livreur;
        private int nb_de_livreur;

        public Livreur(int no_de_livreur, int nb_de_livreur)
        {
            this.no_de_livreur = no_de_livreur;
            this.nb_de_livreur = nb_de_livreur;
        }

        public override string ToString()
        {
            return this.no_de_livreur + " " + this.nb_de_livreur;
        }

    }
}
