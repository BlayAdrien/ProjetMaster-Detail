using Donnee;
using Metier;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JeanBombeur
{

    public partial class App : Application
    {
        public static Restaurant Restaurant { get; private set; } = new FabriqueCategorieStub().CreateCategorie();
        public static Restaurant SauvePlat;

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
