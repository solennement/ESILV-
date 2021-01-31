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
    /// Logique d'interaction pour Commande.xaml
    /// </summary>
    public partial class CommandeDirect : Window
    {
        ObservableCollection<Commande> listeco;
        ObservableCollection<Nourriture> listen;
        public CommandeDirect(ObservableCollection<Commande> listeco, ObservableCollection<Nourriture> listen)
        {
            this.listeco = listeco;
            this.listen = listen;
            this.DataContext = this;
            InitializeComponent(); //On sauvegarde les listes nourritures et commandes qui ont été enregistrés
        }


        private void NouvelleCommande(object sender, RoutedEventArgs e)
        {
            NouvelleCommande no = new NouvelleCommande(listeco,listen); //On ouvre une page pour commander
            no.ShowDialog();
        }

        private void EnCours(object sender, RoutedEventArgs e)
        {
            CommandeEnCours en = new CommandeEnCours(listeco);
            en.ShowDialog();
        }
    }
}
