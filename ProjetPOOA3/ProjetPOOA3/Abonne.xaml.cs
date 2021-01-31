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
    /// Logique d'interaction pour Abonne.xaml
    /// </summary>
    public partial class Abonne : Window
    {
        ObservableCollection<Client> listec;
        ObservableCollection<Client> listecrechercher =new ObservableCollection<Client>(); //On crée une liste rechercher pour trouver l'abonné
         public Abonne(ObservableCollection<Client> listec) 
        {
            this.listec = listec;
            foreach (Client c in listec)
                listecrechercher.Add(c); //Ajouter initialement tous les abonnées 
            this.DataContext = this;
            InitializeComponent();
            list1.ItemsSource = listecrechercher; //Afficher tous les abonnés
        }

        private void RechercherClient(object sender, RoutedEventArgs e)
        {
            string tel = ttel.Text;
            listecrechercher = new ObservableCollection<Client>();
            foreach(Client c in listec) //On parcours la liste des clients enregistrés 
            {
                if(c.Tel==tel) //Si le numéro rechercher correspond à un client
                {
                    listecrechercher.Add(c); //On ajoute ce client à une liste rechercher
                }
            }
            this.DataContext = this;
            list1.ItemsSource = listecrechercher; //On affiche ce client unique présent dans la liste rechercher dans la ListView
        }
    }
}
