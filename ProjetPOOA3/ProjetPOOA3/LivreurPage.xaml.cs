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
    /// Logique d'interaction pour LivreurPage.xaml
    /// </summary>
    public partial class LivreurPage : Window
    {
        ObservableCollection<Livreur> listel;
        public LivreurPage(ObservableCollection<Livreur> listel)
        {
            this.listel = listel;
            this.DataContext = this;
            InitializeComponent();
        }

        private void EnregisterLiv(object sender, RoutedEventArgs e)
        {
            EnregistrerLivreur enr = new EnregistrerLivreur(listel);
            enr.ShowDialog();
        }
    }
}
