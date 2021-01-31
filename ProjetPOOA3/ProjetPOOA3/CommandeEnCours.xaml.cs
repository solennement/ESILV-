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
    /// Logique d'interaction pour CommandeEnCours.xaml
    /// </summary>
    public partial class CommandeEnCours : Window
    {
        ObservableCollection<Commande> listeco;
        public CommandeEnCours(ObservableCollection<Commande> listeco)
        {
            this.listeco = listeco;
            this.DataContext = this;
            InitializeComponent();
            list7.ItemsSource = listeco;
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            string num = nco.Text; //On enregistre le numéro rechercher
            int n = listeco.Count;
            for (int i = 0; i < n; i++) //On parcours la liste des commandes
            {
                if (listeco[i].Numero == num)
                {
                    listeco[i].Livraison = "Fermée"; //On affecte l'étape de la livraison à la commande correspondante
                }
            }
        }

        private void Livraison(object sender, RoutedEventArgs e)
        {
            string num = nco.Text; 
            int n = listeco.Count;
            for (int i = 0; i < n; i++) 
            {
                if (listeco[i].Numero == num)
                {
                    listeco[i].Livraison = "En livraison"; 
                }
            }
        }

        private void Preparation(object sender, RoutedEventArgs e)
        {
            string num = nco.Text; 
            int n = listeco.Count;
            for (int i = 0; i < n; i++) 
            {
                if (listeco[i].Numero == num)
                {
                    listeco[i].Livraison = "En préparation"; 
                }
            }
        }

        private void Perte(object sender, RoutedEventArgs e)
        {
            string num = nco.Text; 
            int n = listeco.Count;
            for (int i = 0; i < n; i++) 
            {
                if (listeco[i].Numero == num)
                {
                    listeco[i].Etat = "A perte"; 
                }
            }
        }

        private void Encaisse(object sender, RoutedEventArgs e)
        {
            string num = nco.Text; 
            int n = listeco.Count;
            for (int i = 0; i < n; i++) 
            {
                if (listeco[i].Numero == num)
                {
                    listeco[i].Etat = "Encaissée";
                }
            }
        }
    }
}
