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
    /// Logique d'interaction pour ParLettre.xaml
    /// </summary>
    public partial class ParLettre : Window
    {
        ObservableCollection<Client> listec;
        public ParLettre(ObservableCollection<Client> listec)
        {
            this.listec = listec;
            this.DataContext = this;
            InitializeComponent();
            list4.ItemsSource = listec; //On affiche la liste des abonnés
        }

        private void Trierl(object sender, RoutedEventArgs e)
        {
            Client temp = new Client();
            for (int w = 0; w < 3; w++)
            {
                for (int i = 1; i < listec.Count; i++)
                {
                    for (int j = i; j < listec.Count; j++)
                    {
                        for (int k = j; k < listec.Count; k++)
                        {
                            int n = listec[k].CompareTo(listec[k - 1]); //CompareTo compare les Nom puis les prénoms (en cas de doublons) dans l'ordre alphabétique
                            if (n == -1) //Si les deux clients ne sont pas triés
                            {
                                temp = listec[k];
                                listec[k] = listec[k - 1];
                                listec[k - 1] = temp; //On échange leur position
                            }
                        }
                    }
                }
            }
            //On réalise un algorithme de tri pour pouvoir trier dans l'ordre alphabétique les différents clients. 
            this.DataContext = this;
            list4.ItemsSource = listec; //Après modification, on réaffiche la liste triée
        }

    }
}
