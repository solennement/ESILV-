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
    /// Logique d'interaction pour Clientpage.xaml
    /// </summary>
    public partial class Clientpage : Page
    {
        public Clientpage()
        {
            InitializeComponent();
        }

        private void Enregistrer(object sender, RoutedEventArgs e)
        {
            Main.Content = new EnregistrementClient();
        }

        private void PageRecherche(object sender, RoutedEventArgs e)
        {
            Main.Content = new RechercheClient();
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            Main.Content = new ModificationClient();
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            Main.Content = new SuppressionClient();
        }
    }
}
