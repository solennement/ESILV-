using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Window
    {
        ObservableCollection<Client> listec;
        public ClientPage(ObservableCollection<Client> listec)
        {
            this.listec = listec;
            this.DataContext = this;
            InitializeComponent();
            //On préserve les données si on quitte la page
        }

        private void Enregistrer(object sender, RoutedEventArgs e)
        {
            Enregistrer enr = new Enregistrer(listec); //On crée à nouveau de nouvelles pages pour accéder aux différentes données du client
            enr.ShowDialog();
        }

        private void PageRecherche(object sender, RoutedEventArgs e)
        {
            Abonne ab = new Abonne(listec);
            ab.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ParVille pv = new ParVille(listec);
            pv.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Trierl(object sender, RoutedEventArgs e)
        {
            ParLettre p = new ParLettre(listec);
            p.ShowDialog();
        }
    }
}
