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
    /// Logique d'interaction pour TypePlat.xaml
    /// </summary>
    public partial class UC_TypePlat : UserControl
    {
        public Restaurant Restaurant { get; private set; } = App.Restaurant;
  
        public UC_TypePlat()
        {
            InitializeComponent();
            listPlat.DataContext = Restaurant;
            DataContext = this;
        }

        private void Notes(object sender, RoutedEventArgs e)
        {

        }
    }
}
