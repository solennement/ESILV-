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
    /// Logique d'interaction pour NouvelleCommande.xaml
    /// </summary>
    public partial class NouvelleCommande : Window
    {
        ObservableCollection<Commande> listeco;
        ObservableCollection<Nourriture> listen;
        public NouvelleCommande(ObservableCollection<Commande> listeco, ObservableCollection<Nourriture> listen)
        {
            this.listeco = listeco;
            this.listen = listen;
            this.DataContext = this;
            InitializeComponent();
            list6.ItemsSource = listeco; //Rajoute les commandes précédemment enregistrés 
        }

        private void EnregistrerP(object sender, RoutedEventArgs e)
        {
            string type = cnom.Text;
            string taille = ctaille.Text;
            float prix = Convert.ToInt32(cprix.Text); //Récupère les informations concernant un item
            Nourriture n= new Nourriture(type, taille, prix); //L'ajoute dans l'objet nourriture
            listen.Add(n); //Le stocke dans la liste de la commande
            this.DataContext = this;
        }

        private void AjouterClient(object sender, RoutedEventArgs e)
        {
            string num = cnum.Text;
            string date = cdate.Text;
            string heure = cheure.Text;
            string nomc = cnomc.Text;
            string nomcl = cnomcl.Text;
            Commande c = new Commande(num, date, heure, listen, nomc, nomcl); //Crée une nouvelle commande
            listeco.Add(c);
            this.DataContext = this;
            list6.ItemsSource = listeco;
        }

        private void FinaliserCommande(object sender, RoutedEventArgs e)
        {
            listen = new ObservableCollection<Nourriture>(); //Si tous les items ont été ajouté à la commande, alors on appuie sur ce bouton pour initialiser une nouvelle liste de nourriture 
        }

        private void Montrer(object sender, RoutedEventArgs e)
        {
            foreach (Commande c in list6.SelectedItems) //Pour la commande sélectionnée
            {
                string resul = c.ToString(); //Concerne les caractéristiques de la nourriture de la commande et son prix final
                MessageBox.Show(resul); //On affiche dans une fenêtre la liste de nourriture associé à la commande
            }
        }

        private void Changer(object sender, RoutedEventArgs e)
        {
            foreach (Object o in list6.SelectedItems) //Voir description catégorie client
            {
                NouveauCommande w = new NouveauCommande((Commande)o);
                w.Show();
                w.num.Text = ((Commande)o).Numero;
                w.date.Text = ((Commande)o).Date;
                w.heure.Text = ((Commande)o).Heure;
                w.nomc.Text = ((Commande)o).Nomc;
                w.nomcl.Text = ((Commande)o).Nomcl;
            }
        }
    }
}
