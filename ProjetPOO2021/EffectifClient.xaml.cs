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
    /// Logique d'interaction pour EffectifClient.xaml
    /// </summary>
    public partial class EffectifClient : Page
    {
        public EffectifClient()
        {
            InitializeComponent();
        }

        private void Client(object sender, RoutedEventArgs e)
        {
            Main.Content = new Clientpage();
        }

        private void Livreur(object sender, RoutedEventArgs e)
        {
            Main.Content = new LivreurPage();
        }

        private void Commis(object sender, RoutedEventArgs e)
        {
            Main.Content = new CommisPage();
        }
    }
}
