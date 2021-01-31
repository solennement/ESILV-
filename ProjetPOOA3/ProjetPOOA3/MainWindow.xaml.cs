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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetPOOA3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ObservableCollection<Client> listec = new ObservableCollection<Client>();
        ObservableCollection<Commis> listeco = new ObservableCollection<Commis>();
        ObservableCollection<Livreur> listel = new ObservableCollection<Livreur>();
        ObservableCollection<Commande> listecom = new ObservableCollection<Commande>();
        ObservableCollection<Nourriture> listen = new ObservableCollection<Nourriture>();

        /*On crée pour chaque nouvelle fenêtre qu'on créera des listes de type observable dans le but de collecter 
         des données de manière dynamique et pouvoir les récupérer lorsqu'on quitte une fenêtre et on y revient*/
        //Nous allons détailler en particulier le programme pour un client qui sera analogue pour le livreur et le commis
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClientPage cp = new ClientPage(listec); //On crée une nouvelle fenêtre 
            cp.ShowDialog(); //On l'affiche
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LivreurPage lp = new LivreurPage(listel);
            lp.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CommisPage cop = new CommisPage(listeco);
            cop.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CommandeDirect commande = new CommandeDirect(listecom, listen);
            commande.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Statistique commande = new Statistique(listecom);
            commande.ShowDialog();
        }
    }
}
