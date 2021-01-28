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
    /// Logique d'interaction pour CommandeClient.xaml
    /// </summary>
    public partial class CommandeClient : Page
    {
        public CommandeClient()
        {
            InitializeComponent();
        }

        private void NouvelleCommande(object sender, RoutedEventArgs e)
        {
            Main.Content = new NouvelleCommande();
        }

        private void EnCours(object sender, RoutedEventArgs e)
        {
            Main.Content = new EnCours();
        }
    }
}
