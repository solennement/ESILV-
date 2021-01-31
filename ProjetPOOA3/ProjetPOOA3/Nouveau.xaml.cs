using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetPOOA3
{
    /// <summary>
    /// Logique d'interaction pour Nouveau.xaml
    /// </summary>
    public partial class Nouveau : Window
    {
        Client c;
        public Nouveau(Client c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            c.Nom = nomPersonne.Text;
            c.Prenom = prenomPersonne.Text;
            c.Date_premiere_commande = date.Text;
            c.Tel = tel.Text;
            c.Adresse = adresse.Text;
            //On donne au client ses nouvelles valeurs saisis
            this.Close();
        }
    }
}
