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
    /// Logique d'interaction pour Categorie.xaml
    /// </summary>
    public partial class Categorie : Page
    {
        public Restaurant Selection { get ; set; }
        public ListView ListViewFiltre { get; set; }


        public Categorie()
        {
            InitializeComponent();
        }

        private void Filtrage(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "Sandwich":
                    ListViewFiltre.ItemsSource = Selection.ListPlatFiltre("Sandwich", null);
                    break;
                case "Pizza":
                    ListViewFiltre.ItemsSource = Selection.ListPlatFiltre("Pizza", null);
                    break;
                case "Hamburger":
                    ListViewFiltre.ItemsSource = Selection.ListPlatFiltre("Hamburger", null);
                    break;
            }
        }

    }
}



/* 
        private void Sandwich(object sender, RoutedEventArgs e)
        {
            Sandwich s = new Sandwich();
            this.NavigationService.Navigate(s);
        }

        private void Pizza(object sender, RoutedEventArgs e)
        {
            Pizza p = new Pizza();
            this.NavigationService.Navigate(p);
        }

        private void Hamburger(object sender, RoutedEventArgs e)
        {
            Hamburger t = new Hamburger();
            this.NavigationService.Navigate(t);
        } */
