using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO2021
{
    class Pizza
    {
        private string type;
        private string taille;

        public Pizza(string type, string taille)
        {
            this.type = type;
            this.taille = taille;
        }

        public override string ToString()
        {
            return this.type + " " + this.taille;
        }
    }
}
