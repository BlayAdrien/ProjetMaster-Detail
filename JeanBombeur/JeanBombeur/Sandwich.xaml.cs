using Metier;
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
    /// Logique d'interaction pour Sandwich.xaml
    /// </summary>
    public partial class Sandwich : Page
    {

        public Sandwich()
        {
            InitializeComponent();
        }

        private void Accueil(object sender, RoutedEventArgs e)
        {
            Categorie c = new Categorie();
            this.NavigationService.Navigate(c);
        }
        private void Panier(object sender, RoutedEventArgs e)
        {
            Panier pa = new Panier();
            this.NavigationService.Navigate(pa);
        }

        private void AjoutPlat(object sender, RoutedEventArgs e)
        {
            Window ajoutPlat = new AjoutPlat();
            ajoutPlat.Show();
        }

    }
}

