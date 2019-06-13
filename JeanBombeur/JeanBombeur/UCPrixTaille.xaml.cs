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
using Metier;

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour UCPrixTaille.xaml
    /// </summary>
    public partial class UCPrixTaille : UserControl
    {
        
        public UCPrixTaille()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty TailleProperty = DependencyProperty.Register("Taille", typeof(string), typeof(UCPrixTaille));
        public static readonly DependencyProperty PrixPlatProperty = DependencyProperty.Register("PrixPlat",typeof(float), typeof(UCPrixTaille));

        

        public string Taille
        {
            get
            {
                return (string)GetValue(TailleProperty);
            }
            set
            {
                SetValue(TailleProperty, value);
            }
        }

        public float PrixPlat
        {
            get
            {
                return (float)GetValue(PrixPlatProperty);
            }
            set
            {
                SetValue(PrixPlatProperty, value);
            }
        }
    }
}
