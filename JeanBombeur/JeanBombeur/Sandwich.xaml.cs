using Metier;
using Microsoft.Win32;
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

        private void AjoutPlat(object sender, RoutedEventArgs e)
        {
            Window ajoutPlat = new AjoutPlat();
            ajoutPlat.Show();
        }

        private void Sauvegarder(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sauvegarde = new SaveFileDialog();
            if (sauvegarde.ShowDialog() == true)
            {
                Persistance.SauvegarderCategorie(sauvegarde.FileName, App.SauvePlat);
            }
        }

        private void Charger(object sender, RoutedEventArgs e)
        {
            OpenFileDialog chargement = new OpenFileDialog();
            if (chargement.ShowDialog() == true)
            {
                Persistance.ChargerCategorie(chargement.FileName);
            }
        }
    }
}

