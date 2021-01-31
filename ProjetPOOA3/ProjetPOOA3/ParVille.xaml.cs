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
    /// Logique d'interaction pour ParVille.xaml
    /// </summary>
    public partial class ParVille : Window
    {
        ObservableCollection<Client> listec;
        public ParVille(ObservableCollection<Client> listec)
        {
            this.listec = listec;
            this.DataContext = this;
            InitializeComponent();
            list5.ItemsSource = listec;
        }

        private void Trierv(object sender, RoutedEventArgs e)
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
                            int n = listec[k].CompareTo1(listec[k - 1]);
                            if (n == -1)
                            {
                                temp = listec[k];
                                listec[k] = listec[k - 1];
                                listec[k - 1] = temp;
                            }
                        }
                    }
                }
            }
            this.DataContext = this;
            list5.ItemsSource = listec;
        }
    }
}
