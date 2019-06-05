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
        }

        public static readonly DependencyProperty Taille;
        public static readonly DependencyProperty Prix;

        static UCPrixTaille()
        {
            UCPrixTaille.Taille = DependencyProperty.Register("Taille",
                typeof(string), typeof(UCPrixTaille),
                new PropertyMetadata("Default"));
            UCPrixTaille.Prix = DependencyProperty.Register("PrixPlat",
                typeof(float), typeof(UCPrixTaille),
                new PropertyMetadata("PrixPlat"));
        }

        public string TaillePlat
        {
            get
            {
                return GetValue(UCPrixTaille.Taille) as string;
            }
            set
            {
                SetValue(UCPrixTaille.Taille, value);
            }
        }

        public float PrixPlat
        {
            get
            {
                return (float)GetValue(UCPrixTaille.Prix);
            }
            set
            {
                SetValue(UCPrixTaille.Prix, value);
            }
        }
    }
}
