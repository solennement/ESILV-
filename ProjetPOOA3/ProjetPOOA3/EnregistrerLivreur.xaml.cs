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
    /// Logique d'interaction pour EnregistrerLivreur.xaml
    /// </summary>
    public partial class EnregistrerLivreur : Window
    {
        ObservableCollection<Livreur> listel;
        public EnregistrerLivreur(ObservableCollection<Livreur> listel)
        {
            this.listel = listel;
            this.DataContext = this;
            InitializeComponent();
            list2.ItemsSource = listel;
        }
        private void AjouterLivreur(object sender, RoutedEventArgs e)
        {
            string nom = lnom.Text;
            string prenom = lprenom.Text;
            string moyen = lmoyen.Text;
            string tel = ltel.Text;
            string adresse = ladresse.Text;
            Livreur li = new Livreur(nom, prenom, tel, adresse, moyen);
            listel.Add(li);
            this.DataContext = this;
            list2.ItemsSource = listel;
        }

        private void Changer(object sender, RoutedEventArgs e)
        {
            foreach (Object o in list2.SelectedItems)
            {
                NouveauLivreur w = new NouveauLivreur((Livreur)o);
                w.Show();
                w.lnom.Text = ((Livreur)o).Nom;
                w.lprenom.Text = ((Livreur)o).Prenom;
                w.lmoy.Text = ((Livreur)o).Moyen_transport;
                w.ltel.Text = ((Livreur)o).Tel;
                w.ladresse.Text = ((Livreur)o).Adresse;
            }
        }

        private void Effacer(object sender, RoutedEventArgs e)
        {
            string tel = ltel.Text;
            int n = listel.Count;
            for (int i = 0; i < n; i++)
            {
                if (listel[i].Tel == tel)
                {
                    listel.RemoveAt(i);
                }
            }
        }

    }
}
