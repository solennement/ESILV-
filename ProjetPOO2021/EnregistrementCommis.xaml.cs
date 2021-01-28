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
    /// Logique d'interaction pour EnregistrementCommis.xaml
    /// </summary>
    public partial class EnregistrementCommis : Page
    {
        public EnregistrementCommis()
        {
            InitializeComponent();
        }

        List<Commis> listeco = new List<Commis>();

        private void AjouterCommis(object sender, RoutedEventArgs e)
        {
            string nom = cnom.Text;
            string prenom = cprenom.Text;
            string date = cdate.Text;
            string tel = ctel.Text;
            string adresse = cadresse.Text;
            Commis co = new Commis(nom, prenom, tel, adresse, date);
            listeco.Add(co);
            DataGrid.Items.Add(co);
        }
    }
}
