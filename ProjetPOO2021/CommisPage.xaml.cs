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
    /// Logique d'interaction pour CommisPage.xaml
    /// </summary>
    public partial class CommisPage : Page
    {
        public CommisPage()
        {
            InitializeComponent();
        }

        private void Enregistrer(object sender, RoutedEventArgs e)
        {
            Main.Content = new EnregistrementCommis();
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            Main.Content = new SuppressionCommis();
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            Main.Content = new ModificationCommis();
        }

    }
}
