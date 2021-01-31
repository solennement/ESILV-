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
using System.Windows.Shapes;

namespace ProjetPOOA3
{
    /// <summary>
    /// Logique d'interaction pour NouveauCommande.xaml
    /// </summary>
    public partial class NouveauCommande : Window
    {
        Commande co;
        public NouveauCommande(Commande co)
        {
            InitializeComponent();
            this.co = co;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            co.Numero = num.Text;
            co.Date = date.Text;
            co.Heure = heure.Text;
            co.Nomc = nomc.Text;
            co.Nomcl = nomcl.Text;
            this.Close();
        }
    }
}
