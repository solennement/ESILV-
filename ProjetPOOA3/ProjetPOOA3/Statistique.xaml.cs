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
    /// Logique d'interaction pour Statistique.xaml
    /// </summary>
    public partial class Statistique : Window
    {
        ObservableCollection<Commande> listeco;
        Commande c=new Commande();
        ObservableCollection<Commande> commandecommis = new ObservableCollection<Commande>();
        public Statistique(ObservableCollection<Commande>  listeco)
        {
            this.listeco = listeco;
            this.DataContext = this;
            InitializeComponent();
            list7.ItemsSource = listeco;
        }

        private void Afficher(object sender, RoutedEventArgs e)
        {
            string nom = ccom.Text;
            int somme = 0;
            foreach(Commande c in listeco)
            {
                if(c.Nomc==nom)
                {
                    somme += 1; //On ajoute 1 à chaque fois qu'on trouve le nom du commis dans une commande
                }
            }
            c.CommandeEffectuee = somme; //On met dans un nouvel objet commande le nombre de fois qu'il a trouvé le nom du commis dans une commande
            commandecommis.Add(c);
            list7.ItemsSource = commandecommis; //On actualise 
        }
    }
}
