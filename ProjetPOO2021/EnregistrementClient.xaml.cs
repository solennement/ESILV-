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
    /// Logique d'interaction pour EnregistrementClient.xaml
    /// </summary>
    public partial class EnregistrementClient : Page
    {
        public EnregistrementClient()
        {
            InitializeComponent();
        }

        List<Client> listec = new List<Client>();

        private void AjouterClient(object sender, RoutedEventArgs e)
        {
            string nom = tnom.Text;
            string prenom = tprenom.Text;
            string date = tdate.Text;
            string tel = ttel.Text;
            string adresse = tadresse.Text;
            Client c = new Client(nom, prenom, tel, adresse, date);
            listec.Add(c);
            DataGrid.Items.Add(c);
        }
    }
}
