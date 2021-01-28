﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalPoo
{
    class Commis : Personne
    {
        string date_embauche;

        public Commis(string nom, string prenom,string tel, string adresse, string date_embauche): base(nom, prenom, tel, adresse)
        {
            this.date_embauche = date_embauche;
        }

        public string Date_embauche
        {
            get { return this.date_embauche; }
            set { this.date_embauche = value; }
        }
    }
}
