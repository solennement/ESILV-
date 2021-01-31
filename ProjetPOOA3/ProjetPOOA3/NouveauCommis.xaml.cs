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
    /// Logique d'interaction pour NouveauCommis.xaml
    /// </summary>
    public partial class NouveauCommis : Window
    {
        Commis c;
        public NouveauCommis(Commis c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            c.Nom = cnom.Text;
            c.Prenom = cprenom.Text;
            c.Date_embauche = cdate.Text;
            c.Tel = ctel.Text;
            c.Adresse = cadresse.Text;
            this.Close();
        }
    }
}
