using Metier;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour AjoutPlat.xaml
    /// </summary>
    public partial class AjoutPlat : Window
    {
        private Restaurant selection = new Restaurant();
        public Restaurant Selection
        {
            get
            {
                return selection;
            }
            
        }

        Plat r = new Plat();

        public AjoutPlat()
        {
            InitializeComponent();
            ajoutPlat.DataContext = r;

            AjoutIngredient(null, null);
            AjoutIngredient(null, null);
            AjoutIngredient(null, null);
        }

        private void AjoutImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == true)
            {
                string source = o.FileName;
                if (o.FileName != source)
                {
                    File.Copy(o.FileName, source);
                }
                r.Image = source;
            }
        }

        private void AjoutIngredient(object sender, RoutedEventArgs e)
        {
            Ingredient i = new Ingredient();
            r.AjouterIngredient(i);

            AjoutIngredient a = new AjoutIngredient();
            a.DataContext = i;
            AjoutIng.Items.Add(a);
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            Selection.ValiderPlat(r);
            // MessageBox.Show("Recette ajoutée avec succès!");
            this.Close();
        }
    }
}
