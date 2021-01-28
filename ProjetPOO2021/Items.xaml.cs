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
    /// Logique d'interaction pour Items.xaml
    /// </summary>
    public partial class Items : Page
    {
        public Items()
        {
            InitializeComponent();
        }

        private void EnregistrerP(object sender, RoutedEventArgs e)
        {
            string type = cnom.Text;
            string taille =ctaille.Text;
            float prix = Convert.ToInt32(cprix.Text);
            Pizza p = new Pizza(type, taille, prix);
            DataGrid.Items.Add(p);
        }

        private void EnregistrerB(object sender, RoutedEventArgs e)
        {
            string type = cnom.Text;
            float taille = Convert.ToInt32(ctaille.Text);
            float prix = Convert.ToInt32(cprix.Text);
            Boisson b= new Boisson(type, taille, prix);
            DataGrid.Items.Add(b);
        }
    }
}
