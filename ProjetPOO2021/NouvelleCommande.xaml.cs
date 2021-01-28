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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetFinalPoo
{
    /// <summary>
    /// Logique d'interaction pour NouvelleCommande.xaml
    /// </summary>
    public partial class NouvelleCommande : Page
    {
        public NouvelleCommande()
        {
            InitializeComponent();
        }


        //private void AjouterCommande(object sender, RoutedEventArgs e)
        //{
        //    string num = cnum.Text;
        //    string date = cdate.Text;
        //    string heure = cheure.Text;
        //    string nomc = cnomc.Text;
        //    string nomcl = cnomcl.Text;
        //}

        private void Enregistrer(object sender, RoutedEventArgs e)
        {
            Main.Content = new Items();
        }
    }
}
