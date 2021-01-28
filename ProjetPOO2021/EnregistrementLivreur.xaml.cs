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

namespace ProjetFinalPoo
{
    /// <summary>
    /// Logique d'interaction pour EnregistrementLivreur.xaml
    /// </summary>
    public partial class EnregistrementLivreur : Page
    {
        public EnregistrementLivreur()
        {
            InitializeComponent();
        }

        List<Livreur> listel = new List<Livreur>();

        private void AjouterLivreur(object sender, RoutedEventArgs e)
        {
            string nom = lnom.Text;
            string prenom = lprenom.Text;
            string moyen = lmoyen.Text;
            string tel = ltel.Text;
            string adresse = ladresse.Text;
            Livreur li = new Livreur(nom, prenom, tel, adresse, moyen);
            listel.Add(li);
            DataGrid.Items.Add(li);
        }
    }
}
