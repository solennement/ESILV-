using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPOO
{
    class Pizza
    {
        string type;
        string taille;

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
