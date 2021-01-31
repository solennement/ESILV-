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
    /// Logique d'interaction pour NouveauLivreur.xaml
    /// </summary>
    public partial class NouveauLivreur : Window
    {
        Livreur l;
        public NouveauLivreur(Livreur l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            l.Nom = lnom.Text;
            l.Prenom = lprenom.Text;
            l.Moyen_transport = lmoy.Text;
            l.Tel= ltel.Text;
            l.Adresse = ladresse.Text;
            this.Close();
        }
    }
}
