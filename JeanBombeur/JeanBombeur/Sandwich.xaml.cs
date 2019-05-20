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
        public Restaurant Restaurant { get; private set; } = App.Restaurant;

        public Sandwich()
        {
            InitializeComponent();
            listPlat.DataContext = Restaurant;
            DataContext = this;
        }

        private void Accueil(object sender, RoutedEventArgs e)
        {
            Categorie c = new Categorie();
            this.NavigationService.Navigate(c);
        }
    }
}

