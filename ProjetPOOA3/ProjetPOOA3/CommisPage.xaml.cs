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
    /// Logique d'interaction pour CommisPage.xaml
    /// </summary>
    public partial class CommisPage : Window
    {
        ObservableCollection<Commis> listeco;
        public CommisPage(ObservableCollection<Commis> listeco)
        {
            this.listeco = listeco;
            this.DataContext = this;
            InitializeComponent();
        }

        private void OuvrirCommis(object sender, RoutedEventArgs e)
        {
            EnregistrerCommis enr = new EnregistrerCommis(listeco);
            enr.ShowDialog();
        }
    }
}
