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
    /// Logique d'interaction pour EnregistrerCommis.xaml
    /// </summary>
    public partial class EnregistrerCommis : Window
    {
        ObservableCollection<Commis> listeco;
        public EnregistrerCommis(ObservableCollection<Commis> listeco)
        {
            this.listeco = listeco;
            this.DataContext = this;
            InitializeComponent();
            list3.ItemsSource = listeco;
        }

        private void AjouterCommis(object sender, RoutedEventArgs e)
        {
            string nom = cnom.Text;
            string prenom = cprenom.Text;
            string date = cdate.Text;
            string tel = ctel.Text;
            string adresse = cadresse.Text;
            Commis co = new Commis(nom, prenom, tel, adresse, date);
            listeco.Add(co);
            this.DataContext = this;
            list3.ItemsSource = listeco;
        }

        private void Changer(object sender, RoutedEventArgs e)
        {
            foreach (Object o in list3.SelectedItems)
            {
                NouveauCommis w = new NouveauCommis((Commis)o);
                w.Show();
                w.cnom.Text = ((Commis)o).Nom;
                w.cprenom.Text = ((Commis)o).Prenom;
                w.cdate.Text = ((Commis)o).Date_embauche;
                w.ctel.Text = ((Commis)o).Tel;
                w.cadresse.Text = ((Commis)o).Adresse;
            }
        }

        private void Effacer(object sender, RoutedEventArgs e)
        {
            string tel = ctel.Text;
            int n = listeco.Count;
            for (int i = 0; i < n; i++)
            {
                if (listeco[i].Tel == tel)
                {
                    listeco.RemoveAt(i);
                }
            }
        }
    }
}
