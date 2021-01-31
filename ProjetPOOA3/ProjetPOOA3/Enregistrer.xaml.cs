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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjetPOOA3
{
    /// <summary>
    /// Logique d'interaction pour Enregistrer.xaml
    /// </summary>
    public partial class Enregistrer : Window
    {
        ObservableCollection<Client> listec;
        public Enregistrer(ObservableCollection<Client> listec)
        {
            this.listec = listec;
            this.DataContext = this;
            InitializeComponent();
            list1.ItemsSource = listec; //On rajoute les données qui ont été ajouté précédemment dans la ListView si on est partis
        }

        private void AjouteClient(object sender, RoutedEventArgs e)
        {
            string nom = tnom.Text;
            string prenom = tprenom.Text;
            string date = tdate.Text;
            string tel = ttel.Text;
            string adresse = tadresse.Text;
            //On récupère les données saisies dans les TextBox
            Client c = new Client(nom, prenom, tel, adresse, date); //On les affecte au client
            listec.Add(c);
            this.DataContext = this;
            list1.ItemsSource = listec; //On ajoute les données du client dans la ListView
        }

        private void Changer(object sender, RoutedEventArgs e)
        {
            foreach (Object o in list1.SelectedItems) //On demande à l'utilisateur de selectionner le client sur la ListView qu'il veut changer
            {
                Nouveau w = new Nouveau((Client)o);//On crée une fenêtre qui va permettre à l'utilisateur de changer ses données
                w.Show();
                w.nomPersonne.Text = ((Client)o).Nom;
                w.prenomPersonne.Text = ((Client)o).Prenom;
                w.date.Text = ((Client)o).Date_premiere_commande;
                w.tel.Text = ((Client)o).Tel;
                w.adresse.Text = ((Client)o).Adresse;
                //On affecte aux nouveaux noms saisis dans la nouvelle fenêtre leur nouvelles valeurs
            }
        }

        private void Effacer(object sender, RoutedEventArgs e)
        {
            string tel = ttel.Text; //On enregistre le numéro rechercher
            int n = listec.Count;
            for (int i=0;i<n;i++) //On parcours la liste des clients
            {
                if (listec[i].Tel == tel)
                {
                    listec.RemoveAt(i); //On supprime le client qui correspond au numéro saisi
                }
            }
        }
    }
}
