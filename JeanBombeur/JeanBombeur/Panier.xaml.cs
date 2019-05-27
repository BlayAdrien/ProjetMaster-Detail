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

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour Panier.xaml
    /// </summary>
    public partial class Panier : Page
    {
        public Panier()
        {
            InitializeComponent();
        }

        private void Categorie(object sender, RoutedEventArgs e)
        {
            Categorie c = new Categorie();
            this.NavigationService.Navigate(c);
        }
    }
}
